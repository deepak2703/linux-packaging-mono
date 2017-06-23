// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
    /// <summary>
    /// Represents a dynamic property access in C#, providing the binding semantics and the details about the operation. 
    /// Instances of this class are generated by the C# compiler.
    /// </summary>
    internal sealed class CSharpSetMemberBinder : SetMemberBinder, ICSharpBinder
    {
        public BindingFlag BindingFlags => 0;

        public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
            => runtimeBinder.BindAssignment(this, arguments, locals);

        public void PopulateSymbolTableWithName(SymbolTable symbolTable, Type callingType, ArgumentObject[] arguments)
            => symbolTable.PopulateSymbolTableWithName(Name, null, arguments[0].Type);

        public bool IsBinderThatCanHaveRefReceiver => false;

        internal bool IsCompoundAssignment { get; }

        public bool IsChecked { get; }

        public Type CallingContext { get; }

        private readonly List<CSharpArgumentInfo> _argumentInfo;

        CSharpArgumentInfo ICSharpBinder.GetArgumentInfo(int index) => _argumentInfo[index];

        private readonly RuntimeBinder _binder;

        //////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Initializes a new instance of the <see cref="SetMemberBinder" />.
        /// </summary>
        /// <param name="name">The name of the member to get.</param>
        /// <param name="isCompoundAssignment">True if the assignment comes from a compound assignment in source.</param>
        /// <param name="isChecked">True if the operation is defined in a checked context; otherwise, false.</param>
        /// <param name="callingContext">The <see cref="Type"/> that indicates where this operation is defined.</param>
        /// <param name="argumentInfo">The sequence of <see cref="CSharpArgumentInfo"/> instances for the arguments to this operation.</param>
        public CSharpSetMemberBinder(
            string name,
            bool isCompoundAssignment,
            bool isChecked,
            Type callingContext,
            IEnumerable<CSharpArgumentInfo> argumentInfo) :
            base(name, false)
        {
            IsCompoundAssignment = isCompoundAssignment;
            IsChecked = isChecked;
            CallingContext = callingContext;
            _argumentInfo = BinderHelper.ToList(argumentInfo);
            _binder = RuntimeBinder.GetInstance();
        }

        /// <summary>
        /// Performs the binding of the dynamic set member operation if the target dynamic object cannot bind.
        /// </summary>
        /// <param name="target">The target of the dynamic set member operation.</param>
        /// <param name="value">The value to set to the member.</param>
        /// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
        /// <returns>The <see cref="DynamicMetaObject"/> representing the result of the binding.</returns>
        public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
        {
#if ENABLECOMBINDER
            DynamicMetaObject com;
            if (!BinderHelper.IsWindowsRuntimeObject(target) && ComBinder.TryBindSetMember(this, target, value, out com))
            {
                return com;
            }
#endif
            return BinderHelper.Bind(this, _binder, new[] { target, value }, _argumentInfo, errorSuggestion);
        }
    }
}

//
// This file was generated by txt2sr tool
//

partial class SR
{
	public const string ArgumentOutOfRange_NeedNonNegNum = "Non negative number is required.";
	public const string Argument_WrongAsyncResult = "IAsyncResult object did not come from the corresponding async method on this type.";
	public const string Argument_InvalidOffLen = "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";
	public const string Argument_NeedNonemptyPipeName = "pipeName cannot be an empty string.";
	public const string Argument_EmptyServerName = "serverName cannot be an empty string.  Use \".\" for current machine.";
	public const string Argument_NonContainerInvalidAnyFlag = "This flag may not be set on a pipe.";
	public const string Argument_InvalidHandle = "Invalid handle.";
	public const string ArgumentNull_Buffer = "Buffer cannot be null.";
	public const string ArgumentNull_ServerName = "serverName cannot be null. Use \".\" for current machine.";
	public const string ArgumentOutOfRange_AdditionalAccessLimited = "additionalAccessRights is limited to the PipeAccessRights.ChangePermissions, PipeAccessRights.TakeOwnership, and PipeAccessRights.AccessSystemSecurity flags when creating NamedPipeServerStreams.";
	public const string ArgumentOutOfRange_AnonymousReserved = "The pipeName \"anonymous\" is reserved.";
	public const string ArgumentOutOfRange_TransmissionModeByteOrMsg = "For named pipes, transmission mode can be TransmissionMode.Byte or PipeTransmissionMode.Message. For anonymous pipes, transmission mode can be TransmissionMode.Byte.";
	public const string ArgumentOutOfRange_DirectionModeInOrOut = "PipeDirection.In or PipeDirection.Out required.";
	public const string ArgumentOutOfRange_DirectionModeInOutOrInOut = "For named pipes, the pipe direction can be PipeDirection.In, PipeDirection.Out or PipeDirection.InOut. For anonymous pipes, the pipe direction can be PipeDirection.In or PipeDirection.Out.";
	public const string ArgumentOutOfRange_ImpersonationInvalid = "TokenImpersonationLevel.None, TokenImpersonationLevel.Anonymous, TokenImpersonationLevel.Identification, TokenImpersonationLevel.Impersonation or TokenImpersonationLevel.Delegation required.";
	public const string ArgumentOutOfRange_ImpersonationOptionsInvalid = "impersonationOptions contains an invalid flag.";
	public const string ArgumentOutOfRange_OptionsInvalid = "options contains an invalid flag.";
	public const string ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable = "HandleInheritability.None or HandleInheritability.Inheritable required.";
	public const string ArgumentOutOfRange_InvalidPipeAccessRights = "Invalid PipeAccessRights flag.";
	public const string ArgumentOutOfRange_InvalidTimeout = "Timeout must be non-negative or equal to -1 (Timeout.Infinite)";
	public const string ArgumentOutOfRange_MaxNumServerInstances = "maxNumberOfServerInstances must either be a value between 1 and 254, or NamedPipeServerStream.MaxAllowedServerInstances (to obtain the maximum number allowed by system resources).";
	public const string ArgumentOutOfRange_NeedValidPipeAccessRights = "Need valid PipeAccessRights value.";
	public const string IndexOutOfRange_IORaceCondition = "Probable I/O race condition detected while copying memory. The I/O package is not thread safe by default unless stated otherwise. In multithreaded applications, access streams in a thread-safe way, such as a thread-safe wrapper returned by TextReader's or TextWriter's Synchronized methods. This also applies to classes like StreamWriter and StreamReader.";
	public const string InvalidOperation_EndReadCalledMultiple = "EndRead can only be called once for each asynchronous operation.";
	public const string InvalidOperation_EndWriteCalledMultiple = "EndWrite can only be called once for each asynchronous operation.";
	public const string InvalidOperation_EndWaitForConnectionCalledMultiple = "EndWaitForConnection can only be called once for each asynchronous operation.";
	public const string InvalidOperation_PipeNotYetConnected = "Pipe hasn't been connected yet.";
	public const string InvalidOperation_PipeDisconnected = "Pipe is in a disconnected state.";
	public const string InvalidOperation_PipeHandleNotSet = "Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?";
	public const string InvalidOperation_PipeNotAsync = "Pipe is not opened in asynchronous mode.";
	public const string InvalidOperation_PipeReadModeNotMessage = "ReadMode is not of PipeTransmissionMode.Message.";
	public const string InvalidOperation_PipeMessageTypeNotSupported = "This pipe does not support message type transmission.";
	public const string InvalidOperation_PipeAlreadyConnected = "Already in a connected state.";
	public const string InvalidOperation_PipeAlreadyDisconnected = "Already in a disconnected state.";
	public const string InvalidOperation_PipeClosed = "Pipe is closed.";
	public const string IO_FileTooLongOrHandleNotSync = "IO operation will not work. Most likely the file will become too long or the handle was not opened to support synchronous IO operations.";
	public const string IO_EOF_ReadBeyondEOF = "Unable to read beyond the end of the stream.";
	public const string IO_FileNotFound = "Unable to find the specified file.";
	public const string IO_FileNotFound_FileName = "Could not find file '{0}'.";
	public const string IO_IO_AlreadyExists_Name = "Cannot create \"{0}\" because a file or directory with the same name already exists.";
	public const string IO_IO_BindHandleFailed = "BindHandle for ThreadPool failed on this handle.";
	public const string IO_IO_FileExists_Name = "The file '{0}' already exists.";
	public const string IO_IO_NoPermissionToDirectoryName = "<Path discovery permission to the specified directory was denied.>";
	public const string IO_IO_SharingViolation_File = "The process cannot access the file '{0}' because it is being used by another process.";
	public const string IO_IO_SharingViolation_NoFileName = "The process cannot access the file because it is being used by another process.";
	public const string IO_IO_PipeBroken = "Pipe is broken.";
	public const string IO_IO_InvalidPipeHandle = "Invalid pipe handle.";
	public const string IO_DriveNotFound_Drive = "Could not find the drive '{0}'. The drive might not be ready or might not be mapped.";
	public const string IO_PathNotFound_Path = "Could not find a part of the path '{0}'.";
	public const string IO_PathNotFound_NoPathName = "Could not find a part of the path.";
	public const string IO_PathTooLong = "The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.";
	public const string NotSupported_MemStreamNotExpandable = "Memory stream is not expandable.";
	public const string NotSupported_UnreadableStream = "Stream does not support reading.";
	public const string NotSupported_UnseekableStream = "Stream does not support seeking.";
	public const string NotSupported_UnwritableStream = "Stream does not support writing.";
	public const string NotSupported_AnonymousPipeUnidirectional = "Anonymous pipes can only be in one direction.";
	public const string NotSupported_AnonymousPipeMessagesNotSupported = "Anonymous pipes do not support PipeTransmissionMode.Message ReadMode.";
	public const string ObjectDisposed_FileClosed = "Cannot access a closed file.";
	public const string ObjectDisposed_PipeClosed = "Cannot access a closed pipe.";
	public const string ObjectDisposed_ReaderClosed = "Cannot read from a closed TextReader.";
	public const string ObjectDisposed_StreamClosed = "Cannot access a closed Stream.";
	public const string ObjectDisposed_WriterClosed = "Cannot write to a closed TextWriter.";
	public const string PlatformNotSupported_NamedPipeServers = "Named Pipe Servers are not supported on Windows 95/98/ME.";
	public const string UnauthorizedAccess_IODenied_Path = "Access to the path '{0}' is denied.";
	public const string UnauthorizedAccess_IODenied_NoPathName = "Access to the path is denied.";
	public const string TraceAsTraceSource = "Trace";
	public const string ArgumentOutOfRange_NeedValidLogRetention = "Need valid log retention option.";
	public const string ArgumentOutOfRange_NeedMaxFileSizeGEBufferSize = "Maximum file size value should be greater than or equal to bufferSize.";
	public const string ArgumentOutOfRange_NeedValidMaxNumFiles = "Maximum number of files value should be greater than or equal to '{0}' for this retention";
	public const string ArgumentOutOfRange_NeedValidId = "The ID parameter must be in the range {0} through {1}.";
	public const string ArgumentOutOfRange_MaxArgExceeded = "The total number of parameters must not exceed {0}.";
	public const string ArgumentOutOfRange_MaxStringsExceeded = "The number of String parameters must not exceed {0}.";
	public const string NotSupported_DownLevelVista = "This functionality is only supported in Windows Vista and above.";
	public const string Argument_NeedNonemptyDelimiter = "Delimiter cannot be an empty string.";
	public const string NotSupported_SetTextWriter = "Setting TextWriter is unsupported on this listener.";
	public const string Perflib_PlatformNotSupported = "Classes in System.Diagnostics.PerformanceData is only supported in Windows Vista and above.";
	public const string Perflib_Argument_CounterSetAlreadyRegister = "CounterSet '{0}' already registered.";
	public const string Perflib_Argument_InvalidCounterType = "CounterType '{0}' is not a valid CounterType.";
	public const string Perflib_Argument_InvalidCounterSetInstanceType = "CounterSetInstanceType '{0}' is not a valid CounterSetInstanceType.";
	public const string Perflib_Argument_InstanceAlreadyExists = "Instance '{0}' already exists in CounterSet '{1}'.";
	public const string Perflib_Argument_CounterAlreadyExists = "CounterId '{0}' already added to CounterSet '{1}'.";
	public const string Perflib_Argument_CounterNameAlreadyExists = "CounterName '{0}' already added to CounterSet '{1}'.";
	public const string Perflib_Argument_ProviderNotFound = "CounterSet provider '{0}' not found.";
	public const string Perflib_Argument_InvalidInstance = "Single instance type CounterSet '{0}' can only have 1 CounterSetInstance.";
	public const string Perflib_Argument_EmptyInstanceName = "Non-empty instanceName required.";
	public const string Perflib_Argument_EmptyCounterName = "Non-empty counterName required.";
	public const string Perflib_InsufficientMemory_InstanceCounterBlock = "Cannot allocate raw counter data for CounterSet '{0}' Instance '{1}'.";
	public const string Perflib_InsufficientMemory_CounterSetTemplate = "Cannot allocate memory for CounterSet '{0}' template with size '{1}'.";
	public const string Perflib_InvalidOperation_CounterRefValue = "Cannot locate raw counter data location for CounterSet '{0}', Counter '{1}, in Instance '{2}'.";
	public const string Perflib_InvalidOperation_CounterSetNotInstalled = "CounterSet '{0}' not installed yet.";
	public const string Perflib_InvalidOperation_InstanceNotFound = "Cannot find Instance '{0}' in CounterSet '{1}'.";
	public const string Perflib_InvalidOperation_AddCounterAfterInstance = "Cannot AddCounter to CounterSet '{0}' after CreateCounterSetInstance.";
	public const string Perflib_InvalidOperation_NoActiveProvider = "CounterSet provider '{0}' not active.";
	public const string Perflib_InvalidOperation_CounterSetContainsNoCounter = "CounterSet '{0}' does not include any counters.";
	public const string Arg_ArrayPlusOffTooSmall = "Destination array is not long enough to copy all the items in the collection. Check array index and length.";
	public const string Arg_HSCapacityOverflow = "HashSet capacity is too big.";
	public const string InvalidOperation_EnumFailedVersion = "Collection was modified; enumeration operation may not execute.";
	public const string InvalidOperation_EnumOpCantHappen = "Enumeration has either not started or has already finished.";
	public const string Serialization_MissingKeys = "The Keys for this dictionary are missing.";
	public const string LockRecursionException_RecursiveReadNotAllowed = "Recursive read lock acquisitions not allowed in this mode.";
	public const string LockRecursionException_RecursiveWriteNotAllowed = "Recursive write lock acquisitions not allowed in this mode.";
	public const string LockRecursionException_RecursiveUpgradeNotAllowed = "Recursive upgradeable lock acquisitions not allowed in this mode.";
	public const string LockRecursionException_ReadAfterWriteNotAllowed = "A read lock may not be acquired with the write lock held in this mode.";
	public const string LockRecursionException_WriteAfterReadNotAllowed = "Write lock may not be acquired with read lock held. This pattern is prone to deadlocks. Please ensure that read locks are released before taking a write lock. If an upgrade is necessary, use an upgrade lock in place of the read lock.";
	public const string LockRecursionException_UpgradeAfterReadNotAllowed = "Upgradeable lock may not be acquired with read lock held.";
	public const string LockRecursionException_UpgradeAfterWriteNotAllowed = "Upgradeable lock may not be acquired with write lock held in this mode. Acquiring Upgradeable lock gives the ability to read along with an option to upgrade to a writer.";
	public const string SynchronizationLockException_MisMatchedRead = "The read lock is being released without being held.";
	public const string SynchronizationLockException_MisMatchedWrite = "The write lock is being released without being held.";
	public const string SynchronizationLockException_MisMatchedUpgrade = "The upgradeable lock is being released without being held.";
	public const string SynchronizationLockException_IncorrectDispose = "The lock is being disposed while still being used. It either is being held by a thread and/or has active waiters waiting to acquire the lock.";
	public const string Cryptography_ArgECDHKeySizeMismatch = "The keys from both parties must be the same size to generate a secret agreement.";
	public const string Cryptography_ArgECDHRequiresECDHKey = "Keys used with the ECDiffieHellmanCng algorithm must have an algorithm group of ECDiffieHellman.";
	public const string Cryptography_ArgECDsaRequiresECDsaKey = "Keys used with the ECDsaCng algorithm must have an algorithm group of ECDsa.";
	public const string Cryptography_ArgExpectedECDiffieHellmanCngPublicKey = "DeriveKeyMaterial requires an ECDiffieHellmanCngPublicKey.";
	public const string Cryptography_ArgMustBeCngAlgorithm = "Object must be of type CngAlgorithm.";
	public const string Cryptography_ArgMustBeCngAlgorithmGroup = "Object must be of type CngAlgorithmGroup.";
	public const string Cryptography_ArgMustBeCngKeyBlobFormat = "Object must be of type CngKeyBlobFormat.";
	public const string Cryptography_ArgMustBeCngProvider = "Object must be of type CngProvider.";
	public const string Cryptography_DecryptWithNoKey = "Decrypting a value requires that a key be set on the algorithm object.";
	public const string Cryptography_ECXmlSerializationFormatRequired = "XML serialization of an elliptic curve key requires using an overload which specifies the XML format to be used.";
	public const string Cryptography_InvalidAlgorithmGroup = "The algorithm group '{0}' is invalid.";
	public const string Cryptography_InvalidAlgorithmName = "The algorithm name '{0}' is invalid.";
	public const string Cryptography_InvalidCipherMode = "The specified cipher mode is not valid for this algorithm.";
	public const string Cryptography_InvalidIVSize = "The specified initialization vector (IV) does not match the block size for this algorithm.";
	public const string Cryptography_InvalidKeyBlobFormat = "The key blob format '{0}' is invalid.";
	public const string Cryptography_InvalidKeySize = "The specified key is not a valid size for this algorithm.";
	public const string Cryptography_InvalidPadding = "Padding is invalid and cannot be removed.";
	public const string Cryptography_InvalidProviderName = "The provider name '{0}' is invalid.";
	public const string Cryptography_MissingDomainParameters = "Could not read the domain parameters from the XML string.";
	public const string Cryptography_MissingPublicKey = "Could not read the public key from the XML string.";
	public const string Cryptography_MissingIV = "The cipher mode specified requires that an initialization vector (IV) be used.";
	public const string Cryptography_MustTransformWholeBlock = "TransformBlock may only process bytes in block sized increments.";
	public const string Cryptography_NonCompliantFIPSAlgorithm = "This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms.";
	public const string Cryptography_OpenInvalidHandle = "Cannot open an invalid handle.";
	public const string Cryptography_OpenEphemeralKeyHandleWithoutEphemeralFlag = "The CNG key handle being opened was detected to be ephemeral, but the EphemeralKey open option was not specified.";
	public const string Cryptography_PartialBlock = "The input data is not a complete block.";
	public const string Cryptography_PlatformNotSupported = "The specified cryptographic algorithm is not supported on this platform.";
	public const string Cryptography_TlsRequiresLabelAndSeed = "The TLS key derivation function requires both the label and seed properties to be set.";
	public const string Cryptography_TransformBeyondEndOfBuffer = "Attempt to transform beyond end of buffer.";
	public const string Cryptography_UnknownEllipticCurve = "Unknown elliptic curve.";
	public const string Cryptography_UnknownEllipticCurveAlgorithm = "Unknown elliptic curve algorithm.";
	public const string Cryptography_UnknownPaddingMode = "Unknown padding mode used.";
	public const string Cryptography_UnexpectedXmlNamespace = "The XML namespace '{0}' was unexpected, expected '{1}'.";
	public const string ArgumentException_RangeMinRangeMaxRangeType = "Cannot accept MinRange {0} because it is not the same type as MaxRange {1}. Verify that the MaxRange and MinRange values are of the same type and try again.";
	public const string ArgumentException_RangeNotIComparable = "Cannot accept MaxRange and MinRange because they are not IComparable.";
	public const string ArgumentException_RangeMaxRangeSmallerThanMinRange = "Cannot accept MaxRange because it is less than MinRange. Specify a MaxRange value that is greater than or equal to the MinRange value and try again.";
	public const string ArgumentException_CountMaxLengthSmallerThanMinLength = "MaxLength should be greater than MinLength.";
	public const string ArgumentException_LengthMaxLengthSmallerThanMinLength = "Cannot accept MaxLength value. Specify MaxLength value greater than the value of MinLength and try again.";
	public const string ArgumentException_UnregisteredParameterName = "Parameter {0} has not been added to this parser.";
	public const string ArgumentException_InvalidParameterName = "{0} is an invalid parameter name.";
	public const string ArgumentException_DuplicateName = "The name {0} is already in use.";
	public const string ArgumentException_DuplicatePosition = "The position {0} is already in use.";
	public const string ArgumentException_NoParametersFound = "The object has no parameters associated with it.";
	public const string ArgumentException_HelpMessageBaseNameNullOrEmpty = "Help message base name may not be null or empty.";
	public const string ArgumentException_HelpMessageResourceIdNullOrEmpty = "Help message resource id may not be null or empty.";
	public const string ArgumentException_HelpMessageNullOrEmpty = "Help message may not be null or empty.";
	public const string ArgumentException_RegexPatternNullOrEmpty = "The regular expression pattern may not be null or empty.";
	public const string ArgumentException_RequiredPositionalAfterOptionalPositional = "Optional positional parameter {0} cannot precede required positional parameter {1}.";
	public const string ArgumentException_DuplicateParameterAttribute = "Duplicate parameter attributes with the same parameter set on parameter {0}.";
	public const string ArgumentException_MissingBaseNameOrResourceId = "On parameter {0}, either both HelpMessageBaseName and HelpMessageResourceId must be set or neither can be set.";
	public const string ArgumentException_DuplicateRemainingArgumets = "Can not set {0} as the remaining arguments parameter for parameter set {1} because that parameter set already has a parameter set as the remaining arguments parameter.";
	public const string ArgumentException_TypeMismatchForRemainingArguments = "Parameter {0} must be an array of strings if it can have its value from the remaining arguments.";
	public const string ArgumentException_ValidationParameterTypeMismatch = "Validator {0} may not be applied to a parameter of type {1}.";
	public const string ArgumentException_ParserBuiltWithValueType = "The parameter toBind may not be an instance of a value type.";
	public const string InvalidOperationException_GetParameterTypeMismatch = "Parameter {0} may not retrieved with type {1} since it is of type {2}.";
	public const string InvalidOperationException_GetParameterValueBeforeParse = "Parse must be called before retrieving parameter values.";
	public const string InvalidOperationException_SetRemainingArgumentsParameterAfterParse = "AllowRemainingArguments may not be set after Parse has been called.";
	public const string InvalidOperationException_AddParameterAfterParse = "Parameters may not be added after Parse has been called.";
	public const string InvalidOperationException_BindAfterBind = "Parse may only be called once.";
	public const string InvalidOperationException_GetRemainingArgumentsNotAllowed = "GetRemainingArguments may not be called unless AllowRemainingArguments is set to true.";
	public const string InvalidOperationException_ParameterSetBeforeParse = "The SpecifiedParameterSet property may only be accessed after Parse has been called successfully.";
	public const string CommandLineParser_Aliases = "Aliases";
	public const string CommandLineParser_ErrorMessagePrefix = "Error";
	public const string CommandLineParser_HelpMessagePrefix = "Usage";
	public const string ParameterBindingException_AmbiguousParameterName = "Prefix {0} resolves to multiple parameters: {1}.  Use a more specific prefix for this parameter.";
	public const string ParameterBindingException_ParameterValueAlreadySpecified = "Parameter {0} already given value of {1}.";
	public const string ParameterBindingException_UnknownParameteName = "Unknown parameter {0}.";
	public const string ParameterBindingException_RequiredParameterMissingCommandLineValue = "Parameter {0} must be followed by a value.";
	public const string ParameterBindingException_UnboundCommandLineArguments = "Unbound parameters left on command line: {0}.";
	public const string ParameterBindingException_UnboundMandatoryParameter = "Values for required parameters missing: {0}.";
	public const string ParameterBindingException_ResponseFileException = "Could not open response file {0}: {1}";
	public const string ParameterBindingException_ValididationError = "Could not validate parameter {0}: {1}";
	public const string ParameterBindingException_TransformationError = "Could not convert {0} to type {1}.";
	public const string ParameterBindingException_AmbiguousParameterSet = "Named parameters specify an ambiguous parameter set.  Specify more parameters by name.";
	public const string ParameterBindingException_UnknownParameterSet = "No valid parameter set for named parameters.  Make sure all named parameters belong to the same parameter set.";
	public const string ParameterBindingException_NestedResponseFiles = "A response file may not contain references to other response files.";
	public const string ValidateMetadataException_RangeGreaterThanMaxRangeFailure = "The value {0} was greater than the maximum value {1}. Specify a value less than or equal to the maximum value and try again.";
	public const string ValidateMetadataException_RangeSmallerThanMinRangeFailure = "The value {0} was smaller than the minimum value {1}. Specify a value greater than or equal to the minimum value and try again.";
	public const string ValidateMetadataException_PatternFailure = "The value {0} does not match the pattern {1}.";
	public const string ValidateMetadataException_CountMinLengthFailure = "The number of values should be greater than or equal to {0} instead of {1}.";
	public const string ValidateMetadataException_CountMaxLengthFailure = "The number of values should be less than or equal to {0} instead of {1}.";
	public const string ValidateMetadataException_LengthMinLengthFailure = "The length should be greater than or equal to {0} instead of {1}.";
	public const string ValidateMetadataException_LengthMaxLengthFailure = "The length should be less than or equal to {0} instead of {1}.";
	public const string Argument_MapNameEmptyString = "Map name cannot be an empty string.";
	public const string Argument_EmptyFile = "A positive capacity must be specified for a Memory Mapped File backed by an empty file.";
	public const string Argument_NewMMFWriteAccessNotAllowed = "MemoryMappedFileAccess.Write is not permitted when creating new memory mapped files. Use MemoryMappedFileAccess.ReadWrite instead.";
	public const string Argument_ReadAccessWithLargeCapacity = "When specifying MemoryMappedFileAccess.Read access, the capacity must not be larger than the file size.";
	public const string Argument_NewMMFAppendModeNotAllowed = "FileMode.Append is not permitted when creating new memory mapped files. Instead, use MemoryMappedFileView to ensure write-only access within a specified region.";
	public const string ArgumentNull_MapName = "Map name cannot be null.";
	public const string ArgumentNull_FileStream = "fileStream cannot be null.";
	public const string ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed = "The capacity cannot be greater than the size of the system's logical address space.";
	public const string ArgumentOutOfRange_NeedPositiveNumber = "A positive number is required.";
	public const string ArgumentOutOfRange_PositiveOrDefaultCapacityRequired = "The capacity must be greater than or equal to 0. 0 represents the the size of the file being mapped.";
	public const string ArgumentOutOfRange_PositiveOrDefaultSizeRequired = "The size must be greater than or equal to 0. If 0 is specified, the view extends from the specified offset to the end of the file mapping.";
	public const string ArgumentOutOfRange_PositionLessThanCapacityRequired = "The position may not be greater or equal to the capacity of the accessor.";
	public const string ArgumentOutOfRange_CapacityGEFileSizeRequired = "The capacity may not be smaller than the file size.";
	public const string IO_NotEnoughMemory = "Not enough memory to map view.";
	public const string InvalidOperation_CalledTwice = "Cannot call this operation twice.";
	public const string InvalidOperation_CantCreateFileMapping = "Cannot create file mapping.";
	public const string InvalidOperation_ViewIsNull = "The underlying MemoryMappedView object is null.";
	public const string NotSupported_DelayAllocateFileBackedNotAllowed = "The MemoryMappedFileOptions.DelayAllocatePages option is not supported with memory mapped files mapping files on disk.";
	public const string NotSupported_MMViewStreamsFixedLength = "MemoryMappedViewStreams are fixed length.";
	public const string ObjectDisposed_ViewAccessorClosed = "Cannot access a closed accessor.";
	public const string ObjectDisposed_StreamIsClosed = "Cannot access a closed Stream.";
}

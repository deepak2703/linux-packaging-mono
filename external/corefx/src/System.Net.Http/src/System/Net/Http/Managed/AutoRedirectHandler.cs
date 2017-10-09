﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    internal sealed class AutoRedirectHandler : HttpMessageHandler
    {
        private readonly HttpMessageHandler _innerHandler;
        private readonly int _maxAutomaticRedirections;

        public AutoRedirectHandler(int maxAutomaticRedirections, HttpMessageHandler innerHandler)
        {
            _innerHandler = innerHandler ?? throw new ArgumentNullException(nameof(innerHandler));

            if (maxAutomaticRedirections < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxAutomaticRedirections));
            }
            _maxAutomaticRedirections = maxAutomaticRedirections;
        }

        protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response;
            uint redirectCount = 0;
            while (true)
            {
                response = await _innerHandler.SendAsync(request, cancellationToken).ConfigureAwait(false);

                bool needRedirect = false;
                bool forceGet = false;
                switch (response.StatusCode)
                {
                    case HttpStatusCode.TemporaryRedirect:
                        needRedirect = true;
                        break;

                    case HttpStatusCode.Moved:
                    case HttpStatusCode.Found:
                    case HttpStatusCode.SeeOther:
                        needRedirect = true;
                        forceGet = request.Method == HttpMethod.Post;
                        break;

                    case HttpStatusCode.MultipleChoices:
                        needRedirect = response.Headers.Location != null; // Don't redirect if no Location specified
                        forceGet = request.Method == HttpMethod.Post;
                        break;
                }

                if (!needRedirect)
                {
                    break;
                }

                Uri location = response.Headers.Location;
                if (location == null)
                {
                    throw new HttpRequestException(SR.net_http_headers_missing_location);
                }

                if (!location.IsAbsoluteUri)
                {
                    location = new Uri(request.RequestUri, location);
                }

                // Disallow automatic redirection from https to http
                bool allowed =
                    (request.RequestUri.Scheme == UriScheme.Http && (location.Scheme == UriScheme.Http || location.Scheme == UriScheme.Https)) ||
                    (request.RequestUri.Scheme == UriScheme.Https && location.Scheme == UriScheme.Https);
                if (!allowed)
                {
                    break;
                }

                redirectCount++;
                if (redirectCount > _maxAutomaticRedirections)
                {
                    throw new HttpRequestException(SR.net_http_max_redirects);
                }

                // Set up for the automatic redirect
                request.RequestUri = location;

                if (forceGet)
                {
                    request.Method = HttpMethod.Get;
                    request.Content = null;
                }

                // Do the redirect.
                response.Dispose();
            }

            return response;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _innerHandler.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}

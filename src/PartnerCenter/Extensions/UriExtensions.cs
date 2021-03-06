﻿// -----------------------------------------------------------------------
// <copyright file="UriExtensions.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides useful URI extension methods.
    /// </summary>
    public static class UriExtensions
    {
        /// <summary>
        /// Adds the parameters to the URI as query string parameters.
        /// </summary>
        /// <param name="uri">The address of the request.</param>
        /// <param name="parameters">The parameters to be added as query string parameters.</param>
        /// <returns>A URI that includes the query string parameters.</returns>
        public static Uri AddQueryParemeters(this Uri uri, IDictionary<string, string> parameters)
        {
            UriBuilder builder;

            builder = new UriBuilder(uri)
            {
                Query = $"{string.Join("&", parameters.Select(x => $"{x.Key}={x.Value}"))}"
            };

            return builder.Uri;
        }
    }
}
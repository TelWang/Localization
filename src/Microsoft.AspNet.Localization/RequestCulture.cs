﻿// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System.Globalization;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Localization
{
    /// <summary>
    /// Details about the culture for an <see cref="Http.HttpRequest"/>.
    /// </summary>
    public class RequestCulture
    {
        /// <summary>
        /// Creates a new <see cref="RequestCulture"/> object has its <see cref="Culture"/> and <see cref="UICulture"/>
        /// properties set to the same <see cref="CultureInfo"/> value.
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/> for the request.</param>
        public RequestCulture([NotNull] CultureInfo culture)
            : this (culture, culture)
        {

        }

        /// <summary>
        /// Creates a new <see cref="RequestCulture"/> object has its <see cref="Culture"/> and <see cref="UICulture"/>
        /// properties set to the respective <see cref="CultureInfo"/> values provided.
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/> for the request to be used for formatting.</param>
        /// <param name="uiCulture">The <see cref="CultureInfo"/> for the request to be used for text, i.e. language.</param>
        public RequestCulture([NotNull] CultureInfo culture, [NotNull] CultureInfo uiCulture)
        {
            Culture = culture;
            UICulture = uiCulture;
        }

        /// <summary>
        /// Gets the <see cref="CultureInfo"/> for the request to be used for formatting.
        /// </summary>
        public CultureInfo Culture { get; }

        /// <summary>
        /// Gets the <see cref="CultureInfo"/> for the request to be used for text, i.e. language;
        /// </summary>
        public CultureInfo UICulture { get; }
    }
}

﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using Microsoft.DotNet.Interactive.ExtensionLab;
using Microsoft.DotNet.Interactive.Formatting.TabularData;

namespace Microsoft.DotNet.Interactive.Formatting
{
    public static class TabularDataResourceExtensions
    {
        public static NteractDataExplorer ExploreWithNteract(this TabularDataResource source)
        {
            var explorer = new NteractDataExplorer(source);
            return explorer;
        }
    }
}
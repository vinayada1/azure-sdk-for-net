﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.V2.Resource.Core;
using System;

namespace Microsoft.Azure.Management.V2.Resource
{
    public enum ResourceGroupExportTemplateOptions
    {
        [EnumName("IncludeParameterDefaultValue")]
        INCLUDE_PARAMETER_DEFAULT_VALUE,
        [EnumName("IncludeComments")]
        INCLUDE_COMMENTS,
        [EnumName("IncludeParameterDefaultValue, IncludeComments")]
        INCLUDE_BOTH
    }
}
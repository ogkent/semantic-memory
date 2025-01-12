﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.SemanticMemory.FileSystem.DevTools;

public static class StringExtensions
{
    public static string RemoveBOM(this string x)
    {
        return x.TrimStart('\uFEFF', '\u200B');
    }
}

﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using System.Security;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.Handle, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [SecurityCritical]
        internal static extern bool CloseHandle(IntPtr handle);
    }
}

﻿/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

using System;
using AlastairLundy.Extensions.System.VersionExtensions;

namespace PlatformKit.Extensions.OperatingSystem
{
    // ReSharper disable once InconsistentNaming
    internal static class IsFreeBSDVersionAtLeastExtension
    {
        /// <summary>
        /// Checks to see whether the specified version of FreeBSD is the same or newer than the installed version of Windows.
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        /// <param name="build"></param>
        /// <param name="revision"></param>
        /// <returns></returns>
        /// <exception cref="PlatformNotSupportedException"></exception>
        // ReSharper disable once InconsistentNaming
        internal static bool IsFreeBSDVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0)
        {
            if (IsFreeBSDExtension.IsFreeBSD())
            {
                return GetSystemExtension.GetSystem(PlatformID.Unix).Version.IsAtLeast(new Version(major, minor, build, revision));
            }

            throw new PlatformNotSupportedException();
        }
    }
}
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
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;


// ReSharper disable InconsistentNaming

namespace PlatformKit.Extensions.OperatingSystem
{
    internal static class IsOperatingSystemExtensions
    {
        internal static bool IsWindows()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }
        
        internal static bool IsMacOS()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        }
        
        internal static bool IsLinux()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }
        
        internal static bool IsFreeBSD()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("freebsd");
        }

        internal static bool IsAndroid()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("android") && RuntimeInformation.OSDescription.ToLower().Contains("tv") == false;
        }

        internal static bool IsAndroidTV()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("android") && RuntimeInformation.OSDescription.ToLower().Contains("tv") == true;
        }
        
        internal static bool IsIOS()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("ios");
        }

        internal static bool IsWatchOS()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("watchos");
        }
        
        internal static bool IsWearOS()
        {
            return RuntimeInformation.OSDescription.ToLower().Contains("wearos");
        }

        internal static bool IsTvOS()
        {
            if(RuntimeInformation.OSDescription.ToLower().Contains("tvos") && RuntimeInformation.OSDescription.ToLower().Contains("android"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
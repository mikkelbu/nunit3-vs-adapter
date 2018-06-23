﻿// ***********************************************************************
// Copyright (c) 2018 Charlie Poole, Terje Sandstrom
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.VisualStudio.TestAdapter.Internal;

namespace NUnit.VisualStudio.TestAdapter.Tests
{
#if !NETCOREAPP1_0
    public class ExtensionsTests
    {
        [TestCase("\t\t\t")]
        [TestCase("    \t")]
        [TestCase("  ")]
        [TestCase("")]
        public void ThatIsNullOrWhiteSpaceHandlesTabs(string value)
        {
            var res = StringExtensions.IsNullOrWhiteSpace(value);
            Assert.That(res);
        }

        [TestCase("\t42")]
        [TestCase("   42")]
        [TestCase("42\n\r")]
        public void ThatIsNullOrWhiteSpaceHandlesNonWhiteSpace(string value)
        {
            var res = StringExtensions.IsNullOrWhiteSpace(value);
            Assert.That(res, Is.False);
        }
    }
#endif
}
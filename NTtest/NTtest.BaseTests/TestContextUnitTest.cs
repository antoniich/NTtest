using NTtest.Core.Configuration;
using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using NTtest.Core;

namespace NTtest.BaseTests
{
    public class TestContextUnitTest
    {
        [Fact]
        public void TestContextInitialization()
        {
            using (var testContext = new NtTestContext())
            {
            }
        }
    }
}
using NTtest.Core.Configuration;
using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using NTtest.Core;
using Xunit.Abstractions;
using System.Reflection;

namespace NTtest.BaseTests
{
    public class TestContextUnitTest
    {
        private readonly ITestOutputHelper _output;
        private readonly string _fullTestName;

        public TestContextUnitTest(ITestOutputHelper output)
        {
            _output = output;
            var type = output.GetType();
            var testMember = type.GetField("test", BindingFlags.Instance | BindingFlags.NonPublic);
            var test = (ITest)testMember.GetValue(output);
            _fullTestName = test.DisplayName;
        }

        [Fact]
        public void TestContextInitialization()
        {
            using (var testContext = new NtTestContext())
            {
                Assert.False(true);
                _output.WriteLine("test...");
            }
        }
    }
}
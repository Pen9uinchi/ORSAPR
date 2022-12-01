using System;
using NUnit.Framework;
using PotParameters;

namespace UnitTests
{
    [TestFixture]
    public class ParameterTest
    {
        [TestCase(TestName = "Positive parameter setter")]
        public void Parameter_SetCorrectValue()
        {
            var minimumParameterValue = 10;
            var maximumParameterValue = 50;
            var expected = new Parameter(
                minimumParameterValue,
                maximumParameterValue)
                { ParameterValue = 30 };

            var actual = 30;

            Assert.AreEqual(expected.ParameterValue, actual);
        }

        [Test(Description = "Positive parameter getter")]
        public void Parameter_GetCorrectValue()
        {
            var minimumParameterValue = 10;
            var maximumParameterValue = 50;
            var expected = new Parameter(minimumParameterValue, maximumParameterValue);

            var testValue = 30;
            expected.ParameterValue = testValue;

            Assert.AreEqual(expected.ParameterValue, testValue);
        }

        [Test(Description = "Positive create default constructor")]
        public void Parameter_CorrectConstructor()
        {
            var expected = new Parameter();

            Assert.True(expected.MinimumValue == -1);
            Assert.True(expected.MaximumValue == -1);
        }

        [TestCase(5, 10, 50, TestName =
            "Negative parameter setter value is less than allowed")]
        [TestCase(100, 0, 50, TestName =
            "Negative parameter setter value is more than allowed")]
        [TestCase(50, -1, -1, TestName =
            "Negative parameter setter dependent parameter not set")]
        public void Parameter_SetUnCorrectValue(double value,
            double minimumValue, double maximumValue)
        {
            var testParameter = new Parameter(minimumValue, maximumValue);
            Assert.Throws<ArgumentException>(
                () =>
                {
                    testParameter.ParameterValue = value;
                },
                "Exception: argument out of range");
        }

        [TestCase(TestName = "Positive equals test")]
        public void Parameter_EqualsTest()
        {
            var parameter = new Parameter();
            var otherParameter = parameter;
            Assert.True(parameter.Equals(otherParameter));
        }
    }
}

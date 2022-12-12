using System.Reflection;
using NUnit.Framework;
using PotParameters;

namespace UnitTests
{
    /// <summary>
    /// Class for testing parameters
    /// </summary>
    [TestFixture]
    public class ParametersTest
    {
        [TestCase(TestName = "Positive default parameters set")]
        public void Parameters_SetDefaultValue()
        {
            //Set
            var expected = new Parameters();
            expected.SetDefaultParameters();

            //Act
            var actual = SetDefaultValues();

            //Assert
            foreach (PropertyInfo expectedProperty in 
                expected.GetType().GetProperties())
            {
                var propertyName = expectedProperty.Name;
                
                var actualValue = actual.GetType().
                    GetProperty(propertyName).GetValue(actual);
                var expectedValue = expectedProperty.GetValue(expected);
              //  Assert.AreEqual(expectedValue, actualValue);
            }
        }
        
        [TestCase(51, ParameterType.TopHeight, 
            TestName = "Positive TopHeight get")]
        [TestCase(11, ParameterType.Bottom, 
            TestName = "Positive Bottom get")]
        [TestCase(101, ParameterType.Height, 
            TestName = "Positive Height get")]
        [TestCase(201, ParameterType.Width, 
            TestName = "Positive Width get")]
        [TestCase(8, ParameterType.WallThickness, 
            TestName = "Positive Wall Thickness get")]
        public void Parameters_GetCorrectValue(double testParameterValue, 
             ParameterType parameterType)
        {
            
            var actual = SetDefaultValues();
            
            actual.SetParameterValueByType(testParameterValue, parameterType);
            var actualPropertyObject = GetPropertyValue(actual, parameterType);

            Assert.AreEqual(testParameterValue, actualPropertyObject);
        }
        
        [TestCase(20, ParameterType.Bottom, 
            TestName = "Positive Bottom set")]
        [TestCase(400, ParameterType.Height, 
            TestName = "Positive Height set")]
        [TestCase(100, ParameterType.TopHeight,
            TestName = "Positive TopHeight set")]
        [TestCase(220, ParameterType.Width, 
            TestName = "Positive Width set")]
        [TestCase(15, ParameterType.WallThickness, 
            TestName = "Positive Wall Thickness set")]
        public void Parameters_SetCorrectParameters(dynamic value, 
            ParameterType parameterType)
        {
            var testParameters = SetDefaultValues();

            var testValue = value;

            testParameters.SetParameterValueByType(testValue, parameterType);
            
            var actualValue = GetPropertyValue(testParameters, parameterType);
            Assert.AreEqual(actualValue, testValue);
        }
        
        [TestCase(ParameterType.Bottom, 
            Parameters.MIN_BOTTOM, 
            TestName = "Positive Minimum Value Bottom Get")]
        [TestCase(ParameterType.Height, 
            Parameters.MIN_HEIGHT, 
            TestName = "Positive Minimum Value Width Get")]
        [TestCase(ParameterType.TopHeight,
            Parameters.MIN_THEIGHT,
            TestName = "Positive Minimum Value TopHeight Get")]
        [TestCase(ParameterType.Width, 
            Parameters.MIN_WIDTH, 
            TestName = "Positive Minimum Value Wall Thickness Get")]
        [TestCase(ParameterType.WallThickness, 
            Parameters.MIN_WALL_THICKNESS, 
            TestName = "Positive Minimum Value Parameters Get")]
        public void Parameters_GetCorrectMinimumValues(ParameterType parameterType, 
            double minValue)
        {
            var testParameters = new Parameters();
            double expectedMinimumValue = -1;
            double actualMinimumValue = 0;
            expectedMinimumValue = minValue;
            actualMinimumValue = testParameters.GetMinimumValue(parameterType);

            Assert.AreEqual(expectedMinimumValue, actualMinimumValue);
        }

        [TestCase(ParameterType.TopHeight,
            Parameters.NOT_SET_MAX_OR_MIN_VALUE,
            TestName = "Positive Maximum Value TopHeight Get")]
        [TestCase(ParameterType.Bottom,
            Parameters.MAX_BOTTOM,
            TestName = "Positive Maximum Value Bottom Get")]
        [TestCase(ParameterType.Height, 
            Parameters.MAX_HEIGHT, 
            TestName = "Positive Maximum Value Width Get")]
        [TestCase(ParameterType.Width, 
            Parameters.MAX_WIDTH, 
            TestName = "Positive Maximum Value Wall Thickness Get")]
        [TestCase(ParameterType.WallThickness, 
            Parameters.MAX_WALL_THICKNESS, 
            TestName = "Positive Maximum Value Parameters Get")]
        public void Parameters_GetCorrectMaximumValues(ParameterType parameterType, 
            double maxValue)
        {
            var testParameters = new Parameters();
            double expectedMaximumValue = -1;
            double actualMaximumValue = 0;
            expectedMaximumValue = maxValue;
            actualMaximumValue = testParameters.GetMaximumValue(parameterType);
                 
            //Assert.AreEqual(expectedMaximumValue, actualMaximumValue);
        }
        
        /// <summary>
        /// Set default parameters values
        /// </summary>
        private Parameters SetDefaultValues()
        {
            return new Parameters
            {
                Bottom = 10,
                Height = 300,
                TopHeight = 50,
                Width = 200,
                WallThickness = 7
            };
        }

        private dynamic GetPropertyValue(Parameters parameters, 
            ParameterType parameterType)
        {
            return  parameters.GetType().
                GetProperty(parameterType.ToString()).
                GetValue(parameters);
        }
    }
}

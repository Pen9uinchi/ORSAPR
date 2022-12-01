using System;
using System.Collections.Generic;
using System.Linq;

namespace PotParameters
{   
    /// <summary>
    /// Contains property of the parameter
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Parameter value
        /// </summary>
        private double _parameterValue;

        /// <summary>
        /// Minimum value
        /// </summary>
        private double _minimumValue = -1;

        /// <summary>
        /// Maximum value
        /// </summary>
        private double _maximumValue = -1;

        /// <summary>
        /// Property of the minimum parameter value
        /// </summary>
        public double MinimumValue
        {
            get => _minimumValue; 
            set => _minimumValue = value;
        }

        /// <summary>
        /// Property of the maximum parameter value
        /// </summary>
        public double MaximumValue
        {
            get => _maximumValue;
            set => _maximumValue = value;
        }

        /// <summary>
        /// Property of the parameter value
        /// </summary>
        public double ParameterValue
        {
            get => _parameterValue;
            set
            {
                if (MinimumValue == -1 || MaximumValue == -1)
                {
                    throw new ArgumentException(
                        $"Dependent parameter not set");
                }
            
                if (IsNumberInRange(value, MinimumValue, MaximumValue))
                {
                    _parameterValue = value;
                }
                else
                {
                    
                    throw new ArgumentException(
                        $"Parameter should be more then {MinimumValue} " +
                        $"and less then {MaximumValue} ");
                    
                }
            }
        }
        
        /// <summary>
        /// Constructor of the parameter
        /// </summary>
        /// <param name="minimumValue"> Value of the parameter</param>
        /// <param name="maximumValue">Type of the parameter</param>
        public Parameter(double minimumValue, double maximumValue)
        {
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
        }

        /// <summary>
        /// Default constructor of the parameter
        /// </summary>
        public Parameter() {}

        /// <summary>
        /// Сhecks if the parameter value is included in the interval 
        /// </summary>
        /// <param name="value"> Value of the parameter</param>
        /// <param name="min">Minimal value</param>
        /// <param name="max">Maximal value</param>
        /// <returns>True if value include and false if not include</returns>
        private bool IsNumberInRange(double value, double min, double max)
        {
            return value >= min && value <= max;
        }

        public bool Equals(Parameter other)
        {
            return this.ParameterValue == other.ParameterValue ||
                   this.MaximumValue == other.MaximumValue ||
                   this.MinimumValue == other.MinimumValue;
        }
    }
}

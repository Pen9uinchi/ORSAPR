using System.Runtime.CompilerServices;

namespace PotParameters
{
    /// <summary>
    /// Contain list of the parameters
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Top height of the pot
        /// </summary>
        private Parameter _topHeight = 
            new Parameter(MIN_THEIGHT, NOT_SET_MAX_OR_MIN_VALUE);

        /// <summary>
        /// Handle length of the pot
        /// </summary>
        private Parameter _bottom = 
            new Parameter(MIN_BOTTOM, MAX_BOTTOM);

        /// <summary>
        /// HEIGHT of the pot
        /// </summary>
        private Parameter _height = 
            new Parameter(MIN_HEIGHT, MAX_HEIGHT);

        /// <summary>
        /// WIDTH of the pot
        /// </summary>
        private Parameter _width = 
            new Parameter(MIN_WIDTH, MAX_WIDTH);

        /// <summary>
        /// Wall thickness of the pot
        /// </summary>
        private Parameter _wallThickness = 
            new Parameter(MIN_WALL_THICKNESS, MAX_WALL_THICKNESS);

        /// <summary>
        /// Get or set cover radius
        /// </summary>
        public double TopHeight
        {
            get => _topHeight.ParameterValue;

            set => _topHeight.ParameterValue = value;
        }

        /// <summary>
        /// Get or set bottom
        /// </summary>
        public double Bottom
        {
            get => _bottom.ParameterValue;

            set => _bottom.ParameterValue = value;
        }

        /// <summary>
        /// Get or set HEIGHT
        /// </summary>
        public double Height
        {
            get => _height.ParameterValue;

            set
            {
                _height.ParameterValue = value;

                double TopHeightMax = 600 - value;

                _topHeight.MaximumValue = TopHeightMax;
            }
        }

        /// <summary>
        /// Get or set WIDTH
        /// </summary>
        public double Width
        {
            get => _width.ParameterValue;

            set => _width.ParameterValue = value;
        }

        /// <summary>
        /// Get or set wall thickness
        /// </summary>
        public double WallThickness
        {
            get => _wallThickness.ParameterValue;

            set => _wallThickness.ParameterValue = value;
        }

        
        /// <summary>
        ///Minimum value of Top Height
        /// </summary>
        public const double MIN_THEIGHT = 50.0;
        /*
        /// <summary>
        ///Maximum value of Top Height
        /// </summary>
        public const double MAX_TOP_HEIGHT = 350.0;
        */

        /// <summary>
        ///Minimum value of Handle Length
        /// </summary>
        public const double MIN_BOTTOM = 10.0;

        /// <summary>
        ///Maximum value of HANDLE_LENGTH
        /// </summary>
        public const double MAX_BOTTOM = 30.0;

        /// <summary>
        ///Minimum value of HEIGHT
        /// </summary>
        public const double MIN_HEIGHT = 100.0;

        /// <summary>
        ///Maximum value of HEIGHT
        /// </summary>
        public const double MAX_HEIGHT = 500.0;

        /// <summary>
        ///Minimum value of WIDTH
        /// </summary>
        public const double MIN_WIDTH = 200.0;

        /// <summary>
        ///Maximum value of WIDTH
        /// </summary>
        public const double MAX_WIDTH = 400.0;

        /// <summary>
        ///Minimum value of WALL_THICKNESS
        /// </summary>
        public const double MIN_WALL_THICKNESS = 7.0;

        /// <summary>
        ///Maximum value of WallThickness
        /// </summary>
        public const double MAX_WALL_THICKNESS = 20.0;

        /// <summary>
        /// Not set max or min value
        /// </summary>
        public const double NOT_SET_MAX_OR_MIN_VALUE = -1;
        
        /// <summary>
        /// Set default parameters
        /// </summary>
        public void SetDefaultParameters()
        {
            this.Height = 300;
            this.Bottom = 10;
            this.TopHeight = 50;
            this.Width = 300;
            this.WallThickness = 7;
        }

        /// <summary>
        /// Return parameter minimum value
        /// </summary>
        /// <param name="parameterType">Parameter type</param>
        /// <returns>Parameter minimum value</returns>
        public double GetMinimumValue(ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Bottom:
                {
                    return this._bottom.MinimumValue;
                }
                case ParameterType.Height:
                {
                    return this._height.MinimumValue;
                }
                case ParameterType.TopHeight:
                {
                    return this._topHeight.MinimumValue;
                }
                case ParameterType.Width:
                {
                    return this._width.MinimumValue;
                }
                case ParameterType.WallThickness:
                {
                    return this._wallThickness.MinimumValue;
                }
                default:
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Return parameter maximum value
        /// </summary>
        /// <param name="parameterType">Parameter type</param>
        /// <returns>Parameter maximum value</returns>
        public double GetMaximumValue(ParameterType parameterType)
        {
            switch (parameterType)
            {
                
                case ParameterType.Bottom:
                {
                    return this._bottom.MinimumValue;
                }
                case ParameterType.Height:
                {
                    return this._height.MaximumValue;
                }
                case ParameterType.TopHeight:
                {
                    return this._topHeight.MaximumValue;
                }
                case ParameterType.Width:
                {
                    return this._width.MaximumValue;
                }
                case ParameterType.WallThickness:
                {
                    return this._wallThickness.MaximumValue;
                }
                default:
                {
                    return -1;
                }
            }
        }
        
        /// <summary>
        /// Set parameter by parameterType
        /// </summary>
        /// <param name="value">parameter new value</param>
        /// <param name="parameterType">Parameter type</param>
        public void SetParameterValueByType(dynamic value, ParameterType parameterType)
        {
            switch (parameterType)
            {
                
                case ParameterType.Bottom:
                {
                    this.Bottom = value;
                    break;
                }
                case ParameterType.Height:
                {
                    this.Height = value;
                    break;
                }
                case ParameterType.TopHeight:
                {
                    this.TopHeight = value;
                    break;
                }
                case ParameterType.Width:
                {
                    this.Width = value;
                    break;
                }
                case ParameterType.WallThickness:
                {
                    this.WallThickness = value;
                    break;
                }
            }
        }
    }
}

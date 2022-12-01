using PotBuilder;
using PotParameters;
using KompasConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace FlowerPot
{
    /// <summary>
    /// A class that stores and processes the user interface of the plugin
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// PotBuilder
        /// </summary>
        private Builder _potBuilder;

        /// <summary>
        /// Parameters
        /// </summary>
        private Parameters _potParameters = new Parameters();

        /// <summary>
        /// Variable for connecting with Kompas
        /// </summary>
        private Konnector _kompasConnector = new Konnector();

        /// <summary>
        /// Dictionary of Suggested Pairs (ComboBoxes, parameter name)
        /// </summary>
        private Dictionary<ComboBox, ParameterType> _comboboxDictionary;

        /// <summary>
         /// Main form constructor
         /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _comboboxDictionary = new Dictionary<ComboBox, ParameterType>
            {
                {bottomComboBox, ParameterType.Bottom},
                {topHeightComboBox, ParameterType.TopHeight},
                {heightComboBox, ParameterType.Height},
                {widthComboBox, ParameterType.Width},
                {wallThicknessComboBox, ParameterType.WallThickness},
            };
        }

        /// <summary>
        /// Сonverts a string to a number
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns name="numberResult">Output double</returns>
        private double ConvertStringToDouble(string text)
        {
            double.TryParse(text, out double numberResult);
            return numberResult;
        }
        
        /// <summary>
        /// Event handler "Build" button
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _potParameters.TopHeight = ConvertStringToDouble(topHeightComboBox.Text);
                _potParameters.Bottom = ConvertStringToDouble(bottomComboBox.Text);
                _potParameters.Height = ConvertStringToDouble(heightComboBox.Text);
                _potParameters.Width = ConvertStringToDouble(widthComboBox.Text);
                _potParameters.WallThickness = ConvertStringToDouble(wallThicknessComboBox.Text);

            }
            catch (Exception exception)
            {
                buildButton.Enabled = false;
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OKCancel);
                return;
            }
            try
            {
                _kompasConnector.OpenKompas();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            _potBuilder = new Builder();
            _potBuilder.BuildPot(_kompasConnector, _potParameters);

        }


        /// <summary>
        ///  Event handler button for set default parameters
        /// </summary>
        private void DefaultParametersButton_Click(object sender, EventArgs e)
        {
            _potParameters.SetDefaultParameters();

            topHeightComboBox.Text =
                _potParameters.TopHeight.ToString(CultureInfo.CurrentCulture);
            wallThicknessComboBox.Text = 
                _potParameters.WallThickness.ToString();
            heightComboBox.Text = 
                _potParameters.Height.ToString();
           bottomComboBox.Text = 
               _potParameters.Bottom.ToString();
            widthComboBox.Text = 
                _potParameters.Width.ToString();

            buildButton.Enabled = true;

            topHeightComboBox.BackColor = Color.White;
            handleLengthLabel.BackColor = Color.White;
            heightComboBox.BackColor = Color.White;
            widthComboBox.BackColor = Color.White;
            wallThicknessComboBox.BackColor = Color.White;
        }
        
        /// <summary>
        /// ComboBox validation method
        /// </summary>
        /// <param name="sender">ComboBox</param>
        private void Combobox_Validating(object sender, EventArgs e)
        {
            if (!(sender is ComboBox comboBox)) return;
            try
            {
                _comboboxDictionary.TryGetValue(comboBox,
                    out var parameterInComboboxType);
                _potParameters.SetParameterValueByType(double.Parse(comboBox.Text),
                    parameterInComboboxType);
                comboBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                comboBox.BackColor = Color.Salmon;
            }
            SwitchingBuildButton();
        }


        /// <summary>
        /// Enabled BuildButton if values in all ComboBoxes are correct
        /// </summary>
        /// <returns></returns>
        private void SwitchingBuildButton()
        {
            try
            {
                foreach (var comboBoxParameterTypePair in _comboboxDictionary)
                {
                    double.TryParse(comboBoxParameterTypePair.Key.Text, 
                        out double parameterValue);
                    _potParameters.SetParameterValueByType(
                        parameterValue, comboBoxParameterTypePair.Value);
                }

                buildButton.Enabled = true;
            }
            catch (Exception)
            {
                buildButton.Enabled = false;
            }
        }

        private void flaskWithNeckRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        private Dictionary<TextBox, ParameterType> _textboxDictionary;

        /// <summary>
         /// Main form constructor
         /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _textboxDictionary = new Dictionary<TextBox, ParameterType>
            {
                {bottomTextBox, ParameterType.Bottom},
                {heightTextBox, ParameterType.Height},
                {topHeightTextBox, ParameterType.TopHeight},
                {widthTextBox, ParameterType.Width},
                {wallThicknessTextBox, ParameterType.WallThickness},
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
                _potParameters.Bottom = ConvertStringToDouble(bottomTextBox.Text);
                _potParameters.Height = ConvertStringToDouble(heightTextBox.Text);
                _potParameters.TopHeight = ConvertStringToDouble(topHeightTextBox.Text);
                _potParameters.Width = ConvertStringToDouble(widthTextBox.Text);
                _potParameters.WallThickness = ConvertStringToDouble(wallThicknessTextBox.Text);

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
            // CultureInfo.CurrentCulture
            heightTextBox.Text =
                _potParameters.Height.ToString();
            wallThicknessTextBox.Text = 
                _potParameters.WallThickness.ToString();
            topHeightTextBox.Text =
                _potParameters.TopHeight.ToString();
            bottomTextBox.Text = 
               _potParameters.Bottom.ToString();
            widthTextBox.Text = 
                _potParameters.Width.ToString();

            buildButton.Enabled = true;

            topHeightTextBox.BackColor = Color.White;
            bottomTextBox.BackColor = Color.White;
            heightTextBox.BackColor = Color.White;
            widthTextBox.BackColor = Color.White;
            wallThicknessTextBox.BackColor = Color.White;
        }
        
        /// <summary>
        /// ComboBox validation method
        /// </summary>
        /// <param name="sender">ComboBox</param>
        private void TextBox_Validating(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            try
            {
                _textboxDictionary.TryGetValue(textBox,
                    out var parameterInTextboxType);
                _potParameters.SetParameterValueByType(double.Parse(textBox.Text),
                    parameterInTextboxType);
                if (textBox == heightTextBox)
                {
                    topHeightTextBox.Enabled = true;
                    var upHeightMax =
                        _potParameters.GetMaximumValue(ParameterType.TopHeight);
                    topHeightLabel.Text = $"(50" +
                                             $"-{upHeightMax}) мм";
                }
                textBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (textBox == heightTextBox)
                {
                    topHeightTextBox.Enabled = false;
                }
                textBox.BackColor = Color.Salmon;
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
                foreach (var textBoxParameterTypePair in _textboxDictionary)
                {
                    double.TryParse(textBoxParameterTypePair.Key.Text, 
                        out double parameterValue);
                    _potParameters.SetParameterValueByType(
                        parameterValue, textBoxParameterTypePair.Value);
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

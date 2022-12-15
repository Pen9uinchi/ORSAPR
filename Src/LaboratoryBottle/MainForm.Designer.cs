namespace FlowerPot
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wallThicknessLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.topHeightNameLabel = new System.Windows.Forms.Label();
            this.angleNameLabel = new System.Windows.Forms.Label();
            this.topHeightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.bottomTextBox = new System.Windows.Forms.TextBox();
            this.handleLengthLabel = new System.Windows.Forms.Label();
            this.topHeightTextBox = new System.Windows.Forms.TextBox();
            this.wallThicknessTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.defaultParametersButton = new System.Windows.Forms.Button();
            this.straightPotPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conePotPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.straightPotRadioButton = new System.Windows.Forms.RadioButton();
            this.conePotRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.straightPotPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conePotPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // wallThicknessLabel
            // 
            this.wallThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wallThicknessLabel.AutoSize = true;
            this.wallThicknessLabel.Location = new System.Drawing.Point(267, 154);
            this.wallThicknessLabel.Name = "wallThicknessLabel";
            this.wallThicknessLabel.Size = new System.Drawing.Size(53, 13);
            this.wallThicknessLabel.TabIndex = 8;
            this.wallThicknessLabel.Text = "(7-20) мм";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(267, 124);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(71, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "(200-400) мм";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(267, 37);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(71, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "(100-500) мм";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Толщина стенки (E)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина (D)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота нижней части (B)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры горшка";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10949F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89051F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.Controls.Add(this.topHeightNameLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.angleNameLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.topHeightLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.angleLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.angleTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.heightTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bottomTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.handleLengthLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.topHeightTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessLabel, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.widthTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.widthLabel, 2, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 175);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // topHeightNameLabel
            // 
            this.topHeightNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topHeightNameLabel.AutoSize = true;
            this.topHeightNameLabel.Location = new System.Drawing.Point(3, 66);
            this.topHeightNameLabel.Name = "topHeightNameLabel";
            this.topHeightNameLabel.Size = new System.Drawing.Size(136, 13);
            this.topHeightNameLabel.TabIndex = 0;
            this.topHeightNameLabel.Text = "Высота верхней части (C)";
            // 
            // angleNameLabel
            // 
            this.angleNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.angleNameLabel.AutoSize = true;
            this.angleNameLabel.Location = new System.Drawing.Point(3, 95);
            this.angleNameLabel.Name = "angleNameLabel";
            this.angleNameLabel.Size = new System.Drawing.Size(93, 13);
            this.angleNameLabel.TabIndex = 0;
            this.angleNameLabel.Text = "Угол наклона (C)";
            this.angleNameLabel.Visible = false;
            // 
            // topHeightLabel
            // 
            this.topHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topHeightLabel.AutoSize = true;
            this.topHeightLabel.Location = new System.Drawing.Point(267, 66);
            this.topHeightLabel.Name = "topHeightLabel";
            this.topHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.topHeightLabel.TabIndex = 9;
            this.topHeightLabel.Text = "(50-100) мм";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Толщина дна (A)";
            // 
            // angleLabel
            // 
            this.angleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(267, 95);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(90, 13);
            this.angleLabel.TabIndex = 9;
            this.angleLabel.Text = "(10-45) Градусов";
            this.angleLabel.Visible = false;
            // 
            // angleTextBox
            // 
            this.angleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.angleTextBox.Location = new System.Drawing.Point(149, 91);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(112, 20);
            this.angleTextBox.TabIndex = 14;
            this.angleTextBox.Visible = false;
            this.angleTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightTextBox.Location = new System.Drawing.Point(149, 33);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(112, 20);
            this.heightTextBox.TabIndex = 13;
            this.heightTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // bottomTextBox
            // 
            this.bottomTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bottomTextBox.BackColor = System.Drawing.Color.White;
            this.bottomTextBox.Location = new System.Drawing.Point(149, 4);
            this.bottomTextBox.Name = "bottomTextBox";
            this.bottomTextBox.Size = new System.Drawing.Size(112, 20);
            this.bottomTextBox.TabIndex = 13;
            this.bottomTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // handleLengthLabel
            // 
            this.handleLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.handleLengthLabel.AutoSize = true;
            this.handleLengthLabel.Location = new System.Drawing.Point(267, 8);
            this.handleLengthLabel.Name = "handleLengthLabel";
            this.handleLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.handleLengthLabel.TabIndex = 12;
            this.handleLengthLabel.Text = "(10-30) мм";
            // 
            // topHeightTextBox
            // 
            this.topHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topHeightTextBox.Enabled = false;
            this.topHeightTextBox.Location = new System.Drawing.Point(149, 62);
            this.topHeightTextBox.Name = "topHeightTextBox";
            this.topHeightTextBox.Size = new System.Drawing.Size(112, 20);
            this.topHeightTextBox.TabIndex = 14;
            this.topHeightTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // wallThicknessTextBox
            // 
            this.wallThicknessTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wallThicknessTextBox.Location = new System.Drawing.Point(149, 150);
            this.wallThicknessTextBox.Name = "wallThicknessTextBox";
            this.wallThicknessTextBox.Size = new System.Drawing.Size(112, 20);
            this.wallThicknessTextBox.TabIndex = 13;
            this.wallThicknessTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthTextBox.Enabled = false;
            this.widthTextBox.Location = new System.Drawing.Point(149, 121);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(112, 20);
            this.widthTextBox.TabIndex = 13;
            this.widthTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // buildButton
            // 
            this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buildButton.BackColor = System.Drawing.Color.LightGray;
            this.buildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildButton.Enabled = false;
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(11, 342);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(106, 33);
            this.buildButton.TabIndex = 7;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = false;
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // defaultParametersButton
            // 
            this.defaultParametersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.defaultParametersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.defaultParametersButton.Location = new System.Drawing.Point(123, 342);
            this.defaultParametersButton.Name = "defaultParametersButton";
            this.defaultParametersButton.Size = new System.Drawing.Size(218, 33);
            this.defaultParametersButton.TabIndex = 8;
            this.defaultParametersButton.Text = "Параметры по умолчанию";
            this.defaultParametersButton.UseVisualStyleBackColor = true;
            this.defaultParametersButton.Click += new System.EventHandler(this.DefaultParametersButton_Click);
            // 
            // straightPotPictureBox
            // 
            this.straightPotPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.straightPotPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("straightPotPictureBox.ErrorImage")));
            this.straightPotPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("straightPotPictureBox.Image")));
            this.straightPotPictureBox.Location = new System.Drawing.Point(6, 12);
            this.straightPotPictureBox.Name = "straightPotPictureBox";
            this.straightPotPictureBox.Size = new System.Drawing.Size(319, 302);
            this.straightPotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.straightPotPictureBox.TabIndex = 9;
            this.straightPotPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conePotPictureBox);
            this.groupBox1.Controls.Add(this.straightPotPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(444, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // conePotPictureBox
            // 
            this.conePotPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.conePotPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("conePotPictureBox.ErrorImage")));
            this.conePotPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("conePotPictureBox.Image")));
            this.conePotPictureBox.Location = new System.Drawing.Point(6, 12);
            this.conePotPictureBox.Name = "conePotPictureBox";
            this.conePotPictureBox.Size = new System.Drawing.Size(319, 302);
            this.conePotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conePotPictureBox.TabIndex = 9;
            this.conePotPictureBox.TabStop = false;
            this.conePotPictureBox.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(11, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 106);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор формы";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68293F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.09756F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63415F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tableLayoutPanel3.Controls.Add(this.straightPotRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.conePotRadioButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(410, 82);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // straightPotRadioButton
            // 
            this.straightPotRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.straightPotRadioButton.AutoSize = true;
            this.straightPotRadioButton.Checked = true;
            this.straightPotRadioButton.Location = new System.Drawing.Point(14, 32);
            this.straightPotRadioButton.Name = "straightPotRadioButton";
            this.straightPotRadioButton.Size = new System.Drawing.Size(104, 17);
            this.straightPotRadioButton.TabIndex = 8;
            this.straightPotRadioButton.TabStop = true;
            this.straightPotRadioButton.Text = "Ровный горшок";
            this.straightPotRadioButton.UseVisualStyleBackColor = true;
            // 
            // conePotRadioButton
            // 
            this.conePotRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conePotRadioButton.AutoSize = true;
            this.conePotRadioButton.Location = new System.Drawing.Point(206, 32);
            this.conePotRadioButton.Name = "conePotRadioButton";
            this.conePotRadioButton.Size = new System.Drawing.Size(125, 17);
            this.conePotRadioButton.TabIndex = 8;
            this.conePotRadioButton.Text = "Конический горшок";
            this.conePotRadioButton.UseVisualStyleBackColor = true;
            this.conePotRadioButton.CheckedChanged += new System.EventHandler(this.conePotRadioButton_CheckedChanged_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(137, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.defaultParametersButton);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построитель горшков";
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.straightPotPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conePotPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label wallThicknessLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button defaultParametersButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label topHeightLabel;
        private System.Windows.Forms.Label topHeightNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label handleLengthLabel;
        private System.Windows.Forms.TextBox bottomTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox wallThicknessTextBox;
        private System.Windows.Forms.TextBox topHeightTextBox;
        private System.Windows.Forms.PictureBox straightPotPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton straightPotRadioButton;
        private System.Windows.Forms.RadioButton conePotRadioButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label angleNameLabel;
        private System.Windows.Forms.PictureBox conePotPictureBox;
        private System.Windows.Forms.Label angleLabel;
    }
}


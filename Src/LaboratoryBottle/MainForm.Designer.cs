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
            this.wallThicknessLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.wallThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.widthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.coverRadiusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bottomComboBox = new System.Windows.Forms.ComboBox();
            this.handleLengthLabel = new System.Windows.Forms.Label();
            this.topHeightComboBox = new System.Windows.Forms.ComboBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.defaultParametersButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallThicknessLabel
            // 
            this.wallThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wallThicknessLabel.AutoSize = true;
            this.wallThicknessLabel.Location = new System.Drawing.Point(274, 153);
            this.wallThicknessLabel.Name = "wallThicknessLabel";
            this.wallThicknessLabel.Size = new System.Drawing.Size(53, 13);
            this.wallThicknessLabel.TabIndex = 8;
            this.wallThicknessLabel.Text = "(7-20) мм";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(274, 119);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(71, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "(200-400) мм";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(274, 83);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(71, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "(200-400) мм";
            // 
            // wallThicknessComboBox
            // 
            this.wallThicknessComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wallThicknessComboBox.FormattingEnabled = true;
            this.wallThicknessComboBox.Location = new System.Drawing.Point(152, 149);
            this.wallThicknessComboBox.Name = "wallThicknessComboBox";
            this.wallThicknessComboBox.Size = new System.Drawing.Size(116, 21);
            this.wallThicknessComboBox.TabIndex = 7;
            this.wallThicknessComboBox.TextUpdate += new System.EventHandler(this.Combobox_Validating);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Толщина стенки ";
            // 
            // widthComboBox
            // 
            this.widthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.widthComboBox.FormattingEnabled = true;
            this.widthComboBox.Items.AddRange(new object[] {
            "200",
            "250",
            "300",
            "400"});
            this.widthComboBox.Location = new System.Drawing.Point(152, 115);
            this.widthComboBox.Name = "widthComboBox";
            this.widthComboBox.Size = new System.Drawing.Size(116, 21);
            this.widthComboBox.TabIndex = 6;
            this.widthComboBox.TextUpdate += new System.EventHandler(this.Combobox_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина ";
            // 
            // heightComboBox
            // 
            this.heightComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.heightComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heightComboBox.FormattingEnabled = true;
            this.heightComboBox.Location = new System.Drawing.Point(152, 79);
            this.heightComboBox.Name = "heightComboBox";
            this.heightComboBox.Size = new System.Drawing.Size(116, 21);
            this.heightComboBox.TabIndex = 5;
            this.heightComboBox.TextUpdate += new System.EventHandler(this.Combobox_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота нижней части";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessLabel, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.widthLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.coverRadiusLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessComboBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.heightComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bottomComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.handleLengthLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.topHeightComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.widthComboBox, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 175);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // coverRadiusLabel
            // 
            this.coverRadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coverRadiusLabel.AutoSize = true;
            this.coverRadiusLabel.Location = new System.Drawing.Point(274, 11);
            this.coverRadiusLabel.Name = "coverRadiusLabel";
            this.coverRadiusLabel.Size = new System.Drawing.Size(71, 13);
            this.coverRadiusLabel.TabIndex = 9;
            this.coverRadiusLabel.Text = "(150-350) мм";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Высота верхней части";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Толщина дна";
            // 
            // bottomComboBox
            // 
            this.bottomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomComboBox.FormattingEnabled = true;
            this.bottomComboBox.Location = new System.Drawing.Point(152, 43);
            this.bottomComboBox.Name = "bottomComboBox";
            this.bottomComboBox.Size = new System.Drawing.Size(116, 21);
            this.bottomComboBox.TabIndex = 4;
            this.bottomComboBox.TextUpdate += new System.EventHandler(this.Combobox_Validating);
            // 
            // handleLengthLabel
            // 
            this.handleLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.handleLengthLabel.AutoSize = true;
            this.handleLengthLabel.Location = new System.Drawing.Point(274, 47);
            this.handleLengthLabel.Name = "handleLengthLabel";
            this.handleLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.handleLengthLabel.TabIndex = 12;
            this.handleLengthLabel.Text = "(10-30) мм";
            // 
            // topHeightComboBox
            // 
            this.topHeightComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.topHeightComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.topHeightComboBox.FormattingEnabled = true;
            this.topHeightComboBox.Location = new System.Drawing.Point(152, 7);
            this.topHeightComboBox.Name = "topHeightComboBox";
            this.topHeightComboBox.Size = new System.Drawing.Size(116, 21);
            this.topHeightComboBox.TabIndex = 1;
            this.topHeightComboBox.TextUpdate += new System.EventHandler(this.Combobox_Validating);
            // 
            // buildButton
            // 
            this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buildButton.BackColor = System.Drawing.Color.LightGray;
            this.buildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildButton.Enabled = false;
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(11, 235);
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
            this.defaultParametersButton.Location = new System.Drawing.Point(123, 235);
            this.defaultParametersButton.Name = "defaultParametersButton";
            this.defaultParametersButton.Size = new System.Drawing.Size(218, 33);
            this.defaultParametersButton.TabIndex = 8;
            this.defaultParametersButton.Text = "Параметры по умолчанию";
            this.defaultParametersButton.UseVisualStyleBackColor = true;
            this.defaultParametersButton.Click += new System.EventHandler(this.DefaultParametersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(451, 280);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox widthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox heightComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox wallThicknessComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label wallThicknessLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button defaultParametersButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label coverRadiusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bottomComboBox;
        private System.Windows.Forms.Label handleLengthLabel;
        private System.Windows.Forms.ComboBox topHeightComboBox;
    }
}


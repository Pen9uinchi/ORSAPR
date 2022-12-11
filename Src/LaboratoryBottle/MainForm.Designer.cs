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
            this.topHeightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.handleLengthLabel = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.defaultParametersButton = new System.Windows.Forms.Button();
            this.bottomTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.wallThicknessTextBox = new System.Windows.Forms.TextBox();
            this.topHeightTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallThicknessLabel
            // 
            this.wallThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wallThicknessLabel.AutoSize = true;
            this.wallThicknessLabel.Location = new System.Drawing.Point(272, 153);
            this.wallThicknessLabel.Name = "wallThicknessLabel";
            this.wallThicknessLabel.Size = new System.Drawing.Size(53, 13);
            this.wallThicknessLabel.TabIndex = 8;
            this.wallThicknessLabel.Text = "(7-20) мм";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(272, 119);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(71, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "(200-400) мм";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(272, 47);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(71, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "(100-500) мм";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Толщина стенки (E)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина (D)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота нижней части (B)";
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessLabel, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.widthLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.widthTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.wallThicknessTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.topHeightLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bottomTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.handleLengthLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.topHeightTextBox, 1, 2);
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
            // topHeightLabel
            // 
            this.topHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topHeightLabel.AutoSize = true;
            this.topHeightLabel.Location = new System.Drawing.Point(272, 83);
            this.topHeightLabel.Name = "topHeightLabel";
            this.topHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.topHeightLabel.TabIndex = 9;
            this.topHeightLabel.Text = "(50-100) мм";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Высота верхней части (C)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Толщина дна (A)";
            // 
            // handleLengthLabel
            // 
            this.handleLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.handleLengthLabel.AutoSize = true;
            this.handleLengthLabel.Location = new System.Drawing.Point(272, 11);
            this.handleLengthLabel.Name = "handleLengthLabel";
            this.handleLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.handleLengthLabel.TabIndex = 12;
            this.handleLengthLabel.Text = "(10-30) мм";
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
            // bottomTextBox
            // 
            this.bottomTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bottomTextBox.BackColor = System.Drawing.Color.White;
            this.bottomTextBox.Location = new System.Drawing.Point(151, 8);
            this.bottomTextBox.Name = "bottomTextBox";
            this.bottomTextBox.Size = new System.Drawing.Size(115, 20);
            this.bottomTextBox.TabIndex = 13;
            this.bottomTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightTextBox.Location = new System.Drawing.Point(151, 44);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(115, 20);
            this.heightTextBox.TabIndex = 13;
            this.heightTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthTextBox.Location = new System.Drawing.Point(151, 116);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(115, 20);
            this.widthTextBox.TabIndex = 13;
            this.widthTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // wallThicknessTextBox
            // 
            this.wallThicknessTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wallThicknessTextBox.Location = new System.Drawing.Point(151, 149);
            this.wallThicknessTextBox.Name = "wallThicknessTextBox";
            this.wallThicknessTextBox.Size = new System.Drawing.Size(115, 20);
            this.wallThicknessTextBox.TabIndex = 13;
            this.wallThicknessTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // topHeightTextBox
            // 
            this.topHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topHeightTextBox.Enabled = false;
            this.topHeightTextBox.Location = new System.Drawing.Point(151, 80);
            this.topHeightTextBox.Name = "topHeightTextBox";
            this.topHeightTextBox.Size = new System.Drawing.Size(115, 20);
            this.topHeightTextBox.TabIndex = 14;
            this.topHeightTextBox.TextChanged += new System.EventHandler(this.TextBox_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(444, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(787, 280);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label handleLengthLabel;
        private System.Windows.Forms.TextBox bottomTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox wallThicknessTextBox;
        private System.Windows.Forms.TextBox topHeightTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


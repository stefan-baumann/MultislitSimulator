namespace MultislitSimulator.Ui
{
    partial class MultislitConfigurator
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LightModeComboBox = new System.Windows.Forms.ComboBox();
            this.LightSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrightnessNumeric = new System.Windows.Forms.NumericUpDown();
            this.LightSourceFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddLightSourceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new AeroSuite.Controls.AeroLinkLabel();
            this.GitHubLinkLabel = new AeroSuite.Controls.AeroLinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.HighResRenderButton = new AeroSuite.Controls.CommandLink();
            this.SaveButton = new AeroSuite.Controls.CommandLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScaleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SlitCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LightSourceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlitCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LightModeComboBox);
            this.panel1.Controls.Add(this.LightSourceGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(348, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 254);
            this.panel1.TabIndex = 0;
            // 
            // LightModeComboBox
            // 
            this.LightModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LightModeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LightModeComboBox.FormattingEnabled = true;
            this.LightModeComboBox.Items.AddRange(new object[] {
            "Visible Light",
            "Custom"});
            this.LightModeComboBox.Location = new System.Drawing.Point(86, 4);
            this.LightModeComboBox.Name = "LightModeComboBox";
            this.LightModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.LightModeComboBox.TabIndex = 0;
            this.LightModeComboBox.SelectedIndexChanged += new System.EventHandler(this.LightModeComboBox_SelectedIndexChanged);
            // 
            // LightSourceGroupBox
            // 
            this.LightSourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LightSourceGroupBox.Controls.Add(this.label3);
            this.LightSourceGroupBox.Controls.Add(this.BrightnessNumeric);
            this.LightSourceGroupBox.Controls.Add(this.LightSourceFlowPanel);
            this.LightSourceGroupBox.Controls.Add(this.AddLightSourceButton);
            this.LightSourceGroupBox.Location = new System.Drawing.Point(5, 7);
            this.LightSourceGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.LightSourceGroupBox.Name = "LightSourceGroupBox";
            this.LightSourceGroupBox.Size = new System.Drawing.Size(329, 242);
            this.LightSourceGroupBox.TabIndex = 0;
            this.LightSourceGroupBox.TabStop = false;
            this.LightSourceGroupBox.Text = "Light Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brightness:";
            // 
            // BrightnessNumeric
            // 
            this.BrightnessNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessNumeric.DecimalPlaces = 1;
            this.BrightnessNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BrightnessNumeric.Location = new System.Drawing.Point(258, 22);
            this.BrightnessNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BrightnessNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BrightnessNumeric.Name = "BrightnessNumeric";
            this.BrightnessNumeric.Size = new System.Drawing.Size(65, 22);
            this.BrightnessNumeric.TabIndex = 5;
            this.BrightnessNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BrightnessNumeric.ValueChanged += new System.EventHandler(this.BrightnessNumeric_ValueChanged);
            // 
            // LightSourceFlowPanel
            // 
            this.LightSourceFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LightSourceFlowPanel.AutoScroll = true;
            this.LightSourceFlowPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LightSourceFlowPanel.Location = new System.Drawing.Point(6, 50);
            this.LightSourceFlowPanel.Name = "LightSourceFlowPanel";
            this.LightSourceFlowPanel.Size = new System.Drawing.Size(317, 157);
            this.LightSourceFlowPanel.TabIndex = 1;
            // 
            // AddLightSourceButton
            // 
            this.AddLightSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLightSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddLightSourceButton.Location = new System.Drawing.Point(5, 212);
            this.AddLightSourceButton.Name = "AddLightSourceButton";
            this.AddLightSourceButton.Size = new System.Drawing.Size(319, 25);
            this.AddLightSourceButton.TabIndex = 0;
            this.AddLightSourceButton.Text = "+";
            this.AddLightSourceButton.UseVisualStyleBackColor = true;
            this.AddLightSourceButton.Click += new System.EventHandler(this.AddLightSourceButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 254);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EmailLinkLabel);
            this.groupBox2.Controls.Add(this.GitHubLinkLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.HighResRenderButton);
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Location = new System.Drawing.Point(2, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Multislit Simulator v1.0";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(282, 138);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.EmailLinkLabel.TabIndex = 13;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "Contact";
            this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
            this.GitHubLinkLabel.Location = new System.Drawing.Point(285, 123);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(44, 13);
            this.GitHubLinkLabel.TabIndex = 12;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "GitHub";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Copyright © 2016 Stefan Baumann";
            // 
            // HighResRenderButton
            // 
            this.HighResRenderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighResRenderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HighResRenderButton.Location = new System.Drawing.Point(6, 72);
            this.HighResRenderButton.Name = "HighResRenderButton";
            this.HighResRenderButton.Note = "";
            this.HighResRenderButton.Size = new System.Drawing.Size(323, 45);
            this.HighResRenderButton.TabIndex = 10;
            this.HighResRenderButton.Text = "Render high resolution image";
            this.HighResRenderButton.UseVisualStyleBackColor = true;
            this.HighResRenderButton.Click += new System.EventHandler(this.HighResRenderButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.Location = new System.Drawing.Point(6, 21);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Note = "";
            this.SaveButton.Size = new System.Drawing.Size(323, 45);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save current rendering";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ScaleNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SlitCountNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slit Configuration";
            // 
            // ScaleNumeric
            // 
            this.ScaleNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleNumeric.DecimalPlaces = 1;
            this.ScaleNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleNumeric.Location = new System.Drawing.Point(264, 50);
            this.ScaleNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScaleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleNumeric.Name = "ScaleNumeric";
            this.ScaleNumeric.Size = new System.Drawing.Size(65, 22);
            this.ScaleNumeric.TabIndex = 3;
            this.ScaleNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleNumeric.ValueChanged += new System.EventHandler(this.ScaleNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scale:";
            // 
            // SlitCountNumeric
            // 
            this.SlitCountNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlitCountNumeric.Location = new System.Drawing.Point(264, 22);
            this.SlitCountNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SlitCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SlitCountNumeric.Name = "SlitCountNumeric";
            this.SlitCountNumeric.Size = new System.Drawing.Size(65, 22);
            this.SlitCountNumeric.TabIndex = 1;
            this.SlitCountNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SlitCountNumeric.ValueChanged += new System.EventHandler(this.SlitCountNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slit Count:";
            // 
            // MultislitConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "MultislitConfigurator";
            this.Size = new System.Drawing.Size(690, 260);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LightSourceGroupBox.ResumeLayout(false);
            this.LightSourceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlitCountNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox LightSourceGroupBox;
        private System.Windows.Forms.ComboBox LightModeComboBox;
        private System.Windows.Forms.Button AddLightSourceButton;
        private System.Windows.Forms.FlowLayoutPanel LightSourceFlowPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BrightnessNumeric;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ScaleNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SlitCountNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AeroSuite.Controls.CommandLink HighResRenderButton;
        private AeroSuite.Controls.CommandLink SaveButton;
        private System.Windows.Forms.Label label4;
        private AeroSuite.Controls.AeroLinkLabel GitHubLinkLabel;
        private AeroSuite.Controls.AeroLinkLabel EmailLinkLabel;
        private System.Windows.Forms.Label label5;
    }
}

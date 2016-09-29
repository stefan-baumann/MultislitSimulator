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
            this.LightSourceFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddLightSourceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SlitCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LightSourceGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlitCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LightModeComboBox);
            this.panel1.Controls.Add(this.LightSourceGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(348, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 317);
            this.panel1.TabIndex = 0;
            // 
            // LightModeComboBox
            // 
            this.LightModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.LightSourceGroupBox.Controls.Add(this.LightSourceFlowPanel);
            this.LightSourceGroupBox.Controls.Add(this.AddLightSourceButton);
            this.LightSourceGroupBox.Location = new System.Drawing.Point(5, 7);
            this.LightSourceGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.LightSourceGroupBox.Name = "LightSourceGroupBox";
            this.LightSourceGroupBox.Size = new System.Drawing.Size(329, 305);
            this.LightSourceGroupBox.TabIndex = 0;
            this.LightSourceGroupBox.TabStop = false;
            this.LightSourceGroupBox.Text = "Light Source";
            // 
            // LightSourceFlowPanel
            // 
            this.LightSourceFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LightSourceFlowPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LightSourceFlowPanel.Location = new System.Drawing.Point(6, 21);
            this.LightSourceFlowPanel.Name = "LightSourceFlowPanel";
            this.LightSourceFlowPanel.Size = new System.Drawing.Size(317, 249);
            this.LightSourceFlowPanel.TabIndex = 1;
            // 
            // AddLightSourceButton
            // 
            this.AddLightSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLightSourceButton.Location = new System.Drawing.Point(5, 275);
            this.AddLightSourceButton.Name = "AddLightSourceButton";
            this.AddLightSourceButton.Size = new System.Drawing.Size(319, 25);
            this.AddLightSourceButton.TabIndex = 0;
            this.AddLightSourceButton.Text = "+";
            this.AddLightSourceButton.UseVisualStyleBackColor = true;
            this.AddLightSourceButton.Click += new System.EventHandler(this.AddLightSourceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SlitCountNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slit Configuration";
            // 
            // SlitCountNumeric
            // 
            this.SlitCountNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlitCountNumeric.Location = new System.Drawing.Point(264, 22);
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
            this.Size = new System.Drawing.Size(690, 323);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LightSourceGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlitCountNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox LightSourceGroupBox;
        private System.Windows.Forms.ComboBox LightModeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SlitCountNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddLightSourceButton;
        private System.Windows.Forms.FlowLayoutPanel LightSourceFlowPanel;
    }
}

namespace MultislitSimulator.Ui
{
    partial class LightColorSelector
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.WavelengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WavelengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WavelengthNumeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ColorPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(190, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(57, 24);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "X";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // WavelengthNumeric
            // 
            this.WavelengthNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WavelengthNumeric.Location = new System.Drawing.Point(128, 4);
            this.WavelengthNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.WavelengthNumeric.Maximum = new decimal(new int[] {
            679,
            0,
            0,
            0});
            this.WavelengthNumeric.Minimum = new decimal(new int[] {
            431,
            0,
            0,
            0});
            this.WavelengthNumeric.Name = "WavelengthNumeric";
            this.WavelengthNumeric.Size = new System.Drawing.Size(56, 22);
            this.WavelengthNumeric.TabIndex = 1;
            this.WavelengthNumeric.Value = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.WavelengthNumeric.ValueChanged += new System.EventHandler(this.WavelengthNumeric_ValueChanged);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(6, 4);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(113, 22);
            this.ColorPanel.TabIndex = 2;
            // 
            // LightColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "LightColorSelector";
            this.Size = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WavelengthNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.NumericUpDown WavelengthNumeric;
        private System.Windows.Forms.Panel ColorPanel;
    }
}

namespace MultislitSimulator.Ui
{
    partial class HighResRenderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighResRenderDialog));
            this.RenderButton = new AeroSuite.Controls.CommandLink();
            this.WidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.captionLabel1 = new AeroSuite.Controls.CaptionLabel();
            this.HeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ScaleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MainProgressBar = new AeroSuite.Controls.AeroProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderButton
            // 
            this.RenderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RenderButton.Location = new System.Drawing.Point(12, 201);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Note = "";
            this.RenderButton.Size = new System.Drawing.Size(276, 45);
            this.RenderButton.TabIndex = 0;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // WidthNumeric
            // 
            this.WidthNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthNumeric.Location = new System.Drawing.Point(223, 76);
            this.WidthNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.WidthNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthNumeric.Name = "WidthNumeric";
            this.WidthNumeric.Size = new System.Drawing.Size(65, 22);
            this.WidthNumeric.TabIndex = 5;
            this.WidthNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // captionLabel1
            // 
            this.captionLabel1.AutoSize = true;
            this.captionLabel1.Location = new System.Drawing.Point(8, 9);
            this.captionLabel1.Name = "captionLabel1";
            this.captionLabel1.Size = new System.Drawing.Size(189, 21);
            this.captionLabel1.TabIndex = 6;
            this.captionLabel1.Text = "High Resolution Renderer";
            // 
            // HeightNumeric
            // 
            this.HeightNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.HeightNumeric.Location = new System.Drawing.Point(223, 104);
            this.HeightNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.HeightNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.HeightNumeric.Name = "HeightNumeric";
            this.HeightNumeric.Size = new System.Drawing.Size(65, 22);
            this.HeightNumeric.TabIndex = 8;
            this.HeightNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Height:";
            // 
            // ScaleNumeric
            // 
            this.ScaleNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleNumeric.DecimalPlaces = 1;
            this.ScaleNumeric.Location = new System.Drawing.Point(223, 132);
            this.ScaleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleNumeric.Name = "ScaleNumeric";
            this.ScaleNumeric.Size = new System.Drawing.Size(65, 22);
            this.ScaleNumeric.TabIndex = 10;
            this.ScaleNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scale:";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProgressBar.Location = new System.Drawing.Point(12, 172);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(276, 23);
            this.MainProgressBar.State = AeroSuite.Controls.ProgressBarState.Normal;
            this.MainProgressBar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "This renderer creates higher-resolution images with superier quality over the nor" +
    "mal renderer.";
            // 
            // HighResRenderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(300, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.ScaleNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captionLabel1);
            this.Controls.Add(this.WidthNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RenderButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighResRenderDialog";
            this.Text = "Multislit Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AeroSuite.Controls.CommandLink RenderButton;
        private System.Windows.Forms.NumericUpDown WidthNumeric;
        private System.Windows.Forms.Label label2;
        private AeroSuite.Controls.CaptionLabel captionLabel1;
        private System.Windows.Forms.NumericUpDown HeightNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ScaleNumeric;
        private System.Windows.Forms.Label label3;
        private AeroSuite.Controls.AeroProgressBar MainProgressBar;
        private System.Windows.Forms.Label label4;
    }
}
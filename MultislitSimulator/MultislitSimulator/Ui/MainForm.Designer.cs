namespace MultislitSimulator.Ui
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.multislitRenderingSurface1 = new MultislitSimulator.Rendering.MultislitRenderingSurface();
            this.SuspendLayout();
            // 
            // multislitRenderingSurface1
            // 
            this.multislitRenderingSurface1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.multislitRenderingSurface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multislitRenderingSurface1.Location = new System.Drawing.Point(0, 0);
            this.multislitRenderingSurface1.Name = "multislitRenderingSurface1";
            this.multislitRenderingSurface1.Size = new System.Drawing.Size(734, 511);
            this.multislitRenderingSurface1.TabIndex = 0;
            this.multislitRenderingSurface1.Text = "multislitRenderingSurface1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.multislitRenderingSurface1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "MainForm";
            this.Text = "Multislit Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private Rendering.MultislitRenderingSurface multislitRenderingSurface1;
    }
}


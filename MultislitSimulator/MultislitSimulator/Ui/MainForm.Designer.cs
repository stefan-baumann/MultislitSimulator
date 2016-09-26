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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RenderingSurface = new MultislitSimulator.Rendering.MultislitRenderingSurface();
            this.Configurator = new MultislitSimulator.Ui.MultislitConfigurator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RenderingSurface);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Configurator);
            this.splitContainer1.Size = new System.Drawing.Size(734, 511);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // RenderingSurface
            // 
            this.RenderingSurface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.RenderingSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderingSurface.Location = new System.Drawing.Point(0, 0);
            this.RenderingSurface.Name = "RenderingSurface";
            this.RenderingSurface.Size = new System.Drawing.Size(734, 243);
            this.RenderingSurface.TabIndex = 0;
            this.RenderingSurface.Text = "multislitRenderingSurface1";
            // 
            // Configurator
            // 
            this.Configurator.BackColor = System.Drawing.SystemColors.Window;
            this.Configurator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Configurator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Configurator.Location = new System.Drawing.Point(0, 0);
            this.Configurator.Name = "Configurator";
            this.Configurator.Size = new System.Drawing.Size(734, 264);
            this.Configurator.TabIndex = 0;
            this.Configurator.ConfigurationChanged += new System.EventHandler(this.Configurator_ConfigurationChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "MainForm";
            this.Text = "Multislit Simulator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Rendering.MultislitRenderingSurface RenderingSurface;
        private MultislitConfigurator Configurator;
    }
}


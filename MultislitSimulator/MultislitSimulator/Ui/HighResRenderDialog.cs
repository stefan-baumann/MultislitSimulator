using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MultislitSimulator.Rendering;
using MultislitSimulator.Utilities;

namespace MultislitSimulator.Ui
{
    public partial class HighResRenderDialog : Form
    {
        public HighResRenderDialog(MultislitConfiguration configuration)
        {
            this.Configuration = configuration;

            this.InitializeComponent();
        }

        protected MultislitConfiguration Configuration { get; set; }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            this.Configuration.Scale = (double) this.ScaleNumeric.Value;

            foreach (Control c in this.Controls.OfType<Control>().Where(c => !(c is ProgressBar)))
            {
                c.Enabled = false;
            }

            ProgressProvider progress = new ProgressProvider((s, a) => this.Invoke((Action)(() => this.MainProgressBar.Value = (int)(100 * (s as ProgressProvider).Progress))));
            Thread renderThread = new Thread((ThreadStart)(() =>
            {
                Bitmap rendered = MultislitRenderer.RenderHighRes(this.Configuration, new Size((int) this.WidthNumeric.Value, (int) this.HeightNumeric.Value), progress);
                this.Invoke((Action) (() =>
                {
                    ImageSavingHelper.Save(rendered);
                    this.Close();
                }));
            }));

            renderThread.Start();
        }
    }
}

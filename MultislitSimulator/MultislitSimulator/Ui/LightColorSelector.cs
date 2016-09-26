using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultislitSimulator.Rendering;

namespace MultislitSimulator.Ui
{
    public partial class LightColorSelector : UserControl
    {
        public LightColorSelector()
        {
            InitializeComponent();

            this.UpdateSelection();
        }

        public WavelengthColorPair Selection { get; set; }

        public event EventHandler Updated;
        public event EventHandler Remove;

        protected void UpdateSelection()
        {
            //Something is really, really wrong with the further processing of the selection (the spectrum is interpreted the wrong way around)
            //I'll have to look into that in the future - will leave it as it is for the moment
            this.Selection = new WavelengthColorPair((double)this.WavelengthNumeric.Value);
            this.ColorPanel.BackColor = this.Selection.Color;

            this.Updated?.Invoke(this, EventArgs.Empty);
        }

        private void WavelengthNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateSelection();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.Remove?.Invoke(this, EventArgs.Empty);
        }
    }
}

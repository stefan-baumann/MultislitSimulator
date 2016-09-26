/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultislitSimulator.Rendering;

namespace MultislitSimulator.Ui
{
    public partial class MultislitConfigurator : UserControl
    {
        public MultislitConfigurator()
        {
            InitializeComponent();
            this.LightModeComboBox.SelectedIndex = 0;
            this.RecreateConfiguration();
        }

        public MultislitConfiguration Configuration { get; set; }

        public event EventHandler ConfigurationChanged;
        protected void OnConfigurationChanged()
        {
            this.ConfigurationChanged?.Invoke(this, EventArgs.Empty);
        }

        protected void RecreateConfiguration()
        {
            int slits = (int)this.SlitCountNumeric.Value;
            double brightness = 1;
            IEnumerable<WavelengthColorPair> lightSources;
            if (this.LightModeComboBox.SelectedIndex == 0)
            {
                int quality = 25;
                lightSources = this.CreateVisibleLightSource(quality);
                brightness = (slits * Math.Pow(0.95, slits)) / quality;
            }
            else
            {
                //Todo: Custom light source
                lightSources = Enumerable.Empty<WavelengthColorPair>();
            }

            this.Configuration = new Rendering.MultislitConfiguration(slits, brightness, lightSources);

            this.OnConfigurationChanged();
        }

        protected IEnumerable<WavelengthColorPair> CreateVisibleLightSource(int quality)
        {
            double start = 430;
            double end = 660;
            double step = (end - start) / (quality - 1);

            for (double w = start, i = 0; i < quality; w += step, i++)
            {
                yield return new WavelengthColorPair(w);
            }

            yield break;
        }



        private void LightModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LightModeComboBox.SelectedIndex == 0)
            {
                foreach(Control c in this.LightSourceGroupBox.Controls)
                {
                    c.Enabled = false;
                }
            }
            else
            {
                foreach (Control c in this.LightSourceGroupBox.Controls)
                {
                    c.Enabled = true;
                }
            }

            this.RecreateConfiguration();
        }

        private void SlitCountNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.RecreateConfiguration();
        }
    }
}

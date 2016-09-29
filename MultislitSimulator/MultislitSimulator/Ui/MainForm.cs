/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using MultislitSimulator.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultislitSimulator.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            this.RenderingSurface.Configuration = this.Configurator.Configuration;
        }
        
        private void Configurator_ConfigurationChanged(object sender, EventArgs e)
        {
            this.RenderingSurface.Configuration = this.Configurator.Configuration;
        }
    }
}

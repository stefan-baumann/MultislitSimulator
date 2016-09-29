/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultislitSimulator
{
    /// <summary>
    /// Main class of the application with the entry-point method.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry-point when the application is launched.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultislitSimulator.Ui.MainForm());
        }
    }
}

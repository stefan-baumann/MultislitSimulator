/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultislitSimulator.Ui
{
    /// <summary>
    /// Provides a simple way to save an image with an extensive save file dialog.
    /// </summary>
    public static class ImageSavingHelper
    {
        /// <summary>
        /// Saves the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns><c>true</c> if the image was saved successfully.</returns>
        public static bool Save(Image image)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    AutoUpgradeEnabled = true,
                    CheckPathExists = true,
                    DefaultExt = "png",
                    DereferenceLinks = true,
                    FileName = "Multislit Rendering.png",
                    Filter = "Portable Network Graphics (*.png)|*.png|Jpeg (*.jpg, *.jpeg)|*.jpg;*.jpeg",
                    FilterIndex = 0,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    ValidateNames = true,
                    OverwritePrompt = true,
                    Title = "Save Rendering"
                }
            )
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image.Save(dialog.FileName);
                    return true;
                }

                return false;
            }
        }
    }
}

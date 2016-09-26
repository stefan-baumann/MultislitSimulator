/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using MultislitSimulator.Physics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// Provides methods for rendering the result of shining a number of lights onto a single-, double- or n-slit.
    /// </summary>
    public static class MultislitRenderer
    {
        /// <summary>
        /// Renders an image of the specified multislit configuration.
        /// </summary>
        /// <param name="configuration">The multislit configuration.</param>
        /// <param name="size">The image size.</param>
        /// <returns>A rendering of the specified multislit configuration</returns>
        public static Bitmap Render(MultislitConfiguration configuration, Size size)
        {
            return MultislitRenderer.Render(configuration, size, 1);
        }

        /// <summary>
        /// Renders an image of the specified multislit configuration.
        /// </summary>
        /// <param name="configuration">The multislit configuration.</param>
        /// <param name="size">The image size.</param>
        /// <param name="scale">The scale.</param>
        /// <returns>A rendering of the specified multislit configuration</returns>
        public static Bitmap Render(MultislitConfiguration configuration, Size size, double scale)
        {
            return MultislitRenderer.Render(configuration, size, scale, 10);
        }

        /// <summary>
        /// Renders an image of the specified multislit configuration.
        /// </summary>
        /// <param name="configuration">The multislit configuration.</param>
        /// <param name="size">The image size.</param>
        /// <param name="scale">The scale.</param>
        /// <param name="quality">The quality (higher is better).</param>
        /// <returns>A rendering of the specified multislit configuration</returns>
        public static Bitmap Render(MultislitConfiguration configuration, Size size, double scale, int quality)
        {
            double colorRadius = 1 / scale;
            double[] yBrightnessFactors = CalculateYBrightnessDistribution(configuration, size.Height, scale, colorRadius, quality);

            using (FastBitmap target = new FastBitmap(size, Color.FromArgb(10, 10, 10)))
            {
                int chunkSize = 50;
                Parallel.For(0, (int)Math.Ceiling(size.Width / (double)chunkSize), i =>
                {
                    for (int ix = i * chunkSize; ix < Math.Min(i * chunkSize + chunkSize, size.Width); ix++)
                    {
                        double x = (ix - size.Width * 0.5) / scale;
                        RgbColor xColor = configuration.Brightness * MultislitRenderer.CalculateColorAt(configuration, x, colorRadius, quality);

                        for (int iy = 0; iy < size.Height; iy++)
                        {
                            target[ix, iy] = yBrightnessFactors[iy] * xColor;
                        }
                    }
                });

                return (Bitmap)target.InternalBitmap.Clone();
            }
        }

        /// <summary>
        /// Calculates the overall color at a specific location.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="x">The location x.</param>
        /// <param name="radius">The analyzation radius.</param>
        /// <param name="quality">The quality (higher is better).</param>
        /// <returns>The overall color at a specific location.</returns>
        private static RgbColor CalculateColorAt(MultislitConfiguration configuration, double x, double radius, int quality)
        {
            RgbColor result = new RgbColor(0, 0, 0);
            foreach (WavelengthColorPair light in configuration.LightSources)
            {
                result = result + (light.Color * MultiSlitIntensityCalculator.CalculateIntensity(light.Wavelength, configuration.Slits, x, radius, quality));
            }

            return result;
        }

        /// <summary>
        /// Calculates the vertical brightness distribution.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="height">The screen height.</param>
        /// <param name="scale">The scale.</param>
        /// <param name="radius">The analyzation radius.</param>
        /// <param name="quality">The quality (higher is better).</param>
        /// <returns>The vertical brightness distribution.</returns>
        private static double[] CalculateYBrightnessDistribution(MultislitConfiguration configuration, int height, double scale, double radius, int quality)
        {
            double[] brightnessFactors = new double[height];
            for (int iy = 0; iy < height; iy++)
            {
                double y = (iy - height * 0.5) / scale;

                //This formula actually has no scientific base but it is damn close to the reality
                double brightness = (10 / Math.Pow(1.25, Math.Abs(y / 2.5)));

                brightnessFactors[iy] = brightness;
            }

            return brightnessFactors;
        }
    }
}
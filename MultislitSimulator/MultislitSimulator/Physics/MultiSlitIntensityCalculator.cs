/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 * 
 * Some of the formulas used in this code file are taken from the following document: https://www.physnet.uni-hamburg.de/TUHH/Versuchsanleitung/Beugung_am_Spalt.pdf
 */

using MultislitSimulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Physics
{
    /// <summary>
    /// Provides methods for calculating the intensity of specific points of a single-, double- or n-slit interference pattern.
    /// </summary>
    public static class MultiSlitIntensityCalculator
    {
        /// <summary>
        /// Calculates the intensity at a specified location.
        /// </summary>
        /// <param name="wavelength">The light wavelength.</param>
        /// <param name="n">The number of slits.</param>
        /// <param name="x">The location (the horizontal distance from the middle of the screen).</param>
        /// <param name="radius">The radius in which the values should be calcualted.</param>
        /// <returns></returns>
        public static double CalculateIntensity(double wavelength, double n, double x, double radius)
        {
            return MultiSlitIntensityCalculator.CalculateIntensity(wavelength, n, x, radius, 5);
        }

        /// <summary>
        /// Calculates the intensity at a specified location.
        /// </summary>
        /// <param name="wavelength">The light wavelength.</param>
        /// <param name="n">The number of slits.</param>
        /// <param name="x">The location (the horizontal distance from the middle of the screen).</param>
        /// <param name="radius">The radius in which the values should be calcualted.</param>
        /// <param name="iterations">The iteration count - the higher it is, the higher the precision.</param>
        /// <returns></returns>
        public static double CalculateIntensity(double wavelength, double n, double x, double radius, int iterations)
        {
            double step = (2 * radius) / iterations;
            List<double> results = new List<double>();
            for (double x1 = x - radius; x1 <= x + radius; x1 += step)
            {
                double xx = (7.5 / wavelength) * x1;
                double i = (1 / Math.Pow(n, 2)) * Math.Pow(Math.Sin(.25 * Math.PI * xx) / (.25 * Math.PI * xx), 2) * Math.Pow(Math.Sin(n * Math.PI * xx) / Math.Sin(Math.PI * xx), 2);
                if (!double.IsNaN(i))
                {
                    results.Add(i.Clamp(0, 1));
                }
            }

            if (results.Count == 0)
            {
                return 1;
            }

            return results.Average();
        }
    }
}

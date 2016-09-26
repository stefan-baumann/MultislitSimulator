/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using MultislitSimulator.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// A helper class which contains a tuple of a wavelength and a rgb color.
    /// </summary>
    public class WavelengthColorPair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WavelengthColorPair"/> class.
        /// </summary>
        /// <param name="wavelength">The wavelength of the light source; the color will be automatically chosen.</param>
        public WavelengthColorPair(double wavelength)
            : this(wavelength, VisibleLightSpectrum.GetNearestColor(wavelength))
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavelengthColorPair"/> class.
        /// </summary>
        /// <param name="wavelength">The wavelength of the light source.</param>
        /// <param name="color">The color of the light source.</param>
        public WavelengthColorPair(double wavelength, RgbColor color)
        {
            this.Wavelength = wavelength;
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets the wavelength of the light source.
        /// </summary>
        /// <value>
        /// The wavelength of the light source.
        /// </value>
        public double Wavelength { get; set; }

        /// <summary>
        /// Gets or sets the color of the light source.
        /// </summary>
        /// <value>
        /// The color of the light source.
        /// </value>
        public RgbColor Color { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"WavelengthColorPair [ Wavelength: {this.Wavelength:#.000}: Color: {this.Color} ]";
        }
    }
}

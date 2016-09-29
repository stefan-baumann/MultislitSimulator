/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS0660
#pragma warning disable CS0661

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// Provides configuration details for a <see cref="MultislitRenderer"/>.
    /// </summary>
    public class MultislitConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultislitConfiguration" /> class.
        /// </summary>
        /// <param name="slits">The slit count.</param>
        /// <param name="scale">The display scale.</param>
        /// <param name="brightness">The overall brightness.</param>
        /// <param name="lightSources">The light sources.</param>
        public MultislitConfiguration(int slits, double scale, double brightness, IEnumerable<WavelengthColorPair> lightSources)
        {
            this.Slits = slits;
            this.Scale = scale;
            this.Brightness = brightness;
            this.LightSources = lightSources;
        }

        /// <summary>
        /// Returns the amount of slits.
        /// </summary>
        /// <value>
        /// The amount of slits.
        /// </value>
        public int Slits { get; protected internal set; }

        /// <summary>
        /// Returns the display scale.
        /// </summary>
        /// <value>
        /// The display scale.
        /// </value>
        public double Scale { get; protected internal set; }

        /// <summary>
        /// Returns the overall brightness.
        /// </summary>
        /// <value>
        /// The overall brightness.
        /// </value>
        public double Brightness { get; protected internal set; }

        /// <summary>
        /// Returns the light sources.
        /// </summary>
        /// <value>
        /// The light sources.
        /// </value>
        public IEnumerable<WavelengthColorPair> LightSources { get; protected internal set; }
    }
}

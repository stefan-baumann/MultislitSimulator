﻿/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// Provides configuration details for a <see cref="MultislitRenderer"/>.
    /// </summary>
    public class MultislitConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultislitConfiguration"/> class.
        /// </summary>
        /// <param name="slits">The slit count.</param>
        /// <param name="brightness">The overall brightness.</param>
        /// <param name="lightSources">The light sources.</param>
        public MultislitConfiguration(int slits, double brightness, IEnumerable<WavelengthColorPair> lightSources)
        {
            this.Slits = slits;
            this.Brightness = brightness;
            this.LightSources = lightSources;
        }

        /// <summary>
        /// Returns the amount of slits.
        /// </summary>
        /// <value>
        /// The amount of slits.
        /// </value>
        public int Slits { get; protected set; }

        /// <summary>
        /// Returns the overall brightness.
        /// </summary>
        /// <value>
        /// The overall brightness.
        /// </value>
        public double Brightness { get; protected set; }

        /// <summary>
        /// Returns the light sources.
        /// </summary>
        /// <value>
        /// The light sources.
        /// </value>
        public IEnumerable<WavelengthColorPair> LightSources { get; protected set; }
    }
}
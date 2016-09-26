/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using MultislitSimulator.Rendering;
using MultislitSimulator.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Physics
{
    /// <summary>
    /// A color represented in the RGB-colorspace. Other than most implementations of RGB color object implementation, this one uses the proper method for calculating with the values. The scale is from <c>0.0</c> to <c>1.0</c> but higher values are allowed for convenience.
    /// </summary>
    /// <remarks>
    /// This implementation uses the correct way to calculate in the RGB-colorspace: Most programmers oversee the fact, that the color components are not linear but that they are derived from the square root of photon flux. This has to be taken into account when implementing anything in the field of physics.
    /// </remarks>
    public class RgbColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RgbColor"/> class.
        /// </summary>
        /// <param name="r">The red component.</param>
        /// <param name="g">The green component.</param>
        /// <param name="b">The blue component.</param>
        public RgbColor(double r, double g, double b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        /// <summary>
        /// The red component of this <see cref="RgbColor"/>.
        /// </summary>
        /// <value>
        /// The red component.
        /// </value>
        public double R { get; private set; }

        /// <summary>
        /// The green component of this <see cref="RgbColor"/>.
        /// </summary>
        /// <value>
        /// The green component.
        /// </value>
        public double G { get; private set; }

        /// <summary>
        /// The blue component of this <see cref="RgbColor"/>.
        /// </summary>
        /// <value>
        /// The blue component.
        /// </value>
        public double B { get; private set; }

        /// <summary>
        /// Performs an implicit conversion from <see cref="RgbColor"/> to <see cref="Color"/>.
        /// </summary>
        /// <param name="rgb">The RGB.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Color(RgbColor rgb)
        {
            return Color.FromArgb((byte)(rgb.R * 255).Clamp(0, 255), (byte)(rgb.G * 255).Clamp(0, 255), (byte)(rgb.B * 255).Clamp(0, 255));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Color"/> to <see cref="RgbColor"/>.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RgbColor(Color color)
        {
            return new RgbColor(color.R / 255d, color.G / 255d, color.B / 255d);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="RgbColor"/> to <see cref="FastColor"/>.
        /// </summary>
        /// <param name="rgb">The RGB.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator FastColor(RgbColor rgb)
        {
            return new FastColor((byte)(rgb.R * 255).Clamp(0, 255), (byte)(rgb.G * 255).Clamp(0, 255), (byte)(rgb.B * 255).Clamp(0, 255));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="FastColor"/> to <see cref="RgbColor"/>.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RgbColor(FastColor color)
        {
            return new RgbColor(color.R / 255d, color.G / 255d, color.B / 255d);
        }

        /// <summary>
        /// Adds the two specified <see cref="RgbColor"/> instances.
        /// </summary>
        /// <param name="left">The left <see cref="RgbColor"/> instance.</param>
        /// <param name="right">The right <see cref="RgbColor"/> instance.</param>
        /// <returns>
        /// The sum of the two specified <see cref="RgbColor"/> instances.
        /// </returns>
        public static RgbColor operator +(RgbColor left, RgbColor right)
        {
            double r = Math.Sqrt(Math.Pow(left.R, 2) + Math.Pow(right.R, 2));
            double g = Math.Sqrt(Math.Pow(left.G, 2) + Math.Pow(right.G, 2));
            double b = Math.Sqrt(Math.Pow(left.B, 2) + Math.Pow(right.B, 2));

            return new RgbColor(r, g, b);
        }

        /// <summary>
        /// Adjusts the brightness of the specified <see cref="RgbColor" /> instance.
        /// </summary>
        /// <param name="f">The factor.</param>
        /// <param name="rgb">The <see cref="RgbColor" /> instance.</param>
        /// <returns>
        /// The adjusted <see cref="RgbColor" /> instance.
        /// </returns>
        public static RgbColor operator *(double f, RgbColor rgb)
        {
            double r = Math.Sqrt(f * Math.Pow(rgb.R, 2));
            double g = Math.Sqrt(f * Math.Pow(rgb.G, 2));
            double b = Math.Sqrt(f * Math.Pow(rgb.B, 2));

            return new RgbColor(r, g, b);
        }

        /// <summary>
        /// Adjusts the brightness of the specified <see cref="RgbColor"/> instance.
        /// </summary>
        /// <param name="rgb">The <see cref="RgbColor"/> instance.</param>
        /// <param name="f">The factor.</param>
        /// <returns>
        /// The adjusted <see cref="RgbColor"/> instance.
        /// </returns>
        public static RgbColor operator *(RgbColor rgb, double f)
        {
            return f * rgb;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"RgbColor [ R: {this.R:#.000}, G: {this.G:#.000}, B: {this.B:#.000} ]";
        }
    }
}

/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultislitSimulator.Rendering
{
    /// <summary>
    /// Represents a color in the RGB colorspace.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct FastColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FastColor"/> struct.
        /// </summary>
        /// <param name="r">The red component value.</param>
        /// <param name="g">The green component value.</param>
        /// <param name="b">The blue component value.</param>
        public FastColor(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        [FieldOffset(0)]
        private byte r;
        /// <summary>
        /// The red component value of this color.
        /// </summary>
        public byte R
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }

        [FieldOffset(1)]
        private byte g;
        /// <summary>
        /// The green component value of this color.
        /// </summary>
        public byte G
        {
            get
            {
                return this.g;
            }
            set
            {
                this.g = value;
            }
        }

        [FieldOffset(2)]
        private byte b;
        /// <summary>
        /// The blue component value of this color.
        /// </summary>
        public byte B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        /// <summary>
        /// Tests whether the two specified <see cref="FastColor"/> structures are equivalent.
        /// </summary>
        /// <param name="left">The first specified <see cref="FastColor"/> structure.</param>
        /// <param name="right">The second specified <see cref="FastColor"/> structure.</param>
        /// <returns>
        /// A value indicating whether the two specified <see cref="FastColor"/> structures are equivalent.
        /// </returns>
        public static bool operator ==(FastColor left, FastColor right)
        {
            return left.R == right.R && left.G == right.G && left.B == right.B;
        }

        /// <summary>
        /// Tests whether the two specified <see cref="FastColor"/> structures are different.
        /// </summary>
        /// <param name="left">The first specified <see cref="FastColor"/> structure.</param>
        /// <param name="right">The second specified <see cref="FastColor"/> structure.</param>
        /// <returns>
        /// A value indicating whether the two specified <see cref="FastColor"/> structures are different.
        /// </returns>
        public static bool operator !=(FastColor left, FastColor right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj != null && obj is FastColor && (FastColor)obj == this;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return (this.r << 16 | this.g << 8 | this.b).GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"FastColor [ R: {this.R}, G: {this.G}, B: {this.B} ]";
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="FastColor"/> to <see cref="Color"/>.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Color(FastColor color)
        {
            return Color.FromArgb(color.r, color.g, color.b);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Color"/> to <see cref="FastColor"/>.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator FastColor(Color color)
        {
            return new FastColor(color.R, color.G, color.B);
        }
    }
}

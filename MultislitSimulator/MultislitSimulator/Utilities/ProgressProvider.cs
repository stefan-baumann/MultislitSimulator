/* Copyright (c) 2016 Stefan Baumann
 * This code is distributed under the terms of the MIT License (https://opensource.org/licenses/MIT)
 * GitHub Repository: https://github.com/stefan-baumann/MultislitSimulator
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultislitSimulator.Utilities
{
    /// <summary>
    /// Provides a simple way to report progresses.
    /// </summary>
    public class ProgressProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressProvider"/> class.
        /// </summary>
        /// <param name="handler">The progress update handler.</param>
        public ProgressProvider(Action handler)
        {
            this.ProgressChanged += (s, e) => handler();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressProvider"/> class.
        /// </summary>
        /// <param name="handler">The progress update handler.</param>
        public ProgressProvider(EventHandler handler)
        {
            this.ProgressChanged += handler;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressProvider"/> class.
        /// </summary>
        public ProgressProvider()
        { }

        /// <summary>
        /// Gets raised when the specified progress has changed.
        /// </summary>
        public event EventHandler ProgressChanged;

        private double progress = 0;
        /// <summary>
        /// Gets or sets the progress.
        /// </summary>
        /// <value>
        /// The progress.
        /// </value>
        public double Progress
        {
            get
            {
                return this.progress;
            }
            set
            {
                this.progress = value.Clamp(0, 1);
                this.ProgressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

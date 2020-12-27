// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinearCongruenceGenerator.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The linear congruence generator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LCG
{
    using System;

    /// <summary>
    /// The linear congruence generator.
    /// </summary>
    public class LinearCongruenceGenerator
    {
        /// <summary>
        /// The a value.
        /// </summary>
        private long localA;

        /// <summary>
        /// The b value.
        /// </summary>
        private long localB;

        /// <summary>
        /// The m value.
        /// </summary>
        private long localM;

        /// <summary>
        /// The y value.
        /// </summary>
        private long localY;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearCongruenceGenerator"/> class.
        /// </summary>
        /// <param name="m">The m value.</param>
        /// <param name="a">The a value.</param>
        /// <param name="b">The b value.</param>
        /// <param name="y">The y value.</param>
        public LinearCongruenceGenerator(long m, long a, long b, long y)
        {
            this.Init(m, a, b, y);
        }

        /// <summary>
        /// Generates a new <see cref="long"/> value.
        /// </summary>
        /// <returns>A new <see cref="long"/> value.</returns>
        // ReSharper disable once UnusedMember.Global
        public long NextLong()
        {
            this.localY = ((this.localA * this.localY) + this.localB) % this.localM;
            return this.localY;
        }

        /// <summary>
        /// Generates a new <see cref="int"/> value.
        /// </summary>
        /// <returns>A new <see cref="int"/> value.</returns>
        // ReSharper disable once UnusedMember.Global
        public int NextInt()
        {
            this.localY = ((this.localA * this.localY) + this.localB) % this.localM;
            return (int)this.localY;
        }

        /// <summary>
        /// Generates a new <see cref="double"/> value.
        /// </summary>
        /// <returns>A new <see cref="double"/> value.</returns>
        // ReSharper disable once UnusedMember.Global
        public double NextDouble()
        {
            this.localY = ((this.localA * this.localY) + this.localB) % this.localM;
            return this.localY;
        }

        /// <summary>
        /// Checks whether there is an initialized error or not.
        /// </summary>
        /// <param name="m">The m value.</param>
        /// <param name="a">The a value.</param>
        /// <param name="b">The b value.</param>
        /// <returns>A value indicating whether there is an initialized error or not.</returns>
        // ReSharper disable ParameterOnlyUsedForPreconditionCheck.Local
        private static bool CheckForInitError(long m, long a, long b)
        {
            if (a >= m)
            {
                throw new TypeLoadException("Parameter a mustn't bee larger or equal to m");
            }

            if (b >= m)
            {
                throw new TypeLoadException("Parameter b mustn't bee larger or equal to m");
            }

            return false;
        }

        /// <summary>
        /// Initializes the generator.
        /// </summary>
        /// <param name="m">The m value.</param>
        /// <param name="a">The a value.</param>
        /// <param name="b">The b value.</param>
        /// <param name="y">The y value.</param>
        private void Init(long m, long a, long b, long y)
        {
            if (!CheckForInitError(m, a, b))
            {
                this.SetInit(m, a, b, y);
            }
        }

        /// <summary>
        /// Sets the initialized values.
        /// </summary>
        /// <param name="m">The m value.</param>
        /// <param name="a">The a value.</param>
        /// <param name="b">The b value.</param>
        /// <param name="y">The y value.</param>
        private void SetInit(long m, long a, long b, long y)
        {
            this.localM = m;
            this.localA = a;
            this.localB = b;
            this.localY = y;
        }
    }
}
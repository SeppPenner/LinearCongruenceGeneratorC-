// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExampleUsage.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class that shows the example usage.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LCG
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// A class that shows the example usage.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public class ExampleUsage
    {
        /// <summary>
        /// An example generator.
        /// See https://en.wikipedia.org/wiki/Linear_congruential_generator for good parameters.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        // ReSharper disable once UnusedMember.Local
        private LinearCongruenceGenerator random = new LinearCongruenceGenerator((long)Math.Pow(2, 32), 1664525, 1013904223, 0);
    }
}

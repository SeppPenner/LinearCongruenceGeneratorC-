// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExampleUsage.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class that shows the example usage.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LCG;

/// <summary>
/// A class that shows the example usage.
/// </summary>
public class ExampleUsage
{
    /// <summary>
    /// An example generator.
    /// See https://en.wikipedia.org/wiki/Linear_congruential_generator for good parameters.
    /// </summary>
    private LinearCongruenceGenerator random = new((long)Math.Pow(2, 32), 1664525, 1013904223, 0);
}

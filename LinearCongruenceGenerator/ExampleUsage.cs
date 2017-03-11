using System;

namespace LCG
{
    public class ExampleUsage
    {
        private LinearCongruenceGenerator _random = new LinearCongruenceGenerator((long) Math.Pow(2, 32), 1664525,
            1013904223, 0);
    }
}

//See https://en.wikipedia.org/wiki/Linear_congruential_generator for good parameters
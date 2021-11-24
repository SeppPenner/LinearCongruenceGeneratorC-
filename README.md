# LinearCongruenceGenerator
Linear Congruence Generator implementation in C#.

[![Build status](https://ci.appveyor.com/api/projects/status/t0v8qsktgau2fh96?svg=true)](https://ci.appveyor.com/project/SeppPenner/linearcongruencegeneratorc)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/stargazers)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/SeppPenner/LinearCongruenceGeneratorC-/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/LinearCongruenceGeneratorC-/badge.svg)](https://snyk.io/test/github/SeppPenner/LinearCongruenceGeneratorC-)

Link to Linear Congruence Generator implementation in Java:
https://github.com/SeppPenner/LinearCongruenceGenerator/blob/master/README.md

## Basic usage
```csharp
public class ExampleUsage
{
    private LinearCongruenceGenerator _random = new LinearCongruenceGenerator(
        (long)Math.Pow(2, 32), 1664525, 1013904223, 0);
}
```
See https://en.wikipedia.org/wiki/Linear_congruential_generator for good parameters.

Change history
--------------

See the [Changelog](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/blob/master/Changelog.md).
# LinearCongruenceGenerator
Linear Congruence Generator implementation in C#.

This assembly was written and tested in .Net 4.8.

[![Build status](https://ci.appveyor.com/api/projects/status/t0v8qsktgau2fh96?svg=true)](https://ci.appveyor.com/project/SeppPenner/linearcongruencegeneratorc)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/LinearCongruenceGeneratorC-.svg)](https://github.com/SeppPenner/LinearCongruenceGeneratorC-/stargazers)
[![GitHub license](https://img.shields.io/badge/license-AGPL-blue.svg)](https://raw.githubusercontent.com/SeppPenner/LinearCongruenceGeneratorC-/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/LinearCongruenceGeneratorC-/badge.svg)](https://snyk.io/test/github/SeppPenner/LinearCongruenceGeneratorC-)

Link to Linear Congruence Generator implementation in Java:
https://github.com/SeppPenner/LinearCongruenceGenerator/blob/master/README.md

## Basic usage:
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

* **Version 1.0.1.0 (2019-10-27)** : Updated nuget packages, added GitVersionTask.
* **Version 1.0.0.1 (2019-05-06)** : Updated .Net version to 4.8.
* **Version 1.0.0.0 (2017-03-11)** : Switched to .Net 4.6.2 and added license.
* **Version 1.0.0.0 (2016-12-03)** : Added basic usage to Readme.
* **Version 1.0.0.0 (2016-11-17)** : 1.0 release.
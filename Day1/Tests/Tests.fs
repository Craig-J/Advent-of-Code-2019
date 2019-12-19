open NUnit.Framework
open Program

[<TestCase(10, 1)>]
[<TestCase(14, 2)>]
[<TestCase(1969, 966)>]
[<TestCase(100756, 50346)>]
let Test1 (mass:float, expectedFuel:float) =
    Assert.AreEqual(expectedFuel, fuelForModule mass)

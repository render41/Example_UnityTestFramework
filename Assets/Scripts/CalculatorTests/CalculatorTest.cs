using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CalculatorTest
{
    [Test]
    public void CalculatorTestAdd()
    {
        var calculator = new GameObject().AddComponent<Calculator>();
        var result = calculator.CalculatorPlus(2, 3);
        Assert.AreEqual(5, result);
    }
}

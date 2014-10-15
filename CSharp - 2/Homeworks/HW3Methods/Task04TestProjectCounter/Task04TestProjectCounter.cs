using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// You can read about test projects here: http://www.youtube.com/watch?v=nzbh8o8tqJw after 1:55:00

[TestClass]
public class Task04TestProjectCounter
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] array = {1,1,2,1,3};
        int result =Task04NumberCounter.ElementCounting(array,1);
        Assert.AreEqual(3, result);

    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] array = { 1, 1, 2, 1, 3 };
        int result = Task04NumberCounter.ElementCounting(array, 2);
        Assert.AreEqual(1, result);

    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] array = { 1, 1, 2, 1, 3 };
        int result = Task04NumberCounter.ElementCounting(array,9);
        Assert.AreEqual(0, result);

    }

}
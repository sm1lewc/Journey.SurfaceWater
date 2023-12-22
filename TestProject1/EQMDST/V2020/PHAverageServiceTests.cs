namespace Journey.SurfaceWater.EQMDST.V2020.Tests;

[TestClass()]
public class PHAverageServiceTests
{
    [TestMethod()]
    public void CalculatePHAverageTest()
    {
        List<decimal> lists = [6.5m, 7.9m, 8.8m, 9m, 6.78m, 8.87m];
        var tmp = PHAverageService.CalculatePHAverage(lists);
        Assert.AreEqual("7.08", tmp?.ToString("f2"));
    }
}
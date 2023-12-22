using Microsoft.VisualStudio.TestTools.UnitTesting;
using Journey.SurfaceWater.EQMDST.V2020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.SurfaceWater.EQMDST.V2020.Tests;

[TestClass()]
public class RoundingServiceTests
{
    [TestMethod()]
    public void GetAssessmentDecimalPlacesTest()
    {
        var se = RoundingService.GetAssessmentDecimalPlaces("se");
        Assert.AreEqual(4, se);
    }

    [TestMethod()]
    public void GetHourdataDecimalPlacesTest()
    {
        var nh3n = RoundingService.GetHourdataDecimalPlaces("nh3n");
        Assert.AreEqual(3, nh3n);
    }

    [TestMethod()]
    public void RoundingToEvenTest()
    {
        var tmp1 = RoundingService.RoundingToEven(0.0034m, 3);
        Assert.AreEqual(0.003m, tmp1);
        var tmp2 = RoundingService.RoundingToEven(0.0035m, 3);
        Assert.AreEqual(0.004m, tmp2);
        var tmp3 = RoundingService.RoundingToEven(0.0045m, 3);
        Assert.AreEqual(0.004m, tmp3);
        var tmp4 = RoundingService.RoundingToEven(0.00005m, 3);
        Assert.AreEqual(0.00005m, tmp4);

    }
}
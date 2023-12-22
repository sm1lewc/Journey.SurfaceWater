using Microsoft.VisualStudio.TestTools.UnitTesting;
using Journey.SurfaceWater.Factors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journey.SurfaceWater.EQMDST.V2020;

namespace Journey.SurfaceWater.Factors.Tests;

[TestClass()]
public class FactorServiceTests
{
    [TestMethod()]
    public void GetFactorNameTest()
    {
        var tmp = FactorService.GetFactorName("w21003");
        Assert.AreEqual("氨氮", tmp);
        var tmp2 = FactorService.GetFactorName("w210003");
        Assert.AreEqual(null, tmp2);
    }

    [TestMethod()]
    public void GetFactorEnumTest()
    {
        var tmp = FactorService.GetFactorEnum("w21003");
        Assert.AreEqual(Enums.Factor.氨氮, tmp);
        var tmp2 = FactorService.GetFactorEnum("w210003");
        Assert.AreEqual(null, tmp2);
    }

    [TestMethod()]
    public void GetFactorAbbreviationByNameTest()
    {
        var tmp = FactorService.GetFactorAbbreviationByName(Enums.Factor.氨氮);
        Assert.AreEqual("NH3N", tmp);

    }

    [TestMethod()]
    public void GetFactorCodeByNameTest()
    {
        var tmp = FactorService.GetFactorCodeByName(Enums.Factor.氨氮);
        Assert.AreEqual("w21003", tmp);
    }

    [TestMethod()]
    public void GetFactorAbbreviationByCodeTest()
    {
        var tmp = FactorService.GetFactorAbbreviationByCode("w21003");
        Assert.AreEqual("NH3N", tmp);
        var tmp2 = FactorService.GetFactorAbbreviationByCode("W21003");
        Assert.AreEqual("NH3N", tmp2);
    }

    [TestMethod()]
    public void GetFactorCodeByAbbreviationTest()
    {
         var tmp = FactorService.GetFactorCodeByAbbreviation("NH3N");
        Assert.AreEqual("w21003", tmp);
        var tmp2 = FactorService.GetFactorCodeByAbbreviation("nh3n");
        Assert.AreEqual("w21003", tmp2);
    }
}
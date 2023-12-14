using Journey.SurfaceWater.EQSFSW.V2002;
using Journey.SurfaceWater.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1;

[TestClass]
public class GradeServiceTests
{

    [TestMethod()]
    public void GetWaterGradeTest()
    {
       


        BasicItemValues values = new()
        {
            PH = 6.5,
            DO = 8.5,
            CODMN = 2.0,
            COD = 15.0,
            BOD5 = 2.0,
            NH3N = 0.15,
            TP = 0.02,
            TN = 0.5,
            CU = 0.01,
            ZN = 0.05,
            F = 1.0,
            SE = 0.01,
            AS = 0.01,
            HG = 0.0001,
            CD = 0.001,
            CR6 = 0.005,
            PB = 0.01,
            CN = 0.01,
            PHEN = 0.002,
            TPH = 0.05,
            LAS = 0.5,
            H2S = 0.1,
            FC = 1000
        };

        var result = GradeService.GetWaterGrade(values);

        Assert.IsNotNull(result);

        //Assert.Fail();
    }

}
using Journey.SurfaceWater.Models;
using System.Collections.Generic;

namespace Journey.SurfaceWater.EQSFSW.V2002
{
    /// <summary>
    /// 标准限值的相关方法
    /// </summary>
    public class StandardLimitService
    {
        /// <summary>
        /// 获取PH的标准限值范围
        /// </summary>
        /// <returns></returns>
        public static (double, double) GetPHLimit()
        {
            return (6, 9);
        }

        /// <summary>
        /// 获取溶解氧Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetDOLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 7.5},
                new StandardLimit(){Grade = 2,Limit = 6},
                new StandardLimit(){Grade = 3,Limit = 5},
                new StandardLimit(){Grade = 4,Limit = 3},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取溶解氧的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetDOLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 7.5,
                Enums.WaterGrade.Ⅱ => 6,
                Enums.WaterGrade.Ⅲ => 5,
                Enums.WaterGrade.Ⅳ => 3,
                Enums.WaterGrade.Ⅴ => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取高锰酸盐指数Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCODMNLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 2},
                new StandardLimit(){Grade = 2,Limit = 4},
                new StandardLimit(){Grade = 3,Limit = 6},
                new StandardLimit(){Grade = 4,Limit = 10},
                new StandardLimit(){Grade = 5,Limit = 15}
            };
        }

        /// <summary>
        /// 根据水质类别获取高锰酸盐指数的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCODMNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 2,
                Enums.WaterGrade.Ⅱ => 4,
                Enums.WaterGrade.Ⅲ => 6,
                Enums.WaterGrade.Ⅳ => 10,
                Enums.WaterGrade.Ⅴ => 15,
                _ => null,
            };
        }

        /// <summary>
        /// 获取化学需氧量Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCODLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 15},
                new StandardLimit(){Grade = 2,Limit = 15},
                new StandardLimit(){Grade = 3,Limit = 20},
                new StandardLimit(){Grade = 4,Limit = 30},
                new StandardLimit(){Grade = 5,Limit = 40}
            };
        }

        /// <summary>
        /// 根据水质类别获取化学需氧量的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCODLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 15,
                Enums.WaterGrade.Ⅱ => 15,
                Enums.WaterGrade.Ⅲ => 20,
                Enums.WaterGrade.Ⅳ => 30,
                Enums.WaterGrade.Ⅴ => 40,
                _ => null,
            };
        }

        /// <summary>
        /// 获取五日生化需氧量Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetBOD5Limits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 3},
                new StandardLimit(){Grade = 2,Limit = 3},
                new StandardLimit(){Grade = 3,Limit = 4},
                new StandardLimit(){Grade = 4,Limit = 6},
                new StandardLimit(){Grade = 5,Limit = 10}
            };
        }

        /// <summary>
        /// 根据水质类别获取五日生化需氧量的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetBOD5LimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 3,
                Enums.WaterGrade.Ⅱ => 3,
                Enums.WaterGrade.Ⅲ => 4,
                Enums.WaterGrade.Ⅳ => 6,
                Enums.WaterGrade.Ⅴ => 10,
                _ => null,
            };
        }

        /// <summary>
        /// 获取氨氮Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetNH3NLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.15},
                new StandardLimit(){Grade = 2,Limit = 0.5},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取氨氮的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetNH3NLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.15,
                Enums.WaterGrade.Ⅱ => 0.5,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5,
                Enums.WaterGrade.Ⅴ => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取总磷Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <param name="waterBody">河流/湖库</param>
        /// <returns></returns>
        public static List<StandardLimit> GetTPLimits(Enums.WaterBody waterBody = Enums.WaterBody.河流)
        {
            if (waterBody == Enums.WaterBody.湖库) return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.025},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.1},
                new StandardLimit(){Grade = 5,Limit = 0.2}
            };
            else return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.02},
                new StandardLimit(){Grade = 2,Limit = 0.1},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.3},
                new StandardLimit(){Grade = 5,Limit = 0.4}
            };
        }

        /// <summary>
        /// 根据水质类别获取总磷的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="waterBody">河流/湖库</param>
        /// <returns></returns>
        public static double? GetTPLimitByGrade(Enums.WaterGrade grade, Enums.WaterBody waterBody = Enums.WaterBody.河流)
        {
            if (waterBody == Enums.WaterBody.湖库) return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01,
                Enums.WaterGrade.Ⅱ => 0.025,
                Enums.WaterGrade.Ⅲ => 0.05,
                Enums.WaterGrade.Ⅳ => 0.1,
                Enums.WaterGrade.Ⅴ => 0.2,
                _ => null,
            };
            else return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.02,
                Enums.WaterGrade.Ⅱ => 0.1,
                Enums.WaterGrade.Ⅲ => 0.2,
                Enums.WaterGrade.Ⅳ => 0.3,
                Enums.WaterGrade.Ⅴ => 0.4,
                _ => null,
            };
        }

        /// <summary>
        /// 获取总氮Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetTNLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.2},
                new StandardLimit(){Grade = 2,Limit = 0.5},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取总氮的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetTNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.2,
                Enums.WaterGrade.Ⅱ => 0.5,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5,
                Enums.WaterGrade.Ⅴ => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取铜Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCULimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1},
                new StandardLimit(){Grade = 5,Limit = 1}
            };
        }

        /// <summary>
        /// 根据水质类别获取铜的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCULimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01,
                Enums.WaterGrade.Ⅱ => 1,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1,
                Enums.WaterGrade.Ⅴ => 1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取锌Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetZNLimits()
        {
            return new List<StandardLimit>()
            {
                 new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 2},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取锌的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetZNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05,
                Enums.WaterGrade.Ⅱ => 1,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 2,
                Enums.WaterGrade.Ⅴ => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取氟化物Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetFLimits()
        {
            return new List<StandardLimit>()
            {
               new StandardLimit(){Grade = 1,Limit = 1},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 1.5}
            };
        }

        /// <summary>
        /// 根据水质类别获取氟化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetFLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 1,
                Enums.WaterGrade.Ⅱ => 1,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5,
                Enums.WaterGrade.Ⅴ => 1.5,
                _ => null,
            };
        }

        /// <summary>
        /// 获取硒Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetSELimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.01},
                new StandardLimit(){Grade = 3,Limit = 0.01},
                new StandardLimit(){Grade = 4,Limit = 0.02},
                new StandardLimit(){Grade = 5,Limit = 0.02}
            };
        }

        /// <summary>
        /// 根据水质类别获取硒的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetSELimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01,
                Enums.WaterGrade.Ⅱ => 0.01,
                Enums.WaterGrade.Ⅲ => 0.01,
                Enums.WaterGrade.Ⅳ => 0.02,
                Enums.WaterGrade.Ⅴ => 0.02,
                _ => null,
            };
        }

        /// <summary>
        /// 获取砷Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetASLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.1},
                new StandardLimit(){Grade = 5,Limit = 0.1}
            };
        }

        /// <summary>
        /// 根据水质类别获取砷的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetASLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05,
                Enums.WaterGrade.Ⅱ => 0.05,
                Enums.WaterGrade.Ⅲ => 0.05,
                Enums.WaterGrade.Ⅳ => 0.1,
                Enums.WaterGrade.Ⅴ => 0.1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取汞Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetHGLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.00005},
                new StandardLimit(){Grade = 2,Limit = 0.00005},
                new StandardLimit(){Grade = 3,Limit = 0.0001},
                new StandardLimit(){Grade = 4,Limit = 0.001},
                new StandardLimit(){Grade = 5,Limit = 0.001}
            };
        }

        /// <summary>
        /// 根据水质类别获取汞的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetHGLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.00005,
                Enums.WaterGrade.Ⅱ => 0.00005,
                Enums.WaterGrade.Ⅲ => 0.0001,
                Enums.WaterGrade.Ⅳ => 0.001,
                Enums.WaterGrade.Ⅴ => 0.001,
                _ => null,
            };
        }

        /// <summary>
        /// 获取镉Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCDLimits()
        {
            return new List<StandardLimit>()
            {
               new StandardLimit(){Grade = 1,Limit = 0.001},
                new StandardLimit(){Grade = 2,Limit = 0.005},
                new StandardLimit(){Grade = 3,Limit = 0.005},
                new StandardLimit(){Grade = 4,Limit = 0.005},
                new StandardLimit(){Grade = 5,Limit = 0.01}
            };
        }

        /// <summary>
        /// 根据水质类别获取镉的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCDLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.001,
                Enums.WaterGrade.Ⅱ => 0.005,
                Enums.WaterGrade.Ⅲ => 0.005,
                Enums.WaterGrade.Ⅳ => 0.005,
                Enums.WaterGrade.Ⅴ => 0.01,
                _ => null,
            };
        }

        /// <summary>
        /// 获取六价铬Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCR6Limits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.05},
                new StandardLimit(){Grade = 5,Limit = 0.1}
            };
        }

        /// <summary>
        /// 根据水质类别获取六价铬的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCR6LimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01,
                Enums.WaterGrade.Ⅱ => 0.05,
                Enums.WaterGrade.Ⅲ => 0.05,
                Enums.WaterGrade.Ⅳ => 0.05,
                Enums.WaterGrade.Ⅴ => 0.1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取铅Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetPBLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.01},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.05},
                new StandardLimit(){Grade = 5,Limit = 0.1}
            };
        }


        /// <summary>
        /// 根据水质类别获取铅的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetPBLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01,
                Enums.WaterGrade.Ⅱ => 0.01,
                Enums.WaterGrade.Ⅲ => 0.05,
                Enums.WaterGrade.Ⅳ => 0.05,
                Enums.WaterGrade.Ⅴ => 0.1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取氰化物Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetCNLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.005},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.2},
                new StandardLimit(){Grade = 5,Limit = 0.2}
            };
        }

        /// <summary>
        /// 根据水质类别获取氰化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.005,
                Enums.WaterGrade.Ⅱ => 0.05,
                Enums.WaterGrade.Ⅲ => 0.2,
                Enums.WaterGrade.Ⅳ => 0.2,
                Enums.WaterGrade.Ⅴ => 0.2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取挥发酚Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetPHENLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.002},
                new StandardLimit(){Grade = 2,Limit = 0.002},
                new StandardLimit(){Grade = 3,Limit = 0.005},
                new StandardLimit(){Grade = 4,Limit = 0.01},
                new StandardLimit(){Grade = 5,Limit = 0.1}
            };
        }

        /// <summary>
        /// 根据水质类别获取挥发酚的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double?  GetPHENLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.002,
                Enums.WaterGrade.Ⅱ => 0.002,
                Enums.WaterGrade.Ⅲ => 0.005,
                Enums.WaterGrade.Ⅳ => 0.01,
                Enums.WaterGrade.Ⅴ => 0.1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取石油类Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetTPHLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.5},
                new StandardLimit(){Grade = 5,Limit = 1}
            };
        }

        /// <summary>
        /// 根据水质类别获取石油类的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetTPHLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05,
                Enums.WaterGrade.Ⅱ => 0.05,
                Enums.WaterGrade.Ⅲ => 0.05,
                Enums.WaterGrade.Ⅳ => 0.5,
                Enums.WaterGrade.Ⅴ => 1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取阴离子表面活性剂Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetLASLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.2},
                new StandardLimit(){Grade = 2,Limit = 0.2},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.3},
                new StandardLimit(){Grade = 5,Limit = 0.3}
            };
        }

        /// <summary>
        /// 根据水质类别获取阴离子表面活性剂的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetLASLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.2,
                Enums.WaterGrade.Ⅱ => 0.2,
                Enums.WaterGrade.Ⅲ => 0.2,
                Enums.WaterGrade.Ⅳ => 0.3,
                Enums.WaterGrade.Ⅴ => 0.3,
                _ => null,
            };
        }

        /// <summary>
        /// 获取硫化物Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetH2SLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.1},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.5},
                new StandardLimit(){Grade = 5,Limit = 1}
            };
        }

        /// <summary>
        /// 根据水质类别获取硫化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetH2SLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05,
                Enums.WaterGrade.Ⅱ => 0.1,
                Enums.WaterGrade.Ⅲ => 0.2,
                Enums.WaterGrade.Ⅳ => 0.5,
                Enums.WaterGrade.Ⅴ => 1,
                _ => null,
            };
        }

        /// <summary>
        /// 获取粪大肠菌群Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> GetFCLimits()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 200},
                new StandardLimit(){Grade = 2,Limit = 2000},
                new StandardLimit(){Grade = 3,Limit = 10000},
                new StandardLimit(){Grade = 4,Limit = 20000},
                new StandardLimit(){Grade = 5,Limit = 40000}
            };
        }

        /// <summary>
        /// 根据水质类别获取粪大肠菌群的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetFCLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 200,
                Enums.WaterGrade.Ⅱ => 2000,
                Enums.WaterGrade.Ⅲ => 10000,
                Enums.WaterGrade.Ⅳ => 20000,
                Enums.WaterGrade.Ⅴ => 40000,
                _ => null,
            };
        }
    }
}

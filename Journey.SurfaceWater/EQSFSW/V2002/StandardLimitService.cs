﻿using Journey.SurfaceWater.Enums;
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
        public static (decimal, decimal) GetPHLimit()
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
                new StandardLimit(){Grade = 1,Limit = 7.5m},
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
        public static decimal? GetDOLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 7.5m,
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
        public static decimal? GetCODMNLimitByGrade(Enums.WaterGrade grade)
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
        public static decimal? GetCODLimitByGrade(Enums.WaterGrade grade)
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
        public static decimal? GetBOD5LimitByGrade(Enums.WaterGrade grade)
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
                new StandardLimit(){Grade = 1,Limit = 0.15m},
                new StandardLimit(){Grade = 2,Limit = 0.5m},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5m},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取氨氮的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetNH3NLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.15m,
                Enums.WaterGrade.Ⅱ => 0.5m,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5m,
                Enums.WaterGrade.Ⅴ => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 获取总磷Ⅰ-Ⅴ类标准限值
        /// </summary>
        /// <param name="waterBody">河流/湖库</param>
        /// <returns></returns>
        public static List<StandardLimit> GetTPLimits(Enums.Waterbody waterBody = Enums.Waterbody.河流)
        {
            if (waterBody == Enums.Waterbody.湖库) return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01m},
                new StandardLimit(){Grade = 2,Limit = 0.025m},
                new StandardLimit(){Grade = 3,Limit = 0.05m},
                new StandardLimit(){Grade = 4,Limit = 0.1m},
                new StandardLimit(){Grade = 5,Limit = 0.2m}
            };
            else return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.02m},
                new StandardLimit(){Grade = 2,Limit = 0.1m},
                new StandardLimit(){Grade = 3,Limit = 0.2m},
                new StandardLimit(){Grade = 4,Limit = 0.3m},
                new StandardLimit(){Grade = 5,Limit = 0.4m}
            };
        }

        /// <summary>
        /// 根据水质类别获取总磷的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="waterBody">河流/湖库</param>
        /// <returns></returns>
        public static decimal? GetTPLimitByGrade(Enums.WaterGrade grade, Enums.Waterbody waterBody = Enums.Waterbody.河流)
        {
            if (waterBody == Enums.Waterbody.湖库) return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01m,
                Enums.WaterGrade.Ⅱ => 0.025m,
                Enums.WaterGrade.Ⅲ => 0.05m,
                Enums.WaterGrade.Ⅳ => 0.1m,
                Enums.WaterGrade.Ⅴ => 0.2m,
                _ => null,
            };
            else return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.02m,
                Enums.WaterGrade.Ⅱ => 0.1m,
                Enums.WaterGrade.Ⅲ => 0.2m,
                Enums.WaterGrade.Ⅳ => 0.3m,
                Enums.WaterGrade.Ⅴ => 0.4m,
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
                new StandardLimit(){Grade = 1,Limit = 0.2m},
                new StandardLimit(){Grade = 2,Limit = 0.5m},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5m},
                new StandardLimit(){Grade = 5,Limit = 2}
            };
        }

        /// <summary>
        /// 根据水质类别获取总氮的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetTNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.2m,
                Enums.WaterGrade.Ⅱ => 0.5m,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5m,
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
                new StandardLimit(){Grade = 1,Limit = 0.01m},
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
        public static decimal? GetCULimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01m,
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
                 new StandardLimit(){Grade = 1,Limit = 0.05m},
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
        public static decimal? GetZNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05m,
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
                new StandardLimit(){Grade = 4,Limit = 1.5m},
                new StandardLimit(){Grade = 5,Limit = 1.5m}
            };
        }

        /// <summary>
        /// 根据水质类别获取氟化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetFLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 1,
                Enums.WaterGrade.Ⅱ => 1,
                Enums.WaterGrade.Ⅲ => 1,
                Enums.WaterGrade.Ⅳ => 1.5m,
                Enums.WaterGrade.Ⅴ => 1.5m,
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
                new StandardLimit(){Grade = 1,Limit = 0.01m},
                new StandardLimit(){Grade = 2,Limit = 0.01m},
                new StandardLimit(){Grade = 3,Limit = 0.01m},
                new StandardLimit(){Grade = 4,Limit = 0.02m},
                new StandardLimit(){Grade = 5,Limit = 0.02m}
            };
        }

        /// <summary>
        /// 根据水质类别获取硒的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetSELimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01m,
                Enums.WaterGrade.Ⅱ => 0.01m,
                Enums.WaterGrade.Ⅲ => 0.01m,
                Enums.WaterGrade.Ⅳ => 0.02m,
                Enums.WaterGrade.Ⅴ => 0.02m,
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
                new StandardLimit(){Grade = 1,Limit = 0.05m},
                new StandardLimit(){Grade = 2,Limit = 0.05m},
                new StandardLimit(){Grade = 3,Limit = 0.05m},
                new StandardLimit(){Grade = 4,Limit = 0.1m},
                new StandardLimit(){Grade = 5,Limit = 0.1m}
            };
        }

        /// <summary>
        /// 根据水质类别获取砷的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetASLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05m,
                Enums.WaterGrade.Ⅱ => 0.05m,
                Enums.WaterGrade.Ⅲ => 0.05m,
                Enums.WaterGrade.Ⅳ => 0.1m,
                Enums.WaterGrade.Ⅴ => 0.1m,
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
                new StandardLimit(){Grade = 1,Limit = 0.00005m},
                new StandardLimit(){Grade = 2,Limit = 0.00005m},
                new StandardLimit(){Grade = 3,Limit = 0.0001m},
                new StandardLimit(){Grade = 4,Limit = 0.001m},
                new StandardLimit(){Grade = 5,Limit = 0.001m}
            };
        }

        /// <summary>
        /// 根据水质类别获取汞的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetHGLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.00005m,
                Enums.WaterGrade.Ⅱ => 0.00005m,
                Enums.WaterGrade.Ⅲ => 0.0001m,
                Enums.WaterGrade.Ⅳ => 0.001m,
                Enums.WaterGrade.Ⅴ => 0.001m,
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
               new StandardLimit(){Grade = 1,Limit = 0.001m},
                new StandardLimit(){Grade = 2,Limit = 0.005m},
                new StandardLimit(){Grade = 3,Limit = 0.005m},
                new StandardLimit(){Grade = 4,Limit = 0.005m},
                new StandardLimit(){Grade = 5,Limit = 0.01m}
            };
        }

        /// <summary>
        /// 根据水质类别获取镉的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetCDLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.001m,
                Enums.WaterGrade.Ⅱ => 0.005m,
                Enums.WaterGrade.Ⅲ => 0.005m,
                Enums.WaterGrade.Ⅳ => 0.005m,
                Enums.WaterGrade.Ⅴ => 0.01m,
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
                new StandardLimit(){Grade = 1,Limit = 0.01m},
                new StandardLimit(){Grade = 2,Limit = 0.05m},
                new StandardLimit(){Grade = 3,Limit = 0.05m},
                new StandardLimit(){Grade = 4,Limit = 0.05m},
                new StandardLimit(){Grade = 5,Limit = 0.1m}
            };
        }

        /// <summary>
        /// 根据水质类别获取六价铬的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetCR6LimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01m,
                Enums.WaterGrade.Ⅱ => 0.05m,
                Enums.WaterGrade.Ⅲ => 0.05m,
                Enums.WaterGrade.Ⅳ => 0.05m,
                Enums.WaterGrade.Ⅴ => 0.1m,
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
                new StandardLimit(){Grade = 1,Limit = 0.01m},
                new StandardLimit(){Grade = 2,Limit = 0.01m},
                new StandardLimit(){Grade = 3,Limit = 0.05m},
                new StandardLimit(){Grade = 4,Limit = 0.05m},
                new StandardLimit(){Grade = 5,Limit = 0.1m}
            };
        }


        /// <summary>
        /// 根据水质类别获取铅的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetPBLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.01m,
                Enums.WaterGrade.Ⅱ => 0.01m,
                Enums.WaterGrade.Ⅲ => 0.05m,
                Enums.WaterGrade.Ⅳ => 0.05m,
                Enums.WaterGrade.Ⅴ => 0.1m,
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
                new StandardLimit(){Grade = 1,Limit = 0.005m},
                new StandardLimit(){Grade = 2,Limit = 0.05m},
                new StandardLimit(){Grade = 3,Limit = 0.2m},
                new StandardLimit(){Grade = 4,Limit = 0.2m},
                new StandardLimit(){Grade = 5,Limit = 0.2m}
            };
        }

        /// <summary>
        /// 根据水质类别获取氰化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetCNLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.005m,
                Enums.WaterGrade.Ⅱ => 0.05m,
                Enums.WaterGrade.Ⅲ => 0.2m,
                Enums.WaterGrade.Ⅳ => 0.2m,
                Enums.WaterGrade.Ⅴ => 0.2m,
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
                new StandardLimit(){Grade = 1,Limit = 0.002m},
                new StandardLimit(){Grade = 2,Limit = 0.002m},
                new StandardLimit(){Grade = 3,Limit = 0.005m},
                new StandardLimit(){Grade = 4,Limit = 0.01m},
                new StandardLimit(){Grade = 5,Limit = 0.1m}
            };
        }

        /// <summary>
        /// 根据水质类别获取挥发酚的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetPHENLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.002m,
                Enums.WaterGrade.Ⅱ => 0.002m,
                Enums.WaterGrade.Ⅲ => 0.005m,
                Enums.WaterGrade.Ⅳ => 0.01m,
                Enums.WaterGrade.Ⅴ => 0.1m,
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
                new StandardLimit(){Grade = 1,Limit = 0.05m},
                new StandardLimit(){Grade = 2,Limit = 0.05m},
                new StandardLimit(){Grade = 3,Limit = 0.05m},
                new StandardLimit(){Grade = 4,Limit = 0.5m},
                new StandardLimit(){Grade = 5,Limit = 1}
            };
        }

        /// <summary>
        /// 根据水质类别获取石油类的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetTPHLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05m,
                Enums.WaterGrade.Ⅱ => 0.05m,
                Enums.WaterGrade.Ⅲ => 0.05m,
                Enums.WaterGrade.Ⅳ => 0.5m,
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
                new StandardLimit(){Grade = 1,Limit = 0.2m},
                new StandardLimit(){Grade = 2,Limit = 0.2m},
                new StandardLimit(){Grade = 3,Limit = 0.2m},
                new StandardLimit(){Grade = 4,Limit = 0.3m},
                new StandardLimit(){Grade = 5,Limit = 0.3m}
            };
        }

        /// <summary>
        /// 根据水质类别获取阴离子表面活性剂的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetLASLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.2m,
                Enums.WaterGrade.Ⅱ => 0.2m,
                Enums.WaterGrade.Ⅲ => 0.2m,
                Enums.WaterGrade.Ⅳ => 0.3m,
                Enums.WaterGrade.Ⅴ => 0.3m,
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
                new StandardLimit(){Grade = 1,Limit = 0.05m},
                new StandardLimit(){Grade = 2,Limit = 0.1m},
                new StandardLimit(){Grade = 3,Limit = 0.2m},
                new StandardLimit(){Grade = 4,Limit = 0.5m},
                new StandardLimit(){Grade = 5,Limit = 1}
            };
        }

        /// <summary>
        /// 根据水质类别获取硫化物的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static decimal? GetH2SLimitByGrade(Enums.WaterGrade grade)
        {
            return grade switch
            {
                Enums.WaterGrade.Ⅰ => 0.05m,
                Enums.WaterGrade.Ⅱ => 0.1m,
                Enums.WaterGrade.Ⅲ => 0.2m,
                Enums.WaterGrade.Ⅳ => 0.5m,
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
        public static decimal? GetFCLimitByGrade(Enums.WaterGrade grade)
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


        /// <summary>
        /// 获取硫酸盐的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetSO42Limit() => 250;

        /// <summary>
        /// 获取氯化物的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetCLLimit() => 250;

        /// <summary>
        /// 获取硝酸盐的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetNO3Limit() => 10;

        /// <summary>
        /// 获取铁的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetFELimit() => 0.3m;

        /// <summary>
        /// 获取锰的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetMNLimit() => 0.1m;

        /// <summary>
        /// 获取钼的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetMOLimit() => 0.07m;

        /// <summary>
        /// 获取钴的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetCOLimit() => 1;

        /// <summary>
        /// 获取铍的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBELimit() => 0.002m;

        /// <summary>
        /// 获取硼的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBLimit() => 0.5m;

        /// <summary>
        /// 获取锑的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetSBLimit() => 0.005m;

        /// <summary>
        /// 获取镍的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetNILimit() => 0.02m;

        /// <summary>
        /// 获取钡的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBALimit() => 0.7m;

        /// <summary>
        /// 获取钒的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetVLimit() => 0.05m;

        /// <summary>
        /// 获取钛的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTILimit() => 0.1m;

        /// <summary>
        /// 获取铊的标准值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTLLimit() => 0.0001m;

        /// <summary>
        /// 根据指标的简写或者代码获取类别的标准限值
        /// 对于非表1中的指标，grade参数无效，可任意值
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="factorAbbrOrCode">codmn或w01019,不区分大小写</param>
        /// <param name="waterbody"></param>
        /// <returns></returns>
        public static decimal? GetFactorLimitByGradeAndFactor(Enums.WaterGrade grade, string factorAbbrOrCode, Waterbody waterbody = Waterbody.河流)
        {
            switch (factorAbbrOrCode.ToUpper())
            {
                case "DO":
                case "W01009": return GetDOLimitByGrade(grade);
                case "CODMN":
                case "W01019": return GetCODMNLimitByGrade(grade);
                case "COD":
                case "W01018": return GetCODLimitByGrade(grade);
                case "BOD5":
                case "W01017": return GetBOD5LimitByGrade(grade);
                case "NH3N":
                case "W21003": return GetNH3NLimitByGrade(grade);
                case "TP":
                case "W21011": return GetTPLimitByGrade(grade, waterbody);
                case "TN":
                case "W21001": return GetTNLimitByGrade(grade);
                case "CU":
                case "W20122": return GetCULimitByGrade(grade);
                case "ZN":
                case "W20123": return GetZNLimitByGrade(grade);
                case "F":
                case "W21017": return GetFLimitByGrade(grade);
                case "SE":
                case "W20128": return GetSELimitByGrade(grade);
                case "AS":
                case "W20141": return GetASLimitByGrade(grade);
                case "HG":
                case "W20111": return GetHGLimitByGrade(grade);
                case "CD":
                case "W20115": return GetCDLimitByGrade(grade);
                case "CR6":
                case "W20117": return GetCR6LimitByGrade(grade);
                case "PB":
                case "W20120": return GetPBLimitByGrade(grade);
                case "CN":
                case "W21016": return GetCNLimitByGrade(grade);
                case "PHEN":
                case "W23002": return GetPHENLimitByGrade(grade);
                case "TPH":
                case "W22001": return GetTPHLimitByGrade(grade);
                case "LAS":
                case "W19002": return GetLASLimitByGrade(grade);
                case "H2S":
                case "W21019": return GetH2SLimitByGrade(grade);
                case "FC":
                case "W02003": return GetFCLimitByGrade(grade);
                case "SO42":
                case "W21038": return GetSO42Limit();
                case "CL":
                case "W21022": return GetCLLimit();
                case "NO3":
                case "W21007": return GetNO3Limit();
                case "FE":
                case "W20125": return GetFELimit();
                case "MN":
                case "W20124": return GetMNLimit();
                case "MO":
                case "W20061": return GetMOLimit();
                case "CO":
                case "W20038": return GetCOLimit();
                case "BE":
                case "W20127": return GetBELimit();
                case "B":
                case "W20023": return GetBLimit();
                case "SB":
                case "W20004": return GetSBLimit();
                case "NI":
                case "W20121": return GetNILimit();
                case "BA":
                case "W20012": return GetBALimit();
                case "V":
                case "W20101": return GetVLimit();
                case "TI":
                case "W20095": return GetTILimit();
                case "TL":
                case "W20089": return GetTLLimit();
                default: return null;
            }
        }
    }
}

using Journey.SurfaceWater.Enums;
using Journey.SurfaceWater.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Journey.SurfaceWater.EQSFSW.V2002
{
    /// <summary>
    /// 类别计算的相关方法
    /// </summary>
    public class GradeService
    {

        /// <summary>
        /// 根据监测指标的简写计算指标的类别
        /// </summary>
        /// <param name="abbreviation">指标简写,不区分大小写 eg. PHEN</param>
        /// <param name="value"></param>
        /// <param name="waterbody">水体类型(计算总磷类别时候需要,河流/湖库)</param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetFactorGradeByAbbreviation(string abbreviation, double value, WaterBody waterbody = WaterBody.河流)
        {
            return abbreviation.ToUpper() switch
            {
                "PH" => GetPHGrade(value),
                "DO" => GetDOGrade(value),
                "CODMN" => GetCODMNGrade(value),
                "COD" => GetCODGrade(value),
                "BOD5" => GetBOD5Grade(value),
                "NH3N" => GetNH3NGrade(value),
                "TP" => GetTPGrade(value, waterbody),
                "TN" => GetTNGrade(value),
                "CU" => GetCUGrade(value),
                "ZN" => GetZNGrade(value),
                "F" => GetFGrade(value),
                "SE" => GetSEGrade(value),
                "AS" => GetASGrade(value),
                "HG" => GetHGGrade(value),
                "CD" => GetCDGrade(value),
                "CR6" => GetCR6Grade(value),
                "PB" => GetPBGrade(value),
                "CN" => GetCNGrade(value),
                "PHEN" => GetPHENGrade(value),
                "TPH" => GetTPHGrade(value),
                "LAS" => GetLASGrade(value),
                "H2S" => GetH2SGrade(value),
                "FC" => GetFCGrade(value),
                _ => null
            };
        }

        /// <summary>
        /// 根据监测指标的编码计算指标的类别
        /// </summary>
        /// <param name="factorCode">指标编码,不区分大小写 eg. w20122</param>
        /// <param name="value"></param>
        /// <param name="waterBody">水体类型(计算总磷类别时候需要,河流/湖库)</param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetFactorGradeByCode(string factorCode, double value, WaterBody waterBody = WaterBody.河流)
        {
            return factorCode.ToUpper() switch
            {
                "W01001" => GetPHGrade(value),
                "W01009" => GetDOGrade(value),
                "W01019" => GetCODMNGrade(value),
                "W01018" => GetCODGrade(value),
                "W01017" => GetBOD5Grade(value),
                "W21003" => GetNH3NGrade(value),
                "W21011" => GetTPGrade(value, waterBody),
                "W21001" => GetTNGrade(value),
                "W20122" => GetCUGrade(value),
                "W20123" => GetZNGrade(value),
                "W21017" => GetFGrade(value),
                "W20128" => GetSEGrade(value),
                "W20141" => GetASGrade(value),
                "W20111" => GetHGGrade(value),
                "W20115" => GetCDGrade(value),
                "W20117" => GetCR6Grade(value),
                "W20120" => GetPBGrade(value),
                "W21016" => GetCNGrade(value),
                "W23002" => GetPHENGrade(value),
                "W22001" => GetTPHGrade(value),
                "W19002" => GetLASGrade(value),
                "W21019" => GetH2SGrade(value),
                "W02003" => GetFCGrade(value),
                _ => null
            };
        }


        /*
         * 考虑到是固定形式，就不通过枚举来获取文字类别了
         */

        /// <summary>
        /// 计算PH的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetPHGrade(double value)
        {
            if (value <= 0) return null;
            if (value >= 6 && value <= 9) return (1, "Ⅰ");
            return (6, "劣Ⅴ");
        }

        /// <summary>
        /// 计算溶解氧的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetDOGrade(double value)
        {
            if (value <= 0) return null;
            if (value >= 7.5) return (1, "Ⅰ");
            if (value >= 6) return (2, "Ⅱ");
            if (value >= 5) return (3, "Ⅲ");
            if (value >= 3) return (4, "Ⅳ");
            if (value >= 2) return (5, "Ⅴ");
            if (value < 2 && value > 0) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算高锰酸盐指数的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCODMNGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 2) return (1, "Ⅰ");
            if (value <= 4) return (2, "Ⅱ");
            if (value <= 6) return (3, "Ⅲ");
            if (value <= 10) return (4, "Ⅳ");
            if (value <= 15) return (5, "Ⅴ");
            return (6, "劣Ⅴ");
        }

        /// <summary>
        /// 计算化学需氧量的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCODGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 15) return (1, "Ⅰ");
            if (value <= 20) return (3, "Ⅲ");
            if (value <= 30) return (4, "Ⅳ");
            if (value <= 40) return (5, "Ⅴ");
            if (value > 40) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算五日生化需氧量的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetBOD5Grade(double value)
        {
            if (value <= 0) return null;
            if (value <= 3) return (1, "Ⅰ");
            if (value <= 4) return (3, "Ⅲ");
            if (value <= 6) return (4, "Ⅳ");
            if (value <= 10) return (5, "Ⅴ");
            if (value > 10) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算氨氮的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetNH3NGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.15) return (1, "Ⅰ");
            if (value <= 0.5) return (2, "Ⅱ");
            if (value <= 1) return (3, "Ⅲ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value <= 2) return (5, "Ⅴ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算总磷的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <param name="waterbody">河流/湖库,其它则返回null</param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetTPGrade(double value, Enums.WaterBody waterbody = WaterBody.河流)
        {
            if (value <= 0) return null;
            if (waterbody == WaterBody.河流)
            {
                if (value <= 0.02) return (1, "Ⅰ");
                if (value <= 0.1) return (2, "Ⅱ");
                if (value <= 0.2) return (3, "Ⅲ");
                if (value <= 0.3) return (4, "Ⅳ");
                if (value <= 0.4) return (5, "Ⅴ");
                if (value > 0.4) return (6, "劣Ⅴ");
                return null;
            }
            else if (waterbody == WaterBody.湖库)
            {
                if (value <= 0.01) return (1, "Ⅰ");
                if (value <= 0.025) return (2, "Ⅱ");
                if (value <= 0.05) return (3, "Ⅲ");
                if (value <= 0.1) return (4, "Ⅳ");
                if (value <= 0.2) return (5, "Ⅴ");
                if (value > 0.2) return (6, "劣Ⅴ");
                return null;
            }
            else return null;
        }

        /// <summary>
        /// 计算总氮的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetTNGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.2) return (1, "Ⅰ");
            if (value <= 0.5) return (2, "Ⅱ");
            if (value <= 1) return (3, "Ⅲ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value <= 2) return (5, "Ⅴ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算铜的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCUGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.01) return (1, "Ⅰ");
            if (value <= 1) return (2, "Ⅱ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算锌的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetZNGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.05) return (1, "Ⅰ");
            if (value <= 1) return (2, "Ⅱ");
            if (value <= 2) return (4, "Ⅳ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算氟化物的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetFGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 1) return (1, "Ⅰ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value > 1.5) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算硒的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetSEGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.02) return (4, "Ⅳ");
            if (value > 0.02) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算砷的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetASGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.1) return (4, "Ⅳ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算汞的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetHGGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.00005) return (1, "Ⅰ");
            if (value <= 0.0001) return (3, "Ⅲ");
            if (value <= 0.001) return (4, "Ⅳ");
            if (value > 0.001) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算镉的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCDGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.001) return (1, "Ⅰ");
            if (value <= 0.005) return (2, "Ⅱ");
            if (value <= 0.01) return (5, "Ⅴ");
            if (value > 0.01) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算六价铬的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCR6Grade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.05) return (2, "Ⅱ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算铅的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetPBGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.05) return (3, "Ⅲ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算氰化物的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetCNGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.005) return (1, "Ⅰ");
            if (value <= 0.05) return (2, "Ⅱ");
            if (value <= 0.2) return (3, "Ⅲ");
            if (value > 0.2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算挥发酚的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetPHENGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.002) return (1, "Ⅰ");
            if (value <= 0.005) return (3, "Ⅲ");
            if (value <= 0.01) return (4, "Ⅳ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算石油类的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetTPHGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.5) return (4, "Ⅳ");
            if (value <= 1) return (5, "Ⅴ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算阴离子表面活性剂的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetLASGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.2) return (1, "Ⅰ");
            if (value <= 0.3) return (4, "Ⅳ");
            if (value > 0.3) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算硫化物的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetH2SGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.1) return (2, "Ⅱ");
            if (value <= 0.2) return (3, "Ⅲ");
            if (value <= 0.5) return (4, "Ⅳ");
            if (value <= 1) return (5, "Ⅴ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算粪大肠菌群的类别,如果值小于0则返回null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(数字类别,文字类别) eg. (4,Ⅳ)</returns>
        public static (int, string)? GetFCGrade(double value)
        {
            if (value <= 0) return null;
            if (value <= 200) return (1, "Ⅰ");
            if (value <= 2000) return (2, "Ⅱ");
            if (value <= 10000) return (3, "Ⅲ");
            if (value <= 20000) return (4, "Ⅳ");
            if (value <= 40000) return (5, "Ⅴ");
            if (value > 40000) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 计算一条数据的水质类别
        /// </summary>
        /// <param name="data"></param>
        /// <param name="waterbody"></param>
        /// <param name="isAnalysisTN">整体水质类别中是否加入总氮的类别,true:加入,false:不加入</param>
        /// <param name="isAnalysisFC">整体水质类别中是否加入粪大肠菌群的类别,true:加入,false:不加入</param>
        /// <returns></returns>
        public static BasicItemValuesAndGrades? GetWaterGrade(BasicItemValues data, WaterBody waterbody = WaterBody.河流, bool isAnalysisTN = false, bool isAnalysisFC = false)
        {
            var result = new BasicItemValuesAndGrades
            {
                WT = data.WT,
                PH = data.PH,
                DO = data.DO,
                CODMN = data.CODMN,
                COD = data.COD,
                BOD5 = data.BOD5,
                NH3N = data.NH3N,
                TP = data.TP,
                TN = data.TN,
                CU = data.CU,
                ZN = data.ZN,
                F = data.F,
                SE = data.SE,
                AS = data.AS,
                HG = data.HG,
                CD = data.CD,
                CR6 = data.CR6,
                PB = data.PB,
                CN = data.CN,
                PHEN = data.PHEN,
                TPH = data.TPH,
                LAS = data.LAS,
                H2S = data.H2S,
                FC = data.FC
            };
            List<int> grades = new List<int>();
            if (data.PH.HasValue)
            {
                var grade = GetPHGrade(data.PH.Value);
                if (grade.HasValue)
                {
                    result.PHGrade = grade.Value.Item1;
                    result.PHGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.DO.HasValue)
            {
                var grade = GetDOGrade(data.DO.Value);
                if (grade.HasValue)
                {
                    result.DOGrade = grade.Value.Item1;
                    result.DOGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.CODMN.HasValue)
            {
                var grade = GetCODMNGrade(data.CODMN.Value);
                if (grade.HasValue)
                {
                    result.CODMNGrade = grade.Value.Item1;
                    result.CODMNGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.COD.HasValue)
            {
                var grade = GetCODGrade(data.COD.Value);
                if (grade.HasValue)
                {
                    result.CODGrade = grade.Value.Item1;
                    result.CODGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.BOD5.HasValue)
            {
                var grade = GetBOD5Grade(data.BOD5.Value);
                if (grade.HasValue)
                {
                    result.BOD5Grade = grade.Value.Item1;
                    result.BOD5GradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.NH3N.HasValue)
            {
                var grade = GetNH3NGrade(data.NH3N.Value);
                if (grade.HasValue)
                {
                    result.NH3NGrade = grade.Value.Item1;
                    result.NH3NGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.TP.HasValue)
            {
                var grade = GetTPGrade(data.TP.Value, waterbody);
                if (grade.HasValue)
                {
                    result.TPGrade = grade.Value.Item1;
                    result.TPGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.TN.HasValue)
            {
                var grade = GetTNGrade(data.TN.Value);
                if (grade.HasValue)
                {
                    result.TNGrade = grade.Value.Item1;
                    result.TNGradeText = grade.Value.Item2;
                    if (isAnalysisTN) grades.Add(grade.Value.Item1);
                }
            }
            if (data.CU.HasValue)
            {
                var grade = GetCUGrade(data.CU.Value);
                if (grade.HasValue)
                {
                    result.CUGrade = grade.Value.Item1;
                    result.CUGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.ZN.HasValue)
            {
                var grade = GetZNGrade(data.ZN.Value);
                if (grade.HasValue)
                {
                    result.ZNGrade = grade.Value.Item1;
                    result.ZNGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.F.HasValue)
            {
                var grade = GetFGrade(data.F.Value);
                if (grade.HasValue)
                {
                    result.FGrade = grade.Value.Item1;
                    result.FGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.SE.HasValue)
            {
                var grade = GetSEGrade(data.SE.Value);
                if (grade.HasValue)
                {
                    result.SEGrade = grade.Value.Item1;
                    result.SEGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.AS.HasValue)
            {
                var grade = GetASGrade(data.AS.Value);
                if (grade.HasValue)
                {
                    result.ASGrade = grade.Value.Item1;
                    result.ASGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.HG.HasValue)
            {
                var grade = GetHGGrade(data.HG.Value);
                if (grade.HasValue)
                {
                    result.HGGrade = grade.Value.Item1;
                    result.HGGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.CD.HasValue)
            {
                var grade = GetCDGrade(data.CD.Value);
                if (grade.HasValue)
                {
                    result.CDGrade = grade.Value.Item1;
                    result.CDGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.CR6.HasValue)
            {
                var grade = GetCR6Grade(data.CR6.Value);
                if (grade.HasValue)
                {
                    result.CR6Grade = grade.Value.Item1;
                    result.CR6GradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.PB.HasValue)
            {
                var grade = GetPBGrade(data.PB.Value);
                if (grade.HasValue)
                {
                    result.PBGrade = grade.Value.Item1;
                    result.PBGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.CN.HasValue)
            {
                var grade = GetCNGrade(data.CN.Value);
                if (grade.HasValue)
                {
                    result.CNGrade = grade.Value.Item1;
                    result.CNGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.PHEN.HasValue)
            {
                var grade = GetPHENGrade(data.PHEN.Value);
                if (grade.HasValue)
                {
                    result.PHENGrade = grade.Value.Item1;
                    result.PHENGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.TPH.HasValue)
            {
                var grade = GetTPHGrade(data.TPH.Value);
                if (grade.HasValue)
                {
                    result.TPHGrade = grade.Value.Item1;
                    result.TPHGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.LAS.HasValue)
            {
                var grade = GetLASGrade(data.LAS.Value);
                if (grade.HasValue)
                {
                    result.LASGrade = grade.Value.Item1;
                    result.LASGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.H2S.HasValue)
            {
                var grade = GetH2SGrade(data.H2S.Value);
                if (grade.HasValue)
                {
                    result.H2SGrade = grade.Value.Item1;
                    result.H2SGradeText = grade.Value.Item2;
                    grades.Add(grade.Value.Item1);
                }
            }
            if (data.FC.HasValue)
            {
                var grade = GetFCGrade(data.FC.Value);
                if (grade.HasValue)
                {
                    result.FCGrade = grade.Value.Item1;
                    result.FCGradeText = grade.Value.Item2;
                    if (isAnalysisFC) grades.Add(grade.Value.Item1);
                }
            }
            if (grades.Count == 0) return null;
            else
            {
                result.WaterGrade = grades.Max();
                result.WaterGradeText = Enum.GetName(typeof(WaterGrade), result.WaterGrade);
                return result;
            }
        }
    }
}

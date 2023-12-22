using System;

namespace Journey.SurfaceWater.EQMDST.V2020
{
    /// <summary>
    /// 修约的相关方法
    /// </summary>
    public class RoundingService
    {
        private static readonly char[] SearchValue = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// 根据监测指标的简写或编码获取评价数据的修约小数位数
        /// </summary>
        /// <param name="factorAbbreviationOrCode">不区分大小写</param>
        /// <returns></returns>
        public static int? GetAssessmentDecimalPlaces(string factorAbbreviationOrCode)
        {
            var tmp = Enums.EnumsHelper.GetFactorEnumByCodeOrAbbreviation(factorAbbreviationOrCode);
            if (tmp == null) return null;
            if (Dictionaries.FactorDictionary.FactorAssessmentMapping2020.TryGetValue((Enums.Factor)tmp, out int result)) return result;
            else return null;
        }

        /// <summary>
        /// 根据监测指标的简写或编码获取小时数据的修约小数位数
        /// 总站水字[2020]90号表1规定的比较少,3838表1中未规定的则按Ⅰ类标准加1位小数点位，3838表2中加1位小数点位，表3中重金属5位小数点位
        /// </summary>
        /// <param name="factorAbbreviationOrCode"></param>
        /// <returns></returns>
        public static int? GetHourdataDecimalPlaces(string factorAbbreviationOrCode)
        {
            var tmp = Enums.EnumsHelper.GetFactorEnumByCodeOrAbbreviation(factorAbbreviationOrCode);
            if (tmp == null) return null;
            if (Dictionaries.FactorDictionary.FactorHourdataMapping2020.TryGetValue((Enums.Factor)tmp, out int result)) return result;
            else return null;
        }

        /// <summary>
        /// 数据修约(四舍六入五成双)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static decimal RoundingToEven(decimal value, int decimalPlaces)
        {
            if (value == 0) return 0;
            var tmp = Math.Round(value, decimalPlaces, MidpointRounding.ToEven);
            if (tmp == 0)
            {
                int index = value.ToString().IndexOfAny(SearchValue);
                tmp = Math.Round(value, index - 1, MidpointRounding.ToEven);
            }
            return tmp;
        }
    }
}

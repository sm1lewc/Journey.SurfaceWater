using Journey.SurfaceWater.Dictionaries;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Journey.SurfaceWater.Factors
{
    /// <summary>
    /// 监测指标相关方法
    /// </summary>
    public class FactorService
    {
        /// <summary>
        /// 根据监测指标的缩写或者编码获取监测指标的名称，如果没有找到则返回null
        /// 不区分大小写
        /// </summary>
        /// <param name="abbrOrCode"></param>
        /// <returns></returns>
        public static string? GetFactorName(string abbrOrCode)
        {
            return Enums.EnumsHelper.GetFactorEnumByCodeOrAbbreviation(abbrOrCode)?.ToString();
        }

        /// <summary>
        /// 根据监测指标的缩写或者编码获取监测指标的枚举，如果没有找到则返回null
        /// </summary>
        /// <param name="abbrOrCode"></param>
        /// <returns></returns>
        public static Enums.Factor? GetFactorEnum(string abbrOrCode)
        {
            return Enums.EnumsHelper.GetFactorEnumByCodeOrAbbreviation(abbrOrCode);
        }

        /// <summary>
        /// 根据监测指标的名称获取监测指标的缩写，如果没有找到则返回null
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static string? GetFactorAbbreviationByName(Enums.Factor factor)
        {
            return Enums.EnumsHelper.GetFactorAbbreviation(factor);
        }


        /// <summary>
        /// 根据监测指标的名称获取监测指标的编码，如果没有找到则返回null
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static string? GetFactorCodeByName(Enums.Factor factor)
        {
            return Enums.EnumsHelper.GetFactorCode(factor);
        }

        /// <summary>
        /// 根据监测指标的编码获取监测指标的缩写，如果没有找到则返回null
        /// 不区分大小写
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string? GetFactorAbbreviationByCode(string code)
        {
            FactorDictionary.FactorCodeAbbreviationMapping.TryGetValue(code.ToUpper(), out string? result);
            return result;
        }

        /// <summary>
        /// 根据监测指标的缩写获取监测指标的编码，如果没有找到则返回null
        /// 不区分大小写
        /// </summary>
        /// <param name="abbreviation"></param>
        /// <returns></returns>
        public static string? GetFactorCodeByAbbreviation(string abbreviation)
        {
            var kv = FactorDictionary.FactorCodeAbbreviationMapping.Where(x => x.Value == abbreviation.ToUpper()).FirstOrDefault();
            return kv.Key?.ToLower();
        }
    }
}

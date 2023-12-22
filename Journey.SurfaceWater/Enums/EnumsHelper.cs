using System;
using System.ComponentModel;
using System.Reflection;

namespace Journey.SurfaceWater.Enums
{
    /// <summary>
    /// 枚举的相关方法
    /// </summary>
    internal class EnumsHelper
    {
        /// <summary>
        /// 获取枚举的描述 (code,abbr)
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns>w01001,PH</returns>
        internal static string? GetEnumDescription(Enum enumValue)
        {
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());
            if (field == null) return null;
            object[] objs = field.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            if (objs == null || objs.Length == 0) return null;
            return ((System.ComponentModel.DescriptionAttribute)objs[0]).Description;
        }

        /// <summary>
        /// 获取指标的编码
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        internal static string? GetFactorCode(Factor enumValue) 
        {
            string? description = GetEnumDescription(enumValue);
            if (description == null) return null;
            return (description.Split(',')[0]).ToLower();
        }

        /// <summary>
        /// 获取指标的简写
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        internal static string? GetFactorAbbreviation(Factor enumValue)
        {
            string? description = GetEnumDescription(enumValue);
            if (description == null) return null;
            return description.Split(',')[1];
        }

        /// <summary>
        /// 根据指标的编码或简写获取枚举
        /// </summary>
        /// <param name="codeOrAbbreviation"></param>
        /// <returns></returns>
        internal static Enums.Factor? GetFactorEnumByCodeOrAbbreviation(string codeOrAbbreviation)
        {
            var infos= typeof(Enums.Factor).GetFields();
            foreach(FieldInfo field in infos)
            {
                if(Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if(attribute.Description.Contains(codeOrAbbreviation.ToUpper()))
                    {
                        return (Enums.Factor)Enum.Parse(typeof(Enums.Factor), field.Name);
                    }
                }
            }
            return null;
        }
    }
}

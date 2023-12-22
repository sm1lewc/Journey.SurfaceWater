using System;
using System.Collections.Generic;
using System.Linq;

namespace Journey.SurfaceWater.EQMDST.V2020
{
    /// <summary>
    /// PH均值计算服务
    /// </summary>
    public class PHAverageService
    {
        /// <summary>
        /// 计算PH均值(结果不修约)
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static decimal? CalculatePHAverage(IEnumerable<decimal> values)
        {
            if (values == null || values.Count() == 0) return null;
            List<double> hValues = new List<double>();
            foreach (var value in values)
            {
                //氢离子浓度值
                hValues.Add(Math.Pow(10, Convert.ToDouble(value) * -1));
            }
            //氢离子浓度值的平均值
            var hAverage = hValues.Average();
            //PH值
            var phAverage = Math.Log10(hAverage) * -1;
            return Convert.ToDecimal(phAverage);
        }
    }
}

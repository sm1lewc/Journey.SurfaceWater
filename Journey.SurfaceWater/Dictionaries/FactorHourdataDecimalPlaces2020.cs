using Journey.SurfaceWater.Enums;
using System.Collections.Generic;

namespace Journey.SurfaceWater.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class FactorDictionary
    {
        /// <summary>
        /// 指标小时数据修约位数的映射(2020版)
        /// </summary>
        internal static readonly Dictionary<Factor, int> FactorHourdataMapping2020 = new Dictionary<Factor, int>()
        {
            { Factor.水温,1 },
            {Factor.pH,2 },
            { Factor.溶解氧,2},
            {Factor.电导率,1 },
            {Factor.高锰酸盐指数,2 },
            {Factor.氨氮,3 },
            {Factor.总磷,3 },
            {Factor.总氮,2 },
            {Factor.叶绿素a,3 },
            {Factor.藻密度,0 },
            { Factor.六价铬,3},
            {Factor.化学需氧量,2 },
            {Factor.铜,3 },
            {Factor.锌,3 },
            {Factor.氟化物,2 },
            {Factor.硒,3 },
            {Factor.砷,3 },
            {Factor.汞,6 },
            {Factor.镉,4 },
            {Factor.铅,3 },
            {Factor.氰化物,4 },
            {Factor.挥发酚,4 },
            {Factor.石油类,3 },
            {Factor.阴离子表面活性剂,2 },
            {Factor.硫化物,3 },
            {Factor.粪大肠菌群,0 },
            {Factor.浊度,1 },
            {Factor.硫酸盐,1 },
            {Factor.氯化物,1 },
            {Factor.硝酸盐,1 },
            {Factor.铁,5 },
            {Factor.锰,5 },
            {Factor.钼,5 },
            {Factor.钡,5 },
            {Factor.钴,5 },
            {Factor.铍,5 },
            {Factor.硼,5 },
            {Factor.锑,5 },
            {Factor.钒,5 },
            {Factor.镍,5 },
            {Factor.钛,5 },
            {Factor.铊,5 }
        };
    }
}

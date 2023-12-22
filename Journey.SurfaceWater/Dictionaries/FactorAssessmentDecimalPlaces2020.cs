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
        /// 指标评价数据修约位数的映射(2020版)
        /// </summary>
        internal static readonly Dictionary<Factor, int> FactorAssessmentMapping2020 = new Dictionary<Factor, int>()
        {
            {Factor.水温,1 },
            {Factor.pH,0 },
            {Factor.溶解氧,1 },
            {Factor.高锰酸盐指数,1 },
            {Factor.化学需氧量,1 },
            {Factor.五日生化需氧量,1 },
            {Factor.氨氮,2 },
            {Factor.总磷,3 },
            {Factor.总氮,2 },
            {Factor.铜,3 },
            {Factor.锌,3 },
            {Factor.氟化物,3 },
            {Factor.硒,4 },
            {Factor.砷,4 },
            {Factor.汞,5 },
            {Factor.镉,5 },
            {Factor.六价铬,3 },
            {Factor.铅,3 },
            {Factor.氰化物,3 },
            {Factor.挥发酚,4 },
            {Factor.石油类,2 },
            {Factor.阴离子表面活性剂,2 },
            {Factor.硫化物,3 },
            {Factor.粪大肠菌群,0 },
            {Factor.电导率,1},
            {Factor.浊度,1},
            {Factor.叶绿素a,3},
            {Factor.藻密度,0}
        };
    }
}

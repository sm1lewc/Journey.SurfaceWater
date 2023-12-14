using System.ComponentModel;

namespace Journey.SurfaceWater.Enums
{
    /// <summary>
    /// 监测指标枚举
    /// </summary>
    public enum Factor
    {
        /// <summary>
        /// WT
        /// </summary>
        [Description("w01010")]
        水温,
        /// <summary>
        /// PH
        /// </summary>
        [Description("w01001")]
        pH,
        /// <summary>
        /// DO
        /// </summary>
        [Description("w01009")]
        溶解氧,
        /// <summary>
        /// CODMN
        /// </summary>
        [Description("w01019")]
        高锰酸盐指数,
        /// <summary>
        /// COD
        /// </summary>
        [Description("w01018")]
        化学需氧量,
        /// <summary>
        /// BOD5
        /// </summary>
        [Description("w01017")]
        五日生化需氧量,
        /// <summary>
        /// NH3N
        /// </summary>
        [Description("w21003")]
        氨氮,
        /// <summary>
        /// TP
        /// </summary>
        [Description("w21011")]
        总磷,
        /// <summary>
        /// TN
        /// </summary>
        [Description("w21001")]
        总氮,
        /// <summary>
        /// CU
        /// </summary>
        [Description("w20122")]
        铜,
        /// <summary>
        /// ZN
        /// </summary>
        [Description("w20123")]
        锌,
        /// <summary>
        /// F
        /// </summary>
        [Description("w21017")]
        氟化物,
        /// <summary>
        /// SE
        /// </summary>
        [Description("w20128")]
        硒,
        /// <summary>
        /// AS
        /// </summary>
        [Description("w20141")]
        砷,
        /// <summary>
        /// HG
        /// </summary>
        [Description("w20111")]
        汞,
        /// <summary>
        /// CD
        /// </summary>
        [Description("w20115")]
        镉,
        /// <summary>
        /// CR6
        /// </summary>
        [Description("w20117")]
        六价铬,
        /// <summary>
        /// PB
        /// </summary>
        [Description("w20120")]
        铅,
        /// <summary>
        /// CN
        /// </summary>
        [Description("w21016")]
        氰化物,
        /// <summary>
        /// PHEN
        /// </summary>
        [Description("w23002")]
        挥发酚,
        /// <summary>
        /// TPH
        /// </summary>
        [Description("w22001")]
        石油类,
        /// <summary>
        /// LAS
        /// </summary>
        [Description("w19002")]
        阴离子表面活性剂,
        /// <summary>
        /// H2S
        /// </summary>
        [Description("w21019")]
        硫化物,
        /// <summary>
        /// FC
        /// </summary>
        [Description("w02003")]
        粪大肠菌群
    }
}
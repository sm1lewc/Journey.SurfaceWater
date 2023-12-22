using System.ComponentModel;

namespace Journey.SurfaceWater.Enums
{
    /// <summary>
    /// 监测指标枚举
    /// </summary>
    public enum Factor
    {
        //code大写，方便反射匹配

        /// <summary>
        /// NTU
        /// </summary>
        [Description("W01003,NTU")]
        浊度,
        /// <summary>
        /// EC
        /// </summary>
        [Description("W01014,EC")]
        电导率,
        /// <summary>
        /// WT
        /// </summary>
        [Description("W01010,WT")]
        水温,
        /// <summary>
        /// PH
        /// </summary>
        [Description("W01001,PH")]
        pH,
        /// <summary>
        /// DO
        /// </summary>
        [Description("W01009,DO")]
        溶解氧,
        /// <summary>
        /// CODMN
        /// </summary>
        [Description("W01019,CODMN")]
        高锰酸盐指数,
        /// <summary>
        /// COD
        /// </summary>
        [Description("W01018,COD")]
        化学需氧量,
        /// <summary>
        /// BOD5
        /// </summary>
        [Description("BOD5,w01017")]
        五日生化需氧量,
        /// <summary>
        /// NH3N
        /// </summary>
        [Description("W21003,NH3N")]
        氨氮,
        /// <summary>
        /// TP
        /// </summary>
        [Description("W21011,TP")]
        总磷,
        /// <summary>
        /// TN
        /// </summary>
        [Description("W21001,TN")]
        总氮,
        /// <summary>
        /// CU
        /// </summary>
        [Description("W20122,CU")]
        铜,
        /// <summary>
        /// ZN
        /// </summary>
        [Description("W20123,ZN")]
        锌,
        /// <summary>
        /// F
        /// </summary>
        [Description("W21017,F")]
        氟化物,
        /// <summary>
        /// SE
        /// </summary>
        [Description("W20128,SE")]
        硒,
        /// <summary>
        /// AS
        /// </summary>
        [Description("W20141,AS")]
        砷,
        /// <summary>
        /// HG
        /// </summary>
        [Description("W20111,HG")]
        汞,
        /// <summary>
        /// CD
        /// </summary>
        [Description("W20115,CD")]
        镉,
        /// <summary>
        /// CR6
        /// </summary>
        [Description("W20117,CR6")]
        六价铬,
        /// <summary>
        /// PB
        /// </summary>
        [Description("W20120,PB")]
        铅,
        /// <summary>
        /// CN
        /// </summary>
        [Description("W21016,CN")]
        氰化物,
        /// <summary>
        /// PHEN
        /// </summary>
        [Description("W23002,PHEN")]
        挥发酚,
        /// <summary>
        /// TPH
        /// </summary>
        [Description("W22001,TPH")]
        石油类,
        /// <summary>
        /// LAS
        /// </summary>
        [Description("W19002,LAS")]
        阴离子表面活性剂,
        /// <summary>
        /// H2S
        /// </summary>
        [Description("W21019,H2S")]
        硫化物,
        /// <summary>
        /// FC
        /// </summary>
        [Description("W02003,FC")]
        粪大肠菌群,
        /// <summary>
        /// SO42
        /// </summary>
        [Description("W21038,SO42")]
        硫酸盐,
        /// <summary>
        /// CL
        /// </summary>
        [Description("W21022,CL")]
        氯化物,
        /// <summary>
        /// NO3
        /// </summary>
        [Description("W21007,NO3")]
        硝酸盐,
        /// <summary>
        /// FE
        /// </summary>
        [Description("W20125,FE")]
        铁,
        /// <summary>
        /// MN
        /// </summary>
        [Description("W20124,MN")]
        锰,
        /// <summary>
        /// MO
        /// </summary>
        [Description("W20061,MO")]
        钼,
        /// <summary>
        /// CO
        /// </summary>
        [Description("W20038,CO")]
        钴,
        /// <summary>
        /// BE
        /// </summary>
        [Description("W20127,BE")]
        铍,
        /// <summary>
        /// B
        /// </summary>
        [Description("W20023,B")]
        硼,
        /// <summary>
        /// SB
        /// </summary>
        [Description("W20004,SB")]
        锑,
        /// <summary>
        /// NI
        /// </summary>
        [Description("W20121,NI")]
        镍,
        /// <summary>
        /// BA
        /// </summary>
        [Description("W20012,BA")]
        钡,
        /// <summary>
        /// V
        /// </summary>
        [Description("W20101,V")]
        钒,
        /// <summary>
        /// TI
        /// </summary>
        [Description("W20095,TI")]
        钛,
        /// <summary>
        /// TL
        /// </summary>
        [Description("W20089,TL")]
        铊,
        /// <summary>
        /// TC
        /// </summary>
        [Description("W01004,TC")]
        透明度,
        /// <summary>
        /// CHLA
        /// </summary>
        [Description("W01016,CHLA")]
        叶绿素a,
        /// <summary>
        /// C
        /// </summary>
        [Description("W19011,C")]
        藻密度
    }

}
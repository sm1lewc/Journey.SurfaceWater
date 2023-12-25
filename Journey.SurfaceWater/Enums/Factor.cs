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
        藻密度,
        /// <summary>
        /// TRICHLOROMETHANE
        /// </summary>
        [Description("W24004,TRICHLOROMETHANE")]
        三氯甲烷,
        /// <summary>
        /// TETRACHLOROMETHANE
        /// </summary>
        [Description("W24005,TETRACHLOROMETHANE")]
        四氯化碳_四氯甲烷,
        /// <summary>
        /// TRIBROMOMETHANE
        /// </summary>
        [Description("W24009,TRIBROMOMETHANE")]
        三溴甲烷,
        /// <summary>
        /// DCM
        /// </summary>
        [Description("W24003,DCM")]
        二氯甲烷,
        /// <summary>
        /// DICHLOROETHANE
        /// </summary>
        [Description("W24017,DICHLOROETHANE")]
        一_二_二氯乙烷,
        /// <summary>
        /// ECH
        /// </summary>
        [Description("W24024,ECH")]
        环氧氯丙烷,
        /// <summary>
        /// VCM
        /// </summary>
        [Description("W24046,VCM")]
        氯乙烯,
        /// <summary>
        /// 11DCE
        /// </summary>
        [Description("W24047,11DCE")]
        一_一_二氯乙烯,
        /// <summary>
        /// 12DCE
        /// </summary>
        [Description("W24048,12DCE")]
        一_二_二氯乙烯,
        /// <summary>
        /// TCE
        /// </summary>
        [Description("W24049,TCE")]
        三氯乙烯,
        /// <summary>
        /// PCE
        /// </summary>
        [Description("W24050,PCE")]
        四氯乙烯,
        /// <summary>
        /// CHLOROPRENE
        /// </summary>
        [Description("W24062,CHLOROPRENE")]
        氯丁二烯,
        /// <summary>
        /// HCBD
        /// </summary>
        [Description("W24064,HCBD")]
        六氯丁二烯,
        /// <summary>
        /// STYRENE
        /// </summary>
        [Description("W25038,STYRENE")]
        苯乙烯,
        /// <summary>
        /// FORMALDEHYDE
        /// </summary>
        [Description("W31001,FORMALDEHYDE")]
        甲醛,
        /// <summary>
        /// ACETALDEHYDE
        /// </summary>
        [Description("W31002,ACETALDEHYDE")]
        乙醛,
        /// <summary>
        /// ACROLEIN
        /// </summary>
        [Description("W31004,ACROLEIN")]
        丙烯醛,
        /// <summary>
        /// CHLORAL
        /// </summary>
        [Description("W31003,CHLORAL")]
        三氯乙醛,
        /// <summary>
        /// PHH
        /// </summary>
        [Description("W25002,PHH")]
        苯,
        /// <summary>
        /// TOLUENE
        /// </summary>
        [Description("W25003,TOLUENE")]
        甲苯,
        /// <summary>
        /// XYLENE
        /// </summary>
        [Description("W25005,XYLENE")]
        二甲苯,
        /// <summary>
        /// IBP
        /// </summary>
        [Description("W25034,IBP")]
        异丙苯,
        /// <summary>
        /// PHCL
        /// </summary>
        [Description("W25010,PHCL")]
        氯苯,
        /// <summary>
        /// 12DCB
        /// </summary>
        [Description("W25011,12DCB")]
        一_二_二氯苯,
        /// <summary>
        /// 14DCB
        /// </summary>
        [Description("W25013,14DCB")]
        一_四_二氯苯,
        /// <summary>
        /// TRICHLOROBENZENE
        /// </summary>
        [Description("W25014,TRICHLOROBENZENE")]
        三氯苯,
        /// <summary>
        /// CCL4C6H4
        /// </summary>
        [Description("W25016,CCL4C6H4")]
        四氯苯,
        /// <summary>
        /// HEXACHLOROBENZENE
        /// </summary>
        [Description("W25019,HEXACHLOROBENZENE")]
        六氯苯,
        /// <summary>
        /// NITROBENZENE
        /// </summary>
        [Description("W25023,NITROBENZENE")]
        硝基苯,
        /// <summary>
        /// C6H4O2N2
        /// </summary>
        [Description("W25027,C6H4O2N2")]
        二硝基苯,
        /// <summary>
        /// DINITROTOLUENE
        /// </summary>
        [Description("W25030,DINITROTOLUENE")]
        二_四_二硝基甲苯,
        /// <summary>
        /// TNT
        /// </summary>
        [Description("W25032,TNT")]
        二_四_六_三硝基甲苯,
        /// <summary>
        /// CHLORONITROBENZENE
        /// </summary>
        [Description("W25020,CHLORONITROBENZENE")]
        硝基氯苯,
        /// <summary>
        /// CLC6H3NO22
        /// </summary>
        [Description("W25022,CLC6H3NO22")]
        二_四_二硝基氯苯,
        /// <summary>
        /// CL2C6H4OH
        /// </summary>
        [Description("W23020,CL2C6H4OH")]
        二_四_二氯苯酚,
        /// <summary>
        /// CL3C6H3OH
        /// </summary>
        [Description("W23022,CL3C6H3OH")]
        二_四_六_三氯苯酚,
        /// <summary>
        /// CL5C6H3OH
        /// </summary>
        [Description("W23025,CL5C6H3OH")]
        五氯酚,
        /// <summary>
        /// ANILINE
        /// </summary>
        [Description("W26001,ANILINE")]
        苯胺,
        /// <summary>
        /// C6H5NH2
        /// </summary>
        [Description("W26002,C6H5NH2")]
        联苯胺,
        /// <summary>
        /// AM
        /// </summary>
        [Description("W26048,AM")]
        丙烯酰胺,
        /// <summary>
        /// ACRYLONITRILE
        /// </summary>
        [Description("W99010,ACRYLONITRILE")]
        丙烯腈,
        /// <summary>
        /// DIBUTYL_PHTHALATE
        /// </summary>
        [Description("W29002,DIBUTYL_PHTHALATE")]
        邻苯二甲酸二丁酯,
        /// <summary>
        /// DEHP
        /// </summary>
        [Description("W29004,DEHP")]
        邻苯二甲酸二_二_乙基己基_酯,
        /// <summary>
        /// H2O2
        /// </summary>
        [Description("W21009,HO2O")]
        水合肼,
        /// <summary>
        /// ET4PB
        /// </summary>
        [Description("W20047,ET4PB")]
        四乙基铅,
        /// <summary>
        /// PYRIDINE
        /// </summary>
        [Description("W25052,PYRIDINE")]
        吡啶,
        /// <summary>
        /// TURPENTINE
        /// </summary>
        [Description("W22007,TURPENTINE")]
        松节油,
        /// <summary>
        /// BITTERACID
        /// </summary>
        [Description("W23036,BITTERACID")]
        苦味酸,
        /// <summary>
        /// NBUACGN
        /// </summary>
        [Description("W32003,NBUACGN")]
        丁基黄原酸,
        /// <summary>
        /// CL2O
        /// </summary>
        [Description("W21023,CL2O")]
        活性氯,
        /// <summary>
        /// DDT
        /// </summary>
        [Description("W33007,DDT")]
        滴滴涕,
        /// <summary>
        /// LINDANE
        /// </summary>
        [Description("W33005,LINDANE")]
        林丹,
        /// <summary>
        /// HEPTACHLOR_EPOXIDE
        /// </summary>
        [Description("W99003,HEPTACHLOR_EPOXIDE")]
        环氧七氯,
        /// <summary>
        /// PARATHION
        /// </summary>
        [Description("W33030,PARATHION")]
        对硫磷,
        /// <summary>
        /// PHRATHION_METHYL
        /// </summary>
        [Description("W33021,PHRATHION_METHYL")]
        甲基对硫磷,
        /// <summary>
        /// MALATHION
        /// </summary>
        [Description("W33022,MALATHION")]
        马拉硫磷,
        /// <summary>
        /// DIMETHOATE
        /// </summary>
        [Description("W33019,DIMETHOATE")]
        乐果,
        /// <summary>
        /// DDVP
        /// </summary>
        [Description("W33010,DDVP")]
        敌敌畏,
        /// <summary>
        /// DIPTEREX
        /// </summary>
        [Description("W33011,DIPTEREX")]
        敌百虫,
        /// <summary>
        /// SYSTOX
        /// </summary>
        [Description("W33025,SYSTOX")]
        内吸磷,
        /// <summary>
        /// CHLOROTHALONIL
        /// </summary>
        [Description("W33012,CHLOROTHALONIL")]
        百菌清,
        /// <summary>
        /// CARBARYL
        /// </summary>
        [Description("W33047,CARBARYL")]
        甲萘威,
        /// <summary>
        /// DELTAMETHRIN
        /// </summary>
        [Description("W33052,DELTAMETHRIN")]
        溴氰菊酯,
        /// <summary>
        /// ATRAZINE
        /// </summary>
        [Description("W33029,ATRAZINE")]
        阿特拉津,
        /// <summary>
        /// BENZOPYRENE
        /// </summary>
        [Description("W25043,BENZOPYRENE")]
        苯并a芘,
        /// <summary>
        /// METHYLMERCURY
        /// </summary>
        [Description("W20136,METHYLMERCURY")]
        甲基汞,
        /// <summary>
        /// POLYCHLORINATED_BIPHENYLS
        /// </summary>
        [Description("W27001,POLYCHLORINATED_BIPHENYLS")]
        多氯联苯,
        /// <summary>
        /// MICROCYSTINLR
        /// </summary>
        [Description("W99004,MICROCYSTINLR")]
        微囊藻毒素LR,
        /// <summary>
        /// PHOSPHORUS
        /// </summary>
        [Description("W21013,PHOSPHORUS")]
        黄磷
    }

}
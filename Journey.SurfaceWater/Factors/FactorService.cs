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
            switch (abbrOrCode.ToUpper())
            {
                case "WT":
                case "W01010": return "水温";
                case "PH":
                case "W01001": return "pH";
                case "DO":
                case "W01009": return "溶解氧";
                case "CODMN":
                case "W01019": return "高锰酸盐指数";
                case "COD":
                case "W01018": return "化学需氧量";
                case "BOD5":
                case "W01017": return "五日生化需氧量";
                case "NH3N":
                case "W21003": return "氨氮";
                case "TP":
                case "W21011": return "总磷";
                case "TN":
                case "W21001": return "总氮";
                case "CU":
                case "W20122": return "铜";
                case "ZN":
                case "W20123": return "锌";
                case "F":
                case "W21017": return "氟化物";
                case "SE":
                case "W20128": return "硒";
                case "AS":
                case "W20141": return "砷";
                case "HG":
                case "W20111": return "汞";
                case "CD":
                case "W20115": return "镉";
                case "CR6":
                case "W20117": return "铬(六价)";
                case "PB":
                case "W20120": return "铅";
                case "CN":
                case "W21016": return "氰化物";
                case "PHEN":
                case "W23002": return "挥发酚";
                case "TPH":
                case "W22001": return "石油类";
                case "LAS":
                case "W19002": return "阴离子表面活性剂";
                case "H2S":
                case "W21019": return "硫化物";
                case "FC":
                case "W02003": return "粪大肠菌群";
                default: return null;
            }
        }

        /// <summary>
        /// 根据监测指标的编码获取监测指标的缩写，如果没有找到则返回null
        /// 不区分大小写
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string? GetFactorAbbreviationByCode(string code)
        {
            return code.ToUpper() switch
            {
                "W01010" => "WT",
                "W01001" => "PH",
                "W01009" => "DO",
                "W01019" => "CODMN",
                "W01018" => "COD",
                "W01017" => "BOD5",
                "W21003" => "NH3N",
                "W21011" => "TP",
                "W21001" => "TN",
                "W20122" => "CU",
                "W20123" => "ZN",
                "W21017" => "F",
                "W20128" => "SE",
                "W20141" => "AS",
                "W20111" => "HG",
                "W20115" => "CD",
                "W20117" => "CR6",
                "W20120" => "PB",
                "W21016" => "CN",
                "W23002" => "PHEN",
                "W22001" => "TPH",
                "W19002" => "LAS",
                "W21019" => "H2S",
                "W02003" => "FC",
                _ => null
            };
        }

        /// <summary>
        /// 根据监测指标的名称获取监测指标的缩写，如果没有找到则返回null
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static string? GetFactorAbbreviationByName(Enums.Factor factor)
        {
            return factor switch
            {
                Enums.Factor.水温 => "WT",
                Enums.Factor.pH => "PH",
                Enums.Factor.溶解氧 => "DO",
                Enums.Factor.高锰酸盐指数 => "CODMN",
                Enums.Factor.化学需氧量 => "COD",
                Enums.Factor.五日生化需氧量 => "BOD5",
                Enums.Factor.氨氮 => "NH3N",
                Enums.Factor.总磷 => "TP",
                Enums.Factor.总氮 => "TN",
                Enums.Factor.铜 => "CU",
                Enums.Factor.锌 => "ZN",
                Enums.Factor.氟化物 => "F",
                Enums.Factor.硒 => "SE",
                Enums.Factor.砷 => "AS",
                Enums.Factor.汞 => "HG",
                Enums.Factor.镉 => "CD",
                Enums.Factor.六价铬 => "CR6",
                Enums.Factor.铅 => "PB",
                Enums.Factor.氰化物 => "CN",
                Enums.Factor.挥发酚 => "PHEN",
                Enums.Factor.石油类 => "TPH",
                Enums.Factor.阴离子表面活性剂 => "LAS",
                Enums.Factor.硫化物 => "H2S",
                Enums.Factor.粪大肠菌群 => "FC",
                _ => null
            };
        }

        /// <summary>
        /// 根据监测指标的缩写获取监测指标的编码，如果没有找到则返回null
        /// 不区分大小写
        /// </summary>
        /// <param name="abbreviation"></param>
        /// <returns></returns>
        public static string? GetFactorCodeByAbbreviation(string abbreviation)
        {
            return abbreviation.ToUpper() switch
            {
                "WT" => "w01010",
                "PH" => "w01001",
                "DO" => "w01009",
                "CODMN" => "w01019",
                "COD" => "w01018",
                "BOD5" => "w01017",
                "NH3N" => "w21003",
                "TP" => "w21011",
                "TN" => "w21001",
                "CU" => "w20122",
                "ZN" => "w20123",
                "F" => "w21017",
                "SE" => "w20128",
                "AS" => "w20141",
                "HG" => "w20111",
                "CD" => "w20115",
                "CR6" => "w20117",
                "PB" => "w20120",
                "CN" => "w21016",
                "PHEN" => "w23002",
                "TPH" => "w22001",
                "LAS" => "w19002",
                "H2S" => "w21019",
                "FC" => "w02003",
                _ => null
            };
        }

        /// <summary>
        /// 根据监测指标的名称获取监测指标的编码，如果没有找到则返回null
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static string? GetFactorCodeByName(Enums.Factor factor)
        {
            return factor switch
            {
                Enums.Factor.水温 => "w01010",
                Enums.Factor.pH => "w01001",
                Enums.Factor.溶解氧 => "w01009",
                Enums.Factor.高锰酸盐指数 => "w01019",
                Enums.Factor.化学需氧量 => "w01018",
                Enums.Factor.五日生化需氧量 => "w01017",
                Enums.Factor.氨氮 => "w21003",
                Enums.Factor.总磷 => "w21011",
                Enums.Factor.总氮 => "w21001",
                Enums.Factor.铜 => "w20122",
                Enums.Factor.锌 => "w20123",
                Enums.Factor.氟化物 => "w21017",
                Enums.Factor.硒 => "w20128",
                Enums.Factor.砷 => "w20141",
                Enums.Factor.汞 => "w20111",
                Enums.Factor.镉 => "w20115",
                Enums.Factor.六价铬 => "w20117",
                Enums.Factor.铅 => "w20120",
                Enums.Factor.氰化物 => "w21016",
                Enums.Factor.挥发酚 => "w23002",
                Enums.Factor.石油类 => "w22001",
                Enums.Factor.阴离子表面活性剂 => "w19002",
                Enums.Factor.硫化物 => "w21019",
                Enums.Factor.粪大肠菌群 => "w02003",
                _ => null
            };

        }
    }
}

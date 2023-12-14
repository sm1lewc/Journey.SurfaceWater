namespace Journey.SurfaceWater.Models
{
    /// <summary>
    /// GB 3838《地表水环境质量标准》中表1的基本项目的值和类别
    /// </summary>
    public class BasicItemValuesAndGrades : BasicItemValues
    {
        /// <summary>
        /// PH类别
        /// </summary>
        public int? PHGrade { get; set; }
        /// <summary>
        /// PH类别文本
        /// </summary>
        public string? PHGradeText { get; set; }
        /// <summary>
        /// 溶解氧类别
        /// </summary>
        public int? DOGrade { get; set; }
        /// <summary>
        /// 溶解氧类别文本
        /// </summary>
        public string? DOGradeText { get; set; }
        /// <summary>
        /// 高锰酸盐指数类别
        /// </summary>
        public int? CODMNGrade { get; set; }
        /// <summary>
        /// 高锰酸盐指数类别文本
        /// </summary>
        public string? CODMNGradeText { get; set; }
        /// <summary>
        /// 化学需氧量类别
        /// </summary>
        public int? CODGrade { get; set; }
        /// <summary>
        /// 化学需氧量类别文本
        /// </summary>
        public string? CODGradeText { get; set; }
        /// <summary>
        /// 五日生化需氧量类别
        /// </summary>
        public int? BOD5Grade { get; set; }
        /// <summary>
        /// 五日生化需氧量类别文本
        /// </summary>
        public string? BOD5GradeText { get; set; }
        /// <summary>
        /// 氨氮类别
        /// </summary>
        public int? NH3NGrade { get; set; }
        /// <summary>
        /// 氨氮类别文本
        /// </summary>
        public string? NH3NGradeText { get; set; }
        /// <summary>
        /// 总磷类别
        /// </summary>
        public int? TPGrade { get; set; }
        /// <summary>
        /// 总磷类别文本
        /// </summary>
        public string? TPGradeText { get; set; }
        /// <summary>
        /// 总氮类别
        /// </summary>
        public int? TNGrade { get; set; }
        /// <summary>
        /// 总氮类别文本
        /// </summary>
        public string? TNGradeText { get; set; }
        /// <summary>
        /// 铜类别
        /// </summary>
        public int? CUGrade { get; set; }
        /// <summary>
        /// 铜类别文本
        /// </summary>
        public string? CUGradeText { get; set; }
        /// <summary>
        /// 锌类别
        /// </summary>
        public int? ZNGrade { get; set; }
        /// <summary>
        /// 锌类别文本
        /// </summary>
        public string? ZNGradeText { get; set; }
        /// <summary>
        /// 氟化物类别
        /// </summary>
        public int? FGrade { get; set; }
        /// <summary>
        /// 氟化物类别文本
        /// </summary>
        public string? FGradeText { get; set; }
        /// <summary>
        /// 硒类别
        /// </summary>
        public int? SEGrade { get; set; }
        /// <summary>
        /// 硒类别文本
        /// </summary>
        public string? SEGradeText { get; set; }
        /// <summary>
        /// 砷类别 
        /// </summary>
        public int? ASGrade { get; set; }
        /// <summary>
        /// 砷类别文本
        /// </summary>
        public string? ASGradeText { get; set; }
        /// <summary>
        /// 汞类别
        /// </summary>
        public int? HGGrade { get; set; }
        /// <summary>
        /// 汞类别文本
        /// </summary>
        public string? HGGradeText { get; set; }
        /// <summary>
        /// 镉类别
        /// </summary>
        public int? CDGrade { get; set; }
        /// <summary>
        /// 镉类别文本
        /// </summary>
        public string? CDGradeText { get; set; }
        /// <summary>
        /// 六价铬类别
        /// </summary>
        public int? CR6Grade { get; set; }
        /// <summary>
        /// 六价铬类别文本
        /// </summary>
        public string? CR6GradeText { get; set; }
        /// <summary>
        /// 铅类别
        /// </summary>
        public int? PBGrade { get; set; }
        /// <summary>
        /// 铅类别文本
        /// </summary>
        public string? PBGradeText { get; set; }
        /// <summary>
        /// 氰化物类别
        /// </summary>
        public int? CNGrade { get; set; }
        /// <summary>
        /// 氰化物类别文本
        /// </summary>
        public string? CNGradeText { get; set; }
        /// <summary>
        ///  挥发酚类别
        /// </summary>
        public int? PHENGrade { get; set; }
        /// <summary>
        /// 挥发酚类别文本
        /// </summary>
        public string? PHENGradeText { get; set; }
        /// <summary>
        /// 石油类类别
        /// </summary>
        public int? TPHGrade { get; set; }
        /// <summary>
        /// 石油类类别文本
        /// </summary>
        public string? TPHGradeText { get; set; }
        /// <summary>
        /// 阴离子表面活性剂类别
        /// </summary>
        public int? LASGrade { get; set; }
        /// <summary>
        /// 阴离子表面活性剂类别文本
        /// </summary>
        public string? LASGradeText { get; set; }
        /// <summary>
        /// 硫化物类别
        /// </summary>
        public int? H2SGrade { get; set; }
        /// <summary>
        /// 硫化物类别文本
        /// </summary>
        public string? H2SGradeText { get; set; }
        /// <summary>
        /// 粪大肠类别
        /// </summary>
        public int? FCGrade { get; set; }
        /// <summary>
        /// 粪大肠类别问题
        /// </summary>
        public string? FCGradeText { get; set; }
        /// <summary>
        /// 整体水质类别
        /// </summary>
        public int? WaterGrade { get; set; }
        /// <summary>
        /// 整体水质类别文本
        /// </summary>
        public string? WaterGradeText { get; set; }
    }
}

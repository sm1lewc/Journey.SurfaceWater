namespace Journey.SurfaceWater.Models
{
    /// <summary>
    /// 标准限值
    /// </summary>
    public class StandardLimit
    {
        /// <summary>
        /// 水质类别
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 类别标准限值
        /// </summary>
        public double Limit { get; set; }
    }
}

using System.Collections.Generic;

namespace YouService.Data.Services.Colleges
{
    /// <summary>
    /// 搜索院校的参数输入
    /// </summary>
    public class CollegeSearchInput : PagingInput
    {
        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 省份Id列表
        /// </summary>
        public IList<int> ProvinceIds { get; set; }

        /// <summary>
        /// 办学层次，如：211、985
        /// </summary>
        public IList<string> Levels { get; set; }

        /// <summary>
        /// 学科范围，如：综合、理工
        /// </summary>
        public IList<string> Classify { get; set; }

        /// <summary>
        /// 教育性质，如：大学、学院
        /// </summary>
        public IList<string> Natures { get; set; }

        /// <summary>
        /// 是否艺术类
        /// </summary>
        public bool? IsArt { get; set; }

        /// <summary>
        /// 是否本科
        /// </summary>
        public bool? IsBen { get; set; }

        /// <summary>
        /// 公立=1
        /// 私立=0
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 是否单招
        /// </summary>
        public bool? IsSingleRecruit { get; set; }

        /// <summary>
        /// 是否做关键字分词搜索
        /// 比如：同济、大学
        /// </summary>
        public bool WordSegment { get; set; }
    }
}

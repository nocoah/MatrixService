using UPrime.AutoMapper;
using UPrime.Services.Dto;
using YouService.Data.Domain.Colleges;
using YouService.Data.Services.Common;

namespace YouService.Data.Services.Colleges
{
    /// <summary>
    /// 代表“一所大学的短信信息”，一般用于列表搜索
    /// </summary>
    [AutoMapFrom(typeof(College))]
    public class CollegeBriefDto : EntityDto
    {
        /// <summary>
        /// 全国代码 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        public string CnName { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EnName { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 所属省份
        /// </summary>
        public AreaDto Province { get; set; }
    }
}

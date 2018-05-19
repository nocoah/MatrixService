using UPrime.Services.Dto;
using UPrime.AutoMapper;
using YouService.Data.Domain.Common;

namespace YouService.Data.Services.Common
{
    /// <summary>
    /// 代表“一个地区信息”，主要用于省、地区、城市
    /// </summary>
    [AutoMapFrom(typeof(Area))]
    public class AreaDto : EntityDto
    {
        /// <summary>
        /// 地区名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父地区Id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 地区类型标识
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 地区类型
        /// </summary>
        public AreaType Type
        {
            get
            {
                return (AreaType)this.TypeId;
            }
            set
            {
                this.TypeId = (int)value;
            }
        }
    }
}

using UPrime.Domain.Entities;
using YouService.Data.Domain.Common;

namespace YouService.Data.Domain.Colleges
{
    /// <summary>
    /// 代表“一所大学的信息”
    /// </summary>
    public class College : Entity, ISoftDelete
    {
        /// <summary>
        /// 全国代码 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Logo picture id
        /// </summary>
        public int LogoId { get; set; }

        /// <summary>
        /// log picutre url
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// 省份Id
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 城市Id
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        public string CnName { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EnName { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        public string NameUsedBefore { get; set; }

        /// <summary>
        /// 创立时间
        /// </summary>
        public string Creation { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int Hits { get; set; }

        #region ISoftDelete
        public bool IsDeleted { get; set; }
        #endregion

        #region Navigation Properties
        /// <summary>
        /// 所属省份
        /// </summary>
        public virtual Area Province{ get; set; }
        #endregion
    }
}

using UPrime.Domain.Entities;

namespace YouService.Data.Domain.StudyAboard
{
    /// <summary>
    /// 留学模块 - 新闻资讯
    /// </summary>
    public class Article : Entity
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string FromSource { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 文章简介（关键性内容）
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 预览图Url
        /// </summary>
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 文章类型标识
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 审核状态标识
        /// </summary>
        public int AuditTypeId { get; set; }

        /// <summary>
        /// 省份Id（0=全国）
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 网页标签
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// 网页描述
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// 显示的版本 0=全部 1=电脑 2=移动
        /// </summary>
        public int VersionId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public int TemplatesId { get; set; }

        #region Show 根据对应参数条件显示
        /// <summary>
        /// 首页显示
        /// </summary>
        public bool ShowHomePage { get; set; }
        /// <summary>
        /// 首页显示焦点（高考观察）
        /// </summary>
        public bool ShowHomePageFocus { get; set; }

        /// <summary>
        /// 高考页显示
        /// </summary>
        public bool ShowNewsPage { get; set; }

        /// <summary>
        /// 高考页焦点显示（高考观察）
        /// </summary>
        public bool ShowNewsPageFocus { get; set; }

        /// <summary>
        /// 高考页显示Banner
        /// </summary>
        public bool ShowNewsPageBanner { get; set; }

        /// <summary>
        /// 是否同步到B端
        /// </summary>
        public bool IsSynToB { get; set; }

        /// <summary>
        /// 同步到B端的内容
        /// </summary>
        public string BodyToB { get; set; }
        #endregion

        #region Custom Properties
        /// <summary>
        /// 文章类型
        /// </summary>
        public ArticleType Type
        {
            get { return (ArticleType)TypeId; }
            set { TypeId = (int)value; }
        }

        /// <summary>
        /// 审核状态
        /// </summary>
        public ArticleAuditType AuditType
        {
            get { return (ArticleAuditType)AuditTypeId; }
            set { AuditTypeId = (int)value; }
        }

        /// <summary>
        /// 该资讯所属省份
        /// </summary>
        public string ProvinceName { get; set; }
        #endregion
    }
}

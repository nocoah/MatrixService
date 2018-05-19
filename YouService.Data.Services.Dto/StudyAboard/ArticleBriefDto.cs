using UPrime.AutoMapper;
using UPrime.Services.Dto;
using YouService.Data.Domain.StudyAboard;

namespace YouService.Data.Services.StudyAboard
{
    /// <summary>
    /// 文章简要，一般用于搜索
    /// </summary>
    [AutoMapFrom(typeof(Article))]
    public class ArticleBriefDto : FullAuditedEntityDto
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
        /// 省份Id（0=全国）
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 文章类型（版块）
        /// </summary>
        public ArticleType Type { get; set; }

        /// <summary>
        /// 文章类型（版块）标识
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }

        public string FormatTitle { get; set; }
    }
}

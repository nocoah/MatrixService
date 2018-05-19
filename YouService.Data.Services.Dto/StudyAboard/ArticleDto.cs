using UPrime.AutoMapper;
using YouService.Data.Domain.StudyAboard;

namespace YouService.Data.Services.StudyAboard
{
    [AutoMapFrom(typeof(Article))]
    public class ArticleDto : ArticleBriefDto
    {
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
        /// 内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public int TemplatesId { get; set; }

        /// <summary>
        /// 是否同步到B端
        /// </summary>
        public bool IsSynToB { get; set; }

        /// <summary>
        /// 同步到B端的内容
        /// </summary>
        public string BodyToB { get; set; }
    }
}

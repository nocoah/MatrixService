using UPrime.Services.Dto;
using UPrime.Domain.Entities.Caching;
using YouService.Data.Domain.StudyAboard;
using System.Collections.Generic;

namespace YouService.Data.Services.StudyAboard
{
    /// <summary>
    /// 优志愿 留学模块 资讯新闻 缓存化
    /// </summary>
    public interface IArticleCache : IEntityCache<ArticleDto>
    {
        #region Search / Getts

        /// <summary>
        /// 查询一条新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ArticleDto GetById(int id);

        /// <summary>
        /// 分页查询新闻
        /// </summary>
        /// <param name="auditType"></param>
        /// <param name="type"></param>
        /// <param name="showType"></param>
        /// <param name="province"></param>
        /// <param name="keyWords"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        List<Article> Search(int auditType, int type, ArticleShowType showType, int province, string keyWords, int pageIndex, int pageSize,
            out int count);

        /// <summary>
        /// 增加点击量
        /// </summary>
        /// <param name="articleId"></param>
        void AddHits(int articleId);

        #endregion
    }
}

using System.Collections.Generic;
using YouService.Data.Domain.StudyAboard;

namespace YouService.Data.Services.StudyAboard
{
    /// <summary>
    /// 优志愿留学项目资讯
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// 查询一篇文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Article Get(int id);

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
    }
}

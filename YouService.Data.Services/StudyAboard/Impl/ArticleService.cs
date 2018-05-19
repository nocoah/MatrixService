using System.Collections.Generic;
using YouService.Data.Domain.StudyAboard;
using YouService.Data.Domain.StudyAboard.Repositories;

namespace YouService.Data.Services.StudyAboard.Impl
{
    public partial class ArticleService : ServiceBase, IArticleService
    {
        #region Fileds & Ctor
        private readonly IArticleCache _articleCache;
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleCache articleCache, IArticleRepository articleRepository)
        {
            this._articleCache = articleCache;
            this._articleRepository = articleRepository;
        }
        #endregion

        #region Search / Getts

        /// <summary>
        /// 查询一篇文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Article Get(int id)
        {
            return null;   
        }

        #endregion

        /// <summary>
        /// 查询一条新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ArticleDto GetById(int id)
        {
            return null;
        }

        /// <summary>
        /// 增加点击量
        /// </summary>
        /// <param name="articleId"></param>
        public void AddHits(int articleId)
        {
        }

        /// <summary>
        ///  分页查询新闻
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
        public List<Article> Search(int auditType, int type, ArticleShowType showType, int province, string keyWords, int pageIndex, int pageSize, out int count)
        {
            count = 0;
            return null;
        }
    }
}

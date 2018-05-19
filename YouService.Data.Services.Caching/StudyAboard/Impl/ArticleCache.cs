using System.Collections.Generic;
using UPrime.Dependency;
using UPrime.Domain.Entities.Caching;
using UPrime.Events.Bus.Entities;
using UPrime.Services.Dto;
using YouService.Data.Domain.StudyAboard;
using YouService.Data.Domain.StudyAboard.Repositories;

namespace YouService.Data.Services.StudyAboard.Impl
{
    public class ArticleCache : EntityCache<Article, ArticleDto>, IArticleCache, ITransientDependency
    {
        #region Keys
        public const string StudyAboard_Article = "StudyAboardArticle-{0}";
        #endregion

        public ArticleCache(ICacheManagerProvider cacheManagerProvider, IArticleRepository repository)
        : base(cacheManagerProvider.GetCacheManager(), repository, "Article")
        {

        }

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

        public override void HandleEvent(EntityChangedEventData<Article> eventData)
        {
            base.HandleEvent(eventData);
        }

    }
}

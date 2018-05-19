using System.Configuration;

namespace YouService.Data.Configuration
{
    public static class CoreSettings
    {
        /// <summary>
        /// 数据库(多）有并的连接
        /// </summary>
        public static class DbConnectionString
        {
            /// <summary>
            /// 核心数据的配置
            /// 如：Youzy.Data (Db)
            /// </summary>
            public static string Data
            {
                get { return ConfigurationManager.AppSettings["YouService.Data.DbConnectionString.Data"]; }

            }

            /// <summary>
            /// 通用业务的配置
            /// 如：Youzy (Db)
            /// </summary>
            public static string Common
            {
                get { return ConfigurationManager.AppSettings["YouService.Data.DbConnectionString.Common"]; }
            }

            /// <summary>
            /// Youzy.Core数据库，有些通用业务原来放在C端的数据库中
            /// </summary>
            public static string Core {
                get { return ConfigurationManager.AppSettings["YouService.Data.DbConnectionString.Core"]; }
            }

        }

        /// <summary>
        /// 是否开启缓存
        /// </summary>
        public static bool CachingOpened
        {
            get { return ConfigurationManager.AppSettings["YouService.Data.CachingOpened"].ToBool(); }
        }

        /// <summary>
        /// 是否开启Redis，目前业务缓存在一起
        /// false：使用内存
        /// true：Redis server
        /// </summary>
        public static bool RedisEnabled
        {
            get { return ConfigurationManager.AppSettings["YouService.Data.RedisEnabled"].ToBool(); }
        }

        /// <summary>
        /// Redis连接字符串
        /// </summary>
        public static string RedisConnectionString
        {
            get { return ConfigurationManager.AppSettings["YouService.Data.RedisConnectionString"]; }
        }

        /// <summary>
        /// 数据库Id
        /// Redis：(1-12)
        /// </summary>
        public static int RedisDatabaseId
        {
            get { return ConfigurationManager.AppSettings["YouService.Data.RedisDatabaseId"].ToInt(); }
        }
    }
}

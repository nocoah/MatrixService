using UPrime.CodeAnnotations;

namespace YouService.Data
{
    /// <summary>
    /// 地区类型
    /// </summary>
    public enum AreaType : int
    {
        /// <summary>
        /// 省
        /// </summary>
        Province = 1,
        /// <summary>
        /// 市
        /// </summary>
        City = 2,
        /// <summary>
        /// 地区
        /// </summary>
        District = 3,
        /// <summary>
        /// 高中
        /// </summary>
        School = 4
    }

    /// <summary>
    /// 表示“院校标签”的类型
    /// </summary>
    public enum CollegeTagType : int
    {
        /// <summary>
        /// 办学层次
        /// </summary>
        [EnumAlias("办学层次")]
        Level = 1,
        /// <summary>
        /// 教育性质
        /// </summary>
        [EnumAlias("教育性质")]
        Nature = 2,
        /// <summary>
        /// 学科范围
        /// </summary>
        [EnumAlias("学科范围")]
        Classify = 3,
        /// <summary>
        /// 主管部门
        /// </summary>
        [EnumAlias("主管部门")]
        Belong = 4,
        /// <summary>
        /// 校园照片
        /// </summary>
        [EnumAlias("校园照片")]
        CollegePhoto = 5
    }

    /// <summary>
    /// 词类型
    /// </summary>
    public enum UWordType : int
    {
        /// <summary>
        /// 大学名称
        /// </summary>
        [EnumAlias("大学名称")]
        CollegeName = 1,
        /// <summary>
        /// 代词（一般用作疑问代词）
        /// 如：同济大学/能不能上
        /// </summary>
        [EnumAlias("疑问代词")]
        DaiCi = 99,
        /// <summary>
        /// 其他
        /// </summary>
        [EnumAlias("其他")]
        Other = 0,
        /// <summary>
        /// 未找到
        /// </summary>
        [EnumAlias("全部")]
        None = -1
    }

    /// <summary>
    /// 词规则对应的应用类型
    /// </summary>
    public enum UWordRuleType : int
    {
        /// <summary>
        /// 院校简介
        /// </summary>
        [EnumAlias("院校简介")]
        CollegeIntro = 1,
        [EnumAlias("全部")]
        None = -1
    }


    /// <summary>
    /// 文章类型
    /// </summary>
    public enum ArticleType
    {
        /// <summary>
        /// 高招动态
        /// </summary>
        [EnumAlias("高招动态")]
        GKDT = 1,
        /// <summary>
        /// 数据看板
        /// </summary>
        [EnumAlias("数据看板")]
        SJKB = 2,
        /// <summary>
        /// 院校资讯
        /// </summary>
        [EnumAlias("院校资讯")]
        YXZX = 3,
        /// <summary>
        /// 专业资讯
        /// </summary>
        [EnumAlias("专业资讯")]
        ZYZX = 4,
        /// <summary>
        /// 高考课堂
        /// </summary>
        [EnumAlias("高考课堂")]
        GKKT = 5,
        /// <summary>
        /// 高考政策
        /// </summary>
        [EnumAlias("高考政策")]
        GKZC = 6,
        /// <summary>
        /// 留学动态
        /// </summary>
        [EnumAlias("留学动态")]
        LXDT = 7,
        None = -1
    }

    /// <summary>
    /// 文章审核状态
    /// </summary>
    public enum ArticleAuditType
    {
        /// <summary>
        /// 待审核
        /// </summary>
        [EnumAlias("待审核")]
        CheckPending = 1,
        /// <summary>
        /// 审核退回
        /// </summary>
        [EnumAlias("审核退回")]
        CheckReturn = 2,
        /// <summary>
        /// 已审核
        /// </summary>
        [EnumAlias("已审核")]
        Checked = 3
    }

    /// <summary>
    /// 文章展示类型
    /// </summary>
    public enum ArticleShowType
    {
        /// <summary>
        /// 首页显示（对应版块）
        /// </summary>
        ShowHomePage,
        /// <summary>
        /// 首页显示焦点（高考观察）
        /// </summary>
        ShowHomePageFocus,
        /// <summary>
        /// 高考页显示（对应版块）
        /// </summary>
        ShowNewsPage,
        /// <summary>
        /// 高考页焦点显示（高考观察）
        /// </summary>
        ShowNewsPageFocus,
        /// <summary>
        /// 【20160126不使用了】高考页显示Banner
        /// </summary>
        ShowNewsPageBanner,

        /// <summary>
        /// 后台用
        /// </summary>
        None
    }

}

using UPrime.Domain.Entities;

namespace YouService.Data.Domain.Colleges
{
    /// <summary>
    /// 代表“院校标签信息”
    /// 常用于图片的标签
    /// </summary>
    public class CollegeTag: Entity
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 标签类型标识
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 父级Id,如校园照片有2级
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否当前使用
        /// </summary>
        public bool IsUsed { get; set; }

        #region Custom Properties
        /// <summary>
        /// 标签类型
        /// </summary>
        public CollegeTagType Type
        {
            get
            {
                return (CollegeTagType)TypeId;
            }
            set
            {
                TypeId = (int)value;
            }
        }
        #endregion
    }
}

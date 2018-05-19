using UPrime.Domain.Entities.Auditing;

namespace YouService.Data.Domain.WordBank
{
    /// <summary>
    /// 代表“词库里的一个词”
    /// </summary>
    public class UWord : FullAuditedEntity
    {
        public UWord()
        {
            Name = "";
            Value = "";
            Type = UWordType.Other;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        public string Value { get; set; }

        /// <summary>
        /// 类型Id
        /// </summary>
        public int TypeId { get; set; }

        #region Custom Properties
        /// <summary>
        /// 类型
        /// </summary>
        public UWordType Type
        {
            get { return (UWordType)TypeId; }
            set { TypeId = (int)value; }
        }
        #endregion
    }
}

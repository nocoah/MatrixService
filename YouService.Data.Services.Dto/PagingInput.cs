using UPrime.Services.Dto;

namespace YouService.Data.Services
{
    /// <summary>
    /// 分页参数输入可以继承此类
    /// </summary>
    public abstract class PagingInput : IInputDto
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 多少条
        /// </summary>
        public int PageSize { get; set; }
    }
}

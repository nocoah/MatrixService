using UPrime.AutoMapper;
using YouService.Data.Domain.Colleges;

namespace YouService.Data.Services.Colleges
{
    /// <summary>
    /// 代表“一所大学的详细信息”，一般用于内页全内容展示
    /// </summary>
    [AutoMapFrom(typeof(College))]
    public class CollegeDto : CollegeBriefDto
    {
    }
}

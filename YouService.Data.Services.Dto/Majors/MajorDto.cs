using UPrime.AutoMapper;
using YouService.Data.Domain.Majors;

namespace YouService.Data.Services.Majors
{
    /// <summary>
    /// 专业库Dto
    /// </summary>
    [AutoMapFrom(typeof(Major))]
    public class MajorDto
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouService.Data.Domain.Majors.Repositories;

namespace YouService.Data.Services.Majors.Impl
{
   public partial class MajorService : ServiceBase, IMajorService
    {
        #region Fileds & Ctor
        private readonly IMajorCache _majorCache;
        private readonly IMajorRepository _majorRepository;
        public MajorService(IMajorCache majorCache, IMajorRepository majorRepository)
        {
            this._majorCache = majorCache;
            this._majorRepository = majorRepository;
        }
        #endregion

        /// <summary>
        /// 根据MajorCode查询专业信息，因为现在都是用MajorCode匹配,所以Id只是用来做修改什么的操作了
        /// </summary>
        /// <param name="majorCode"></param>
        /// <returns></returns>
        public MajorDto GetMajorByMajorCode(string majorCode)
        {
            return null;  
        }


        ///// <summary>
        ///// 按男女比例降序查询专业
        ///// </summary>
        ///// <param name="gender"></param>
        ///// <param name="level">2:中类，3:小类</param>
        ///// <returns></returns>
        //protected List<MajorDto> QueryMajorMaleAndFemaleSort(Gender gender, int level)
        //{
        //    //获取全部中类信息
        //    List<MajorDto> dataList = GetAllMajor(level).ToList();
        //    switch (gender)
        //    {
        //        case Gender.Male:
        //            dataList = dataList.OrderByDescending(x => x.Male).ToList();
        //            break;
        //        case Gender.Female:
        //            dataList = dataList.OrderByDescending(x => x.Female).ToList();
        //            break;
        //        default:
        //            break;
        //    }
        //    return dataList;
        //}
    }
}

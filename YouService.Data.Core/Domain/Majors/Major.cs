using System;
using UPrime.Domain.Entities;

namespace YouService.Data.Domain.Majors
{
    /// <summary>
    /// 优志愿专业库
    /// </summary>
    public class Major : Entity
    {
        #region Constructor 

        public Major()
        {
            Name = "";
            Code = "";
            Introduction = "";
            TypeId = 0;
            Level = 0;
            ParentId = 0;
            ChildrenCount = 0;
            CreateDate = DateTime.Now;
            HollandTest = "";
            Jobs = "";
            Year = "";
            Summary = "";
            Objective = "";
            Requirement = "";
            LoreAndAbility = "";
            MajorSubject = "";
            MajorCourse = "";
            TeachingPractice = "";
            Salary = "";
            JobRecommend = "";
            Hits = 0;
            CountOfCollected = 0;
            CountOfClass = 0;
            Year0 = "";
            Year1 = "";
            Year2 = "";
            Year3 = "";
            Year4 = "";
            Year5 = "";
            Year6 = "";
            Year7 = "";
            Year8 = "";
            Year9 = "";
            Year10 = "";
            Industry = "";
            Job = "";
            City = "";
            Male = 0;
            Female = 0;
            GraduateRate = 0;
            InternationalRate = 0;
            IndustryDistribution = "";
            LearnYear = 0;
            SimilarMajors = "";
            SubjectRequirement = "";
            FamousScholar = "";
            EmploymentProspects = "";
            OccupationalPay = "";
        }
        #endregion

        #region Property
        /// <summary>
        /// 专业名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
		/// 专业代码
		/// </summary>
		public string Code { get; set; }
        /// <summary>
		/// 专业介绍
		/// </summary>
		public string Introduction { get; set; }
        /// <summary>
		/// 专业类型Id
		/// </summary>
		public int TypeId { get; set; }
        /// <summary>
        ///等级（如：1级 2级）
		/// </summary>
		public int Level { get; set; }
        /// <summary>
		/// 父类Id
		/// </summary>
		public int ParentId { get; set; }
        /// <summary>
		/// 子数量
		/// </summary>
		public int ChildrenCount { get; set; }
        /// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateDate { get; set; }
        /// <summary>
        /// 霍兰德测试结果（字母）
		/// </summary>
		public string HollandTest { get; set; }
        /// <summary>
		/// 对应职业
		/// </summary>
		public string Jobs { get; set; }
        /// <summary>
		/// 学制
		/// </summary>
		public string Year { get; set; }
        /// <summary>
		/// 专业简介
		/// </summary>
		public string Summary { get; set; }
        /// <summary>
		/// 获得学位
		/// </summary>
		public string Degree { get; set; }
        /// <summary>
		/// 培养目标
		/// </summary>
		public string Objective { get; set; }
        /// <summary>
		/// 培养要求
		/// </summary>
		public string Requirement { get; set; }
        /// <summary>
		/// 知识与能力
		/// </summary>
		public string LoreAndAbility { get; set; }
        /// <summary>
		/// 主干学科
		/// </summary>
		public string MajorSubject { get; set; }
        /// <summary>
		/// 主要课程
		/// </summary>
		public string MajorCourse { get; set; }
        /// <summary>
		/// 教学实践
		/// </summary>
		public string TeachingPractice { get; set; }
        /// <summary>
		/// 薪资待遇
		/// </summary>
		public string Salary { get; set; }
        /// <summary>
		/// 职业推荐
		/// </summary>
		public string JobRecommend { get; set; }
        /// <summary>
		/// 点击量
		/// </summary>
		public int Hits { get; set; }
        /// <summary>
		/// 收藏次数
		/// </summary>
		public int CountOfCollected { get; set; }
        /// <summary>
		/// 课程数量
		/// </summary>
		public int CountOfClass { get; set; }
        /// <summary>
		/// 毕业第1年平均工资
		/// </summary>
		public string Year0 { get; set; }
        /// <summary>
        /// 毕业第2年平均工资
		/// </summary>
		public string Year1 { get; set; }
        /// <summary>
        /// 毕业第3年平均工资
		/// </summary>
		public string Year2 { get; set; }
        /// <summary>
        /// 毕业第4年平均工资
		/// </summary>
		public string Year3 { get; set; }
        /// <summary>
        /// 毕业第5年平均工资
		/// </summary>
		public string Year4 { get; set; }
        /// <summary>
        /// 毕业第6年平均工资
		/// </summary>
		public string Year5 { get; set; }
        /// <summary>
        /// 毕业第7年平均工资
		/// </summary>
		public string Year6 { get; set; }
        /// <summary>
        /// 毕业第8年平均工资
		/// </summary>
		public string Year7 { get; set; }
        /// <summary>
        /// 毕业第9年平均工资
		/// </summary>
		public string Year8 { get; set; }
        /// <summary>
        /// 毕业第10年平均工资
		/// </summary>
		public string Year9 { get; set; }
        /// <summary>
        /// 毕业第11年平均工资
		/// </summary>
		public string Year10 { get; set; }
        /// <summary>
		/// 所属行业
		/// </summary>
		public string Industry { get; set; }
        /// <summary>
		/// 所在职位
		/// </summary>
		public string Job { get; set; }
        /// <summary>
		/// 分布城市
		/// </summary>
		public string City { get; set; }
        /// <summary>
		/// 男生占比
		/// </summary>
		public int Male { get; set; }
        /// <summary>
		/// 女生占比
		/// </summary>
		public int Female { get; set; }
        /// <summary>
		/// 就业率
		/// </summary>
		public int EmploymentRate { get; set; }
        /// <summary>
		/// 毕业率
		/// </summary>
		public int GraduateRate { get; set; }
        /// <summary>
        /// InternationalRate（不知道是什么概率，前台暂时没用到）
		/// </summary>
		public int InternationalRate { get; set; }
        /// <summary>
		/// 行业分布
		/// </summary>
		public string IndustryDistribution { get; set; }

        /// <summary>
        /// 学制
        /// </summary>
        public int LearnYear { get; set; }

        /// <summary>
        /// 最后编辑时间
        /// </summary>
        public DateTime LastModificationTime { get; set; }

        /// <summary>
        /// 相近专业
        /// </summary>
        public string SimilarMajors { get; set; }
        /// <summary>
        /// 学科要求
        /// </summary>
        public string SubjectRequirement { get; set; }
        /// <summary>
        /// 名人学者
        /// </summary>
        public string FamousScholar { get; set; }
        /// <summary>
        /// 就业前景
        /// </summary>
        public string EmploymentProspects { get; set; }
        /// <summary>
        /// 职业薪酬
        /// </summary>
        public string OccupationalPay { get; set; }

        #endregion
    }
}

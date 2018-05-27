using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 客户类型
    /// </summary>
    public enum CustomerType
    {
        /// <summary>
        /// 默认客户
        /// </summary>
        Default = 0
    }
    public enum MaritalStatus
    {
        Default = 0
    }
    /// <summary>
    /// 客户信息--实体类
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomerType CustomerType { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex { get; set; }
        /// <summary>
        /// 婚姻状况
        public MaritalStatus MaritalStatus { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public List<Mobile> Mobiles { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        public string QQNumber { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 户口类别(EnumId)
        /// </summary>
        public string AccountEnum { get; set; }
        /// <summary>
        /// 学历类别(EnumId)
        /// </summary>
        public string EducationEnum { get; set; }
        /// <summary>
        /// 所属省份Id
        /// </summary>
        public string ProvinceId { get; set; }
        /// <summary>
        /// 所属城市Id
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 所属地区Id
        /// </summary>
        public string AreaId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 居住状况
        /// </summary>
        public string LiveEnum { get; set; }
        /// <summary>
        /// 孩子个数
        /// </summary>
        public int? ChildNumber { get; set; }
        /// <summary>
        /// 最后填写页
        /// </summary>
        public string FromPage { get; set; }
        /// <summary>
        /// 市场来源
        /// </summary>
        public string FromMarket { get; set; }
        /// <summary>
        /// 信息来源
        /// </summary>
        public string InfoSource { get; set; }
        /// <summary>
        /// 还款能力
        /// </summary>
        public int? RepayCapacity { get; set; }
        /// <summary>
        /// 家庭开销
        /// </summary>
        public int? FamilySpending { get; set; }
        /// <summary>
        /// 贷款历史
        /// </summary>
        public string LoanHistory { get; set; }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime? AddTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 房产数量
        /// </summary>
        public string HouseCount { get; set; }
        /// <summary>
        /// 车辆数量
        /// </summary>
        public string CarCount { get; set; }
    }
}

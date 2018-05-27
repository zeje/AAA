using System;
using System.Collections.Generic;
using System.Text;

namespace AAA
{
    public class Mobile : EntityBase
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// 手机所属省份Id
        /// </summary>
        public Guid ProvinceId { get; set; }
        /// <summary>
        /// 手机所属城市Id
        /// </summary>
        public Guid CityId { get; set; }
    }
}

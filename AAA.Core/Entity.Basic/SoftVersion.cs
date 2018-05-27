using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace AAA
{
    /// <summary>
    /// 软件版本
    /// </summary>
    public partial class SoftVersion : EntityBase
    {
        /// <summary>
        /// 软件名称
        /// </summary>
        [Required]
        [MaxLength(32)]
        public string SoftName { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [Required]
        [MaxLength(32)]
        public string Version { get; set; }
        /// <summary>
        /// 更新文件下载地址
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Url { get; set; }
        /// <summary>
        /// 变更日志
        /// </summary>
        public string Changelog { get; set; }
        /// <summary>
        /// 是否强制
        /// </summary>
        public bool Mandatory { get; set; }
    }
}

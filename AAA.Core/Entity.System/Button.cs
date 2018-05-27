using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : Permission
    {
        public Button()
        {
        }
        /// <summary>
        /// Api地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string ButtonUrl { get; set; }
        /// <summary>
        /// 样式名称
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string ButtonIconClass { get; set; }
    }
}

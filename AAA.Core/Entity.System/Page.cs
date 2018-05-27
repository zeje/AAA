using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 页面
    /// </summary>
    public class Page : Permission
    {
        public Page()
        {
            PageIsMenu = true;
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string PageIconClass { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string PageUrl { get; set; }
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool PageIsMenu { get; set; }

        public new Page Parent { get; set; }
        /// <summary>
        /// 子页面
        /// </summary>
        public new ICollection<Page> Children { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    /// <summary>
    /// 表格
    /// </summary>
    public class Grid : Permission
    {
        public Grid()
        {
        }
        /// <summary>
        /// Load地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string GridUrl { get; set; }
        /// <summary>
        /// 页面
        /// </summary>
        public new Page Parent { get; set; }
        /// <summary>
        /// 表格字段集合
        /// </summary>
        public new ICollection<GridField> Children { get; set; }
    }
}

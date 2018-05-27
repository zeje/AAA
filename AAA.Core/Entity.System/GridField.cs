using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 表格字段信息
    /// </summary>
    public class GridField : Permission
    {
        public GridField()
        {
        }

        public string GridFieldCode { get; set; }

        public string GridFieldName { get; set; }

        /// <summary>
        /// 表格
        /// </summary>
        public new Grid Parent { get; set; }
    }
}

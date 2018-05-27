using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class EntityBase : Entity<long>, IHasCreationTime, IHasModificationTime
    {
        /// <summary>
        /// 
        /// </summary>
        public EntityBase()
        {
            CreationTime = Clock.Now;
            LastModificationTime = Clock.Now;
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public virtual long CreatorUserId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual long LastModifierUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }
    }
}

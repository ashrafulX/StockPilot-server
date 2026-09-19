using System;
using System.Collections.Generic;
using System.Text;

namespace Stockpilot.Domain.Entities
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdateBy { get; set; }
    }
}

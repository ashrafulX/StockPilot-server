using Stockpilot.Domain.Entities;
using System;
using Stockpilot.Domain.Enum;

namespace Stockpilot.Domain.Entities
{
    public class StockMovement : BaseEntity
    {
        public StockMovementType MovementType { get; set; }
        public Guid ProductId { get; set; }
        public Guid WareHouseId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
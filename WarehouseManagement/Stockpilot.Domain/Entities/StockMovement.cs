using Stockpilot.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
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
        public Warehouse Warehouse { get; set; } // Capitalize 'Warehouse' to follow the naming convention for classes
    }

    public class Warehouse : BaseEntity // Assuming Warehouse class is in the same file for simplicity
    {
        public required string Name { get; set; }
        public string? Location { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
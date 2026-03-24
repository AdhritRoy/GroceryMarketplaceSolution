// Order.cs
// Created on 2026-03-24 17:17:51 UTC

using System;

namespace GroceryMarketplaceSolution.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
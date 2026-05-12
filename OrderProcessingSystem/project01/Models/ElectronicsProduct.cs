using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Models
{
    public class ElectronicsProduct : Product
    {
        public ElectronicsProduct(string id, string name, decimal price, int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.10m;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Models
{
    public class ElectronicsProduct : Product
    {
        public ElectronicsProduct(string id,
                                  string name,
                                  double price,
                                  int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        // Override Method
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTags.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate):base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceList()
        {
            return $"{Name}(used) $ {Price} (Manufacture date:{ManufactureDate})" ;
        }
    }
}

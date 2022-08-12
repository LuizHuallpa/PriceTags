using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTags.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee):base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceList()
        {
            return base.PriceList() + $"(Customs Fee: {CustomsFee})";
        }
    }
}

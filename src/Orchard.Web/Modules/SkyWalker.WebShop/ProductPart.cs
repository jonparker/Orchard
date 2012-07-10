using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.ContentManagement;

namespace SkyWalker.WebShop
{
    public class ProductPart : ContentPart<ProductRecord>
    {
        public decimal Price
        {
            get { return Record.Price; }
        }
        public string Sku
        {
            get { return Record.Sku; }
        }
    }

    public class ProductRecord
    {
        public virtual decimal Price { get; set; }
        public virtual string Sku { get; set; }

    }
}

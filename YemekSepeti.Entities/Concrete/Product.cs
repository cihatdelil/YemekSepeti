using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Abstract;

namespace YemekSepeti.Entities.Concrete
{
    public class Product:IEntity
    {
        //public int ProductId { get; set; }
        //public string ProductName { get; set; }
        //public int CategoryId { get; set; }
        //public decimal UnitPrice { get; set; }
        //public string QuantityPerUnit { get; set; }
        //public Int16 UnitsInStock { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
    }
}

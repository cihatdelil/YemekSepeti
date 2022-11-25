using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Abstract;

namespace YemekSepeti.Entities.Concrete
{
    public class Common:IEntity
    {
        public int CommonId { get; set; }
        public int ProductId { get; set; }
        public int RestorantId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}

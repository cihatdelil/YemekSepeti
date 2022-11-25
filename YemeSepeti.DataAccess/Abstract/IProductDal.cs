using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Concrete;

namespace YemeSepeti.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}

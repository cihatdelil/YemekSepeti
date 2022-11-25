using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Concrete;
using YemeSepeti.DataAccess.Abstract;

namespace YemeSepeti.DataAccess.Concrete.EntityFramework
{
    public class EfCommonDal:EfEntityRepositoryBase<Common,Context>,ICommonDal
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Concrete;

namespace YemekSepeti.Business.Abstract
{
    public interface ICommonService
    {
        List<Common> GetAll();
        Category GetById(int id);
    }
}

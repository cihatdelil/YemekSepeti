using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Business.Abstract;
using YemekSepeti.Entities.Concrete;
using YemeSepeti.DataAccess.Abstract;

namespace YemekSepeti.Business.Concrete
{
    public class CommonManager : ICommonService
    {
        private ICommonDal _commonDal;
        public CommonManager(ICommonDal commonDal)
        {
            _commonDal = commonDal;
        }
        public List<Common> GetAll()
        {
           return _commonDal.GetAll();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using project.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BusinessObject
{
    class NhanVienBO
    {
        public  int GetIDNV()
        {
            Providers provi = new Providers();
            return provi.GetIDNV();
        }
        public  int test(params object[]Par)
        {
            Providers provi = new Providers();
            return provi.test(Par);
        }
    }
}

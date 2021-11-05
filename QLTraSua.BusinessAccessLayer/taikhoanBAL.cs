using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AppQLTraSua.dataAcessLayer;

namespace QLTraSua.BusinessAccessLayer
{
    public class taikhoanBAL
    {
        private readonly taikhoanDAL _taikhoanDAL;
        public taikhoanBAL()
        {
            _taikhoanDAL = new taikhoanDAL();
        }

        public bool checklogin(String userName ,String password , out string error)
        {
            return _taikhoanDAL.CheckLogin(userName, password, out error);
        }

    }
}

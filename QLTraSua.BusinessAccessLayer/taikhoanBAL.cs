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
            return _taikhoanDAL.CheckLogin(userName, MD5Hash(password), out error);
        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQLTraSua.dataAcessLayer
{
    public class taikhoanDAL
    {
        public bool CheckLogin(String userName, String password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppQLTraSuaModel())
                {
                    return dbcontext.TaiKhoans.Any(tk => tk.UserName == userName && tk.Password == password);
                }
            }
            catch (Exception ex)
            {

                error = ex.Message;
                return false;
            }
        }
    }
}

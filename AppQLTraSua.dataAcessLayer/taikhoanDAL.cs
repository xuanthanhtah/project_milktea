using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQLTraSua.dataAcessLayer.models;
namespace AppQLTraSua.dataAcessLayer
{
    public class taikhoanDAL
    {
        public bool CheckLogin(String userName, String password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new dbqltrasuauwu())
                {
                    return dbcontext.NHANVIENs.Any(tk => tk.TaiKhoan == userName && tk.MatKhau == password);
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

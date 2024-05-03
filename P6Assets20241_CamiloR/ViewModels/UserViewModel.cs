using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P6Assets20241_CamiloR.Models;

namespace P6Assets20241_CamiloR.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public UserPost MyUserToPost { get; set; }

        public UserRole MyUserRole { get; set; }

        public UserViewModel()
        {
                MyUserToPost = new UserPost(); 
                MyUserRole = new UserRole();
        }

        //Carga de roles de usuarios 
        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {

            try
            {
                List<UserRole>? roles = new List<UserRole>();

                roles = await MyUserRole.GetAllUserRolesAsync();

                if (roles == null)
                {
                    return null;
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}

using DAL.User;
using DTO.User;
using Interfaces.BL;
using Interfaces.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.User
{
    public class UserBL: IUserBL
    {
        private readonly IUserDAL userDAL;
        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        //GetAllUsers
        public async Task<List<UserDTO>> GetAllUsers()
        {
            return await userDAL.GetAllUsers();
        }

        //AddUser
        public async Task<UserDTO> AddUser(UserDTO user)
        {
            return await userDAL.AddUser(user);
        }

        //DeleteUser
        public async Task DeleteUser(UserDTO user)
        {
            await userDAL.DeleteUser(user);
        }
    }
}

using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BL
{
    public interface IUserBL
    {
        //GetAllUsers
        Task<List<UserDTO>> GetAllUsers();


        //AddUser
        Task<UserDTO> AddUser(UserDTO user);

        //DeleteUser
        Task DeleteUser(UserDTO user);
    }
}


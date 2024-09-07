using DB.Database;
using DTO.User;
using Interfaces.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.User
{
    public class UserDAL: IUserDAL
    {
        private readonly DbLibrary Db;
        public UserDAL(DbLibrary db)
        {
            this.Db = db;
        }
        //GetAllUsers
        public async Task<List<UserDTO>> GetAllUsers() {
            return await Db.User.ToListAsync();
        }

        //AddUser
        public async Task<UserDTO> AddUser(UserDTO user) { 
            Db.User.Add(user);
            await Db.SaveChangesAsync();
            return user;
        }

        //DeleteUser
        public async Task DeleteUser(UserDTO user) { 
            var entity=await Db.User.FindAsync(user.id);
            if (entity != null) {
                Db.User.Remove(user);
                await Db.SaveChangesAsync();
            }
        }
    }
}

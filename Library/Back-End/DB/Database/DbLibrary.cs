using DTO.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Database
{
    public class DbLibrary:DbContext
    {
        public DbLibrary(DbContextOptions<DbLibrary> options) : base(options) { }
        public DbSet<UserDTO> User { get; set; }
    }
}

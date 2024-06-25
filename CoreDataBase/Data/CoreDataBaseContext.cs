using CoreDataBase.Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDataBase.Data
{
    public class CoreDataBaseContext : DbContext
    {
        DbSet<UserFileDataEntity> UserFileData {  get; set; }


        public CoreDataBaseContext(DbContextOptions<CoreDataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

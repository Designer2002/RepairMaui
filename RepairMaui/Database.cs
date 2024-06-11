using Android.Content;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Content.ClipData;

namespace RepairMaui
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = $"Filename={GetAndroidPath("repair.db")}";
            optionsBuilder.UseSqlite(connection);

        }
        public DbSet<Machine> Machines { get; set; }

        public static string GetAndroidPath(string nameDb)
        {
            var path = string.Empty;
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, nameDb);
            return path;
        }


    }
}

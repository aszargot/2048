using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.DAL
{
    public class Context : DbContext
    {
        public Context() : base ("2048ConnStr")
        {
        }

        public DbSet<_2048.Model.Score> Scores { get; set; }

    }
}

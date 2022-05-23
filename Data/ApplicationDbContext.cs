using Microsoft.EntityFrameworkCore;
using Najžer_RST_MAG_RNSUV_Projektna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Najžer_RST_MAG_RNSUV_Projektna.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CocktailModel> Cocktail { get; set; }
        public DbSet<OrderModel> Order { get; set; }
    }
}

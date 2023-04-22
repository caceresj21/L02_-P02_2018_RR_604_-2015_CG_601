using Microsoft.EntityFrameworkCore;
using L02_P02__2018_RR_604__2015_CG_601.Models;



namespace L02_P02__2018_RR_604__2015_CG_601.Models
{
    public class restauranteDBcontext : DbContext

    {
        public restauranteDBcontext ( DbContextOptions <restauranteDBcontext> options) : base (options)

        { 
        
        }

        public DbSet<pedidos> pedidos { get; set;}

        public DbSet<platos> platos { get; set;}        
    }
}

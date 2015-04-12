using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace KlanlarBot.BusinessObjects.EntityModel
{
    public partial class SamBotContext : DbContext
    {
        public SamBotContext()
            : base("name=SamBotContext")
        {
        }

        public DbSet<Village> Villages { get; set; }
        public DbSet<VillageAtack> VillageAtacks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

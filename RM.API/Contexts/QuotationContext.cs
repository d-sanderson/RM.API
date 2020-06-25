using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RM.API.Entities;
using System.IO;

namespace RM.API.Contexts
{
    public class QuotationContext : DbContext
    {

        public DbSet<Quotation> Quotes { get; set; }

        public QuotationContext(DbContextOptions<QuotationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            //Quotation[] quotes = new Quotation[97];

            var json = JsonConvert.DeserializeObject<Quotation[]>(
                    File.ReadAllText(@"C:\Users\David\source\repos\RM\RM.API\Data\quotes.json"));

            modelBuilder.Entity<Quotation>()
                 .HasData(json);


            base.OnModelCreating(modelBuilder);
        }
    }
}

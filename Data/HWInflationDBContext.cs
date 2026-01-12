using HWInflation.Models;
using Microsoft.EntityFrameworkCore;

namespace HWInflation.Data
{
    public class HWInflationDBContext : DbContext
    {
        public HWInflationDBContext(DbContextOptions<HWInflationDBContext> options) : base(options) { }
    
        public  DbSet<StoreScrapper> Scrapers { get; set; }
    }
}
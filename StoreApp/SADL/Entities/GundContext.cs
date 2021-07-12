using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace SADL.Entities
{
    public partial class GundContext : DbContext
    {

        public GundContext()
        {
        }
        public GundContext(DbContextOptions<GundContext> options)
            : base(options) { }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}
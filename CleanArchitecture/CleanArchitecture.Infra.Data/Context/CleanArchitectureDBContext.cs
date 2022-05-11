using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Context
{
    public class CleanArchitectureDBContext : DbContext
    {
        internal IEnumerable<EcheanceContractLocation> echanceContratLocation;

        public  CleanArchitectureDBContext(DbContextOptions options) : base(options)
            {

            }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ContractLocation> ContractLocations { get; set; }
        public DbSet<ContractLocationHistory> ContractLocationHistories { get; set; }
        public DbSet<EcheanceContractLocation> EchanceContracts { get; set; }
        public DbSet<EcheanceContractLocationHistory> echanceContratLocationHistories { get; set; }
       public DbSet<Tenant> tenants { get; set; }

        public DbSet<RenewalOption> renewalOptions { get; set; }
        public DbSet<OutputContractLocation> outputContractLocations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TN3253620W2;Database=CleanArchitectureDBConnection;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EcheanceContractLocation>()
             .HasKey(c => c.EcheanceContractLocationid);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContractLocation>()
                .HasKey(c => c.ContactLocationId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContractLocationHistory>()
               .HasKey(c => c.ContractLocationHistoryId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
              .HasKey(c => c.AccountId);

            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<EcheanceContractLocationHistory>()
            .HasKey(c => c.EcheanceContractLocationHistoryid);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OutputContractLocation>()
            .HasKey(c => c.OutputContractLocationId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RenewalOption>()
            .HasKey(c => c.RenewalOptionId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tenant>()
           .HasKey(c => c.TenantId);

            base.OnModelCreating(modelBuilder);

           

        }


    }
}

using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Context
{
    public class CleanArchitectureDBContext : DbContext
    {
        public  CleanArchitectureDBContext(DbContextOptions options) : base(options)
            {

            }
        public DbSet<Account> Accounts { get; set; }
       // public DbSet<ContractLocation> ContractLocations { get; set; }
       // public DbSet<EchanceContractLocation> EchanceContracts { get; set; }
        //public DbSet<EchanceContratLocationHistory> echanceContratLocationHistories { get; set;}
        //public DbSet<Tenant>tenants { get; set; }
       
        

    }
}

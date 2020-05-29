using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoRunProj.Models;

namespace GoRunProj.Data
{
    public class GoRunProjContext : DbContext
    {
        public GoRunProjContext(DbContextOptions<GoRunProjContext> options)
            : base(options)
        {

        }
        public DbSet<RunningSpot> Runningspot { get; set; }
        public DbSet<Map> Map { get; set; }
        public DbSet<LocationOption> RunningSpots { get; set; }
       public DbSet<NewLocationDDL> RunningSpot { get; set; }
    }
}

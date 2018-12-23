using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Schedule.Data.Entities;

namespace Schedule.Api.DataContexts
{
    public class ScheduleApiContext : DbContext
    {
        public ScheduleApiContext (DbContextOptions<ScheduleApiContext> options)
            : base(options)
        {
        }

        public DbSet<Schedule.Data.Entities.User> User { get; set; }
    }
}

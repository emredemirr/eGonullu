using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;
using Microsoft.EntityFrameworkCore;

namespace eGonullu.Data
{
	public class EGonulluDbContext : DbContext
	{
		public EGonulluDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Participant> Participants { get; set; }
		public DbSet<Activity> Activities { get; set; }
	}
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutoringApp.API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Models.Value> Values { get; set; }
		public DbSet<Models.User> Users { get; set; }
		public DbSet<Models.Photo> Photos { get; set; }

	}
}

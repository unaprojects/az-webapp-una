﻿using Microsoft.EntityFrameworkCore;

namespace az_webapp_una.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ 

		}

		public DbSet<Person> Persons { get; set; }
	}
}

using System;
using Frace.CQRS.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Frace.CQRS.Infrastructure.Database.Contexts
{
	public class SchoolDBContext: DbContext
	{
		public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options) { }

		public virtual DbSet<Student> Students { get; set; }
	}
}


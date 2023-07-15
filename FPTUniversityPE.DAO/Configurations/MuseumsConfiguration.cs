using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPTUniversityPE.BusinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPTUniversityPE.BusinessObject.Configurations
{
    public class MuseumsConfiguration : IEntityTypeConfiguration<Museums>
	{
		public void Configure(EntityTypeBuilder<Museums> builder)
		{
			// default
			builder.HasKey(x => x.museum_id);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPTUniversityPE.BusinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPTUniversityPE.BusinessObject.Configurations
{
    public class ArtWorkConfiguration: IEntityTypeConfiguration<ArtWork>
	{
		public void Configure(EntityTypeBuilder<ArtWork> builder)
		{
			// default
			builder.HasKey(x => x.artWork_id);
            builder.HasOne(x => x.Museums).WithMany(x => x.ArtWorks).HasForeignKey(x => x.museum_id);
		}
	}
}
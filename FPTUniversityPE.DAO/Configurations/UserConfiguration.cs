using FPTUniversityPE.BusinessObject.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityPE.BusinessObject.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			// default
			builder.HasKey(x => x.user_Id);
			builder.HasOne(x => x.ArtWork).WithMany(x => x.Users).HasForeignKey(x => x.artWork_id);
			builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
		}
	}
}

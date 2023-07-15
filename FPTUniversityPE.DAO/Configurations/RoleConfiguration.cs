using FPTUniversityPE.BusinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPTUniversityPE.BusinessObject.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			// default
			builder.HasKey(x => x.role_id);
		}
	}
}

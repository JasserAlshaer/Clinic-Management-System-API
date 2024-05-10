﻿using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class LaborityTestEntityConfiguration : IEntityTypeConfiguration<LaborityTest>
    {
        public void Configure(EntityTypeBuilder<LaborityTest> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            
            
            
            
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            //entity configuration
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.Purpose).IsRequired(false);
        }
    }
}

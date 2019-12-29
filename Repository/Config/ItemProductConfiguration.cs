using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class ItemProductConfiguration : IEntityTypeConfiguration<itemProduct>
    {
        public void Configure(EntityTypeBuilder<itemProduct> builder)
        {
            throw new NotImplementedException();
        }
    }
}

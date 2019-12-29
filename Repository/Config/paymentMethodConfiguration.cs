using Domain.paymentObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    class paymentMethodConfiguration : IEntityTypeConfiguration<paymentMethod>
    {
        public void Configure(EntityTypeBuilder<paymentMethod> builder)
        {
            throw new NotImplementedException();
        }
    }
}

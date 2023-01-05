using Directory.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MAP.Configuraiton
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        //first name zorunlu max 15
        //telefon zorunlu max 15
        //last name max 15
        //company max 15
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(15);
            builder.Property(x => x.LastName).HasMaxLength(15);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Company).HasMaxLength(15);
        }
    }
}

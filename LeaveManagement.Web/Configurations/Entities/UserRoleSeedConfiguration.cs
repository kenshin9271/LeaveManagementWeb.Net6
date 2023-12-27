using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "aed19347-4156-4713-9271-3195703a9bbc",
                    UserId = "aed19347-4156-4713-9271-9115703a9bbc"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "aed19347-4156-4713-9272-3195703a9bbd",
                     UserId = "bc8f9cbb-3cae-43f6-a04e-0506c7a96120"
                 }
                );
        }
    }
}
using DotNet8Api.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.EntityConfiguration
{
    internal class EmployeeDepartmentHistoryConfiguration : IEntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public void Configure(EntityTypeBuilder<EmployeeDepartmentHistory> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.DepartmentId, x.ShiftId, x.StartDate });
        }
    }
}

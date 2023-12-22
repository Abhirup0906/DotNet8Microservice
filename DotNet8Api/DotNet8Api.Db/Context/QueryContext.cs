using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Context
{
    public class QueryContext: BaseContext
    {
        public QueryContext(DbContextOptions<QueryContext> options) : base(options) { }
    }
}

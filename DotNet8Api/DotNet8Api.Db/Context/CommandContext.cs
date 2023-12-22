using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db.Context
{
    public class CommandContext: BaseContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options) { }
    }
}

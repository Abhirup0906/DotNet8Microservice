using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Db
{
    public interface ICommand<T, Boolean>
    {
        void CreateTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        Task<bool> Execute(T request);
    }
}

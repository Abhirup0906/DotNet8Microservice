using DotNet8Api.Db;
using DotNet8Api.Model.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8Api.Orchestrator.AR
{
    public class UpdateEmployeeLoginAR : IRequestHandler<UpdateEmployeeLogin, bool>
    {
        private readonly ICommand<UpdateEmployeeLogin> _command;

        public UpdateEmployeeLoginAR(ICommand<UpdateEmployeeLogin> command) 
        {
            _command = command;
        }

        public async Task<bool> Handle(UpdateEmployeeLogin request, CancellationToken cancellationToken)
        {
            var result = await _command.Execute(request);
            return result;
        }
    }
}

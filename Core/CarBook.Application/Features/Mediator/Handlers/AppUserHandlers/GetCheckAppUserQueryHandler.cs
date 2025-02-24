using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Features.Mediator.Results.AppUserResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepository<AppUser> _AppUserrepository;
        private readonly IRepository<AppRole> _AppRolerepository;

        public GetCheckAppUserQueryHandler(IRepository<AppUser> appUserrepository, IRepository<AppRole> appRolerepository)
        {
            _AppUserrepository = appUserrepository;
            _AppRolerepository = appRolerepository;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _AppUserrepository.GetByFilterAsync(x => x.UserName == request.Username && x.Password == request.Password);
            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.Username = user.UserName;
                values.IsExist = true;
                values.Role = (await _AppRolerepository.GetByFilterAsync(x => x.AppRoleId == user.AppRoleId)).RoleName;
                values.Id = user.AppUserId;
            }
            return values;
        }
    }
}

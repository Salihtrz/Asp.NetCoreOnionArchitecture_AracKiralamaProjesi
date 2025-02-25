using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeauteByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
    {
        public GetCarFeauteByCarIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.ApplicationLayer.Features.Mediator.Results.OrderResults;

namespace TakeAway.ApplicationLayer.Features.Mediator.Queries.OrderQueries;

public class GetOrderQuery : IRequest<List<GetOrderQueryResult>>
{ 
}

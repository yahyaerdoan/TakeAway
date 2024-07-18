using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Queries.OrderDetailQueries;

public class GetOrderDetailByIdQuery(int id)
{
    public int Id { get; set; } = id;
}

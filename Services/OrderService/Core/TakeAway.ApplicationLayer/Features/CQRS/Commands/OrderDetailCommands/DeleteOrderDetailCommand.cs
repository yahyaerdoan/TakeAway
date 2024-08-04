﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;

public class DeleteOrderDetailCommand(int id)
{
    public int Id { get; set; } = id;
}

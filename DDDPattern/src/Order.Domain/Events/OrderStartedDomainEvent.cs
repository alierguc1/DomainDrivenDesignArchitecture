﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public AggregateModels.OrderModels.Order Order { get; set; }
    }
}

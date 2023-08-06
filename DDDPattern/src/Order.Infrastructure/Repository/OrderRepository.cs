using Order.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repository
{
    internal class OrderRepository : IOrderRepository
    {
        public async Task<int> SaveChangesAsync()
        {
            return await Task.FromResult(1);
        }
    }
}

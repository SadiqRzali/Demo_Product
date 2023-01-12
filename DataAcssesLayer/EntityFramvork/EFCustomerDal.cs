using DataAcssesLayer.Abstract;
using DataAcssesLayer.Concrete;
using DataAcssesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.EntityFramvork
{
    public class EFCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetListCustomer()
        {
            using (var c=new Context())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}

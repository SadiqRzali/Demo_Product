using BusinesLayer.Abstract;
using DataAcssesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class CustomerManager : IGenericService<Customer>
    {

        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Customer GetById(int id)
        {
          return  _customerDal.GetById(id);
        }

        public List<Customer> GetListCustomers()
        {
            return _customerDal.GetListCustomer();
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}

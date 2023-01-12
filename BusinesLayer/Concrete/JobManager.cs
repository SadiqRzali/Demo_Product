using BusinesLayer.Abstract;
using DataAcssesLayer.Abstract;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class JobManager : IGenericService<Job>
    {
        IJobDal _jobdal;

        public JobManager(IJobDal jobdal)
        {
            _jobdal = jobdal;
        }

        public Job GetById(int id)
        {
            return _jobdal.GetById(id);
        }

        public void TDelete(Job t)
        {
            _jobdal.Delete(t);
        }

        public List<Job> TGetList()
        {
            return _jobdal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobdal.Insert(t);

        }

        public void TUpdate(Job t)
        {
            _jobdal.Update(t);
        }
    }
}

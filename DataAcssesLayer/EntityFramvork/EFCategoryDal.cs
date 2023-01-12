using DataAcssesLayer.Abstract;
using DataAcssesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.EntityFramvork
{
     public class EFCategoryDal:GenericRepository<Category>,ICategoryDal
    {

    }
}

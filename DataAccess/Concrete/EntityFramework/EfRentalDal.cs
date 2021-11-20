using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public bool IsCarARental(int id)
        {
            using (CarRentalContext context= new CarRentalContext())
            {
                bool result = context.Rentals.Any(r=>r.CarId==id);
                return result;
            }
        }
    }
}

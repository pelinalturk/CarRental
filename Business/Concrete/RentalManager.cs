using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {//kiralanabilmesi için teslim edilmiş olmalı
            var getCar = _rentalDal.Get(r => r.CarId == rental.CarId);
            if (getCar.ReturnDate > DateTime.Now)
            {
                Console.WriteLine(DateTime.Now);
                return new ErrorResult();
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccesResult();
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccesResult();
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccesResult();
        }
    }
}

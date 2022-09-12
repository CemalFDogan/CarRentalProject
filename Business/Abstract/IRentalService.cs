using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetById(int rentalId);

        IDataResult<List<Rental>> GetAll();        
        IDataResult<List<Rental>> GetRentalByCarId(int carId);

        //IDataResult<List<RentDetailDto>> GetRentDetails();

        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}

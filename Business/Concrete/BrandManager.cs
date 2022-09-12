using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult($"{brand.BrandName} başarılı bir şekilde listeye eklenmiştir!");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult($"{brand.BrandName} başarılı bir şekilde listeden silinmiştir!");
        }

        public IDataResult<Brand> GetBrandById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id == brandId));
        }

        public IDataResult<List<Brand>> GetBrands()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(), true);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessDataResult<Brand>($"Id numarası {brand.Id} olan marka başarılı bir şekilde güncellenmiştir!");
        }
    }
}

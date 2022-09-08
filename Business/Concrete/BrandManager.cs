using Business.Abstract;
using DataAccess.Abstract;
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

        public void Add(Brand color)
        {
            _brandDal.Add(color);
        }

        public void Delete(Brand color)
        {
            _brandDal.Delete(color);
        }

        public void Update(Brand color)
        {
            _brandDal.Update(color);
        }


        public Brand GetBrandById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }
    }
}

using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult($"{color.ColorName} başarılı bir şekilde listeye eklenmiştir!");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult($"{color.ColorName} başarılı bir şekilde listeden silinmiştir!");
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co => co.Id == colorId));
        }

        public IDataResult<List<Color>> GetColors()
        {
            return new DataResult<List<Color>>(_colorDal.GetAll(), true);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessDataResult<Color>($"Id numarası {color.Id} olan renk başarılı bir şekilde güncellenmiştir!");
        }
    }
}

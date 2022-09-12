using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetById(int colorId);

        IDataResult<List<Color>> GetColors();        
        

        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}

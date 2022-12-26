using Business.Abstract;
using Business.Constants;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService

    {
        IColorDal _colorDal;
        
        public ColorManager(IColorDal colarDal )
        {
            _colorDal = colarDal;
           
        }

        public IResult Add(Color color)
        {

            _colorDal.Add(color);   
            return new SuccessResult(ColorMessages.ColorAdded); 
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(ColorMessages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Renkler Listelendi");
        }

        public IDataResult<Color> GetByColorId(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.Id == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(ColorMessages.ColorUpdated);
        }
    }
}

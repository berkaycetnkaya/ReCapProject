using Business.Abstract;
using Business.Constants;
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
        IGenericMessages<Color> _genericMessages;
        public ColorManager(IColorDal colarDal,IGenericMessages<Color> genericMessages )
        {
            _colorDal = colarDal;
            _genericMessages = genericMessages; 
        }

        public IResult Add(Color color)
        {

            _colorDal.Add(color);   
            return new SuccessResult(_genericMessages.Added(color)); 
        }

        public IResult Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Color> GetByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}

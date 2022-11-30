using Business.Abstract;
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
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByColorId(int id)
        {
            return _colorDal.Get(p => p.Id == id);
        }
    }
}

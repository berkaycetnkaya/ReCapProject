using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {

       
        

        public IDataResult<Color> GetByColorId(int id);
        public IDataResult<List<Color>> GetAll();
        IResult Add(Color color);

        IResult Update(Color color);

        IResult Delete(Color color);

    }
}

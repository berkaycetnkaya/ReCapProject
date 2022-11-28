using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        public void GetById();


        public void GetAll();

        public void Add();

        public void Update();

        public void Delete();
       

    }
}

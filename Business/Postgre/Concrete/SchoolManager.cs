using Business.Postgre.Abstract;
using Business.Postgre.ConstantMessage.Lesson;
using Business.Postgre.ConstantMessage.School;
using Core.Utilities.Results;
using DataAccess.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Concrete
{
    public class SchoolManager : ISchoolService
    {

        ISchoolDal _schoolDal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }
    
        public IResult Add(School school)
        {
            _schoolDal.Add(school);
            return new SuccessResult(SchoolMessages.SchoolAdded);
        }

        public IResult Delete(School school)
        {
            _schoolDal.Delete(school);
            return new SuccessResult(SchoolMessages.SchoolDeleted);
        }

        public IDataResult<List<SchoolDto>> GetAllDto()
        {
           return new SuccessDataResult<List<SchoolDto>>(_schoolDal.GetAllSchoolDto(),SchoolMessages.SchoolListed);    
        }

        public IDataResult<List<SchoolDto>> GetByID(int id)
        {
            return new SuccessDataResult<List<SchoolDto>>(_schoolDal.GetByIdSchoolDto(p=>p.Id==id),SchoolMessages.SchoolListedById);  
        }

        public IResult Update(School school)
        {

            _schoolDal.Update(school);
            return new SuccessResult(SchoolMessages.SchoolUpdated);
        }

       
    }
}

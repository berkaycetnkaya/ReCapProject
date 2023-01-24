using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PostgreSql.PostgreDtos
{
    public class SchoolLessonDto
    {

        public int id { get; set; }

        public int schoolId { get; set; }
        public string schoolName { get; set; }

       

        public DateTime BuildDate { get; set; }

        public TimeSpan StartDate { get; set; }

        public TimeSpan EndDate { get; set; }

        public int lessonId { get; set; }

        public string LessonName { get; set;}
    }
}

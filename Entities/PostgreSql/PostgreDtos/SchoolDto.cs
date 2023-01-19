using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PostgreSql.PostgreDtos
{
    public class SchoolDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BuildDate { get; set; }

        public TimeSpan StartDate { get; set; }

        public TimeSpan EndDate { get; set; }

        public int CityId { get; set; }
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string CityName { get; set; }
    }
}

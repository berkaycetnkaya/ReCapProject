using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PostgreSql.EntitiesPostgre
{
    public class SchoolLesson:IEntity
    {
        public int id { get; set; }

        public int schoolId { get; set; }

        public int lessonId { get; set; }
    }
}

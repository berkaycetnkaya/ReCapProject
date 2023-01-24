using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PostgreSql.EntitiesPostgre
{
    public class School:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }

        public DateTime buildDate { get; set; } 

        public TimeSpan startDate { get; set; }  

        public TimeSpan endDate { get; set;}

        public int cityId { get; set; } 
        
    }
}


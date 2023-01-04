using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HomePage
{
    public class NavContentId:IEntity
    {
        public int Id { get; set; }
        public int NavId { get; set; }   
    }
}

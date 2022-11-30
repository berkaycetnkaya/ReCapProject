using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    internal class BrandDetailDto:IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}

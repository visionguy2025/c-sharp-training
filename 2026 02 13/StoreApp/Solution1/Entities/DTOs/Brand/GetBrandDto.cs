using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.Brand
{
    public class GetBrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}

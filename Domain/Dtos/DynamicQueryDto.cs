using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;
using Core.Persistence.Dynamic;

namespace Domain.Dtos
{
    public class DynamicQueryDto : IDto
    {
        public Dynamic Dynamic { get; set; }
        public int Index { get; set; }
        public int Size { get; set; }
    }
}

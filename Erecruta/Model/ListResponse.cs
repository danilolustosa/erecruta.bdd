using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Model
{
    public class ListResponse : BaseResponse
    {
        public List<string> Erros { get; set; }
    }
}

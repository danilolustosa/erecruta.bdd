using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Model
{
    public class CandidatoResponse : BaseResponse
    {
        public Candidato Candidato { get; set; }
    }
}

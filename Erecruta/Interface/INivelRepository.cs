using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface INivelRepository
    {
        public List<Nivel> ListarByOportunidade(int OportunidadeId);
    }
}

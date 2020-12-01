using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface IOportunidadeNivelRepository
    {
        public void Incluir(OportunidadeNivel oportunidadeNivel);
        public void DeletarByOportunidade(int OportunidadeId);
    }
}

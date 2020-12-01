using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface ICandidatoRepository
    {
        public int Incluir(Candidato candidato);
        public void Alterar(Candidato candidato);
        public List<Candidato> Listar(int OportunidadeId);
        public Candidato Obter(int Id);

    }
}

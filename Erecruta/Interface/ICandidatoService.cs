using Erecruta.Domain;
using Erecruta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface ICandidatoService
    {
        public ListResponse Incluir(Candidato candidato);
        public ListResponse Alterar(Candidato candidato);
        public ListaCandidatoResponse Listar(int oportunidadeId);
        public CandidatoResponse Obter(int id);
    }
}

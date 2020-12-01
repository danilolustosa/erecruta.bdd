using Erecruta.Domain;
using Erecruta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface IOportunidadeService
    {
        public ListResponse Incluir(Oportunidade oportunidade);
        public ListResponse Alterar(Oportunidade oportunidade);
        public ListaOportunidadeResponse Listar();
        public OportunidadeResponse Obter(int id);
    }
}

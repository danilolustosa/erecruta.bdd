using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface IIBGEService
    {
        public List<Estado> ListarEstado();
        public List<Cidade> ListarCidade(long estadoId);
        public Estado ObterEstado(long estadoId);
        public Cidade ObterCidade(long cidadeId);
    }
}

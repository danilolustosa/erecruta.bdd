using Erecruta.Domain;
using Erecruta.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Service
{
    public class IBGEService : IIBGEService
    {
        private IIBGERepository _iBGERepository;

        public IBGEService(IIBGERepository iBGERepository) => _iBGERepository = iBGERepository;

        public List<Estado> ListarEstado() => _iBGERepository.ListarEstado();
        public List<Cidade> ListarCidade(long estadoId) => _iBGERepository.ListarCidade(estadoId);
        public Estado ObterEstado(long estadoId) => _iBGERepository.ObterEstado(estadoId);
        public Cidade ObterCidade(long cidadeId) => _iBGERepository.ObterCidade(cidadeId);
    }
}

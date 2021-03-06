﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Domain
{
    public class Oportunidade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public long EstadoId { get; set; }
        public long CidadeId { get; set; }
        public string Regiao { get; set; }
        public string Remuneracao { get; set; }
        public string Regime { get; set; }
        public string Posicao { get; set; }
        public string JobDescription { get; set; }
        public bool Situacao { get; set; }
        public List<Nivel> Niveis { get; set; }
        public string Duracao { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
    }
}

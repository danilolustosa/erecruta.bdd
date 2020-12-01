using Dapper;
using Erecruta.Domain;
using Erecruta.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Repository
{
    public class NivelRepository : BaseRepository, INivelRepository
    {
        public List<Nivel> ListarByOportunidade(int OportunidadeId)
        {
            string query = @"
                    SELECT 
	                    T02.Id,
	                    T02.Descricao
                    FROM OportunidadeNivel T01
	                    JOIN Nivel T02 ON T02.Id = T01.NivelId
                    WHERE OportunidadeId = @OportunidadeId
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Nivel>(query, new { OportunidadeId }).ToList();
        }
    }
}

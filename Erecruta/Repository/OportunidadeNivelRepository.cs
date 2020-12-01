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
    public class OportunidadeNivelRepository : BaseRepository, IOportunidadeNivelRepository
    {
        public void Incluir(OportunidadeNivel oportunidadeNivel)
        {
            string query = @"
                        INSERT INTO [dbo].[OportunidadeNivel]
                                   ([NivelId]
                                   ,[OportunidadeId])
                             VALUES
                                   (@NivelId
                                   ,@OportunidadeId)
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, oportunidadeNivel);
        }

        public void DeletarByOportunidade(int OportunidadeId)
        {
            string query = @"
                            DELETE FROM OportunidadeNivel 
                            WHERE OportunidadeId = @OportunidadeId
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, new { OportunidadeId });
        }
    }
}

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
    public class CandidatoRepository : BaseRepository, ICandidatoRepository
    {
        public int Incluir(Candidato candidato)
        {
            string query = @"

                    INSERT INTO [dbo].[Candidato]
                               ([Nome]
                               ,[Email]
                               ,[Celular]
                               ,[LinkedIn]
                               ,[Curriculo]
                               ,[Classificacao]
                               ,[EstadoId]
                               ,[CidadeId]
                               ,[Observacao]
                               ,[Situacao]
                               ,[OportunidadeId]
                               ,[Regiao])
                         OUTPUT Inserted.Id
                         VALUES
                               (@Nome
                               ,@Email
                               ,@Celular
                               ,@LinkedIn
                               ,@Curriculo
                               ,@Classificacao
                               ,@EstadoId
                               ,@CidadeId
                               ,@Observacao
                               ,@Situacao
                               ,@OportunidadeId
                               ,@Regiao)
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.ExecuteScalar<int>(query, candidato);
        }

        public void Alterar(Candidato candidato)
        {
            string query = @"
                    UPDATE [dbo].[Candidato]
                       SET [Nome] = @Nome
                          ,[Email] = @Email
                          ,[Celular] = @Celular
                          ,[LinkedIn] = @LinkedIn
                          ,[Curriculo] = @Curriculo
                          ,[Classificacao] = @Classificacao
                          ,[EstadoId] = @EstadoId
                          ,[CidadeId] = @CidadeId
                          ,[Observacao] = @Observacao
                          ,[Situacao] = @Situacao
                          ,[OportunidadeId] = @OportunidadeId
                          ,[Regiao] = @Regiao
                     WHERE Id = @Id
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, candidato);
        }


        public List<Candidato> Listar(int OportunidadeId)
        {
            string query = @"
                    SELECT [Id]
                          ,[Nome]
                          ,[Email]
                          ,[Celular]
                          ,[LinkedIn]
                          ,[Curriculo]
                          ,[Classificacao]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Observacao]
                          ,[Situacao]
                          ,[OportunidadeId]
                          ,[Regiao]
                      FROM [dbo].[Candidato]
                      WHERE OportunidadeId = @OportunidadeId
                           AND Situacao = 1
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Candidato>(query, new { OportunidadeId }).ToList();
        }

        public Candidato Obter(int Id)
        {
            string query = @"
                    SELECT [Id]
                          ,[Nome]
                          ,[Email]
                          ,[Celular]
                          ,[LinkedIn]
                          ,[Curriculo]
                          ,[Classificacao]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Observacao]
                          ,[Situacao]
                          ,[OportunidadeId]
                          ,[Regiao]
                      FROM [dbo].[Candidato]
                      WHERE Id = @Id
                          AND Situacao = 1
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Candidato>(query, new { Id }).FirstOrDefault();
        }
    }
}

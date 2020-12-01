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
    public class OportunidadeRepository : BaseRepository, IOportunidadeRepository
    {
        public int Incluir(Oportunidade oportunidade)
        {
            string query = @"
                        INSERT INTO [dbo].[Oportunidade]
                                   ([Titulo]
                                   ,[Empresa]
                                   ,[DataHoraCriacao]
                                   ,[EstadoId]
                                   ,[CidadeId]
                                   ,[Regiao]
                                   ,[Remuneracao]
                                   ,[Regime]
                                   ,[Posicao]
                                   ,[JobDescription]
                                   ,[Situacao])
                             OUTPUT Inserted.Id 
                             VALUES
                                   (@Titulo
                                   ,@Empresa
                                   ,@DataHoraCriacao
                                   ,@EstadoId                                   
                                   ,@CidadeId
                                   ,@Regiao
                                   ,@Remuneracao
                                   ,@Regime
                                   ,@Posicao
                                   ,@JobDescription
                                   ,@Situacao)
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.ExecuteScalar<int>(query, oportunidade);
        }

        public void Alterar(Oportunidade oportunidade)
        {
            string query = @"
                    UPDATE [dbo].[Oportunidade]
                       SET [Titulo] = @Titulo
                          ,[Empresa] = @Empresa
                          ,[DataHoraCriacao] = @DataHoraCriacao
                          ,[EstadoId] = @EstadoId
                          ,[CidadeId] = @CidadeId
                          ,[Regiao] = @Regiao
                          ,[Remuneracao] = @Remuneracao
                          ,[Regime] = @Regime
                          ,[Posicao] = @Posicao
                          ,[JobDescription] = @JobDescription
                          ,[Situacao] = @Situacao
                     WHERE [Id] = @Id
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, oportunidade);
        }

        public List<Oportunidade> Listar()
        {
            string query = @"
                    SELECT [Id]
                          ,[Titulo]
                          ,[Empresa]
                          ,[DataHoraCriacao]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Regiao]
                          ,[Remuneracao]
                          ,[Regime]
                          ,[Posicao]
                          ,[JobDescription]
                          ,[Situacao]
                      FROM [dbo].[Oportunidade]
                      WHERE Situacao = 1

            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Oportunidade>(query).ToList();
        }

        public Oportunidade Obter(int Id)
        {
            string query = @"
                    SELECT [Id]
                          ,[Titulo]
                          ,[DataHoraCriacao]
                          ,[Empresa]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Regiao]
                          ,[Remuneracao]
                          ,[Regime]
                          ,[Posicao]
                          ,[JobDescription]
                          ,[Situacao]
                      FROM [dbo].[Oportunidade]
                      WHERE Id = @Id
                           AND Situacao = 1
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Oportunidade>(query, new { Id }).FirstOrDefault();
        }
    }
}

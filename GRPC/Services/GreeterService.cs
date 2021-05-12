using Grpc.Core;
using Microsoft.Extensions.Logging;
using Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRPC
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private DatabaseConnection databaseConnection;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
            databaseConnection = new DatabaseConnection();
        }

        public override Task<LivroReply> CriarLivro(CriarLivroRequest request, ServerCallContext context)
        {
            var retorno =  databaseConnection.CriarLivro(request.Titulo, request.Autor, Convert.ToChar(request.NumeroEdicao), request.AnoEdicao);
            return Task.FromResult(new LivroReply
            {
                Message = retorno
            });
        }
        public override Task<LivroReply> AtualizarLivro(AtualizarLivroRequest request, ServerCallContext context)
        {
            var retorno = databaseConnection.AlterarLivro(request.Codigo, request.Titulo, Convert.ToChar(request.NumeroEdicao), request.AnoEdicao);
            return Task.FromResult(new LivroReply
            {
                Message = retorno
            });
        }
        public override Task<LivroReply> RemoverLivro(RemoverLivroRequest request, ServerCallContext context)
        {
            var retorno = databaseConnection.RemoverLivro(request.Titulo);
            return Task.FromResult(new LivroReply
            {
                Message = retorno
            });
        }
        public override Task<LivroReply> ConsultarLivroPorTitulo(ConsultarLivroPorTituloRequest request, ServerCallContext context)
        {
            var retorno = databaseConnection.ConsultarLivroPorNomeAutor(request.Titulo);
            return Task.FromResult(new LivroReply
            {
                Message = retorno
            });
        }
        public override Task<LivroReply> ConsultarPorAnoENumero(ConsultarPorAnoENumeroRequest request, ServerCallContext context)
        {
            var retorno = databaseConnection.ConsultarLivroPorAnoNumeroEdicao(request.Ano, Convert.ToChar(request.Numero));
            return Task.FromResult(new LivroReply
            {
                Message = retorno
            });
        }
    }
}

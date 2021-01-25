using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranPEVerificarPontosRepository : IDetranVerificarPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranPEVerificarPontosRepository(ILogger<DetranPEVerificarPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosVeiculo>> ConsultarPontos(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando os pontos na carteira do veículo placa {veiculo.Placa} para o estado de PE.");
            return Task.FromResult<IEnumerable<PontosVeiculo>>(new List<PontosVeiculo>() { new PontosVeiculo() });
        }
    }
}
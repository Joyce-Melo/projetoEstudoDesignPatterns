using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificarPontosRepository : IDetranVerificarPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificarPontosRepository(ILogger<DetranSPVerificarPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosVeiculo>> ConsultarPontos(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando os pontos na carteira do ve�culo placa {veiculo.Placa} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontosVeiculo>>(new List<PontosVeiculo>() { new PontosVeiculo() });
        }
    }
}
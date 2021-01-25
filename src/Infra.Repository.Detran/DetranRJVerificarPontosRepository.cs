
}using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRJVerificarPontosRepository : IDetranVerificarPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranRJVerificarPontosRepository(ILogger<DetranRJVerificarPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosVeiculo>> ConsultarPontos(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando os pontos na carteira do veículo placa {veiculo.Placa} para o estado de RJ.");
            return Task.FromResult<IEnumerable<PontosVeiculo>>(new List<PontosVeiculo>() { new PontosVeiculo() });
        }
    }
}
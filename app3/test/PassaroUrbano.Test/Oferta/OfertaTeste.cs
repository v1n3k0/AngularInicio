using Moq;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using PassaroUrbano.Domain.Services.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace PassaroUrbano.Test.Oferta
{
    public class OfertaTeste
    {
        private readonly Domain.Entities.Oferta.Oferta _oferta;
        private readonly IEnumerable<Domain.Entities.Oferta.Oferta> _ofertas;
        private readonly OfertaService _ofertaService;
        private readonly Mock<IOfertaRepository> _ofertaRepository;

        public OfertaTeste()
        {
            _ofertas = PreencherLista(5);
            _oferta = _ofertas.First();

            _ofertaRepository = new Mock<IOfertaRepository>();
            _ofertaService = new OfertaService(_ofertaRepository.Object);
        }

        private IEnumerable<Domain.Entities.Oferta.Oferta> PreencherLista(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                yield return new Domain.Entities.Oferta.Oferta()
                {
                    Id = i,
                    DataCadastro = DateTime.Now,
                    Titulo = $"Titulo {i}",
                    Descricao = $"Descricao {i}",
                    Anuciante = $"Anuciante {i}",
                    Valor = 100.12M + i,
                    Destaque = 0 == i % 2,
                    IdCategoria = 1,
                    IdComoUsar = i,
                    IdOndeFica = i,
                };
            }
        }

        [Theory(DisplayName = "DeveObterPorId")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(100)]
        public async Task DeveObterPorIdAsync(int id)
        {
            _ofertaRepository
                .Setup(r => r.ObterPorIdAsync(id))
                .ReturnsAsync(_oferta);

            var response = await _ofertaService
                .ObterPorIdAsync(id);

            _ofertaRepository
                .Verify(r => r.ObterPorIdAsync(It.Is<int>(x => x == id)), Times.Once());

            Assert.Equal(_oferta, response);
        }

        [Theory(DisplayName = "DeveListarPorDestaque")]
        [InlineData(true)]
        [InlineData(false)]
        public async Task DeveListarPorDestaqueAsync(bool destaque)
        {
            var ofertas = _ofertas
                .Where(x => x.Destaque == destaque);

            _ofertaRepository.Setup(r => r.ListarPorAsync(It.IsAny<Expression<Func<Domain.Entities.Oferta.Oferta, bool>>>()))
                .ReturnsAsync(ofertas);

            var response = await _ofertaService
                .ListarPorDestaqueAsync(destaque);

            Assert.True(response.Count() == ofertas.Count());
        }
    }
}

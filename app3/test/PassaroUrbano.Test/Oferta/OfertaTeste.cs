using Moq;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using PassaroUrbano.Domain.Services.Oferta;
using System;
using Xunit;

namespace PassaroUrbano.Test.Oferta
{
    public class OfertaTeste
    {
        private readonly Domain.Entities.Oferta.Oferta _oferta;
        private readonly OfertaService _ofertaService;
        private readonly Mock<IOfertaRepository> _ofertaRepository;

        public OfertaTeste()
        {
            _oferta = new Domain.Entities.Oferta.Oferta()
            {
                Id = 1,
                DataCadastro = DateTime.Now,
                Titulo = "Titulo oferta",
                Descricao = "Descricao oferta",
                Anuciante = "Anuciante oferta",
                Valor = 123.32M,
                Destaque = true,
                IdCategoria = 1,
                IdComoUsar = 1,
                IdOndeFica = 1,
            };

            _ofertaRepository = new Mock<IOfertaRepository>();
            _ofertaService = new OfertaService(_ofertaRepository.Object);
        }


        [Theory(DisplayName = "DeveObterPorId")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(100)]
        public void DeveObterPorId(int id)
        {
            _ofertaRepository.Setup(r => r.Adicionar(_oferta));

            _ofertaService.ObterPorId(id);

            _ofertaRepository.Verify(r => r.ObterPorId(It.Is<int>(o => o == id)));
        }
    }
}

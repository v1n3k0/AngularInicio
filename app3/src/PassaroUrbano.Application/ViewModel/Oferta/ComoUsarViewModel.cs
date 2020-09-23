using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class ObterComoUsarViewModel
    {
        public int IdComoUsar { get; set; }
        public string Descricao { get; set; }

        public static explicit operator ObterComoUsarViewModel(ComoUsar comoUsar)
        {
            return new ObterComoUsarViewModel()
            {
                IdComoUsar = comoUsar.Id,
                Descricao = comoUsar.Descricao
            };
        }
    }
}

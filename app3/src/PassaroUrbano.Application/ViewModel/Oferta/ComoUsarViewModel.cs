using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class ComoUsarViewModel
    {
        public int IdComoUsar { get; set; }
        public string Descricao { get; set; }

        public static explicit operator ComoUsarViewModel(ComoUsar comoUsar)
        {
            return new ComoUsarViewModel()
            {
                IdComoUsar = comoUsar.Id,
                Descricao = comoUsar.Descricao
            };
        }
    }
}

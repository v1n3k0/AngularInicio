using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class OndeFicaViewModel
    {
        public int IdOndeFica { get; set; }
        public string Descricao { get; set; }

        public static explicit operator OndeFicaViewModel(OndeFica ondeFica)
        {
            return new OndeFicaViewModel()
            {
                IdOndeFica = ondeFica.Id,
                Descricao = ondeFica.Descricao
            };
        }
    }
}

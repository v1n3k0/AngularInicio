using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class ObterOndeFicaViewModel
    {
        public int IdOndeFica { get; set; }
        public string Descricao { get; set; }

        public static explicit operator ObterOndeFicaViewModel(OndeFica ondeFica)
        {
            return new ObterOndeFicaViewModel()
            {
                IdOndeFica = ondeFica.Id,
                Descricao = ondeFica.Descricao
            };
        }
    }
}

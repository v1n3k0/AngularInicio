using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class ObterCategoriaViewModel
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static explicit operator ObterCategoriaViewModel(Categoria categoria)
        {
            return new ObterCategoriaViewModel()
            {
                IdCategoria = categoria.Id,
                Nome = categoria.Nome,
                Descricao = categoria.Descricao
            };
        }
    }
}

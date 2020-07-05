namespace PassaroUrbano.Application.ViewModel.Oferta
{
    public class ObterOfertaResponseViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Anuciante { get; set; }
        public decimal Valor { get; set; }
        public bool Destaque { get; set; }

        public static explicit operator ObterOfertaResponseViewModel(Domain.Entities.Oferta.Oferta oferta)
        {
            return new ObterOfertaResponseViewModel()
            {
                Id = oferta.Id,
                Titulo = oferta.Titulo,
                Descricao = oferta.Descricao,
                Anuciante = oferta.Anuciante,
                Destaque = oferta.Destaque,
                Valor = oferta.Valor
            };
        }
    }
}

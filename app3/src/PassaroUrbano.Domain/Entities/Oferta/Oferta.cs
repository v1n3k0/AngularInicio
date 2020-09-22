using System.Collections.Generic;

namespace PassaroUrbano.Domain.Entities.Oferta
{
    public class Oferta : BaseEntity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Anuciante { get; set; }
        public decimal Valor { get; set; }
        public bool Destaque { get; set; }
        public int IdCategoria { get; set; }
        public int IdComoUsar { get; set; }
        public int IdOndeFica { get; set; }

        public Categoria Categoria { get; set; }
        public ComoUsar ComoUsar { get; set; }
        public OndeFica OndeFica { get; set; }
        public IEnumerable<Imagem> Imagens { get; set; }
    }
}

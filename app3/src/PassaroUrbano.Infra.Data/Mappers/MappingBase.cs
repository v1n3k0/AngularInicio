using Dapper.FluentMap.Dommel.Mapping;
using PassaroUrbano.Domain.Entities;

namespace PassaroUrbano.Infra.Data.Mappers
{
    public class MappingBase<T> : DommelEntityMap<T> where T : BaseEntity
    {
        public MappingBase()
        {
            Map(x => x.Id).IsIdentity().IsKey();
            Map(x => x.DataCadastro).ToColumn("DataCadastro");
            Map(x => x.DataAlteracao).ToColumn("DataAlteracao");
            Map(x => x.DataRemocao).ToColumn("DataRemocao");
        }
    }
}

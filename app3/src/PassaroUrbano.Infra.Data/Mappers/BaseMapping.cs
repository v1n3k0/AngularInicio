using Dapper.FluentMap.Dommel.Mapping;
using PassaroUrbano.Domain.Entities;

namespace PassaroUrbano.Infra.Data.Mappers
{
    public abstract class BaseMapping<T> : DommelEntityMap<T> where T : BaseEntity
    {
        protected BaseMapping()
        {
            Map(x => x.Id).ToColumn("Id").IsIdentity().IsKey();
        }
    }
}

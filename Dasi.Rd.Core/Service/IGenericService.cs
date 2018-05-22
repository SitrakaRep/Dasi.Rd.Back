using Dasi.Rd.Core.Interface;

namespace Dasi.Rd.Core.Service
{
    public interface IGenericService<TEntity> : IGenericInterface<TEntity> where TEntity : class
    {
    }
}

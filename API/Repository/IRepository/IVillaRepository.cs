using API.Models;
using System.Linq.Expressions;

namespace API.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa> 
    {
        Task<Villa> UpdateAsync(Villa entity);

    }
}

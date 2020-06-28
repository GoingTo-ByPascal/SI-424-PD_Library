using System;
using System.Threading.Tasks;

namespace GoingTo_Library.Façade.Interface
{
    public interface IFaçade<T>
    {
        Task<T> ListAsync();
        Task<T> ListByIdAsyn(int id);
        Task<T> GetByIdAsync(int id);
        Task<T> SaveAsync(T data);
        Task<T> UpdateAsync(int id, T data);
        Task<T> DeleteAsync(int id);
        Task<T> AssignAsync(int firstId, int secondId);
        Task<T> UnassignAsync(int firstId, int secondId);
     }
}

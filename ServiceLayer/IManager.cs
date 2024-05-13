using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IManager<T, K>
    {
        Task CreateAsync(T item);

        Task<T> ReadAsync(K key);

        Task<List<T>> ReadAllAsync();

        Task UpdateAsync(T item);

        Task DeleteAsync(K key);
    }
}

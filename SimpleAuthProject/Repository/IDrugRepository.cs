using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pharmacyManagementWebApiservice.Repository
{
    public interface IDrugRepository<T> where T : class,new()
    {
        T Create(T drugDetails);
        Task<IEnumerable<T>> GetAll();

        T GetDrugName(string drugName);
        T GetDrug(int id);
        void DeleteDrug(int id);
        void UpdateDrug(T drugDetails);
    }
}

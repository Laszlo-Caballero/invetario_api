using invetario_api.Modules.store.dto;
using invetario_api.Modules.store.entity;
using invetario_api.Modules.store.response;
using invetario_api.utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace invetario_api.Modules.store
{
    public interface IStoreService
    {
        Task<List<StoreResponse>> getStores();

        Task<StoreResponse?> getStoreById(int storeId);
        
        Task<StoreResponse?> createStore(StoreDto data);

        Task<StoreResponse?> updateStore(int storeId, UpdateStoreDto data);

        Task<StoreResponse?> deleteStore(int storeId);
    }
}

using invetario_api.Modules.store.entity;
using invetario_api.Modules.users.entity;
using invetario_api.Modules.users.response;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace invetario_api.Modules.store.response
{
    public class StoreResponse
    {
        public int storeId { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int maxCapacity { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
        public UserSingleResponse user { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public string observations { get; set; }

        public static StoreResponse fromEntity(Store store)
        {
            return new StoreResponse
            {
                storeId = store.storeId,
                name = store.name,
                code = store.code,
                address = store.address,
                phone = store.phone,
                maxCapacity = store.maxCapacity,
                status = store.status,
                type = store.type,
                user = UserSingleResponse.fromEntity(store.user),
                createdAt = store.createdAt,
                observations = store.observations
            };
        }

        public static List<StoreResponse> fromEntityList(List<Store> stores)
        {
            return stores.Select(store => fromEntity(store)).ToList();
        }
    }
}

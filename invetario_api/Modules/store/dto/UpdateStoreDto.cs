using System.ComponentModel.DataAnnotations;

namespace invetario_api.Modules.store.dto
{
    public class UpdateStoreDto : StoreDto
    {
        [Required]
        public bool? status { get; set; }
    }
}

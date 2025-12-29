using invetario_api.Modules.store.dto;
using invetario_api.Modules.store.entity;
using invetario_api.utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace invetario_api.Modules.store
{

    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private IStoreService _storeService;

        public StoreController(IStoreService storeService) {
            _storeService = storeService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> FindAll() 
        {
            var result = await _storeService.getStores();
            return Ok(result);
        }
        
        [HttpGet("{storeId:int}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> FindById(int storeId) 
        {
            var result = await _storeService.getStoreById(storeId);
            if(result == null)
            {
                return BadRequest(ResponseApi<object>.NotFound(404, "Store Not Found"));
            }

            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Create([FromBody] StoreDto data)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var result = await _storeService.createStore(data);
            if(result == null)
            {
                return BadRequest(ResponseApi<object>.NotFound(404, "User Not Found"));
            }
            return Ok(result);
        }

        [HttpPut("{storeId:int}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> update(int storeId, [FromBody] UpdateStoreDto data)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var result = await _storeService.updateStore(storeId, data);

            if(result == null)
            {
                return BadRequest(ResponseApi<object>.NotFound(404, "Store or User Not Found"));
            }

            return Ok(result);
        }


        [HttpDelete("{storeId:int}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> delete(int storeId)
        {
            var result = await _storeService.deleteStore(storeId);
            if (result == null)
            {
                return BadRequest(ResponseApi<object>.NotFound(404, "Store Not Found"));
            }
            return Ok(result);
        }
    }
}

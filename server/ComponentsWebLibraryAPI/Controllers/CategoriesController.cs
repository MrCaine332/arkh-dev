using ComponentsWebLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComponentsWebLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoriesServices _categoriesServices;

        public CategoriesController(CategoriesServices categoriesServices)
        {
            _categoriesServices = categoriesServices;
        }
        
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }
        
        
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok();
        }
        
        
        [HttpPost]
        public async Task<ActionResult> Create()
        {
            return Ok();
        }
        
        
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update()
        {
            return Ok();
        }
        
        
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete()
        {
            return Ok();
        }
    }
}

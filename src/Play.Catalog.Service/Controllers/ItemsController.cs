using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service;
   
namespace Play.Catalog.Service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items = new();
    }
}
using InfinityMarket.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfinityMarket.Api.Controllers
{
    public class NotesController : ControllerBase
    {
        public readonly NotesService _notesService;

        public NotesController(NotesService notesService)
        {
            _notesService = notesService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

using FullWebProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullWebProject.Controllers
{
    public class TextController : Controller
    {
        private readonly ITextService _textService;

        public TextController(ITextService service)
        {
            _textService = service;
        }

        public IActionResult Concat()
        {
            ViewBag.Concat = _textService.ConcatInputs(",", "Eu", "tu");
            return View();
        }
    }
}
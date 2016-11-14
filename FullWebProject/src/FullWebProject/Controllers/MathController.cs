using FullWebProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullWebProject.Controllers
{
    public class MathController : Controller
    {
        private readonly IMathService _mathService;
        private ITextService _textService;

        public MathController(IMathService service)
        {
            _mathService = service;
        }

        public IActionResult Add()
        {
            ViewBag.Add = "1 + 3 is " + _mathService.AddNumbers(3, 1);
            return View();
        }

        public IActionResult Multiply([FromServices]ITextService service)
        {
            _textService = service;
            ViewBag.Multiply = _textService.ConcatInputs("*", "2", "4") + "= " + _mathService.MultiplyNumbers(1, 4);
            return View();
        }
    }
}
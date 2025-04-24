using Calculator.Web.Services;
using System.Web.Mvc;

namespace Calculator.Web.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculator;

        public CalculatorController()
        {
            var historyService = new InMemoryCalculationHistoryService();
            _calculator = new CalculatorService(historyService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.History = _calculator.GetHistory();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string expression)
        {
            if (!string.IsNullOrWhiteSpace(expression))
            {
                try
                {
                    ViewBag.Result = _calculator.Calculate(expression);
                }
                catch
                {
                    ViewBag.Result = "Invalid Expression";
                }
            }

            ViewBag.History = _calculator.GetHistory();
            return View();
        }
    }
}

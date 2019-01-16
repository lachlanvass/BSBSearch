using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSBSearch.Models;

namespace BSBSearch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Bank model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            BSBSearcher searcher = new BSBSearcher();
            await searcher.BSBQuery(model.BSBNumber);
            model = searcher.BankResult;
            model.Instcode = searcher.BankResult.Instcode;

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

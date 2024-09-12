using CoreBookshelf.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreBookshelf.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Books()
		{
			var Book_Object = new List<Books_Database>()
			{
                new Books_Database() {ID=1,Book_Name="Nutuk",Writer="Mustafa Kemal ATATURK"},
                new Books_Database() {ID=2,Book_Name="Churchill",Writer="Andrew ROBERTS"},
				new Books_Database() {ID=3,Book_Name="Julius Caesar",Writer="William SHAKESPEARE"},
				new Books_Database() {ID=4,Book_Name="Napoleon",Writer="Andrew ROBERTS"},
				new Books_Database() {ID=5,Book_Name="Alexander the Great",Writer="Jacob ABBOTT"}
			};
			
			return View(Book_Object);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

using EmailSendingApp.EmailSenderService;
using EmailSendingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailSendingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var email = "usmanmudassarPC@outlook.com";
            var subject = "Test Email Service in new ASP.NET Core project";
            var message = "Hi! My name is Usman. How are you doing?";
            await _emailSender.SendEmailAsync(email, subject, message);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
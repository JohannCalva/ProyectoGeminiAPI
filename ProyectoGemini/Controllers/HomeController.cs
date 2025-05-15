using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoGemini.Interfaces;
using ProyectoGemini.Models;
using ProyectoGemini.Repositories;

namespace ProyectoGemini.Controllers;

public class HomeController : Controller
{
    private IChatbotService _chatbotService;

    public HomeController(IChatbotService chatbotService)
    {
        _chatbotService = chatbotService;
    }

    public async Task<IActionResult> Index()
    {
        string response = await _chatbotService.GetChatbotResponseAsync("Dame un resumen de 100 palabras de la pelicula Interestellar");
        ViewBag.chatbotAnswer = response;
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

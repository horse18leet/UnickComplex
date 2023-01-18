﻿using Microsoft.AspNetCore.Mvc;

namespace ComplexProject.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View("HomePage");
    }
    public IActionResult GetEx()
    {
        return View("Example");
    }
    public IActionResult TrandAuctions()
    {
        return View("TrandAuctionsPage");
    }
    public IActionResult RecomendationAuctions()
    {
        return View("RecomendationAuctionsPage");
    }
    public IActionResult CategoryAuctions()
    {
        return View("CategoryAuctionsPage");
    }
    public IActionResult StandartAuctions()
    {
        return View("StandartAuctionsPage");
    }
    public IActionResult Support()
    {
        return View("StandartPage");
    }
    public IActionResult Login()
    {
        return View("LoginPage");
    }
}

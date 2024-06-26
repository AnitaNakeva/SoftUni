﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Text_Splitter.Models;

namespace Text_Splitter.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Split(TextViewModel model)
    {
        var splitTextArray = model.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        model.SplitText = string.Join(Environment.NewLine, splitTextArray);

        return RedirectToAction("Index", model);
    }

    public IActionResult Index(TextViewModel model)
        => View(model);

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
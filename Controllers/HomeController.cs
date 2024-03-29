﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webmanage.Models;

using Contentful.Core;

namespace Webmanage.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // Contentful variable
    private readonly IContentfulClient _client;

    // Constructor
    public HomeController(ILogger<HomeController> logger, IContentfulClient client)
    {
        _client = client;
        _logger = logger;
    }

    // Index
    public async Task<IActionResult> Index()
    {
        var userData = await _client.GetEntries<OneWebsite>();
        return View(userData);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleAuth.Data;

namespace SimpleAuth.AdminPanel.Controllers;
[Area("AdminPanel")]
[Authorize(Roles = "Admin")]
public class DashBoardController : Controller
{
    private readonly ApplicationDbContext _context;

    public DashBoardController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
}

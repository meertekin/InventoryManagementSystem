//using System.Diagnostics;
using InventoryManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
//using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers;

public class InventoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public InventoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult InventoryPage()
    {
        //var objInventoryList = _db.
        return View();
    }
    public IActionResult InventoryAdd()
    {
        //var objInventoryList = _db.
        return View();
    }
}


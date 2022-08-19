//using System.Diagnostics;
using InventoryManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Models;

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
        
        IEnumerable< InventoryPage> objInventoryList = _db.Inventory.ToList();
    
        return View(objInventoryList);
    }
    public IActionResult InventoryAdd()
    {
        //_db.Inventory.Add(new Models.InventoryPage { Id = 1, Name = "Test", Price = 1.3F, PurchaseDate = DateTime.Now, Type = "dd" });
        //_db.SaveChanges();
        return View();
    }
}


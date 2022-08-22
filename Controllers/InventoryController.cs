//using System.Diagnostics;
using InventoryManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers;


public class InventoryController : Controller
{
    private int id = 7;
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

    //GET
    public IActionResult InventoryAdd()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult InventoryAdd(InventoryPage obj)
    {
        
        _db.Inventory.Add(new Models.InventoryPage { Id = id, Name = obj.Name, Price = obj.Price, PurchaseDate = obj.PurchaseDate, Type = obj.Type });
        id++;
        _db.SaveChanges();
        
        return RedirectToAction("InventoryPage");
    }

}


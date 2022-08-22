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
        
        _db.Inventory.Add(new Models.InventoryPage {Name = obj.Name, Price = obj.Price, PurchaseDate = obj.PurchaseDate, Type = obj.Type });
       
        _db.SaveChanges();
        return RedirectToAction("InventoryPage");
    }

    public IActionResult InventoryEdit(int? Id)
    {
        if(Id==null || Id == 0)
        {
            return NotFound();
        }
        var inventoryFromDb = _db.Inventory.Find(Id);


        if (inventoryFromDb == null)
        {
            return NotFound();
        }
        return View(inventoryFromDb);
    }
}


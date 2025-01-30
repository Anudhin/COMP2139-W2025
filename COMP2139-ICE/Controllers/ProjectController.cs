using COMP2139_ICE.Data;
using COMP2139_ICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_ICE.Controllers;

public class ProjectController : Controller
{
    
    private readonly ApplicationDbContext _context;

    public ProjectController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var projects = _context.Projects.ToList();
        return View(projects);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Project project)
    {
        if (ModelState.IsValid)
        {
            _context.Projects.Add(project); //Add project to database memory
            _context.SaveChanges(); //Save changes to the database. save or persist or commit
            return RedirectToAction("Index");
        }
        return View(project);
    }
    
    //CRUD
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        //Database
        var project = new Project { ProjectId = id, Name = "Project 1", Description = "First Project" };
        return View(project);
    }
 
}
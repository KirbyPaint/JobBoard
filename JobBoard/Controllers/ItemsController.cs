using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<JobOpening> allItems = JobOpening.GetAll();
      return View(allItems);
    }

    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<ContactInfo> allItems2 = ContactInfo.GetAll();
    //   return View(allItems);
    // }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      JobOpening myJob = new JobOpening(title, description);
      ContactInfo myContact = new ContactInfo(name, email, phoneNumber);
      return RedirectToAction("Index");
    }
  }

}
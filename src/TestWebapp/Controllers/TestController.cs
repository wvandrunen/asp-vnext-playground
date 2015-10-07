using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using TestWebapp.Models;

namespace TestWebapp.Controllers
{
    public class TestController : Controller
    {
	    [Route("/")]
	    public IActionResult Index()
	    {
		    var todoItems = new List<TodoItem>()
		    {
			    new TodoItem()
			    {
				    Name = "Test",
				    Description = "Test #1"
			    },
			    new TodoItem()
			    {
				    Name = "Test 2",
					Description = "Nog een testje"
				}
		    };

		    return View("Index", todoItems);
	    }
    }
}

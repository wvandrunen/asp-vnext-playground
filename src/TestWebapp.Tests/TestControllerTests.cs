using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using TestWebapp.Controllers;
using Xunit;
using FluentAssertions;
using TestWebapp.Models;

namespace TestWebapp.Tests
{
    public class TestControllerTests
    {
		[Fact]
        public void TestSomething()
        {
			TestController testController = new TestController();
	        var viewResult = testController.Index() as ViewResult;
	        var model = viewResult.ViewData.Model as IEnumerable<TodoItem>;

			model.Should().HaveCount(2);
        }
    }
}

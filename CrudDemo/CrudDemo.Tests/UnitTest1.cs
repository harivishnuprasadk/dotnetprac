namespace CrudDemo.Tests;

using System.Collections.Generic;
using CrudDemo.Controllers;
using CrudDemo.Models;
using CrudDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Practice.Controllers;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var exception = new ExceptionHandleController();
        int add = 10;
        int unitAdd = exception.Add(5, 5);
        Assert.Equal(add, unitAdd);
    }

    [Fact]
    public async void Test2()
    {
        List<Issue> issuesList = new List<Issue>();
        Issue issue = new Issue()
        {
            Id = 1,
            Title = "test",
            Description = "test desc",
            Priority = Priority.Low,
            IssueType="issue",
            Completed=DateTime.Now,
            Created=DateTime.Now.AddDays(2)


        };
        issuesList.Add(issue);

        //var controller = new IssueControllerRefactored();

        //List<Issue> issuesListNew = (List<Issue>)await controller.Get();
        //IEnumerable <Issue> issueGet = await controller.Get();
       // IActionResult actionResult =  await controller.GetById(2);

        //  var statusCodeResult = (IStatusCodeActionResult)actionResult;
          //Assert.Equal(issuesList,issueGet);

    }

}

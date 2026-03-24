using Application.Features.Users.Commands.Create;
using Application.Features.Users.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class HomeController(ISender _mediator) : Controller
{
    public async Task<IActionResult> Index()
    {


        return View();
    }
}

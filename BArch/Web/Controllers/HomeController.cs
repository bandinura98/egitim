using Application.Common.Interfaces;
using Application.Features.Users.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class HomeController(IMediator _mediator) : Controller
{
    public async Task<IActionResult> Index()
    {
		try
		{

			var response = await _mediator.Send(new CreateUserCommand("batuhan@hotmail.com", ""));


			var response2 = await _mediator.Send(new CreateUserCommand("batuhan@hotmail.com", "qweasd123"));
			//issuccess error data

		}
		catch (Exception)
		{

			throw;
		}


        return View();
    }
}

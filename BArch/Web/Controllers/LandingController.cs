using Application.Features.Users.Commands.Create;
using Application.Features.Users.Queries.GetById;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class LandingController(IMediator _mediator) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        /*
         Burayı sor eğer ki bir kullanıcı giriş yapmışsa ona özel bir sayfa göstermek istiyorsak nasıl olacak.
         Bearer tokeni nası sokçağız, kullanıcı bilgilerini nasıl alacağız, ona göre nasıl bir sayfa göstereceğiz.
         */
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> SignIn(User user)
    {
        var response = await _mediator.Send(new CreateUserCommand(user));

        if (response._IsSuccess)
        {
            //ViewBag.UserId = UserId;
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Errors = response._Error!;

        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> LoginUser(User item)
    {
        var response = await _mediator.Send(new GetByIdQuery(item.Id));

        if (response._IsSuccess)
        {
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Errors = response._Error!;

        return View();
    }
}

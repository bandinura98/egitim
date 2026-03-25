using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Delete;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Queries.GetAll;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Web.Controllers;

public class UserController(IMediator _mediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var users = await _mediator.Send(new GetAllUsersQuery());

        ViewBag.UserList = users._Data;

        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> Update()

    {
        ViewBag.UserList = await _mediator.Send(new GetAllUsersQuery());
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> Delete()

    {
        ViewBag.UserList = await _mediator.Send(new GetAllUsersQuery());
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(User item)
    {
        var response = await _mediator.Send(new CreateUserCommand(item));

        if (response._IsSuccess)
        {
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Errors = response._Error!;

        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Delete(User item)
    {
        var response = await _mediator.Send(new DeleteUserCommand(item));

        if (response._IsSuccess)
        {
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Errors = response._Error!;

        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Update(User item)
    {
        var response = await _mediator.Send(new UpdateUserCommand(item));

        if (response._IsSuccess)
        {
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Errors = response._Error!;

        return View();
    }
}

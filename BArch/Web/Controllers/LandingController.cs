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
}

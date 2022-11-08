
using Microsoft.AspNetCore.Mvc;
using evalucion_bayteq.Services.Interfaces;

namespace evalucion_bayteq.Controllers;

public class PetController : Controller
{
    private readonly IAPIService _APIService;

     public PetController (IAPIService apiService)
        {
            _APIService = apiService;
        }

    public async Task<IActionResult> Index()
    {
        var petList = await _APIService.GetDataPets();

        if (petList.Count > 0)
            ViewBag.PetList = petList;
        
        return View();
    }

    
}

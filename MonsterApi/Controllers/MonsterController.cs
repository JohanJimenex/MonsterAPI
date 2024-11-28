
using Microsoft.AspNetCore.Mvc;
using MonsterApi.Models;
using MonsterApi.Services;
using Microsoft.Extensions.Configuration;
namespace MonsterApi.Controllers;


[ApiController]
[Route("api/monster")]
public class MonsterController : ControllerBase {

    private readonly MonsterService _monsterService;
    private readonly IConfiguration _configuration;

    public MonsterController(MonsterService monsterService, IConfiguration configuration) {
        _monsterService = monsterService;
        _configuration = configuration;
    }

    [HttpGet]
    public ActionResult<Monster> Get() {
        return Ok(_monsterService.Get());
    }

    [HttpGet("prueba")]
    public string ObtenerValor()
    {
        var valor = _configuration["mikey"];
        return valor;
    }

     [HttpGet("prueba2")]
    public string ObtenerValor()
    {
        var valor2 = _configuration["miotrokey"];
        return valor2;
    }

    // POST api/monster
    [HttpPost]
    public ActionResult<Monster> Post([FromBody] Monster monster) {

        if (monster == null) {
            return BadRequest();
        }

        _monsterService.Add(monster);

        return Ok(monster);
    }


}

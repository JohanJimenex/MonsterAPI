
using Microsoft.AspNetCore.Mvc;
using MonsterApi.Models;
using MonsterApi.Services;
namespace MonsterApi.Controllers;


[ApiController]
[Route("api/monster")]
public class MonsterController : ControllerBase {

    private readonly MonsterService _monsterService;

    public MonsterController(MonsterService monsterService) {
        _monsterService = monsterService;
    }

    [HttpGet]
    public ActionResult<Monster> Get() {
        return Ok(_monsterService.Get());
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

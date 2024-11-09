using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterApi.Models;
namespace MonsterApi.Services;


public class MonsterService {

    private List<Monster> monsters;

    public MonsterService() {
        monsters = [
            new Monster { Id=1, Name = "Goblin", Type = "Creature", Habilities = [
                new Hability { Id = 1, Name = "Steal", Level = 1 },
                new Hability { Id = 2, Name = "Attack", Level = 1 }
            ]},

            new Monster { Id=2, Name = "Orc", Type = "Creature", Habilities = [
                new Hability { Id = 1, Name = "Super Defense", Level = 1 },
                new Hability { Id = 2, Name = "Swim", Level = 1 }
            ]},

            new Monster { Id=3, Name = "Dragon", Type = "Creature", Habilities =  [
                new Hability { Id = 1, Name = "Eat", Level = 1 },
                new Hability { Id = 2, Name = "Run", Level = 1 }
            ]  },
        ];
    }

    public List<Monster> Get() {
        return monsters;
    }

    public void Add(Monster monster) {
        monsters.Add(monster);
    }
}

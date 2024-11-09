using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace MonsterApi.Models;


public class Monster {

    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; }

    public required string Type { get; set; }
    public List<Hability> Habilities { get; set; } = new List<Hability>();

}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Food.Models;

public partial class Foods
{
    [Key]
    public int FoodId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}

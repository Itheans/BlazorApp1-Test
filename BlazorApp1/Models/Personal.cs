using System;
using System.Collections.Generic;

namespace BlazorApp1.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string USer { get; set; } = null!;

    public string PassWord { get; set; } = null!;
}

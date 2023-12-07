using System;
using System.Collections.Generic;

namespace EF_Famms_MVC.Models;

public partial class ProductsTbl
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string ImgPath { get; set; } = null!;
}

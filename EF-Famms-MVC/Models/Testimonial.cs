using System;
using System.Collections.Generic;

namespace EF_Famms_MVC.Models;

public partial class Testimonial
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImgPath { get; set; } = null!;
}

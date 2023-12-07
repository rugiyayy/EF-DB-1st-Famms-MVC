using System;
using System.Collections.Generic;

namespace EF_Famms_MVC.Models;

public partial class FooterContact
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;
}

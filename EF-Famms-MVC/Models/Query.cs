using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Famms_MVC.Models;

public partial class Query
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;


    //public int Id { get; set; }


    //[Required(ErrorMessage = "Full Name is required!")]
    //[MinLength(3, ErrorMessage = "Full Name can't be less than 3 characters!")]
    //[MaxLength(10, ErrorMessage = "Name can't be more than 10 characters!")]
    //public string FullName { get; set; } = null!;


    //[Required(ErrorMessage = "The email address is required!")]
    //[EmailAddress(ErrorMessage = "Invalid Email Address")]
    //public string Email { get; set; } = null!;


    //[Required(ErrorMessage = "Subject is required!")]
    //[MinLength(5, ErrorMessage = "Subject can't be less than 5 characters!")]
    //[MaxLength(10, ErrorMessage = "Subject can't be more than 10 characters!")]
    //public string Subject { get; set; } = null!;



    //[Required(ErrorMessage = "Message is required!")]
    //[MinLength(5, ErrorMessage = "Message can't be less than 5 characters!")]
    //[MaxLength(10, ErrorMessage = "Message can't be more than 10 characters!")]
    //public string Message { get; set; } = null!;
}

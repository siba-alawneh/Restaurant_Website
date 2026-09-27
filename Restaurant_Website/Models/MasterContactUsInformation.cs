using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Website.Models;

public partial class MasterContactUsInformation : BaseEntity
{
    public string Desc { get; set; } 

    //public string Redirect { get; set; } = null!;

    //public string Icon { get; set; } = null!;
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    public string Location { get; set; }
    public string Address { get; set; }
    [EmailAddress]
    public string Email1 { get; set; }
    [EmailAddress]
    public string Email2 { get; set; }
}


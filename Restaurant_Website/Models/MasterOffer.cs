using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterOffer : BaseEntity
{
    public string Title { get; set; } = null!;

    public string Breif { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string? ImageUrl { get; set; }

    
}

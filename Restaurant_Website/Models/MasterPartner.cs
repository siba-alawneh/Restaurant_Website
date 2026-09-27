using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterPartner : BaseEntity
{

    public string Name { get; set; } = null!;

    public string? LogoImageUrl { get; set; }

    public string WebsiteUrl { get; set; } = null!;

  
}

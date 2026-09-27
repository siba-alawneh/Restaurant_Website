using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterAbout : BaseEntity
{

    public string Title { get; set; } = null!;

    public string Brief { get; set; } = null!;

    public string Desc { get; set; } = null!;
    public string? ImageUrl { get; set; }

    //public string MasterAboutUrl { get; set; } = null!;
}

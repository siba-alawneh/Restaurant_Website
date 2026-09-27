using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterSlider : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Breif { get; set; } = null!;
    public string Desc { get; set; } = null!;
    //public string SliderUrl { get; set; } = null!;
    public string? ImageUrl { get; set; }

  
}

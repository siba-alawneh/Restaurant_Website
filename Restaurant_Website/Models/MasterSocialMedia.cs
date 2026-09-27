using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterSocialMedia : BaseEntity
{

    public string Url { get; set; } = null!;

    public string Icon { get; set; } = null!;
    public string WebsiteName { get; set; } = null!;
}

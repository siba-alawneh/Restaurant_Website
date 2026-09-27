using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterService : BaseEntity
{
    public string Title { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Icon { get; set; } = null!;
}

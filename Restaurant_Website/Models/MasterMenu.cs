using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterMenu: BaseEntity
{

    public string Name { get; set; } = null!;

    public string MenuUrl { get; set; } = null!;


}

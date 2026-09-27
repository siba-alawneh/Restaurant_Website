using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterWorkingHour:BaseEntity
{
    public string Day { get; set; } = null!;
    public string TimeForm { get; set; } = null!;
    public string TimeTo { get; set; } = null!;

}

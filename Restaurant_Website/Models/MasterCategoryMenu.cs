using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class MasterCategoryMenu : BaseEntity
{

    public string MenuName { get; set; } = null!;
    public virtual ICollection<MasterItemMenu> MasterItemMenus { get; set; } = new List<MasterItemMenu>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Website.Models;

public partial class MasterItemMenu :BaseEntity
{
    public int? CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Breif { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }
    public bool IsPupular { get; set; }=false;
    public DateTime Date { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public virtual MasterCategoryMenu? MasterCategoryMenu { get; set; }
}

using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class TransactionNewsletter: BaseEntity
{
    public string Email { get; set; } = null!;
}

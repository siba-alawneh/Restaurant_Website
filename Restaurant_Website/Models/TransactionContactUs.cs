using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class TransactionContactUs : BaseEntity
{

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;


}

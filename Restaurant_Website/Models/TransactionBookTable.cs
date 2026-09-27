using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class TransactionBookTable : BaseEntity
{

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public DateTime Date { get; set; }

 
}

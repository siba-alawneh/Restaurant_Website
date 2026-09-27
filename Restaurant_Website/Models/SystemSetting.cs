using System;
using System.Collections.Generic;

namespace Restaurant_Website.Models;

public partial class SystemSetting : BaseEntity
{

    public string? LogoImageUrl { get; set; }

    public string? LogoImageUrl2 { get; set; }

    public string Copyright { get; set; } = null!;

    public string WelcomeNoteTitle { get; set; } = null!;

    public string WelcomeNoteBreif { get; set; } = null!;

    public string WelcomeNoteDesc { get; set; } = null!;

    //public string WelcomeNoteUrl { get; set; } = null!;

    public string? WelcomeNoteImageUrl { get; set; }

    public string? MapLocation { get; set; }

    public string? WelcomeNoteImageUrl2 { get; set; }

    public string? WelcomeNoteImageUrl3 { get; set; }

    public string? WelcomeNoteImageUrl4 { get; set; }
}

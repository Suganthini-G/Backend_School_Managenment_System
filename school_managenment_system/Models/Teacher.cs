using System;
using System.Collections.Generic;

namespace school_managenment_system.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactNo { get; set; }

    public string? EmailAddress { get; set; }

}

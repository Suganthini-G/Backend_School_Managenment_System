using System;
using System.Collections.Generic;

namespace school_managenment_system.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactNo { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? ClassroomId { get; set; }
}

using System;
using System.Collections.Generic;

namespace school_managenment_system.Models;

public partial class AllocateSubject
{
    public int AllocateSubjectId { get; set; }

    public int? SubjectId { get; set; }

    public int? TeacherId { get; set; }
}

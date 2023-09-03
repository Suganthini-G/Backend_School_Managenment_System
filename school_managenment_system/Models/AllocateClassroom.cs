using System;
using System.Collections.Generic;

namespace school_managenment_system.Models;

public partial class AllocateClassroom
{
    public int AllocateClassroomId { get; set; }

    public int? TeacherId { get; set; }

    public int? ClassroomId { get; set; }
}

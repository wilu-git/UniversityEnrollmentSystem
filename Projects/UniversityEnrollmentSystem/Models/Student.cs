using System;
using System.Collections.Generic;

namespace UniversityEnrollmentSystem.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}

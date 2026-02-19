using System;
using System.Collections.Generic;

namespace UniversityEnrollmentSystem.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public int CourseOfferingId { get; set; }

    public decimal? FinalGrade { get; set; }

    public DateTime? DateEnrolled { get; set; }

    public virtual CourseOffering CourseOffering { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}

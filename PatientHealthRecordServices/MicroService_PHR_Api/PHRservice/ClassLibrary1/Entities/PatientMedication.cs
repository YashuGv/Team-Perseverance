﻿using System;
using System.Collections.Generic;

namespace EntityFrame.Entities;

public partial class PatientMedication
{
    public Guid Id { get; set; }

    public string? HealthId { get; set; }

    public string? AppointmentId { get; set; }

    public string? Drug { get; set; }

    public virtual PatientHealthRecord? Appointment { get; set; }
}

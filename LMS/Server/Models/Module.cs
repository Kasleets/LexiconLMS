﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LMS.Server.Models;

public partial class Module
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual Course Course { get; set; }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LMS.Server.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual MainAdmin MainAdmin { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
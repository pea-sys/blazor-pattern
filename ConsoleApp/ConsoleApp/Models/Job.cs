﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleApp.Models;

public partial class Job
{
    public short JobId { get; set; }

    public string JobDesc { get; set; }

    public byte MinLvl { get; set; }

    public byte MaxLvl { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models;

[Table("authors")]
public partial class Author
{
    [Column("au_id"),Required, Key]
    public string AuthorId { get; set; }
    [Column("au_fname"),Required]
    public string AuthorFastName { get; set; }
    [Column("au_lname"),Required]
    public string AuthorLastName { get; set; }
    [Column("phone"),Required]
    public string Phone { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public bool Contract { get; set; }

    public byte[] Rowversion { get; set; }

    public virtual ICollection<Titleauthor> Titleauthors { get; set; } = new List<Titleauthor>();
}
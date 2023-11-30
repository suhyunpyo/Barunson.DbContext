using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_user_mailgroup
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string mg_uid { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? mg0 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg5 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg6 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg7 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg8 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg9 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg10 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mg11 { get; set; }
}

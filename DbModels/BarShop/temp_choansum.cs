using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp_choansum
{
    [StringLength(30)]
    [Unicode(false)]
    public string gubun { get; set; } = null!;

    public int month1 { get; set; }

    public int month2 { get; set; }

    public int month3 { get; set; }

    public int month4 { get; set; }

    public int month5 { get; set; }

    public int month6 { get; set; }

    public int month7 { get; set; }

    public int month8 { get; set; }

    public int month9 { get; set; }

    public int month10 { get; set; }

    public int month11 { get; set; }

    public int month12 { get; set; }
}

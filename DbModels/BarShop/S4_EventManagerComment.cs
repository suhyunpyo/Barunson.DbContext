using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_EventManagerComment
{
    [Key]
    public int seq { get; set; }

    public int eventSeq { get; set; }

    public int company_seq { get; set; }

    public byte isSelected { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    public string comment { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? var1 { get; set; }

    public int? card_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;
}

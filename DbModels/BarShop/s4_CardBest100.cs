using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Card_seq", "Company_seq")]
public partial class s4_CardBest100
{
    [Key]
    public int Card_seq { get; set; }

    [Key]
    public int Company_seq { get; set; }

    public int Sort { get; set; }

    [StringLength(1)]
    public string? Gubun01 { get; set; }

    [StringLength(1)]
    public string? Gubun02 { get; set; }

    [StringLength(1)]
    public string? Gubun03 { get; set; }

    [StringLength(1)]
    public string? Gubun04 { get; set; }

    [StringLength(1)]
    public string? Gubun05 { get; set; }

    [StringLength(1)]
    public string? Gubun06 { get; set; }

    [StringLength(1)]
    public string? Gubun07 { get; set; }
}

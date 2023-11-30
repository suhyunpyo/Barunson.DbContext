using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_MySweetWedding
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    public int? company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? casamia1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? casamia2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? clubmed1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? clubmed2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? goldendew1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? goldendew2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }
}

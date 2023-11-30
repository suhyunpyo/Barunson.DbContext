using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_Card_Detail_Sub
{
    [Key]
    public int Seq { get; set; }

    public int Card_Seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_4 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Step_6 { get; set; }

    [StringLength(200)]
    public string? Step_Title { get; set; }

    [Column(TypeName = "text")]
    public string? Step_Text { get; set; }

    [StringLength(50)]
    public string? Step_Img { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EverydayCard
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Prd_Code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Prd_Name { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? Prd_Size { get; set; }

    public int? Prd_Price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Prd_Img { get; set; }

    [Column(TypeName = "text")]
    public string? Prd_Text { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Prd_View { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Prd_Date { get; set; }
}

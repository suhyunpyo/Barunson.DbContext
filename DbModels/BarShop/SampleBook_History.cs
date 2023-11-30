using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Seq", "SampleBook_ID")]
public partial class SampleBook_History
{
    [Key]
    public int Seq { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SampleBook_ID { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string SampleBook_Condition { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Admin_Memo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Admin_ID { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Regist_Date { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("OB_NOTICE_T", Schema = "invtmng")]
public partial class OB_NOTICE_T
{
    [Key]
    public int Nid { get; set; }

    public int? BOARD_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Uname { get; set; } = null!;

    [StringLength(50)]
    public string Title { get; set; } = null!;

    public short Hit { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "text")]
    public string Content { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string gubun { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    public int bd_order { get; set; }

    public int bd_level { get; set; }

    public int bd_group { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? site_div { get; set; }

    [StringLength(4000)]
    public string? FILE_NAME { get; set; }

    [StringLength(4000)]
    public string? FILE_SIZE { get; set; }
}

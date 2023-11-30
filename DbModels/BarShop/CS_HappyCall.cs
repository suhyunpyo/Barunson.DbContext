using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("CS_HappyCall", Schema = "invtmng")]
public partial class CS_HappyCall
{
    [Key]
    public int idx { get; set; }

    public int? sample_order_seq { get; set; }

    public byte? connect_yn { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? product { get; set; }

    public byte? good_yn { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? good_yn_etc { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? good_yn_etc2 { get; set; }

    public byte? good_cont { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? good_cont_etc { get; set; }

    public byte? inflow { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? inflow_etc { get; set; }

    public byte? card_type { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? card_type_etc { get; set; }

    public byte? card_money { get; set; }

    public byte? gift { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? gift_etc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

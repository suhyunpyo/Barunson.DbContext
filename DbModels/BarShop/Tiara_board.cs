using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Tiara_board
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? hphone { get; set; }

    public byte category { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? contents { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSecret { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pw { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCoupon { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? zipcode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? addr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    public int? qid { get; set; }

    public byte? depth { get; set; }

    public int? vcnt { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}

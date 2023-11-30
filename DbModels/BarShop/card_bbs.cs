using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class card_bbs
{
    [Key]
    public int pk_id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? forum_id { get; set; }

    public int? group_id { get; set; }

    public int? group_p { get; set; }

    public int? group_order { get; set; }

    public int? msglevel { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? subject { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? writer { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? email { get; set; }

    public int? readno { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? passwd { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? writedate { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? homepage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ip { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? tag { get; set; }

    [Column(TypeName = "text")]
    public string? content { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? hide { get; set; }
}

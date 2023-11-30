using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 고객센터)자주묻는질문
/// </summary>
public partial class custom_card_faq
{
    [Key]
    public int pkid { get; set; }

    public int? group_order { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? subject { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? writedate { get; set; }

    [Column(TypeName = "text")]
    public string? content { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? hide { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? forum_id { get; set; }
}

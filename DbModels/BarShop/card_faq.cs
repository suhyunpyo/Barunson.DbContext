using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// FAQ 관련
/// </summary>
[Keyless]
public partial class card_faq
{
    public int pkid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? subject { get; set; }

    [Column(TypeName = "text")]
    public string? content { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? forum_id { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_PhotoStory_Reply
{
    public int? event_num { get; set; }

    public int? seq { get; set; }

    public int? idx { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_EVENT_MUSIC_REPLY_PARENT_WEDDING_EVENT
{
    [Key]
    public int REPLY_PARENT_WEDDING_EVENT_SEQ { get; set; }

    public int? EVENT_MUSIC_REPLY_SEQ { get; set; }

    public int? STATUS_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FATHER_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MOTHER_NAME { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PARENT_WEDDING_DAY { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WEDDING_DAY { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FRONT_IMG { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WEDDING_IMG { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BACK_IMG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

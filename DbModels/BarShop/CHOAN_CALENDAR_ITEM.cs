using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CHOAN_CALENDAR_ITEM
{
    [Key]
    public int CALENDAR_SEQ { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? OBJ_CODE { get; set; }

    [StringLength(512)]
    public string? CALENDAR_FILENAME { get; set; }

    [StringLength(512)]
    public string? CARLENDAR_PATH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

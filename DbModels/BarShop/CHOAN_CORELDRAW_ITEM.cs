using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CHOAN_CORELDRAW_ITEM
{
    [Key]
    public int CORELDRAW_SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CORELDRAW_TYPE_CODE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? OBJ_CODE { get; set; }

    [StringLength(512)]
    public string? CORELDRAW_FILENAME { get; set; }

    [StringLength(512)]
    public string? CORELDRAW_PATH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

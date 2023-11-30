using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class MAIN_POPUP_MST
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TITLE { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime END_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CREATED_DATE { get; set; }
}

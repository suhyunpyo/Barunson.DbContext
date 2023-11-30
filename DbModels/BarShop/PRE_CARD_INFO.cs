using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PRE_CARD_INFO
{
    [Key]
    public int PRE_CARD_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PRE_CARD_NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PRE_CARD_FNAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PRE_CARD_SIMG { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PRE_CARD_INDATE { get; set; }
}

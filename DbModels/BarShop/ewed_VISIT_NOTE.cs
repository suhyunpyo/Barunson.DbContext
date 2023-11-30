using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_VISIT_NOTE
{
    [Key]
    public int v_seq { get; set; }

    public int v_buy_card_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string v_pwd { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string v_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string v_title { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string v_message { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }
}

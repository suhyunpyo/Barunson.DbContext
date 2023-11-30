using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Evt_three_six_nine_board
{
    [Key]
    public int b_idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string b_uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string evt_num { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime evt_regDate { get; set; }
}

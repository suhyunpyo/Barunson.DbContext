using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class evt_mem_regist_gift
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int gift_card_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime regist_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? give_Date { get; set; }

    public int? order_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? end_date { get; set; }
}

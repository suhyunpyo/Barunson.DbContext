using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("card_seq", "display_group", "company_seq")]
public partial class Branch_Card_Plan
{
    public int id { get; set; }

    [Key]
    public int card_seq { get; set; }

    [Key]
    public byte display_group { get; set; }

    [Key]
    public short company_seq { get; set; }

    public short display_order { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? info_tmp { get; set; }

    public short dis_gubun { get; set; }
}

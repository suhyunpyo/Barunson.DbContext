using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("session_id", Name = "IX_S2_UserCardView_session_id")]
public partial class S2_UserCardView
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string session_id { get; set; } = null!;

    public int card_seq { get; set; }

    public int company_seq { get; set; }

    public int? cardkind_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}

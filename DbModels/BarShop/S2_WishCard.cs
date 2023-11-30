using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("uid", "card_seq", "site_div", Name = "IX_S2_WishCard_uid_card_seq_site_div")]
public partial class S2_WishCard
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int card_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? company_seq { get; set; }
}

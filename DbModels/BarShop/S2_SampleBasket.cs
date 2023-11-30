using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샘플장바구니
/// </summary>
[Index("uid", Name = "IX_S2_SampleBasket_UID")]
[Index("GUID", Name = "IX_S2_SampleBasket_guid")]
[Index("sales_gubun", "company_seq", "uid", "card_seq", Name = "IX_SampleBasket_Recomm")]
[Index("card_seq", Name = "IX_card_seq")]
public partial class S2_SampleBasket
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int card_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    public string? MD_recommend { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GUID { get; set; }
}

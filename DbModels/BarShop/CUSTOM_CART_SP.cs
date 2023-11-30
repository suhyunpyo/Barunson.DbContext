using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// OLD 장바구니
/// </summary>
public partial class CUSTOM_CART_SP
{
    [Key]
    public long id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MEMBER_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    public int CARD_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_option { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ishave { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int? company_seq { get; set; }
}

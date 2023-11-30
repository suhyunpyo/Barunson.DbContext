using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_BUY_SETTLE_INFO
{
    [Key]
    public int buy_card_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ResultCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ResultMsg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PayMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AuthCode { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CardQuota { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? QuotaInterest { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CardCode { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? PGAuthDate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? PGAuthTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OrderNO { get; set; }

    [ForeignKey("buy_card_SEQ")]
    [InverseProperty("ewed_BUY_SETTLE_INFO")]
    public virtual ewed_BUY_CARD buy_card_SEQNavigation { get; set; } = null!;
}

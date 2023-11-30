using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("UID", Name = "IDX_S4_MARKETING_AGREEMENT_LOG_UID")]
public partial class S4_MARKETING_AGREEMENT_LOG
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MARKETING_TYPE_CODE { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DEL_DATE { get; set; }
}

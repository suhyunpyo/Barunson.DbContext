using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("GUID", Name = "IX_S2_CARD_LIKE_GUID")]
[Index("CARD_SEQ", "COMPANY_SEQ", Name = "NCI_S2_Card_Like_Card_Seq_Company_Seq")]
public partial class S2_CARD_LIKE
{
    [Key]
    public int S2_CARD_LIKE_SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    public int? COMPANY_SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GUID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

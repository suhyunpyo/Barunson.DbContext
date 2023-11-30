using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class MCARD_INVITATION_FOR_OTHER_SITE
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SITE_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ORIGINAL_SITE_ORDER_CODE { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? InvitationCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_NAME { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AVAILABLE_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

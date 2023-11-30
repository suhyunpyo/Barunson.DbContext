using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_SMS_Service
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isMember { get; set; } = null!;

    public short sms_count { get; set; }

    public short send_sms_count { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? etc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? regdate { get; set; }
}

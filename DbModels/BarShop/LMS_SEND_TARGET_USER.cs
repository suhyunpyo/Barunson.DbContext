using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class LMS_SEND_TARGET_USER
{
    [Key]
    public int SEQ { get; set; }

    public int? GROUP_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SITE_DIV { get; set; }

    [StringLength(100)]
    public string? SITE_NAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SIGN_IN_DATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? UNAME { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BIRTH_DATE_VALUE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WEDDING_DAY_VALUE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MK_EVENT_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SMS_YORN { get; set; }
}

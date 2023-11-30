using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_USER_DEVICE_TOKEN
{
    [Key]
    public int S2_USER_DEVICE_TOKEN_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? COMPANY_SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TOKEN { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? MOBILE_DEVICE_OS_TYPE_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DEVICE_TYPE_NAME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? HTTP_USER_AGENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

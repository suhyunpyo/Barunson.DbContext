using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CUCKOOS_INBOUND
{
    [StringLength(10)]
    [Unicode(false)]
    public string? file_dt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ConnInfo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? birth_dt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedding_dt { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? membershipYN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? inbound_info { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}

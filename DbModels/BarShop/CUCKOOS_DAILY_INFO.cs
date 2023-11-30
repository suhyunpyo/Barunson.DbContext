using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CUCKOOS_DAILY_INFO
{
    [Key]
    public int seq { get; set; }

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

    [StringLength(14)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? zipcode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedding_day { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? barun_reg_site { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? barun_reg_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cuckos_reg_date { get; set; }
}

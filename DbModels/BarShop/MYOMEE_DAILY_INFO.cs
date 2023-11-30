﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 광고-롯데렌탈(묘미) 데이터
/// </summary>
public partial class MYOMEE_DAILY_INFO
{
    [Key]
    public int seq { get; set; }

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
    public string? Birth_date { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? zipcode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedding_day { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? barun_reg_Date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? wedd_pgubun { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? create_date { get; set; }
}

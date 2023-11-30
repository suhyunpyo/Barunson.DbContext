using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 방문상담 예약 정보
/// </summary>
public partial class Visit_Reservation
{
    [Key]
    public int visit_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? visit_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? visit_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? visit_time { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tel_no1 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tel_no2 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tel_no3 { get; set; }

    [Column(TypeName = "text")]
    public string? visit_content { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_call { get; set; }

    [StringLength(50)]
    public string? domain_info { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? wedd_date { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? wedd_time { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? gubun { get; set; }
}

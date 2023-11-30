using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 메일발송리스토리
/// </summary>
public partial class tNeo_Queue
{
    [Key]
    public int mid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string barid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string sname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string smail { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mtype { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mstatus { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string rname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string rmail { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string mtitle { get; set; } = null!;

    [Column(TypeName = "text")]
    public string mcontent { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string msave { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isSend { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string c_site { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? c_category { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? cardno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime org_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? c_hosting { get; set; }

    [Unicode(false)]
    public string? ERROR_MSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SEND_DATE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 메뉴별 카드 순위 관리
/// </summary>
public partial class S4_Ranking_Sort
{
    [Key]
    public int ST_SEQ { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ST_SDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ST_Edate { get; set; }

    [StringLength(4000)]
    public string? ST_Card_Code_Arry { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ST_Regdate { get; set; }

    [Column(TypeName = "ntext")]
    public string? ST_Title { get; set; }

    public int? ST_company_seq { get; set; }

    [StringLength(50)]
    public string? ST_tabgubun { get; set; }

    [StringLength(50)]
    public string? ST_brand { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ST_Editdate { get; set; }

    [StringLength(50)]
    public string? ST_Code { get; set; }

    public int? ST_MD_SEQ { get; set; }
}

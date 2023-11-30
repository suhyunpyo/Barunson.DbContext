using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("rots_Idx", "rot_idx")]
public partial class Roulette_ST
{
    [Key]
    public int rots_Idx { get; set; }

    /// <summary>
    /// 참조키
    /// </summary>
    [Key]
    public int rot_idx { get; set; }

    /// <summary>
    /// 회차아이템명
    /// </summary>
    [StringLength(50)]
    public string? rots_title { get; set; }

    /// <summary>
    /// 회차
    /// </summary>
    public int? rots_ST { get; set; }

    /// <summary>
    /// 초기등록수량
    /// </summary>
    public int? rots_OCNT { get; set; }

    /// <summary>
    /// 수량(소진시킬수량)
    /// </summary>
    public int? rots_CNT { get; set; }

    /// <summary>
    /// 아이템코드
    /// </summary>
    public int? rots_roti_Idx { get; set; }

    /// <summary>
    /// 상태 0:기본전시
    /// </summary>
    public int? rots_status { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? rots_regdate { get; set; }

    /// <summary>
    /// 아이템순번
    /// </summary>
    public int? rots_ord { get; set; }
}

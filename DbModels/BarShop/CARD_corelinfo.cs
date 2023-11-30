using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드초안기초상세정보
/// </summary>
public partial class CARD_corelinfo
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// 카드 코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    /// <summary>
    /// 0:약도,1:영문이름,2:한글이름,3:영문이니셜,4:영문+한글이름,5:예식일,9:기타,
    /// </summary>
    public short point_type { get; set; }

    /// <summary>
    /// 1이면 겉면에 인쇄
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    /// <summary>
    /// 포인트 X값
    /// </summary>
    public double point_x { get; set; }

    /// <summary>
    /// 포인트 Y값
    /// </summary>
    public double point_y { get; set; }

    /// <summary>
    /// 0:좌측, 9:중앙, 8:우측
    /// </summary>
    public byte? point_align { get; set; }

    /// <summary>
    /// 폰트명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? font_name { get; set; }

    /// <summary>
    /// 폰트사이즈
    /// </summary>
    public double? font_size { get; set; }

    /// <summary>
    /// 입력문구 뿌려줘야 할 경우 해당 스트링
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? point_str { get; set; }

    /// <summary>
    /// 변경일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }
}

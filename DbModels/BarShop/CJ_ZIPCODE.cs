using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 초안 택배 소속 정보
/// </summary>
[Keyless]
public partial class CJ_ZIPCODE
{
    [StringLength(6)]
    public string ZIP_NO { get; set; } = null!;

    [StringLength(20)]
    public string? MAN_BRAN_ID { get; set; }

    /// <summary>
    /// 소속
    /// </summary>
    [StringLength(100)]
    public string? MAN_BRAN_NM { get; set; }

    [StringLength(20)]
    public string? UP_BRAN_ID { get; set; }

    /// <summary>
    /// 지점
    /// </summary>
    [StringLength(100)]
    public string? UP_BRAN_NM { get; set; }

    /// <summary>
    /// 시
    /// </summary>
    [StringLength(100)]
    public string? SIDO_ADDR { get; set; }

    /// <summary>
    /// 구
    /// </summary>
    [StringLength(100)]
    public string? SKK_ADDR { get; set; }

    /// <summary>
    /// 동
    /// </summary>
    [StringLength(100)]
    public string? DONG_ADDR { get; set; }

    [StringLength(5)]
    public string? END_NO { get; set; }

    [StringLength(3)]
    public string? SUB_END_NO { get; set; }

    [StringLength(20)]
    public string? END_NM { get; set; }

    /// <summary>
    /// 배송담당자
    /// </summary>
    [StringLength(100)]
    public string? CLDV_EMP_NM { get; set; }

    [StringLength(2)]
    public string? FERRY_RGN_YN { get; set; }

    [StringLength(2)]
    public string? AIR_RGN_YN { get; set; }

    [StringLength(2)]
    public string? USE_YN { get; set; }

    /// <summary>
    /// 수정일(YYYYMMDD)
    /// </summary>
    [StringLength(8)]
    public string? MODI_YMD { get; set; }

    /// <summary>
    /// PR_RSPSDIV
    /// </summary>
    [StringLength(20)]
    public string? REG_EMP_ID { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? REG_DTIME { get; set; }

    /// <summary>
    /// PR_RSPSDIV
    /// </summary>
    [StringLength(20)]
    public string? MODI_EMP_ID { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? MODI_DTIME { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("rotm_Idx", "rotm_UID")]
public partial class Roulette_Member
{
    [Key]
    public int rotm_Idx { get; set; }

    /// <summary>
    /// 참여회원아이디
    /// </summary>
    [Key]
    [StringLength(20)]
    public string rotm_UID { get; set; } = null!;

    /// <summary>
    /// 참여룰렛
    /// </summary>
    public int rotm_rot_idx { get; set; }

    /// <summary>
    /// 참여회차
    /// </summary>
    public int rotm_ST { get; set; }

    /// <summary>
    /// 당첨아이템
    /// </summary>
    public int rotm_rots_Idx { get; set; }

    /// <summary>
    /// 당첨일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime rotm_regdate { get; set; }

    /// <summary>
    /// 쿠폰적용시 쿠폰입력코드
    /// </summary>
    [StringLength(50)]
    public string? rotm_coupon_code { get; set; }

    /// <summary>
    /// 상태(0:대기중, 1:완료)
    /// </summary>
    public int rotm_status { get; set; }

    /// <summary>
    /// 청첩장 주문번호
    /// </summary>
    public int? rotm_order_seq { get; set; }

    /// <summary>
    /// 핸드폰번호
    /// </summary>
    [StringLength(50)]
    public string? rotm_phone { get; set; }
}

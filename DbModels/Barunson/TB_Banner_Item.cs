using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 배너_아이템
/// </summary>
public partial class TB_Banner_Item
{
    /// <summary>
    /// 배너_아이템_ID
    /// </summary>
    [Key]
    public int Banner_Item_ID { get; set; }

    /// <summary>
    /// 배너_ID
    /// </summary>
    public int Banner_ID { get; set; }

    /// <summary>
    /// PC
    /// 모바
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Banner_Type_Code { get; set; } = null!;

    /// <summary>
    /// 이미지_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Image_URL { get; set; }

    /// <summary>
    /// 날짜지정
    /// 무제
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Deadline_Type_Code { get; set; }

    /// <summary>
    /// 시작_날짜
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? Start_Date { get; set; }

    /// <summary>
    /// 시작_시간
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? Start_Time { get; set; }

    /// <summary>
    /// 종료_날짜
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? End_Date { get; set; }

    /// <summary>
    /// 종료_시간
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? End_Time { get; set; }

    /// <summary>
    /// 링크_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Link_URL { get; set; }

    /// <summary>
    /// 새창_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? NewPage_YN { get; set; }

    /// <summary>
    /// 클릭_수
    /// </summary>
    public int? Click_Count { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    public int? Sort { get; set; }

    /// <summary>
    /// 등록_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    /// <summary>
    /// 등록_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    /// <summary>
    /// 수정_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    /// <summary>
    /// 수정_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    /// <summary>
    /// 수정_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Banner_Main_Description { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Banner_Add_Description { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Image_URL2 { get; set; }

    [ForeignKey("Banner_ID")]
    [InverseProperty("TB_Banner_Item")]
    public virtual TB_Banner Banner { get; set; } = null!;
}

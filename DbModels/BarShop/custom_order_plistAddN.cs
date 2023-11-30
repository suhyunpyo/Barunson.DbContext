using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드 추가판 이름 정보
/// </summary>
[Keyless]
public partial class custom_order_plistAddN
{
    public int pid { get; set; }

    /// <summary>
    /// 신랑 아버지 故
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? groom_father_header { get; set; }

    /// <summary>
    /// 신랑 아버지 성
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? groom_father_fname { get; set; }

    /// <summary>
    /// 신랑 아버지
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? groom_father { get; set; }

    /// <summary>
    /// 신랑 아버지 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? groom_father_tail { get; set; }

    /// <summary>
    /// 신랑 어머니 故
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? groom_mother_header { get; set; }

    /// <summary>
    /// 신랑 어머니 성
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? groom_mother_fname { get; set; }

    /// <summary>
    /// 신랑 어머니
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? groom_mother { get; set; }

    /// <summary>
    /// 신랑 어머니 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? groom_mother_tail { get; set; }

    /// <summary>
    /// 신랑 관계
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? groom_rank { get; set; }

    /// <summary>
    /// 신랑 성
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? groom_fname { get; set; }

    /// <summary>
    /// 신랑이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? groom_name { get; set; }

    /// <summary>
    /// 신랑 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? groom_tail { get; set; }

    /// <summary>
    /// 신부 아버지 故
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? bride_father_header { get; set; }

    /// <summary>
    /// 신부 아버지 성
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? bride_father_fname { get; set; }

    /// <summary>
    /// 신부 아버지
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? bride_father { get; set; }

    /// <summary>
    /// 신부 아버지 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? bride_father_tail { get; set; }

    /// <summary>
    /// 신부 어머니 故
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? bride_mother_header { get; set; }

    /// <summary>
    /// 신부 어머니 성
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? bride_mother_fname { get; set; }

    /// <summary>
    /// 신부 어머니
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? bride_mother { get; set; }

    /// <summary>
    /// 신부 어머니 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? bride_mother_tail { get; set; }

    /// <summary>
    /// 신부 관계
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? bride_rank { get; set; }

    /// <summary>
    /// 신부 성
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? bride_fname { get; set; }

    /// <summary>
    /// 신부이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? bride_name { get; set; }

    /// <summary>
    /// 신부 세례명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? bride_tail { get; set; }

    /// <summary>
    /// 신랑 세례명 표기 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isgroom_tail { get; set; }

    /// <summary>
    /// 신부 세례명 표기 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isbride_tail { get; set; }

    /// <summary>
    /// 초대장일 경우 초대인 이름
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? invite_name { get; set; }
}

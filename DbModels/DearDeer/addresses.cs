using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 배송주소관리
/// </summary>
[Index("user_id", Name = "idx_user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class addresses
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    /// <summary>
    /// 주문자이름
    /// </summary>
    [StringLength(50)]
    public string? order_name { get; set; }

    /// <summary>
    /// 주문자이메일
    /// </summary>
    [StringLength(50)]
    public string? order_email { get; set; }

    /// <summary>
    /// 주문자전화번호
    /// </summary>
    [StringLength(20)]
    public string? order_phone { get; set; }

    /// <summary>
    /// 주문자전화번호 추가
    /// </summary>
    [StringLength(20)]
    public string? order_phone_add { get; set; }

    /// <summary>
    /// 주문자우편번호
    /// </summary>
    [StringLength(10)]
    public string? order_zipcode { get; set; }

    /// <summary>
    /// 주문자 기본주소
    /// </summary>
    [StringLength(255)]
    public string? order_addr1 { get; set; }

    /// <summary>
    /// 주문자 상세주소
    /// </summary>
    [StringLength(255)]
    public string? order_addr2 { get; set; }

    /// <summary>
    /// 받는사람 이름
    /// </summary>
    [StringLength(50)]
    public string? delivery_name { get; set; }

    /// <summary>
    /// 받는사람 전화번호
    /// </summary>
    [StringLength(20)]
    public string? delivery_phone { get; set; }

    /// <summary>
    /// 받는사람 전화번호 추가
    /// </summary>
    [StringLength(20)]
    public string? delivery_phone_add { get; set; }

    /// <summary>
    /// 받는사람 우편번호
    /// </summary>
    [StringLength(10)]
    public string? delivery_zipcode { get; set; }

    /// <summary>
    /// 받는사람 기본주소
    /// </summary>
    [StringLength(255)]
    public string? delivery_addr1 { get; set; }

    /// <summary>
    /// 받는사람 상세주소
    /// </summary>
    [StringLength(255)]
    public string? delivery_addr2 { get; set; }

    /// <summary>
    /// 받는사람 이메일
    /// </summary>
    [StringLength(255)]
    public string? delivery_email { get; set; }

    /// <summary>
    /// 배송메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? delivery_message { get; set; }

    /// <summary>
    /// orders.id
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte order_id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(50)]
    public string order_no { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}

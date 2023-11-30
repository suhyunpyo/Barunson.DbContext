using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 토스 주문(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class toss_order
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    [StringLength(50)]
    public string? toss_order_no { get; set; }

    /// <summary>
    /// toss에서 보내준 hash 값
    /// </summary>
    [StringLength(50)]
    public string? hash { get; set; }

    /// <summary>
    /// 메세지 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? memo { get; set; }

    [StringLength(100)]
    public string? to { get; set; }

    [StringLength(100)]
    public string? from { get; set; }

    /// <summary>
    /// 메세지
    /// </summary>
    [Column(TypeName = "text")]
    public string? content { get; set; }

    [StringLength(255)]
    public string? api_result { get; set; }

    /// <summary>
    /// 카드 종류
    /// </summary>
    [StringLength(50)]
    public string? product_code { get; set; }

    /// <summary>
    /// 주문자명
    /// </summary>
    [StringLength(50)]
    public string? order_name { get; set; }

    /// <summary>
    /// 주문자 이메일
    /// </summary>
    [StringLength(50)]
    public string? order_email { get; set; }

    /// <summary>
    /// 주문자 연락처
    /// </summary>
    [StringLength(50)]
    public string? order_phone { get; set; }

    /// <summary>
    /// 주문자 추가 연락처
    /// </summary>
    [StringLength(50)]
    public string? order_phone_add { get; set; }

    /// <summary>
    /// 주문자 우편번호
    /// </summary>
    [StringLength(10)]
    public string? order_zipcode { get; set; }

    /// <summary>
    /// 주문자 주소1
    /// </summary>
    [StringLength(255)]
    public string? order_addr1 { get; set; }

    /// <summary>
    /// 주문자 주소2
    /// </summary>
    [StringLength(255)]
    public string? order_addr2 { get; set; }

    /// <summary>
    /// 수취인명
    /// </summary>
    [StringLength(50)]
    public string? delivery_name { get; set; }

    /// <summary>
    /// 수취인 이메일
    /// </summary>
    [StringLength(50)]
    public string? delivery_email { get; set; }

    /// <summary>
    /// 수취인 연락처
    /// </summary>
    [StringLength(50)]
    public string? delivery_phone { get; set; }

    /// <summary>
    /// 수취인 추가 연락처
    /// </summary>
    [StringLength(50)]
    public string? delivery_phone_add { get; set; }

    /// <summary>
    /// 수취인 우편번호
    /// </summary>
    [StringLength(10)]
    public string? delivery_zipcode { get; set; }

    /// <summary>
    /// 수취인 주소1
    /// </summary>
    [StringLength(255)]
    public string? delivery_addr1 { get; set; }

    /// <summary>
    /// 수취인 주소2
    /// </summary>
    [StringLength(255)]
    public string? delivery_addr2 { get; set; }

    /// <summary>
    /// 보낼 금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? delivery_money { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}

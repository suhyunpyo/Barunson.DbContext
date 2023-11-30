using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 묶음배송
/// </summary>
[PrimaryKey("ID", "ORDER_G_SEQ")]
public partial class DELIVERY_INFO_GROUP
{
    [Key]
    public int ID { get; set; }

    [Key]
    public int ORDER_G_SEQ { get; set; }

    public int DELIVERY_SEQ { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? NAME { get; set; }

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? PHONE { get; set; }

    /// <summary>
    /// 헨드폰번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    /// <summary>
    /// 우편번호
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? ZIP { get; set; }

    /// <summary>
    /// 주소
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? ADDR { get; set; }

    /// <summary>
    /// 상세주소
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? ADDR_DETAIL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PACKING_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? DELIVERY_COM { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PACKING_ADMIN_ID { get; set; }

    /// <summary>
    /// 배송비
    /// </summary>
    public int? DELIVERY_PRICE { get; set; }

    public int? DELIVERY_METHOD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELIVERY_PAY { get; set; }

    /// <summary>
    /// 배송 메모
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? DELIVERY_INFO { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? receivecode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? receiveShopname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_MEMO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? savepack_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? savepack_admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNewCopy { get; set; }

    /// <summary>
    /// 국가코드
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? nt_code { get; set; }
}

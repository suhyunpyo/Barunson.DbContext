using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 배송정보
/// </summary>
[PrimaryKey("ORDER_SEQ", "DELIVERY_SEQ")]
public partial class DELIVERY_INFO
{
    public int ID { get; set; }

    [Key]
    public int ORDER_SEQ { get; set; }

    [Key]
    public int DELIVERY_SEQ { get; set; }

    /// <summary>
    /// 수취인 이름
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? NAME { get; set; }

    /// <summary>
    /// 수취인 이메일(사용안함)
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    /// <summary>
    /// 수취인 전화번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? PHONE { get; set; }

    /// <summary>
    /// 수취인 핸드폰 번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    /// <summary>
    /// 배달지 우편번호
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? ZIP { get; set; }

    /// <summary>
    /// 배달지 주소
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? ADDR { get; set; }

    /// <summary>
    /// 배달지 상세주소
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? ADDR_DETAIL { get; set; }

    /// <summary>
    /// 포장일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? PACKING_DATE { get; set; }

    /// <summary>
    /// 발송일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    /// <summary>
    /// 택배사 코드(HJ:한진택배,CJ:CJ택배)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? DELIVERY_COM { get; set; }

    /// <summary>
    /// 포장 담당자
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? PACKING_ADMIN_ID { get; set; }

    public int? DELIVERY_PRICE { get; set; }

    /// <summary>
    /// 1:택배,2:퀵,3:방문
    /// </summary>
    public int? DELIVERY_METHOD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELIVERY_PAY { get; set; }

    /// <summary>
    /// 배송 메시지
    /// </summary>
    [Column("DELIVERY_INFO")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DELIVERY_INFO1 { get; set; }

    /// <summary>
    /// 지시서 검증일(아직 사용안함)
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? receivecode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? receiveShopname { get; set; }

    /// <summary>
    /// 배송관련 관리자 메모
    /// </summary>
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
    /// 국가코드(KOR:한국,USA:미국)
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? nt_code { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Delivery_Type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? QuickGubun { get; set; }
}

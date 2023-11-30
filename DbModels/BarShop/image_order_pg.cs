using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이미지_주문_결제
/// </summary>
public partial class image_order_pg
{
    /// <summary>
    /// 결제_일련번호
    /// </summary>
    [Key]
    public int io_pg_seq { get; set; }

    /// <summary>
    /// 이미지_주문_번호
    /// </summary>
    [StringLength(18)]
    [Unicode(false)]
    public string io_no { get; set; } = null!;

    /// <summary>
    /// 주문자_이름
    /// </summary>
    [StringLength(50)]
    public string? buyer_name { get; set; }

    /// <summary>
    /// 주문_상품명
    /// </summary>
    [StringLength(20)]
    public string? productinfo { get; set; }

    /// <summary>
    /// 결제_금액
    /// </summary>
    public int? settle_price { get; set; }

    /// <summary>
    /// 결제_유형
    /// </summary>
    public byte? pay_type { get; set; }

    /// <summary>
    /// 결제_상태 (1:결제 2:결제취소 9:결제실패)
    /// </summary>
    public byte pay_status { get; set; }

    /// <summary>
    /// 가맹점_ID
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    /// <summary>
    /// PG_거래ID
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    /// <summary>
    /// 데이콤_거래ID
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }

    /// <summary>
    /// 현금영수증_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? cash_receipt_yn { get; set; }

    /// <summary>
    /// 영수증 url
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? receipt_url { get; set; }

    /// <summary>
    /// 에스크로_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? escrow_yn { get; set; }

    /// <summary>
    /// 할무_개월
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? card_install_month { get; set; }

    /// <summary>
    /// 무이자_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? card_noint_yn { get; set; }

    /// <summary>
    /// 결과_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? pg_resp_code { get; set; }

    /// <summary>
    /// 결과_메세지
    /// </summary>
    [StringLength(512)]
    public string? pg_resp_msg { get; set; }

    /// <summary>
    /// 결제기관_코드
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? finance_code { get; set; }

    /// <summary>
    /// 결제기관_명
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? finance_name { get; set; }

    /// <summary>
    /// 결제기관_승인번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? finance_authnum { get; set; }

    /// <summary>
    /// 결제요청_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? pg_request_date { get; set; }

    /// <summary>
    /// 결제처리_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? pg_result_date { get; set; }

    /// <summary>
    /// 등록_일자
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    /// <summary>
    /// 결제_취소일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? cancel_date { get; set; }

    [InverseProperty("io_pg_seqNavigation")]
    public virtual ICollection<image_order> image_order { get; } = new List<image_order>();
}

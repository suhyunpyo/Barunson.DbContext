using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("order_type", "order_seq", "toss_orderid")]
[Index("toss_orderid", Name = "IX_toss_vaccount_toss_orderid")]
[Index("toss_secret", Name = "IX_toss_vaccount_toss_secret")]
public partial class toss_vaccount
{
    public int vacct_seq { get; set; }

    /// <summary>
    /// 주문구분 (W:청첩장 S:샘플 E:부가상품)
    /// </summary>
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string order_type { get; set; } = null!;

    /// <summary>
    /// 주문번호(주문 구분별)
    /// </summary>
    [Key]
    public int order_seq { get; set; }

    /// <summary>
    /// 거래 검증키
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string toss_secret { get; set; } = null!;

    /// <summary>
    /// 주문번호 (각 주문테이블의 pg_tid)
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string toss_orderid { get; set; } = null!;

    /// <summary>
    /// 입금 예정금액
    /// </summary>
    public int? settle_price { get; set; }

    /// <summary>
    /// 입금만료일
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? due_date { get; set; }

    /// <summary>
    /// 은행명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string bank_name { get; set; } = null!;

    /// <summary>
    /// 계좌번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string vacct_number { get; set; } = null!;

    /// <summary>
    /// 예금주
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string vacct_name { get; set; } = null!;

    /// <summary>
    /// 로그 구분 (1:입급대기 2:입금완료 3:입금실패 4:입금취소)
    /// </summary>
    public byte status { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? upd_date { get; set; }
}

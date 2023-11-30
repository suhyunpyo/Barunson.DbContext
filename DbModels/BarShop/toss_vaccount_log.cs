using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("toss_orderid", Name = "IX_toss_vaccount_log_orderid")]
[Index("toss_secret", Name = "IX_toss_vaccount_log_secret")]
public partial class toss_vaccount_log
{
    /// <summary>
    /// 고유번호
    /// </summary>
    [Key]
    public int log_seq { get; set; }

    /// <summary>
    /// 거래 검증키
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string toss_secret { get; set; } = null!;

    /// <summary>
    /// 주문번호 (각 주문테이블의 pg_tid)
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string toss_orderid { get; set; } = null!;

    /// <summary>
    /// toss 거래 상태값
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string toss_status { get; set; } = null!;

    /// <summary>
    /// toss 거래키
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string toss_trankey { get; set; } = null!;

    /// <summary>
    /// 내부 처리 결과
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? barun_msg { get; set; }

    /// <summary>
    /// webhook 생성일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime toss_created_date { get; set; }

    /// <summary>
    /// 로그 등록일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}

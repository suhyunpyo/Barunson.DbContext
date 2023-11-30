using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class partner_accounts
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 제휴사 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    public DateOnly? start_date { get; set; }

    /// <summary>
    /// 종료일
    /// </summary>
    public DateOnly? end_date { get; set; }

    /// <summary>
    /// 공급가액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int supply_value { get; set; }

    /// <summary>
    /// 부가세
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int vat { get; set; }

    /// <summary>
    /// 정산일
    /// </summary>
    public DateOnly? due_date { get; set; }

    /// <summary>
    /// 비고
    /// </summary>
    [Column(TypeName = "text")]
    public string? memo { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제휴 인쇄cdr 파일 관리
/// </summary>
public partial class custom_order_files
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string cont_file1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? cont_file2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cont_file3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cont_file4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? env_file1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? env_file2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? env_file3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? env_file4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? env_file5 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime regdate { get; set; }
}

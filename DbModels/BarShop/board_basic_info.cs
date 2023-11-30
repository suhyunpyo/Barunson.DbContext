using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 게시판기본정보
/// </summary>
[Keyless]
public partial class board_basic_info
{
    public int Idx { get; set; }

    [StringLength(20)]
    public string? siteid { get; set; }

    public int? type { get; set; }

    public int? theme { get; set; }

    [StringLength(50)]
    public string? title { get; set; }

    [StringLength(200)]
    public string? helper { get; set; }

    public int? write { get; set; }

    public int? view { get; set; }

    [StringLength(10)]
    public string? writer_view { get; set; }

    [StringLength(1)]
    public string? status { get; set; }

    [StringLength(20)]
    public string? admin_name { get; set; }

    [StringLength(1)]
    public string? reply { get; set; }

    public int? reply_level { get; set; }

    [StringLength(1)]
    public string? answer { get; set; }

    public int? answer_level { get; set; }

    [StringLength(1)]
    public string? pwd { get; set; }

    [StringLength(1)]
    public string? editor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? editdate { get; set; }
}

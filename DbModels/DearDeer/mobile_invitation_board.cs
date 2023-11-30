using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 모바일청첩장 게시판
/// </summary>
[Index("board_key", Name = "mobile_invitation_board_board_key_index")]
[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class mobile_invitation_board
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(50)]
    public string board_key { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int parent_id { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [StringLength(255)]
    public string? passwd { get; set; }

    [Column(TypeName = "mediumtext")]
    public string? contents { get; set; }

    [StringLength(255)]
    public string? attached { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}

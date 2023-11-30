using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 노티 리스트
/// </summary>
[Index("notifiable_id", "notifiable_type", Name = "notifications_notifiable_id_notifiable_type_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class notifications
{
    [Key]
    public Guid id { get; set; }

    [StringLength(50)]
    public string type { get; set; } = null!;

    [Column(TypeName = "int(10) unsigned")]
    public uint notifiable_id { get; set; }

    [StringLength(30)]
    public string notifiable_type { get; set; } = null!;

    [Column(TypeName = "text")]
    public string data { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? read_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}

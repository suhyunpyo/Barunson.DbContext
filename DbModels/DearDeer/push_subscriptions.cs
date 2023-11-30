using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 노티피케이션(사용안함)
/// </summary>
[Index("endpoint", Name = "push_subscriptions_endpoint_unique", IsUnique = true)]
[Index("user_id", Name = "push_subscriptions_user_id_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class push_subscriptions
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    [StringLength(255)]
    public string endpoint { get; set; } = null!;

    [StringLength(255)]
    public string? public_key { get; set; }

    [StringLength(255)]
    public string? auth_token { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [ForeignKey("user_id")]
    [InverseProperty("push_subscriptions")]
    public virtual users user { get; set; } = null!;
}

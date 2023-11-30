using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("WeddingNewsIdx", "RegDate")]
public partial class WeddingNewsResultLog
{
    [Key]
    public int WeddingNewsIdx { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [StringLength(1)]
    public string? Status { get; set; }

    [StringLength(150)]
    public string? Title { get; set; }

    [StringLength(300)]
    public string? Url { get; set; }

    [StringLength(1)]
    public string? RejectCommentType { get; set; }

    public string? RejectComment { get; set; }

    public string? Content { get; set; }
}

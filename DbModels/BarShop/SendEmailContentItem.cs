using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("ContentId", "ContentKey")]
public partial class SendEmailContentItem
{
    [Key]
    public int ContentId { get; set; }

    [Key]
    [StringLength(100)]
    public string ContentKey { get; set; } = null!;

    public string? ContentValue { get; set; }

    [ForeignKey("ContentId")]
    [InverseProperty("SendEmailContentItem")]
    public virtual SendEmailContent Content { get; set; } = null!;
}

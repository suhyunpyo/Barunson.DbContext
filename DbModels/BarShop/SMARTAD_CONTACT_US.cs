using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 1:1문의
/// </summary>
public partial class SMARTAD_CONTACT_US
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    public string? USER_NAME { get; set; }

    [StringLength(50)]
    public string? USER_HPHONE { get; set; }

    [StringLength(100)]
    public string? USER_EMAIL { get; set; }

    [StringLength(2000)]
    public string? USER_CONTENTS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}

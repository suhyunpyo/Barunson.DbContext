using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할인율 삭제 히스토리
/// </summary>
[Keyless]
public partial class Discount_Delete_Admin_Log
{
    public int SEQ { get; set; }

    [StringLength(50)]
    public string? ADMIN_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELETE_DATE { get; set; }

    public int DISCOUNT_SEQ { get; set; }
}

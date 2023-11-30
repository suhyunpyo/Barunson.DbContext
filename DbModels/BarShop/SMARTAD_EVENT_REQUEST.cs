using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 지문방명록 이벤트 수정요청(초안)
/// </summary>
public partial class SMARTAD_EVENT_REQUEST
{
    [Key]
    public int REQUEST_SEQ { get; set; }

    public int AD_EVENT_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REQUEST_DATE { get; set; }

    [StringLength(2000)]
    public string? REQUEST_MSG { get; set; }
}

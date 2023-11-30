using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 이벤트-쿠폰 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class event_boards_coupons
{
    /// <summary>
    /// event_boards.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint event_boards_id { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint coupons_id { get; set; }
}

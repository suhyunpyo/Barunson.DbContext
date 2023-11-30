using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 재고-인쇄규격 릴레이션(사용안함)
/// </summary>
[Keyless]
[Index("item_stock_manage_id", Name = "item_stock_manage_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class item_stock_manage_item_typeset
{
    /// <summary>
    /// item_stock_manage.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint item_stock_manage_id { get; set; }

    /// <summary>
    /// item_typeset.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint item_typeset_id { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class product_sweetday
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 상품 id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint sweetday_id { get; set; }

    /// <summary>
    /// 상품 id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }

    /// <summary>
    /// 상품 sort
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint sort_order { get; set; }
}

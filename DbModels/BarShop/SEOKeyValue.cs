using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("SeoSeq", "KeyValue")]
public partial class SEOKeyValue
{
    /// <summary>
    /// 고유번호
    /// </summary>
    [Key]
    public int SeoSeq { get; set; }

    /// <summary>
    /// SEOInfo의 KeyValueString값을 Split한 값
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string KeyValue { get; set; } = null!;
}

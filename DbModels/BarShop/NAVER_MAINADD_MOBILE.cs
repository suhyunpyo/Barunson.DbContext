using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class NAVER_MAINADD_MOBILE
{
    [StringLength(50)]
    [Unicode(false)]
    public string GUID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }
}

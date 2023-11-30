using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드카테고리
/// </summary>
public partial class CARD_CATE
{
    [Key]
    [Column("card_cate")]
    [StringLength(2)]
    [Unicode(false)]
    public string card_cate1 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string card_cate_name { get; set; } = null!;
}

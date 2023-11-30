using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_MD_Choice_weeklyhotdeal
{
    /// <summary>
    /// 유일값
    /// </summary>
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// MD 상품 유일값
    /// </summary>
    public int choice_seq { get; set; }

    /// <summary>
    /// 핫딜가격
    /// </summary>
    public int? hotdeal_price { get; set; }
}

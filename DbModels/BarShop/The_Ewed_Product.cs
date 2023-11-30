using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Ewed_Product
{
    [Key]
    public int Product_ID { get; set; }

    /// <summary>
    /// W:청첩장 , V:초대장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Product_Div { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    public int? Price { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column(TypeName = "text")]
    public string? Content { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Designer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Url { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Samp_FileName { get; set; }

    public short? Product_Number { get; set; }

    public bool? State { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sales_Gubun { get; set; }
}

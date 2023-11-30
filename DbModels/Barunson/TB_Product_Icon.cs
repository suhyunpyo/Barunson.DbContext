using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 상품_아이콘
/// </summary>
[PrimaryKey("Product_ID", "Icon_ID")]
public partial class TB_Product_Icon
{
    /// <summary>
    /// 상품_ID
    /// </summary>
    [Key]
    public int Product_ID { get; set; }

    /// <summary>
    /// 아이콘_ID
    /// </summary>
    [Key]
    public int Icon_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [ForeignKey("Icon_ID")]
    [InverseProperty("TB_Product_Icon")]
    public virtual TB_Icon Icon { get; set; } = null!;

    [ForeignKey("Product_ID")]
    [InverseProperty("TB_Product_Icon")]
    public virtual TB_Product Product { get; set; } = null!;
}

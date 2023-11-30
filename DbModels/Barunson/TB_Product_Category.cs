using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 상품_분류
/// </summary>
[PrimaryKey("Category_ID", "Product_ID")]
public partial class TB_Product_Category
{
    /// <summary>
    /// 분류_ID
    /// </summary>
    [Key]
    public int Category_ID { get; set; }

    /// <summary>
    /// 상품_ID
    /// </summary>
    [Key]
    public int Product_ID { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    public int? Sort { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

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

    [ForeignKey("Product_ID")]
    [InverseProperty("TB_Product_Category")]
    public virtual TB_Product Product { get; set; } = null!;
}

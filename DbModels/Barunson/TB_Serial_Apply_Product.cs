﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[PrimaryKey("Product_Apply_ID", "Product_Code")]
public partial class TB_Serial_Apply_Product
{
    /// <summary>
    /// 상품_적용_ID
    /// </summary>
    [Key]
    public int Product_Apply_ID { get; set; }

    /// <summary>
    /// 상품_코드
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Product_Code { get; set; } = null!;

    [ForeignKey("Product_Apply_ID")]
    [InverseProperty("TB_Serial_Apply_Product")]
    public virtual TB_Serial_Coupon_Apply_Product Product_Apply { get; set; } = null!;
}

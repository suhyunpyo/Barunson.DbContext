﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 주문_쿠폰_사용
/// </summary>
public partial class TB_Order_Serial_Coupon_Use
{
    /// <summary>
    /// 주문_ID
    /// </summary>
    [Key]
    public int Order_ID { get; set; }

    /// <summary>
    /// 쿠폰_발행_ID
    /// </summary>
    public int? Coupon_Publish_ID { get; set; }

    /// <summary>
    /// 할인_금액
    /// </summary>
    public int? Discount_Price { get; set; }

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

    [ForeignKey("Coupon_Publish_ID")]
    [InverseProperty("TB_Order_Serial_Coupon_Use")]
    public virtual TB_Serial_Coupon_Publish? Coupon_Publish { get; set; }

    [ForeignKey("Order_ID")]
    [InverseProperty("TB_Order_Serial_Coupon_Use")]
    public virtual TB_Order Order { get; set; } = null!;
}

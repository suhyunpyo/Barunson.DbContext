using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

public partial class TB_Serial_Coupon_Publish
{
    /// <summary>
    /// 쿠폰_발행_ID
    /// </summary>
    [Key]
    public int Coupon_Publish_ID { get; set; }

    /// <summary>
    /// 쿠폰_ID
    /// </summary>
    public int Coupon_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Coupon_Number { get; set; } = null!;

    /// <summary>
    /// 사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? User_ID { get; set; }

    /// <summary>
    /// 사용_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Use_YN { get; set; }

    /// <summary>
    /// 사용_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Use_DateTime { get; set; }

    /// <summary>
    /// 만료_일자
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? Expiration_Date { get; set; }

    /// <summary>
    /// 회수_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Retrieve_DateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Assign_DateTime { get; set; }

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

    [ForeignKey("Coupon_ID")]
    [InverseProperty("TB_Serial_Coupon_Publish")]
    public virtual TB_Serial_Coupon Coupon { get; set; } = null!;

    [InverseProperty("Coupon_Publish")]
    public virtual ICollection<TB_Order_Serial_Coupon_Use> TB_Order_Serial_Coupon_Use { get; } = new List<TB_Order_Serial_Coupon_Use>();
}

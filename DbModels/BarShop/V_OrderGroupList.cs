using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class V_OrderGroupList
{
    public int? CompanySeq { get; set; }

    public int OrderSeq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PayType { get; set; }

    public int? StatusSeq { get; set; }

    public int SettlePrice { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string MemberID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? OrderName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Hp { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Method { get; set; }

    public int? status { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? payDate { get; set; }

    public int? orderPrice { get; set; }

    public int? totalPrice { get; set; }

    public int? deliveryPrice { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? bankInfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? depositor { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? deliveryName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? deliveryDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? deliveryNo { get; set; }

    public int? deliveryMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? deliveryPhone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? deliveryHp { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? deliveryZip { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? deliveryAddr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? deliveryAddrDetail { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? deliveryCountry { get; set; }

    public int? Wed_Order_Seq { get; set; }

    public int? Wed_Order_Seq_CNT { get; set; }

    public int? Order_Seq { get; set; }
}

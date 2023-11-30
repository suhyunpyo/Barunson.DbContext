using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("ORDER_SEQ", Name = "ix_delivery_info_backup_order_seq")]
public partial class delivery_info_backup
{
    public int ID { get; set; }

    public int ORDER_SEQ { get; set; }

    public int DELIVERY_SEQ { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PHONE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ZIP { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ADDR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ADDR_DETAIL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PACKING_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? DELIVERY_COM { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PACKING_ADMIN_ID { get; set; }

    public int? DELIVERY_PRICE { get; set; }

    public int? DELIVERY_METHOD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELIVERY_PAY { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DELIVERY_INFO { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? receivecode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? receiveShopname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_MEMO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? savepack_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? savepack_admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNewCopy { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? nt_code { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Delivery_Type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? QuickGubun { get; set; }
}

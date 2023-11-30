using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class OUTLET_ORDER
{
    [Key]
    public int ORDER_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? ORDER_TYPE { get; set; }

    public int? ORDER_COUNT { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? ORDER_UID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BUYER_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BUYER_EMAIL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BUYER_PHONE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? BUYER_ZIP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BUYER_ADDRESS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BUYER_HPHONE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RECV_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RECV_PHONE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RECV_HPHONE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? RECV_ZIP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RECV_ADDRESS { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? BUYER_COMMENT { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ORDER_DATE { get; set; }

    public int STATUS_SEQ { get; set; }

    public byte? PROCLEVEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PG_AUTH_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_AUTH_CODE { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PG_RESULT_MSG { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PG_RESULT_CODE { get; set; }

    public int? SETTLE_PRICE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SETTLE_METHOD { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SETTLE_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PAY_DATE { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? TID { get; set; }

    public int? BANK_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BANK_RECEIPTER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RECV_EMAIL { get; set; }

    public int? ORDER_TOTAL_PRICE { get; set; }

    public int? REDUCE_PRICE { get; set; }

    public int? BUYER_DELIVERY_PRICE { get; set; }

    public int? ORDER_PRICE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DELIVERY_MEMO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DELIVERY_METHOD { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ADMIN_ID { get; set; }

    public double? ORDER_DISCOUNT_RATE { get; set; }

    public double? ORDER_MDISCOUNT_RATE { get; set; }

    public int? FEE_PRICE { get; set; }

    public int? POST_PRICE { get; set; }

    public int? PG_SETTLE_PRICE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SETTLE_MOBILID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? COUPONSEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BANK_VACCOUNT_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELETE_DATE { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DELETE_ADMIN_ID { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SRC_CONFIRM_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PREPARE_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SRC_ERP_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CANCEL_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CANCEL_REASON { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ADMIN_MEMO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDACOM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_MertId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SRC_COMPOSE_DATE { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SRC_COMPOSE_ADMIN_ID { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SRC_PRINTW_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SRC_PRINT_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_paydate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_caldate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_repaydate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_recaldate { get; set; }

    public double? pg_fee { get; set; }

    public double? pg_refee { get; set; }

    public int? option_price { get; set; }
}

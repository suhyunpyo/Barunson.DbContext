using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class OUTSOURCING_ORDER_MST
{
    [Key]
    public int OUTSOURCING_ORDER_SEQ { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ORDER_STATUS_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ORDER_TYPE_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ORDER_SUB_TYPE_CODE { get; set; }

    public int? ORDER_SEQ { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? SITE_TYPE_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ERP_PART_TYPE_CODE { get; set; }

    [StringLength(100)]
    public string? CARD_CODE { get; set; }

    [StringLength(100)]
    public string? ORDER_NAME { get; set; }

    public int? ORDER_QTY { get; set; }

    [StringLength(200)]
    public string? PAPER_TYPE_NAME { get; set; }

    [StringLength(200)]
    public string? PAPER_SIZE { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? PAGES_PER_SHEET_VALUE { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? PRINT_LOSS_VALUE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BOTH_SIDE_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? OSI_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CUTOUT_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GLOSSY_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PRESS_YORN { get; set; }

    [StringLength(50)]
    public string? FOIL_TYPE_NAME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? LASER_CUT_YORN { get; set; }

    [StringLength(100)]
    public string? REQUESTOR_NAME { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? COMPANY_TYPE_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? DELIVERY_TYPE_CODE { get; set; }

    [StringLength(1000)]
    public string? PRINT_FILE_URL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IMAGE_FILE_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECEIPT_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1000)]
    public string? MEMO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EXPECT_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EDGE_YORN { get; set; }

    [StringLength(30)]
    public string? EDGE_COLOR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PRINT_CHASU { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DEV_FLAG { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? MEMO_EX { get; set; }
}

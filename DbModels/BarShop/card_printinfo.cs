using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제퓸별 인쇄(병합)정보
/// </summary>
[PrimaryKey("print_type", "card_code")]
public partial class card_printinfo
{
    /// <summary>
    /// 제품 타입(C/I/G/P/E)
    /// </summary>
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string print_type { get; set; } = null!;

    /// <summary>
    /// 카드 코드
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int blank_space { get; set; }

    /// <summary>
    /// 포인트 X값
    /// </summary>
    public int print_sizeW { get; set; }

    /// <summary>
    /// 포인트 Y값
    /// </summary>
    public int print_sizeH { get; set; }

    public int id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? print_group { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDigital { get; set; }

    public short? rotate { get; set; }

    public short? print_panW { get; set; }

    public short? print_panH { get; set; }

    public short? offset_top { get; set; }

    public short? offset_left { get; set; }

    public short? offset_midW { get; set; }

    public short? offset_midH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBarcode { get; set; }

    public short? backimg_offset_top { get; set; }

    public short? backimg_offset_left { get; set; }

    public short? backimg_offset_midW { get; set; }

    public short? backimg_offset_midH { get; set; }

    /// <summary>
    /// 1이면 절단선 삽입
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isBackImg { get; set; }

    /// <summary>
    /// 1이면 양면인쇄
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isDPrint { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BOTH_SIDE_YORN { get; set; }

    /// <summary>
    /// 1이면 회전각 사용, 그 외의 경우 가로가 길 경우만 회전각 사용
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? rotate_type { get; set; }

    /// <summary>
    /// 사내 인쇄소(0:기본 마스터, 1:기본내지,2:디지털인쇄실)
    /// </summary>
    public short? printer_group { get; set; }

    public int? F_blank_space { get; set; }

    public int? F_print_sizeW { get; set; }

    public int? F_print_sizeH { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? F_print_group { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? F_isDigital { get; set; }

    public short? F_rotate { get; set; }

    public short? F_print_panW { get; set; }

    public short? F_print_panH { get; set; }

    public short? F_offset_top { get; set; }

    public short? F_offset_left { get; set; }

    public short? F_offset_midW { get; set; }

    public short? F_offset_midH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? F_isBarcode { get; set; }

    public short? F_backimg_offset_top { get; set; }

    public short? F_backimg_offset_left { get; set; }

    public short? F_backimg_offset_midW { get; set; }

    public short? F_backimg_offset_midH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? F_isBackImg { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? F_isDPrint { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? F_rotate_type { get; set; }

    public short? F_printer_group { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBothSidePrinterYN { get; set; }
}

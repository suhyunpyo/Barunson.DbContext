using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이미지_주문_항목
/// </summary>
public partial class image_order_item
{
    /// <summary>
    /// 항목_고유번호
    /// </summary>
    [Key]
    public int io_item_seq { get; set; }

    /// <summary>
    /// 이미지_주문_고유번호
    /// </summary>
    public int io_seq { get; set; }

    /// <summary>
    /// 주문_항목_구분 (1:고급사진보정 2:스피드보정)
    /// </summary>
    public byte? item_type { get; set; }

    /// <summary>
    /// 주문_수량
    /// </summary>
    public int? item_count { get; set; }

    /// <summary>
    /// 주문_단위_금액
    /// </summary>
    public int? item_unit_price { get; set; }

    /// <summary>
    /// 주문_금액
    /// </summary>
    public int? item_price { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [ForeignKey("io_seq")]
    [InverseProperty("image_order_item")]
    public virtual image_order io_seqNavigation { get; set; } = null!;
}

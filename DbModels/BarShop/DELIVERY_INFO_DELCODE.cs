using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("delivery_id", "delivery_code_num")]
[Index("delivery_code_num", Name = "IX_DELIVERY_INFO_DELCODE_code_num")]
[Index("order_seq", Name = "IX_DELIVERY_INFO_DELCODE_order_seq")]
public partial class DELIVERY_INFO_DELCODE
{
    public int order_seq { get; set; }

    [Key]
    public int delivery_id { get; set; }

    /// <summary>
    /// 송장코드
    /// </summary>
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string delivery_code_num { get; set; } = null!;

    /// <summary>
    /// 택배사 코드(HJ:한진택배,CJ:CJ택배)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string delivery_com { get; set; } = null!;

    public int id { get; set; }

    /// <summary>
    /// 한진택배 전송 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isHJ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELCODE_REG_DATE { get; set; }
}

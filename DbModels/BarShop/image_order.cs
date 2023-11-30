using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이미지_주문
/// </summary>
public partial class image_order
{
    /// <summary>
    /// 이미지_주문_고유번호
    /// </summary>
    [Key]
    public int io_seq { get; set; }

    /// <summary>
    /// 이미지_주문_번호
    /// </summary>
    [StringLength(18)]
    [Unicode(false)]
    public string? io_no { get; set; }

    /// <summary>
    /// 결제_일련번호
    /// </summary>
    public int? io_pg_seq { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    /// <summary>
    /// 주문_금액
    /// </summary>
    public int? order_price { get; set; }

    /// <summary>
    /// 결제_금액
    /// </summary>
    public int? settle_price { get; set; }

    /// <summary>
    /// 주문자명
    /// </summary>
    [StringLength(50)]
    public string? order_name { get; set; }

    /// <summary>
    /// 유선전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    /// <summary>
    /// 휴대전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? order_email { get; set; }

    /// <summary>
    /// 주문_상태 (1:주문 2:결제완료 3:결제취소 9:결제실패)
    /// </summary>
    public byte order_status { get; set; }

    public byte order_device { get; set; }

    /// <summary>
    /// 주문_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [InverseProperty("io_seqNavigation")]
    public virtual ICollection<image_order_item> image_order_item { get; } = new List<image_order_item>();

    [ForeignKey("io_pg_seq")]
    [InverseProperty("image_order")]
    public virtual image_order_pg? io_pg_seqNavigation { get; set; }
}

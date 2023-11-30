using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Order_Seq", "Company_Seq")]
public partial class S2_eCardOrder
{
    [Key]
    public int Order_Seq { get; set; }

    [Key]
    public int Company_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Addr { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? GroomName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BrideName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? event_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_Day { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? event_weekname { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? event_ampm { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? event_hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_minute { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WeddingHall { get; set; }

    public int? Wedding_Seq { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? XmlBackgroundData { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? xmlBackgroundModiDate { get; set; }

    [Column(TypeName = "text")]
    public string? XmlMovieData { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? XmlMovieModiDate { get; set; }

    [Column(TypeName = "text")]
    public string? XmlPictureData { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? XmlPictureModiDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOpen { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Skin_Seq { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? UploadImageURL { get; set; }

    /// <summary>
    /// 2:주문완료
    /// </summary>
    public byte? status_seq { get; set; }

    public byte? settle_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    public int? settle_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? settle_cancel_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pg_resultinfo2 { get; set; }

    public double? pg_fee { get; set; }

    /// <summary>
    /// 0:삭제, 1:사용
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? order_state { get; set; }

    public int? worder_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? weddinghall_type { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }
}

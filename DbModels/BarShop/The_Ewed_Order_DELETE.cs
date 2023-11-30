using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Ewed_Order_DELETE
{
    [Key]
    public int Order_ID { get; set; }

    public int? Order_Seq { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Event_Year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Event_Month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Event_Day { get; set; }

    [StringLength(1)]
    public string? Event_WeekName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Event_AmPm { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Event_Hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Event_Minute { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Groom_Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Bride_Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Wedd_Name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Wedd_Place { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Wedd_Addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Wedd_Phone { get; set; }

    public int? Wedd_IDX { get; set; }

    public int? BGM_ID { get; set; }

    public int? ProductID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Wedd_Url { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGM_FileName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_result { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_cancel_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    public int? settle_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

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

    public byte? settle_status { get; set; }

    public int? status_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    public bool? State { get; set; }

    public int Visit_cnt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ac_State { get; set; }
}

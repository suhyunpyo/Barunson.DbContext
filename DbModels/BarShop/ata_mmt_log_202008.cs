using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("date_client_req", "recipient_num", Name = "idx_ata_mmt_log_202008_1")]
[Index("date_mt_report", "report_code", Name = "idx_ata_mmt_log_202008_2")]
[Index("msg_status", Name = "idx_ata_mmt_log_202008_3")]
[Index("sender_key", "template_code", Name = "idx_ata_mmt_log_202008_4")]
public partial class ata_mmt_log_202008
{
    [Key]
    public int mt_pr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mt_refkey { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string priority { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date_client_req { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string subject { get; set; } = null!;

    [StringLength(4000)]
    [Unicode(false)]
    public string content { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string callback { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string msg_status { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? recipient_num { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_mt_sent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_rslt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_mt_report { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? report_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? rs_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string country_code { get; set; } = null!;

    public int msg_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? crypto_yn { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ata_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date_tran { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string sender_key { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? template_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string response_method { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ad_flag { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? kko_btn_type { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? kko_btn_info { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? img_url { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? img_link { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? etc_text_1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? etc_text_2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? etc_text_3 { get; set; }

    public int? etc_num_1 { get; set; }

    public int? etc_num_2 { get; set; }

    public int? etc_num_3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? etc_date_1 { get; set; }
}

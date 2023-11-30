using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문 봉투입력정보
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_item_id", Name = "order_item_id")]
[Index("order_item_no", Name = "order_item_no")]
[Index("order_no", Name = "order_no")]
[Index("user_id", Name = "user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_card_envelopes
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint env_idx { get; set; }

    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_card_base_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int item_cnt { get; set; }

    [StringLength(30)]
    public string? order_no { get; set; }

    [StringLength(30)]
    public string? order_item_no { get; set; }

    [StringLength(30)]
    public string? item_code { get; set; }

    [StringLength(30)]
    public string? item_name { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_id { get; set; }

    [StringLength(10)]
    public string? env_type { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? is_not_print_env { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? env_zip1 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? env_zip2 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? env_zip3 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? env_zip4 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? env_zip5 { get; set; }

    [Column(TypeName = "int(11)")]
    public int? order_zipcode { get; set; }

    [StringLength(255)]
    public string? env_addr { get; set; }

    [StringLength(255)]
    public string? env_addr_detail { get; set; }

    [StringLength(20)]
    public string? env_phone { get; set; }

    [StringLength(20)]
    public string? env_hphone1 { get; set; }

    [StringLength(20)]
    public string? env_hphone2 { get; set; }

    [StringLength(20)]
    public string? env_person1_header { get; set; }

    [StringLength(20)]
    public string? env_person2_header { get; set; }

    [Column(TypeName = "int(11)")]
    public int? isenv_person_tail { get; set; }

    [StringLength(50)]
    public string? env_person_tail { get; set; }

    [StringLength(50)]
    public string? env_person1 { get; set; }

    [StringLength(50)]
    public string? env_person1_tail { get; set; }

    [StringLength(50)]
    public string? env_person2 { get; set; }

    [StringLength(50)]
    public string? env_person2_tail { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? iscopy_env { get; set; }

    [StringLength(1)]
    public string is_post_mark { get; set; } = null!;

    [StringLength(1)]
    public string is_patternless { get; set; } = null!;

    [StringLength(50)]
    public string? post_name { get; set; }

    [StringLength(50)]
    public string? post_name_tail { get; set; }

    [StringLength(10)]
    public string? post_mark_tail { get; set; }

    [StringLength(20)]
    public string recv_tail { get; set; } = null!;

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_zip_box { get; set; }
}

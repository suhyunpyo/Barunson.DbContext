using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_SampleList
{
    public int COMPANY_SEQ { get; set; }

    public int sample_order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MEMBER_NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_EMAIL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_FAX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_PHONE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string MEMBER_ZIP { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string MEMBER_ADDRESS { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string member_address_detail { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string MEMO { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_HPHONE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string old_code { get; set; } = null!;
}

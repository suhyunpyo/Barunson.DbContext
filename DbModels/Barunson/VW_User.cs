using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class VW_User
{
    [StringLength(50)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string? PHONE_NUMBER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NAME { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string? CELLPHONE_NUMBER { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? WEDDING_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? WEDDINGCARD_ORDER_YN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime JOIN_DATETIME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EMAIL { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string REGIST_USER_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REGIST_DATETIME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string REGIST_IP { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string UPDATE_USER_ID { get; set; } = null!;

    public int? UPDATE_DATETIME { get; set; }

    public int? UPDATE_IP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DELETE_USER_ID { get; set; } = null!;

    public int? DELETE_DATETIME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DELETE_IP { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string? DUPINFO { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PWD { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? REFERER_SALES_GUBUN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CARD_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INTEGRATION_MEMBER_YORN { get; set; }
}

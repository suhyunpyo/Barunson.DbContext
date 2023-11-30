using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CUSTOM_PRIVATE_CHOICE
{
    [StringLength(16)]
    [Unicode(false)]
    public string MEMBER_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }

    public int CARD_SEQ { get; set; }

    /// <summary>
    /// W:청첩장,E:E청첩장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string CARD_TYPE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Daum_uid { get; set; }
}

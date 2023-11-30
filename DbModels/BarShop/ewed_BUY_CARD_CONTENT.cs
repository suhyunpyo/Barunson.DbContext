using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_BUY_CARD_CONTENT
{
    [Key]
    public int buy_card_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? buy_GROOM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? buy_BRIDE { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? buy_YEAR { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? buy_MONTH { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? buy_DAY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? buy_WEEK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? buy_AMPM { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? buy_HOUR { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? buy_MINUTE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? buy_LUNAR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? buy_PLACE { get; set; }

    [Column(TypeName = "text")]
    public string? buy_MENT { get; set; }

    [Column(TypeName = "text")]
    public string? buy_MENT2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? place_file_insert { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? place_file_path { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? place_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? place_addr { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? place_phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? we_file_path { get; set; }

    [Column(TypeName = "text")]
    public string? man_description { get; set; }

    [Column(TypeName = "text")]
    public string? woman_description { get; set; }

    [Column(TypeName = "text")]
    public string? we_meet { get; set; }

    [Column(TypeName = "text")]
    public string? resolution { get; set; }

    [ForeignKey("buy_card_SEQ")]
    [InverseProperty("ewed_BUY_CARD_CONTENT")]
    public virtual ewed_BUY_CARD buy_card_SEQNavigation { get; set; } = null!;
}

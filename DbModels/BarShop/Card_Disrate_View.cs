using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Card_Disrate_View
{
    public int? card_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? card_group { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? display_yes_or_no { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num50 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num100 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num150 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num200 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num250 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num300 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num350 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num400 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num450 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num500 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num550 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num600 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num650 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num700 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num800 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num900 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? num1000 { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class t_card
{
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_num { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? wedding_day { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? location { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? map { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? music { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_1 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_2 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_3 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_4 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_5 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_6 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_7 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_8 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_9 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_10 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_11 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_12 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_13 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_14 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_15 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_16 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_17 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_18 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_19 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_20 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_21 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_22 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_23 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_24 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_25 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_26 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_27 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_28 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_29 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_30 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_31 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_32 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_33 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_34 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_35 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_36 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_37 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_38 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_39 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_40 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_41 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_42 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_43 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_44 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_45 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_46 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_47 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? photo_48 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_3 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_4 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_5 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_6 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_7 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_8 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_9 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_10 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_11 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_12 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_13 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_14 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_15 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_16 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_17 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_18 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_19 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_20 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_21 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_22 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_23 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_24 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_25 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_26 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_27 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_28 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_29 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_30 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_31 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_32 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_33 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_34 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_35 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_36 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_37 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_38 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_39 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_40 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_41 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_42 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_43 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_44 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_45 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_46 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_47 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? effect_48 { get; set; }

    public int? totalphoto { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? folderday { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bg { get; set; }

    public int? xp { get; set; }
}

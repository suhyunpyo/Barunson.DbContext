using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_product
{
    [StringLength(20)]
    [Unicode(false)]
    public string? brand { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? new_old { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_info1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_info2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_map { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? name { get; set; }

    public int? price { get; set; }

    public int? price_1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? env { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? env_gr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? inp { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? inp_gr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? acc1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? acc1_gr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? acc2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? acc2_gr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? lining { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? lining_gr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? mat { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? size { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? folding { get; set; }

    [StringLength(10)]
    public string? gubun_1 { get; set; }

    [StringLength(10)]
    public string? gubun_2 { get; set; }

    [StringLength(10)]
    public string? gubun_3 { get; set; }

    [StringLength(10)]
    public string? gubun_4 { get; set; }

    [StringLength(10)]
    public string? gubun_5 { get; set; }

    [StringLength(10)]
    public string? gubun_6 { get; set; }

    [StringLength(10)]
    public string? gubun_7 { get; set; }

    [StringLength(10)]
    public string? gubun_8 { get; set; }

    [StringLength(10)]
    public string? gubun_9 { get; set; }

    [StringLength(10)]
    public string? gubun_10 { get; set; }

    [StringLength(10)]
    public string? option_1 { get; set; }

    [StringLength(10)]
    public string? option_2 { get; set; }

    [StringLength(10)]
    public string? option_3 { get; set; }

    [StringLength(10)]
    public string? option_4 { get; set; }

    [StringLength(10)]
    public string? option_5 { get; set; }

    [StringLength(10)]
    public string? option_6 { get; set; }

    [StringLength(10)]
    public string? option_7 { get; set; }

    [StringLength(30)]
    public string? option_8 { get; set; }

    [StringLength(10)]
    public string? option_9 { get; set; }

    [StringLength(10)]
    public string? option_10 { get; set; }

    [StringLength(10)]
    public string? option_11 { get; set; }

    [StringLength(10)]
    public string? option_12 { get; set; }

    [StringLength(10)]
    public string? option_13 { get; set; }

    public short? option_14 { get; set; }

    public short? option_15 { get; set; }

    [StringLength(10)]
    public string? discount { get; set; }

    public short? style_1 { get; set; }

    public short? style_2 { get; set; }

    [StringLength(10)]
    public string? style_3 { get; set; }

    [StringLength(10)]
    public string? style_4 { get; set; }

    [StringLength(10)]
    public string? style_5 { get; set; }

    [StringLength(10)]
    public string? style_6 { get; set; }

    [StringLength(10)]
    public string? style_7 { get; set; }

    [StringLength(10)]
    public string? style_8 { get; set; }

    public short? style_9 { get; set; }

    [StringLength(10)]
    public string? style_10 { get; set; }

    [StringLength(10)]
    public string? style_11 { get; set; }

    [StringLength(10)]
    public string? style_12 { get; set; }

    [StringLength(10)]
    public string? style_13 { get; set; }

    [StringLength(10)]
    public string? style_14 { get; set; }

    [StringLength(10)]
    public string? style_15 { get; set; }

    [StringLength(10)]
    public string? style_16 { get; set; }

    [StringLength(10)]
    public string? jumun_1 { get; set; }

    [StringLength(10)]
    public string? jumun_2 { get; set; }

    [StringLength(10)]
    public string? jumun_3 { get; set; }

    [StringLength(200)]
    public string? jumun_4 { get; set; }

    [StringLength(500)]
    public string? comment { get; set; }
}

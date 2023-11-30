using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("CARD_ChoanBasic", Schema = "invtmng")]
public partial class CARD_ChoanBasic
{
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string card_type { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isOsiGaro { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isReverse { get; set; } = null!;

    public int BlankSpace { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? printGroup { get; set; }

    public short print_size { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBackColor { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isFBackColor { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isBackPoint { get; set; }

    public short? pagesizeW { get; set; }

    public short? pagesizeH { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? guideLineH { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? guideLineV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? osi { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isMapGaro { get; set; }

    public short? text_sx { get; set; }

    public short? text_sy { get; set; }

    public short? text_ex { get; set; }

    public short? text_ey { get; set; }

    public short? map_sx { get; set; }

    public short? map_sy { get; set; }

    public short? map_ex { get; set; }

    public short? map_ey { get; set; }

    public short? traffic_sx { get; set; }

    public short? traffic_sy { get; set; }

    public short? traffic_ex { get; set; }

    public short? traffic_ey { get; set; }

    public short print_sx { get; set; }

    public short print_sy { get; set; }

    public short print_ex { get; set; }

    public short print_ey { get; set; }

    public int? ex_A { get; set; }

    public int? ex_B { get; set; }

    public int? ex_D { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? swf_url { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fswf_url { get; set; }
}

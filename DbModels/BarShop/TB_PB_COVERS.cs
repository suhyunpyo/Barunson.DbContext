using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_PB_COVERS
{
    public int? IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SAMPLE_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? THUMB_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? XML_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? COVER_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SKIN_MAPSET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? P_SAMLE_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? P_THUMB_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? P_XML_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? E_SAMLE_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? E_THUMB_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? E_XML_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PE_YN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SIZE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PAGES { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CATEGORY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? COVERS_NAME { get; set; }

    public int? TB_PRDT_IDX { get; set; }
}

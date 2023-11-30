using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("MST_SEQ", "COMPANY_SEQ")]
public partial class MAIN_POPUP_IMAGE
{
    [Key]
    public int MST_SEQ { get; set; }

    [Key]
    public int COMPANY_SEQ { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PC_IMAGE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PC_IMAGE_URL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? M_IMAGE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? M_IMAGE_URL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISPLAY_YN { get; set; }
}

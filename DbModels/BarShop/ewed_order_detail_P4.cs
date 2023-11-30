using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_detail_P4
{
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album4 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? photo_album_desc1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? photo_album_desc2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? photo_album_desc3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? photo_album_desc4 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? photo_album_desc5 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? etc_contents { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? music_file { get; set; }
}

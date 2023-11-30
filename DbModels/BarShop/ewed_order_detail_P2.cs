using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_detail_P2
{
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo_blur { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? food_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? we_photo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? food { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? we1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? we2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? we3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? we4 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? we5 { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_snalbum1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_snalbum2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_snalbum3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_snalbum4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_snalbum5 { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? hisStory_title { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? hisStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? herStory_title { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? herStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? music_file { get; set; }
}

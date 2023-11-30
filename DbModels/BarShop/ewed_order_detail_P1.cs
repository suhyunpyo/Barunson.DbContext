using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_detail_P1
{
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HisStory_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HisStory_title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? HisStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HerStory_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HerStory_title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? HerStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WeddStory_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WeddStory_title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? WeddStory { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? music_file { get; set; }
}

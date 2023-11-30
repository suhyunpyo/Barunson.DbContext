using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_detail_T
{
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo3 { get; set; }

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
    public string? photo_album6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album9 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album10 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc3 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc4 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc5 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc6 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc7 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc8 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc9 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? photo_album_desc10 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? hisStory_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HisStory_Title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? HisStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HerStory_Photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HerStory_Title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? herStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WeddStory_photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WeddStory_Title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? WeddStory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LoveLetter_title1 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? LoveLetter1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LoveLetter_photo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LoveLetter_Title2 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? LoveLetter2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LoveLetter_photo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_photo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_photo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_photo3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? music_file { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cam_file { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title9 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_album_title10 { get; set; }
}

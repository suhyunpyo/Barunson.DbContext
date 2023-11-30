using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_TmpInvitation
{
    [Key]
    public int InvitationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string InvitationType { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string AuthYN { get; set; } = null!;

    public int SkinID { get; set; }

    [StringLength(30)]
    public string? OrdererName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? OrdererMobile { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? OrdererEmail { get; set; }

    [StringLength(50)]
    public string? InvitationTitle { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MainImage { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CommentYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? HostYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? VideoYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GiftYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GalleryYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GalleryType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GuideYN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegisterTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? OnlineYN { get; set; }

    [StringLength(1000)]
    public string? Greeting { get; set; }

    [StringLength(20)]
    public string? EventTime { get; set; }

    [StringLength(50)]
    public string? LocationName { get; set; }

    [StringLength(100)]
    public string? LocationAddr { get; set; }

    [StringLength(50)]
    public string? LocationDetail { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? LocationMapType { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? LocationMapImage { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? LocationMapLat { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? LocationMapLng { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LocationTel { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? VideoURL { get; set; }

    [StringLength(300)]
    public string? EtcSubway { get; set; }

    [StringLength(300)]
    public string? EtcBus { get; set; }

    [StringLength(300)]
    public string? EtcCar { get; set; }

    [StringLength(300)]
    public string? EtcParking { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RegisterIP { get; set; }

    [StringLength(30)]
    public string? BabyName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BabyBirth { get; set; }

    [StringLength(30)]
    public string? DadName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? DadMobile { get; set; }

    [StringLength(30)]
    public string? MomName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? MomMobile { get; set; }

    [StringLength(30)]
    public string? GroupName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? GroupMobile { get; set; }

    [StringLength(50)]
    public string? GuideName { get; set; }

    [StringLength(200)]
    public string? GuideNote { get; set; }

    [StringLength(30)]
    public string? GroomName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? GroomMobile { get; set; }

    [StringLength(30)]
    public string? BrideName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BrideMobile { get; set; }

    [StringLength(20)]
    public string? GroomHostRel1 { get; set; }

    [StringLength(30)]
    public string? GroomHostName1 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? GroomHostMobile1 { get; set; }

    [StringLength(20)]
    public string? GroomHostRel2 { get; set; }

    [StringLength(30)]
    public string? GroomHostName2 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? GroomHostMobile2 { get; set; }

    [StringLength(20)]
    public string? BrideHostRel1 { get; set; }

    [StringLength(30)]
    public string? BrideHostName1 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BrideHostMobile1 { get; set; }

    [StringLength(20)]
    public string? BrideHostRel2 { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? BrideHostName2 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BrideHostMobile2 { get; set; }

    [StringLength(20)]
    public string? EventDate { get; set; }

    [StringLength(3500)]
    public string? EtcGuide { get; set; }

    [StringLength(4)]
    public string? VideoType { get; set; }

    [StringLength(300)]
    public string? EtcAfter { get; set; }

    [StringLength(300)]
    public string? EtcInfo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PublishYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SmsInvitationYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SmsMypageYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ExpireYN { get; set; }

    [StringLength(20)]
    public string? EventEndTime { get; set; }

    [ForeignKey("SkinID")]
    [InverseProperty("mcard_TmpInvitation")]
    public virtual mcard_Skin Skin { get; set; } = null!;

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_TmpInvitationGiftRel> mcard_TmpInvitationGiftRel { get; } = new List<mcard_TmpInvitationGiftRel>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_TmpInvitationOption> mcard_TmpInvitationOption { get; } = new List<mcard_TmpInvitationOption>();
}

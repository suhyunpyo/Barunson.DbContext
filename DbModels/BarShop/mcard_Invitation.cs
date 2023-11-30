using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장
/// </summary>
[Index("AuthCode", "SiteCode", Name = "IX_mcard_Invitation_AuthCOde_SiteCode")]
public partial class mcard_Invitation
{
    /// <summary>
    /// 초대장일련번호
    /// </summary>
    [Key]
    public int InvitationID { get; set; }

    /// <summary>
    /// 초대장코드(주문번호)
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    /// <summary>
    /// 초대장종류
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string InvitationType { get; set; } = null!;

    /// <summary>
    /// 인증여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string AuthYN { get; set; } = null!;

    /// <summary>
    /// 스킨일련번호
    /// </summary>
    public int SkinID { get; set; }

    /// <summary>
    /// 주문자명
    /// </summary>
    [StringLength(30)]
    public string OrdererName { get; set; } = null!;

    /// <summary>
    /// 주문자연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string OrdererMobile { get; set; } = null!;

    /// <summary>
    /// 주문자이메일
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string OrdererEmail { get; set; } = null!;

    /// <summary>
    /// 초대장제목
    /// </summary>
    [StringLength(250)]
    public string? InvitationTitle { get; set; }

    /// <summary>
    /// 메인(SNS)이미지
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string? MainImage { get; set; }

    /// <summary>
    /// 방명록사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string CommentYN { get; set; } = null!;

    /// <summary>
    /// 혼주정보사용여부(웨딩)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string HostYN { get; set; } = null!;

    /// <summary>
    /// 동영상사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string VideoYN { get; set; } = null!;

    /// <summary>
    /// 선물사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string GiftYN { get; set; } = null!;

    /// <summary>
    /// 갤러리사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? GalleryYN { get; set; }

    /// <summary>
    /// 갤러리종류
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? GalleryType { get; set; }

    /// <summary>
    /// 기타정보사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string GuideYN { get; set; } = null!;

    /// <summary>
    /// 등록시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? RegisterTime { get; set; }

    /// <summary>
    /// 초대장온라인여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string OnlineYN { get; set; } = null!;

    /// <summary>
    /// 인사말
    /// </summary>
    [StringLength(3000)]
    public string? Greeting { get; set; }

    /// <summary>
    /// 행사시간
    /// </summary>
    [StringLength(20)]
    public string EventTime { get; set; } = null!;

    /// <summary>
    /// 행사장명
    /// </summary>
    [StringLength(400)]
    public string? LocationName { get; set; }

    /// <summary>
    /// 행사장주소
    /// </summary>
    [StringLength(400)]
    public string? LocationAddr { get; set; }

    /// <summary>
    /// 행사장상세정보
    /// </summary>
    [StringLength(50)]
    public string LocationDetail { get; set; } = null!;

    /// <summary>
    /// 행사장약도종류
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string LocationMapType { get; set; } = null!;

    /// <summary>
    /// 행사장약도
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? LocationMapImage { get; set; }

    /// <summary>
    /// 행사장좌표Lat
    /// </summary>
    [StringLength(24)]
    [Unicode(false)]
    public string? LocationMapLat { get; set; }

    /// <summary>
    /// 행사장좌표Lng
    /// </summary>
    [StringLength(24)]
    [Unicode(false)]
    public string? LocationMapLng { get; set; }

    /// <summary>
    /// 행사장연락처
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? LocationTel { get; set; }

    /// <summary>
    /// 동영상주소
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? VideoURL { get; set; }

    /// <summary>
    /// 지하철정보
    /// </summary>
    [StringLength(700)]
    public string? EtcSubway { get; set; }

    /// <summary>
    /// 버스정보
    /// </summary>
    [StringLength(3200)]
    public string? EtcBus { get; set; }

    /// <summary>
    /// 자가용정보
    /// </summary>
    [StringLength(700)]
    public string? EtcCar { get; set; }

    /// <summary>
    /// 주차정보
    /// </summary>
    [StringLength(700)]
    public string? EtcParking { get; set; }

    /// <summary>
    /// 마지막수정시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// 등록지IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? RegisterIP { get; set; }

    /// <summary>
    /// 메인이미지용량
    /// </summary>
    public int MainImageSize { get; set; }

    /// <summary>
    /// 메인이미지가로
    /// </summary>
    public int MainImageWidth { get; set; }

    /// <summary>
    /// 메인이미지세로
    /// </summary>
    public int MainImageHeight { get; set; }

    /// <summary>
    /// 행사장약도이미지용량
    /// </summary>
    public int LocationMapImageSize { get; set; }

    /// <summary>
    /// 행사장약도이미지가로
    /// </summary>
    public int LocationMapImageWidth { get; set; }

    /// <summary>
    /// 행사장약도이미지세로
    /// </summary>
    public int LocationMapImageHeight { get; set; }

    /// <summary>
    /// 인증코드(아이디,이메일)
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? AuthCode { get; set; }

    /// <summary>
    /// 행사일
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string EventDate { get; set; } = null!;

    /// <summary>
    /// 기타추가정보
    /// </summary>
    [StringLength(3500)]
    public string? EtcGuide { get; set; }

    /// <summary>
    /// 동영상종류
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? VideoType { get; set; }

    /// <summary>
    /// 피로연정보
    /// </summary>
    [StringLength(300)]
    public string? EtcAfter { get; set; }

    /// <summary>
    /// 기타정보
    /// </summary>
    [StringLength(700)]
    public string? EtcInfo { get; set; }

    /// <summary>
    /// 유입사이트코드
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    /// <summary>
    /// 주문일련번호
    /// </summary>
    [StringLength(8)]
    [Unicode(false)]
    public string? OrderSeq { get; set; }

    /// <summary>
    /// 초대장스킨코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? SkinCode { get; set; }

    /// <summary>
    /// 초대장작성완료시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CompletedTime { get; set; }

    /// <summary>
    /// 초대장퍼블리시여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? PublishYN { get; set; }

    /// <summary>
    /// 초대장SMS전송여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? SmsInvitationYN { get; set; }

    /// <summary>
    /// 초대장SMS전송여뷰(마이페이지)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? SmsMypageYN { get; set; }

    /// <summary>
    /// 만료여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpireYN { get; set; }

    /// <summary>
    /// 삭제여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? DeleteYN { get; set; }

    /// <summary>
    /// 행사종료시간
    /// </summary>
    [StringLength(20)]
    public string? EventEndTime { get; set; }

    /// <summary>
    /// 축의금기능사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string MoneyGiftYN { get; set; } = null!;

    /// <summary>
    /// 광고배너사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? AdDisplayYN { get; set; }

    [ForeignKey("SkinID")]
    [InverseProperty("mcard_Invitation")]
    public virtual mcard_Skin Skin { get; set; } = null!;

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_Comment> mcard_Comment { get; } = new List<mcard_Comment>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_Gallery> mcard_Gallery { get; } = new List<mcard_Gallery>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_InvitationBaby> mcard_InvitationBaby { get; } = new List<mcard_InvitationBaby>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_InvitationGiftRel> mcard_InvitationGiftRel { get; } = new List<mcard_InvitationGiftRel>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_InvitationParty> mcard_InvitationParty { get; } = new List<mcard_InvitationParty>();

    [InverseProperty("Invitation")]
    public virtual ICollection<mcard_InvitationWedding> mcard_InvitationWedding { get; } = new List<mcard_InvitationWedding>();
}

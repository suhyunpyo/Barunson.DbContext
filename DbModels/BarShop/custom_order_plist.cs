using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 주문관련 인쇄판정보
/// </summary>
[Index("card_seq", "print_type", Name = "IDX_custom_order_plist_card_seq_print_type")]
[Index("print_type", Name = "IDX_custom_order_plist_print_type")]
[Index("order_seq", "print_type", Name = "NCI_custom_order_plist_order_seq_print_type", IsDescending = new[] { true, false })]
public partial class custom_order_plist
{
    [Key]
    public long id { get; set; }

    public int? sid { get; set; }

    public int order_seq { get; set; }

    /// <summary>
    /// 1일 경우 앞면 인쇄판
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    /// <summary>
    /// C:카드,I:내지,E:봉투, M:미니,P:약도카드
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string print_type { get; set; } = null!;

    public int card_seq { get; set; }

    /// <summary>
    /// 판이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? title { get; set; }

    /// <summary>
    /// 인쇄 수량
    /// </summary>
    public int? print_count { get; set; }

    /// <summary>
    /// 기타 요청 내용
    /// </summary>
    [StringLength(4000)]
    public string? etc_comment { get; set; }

    /// <summary>
    /// 기타 정보(미니 인쇄 색상 등)
    /// </summary>
    [StringLength(200)]
    public string? etc_info_s { get; set; }

    /// <summary>
    /// 판정보를 파일 업로드시 파일명.
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? order_filename { get; set; }

    /// <summary>
    /// 옵션 비용
    /// </summary>
    public short option_price { get; set; }

    /// <summary>
    /// 추가 주문시, 카드없이 내지만 주문하는 경우 1
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isNotSet { get; set; }

    /// <summary>
    /// 1: 인쇄를 안하는 경우(백봉투) / 2:세로형 봉투:축하해 주셔서 감사합니다. /3:세로형 봉투:&quot;&quot;&quot;&quot;祝賀해 주셔서 感謝합니다. /4:가로형 봉투:축하해 주셔서 감사합니다. /5:가로형 봉투:&quot;&quot;&quot;&quot;祝賀해 주셔서 感謝합니다.
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isNotPrint { get; set; }

    /// <summary>
    /// 우편번호
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? env_zip { get; set; }

    /// <summary>
    /// 주소
    /// </summary>
    [StringLength(600)]
    public string? env_addr { get; set; }

    /// <summary>
    /// 상세주소
    /// </summary>
    [StringLength(400)]
    public string? env_addr_detail { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    [StringLength(50)]
    public string? env_phone { get; set; }

    /// <summary>
    /// 핸드폰 번호
    /// </summary>
    [StringLength(50)]
    public string? env_hphone { get; set; }

    /// <summary>
    /// 故
    /// </summary>
    [StringLength(50)]
    public string? env_person1_header { get; set; }

    /// <summary>
    /// 故
    /// </summary>
    [StringLength(50)]
    public string? env_person2_header { get; set; }

    /// <summary>
    /// 이름1
    /// </summary>
    [StringLength(100)]
    public string? env_person1 { get; set; }

    /// <summary>
    /// 이름2
    /// </summary>
    [StringLength(100)]
    public string? env_person2 { get; set; }

    /// <summary>
    /// 귀하
    /// </summary>
    [StringLength(50)]
    public string? env_person_Tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnv_person_tail { get; set; }

    /// <summary>
    /// 이름1 세례명
    /// </summary>
    [StringLength(100)]
    public string? env_person1_tail { get; set; }

    /// <summary>
    /// 이름2 세례명
    /// </summary>
    [StringLength(100)]
    public string? env_person2_tail { get; set; }

    /// <summary>
    /// 받는 사람 우편번호 박스 표기 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isZipBox { get; set; }

    /// <summary>
    /// 받는 사람 명칭정보(귀하 등)
    /// </summary>
    [StringLength(50)]
    public string? recv_tail { get; set; }

    /// <summary>
    /// 요금별납 인쇄 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isPostMark { get; set; }

    /// <summary>
    /// 요금별납 인쇄일 경우 해당 우체국명
    /// </summary>
    [StringLength(50)]
    public string? postname { get; set; }

    /// <summary>
    /// 0:요청, 1:초안등록
    /// </summary>
    public byte? pstatus { get; set; }

    /// <summary>
    /// 관련 초안정보(변환 이전 데이터, 사용안함)
    /// </summary>
    public int? preview_seq { get; set; }

    /// <summary>
    /// 초안이미지 저장 폴더
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? imgFolder { get; set; }

    /// <summary>
    /// 초안이미지 파일명
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? imgName { get; set; }

    /// <summary>
    /// 초안작성일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? choan_date { get; set; }

    /// <summary>
    /// 인쇄일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? print_date { get; set; }

    /// <summary>
    /// 인쇄 담당자
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? print_admin_id { get; set; }

    /// <summary>
    /// 코렐 병합일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? choanmerge_date { get; set; }

    /// <summary>
    /// 추가주문시 주문한 원주문의 판정보
    /// </summary>
    public long? up_id { get; set; }

    /// <summary>
    /// QRCODE 인쇄여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isQrcode { get; set; }

    /// <summary>
    /// 요금별납 인쇄할 경우 우체국/우편집중국 등의 정보
    /// </summary>
    [StringLength(50)]
    public string? postname_tail { get; set; }

    /// <summary>
    /// 기본인쇄판 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isBasic { get; set; }

    /// <summary>
    /// 보내는 사람 연락처
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? env_hphone2 { get; set; }

    public int? env_addr_type { get; set; }

    [StringLength(300)]
    public string? env_road_addr { get; set; }

    [StringLength(200)]
    public string? env_road_addr_detail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotPrint_Addr { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnvSpecialType { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 유플러스 결제
/// </summary>
[Index("LGD_OID", Name = "LGD_OID")]
[MySqlCollation("utf8_unicode_ci")]
public partial class lguplus_paid_list
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 응답코드
    /// </summary>
    [StringLength(4)]
    public string? LGD_RESPCODE { get; set; }

    /// <summary>
    /// 응답메세지
    /// </summary>
    [StringLength(512)]
    public string? LGD_RESPMSG { get; set; }

    /// <summary>
    /// LG유플러스 발급 아이디
    /// </summary>
    [StringLength(15)]
    public string? LGD_MID { get; set; }

    /// <summary>
    /// 이용업체 거래번호(주문번호)
    /// </summary>
    [StringLength(64)]
    public string? LGD_OID { get; set; }

    /// <summary>
    /// 결제금액
    /// </summary>
    [StringLength(12)]
    public string? LGD_AMOUNT { get; set; }

    /// <summary>
    /// LG유플러스 거래번호
    /// </summary>
    [StringLength(24)]
    public string? LGD_TID { get; set; }

    /// <summary>
    /// 결제수단
    /// </summary>
    [StringLength(6)]
    public string? LGD_PAYTYPE { get; set; }

    /// <summary>
    /// 결제일시
    /// </summary>
    [StringLength(14)]
    public string? LGD_PAYDATE { get; set; }

    /// <summary>
    /// 해쉬데이타
    /// </summary>
    [StringLength(50)]
    public string? LGD_HASHDATA { get; set; }

    /// <summary>
    /// 타임스탬프
    /// </summary>
    [StringLength(14)]
    public string? LGD_TIMESTAMP { get; set; }

    /// <summary>
    /// 구매자명
    /// </summary>
    [StringLength(128)]
    public string? LGD_BUYER { get; set; }

    /// <summary>
    /// 구매내역
    /// </summary>
    [StringLength(128)]
    public string? LGD_PRODUCTINFO { get; set; }

    /// <summary>
    /// 구매자아이디
    /// </summary>
    [StringLength(15)]
    public string? LGD_BUYERID { get; set; }

    /// <summary>
    /// 구매자주소
    /// </summary>
    [StringLength(128)]
    public string? LGD_BUYERADDRESS { get; set; }

    /// <summary>
    /// 구매자휴대폰번호
    /// </summary>
    [StringLength(15)]
    public string? LGD_BUYERPHONE { get; set; }

    /// <summary>
    /// 구매자메일
    /// </summary>
    [StringLength(40)]
    public string? LGD_BUYEREMAIL { get; set; }

    /// <summary>
    /// 상품코드
    /// </summary>
    [StringLength(40)]
    public string? LGD_PRODUCTCODE { get; set; }

    /// <summary>
    /// 수취인
    /// </summary>
    [StringLength(10)]
    public string? LGD_RECEIVER { get; set; }

    /// <summary>
    /// 수취인전화번호
    /// </summary>
    [StringLength(15)]
    public string? LGD_RECEIVERPHONE { get; set; }

    /// <summary>
    /// 배송정보
    /// </summary>
    [StringLength(128)]
    public string? LGD_DELIVERYINFO { get; set; }

    /// <summary>
    /// 결제기관코드
    /// </summary>
    [StringLength(10)]
    public string? LGD_FINANCECODE { get; set; }

    /// <summary>
    /// 결제기관명
    /// </summary>
    [StringLength(20)]
    public string? LGD_FINANCENAME { get; set; }

    /// <summary>
    /// 결제기관승인번호
    /// </summary>
    [StringLength(20)]
    public string? LGD_FINANCEAUTHNUM { get; set; }

    /// <summary>
    /// 에스크로적용유무
    /// </summary>
    [StringLength(1)]
    public string? LGD_ESCROWYN { get; set; }

    /// <summary>
    /// 현금영수증승인번호
    /// </summary>
    [StringLength(10)]
    public string? LGD_CASHRECEIPTNUM { get; set; }

    /// <summary>
    /// 현금영수증자진발급제유무
    /// </summary>
    [StringLength(1)]
    public string? LGD_CASHRECEIPTSELFYN { get; set; }

    /// <summary>
    /// 현금영수증종류
    /// </summary>
    [StringLength(4)]
    public string? LGD_CASHRECEIPTKIND { get; set; }

    /// <summary>
    /// 신용카드번호
    /// </summary>
    [StringLength(20)]
    public string? LGD_CARDNUM { get; set; }

    /// <summary>
    /// 신용카드할부개월
    /// </summary>
    [StringLength(2)]
    public string? LGD_CARDINSTALLMONTH { get; set; }

    /// <summary>
    /// 신용카드무이자여부
    /// </summary>
    [StringLength(1)]
    public string? LGD_CARDNOINTYN { get; set; }

    /// <summary>
    /// 신용카드제휴코드
    /// </summary>
    [StringLength(10)]
    public string? LGD_AFFILIATECODE { get; set; }

    /// <summary>
    /// 신용카드추가정보1
    /// </summary>
    [StringLength(1)]
    public string? LGD_CARDGUBUN1 { get; set; }

    /// <summary>
    /// 신용카드추가정보2
    /// </summary>
    [StringLength(1)]
    public string? LGD_CARDGUBUN2 { get; set; }

    /// <summary>
    /// 신용카드매입사코드
    /// </summary>
    [StringLength(2)]
    public string? LGD_CARDACQUIRER { get; set; }

    /// <summary>
    /// 신용카드부분취소가능여부
    /// </summary>
    [StringLength(1)]
    public string? LGD_PCANCELFLAG { get; set; }

    /// <summary>
    /// 신용카드부분취소불가능사유
    /// </summary>
    [StringLength(128)]
    public string? LGD_PCANCELSTR { get; set; }

    /// <summary>
    /// 환율적용금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_TRANSAMOUNT { get; set; }

    /// <summary>
    /// 적용환율
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_EXCHANGERATE { get; set; }

    /// <summary>
    /// 신용카드 즉시할인 여부
    /// </summary>
    [StringLength(1)]
    public string? LGD_DISCOUNTUSEYN { get; set; }

    /// <summary>
    /// 신용카드 즉시할인 금액
    /// </summary>
    [StringLength(12)]
    public string? LGD_DISCOUNTUSEAMOUNT { get; set; }

    /// <summary>
    /// 가상계좌발급번호
    /// </summary>
    [StringLength(20)]
    public string? LGD_ACCOUNTNUM { get; set; }

    /// <summary>
    /// 계좌주명
    /// </summary>
    [StringLength(40)]
    public string? LGD_ACCOUNTOWNER { get; set; }

    /// <summary>
    /// 가상계좌입금자명
    /// </summary>
    [StringLength(40)]
    public string? LGD_PAYER { get; set; }

    /// <summary>
    /// 입금누적금액
    /// </summary>
    [StringLength(12)]
    public string? LGD_CASTAMOUNT { get; set; }

    /// <summary>
    /// 현입금금액
    /// </summary>
    [StringLength(12)]
    public string? LGD_CASCAMOUNT { get; set; }

    /// <summary>
    /// 거래종류(R:할당,I:입금,C:취소)
    /// </summary>
    [StringLength(10)]
    public string? LGD_CASFLAG { get; set; }

    /// <summary>
    /// 가상계좌일련번호
    /// </summary>
    [StringLength(3)]
    public string? LGD_CASSEQNO { get; set; }

    /// <summary>
    /// 가상계좌 입금계좌주명
    /// </summary>
    [StringLength(10)]
    public string? LGD_SAOWNER { get; set; }

    /// <summary>
    /// 결제휴대폰번호
    /// </summary>
    [StringLength(11)]
    public string? LGD_TELNO { get; set; }

    /// <summary>
    /// OK캐쉬백 사용금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_OCBAMOUNT { get; set; }

    /// <summary>
    /// OK캐쉬백 적립포인트
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_OCBSAVEPOINT { get; set; }

    /// <summary>
    /// OK캐쉬백 총누적포인트
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_OCBTOTALPOINT { get; set; }

    /// <summary>
    /// OK캐쉬백 사용가능포인트
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_OCBUSABLEPOINT { get; set; }

    /// <summary>
    /// OK캐쉬백 거래번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int LGD_OCBTID { get; set; }

    [StringLength(10)]
    public string? LGD_IFOS { get; set; }

    [StringLength(10)]
    public string? LGD_2TR_FLAG { get; set; }

    [StringLength(10)]
    public string? LGD_DEVICE { get; set; }

    [StringLength(50)]
    public string? LGD_ISPKEY { get; set; }

    [StringLength(10)]
    public string? LGD_VANCODE { get; set; }

    [StringLength(10)]
    public string? LGD_BUYERSSN { get; set; }

    [StringLength(10)]
    public string? LGD_CARDNOINTEREST_YN { get; set; }

    [StringLength(10)]
    public string? LGD_CASHRECEIPTCODE { get; set; }

    [StringLength(100)]
    public string? LGD_COMMENT { get; set; }

    /// <summary>
    /// 성공:T, 실패:F
    /// </summary>
    [StringLength(1)]
    public string LGD_PASS_FLAG { get; set; } = null!;

    [StringLength(5)]
    public string LGD_PAYNOW_TRANTYPE { get; set; } = null!;

    /// <summary>
    /// DC여부
    /// </summary>
    [StringLength(10)]
    public string? LGD_DCNO { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}

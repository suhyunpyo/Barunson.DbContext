using System;
using System.Collections.Generic;
using Barunson.DbContext.DbModels.Barunson;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext;

public partial class BarunsonContext : Microsoft.EntityFrameworkCore.DbContext
{
    public BarunsonContext(DbContextOptions<BarunsonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataProtectionKeys> DataProtectionKeys { get; set; }

    public virtual DbSet<Origin_Invitation_Detail> Origin_Invitation_Detail { get; set; }

    public virtual DbSet<SMS_Log> SMS_Log { get; set; }

    public virtual DbSet<TB_Account> TB_Account { get; set; }

    public virtual DbSet<TB_Account_Extra> TB_Account_Extra { get; set; }

    public virtual DbSet<TB_Account_Setting> TB_Account_Setting { get; set; }

    public virtual DbSet<TB_Admin_Memo> TB_Admin_Memo { get; set; }

    public virtual DbSet<TB_Apply_Product> TB_Apply_Product { get; set; }

    public virtual DbSet<TB_Area> TB_Area { get; set; }

    public virtual DbSet<TB_Bank> TB_Bank { get; set; }

    public virtual DbSet<TB_Banner> TB_Banner { get; set; }

    public virtual DbSet<TB_Banner_Category> TB_Banner_Category { get; set; }

    public virtual DbSet<TB_Banner_Item> TB_Banner_Item { get; set; }

    public virtual DbSet<TB_Board> TB_Board { get; set; }

    public virtual DbSet<TB_CASEA_COUPON_PUBLISHED> TB_CASEA_COUPON_PUBLISHED { get; set; }

    public virtual DbSet<TB_CASEB_COUPON_PUBLISHED> TB_CASEB_COUPON_PUBLISHED { get; set; }

    public virtual DbSet<TB_Calculate> TB_Calculate { get; set; }

    public virtual DbSet<TB_Category> TB_Category { get; set; }

    public virtual DbSet<TB_Common_Code> TB_Common_Code { get; set; }

    public virtual DbSet<TB_Common_Code_Group> TB_Common_Code_Group { get; set; }

    public virtual DbSet<TB_Common_Menu> TB_Common_Menu { get; set; }

    public virtual DbSet<TB_Company_Tax> TB_Company_Tax { get; set; }

    public virtual DbSet<TB_Coupon> TB_Coupon { get; set; }

    public virtual DbSet<TB_Coupon_Apply_Product> TB_Coupon_Apply_Product { get; set; }

    public virtual DbSet<TB_Coupon_Exception_Product> TB_Coupon_Exception_Product { get; set; }

    public virtual DbSet<TB_Coupon_Order> TB_Coupon_Order { get; set; }

    public virtual DbSet<TB_Coupon_Product> TB_Coupon_Product { get; set; }

    public virtual DbSet<TB_Coupon_Product_Option> TB_Coupon_Product_Option { get; set; }

    public virtual DbSet<TB_Coupon_Publish> TB_Coupon_Publish { get; set; }

    public virtual DbSet<TB_Coupon_Publish_TEST> TB_Coupon_Publish_TEST { get; set; }

    public virtual DbSet<TB_Daily_Unique> TB_Daily_Unique { get; set; }

    public virtual DbSet<TB_Depositor_Hits> TB_Depositor_Hits { get; set; }

    public virtual DbSet<TB_Error_Content> TB_Error_Content { get; set; }

    public virtual DbSet<TB_Gallery> TB_Gallery { get; set; }

    public virtual DbSet<TB_GuestBook> TB_GuestBook { get; set; }

    public virtual DbSet<TB_Icon> TB_Icon { get; set; }

    public virtual DbSet<TB_Invitation> TB_Invitation { get; set; }

    public virtual DbSet<TB_Invitation_Account> TB_Invitation_Account { get; set; }

    public virtual DbSet<TB_Invitation_Admin> TB_Invitation_Admin { get; set; }

    public virtual DbSet<TB_Invitation_Area> TB_Invitation_Area { get; set; }

    public virtual DbSet<TB_Invitation_Detail> TB_Invitation_Detail { get; set; }

    public virtual DbSet<TB_Invitation_Detail_Etc> TB_Invitation_Detail_Etc { get; set; }

    public virtual DbSet<TB_Invitation_Item> TB_Invitation_Item { get; set; }

    public virtual DbSet<TB_Invitation_Tax> TB_Invitation_Tax { get; set; }

    public virtual DbSet<TB_Item_Resource> TB_Item_Resource { get; set; }

    public virtual DbSet<TB_Kakao_Cache> TB_Kakao_Cache { get; set; }

    public virtual DbSet<TB_Order> TB_Order { get; set; }

    public virtual DbSet<TB_Order_Copy> TB_Order_Copy { get; set; }

    public virtual DbSet<TB_Order_Coupon_Use> TB_Order_Coupon_Use { get; set; }

    public virtual DbSet<TB_Order_PartnerShip> TB_Order_PartnerShip { get; set; }

    public virtual DbSet<TB_Order_Product> TB_Order_Product { get; set; }

    public virtual DbSet<TB_Order_Serial_Coupon_Use> TB_Order_Serial_Coupon_Use { get; set; }

    public virtual DbSet<TB_Payment_Status_Day> TB_Payment_Status_Day { get; set; }

    public virtual DbSet<TB_Payment_Status_Month> TB_Payment_Status_Month { get; set; }

    public virtual DbSet<TB_Popup> TB_Popup { get; set; }

    public virtual DbSet<TB_Popup_Item> TB_Popup_Item { get; set; }

    public virtual DbSet<TB_Product> TB_Product { get; set; }

    public virtual DbSet<TB_Product_Category> TB_Product_Category { get; set; }

    public virtual DbSet<TB_Product_Icon> TB_Product_Icon { get; set; }

    public virtual DbSet<TB_Product_Image> TB_Product_Image { get; set; }

    public virtual DbSet<TB_Refund_Info> TB_Refund_Info { get; set; }

    public virtual DbSet<TB_Remit> TB_Remit { get; set; }

    public virtual DbSet<TB_Remit_Statistics_Daily> TB_Remit_Statistics_Daily { get; set; }

    public virtual DbSet<TB_Remit_Statistics_Monthly> TB_Remit_Statistics_Monthly { get; set; }

    public virtual DbSet<TB_ReservationWord> TB_ReservationWord { get; set; }

    public virtual DbSet<TB_SCHEDULER_COUPON_PUBLISHED> TB_SCHEDULER_COUPON_PUBLISHED { get; set; }

    public virtual DbSet<TB_Sales_Statistic_Day> TB_Sales_Statistic_Day { get; set; }

    public virtual DbSet<TB_Sales_Statistic_Month> TB_Sales_Statistic_Month { get; set; }

    public virtual DbSet<TB_Serial_Apply_Product> TB_Serial_Apply_Product { get; set; }

    public virtual DbSet<TB_Serial_Coupon> TB_Serial_Coupon { get; set; }

    public virtual DbSet<TB_Serial_Coupon_Apply_Product> TB_Serial_Coupon_Apply_Product { get; set; }

    public virtual DbSet<TB_Serial_Coupon_Publish> TB_Serial_Coupon_Publish { get; set; }

    public virtual DbSet<TB_Standard_Date> TB_Standard_Date { get; set; }

    public virtual DbSet<TB_Tax> TB_Tax { get; set; }

    public virtual DbSet<TB_Temp_Order> TB_Temp_Order { get; set; }

    public virtual DbSet<TB_Template> TB_Template { get; set; }

    public virtual DbSet<TB_Template_Area> TB_Template_Area { get; set; }

    public virtual DbSet<TB_Template_Detail> TB_Template_Detail { get; set; }

    public virtual DbSet<TB_Template_Item> TB_Template_Item { get; set; }

    public virtual DbSet<TB_Total_Statistic_Day> TB_Total_Statistic_Day { get; set; }

    public virtual DbSet<TB_Total_Statistic_Month> TB_Total_Statistic_Month { get; set; }

    public virtual DbSet<TB_Value_Entered_Login> TB_Value_Entered_Login { get; set; }

    public virtual DbSet<TB_Wish_List> TB_Wish_List { get; set; }

    public virtual DbSet<VW_Admin> VW_Admin { get; set; }

    public virtual DbSet<VW_Statics_Produce> VW_Statics_Produce { get; set; }

    public virtual DbSet<VW_User> VW_User { get; set; }

    public virtual DbSet<VW_User_QNA> VW_User_QNA { get; set; }

    public virtual DbSet<View_RandomNumber> View_RandomNumber { get; set; }

    public virtual DbSet<TB_FlaBannerManage> TB_FlaBannerManage { get; set; }

    public virtual DbSet<TB_PolicyInfo> TB_PolicyInfo { get; set; }

    public virtual DbSet<tb_test22> tb_test22 { get; set; }

    public virtual DbSet<test> test { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TB_Account>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("계좌_정보"));

            entity.Property(e => e.Account_ID).HasComment("모바일초대장에 매핑할 키\r\n");
            entity.Property(e => e.Account_Number).HasComment("계좌_번호");
            entity.Property(e => e.Account_Type_Code).HasComment("신랑\r\n신부\r\n신랑혼주\r\n신부혼주\r\n");
            entity.Property(e => e.Bank_Code).HasComment("금융관리원에서 표준으로 잡는 은행 코드\r\n");
            entity.Property(e => e.Depositor_Name).HasComment("예금주_명");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TB_Account");
        });

        modelBuilder.Entity<TB_Account_Extra>(entity =>
        {
            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Account_Extra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TB_Account_Extra");
        });

        modelBuilder.Entity<TB_Account_Setting>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("계좌_설정"));

            entity.Property(e => e.Account_Setting_ID).HasComment("계좌_설정_ID");
            entity.Property(e => e.Barunn_Account_Number).HasComment("바른_계좌_번호");
            entity.Property(e => e.Barunn_Bank_Code).HasComment("바른_은행_코드");
            entity.Property(e => e.Kakao_Account_Number).HasComment("카카오_계좌_번호");
            entity.Property(e => e.Kakao_Bank_Code).HasComment("카카오_은행_코드");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
        });

        modelBuilder.Entity<TB_Admin_Memo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자_메모"));

            entity.Property(e => e.Memo_ID).HasComment("메모_ID");
            entity.Property(e => e.Content).HasComment("내용");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
        });

        modelBuilder.Entity<TB_Apply_Product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_적용_상품_리스트"));

            entity.Property(e => e.Product_Apply_ID).HasComment("상품_적용_ID");
            entity.Property(e => e.Product_Code).HasComment("상품_코드");

            entity.HasOne(d => d.Product_Apply).WithMany(p => p.TB_Apply_Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Coupon_Apply_Product_TO_TB_Apply_Product");
        });

        modelBuilder.Entity<TB_Area>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("영역"));

            entity.Property(e => e.Area_ID)
                .ValueGeneratedNever()
                .HasComment("영역_ID");
            entity.Property(e => e.Area_Name).HasComment("영역_명");
            entity.Property(e => e.Edit_YN)
                .IsFixedLength()
                .HasComment("편집_여부");
            entity.Property(e => e.ThanksCard_YN)
                .IsFixedLength()
                .HasComment("감사장_여부 (사용하지 않음)");
            entity.Property(e => e.WeddingCard_YN)
                .IsFixedLength()
                .HasComment("청첩장_여부 (사용하지 않음)");
        });

        modelBuilder.Entity<TB_Bank>(entity =>
        {
            entity.Property(e => e.Use_YN).IsFixedLength();
        });

        modelBuilder.Entity<TB_Banner>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("배너"));

            entity.Property(e => e.Banner_ID).HasComment("배너_ID");
            entity.Property(e => e.Banner_Category_ID).HasComment("배너_분류_ID");
            entity.Property(e => e.Banner_Mobile_YN)
                .IsFixedLength()
                .HasComment("배너_모바일_여부");
            entity.Property(e => e.Banner_Name).HasComment("배너_명");
            entity.Property(e => e.Banner_PC_YN)
                .IsFixedLength()
                .HasComment("배너_PC_여부");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Banner_Category).WithMany(p => p.TB_Banner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Banner_Category_TO_TB_Banner");
        });

        modelBuilder.Entity<TB_Banner_Category>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("배너_분류"));

            entity.Property(e => e.Banner_Category_ID).HasComment("배너_분류_ID");
            entity.Property(e => e.Banner_Category_Name).HasComment("배너_분류_명");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
        });

        modelBuilder.Entity<TB_Banner_Item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("배너_아이템"));

            entity.Property(e => e.Banner_Item_ID).HasComment("배너_아이템_ID");
            entity.Property(e => e.Banner_ID).HasComment("배너_ID");
            entity.Property(e => e.Banner_Type_Code).HasComment("PC\r\n모바");
            entity.Property(e => e.Click_Count).HasComment("클릭_수");
            entity.Property(e => e.Deadline_Type_Code).HasComment("날짜지정\r\n무제");
            entity.Property(e => e.End_Date).HasComment("종료_날짜");
            entity.Property(e => e.End_Time).HasComment("종료_시간");
            entity.Property(e => e.Image_URL).HasComment("이미지_URL");
            entity.Property(e => e.Link_URL).HasComment("링크_URL");
            entity.Property(e => e.NewPage_YN)
                .IsFixedLength()
                .HasComment("새창_여부");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Start_Date).HasComment("시작_날짜");
            entity.Property(e => e.Start_Time).HasComment("시작_시간");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Banner).WithMany(p => p.TB_Banner_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Banner_TO_TB_Banner_Item");
        });

        modelBuilder.Entity<TB_Board>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("게시판"));

            entity.Property(e => e.Board_ID).HasComment("게시판_ID");
            entity.Property(e => e.Board_Category)
                .IsFixedLength()
                .HasComment("N - 공지사항\r\n\r\nF - FAQ");
            entity.Property(e => e.Content).HasComment("내용");
            entity.Property(e => e.Display_YN)
                .IsFixedLength()
                .HasComment("노출_여부");
            entity.Property(e => e.Hits).HasComment("조회수");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Title).HasComment("제목");
            entity.Property(e => e.Top_YN)
                .IsFixedLength()
                .HasComment("상단고정_여부");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
        });

        modelBuilder.Entity<TB_Calculate>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("정산"));

            entity.Property(e => e.Calculate_ID).HasComment("정산_ID");
            entity.Property(e => e.Calculate_DateTime).HasComment("정산_일시");
            entity.Property(e => e.Error_Code).HasComment("오류_코드");
            entity.Property(e => e.Remit_Account_Number).HasComment("송금_계좌_번호");
            entity.Property(e => e.Remit_Bank_Code).HasComment("송금_은행_코드");
            entity.Property(e => e.Remit_Content).HasComment("송금_내용");
            entity.Property(e => e.Remit_ID).HasComment("송금_ID");
            entity.Property(e => e.Remit_Price).HasComment("송금_금액");
            entity.Property(e => e.Request_Date).HasComment("요청_일자");
            entity.Property(e => e.Request_DateTime).HasComment("요청_일시");
            entity.Property(e => e.Status_Code).HasComment("상태_코드");
            entity.Property(e => e.Trading_Number).HasComment("거래_번호");
            entity.Property(e => e.Unique_Number).HasComment("고유_번호");

            entity.HasOne(d => d.Remit).WithMany(p => p.TB_Calculate).HasConstraintName("FK_TB_Remit_TO_TB_Calculate");
        });

        modelBuilder.Entity<TB_Category>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("분류"));

            entity.Property(e => e.Category_ID).HasComment("분류_ID");
            entity.Property(e => e.Category_Name).HasComment("분류_명");
            entity.Property(e => e.Category_Name_Mobile).HasComment("분류_명_모바일");
            entity.Property(e => e.Category_Name_Mobile_URL).HasComment("분류_명_모바일_URL");
            entity.Property(e => e.Category_Name_PC).HasComment("분류_명_PC");
            entity.Property(e => e.Category_Name_PC_URL).HasComment("분류_명_PC_URL");
            entity.Property(e => e.Category_Name_Type_Code).HasComment("분류_명_구분_코드");
            entity.Property(e => e.Category_Step).HasComment("분류_단계");
            entity.Property(e => e.Category_Type_Code).HasComment("분류_구분_코드");
            entity.Property(e => e.Display_YN)
                .IsFixedLength()
                .HasComment("진열_여부");
            entity.Property(e => e.Icon_ID).HasComment("아이콘_ID");
            entity.Property(e => e.Parent_Category_ID).HasComment("상위_분류_ID");
            entity.Property(e => e.Sort).HasComment("순서");
        });

        modelBuilder.Entity<TB_Common_Code>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("공통_코드"));

            entity.Property(e => e.Code_Group).HasComment("코드_그룹");
            entity.Property(e => e.Code).HasComment("코드");
            entity.Property(e => e.Code_Name).HasComment("코드_명");
            entity.Property(e => e.Sort).HasComment("순서");

            entity.HasOne(d => d.Code_GroupNavigation).WithMany(p => p.TB_Common_Code)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Common_Code_Group_TO_TB_Common_Code");
        });

        modelBuilder.Entity<TB_Common_Code_Group>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("공통_코드_그룹"));

            entity.Property(e => e.Code_Group).HasComment("코드_그룹");
            entity.Property(e => e.Group_Name).HasComment("그룹_명");
        });

        modelBuilder.Entity<TB_Common_Menu>(entity =>
        {
            entity.HasKey(e => e.Menu_ID).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("공통_메뉴"));

            entity.Property(e => e.Menu_ID).HasComment("메뉴_ID");
            entity.Property(e => e.Display_YN)
                .IsFixedLength()
                .HasComment("진열_여부");
            entity.Property(e => e.Menu_Name).HasComment("메뉴_명");
            entity.Property(e => e.Menu_Step).HasComment("메뉴_단계");
            entity.Property(e => e.Menu_Type_Code).HasComment("메뉴_구분_코드");
            entity.Property(e => e.Menu_URL).HasComment("메뉴_URL");
            entity.Property(e => e.Parent_Menu_ID).HasComment("상위_메뉴_아이디");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Parent_Menu).WithMany(p => p.InverseParent_Menu).HasConstraintName("FK_TB_Common_Menu_TO_TB_Common_Menu");
        });

        modelBuilder.Entity<TB_Company_Tax>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("업체_수수료"));

            entity.Property(e => e.Company_Tax_ID).HasComment("업체_수수료_ID");
            entity.Property(e => e.Apply_Start_Date).HasComment("적용_시작_날짜");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Remit_Tax).HasComment("수수료_비율");
        });

        modelBuilder.Entity<TB_Coupon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰"));

            entity.Property(e => e.Coupon_ID).HasComment("쿠폰_ID");
            entity.Property(e => e.Coupon_Apply_Code).HasComment("쿠폰_적용_코드");
            entity.Property(e => e.Coupon_Apply_Product_ID).HasComment("쿠폰_적용_상품_ID");
            entity.Property(e => e.Coupon_Image_URL).HasComment("쿠폰_이미지_URL");
            entity.Property(e => e.Coupon_Name).HasComment("쿠폰_명");
            entity.Property(e => e.Description).HasComment("설명");
            entity.Property(e => e.Discount_Method_Code).HasComment("할인_방식_코드");
            entity.Property(e => e.Discount_Price).HasComment("할인_금액");
            entity.Property(e => e.Discount_Rate).HasComment("할인_율");
            entity.Property(e => e.Period_Method_Code).HasComment("기간_방식_코드");
            entity.Property(e => e.Publish_End_Date).HasComment("발행_종료_일자");
            entity.Property(e => e.Publish_Method_Code).HasComment("발급_방식_코드");
            entity.Property(e => e.Publish_Period_Code).HasComment("발행_기간_코드");
            entity.Property(e => e.Publish_Start_Date).HasComment("발행_시작_일자");
            entity.Property(e => e.Publish_Target_Code).HasComment("발급_대상_코드");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Standard_Purchase_Price).HasComment("기준_구매_금액");
            entity.Property(e => e.Use_Available_Standard_Code).HasComment("사용_가능_기준_코드");
            entity.Property(e => e.Use_YN)
                .IsFixedLength()
                .HasComment("사용_여부");
        });

        modelBuilder.Entity<TB_Coupon_Apply_Product>(entity =>
        {
            entity.HasKey(e => e.Product_Apply_ID).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("쿠폰_적용_상품군"));

            entity.Property(e => e.Product_Apply_ID).HasComment("상품_적용_ID");
        });

        modelBuilder.Entity<TB_Coupon_Order>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_주문"));

            entity.Property(e => e.Coupon_Order_ID)
                .ValueGeneratedNever()
                .HasComment("쿠폰_주문_ID");
            entity.Property(e => e.Callback_PhoneNumber).HasComment("콜백_전화번호");
            entity.Property(e => e.Coupon_Expiration_DateTime).HasComment("쿠폰_만료_일시");
            entity.Property(e => e.Coupon_OrderNumber).HasComment("쿠폰_주문번호");
            entity.Property(e => e.Coupon_Product_ID).HasComment("쿠폰_상품_ID");
            entity.Property(e => e.Futures_Trading_Number).HasComment("선물_거래_번호");
            entity.Property(e => e.Option_Code).HasComment("옵션_코드");
            entity.Property(e => e.PIN_Number).HasComment("핀_번호");
            entity.Property(e => e.PIN_Option_Information).HasComment("핀_부가_정보");
            entity.Property(e => e.PhoneNumber).HasComment("전화번호");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Request_Count).HasComment("요청_수");
            entity.Property(e => e.Result_Code).HasComment("결과_코드");
            entity.Property(e => e.Result_Content).HasComment("결과_내용");
            entity.Property(e => e.Result_DateTime).HasComment("결과_일시");
            entity.Property(e => e.StampOffice).HasComment("인지국");
            entity.Property(e => e.Stamp_Code).HasComment("인지세_코드");
            entity.Property(e => e.Stamp_Type).HasComment("인지세_구분");

            entity.HasOne(d => d.Coupon_Product).WithMany(p => p.TB_Coupon_Order).HasConstraintName("FK_TB_Coupon_Product_TO_TB_Coupon_Order");
        });

        modelBuilder.Entity<TB_Coupon_Product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_상품"));

            entity.Property(e => e.Coupon_Product_ID).HasComment("쿠폰_상품_ID");
            entity.Property(e => e.Affiliate).HasComment("교환처");
            entity.Property(e => e.Affiliate_Category).HasComment("교환처_분류");
            entity.Property(e => e.Delegate_Affiliate_Code).HasComment("대표_교환처_코드");
            entity.Property(e => e.Destination_URL).HasComment("배송지_URL");
            entity.Property(e => e.Image_Path).HasComment("이미지_경로");
            entity.Property(e => e.Product_Category).HasComment("상품_분류");
            entity.Property(e => e.Product_Description).HasComment("상품_설명");
            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Product_Name).HasComment("상품_명");
            entity.Property(e => e.Product_Type).HasComment("상품_구분");
            entity.Property(e => e.Retail_Price).HasComment("소비자_가격");
            entity.Property(e => e.Retail_Price_Tax).HasComment("소비자_가격_부가세");
            entity.Property(e => e.Sale_End_Date).HasComment("판매_종료_날짜");
            entity.Property(e => e.Sale_Price).HasComment("판매_가격");
            entity.Property(e => e.Sale_Price_Tax).HasComment("판매_가격_부가세");
            entity.Property(e => e.Total_Price).HasComment("전체_가격");
            entity.Property(e => e.Valid_Period).HasComment("유효_기간");
        });

        modelBuilder.Entity<TB_Coupon_Product_Option>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_상품_옵션"));

            entity.Property(e => e.Coupon_Product_Option_ID).HasComment("쿠폰_상품_옵션_ID");
            entity.Property(e => e.Coupon_Product_ID).HasComment("쿠폰_상품_ID");
            entity.Property(e => e.Option_Name).HasComment("옵션_명");
            entity.Property(e => e.Option_Value).HasComment("옵션_값");

            entity.HasOne(d => d.Coupon_Product).WithMany(p => p.TB_Coupon_Product_Option).HasConstraintName("FK_TB_Coupon_Product_TO_TB_Coupon_Product_Option");
        });

        modelBuilder.Entity<TB_Coupon_Publish>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_발행"));

            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰_발행_ID");
            entity.Property(e => e.Coupon_ID).HasComment("쿠폰_ID");
            entity.Property(e => e.Expiration_Date).HasComment("만료_일자");
            entity.Property(e => e.Retrieve_DateTime).HasComment("회수_일시");
            entity.Property(e => e.Use_DateTime).HasComment("사용_일시");
            entity.Property(e => e.Use_YN)
                .IsFixedLength()
                .HasComment("사용_여부");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Coupon).WithMany(p => p.TB_Coupon_Publish)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Coupon_TO_TB_Coupon_Publish");
        });

        modelBuilder.Entity<TB_Coupon_Publish_TEST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰_발행"));

            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰_발행_ID");
            entity.Property(e => e.Coupon_ID).HasComment("쿠폰_ID");
            entity.Property(e => e.Expiration_Date).HasComment("만료_일자");
            entity.Property(e => e.Retrieve_DateTime).HasComment("회수_일시");
            entity.Property(e => e.Use_DateTime).HasComment("사용_일시");
            entity.Property(e => e.Use_YN)
                .IsFixedLength()
                .HasComment("사용_여부");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Coupon).WithMany(p => p.TB_Coupon_Publish_TEST)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Coupon_TO_TB_Coupon_Publish_TEST");
        });

        modelBuilder.Entity<TB_Daily_Unique>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("날짜_고유_번호"));

            entity.Property(e => e.Request_Date).HasComment("요청_일자");
            entity.Property(e => e.Unique_Number).HasComment("고유_번호");
        });

        modelBuilder.Entity<TB_Depositor_Hits>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예금주_조회"));

            entity.Property(e => e.Depositor_Hits_ID).HasComment("예금주_조회_ID");
            entity.Property(e => e.Account_Number).HasComment("계좌_번호");
            entity.Property(e => e.Bank_Code).HasComment("은행_코드");
            entity.Property(e => e.Depositor).HasComment("예금주");
            entity.Property(e => e.Error_Code).HasComment("오류_코드");
            entity.Property(e => e.Error_Message).HasComment("오류_메세지");
            entity.Property(e => e.Request_Date).HasComment("요청_일자");
            entity.Property(e => e.Request_DateTime).HasComment("요청_일시");
            entity.Property(e => e.Request_Result_DateTime).HasComment("요청_결과_일시");
            entity.Property(e => e.Status_Code).HasComment("상태_코드");
            entity.Property(e => e.Trading_Number).HasComment("거래_번호");
            entity.Property(e => e.Unique_Number).HasComment("고유_번호");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");
        });

        modelBuilder.Entity<TB_Gallery>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("갤러리"));

            entity.Property(e => e.Gallery_ID).HasComment("갤러리_ID");
            entity.Property(e => e.Image_Height).HasComment("이미지_높이");
            entity.Property(e => e.Image_URL).HasComment("이미지_URL");
            entity.Property(e => e.Image_Width).HasComment("이미지_너비");
            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Sort).HasComment("순서");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Gallery).HasConstraintName("FK_TB_Invitation_TO_TB_Gallery");
        });

        modelBuilder.Entity<TB_GuestBook>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("방명록"));

            entity.Property(e => e.GuestBook_ID).HasComment("방명록_ID");
            entity.Property(e => e.Display_YN)
                .IsFixedLength()
                .HasComment("제목");
            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Message).HasComment("내용");
            entity.Property(e => e.Name).HasComment("이름");
            entity.Property(e => e.Password).HasComment("비밀번호");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_GuestBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TO_TB_GuestBook");
        });

        modelBuilder.Entity<TB_Icon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("아이콘"));

            entity.Property(e => e.Icon_ID).HasComment("아이콘_ID");
            entity.Property(e => e.Icon_URL).HasComment("아이콘_URL");
        });

        modelBuilder.Entity<TB_Invitation>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장"));

            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Invitation_Display_YN).IsFixedLength();
            entity.Property(e => e.Order_ID).HasComment("주문_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Template_ID).HasComment("템플릿_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Order).WithOne(p => p.TB_Invitation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Order_TO_TB_Invitation");

            entity.HasOne(d => d.Template).WithMany(p => p.TB_Invitation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Template_TO_TB_Invitation");
        });

        modelBuilder.Entity<TB_Invitation_Account>(entity =>
        {
            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Invitation_Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TB_Invitation_Account");
        });

        modelBuilder.Entity<TB_Invitation_Admin>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_TB_Invitation_Admin__seq");

            entity.ToTable(tb => tb.HasComment("관리자 아이디"));

            entity.Property(e => e.is_errorMail).IsFixedLength();
            entity.Property(e => e.is_reviewMail).IsFixedLength();
            entity.Property(e => e.is_reviewSMS).IsFixedLength();
        });

        modelBuilder.Entity<TB_Invitation_Area>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장_영역"));

            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Area_ID).HasComment("영역_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Size_Height).HasComment("사이즈_높이");
            entity.Property(e => e.Size_Width).HasComment("사이즈_너비");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Area).WithMany(p => p.TB_Invitation_Area)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Area_TO_TB_Invitation_Area");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Invitation_Area)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TO_TB_Invitation_Area");
        });

        modelBuilder.Entity<TB_Invitation_Detail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장_상세"));

            entity.Property(e => e.Invitation_ID)
                .ValueGeneratedNever()
                .HasComment("초대장_ID");
            entity.Property(e => e.Bride_EngName).HasComment("신부_영문명");
            entity.Property(e => e.Bride_Global_Phone_Number).HasComment("신부_국제_전화_번호");
            entity.Property(e => e.Bride_Global_Phone_YN)
                .IsFixedLength()
                .HasComment("신부_국제_전화_여부");
            entity.Property(e => e.Bride_Name).HasComment("신부_명");
            entity.Property(e => e.Bride_Parents1_Global_Phone_Number).HasComment("신부_혼주1_국제_전화_번호");
            entity.Property(e => e.Bride_Parents1_Global_Phone_Number_YN)
                .IsFixedLength()
                .HasComment("신부_혼주1_국제_전화_번호_여부");
            entity.Property(e => e.Bride_Parents1_Name).HasComment("신부_혼주1_명칭");
            entity.Property(e => e.Bride_Parents1_Phone).HasComment("신부_혼주1_전화");
            entity.Property(e => e.Bride_Parents1_Title).HasComment("신부_혼주1_호칭");
            entity.Property(e => e.Bride_Parents2_Global_Phone_Number).HasComment("신부_혼주2_국제_전화_번호");
            entity.Property(e => e.Bride_Parents2_Global_Phone_Number_YN)
                .IsFixedLength()
                .HasComment("신부_혼주2_국제_전화_번호_여부");
            entity.Property(e => e.Bride_Parents2_Name).HasComment("신부_혼주2_명칭");
            entity.Property(e => e.Bride_Parents2_Phone).HasComment("신부_혼주2_전화");
            entity.Property(e => e.Bride_Parents2_Title).HasComment("신부_혼주2_호칭");
            entity.Property(e => e.Bride_Phone).HasComment("신부_전화");
            entity.Property(e => e.Conf_KaKaoPay_YN).IsFixedLength();
            entity.Property(e => e.Conf_Remit_YN).IsFixedLength();
            entity.Property(e => e.Delegate_Image_URL).HasComment("대표_이미지_URL");
            entity.Property(e => e.DetailNewLineYN).IsFixedLength();
            entity.Property(e => e.Etc_Information_Use_YN)
                .IsFixedLength()
                .HasComment("기타_정보_사용_여부");
            entity.Property(e => e.Flower_gift_YN)
                .IsFixedLength()
                .HasComment("화환선물하기");
            entity.Property(e => e.GalleryPreventPhoto_YN)
                .IsFixedLength()
                .HasComment("사진확대방지");
            entity.Property(e => e.Gallery_Type_Code).HasComment("갤러리_유형_코드");
            entity.Property(e => e.Gallery_Use_YN)
                .IsFixedLength()
                .HasComment("갤러리_사용_여부");
            entity.Property(e => e.Greetings).HasComment("인사말");
            entity.Property(e => e.Groom_EngName).HasComment("신랑_영문명");
            entity.Property(e => e.Groom_Global_Phone_Number).HasComment("신랑_국제_전화");
            entity.Property(e => e.Groom_Global_Phone_YN)
                .IsFixedLength()
                .HasComment("신랑_국제_전화_여부");
            entity.Property(e => e.Groom_Name).HasComment("신랑_명");
            entity.Property(e => e.Groom_Parents1_Global_Phone_Number).HasComment("신랑_혼주1_국제_전화_번호");
            entity.Property(e => e.Groom_Parents1_Global_Phone_Number_YN)
                .IsFixedLength()
                .HasComment("신랑_혼주1_국제_전화_번호_여부");
            entity.Property(e => e.Groom_Parents1_Name).HasComment("신랑_혼주1_명칭");
            entity.Property(e => e.Groom_Parents1_Phone).HasComment("신랑_혼주1_전화");
            entity.Property(e => e.Groom_Parents1_Title).HasComment("신랑_혼주1_호칭");
            entity.Property(e => e.Groom_Parents2_Global_Phone_Number).HasComment("신랑_혼주2_국제_전화_번호");
            entity.Property(e => e.Groom_Parents2_Global_Phone_Number_YN)
                .IsFixedLength()
                .HasComment("신랑_혼주2_국제_전화_번호_여부");
            entity.Property(e => e.Groom_Parents2_Name).HasComment("신랑_혼주2_명칭");
            entity.Property(e => e.Groom_Parents2_Phone).HasComment("신랑_혼주2_전화");
            entity.Property(e => e.Groom_Parents2_Title).HasComment("신랑_혼주2_호칭");
            entity.Property(e => e.Groom_Phone).HasComment("신랑_전화");
            entity.Property(e => e.GuestBook_Use_YN)
                .IsFixedLength()
                .HasComment("방명록_사용_여부");
            entity.Property(e => e.Invitation_Display_YN).IsFixedLength();
            entity.Property(e => e.Invitation_Title).HasComment("초대장_제목");
            entity.Property(e => e.Invitation_URL).HasComment("초대장_URL");
            entity.Property(e => e.Invitation_Video_Type_Code).HasComment("초대_영상_유형_코드");
            entity.Property(e => e.Invitation_Video_URL).HasComment("초대_영상_URL");
            entity.Property(e => e.Invitation_Video_Use_YN)
                .IsFixedLength()
                .HasComment("초대_영상_사용_여부");
            entity.Property(e => e.Location_LAT).HasComment("좌표_LAT");
            entity.Property(e => e.Location_LOT).HasComment("좌표_LOT");
            entity.Property(e => e.MMS_Send_YN).IsFixedLength();
            entity.Property(e => e.MoneyAccount_Div_Use_YN).IsFixedLength();
            entity.Property(e => e.MoneyAccount_Remit_Use_YN).IsFixedLength();
            entity.Property(e => e.MoneyGift_Remit_Use_YN)
                .IsFixedLength()
                .HasComment("축의금_송금_사용_여부");
            entity.Property(e => e.Outline_Image_URL).HasComment("약도_이미지_URL");
            entity.Property(e => e.Outline_Type_Code).HasComment("약도_구분_코드");
            entity.Property(e => e.Parents_Information_Use_YN)
                .IsFixedLength()
                .HasComment("혼주_정보_사용_여부");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.SNS_Image_URL).HasComment("SNS_이미지_URL");
            entity.Property(e => e.Sender).HasComment("보내는이");
            entity.Property(e => e.Time_Type_Code).HasComment("시간_구분_코드");
            entity.Property(e => e.Time_Type_Eng_YN)
                .IsFixedLength()
                .HasComment("시간_구분_영문_여부");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
            entity.Property(e => e.WeddingDD).HasComment("예식일");
            entity.Property(e => e.WeddingDate).HasComment("예식일자");
            entity.Property(e => e.WeddingHHmm).HasComment("예식시분");
            entity.Property(e => e.WeddingHallDetail).HasComment("층홀실");
            entity.Property(e => e.WeddingHour).IsFixedLength();
            entity.Property(e => e.WeddingMM).HasComment("예식월");
            entity.Property(e => e.WeddingMin).HasComment("예식분");
            entity.Property(e => e.WeddingWeek).HasComment("예식요일");
            entity.Property(e => e.WeddingWeek_Eng_YN)
                .IsFixedLength()
                .HasComment("예식요일_영어_여부");
            entity.Property(e => e.WeddingYY).HasComment("예식년");
            entity.Property(e => e.Weddinghall_Address).HasComment("예식장주소");
            entity.Property(e => e.Weddinghall_Name).HasComment("예식장_명");
            entity.Property(e => e.Weddinghall_PhoneNumber).HasComment("예식장_연락처");

            entity.HasOne(d => d.Invitation).WithOne(p => p.TB_Invitation_Detail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TO_TB_Invitation_Detail");
        });

        modelBuilder.Entity<TB_Invitation_Detail_Etc>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장_상세_기타"));

            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Etc_Title).HasComment("기타_제목");
            entity.Property(e => e.Information_Content).HasComment("정보_내용");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Invitation_Detail_Etc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TO_TB_Invitation_Detail_Etc");
        });

        modelBuilder.Entity<TB_Invitation_Item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장_아이템"));

            entity.Property(e => e.Item_ID).HasComment("아이템_ID");
            entity.Property(e => e.Area_ID).HasComment("영역_ID");
            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Item_Type_Code).HasComment("아이템_유형_코드");
            entity.Property(e => e.Location_Left).HasComment("위치_LEFT");
            entity.Property(e => e.Location_Top).HasComment("위치_TOP");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Resource_ID).HasComment("리소스_ID");
            entity.Property(e => e.Size_Height).HasComment("사이즈_높이");
            entity.Property(e => e.Size_Width).HasComment("사이즈_너비");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Invitation_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Invitation_TO_TB_Invitation_Item");

            entity.HasOne(d => d.Resource).WithMany(p => p.TB_Invitation_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Item_Resource_TO_TB_Invitation_Item");
        });

        modelBuilder.Entity<TB_Invitation_Tax>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초대장_수수료"));

            entity.Property(e => e.Invitation_ID)
                .ValueGeneratedNever()
                .HasComment("초대장_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Tax_ID).HasComment("수수료_ID");

            entity.HasOne(d => d.Tax).WithMany(p => p.TB_Invitation_Tax).HasConstraintName("FK_TB_Tax_TO_TB_Invitation_Tax");
        });

        modelBuilder.Entity<TB_Item_Resource>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("아이템_리소스"));

            entity.Property(e => e.Resource_ID).HasComment("리소스_ID");
            entity.Property(e => e.Background_Color).HasComment("배경_색상");
            entity.Property(e => e.BetweenLine).HasComment("행간");
            entity.Property(e => e.BetweenText).HasComment("자간");
            entity.Property(e => e.Bold_YN)
                .IsFixedLength()
                .HasComment("굵게_여부");
            entity.Property(e => e.CharacterSet).HasComment("신랑명 & 신부명\r\n");
            entity.Property(e => e.Character_Size).HasComment("문자_크기");
            entity.Property(e => e.Color).HasComment("색상");
            entity.Property(e => e.Font).HasComment("폰트");
            entity.Property(e => e.Horizontal_Alignment)
                .IsFixedLength()
                .HasComment("수평_정렬");
            entity.Property(e => e.Italic_YN)
                .IsFixedLength()
                .HasComment("이탤릭체_여부");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Resource_Height).HasComment("리소스_높이");
            entity.Property(e => e.Resource_Type_Code).HasComment("I : 이미지\r\nM : 동영상\r\nT : 텍스트");
            entity.Property(e => e.Resource_URL).HasComment("리소스_URL");
            entity.Property(e => e.Resource_Width).HasComment("리소스_너비");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Underline_YN)
                .IsFixedLength()
                .HasComment("밑줄_여부");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
            entity.Property(e => e.Vertical_Alignment)
                .IsFixedLength()
                .HasComment("수직_정렬");
        });

        modelBuilder.Entity<TB_Kakao_Cache>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카카오_케시"));

            entity.Property(e => e.Cache_ID).HasComment("케시_ID");
            entity.Property(e => e.Cache_URL).HasComment("케시_URL");
            entity.Property(e => e.Progress_DateTime).HasComment("처리_일시");
            entity.Property(e => e.Progress_YN)
                .IsFixedLength()
                .HasComment("처리_여부");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
        });

        modelBuilder.Entity<TB_Order>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주문"));

            entity.Property(e => e.Order_ID).HasComment("주문_ID");
            entity.Property(e => e.CashReceipt_Publish_YN).IsFixedLength();
            entity.Property(e => e.CellPhone_Number).HasComment("휴대전화_번호");
            entity.Property(e => e.Coupon_Price).HasComment("쿠폰_금액");
            entity.Property(e => e.Email).HasComment("이메일");
            entity.Property(e => e.Escrow_YN).IsFixedLength();
            entity.Property(e => e.Name).HasComment("이름");
            entity.Property(e => e.Noint_YN).IsFixedLength();
            entity.Property(e => e.Order_Code).HasComment("주문_코드");
            entity.Property(e => e.Order_Price).HasComment("주문_금액");
            entity.Property(e => e.Order_Status_Code).HasComment("주문_상태_코드");
            entity.Property(e => e.PG_ID).HasComment("PG_ID");
            entity.Property(e => e.Payment_Method_Code).HasComment("결제_방법_코드");
            entity.Property(e => e.Payment_Price).HasComment("결제_금액");
            entity.Property(e => e.Payment_Status_Code).HasComment("결제_상태_코드");
            entity.Property(e => e.Previous_Order_ID).HasComment("이전_주문_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Previous_Order).WithMany(p => p.InversePrevious_Order).HasConstraintName("FK_TB_Order_TO_TB_Order");
        });

        modelBuilder.Entity<TB_Order_Copy>(entity =>
        {
            entity.Property(e => e.CashReceipt_Publish_YN).IsFixedLength();
            entity.Property(e => e.Escrow_YN).IsFixedLength();
            entity.Property(e => e.Noint_YN).IsFixedLength();
        });

        modelBuilder.Entity<TB_Order_Coupon_Use>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주문_쿠폰_사용"));

            entity.Property(e => e.Order_ID)
                .ValueGeneratedNever()
                .HasComment("주문_ID");
            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰_발행_ID");
            entity.Property(e => e.Discount_Price).HasComment("할인_금액");

            entity.HasOne(d => d.Coupon_Publish).WithMany(p => p.TB_Order_Coupon_Use)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Coupon_Publish_TO_TB_Order_Coupon_Use");

            entity.HasOne(d => d.Order).WithOne(p => p.TB_Order_Coupon_Use)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Order_TO_TB_Order_Coupon_Use");
        });

        modelBuilder.Entity<TB_Order_PartnerShip>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("파트너 연동 주문 정보"));

            entity.Property(e => e.P_OrderCode).HasComment("파트너사 주문번호");
            entity.Property(e => e.P_Id).HasComment("파트너사 고유ID");
            entity.Property(e => e.Is_Refund).HasComment("최소 여부");
            entity.Property(e => e.Order_ID).HasComment("바른손 주문_ID");
            entity.Property(e => e.P_ExtendData).HasComment("파트너사 확장 데이터");
            entity.Property(e => e.P_OrderDate).HasComment("주문일");
            entity.Property(e => e.P_OrderState).HasComment("파트너사 주문 상태코드");
            entity.Property(e => e.P_Order_Name).HasComment("주문자명");
            entity.Property(e => e.P_Order_Phone).HasComment("주문자연락처");
            entity.Property(e => e.P_ProductCode).HasComment("상품코드");
            entity.Property(e => e.P_ProductName).HasComment("상품명");
            entity.Property(e => e.Payment_Method_Code).HasComment("결제_방법_코드");
            entity.Property(e => e.Payment_Price).HasComment("결제_금액");
            entity.Property(e => e.Payment_Status_Code).HasComment("결제_상태_코드");
        });

        modelBuilder.Entity<TB_Order_Product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주문_상품"));

            entity.Property(e => e.Order_ID).HasComment("주문_ID");
            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Item_Count).HasComment("아이템_수량");
            entity.Property(e => e.Item_Price).HasComment("아이템_가격");
            entity.Property(e => e.Product_Type_Code).HasComment("상품_구분_코드");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Total_Price).HasComment("전체_가격");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Order).WithMany(p => p.TB_Order_Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Order_TO_TB_Order_Product");

            entity.HasOne(d => d.Product).WithMany(p => p.TB_Order_Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Product_TO_TB_Order_Product");
        });

        modelBuilder.Entity<TB_Order_Serial_Coupon_Use>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주문_쿠폰_사용"));

            entity.Property(e => e.Order_ID)
                .ValueGeneratedNever()
                .HasComment("주문_ID");
            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰_발행_ID");
            entity.Property(e => e.Discount_Price).HasComment("할인_금액");

            entity.HasOne(d => d.Coupon_Publish).WithMany(p => p.TB_Order_Serial_Coupon_Use).HasConstraintName("FK_TB_Serial_Coupon_Publish_TO_TB_Order_Serial_Coupon_Use");

            entity.HasOne(d => d.Order).WithOne(p => p.TB_Order_Serial_Coupon_Use)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Order_TO_TB_Order_Serial_Coupon_Use");
        });

        modelBuilder.Entity<TB_Payment_Status_Day>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("결제_수단_일별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Account_Transfer_Price).HasComment("계좌_이체_금액");
            entity.Property(e => e.Cancel_Refund_Price).HasComment("취소_환불_금액");
            entity.Property(e => e.Card_Payment_Price).HasComment("카드_결제_금액");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Etc_Price).HasComment("기타_금액");
            entity.Property(e => e.Profit_Price).HasComment("순매출_금액");
            entity.Property(e => e.Total_Price).HasComment("합계_금액");
            entity.Property(e => e.Virtual_Account_Price).HasComment("가상_계좌_금액");
        });

        modelBuilder.Entity<TB_Payment_Status_Month>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("결제_수단_월별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Account_Transfer_Price).HasComment("계좌_이체_금액");
            entity.Property(e => e.Cancel_Refund_Price).HasComment("취소_환불_금액");
            entity.Property(e => e.Card_Payment_Price).HasComment("카드_결제_금액");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Etc_Price).HasComment("기타_금액");
            entity.Property(e => e.Profit_Price).HasComment("순매출_금액");
            entity.Property(e => e.Total_Price).HasComment("합계_금액");
            entity.Property(e => e.Virtual_Account_Price).HasComment("가상_계좌_금액");
        });

        modelBuilder.Entity<TB_Popup>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("팝업"));

            entity.Property(e => e.Popup_ID).HasComment("팝업_ID");
            entity.Property(e => e.Popup_Height).HasComment("팝업_높이");
            entity.Property(e => e.Popup_Location_Left).HasComment("팝업_위치_LEFT");
            entity.Property(e => e.Popup_Location_Top).HasComment("팝업_위치_TOP");
            entity.Property(e => e.Popup_Mobile_YN)
                .IsFixedLength()
                .HasComment("팝업_모바일_여부");
            entity.Property(e => e.Popup_PC_YN)
                .IsFixedLength()
                .HasComment("팝업_PC_여부");
            entity.Property(e => e.Popup_Title).HasComment("팝업_제목");
            entity.Property(e => e.Popup_Width).HasComment("팝업_너비");
        });

        modelBuilder.Entity<TB_Popup_Item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("팝업_아이템"));

            entity.Property(e => e.Popup_Item_ID).HasComment("팝업_아이템_ID");
            entity.Property(e => e.End_Date).HasComment("종료_날짜");
            entity.Property(e => e.End_Time).HasComment("종료_시간");
            entity.Property(e => e.Image_URL).HasComment("이미지_URL");
            entity.Property(e => e.Link_URL).HasComment("링크_URL");
            entity.Property(e => e.Period_Type_Code).HasComment("날짜지정\r\n무제");
            entity.Property(e => e.Popup_ID).HasComment("팝업_ID");
            entity.Property(e => e.Popup_Type_Code).HasComment("PC\r\n모바일\r\n");
            entity.Property(e => e.Start_Date).HasComment("시작_날짜");
            entity.Property(e => e.Start_Time).HasComment("시작_시간");

            entity.HasOne(d => d.Popup).WithMany(p => p.TB_Popup_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Popup_TO_TB_Popup_Item");
        });

        modelBuilder.Entity<TB_Product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품"));

            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Display_YN)
                .IsFixedLength()
                .HasComment("진열_여부");
            entity.Property(e => e.Main_Image_URL).HasComment("대표_이미지_URL");
            entity.Property(e => e.Price).HasComment("가격");
            entity.Property(e => e.Product_Brand_Code).HasComment("상품_브랜드_코드");
            entity.Property(e => e.Product_Category_Code).HasComment("청첩장\r\n감사장\r\n포토형\r\n\r\n답례품\r\n");
            entity.Property(e => e.Product_Code).HasComment("상품_코드");
            entity.Property(e => e.Product_Description).HasComment("상품_설명");
            entity.Property(e => e.Product_Name).HasComment("상품_명");
            entity.Property(e => e.SetCard_Display_YN).IsFixedLength();
            entity.Property(e => e.Template_ID).HasComment("템플릿_ID");

            entity.HasOne(d => d.Template).WithMany(p => p.TB_Product).HasConstraintName("FK_TB_Template_TO_TB_Product");
        });

        modelBuilder.Entity<TB_Product_Category>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품_분류"));

            entity.Property(e => e.Category_ID).HasComment("분류_ID");
            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Sort).HasComment("순서");

            entity.HasOne(d => d.Product).WithMany(p => p.TB_Product_Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Product_TO_TB_Product_Category");
        });

        modelBuilder.Entity<TB_Product_Icon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품_아이콘"));

            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Icon_ID).HasComment("아이콘_ID");

            entity.HasOne(d => d.Icon).WithMany(p => p.TB_Product_Icon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Icon_TO_TB_Product_Icon");

            entity.HasOne(d => d.Product).WithMany(p => p.TB_Product_Icon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Product_TO_TB_Product_Icon");
        });

        modelBuilder.Entity<TB_Product_Image>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품_이미지"));

            entity.Property(e => e.Image_ID).HasComment("이미지_ID");
            entity.Property(e => e.Image_Type_Code).HasComment("이미지_유형_코드");
            entity.Property(e => e.Image_URL).HasComment("이미지_URL");
            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Product).WithMany(p => p.TB_Product_Image)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Product_TO_TB_Product_Image");
        });

        modelBuilder.Entity<TB_Refund_Info>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("환불_정보"));

            entity.Property(e => e.Refund_ID).HasComment("환불_ID");
            entity.Property(e => e.AccountNumber).HasComment("계좌번호");
            entity.Property(e => e.Bank_Type_Code).HasComment("은행_구분_코드");
            entity.Property(e => e.Depositor_Name).HasComment("예금주_명");
            entity.Property(e => e.Order_ID).HasComment("주문_ID");
            entity.Property(e => e.Refund_Content).HasComment("환불_내용");
            entity.Property(e => e.Refund_DateTime).HasComment("환불_일시");
            entity.Property(e => e.Refund_Price).HasComment("환불_금액");
            entity.Property(e => e.Refund_Status_Code).HasComment("환불_상태_코드");
            entity.Property(e => e.Refund_Type_Code).HasComment("환불_유형_코드");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Order).WithMany(p => p.TB_Refund_Info)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Order_TO_TB_Refund_Info");
        });

        modelBuilder.Entity<TB_Remit>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("송금_정보"));

            entity.Property(e => e.Remit_ID).HasComment("송금_ID");
            entity.Property(e => e.Account_ID).HasComment("계좌_ID");
            entity.Property(e => e.Account_Number).HasComment("더즌에서 할당받은 카카오페이 계좌번호\r\n");
            entity.Property(e => e.Bank_Code).HasComment("더즌에서 할당 받은 카카오페이 결제 은행코드\r\n");
            entity.Property(e => e.Complete_DateTime).HasComment("완료_일시");
            entity.Property(e => e.Coupon_Order_ID).HasComment("쿠폰_주문_ID");
            entity.Property(e => e.Invitation_ID).HasComment("초대장_ID");
            entity.Property(e => e.Item_Name).HasComment("혼주 예금주로 대응\r\n");
            entity.Property(e => e.Partner_Order_ID).HasComment("유니크인덱스 설정 필요\r\n\r\n[년월일] + [제로필 일련번호5자리]\r\n2021123100000");
            entity.Property(e => e.Payment_Token).HasComment("결제_토큰");
            entity.Property(e => e.Ready_DateTime).HasComment("준비_일시");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Remitter_Name).HasComment("송금자_명");
            entity.Property(e => e.Request_DateTime).HasComment("요청_일시");
            entity.Property(e => e.Result_Code).HasComment("R0 : 준비요청\r\nR1 : 준비완료\r\nP2 : 승인요청\r\nP3 : 승인완료\r\n\r\nRC : 준비취소\r\nRF : 준비실패\r\nPF : 승인실패\r\n\r\nC0 : 정산 완료");
            entity.Property(e => e.Send_Status).HasComment("전송_상태");
            entity.Property(e => e.Total_Price).HasComment("전체_금액");
            entity.Property(e => e.Transaction_Detail_ID).HasComment("더즌에서 받는 정보\r\n");
            entity.Property(e => e.Transaction_ID).HasComment("더즌에서 받는 정보\r\n");

            entity.HasOne(d => d.Coupon_Order).WithMany(p => p.TB_Remit).HasConstraintName("FK_TB_Coupon_Order_TO_TB_Remit");

            entity.HasOne(d => d.Invitation).WithMany(p => p.TB_Remit).HasConstraintName("FK_TB_Invitation_Tax_TO_TB_Remit");
        });

        modelBuilder.Entity<TB_Remit_Statistics_Daily>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("송금_통계"));

            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Account_Count).HasComment("계좌_수");
            entity.Property(e => e.Calculate_Tax).HasComment("업체_수수료");
            entity.Property(e => e.Hits_Tax).HasComment("조회_수수료");
            entity.Property(e => e.Remit_Count).HasComment("송금_수");
            entity.Property(e => e.Remit_Price).HasComment("송금_금액");
            entity.Property(e => e.Tax).HasComment("수수료");
            entity.Property(e => e.User_Count).HasComment("사용자_수");
        });

        modelBuilder.Entity<TB_Remit_Statistics_Monthly>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("송금_통계"));

            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Account_Count).HasComment("계좌_수");
            entity.Property(e => e.Calculate_Tax).HasComment("업체_수수료");
            entity.Property(e => e.Hits_Tax).HasComment("조회_수수료");
            entity.Property(e => e.Remit_Count).HasComment("송금_수");
            entity.Property(e => e.Remit_Price).HasComment("송금_금액");
            entity.Property(e => e.Tax).HasComment("수수료");
            entity.Property(e => e.User_Count).HasComment("사용자_수");
        });

        modelBuilder.Entity<TB_ReservationWord>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예약어"));

            entity.Property(e => e.ReserveWord_ID).HasComment("예약어_ID");
            entity.Property(e => e.DefaultValue).HasComment("기본값");
            entity.Property(e => e.MappingField).HasComment("맵핑필드");
            entity.Property(e => e.Mapping_YN).IsFixedLength();
            entity.Property(e => e.ReserveWord).HasComment("예약어");
        });

        modelBuilder.Entity<TB_Sales_Statistic_Day>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("매출_통계_일별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Barunn_Charge_Order_Count).HasComment("바른손_유료_주문_수");
            entity.Property(e => e.Barunn_Free_Order_Count).HasComment("바른손_무료_주문_수");
            entity.Property(e => e.Barunn_Sales_Price).HasComment("바른손_매출_금액");
            entity.Property(e => e.Bhands_Charge_Order_Count).HasComment("비핸즈_유료_주문 _수");
            entity.Property(e => e.Bhands_Free_Order_Count).HasComment("비핸즈_무료_주문 _수");
            entity.Property(e => e.Bhands_Sales_Price).HasComment("비핸즈_매출_금액");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Premier_Charge_Order_Count).HasComment("프리미어_유료_주문_수");
            entity.Property(e => e.Premier_Free_Order_Count).HasComment("프리미어_무료_주문_수");
            entity.Property(e => e.Premier_Sales_Price).HasComment("프리미어_매출_금액 ");
            entity.Property(e => e.Thecard_Charge_Order_Count).HasComment("더카드_유료_주문_수 ");
            entity.Property(e => e.Thecard_Free_Order_Count).HasComment("더카드_무료_주문_수 ");
            entity.Property(e => e.Thecard_Sales_Price).HasComment("더카드_매출_금액");
            entity.Property(e => e.Total_Charge_Order_Count).HasComment("합계_유료_주문_수");
            entity.Property(e => e.Total_Free_Order_Count).HasComment("합계_무료_주문_수");
            entity.Property(e => e.Total_Sales_Price).HasComment("합계_매출_금액");
        });

        modelBuilder.Entity<TB_Sales_Statistic_Month>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("매출_통계_월별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Barunn_Charge_Order_Count).HasComment("바른손_유료_주문_수");
            entity.Property(e => e.Barunn_Free_Order_Count).HasComment("바른손_무료_주문_수");
            entity.Property(e => e.Barunn_Sales_Price).HasComment("바른손_매출_금액");
            entity.Property(e => e.Bhands_Charge_Order_Count).HasComment("비핸즈_유료_주문 _수");
            entity.Property(e => e.Bhands_Free_Order_Count).HasComment("비핸즈_무료_주문 _수");
            entity.Property(e => e.Bhands_Sales_Price).HasComment("비핸즈_매출_금액");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Premier_Charge_Order_Count).HasComment("프리미어_유료_주문_수");
            entity.Property(e => e.Premier_Free_Order_Count).HasComment("프리미어_무료_주문_수");
            entity.Property(e => e.Premier_Sales_Price).HasComment("프리미어_매출_금액 ");
            entity.Property(e => e.Thecard_Charge_Order_Count).HasComment("더카드_유료_주문_수 ");
            entity.Property(e => e.Thecard_Free_Order_Count).HasComment("더카드_무료_주문_수 ");
            entity.Property(e => e.Thecard_Sales_Price).HasComment("더카드_매출_금액");
            entity.Property(e => e.Total_Charge_Order_Count).HasComment("합계_유료_주문_수");
            entity.Property(e => e.Total_Free_Order_Count).HasComment("합계_무료_주문_수");
            entity.Property(e => e.Total_Sales_Price).HasComment("합계_매출_금액");
        });

        modelBuilder.Entity<TB_Serial_Apply_Product>(entity =>
        {
            entity.Property(e => e.Product_Apply_ID).HasComment("상품_적용_ID");
            entity.Property(e => e.Product_Code).HasComment("상품_코드");

            entity.HasOne(d => d.Product_Apply).WithMany(p => p.TB_Serial_Apply_Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Serial_Coupon_Apply_Product_TO_TB_Serial_Apply_Product");
        });

        modelBuilder.Entity<TB_Serial_Coupon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰"));

            entity.Property(e => e.Coupon_ID).HasComment("쿠폰_ID");
            entity.Property(e => e.Coupon_Apply_Code).HasComment("쿠폰_적용_코드");
            entity.Property(e => e.Coupon_Apply_Product_ID).HasComment("쿠폰_적용_상품_ID");
            entity.Property(e => e.Coupon_Image_URL).HasComment("쿠폰_이미지_URL");
            entity.Property(e => e.Coupon_Name).HasComment("쿠폰_명");
            entity.Property(e => e.Coupon_Type_Code).HasComment("쿠폰_유형_코드");
            entity.Property(e => e.Description).HasComment("설명");
            entity.Property(e => e.Discount_Method_Code).HasComment("할인_방식_코드");
            entity.Property(e => e.Discount_Price).HasComment("할인_금액");
            entity.Property(e => e.Discount_Rate).HasComment("할인_율");
            entity.Property(e => e.Period_Method_Code).HasComment("기간_방식_코드");
            entity.Property(e => e.Publish_End_Date).HasComment("발행_종료_일자");
            entity.Property(e => e.Publish_Period_Code).HasComment("발행_기간_코드");
            entity.Property(e => e.Publish_Start_Date).HasComment("발행_시작_일자");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Standard_Purchase_Price).HasComment("기준_구매_금액");
            entity.Property(e => e.Use_Available_Standard_Code).HasComment("사용_가능_기준_코드");
            entity.Property(e => e.Use_YN)
                .IsFixedLength()
                .HasComment("사용_여부");
        });

        modelBuilder.Entity<TB_Serial_Coupon_Apply_Product>(entity =>
        {
            entity.HasKey(e => e.Product_Apply_ID).IsClustered(false);

            entity.Property(e => e.Product_Apply_ID).HasComment("상품_적용_ID");
        });

        modelBuilder.Entity<TB_Serial_Coupon_Publish>(entity =>
        {
            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰_발행_ID");
            entity.Property(e => e.Coupon_ID).HasComment("쿠폰_ID");
            entity.Property(e => e.Expiration_Date).HasComment("만료_일자");
            entity.Property(e => e.Retrieve_DateTime).HasComment("회수_일시");
            entity.Property(e => e.Use_DateTime).HasComment("사용_일시");
            entity.Property(e => e.Use_YN)
                .IsFixedLength()
                .HasComment("사용_여부");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");

            entity.HasOne(d => d.Coupon).WithMany(p => p.TB_Serial_Coupon_Publish)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Serial_Coupon_TO_TB_Serial_Coupon_Publish");
        });

        modelBuilder.Entity<TB_Standard_Date>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("기준_날짜"));

            entity.Property(e => e.Standard_Date).HasComment("기준_날짜");
        });

        modelBuilder.Entity<TB_Tax>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("수수료"));

            entity.Property(e => e.Tax_ID).HasComment("수수료_ID");
            entity.Property(e => e.Previous_Tax).HasComment("이전_수수료");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Tax).HasComment("수수료");
        });

        modelBuilder.Entity<TB_Temp_Order>(entity =>
        {
            entity.HasKey(e => e.Order_Code).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("주문_임시"));

            entity.Property(e => e.Order_Code).HasComment("주문코드");
            entity.Property(e => e.Coupon_Price).HasComment("쿠폰가격");
            entity.Property(e => e.Coupon_Publish_ID).HasComment("쿠폰발급아이디");
        });

        modelBuilder.Entity<TB_Template>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("템플릿"));

            entity.Property(e => e.Template_ID).HasComment("템플릿_ID");
            entity.Property(e => e.Photo_YN)
                .IsFixedLength()
                .HasComment("포토_여부");
            entity.Property(e => e.Preview_URL).HasComment("미리보기_URL");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Template_Name).HasComment("템플릿_명");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
        });

        modelBuilder.Entity<TB_Template_Area>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("템플릿_영역"));

            entity.Property(e => e.Template_ID).HasComment("템플릿_ID");
            entity.Property(e => e.Area_ID).HasComment("영역_ID");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Size_Height).HasComment("사이즈_높이");
            entity.Property(e => e.Size_Width).HasComment("사이즈_너비");
            entity.Property(e => e.Sort).HasComment("순서");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Area).WithMany(p => p.TB_Template_Area)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Area_TO_TB_Template_Area");

            entity.HasOne(d => d.Template).WithMany(p => p.TB_Template_Area)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Template_TO_TB_Template_Area");
        });

        modelBuilder.Entity<TB_Template_Detail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("템플릿 상세"));

            entity.Property(e => e.Template_ID)
                .ValueGeneratedNever()
                .HasComment("템플릿_ID");
            entity.Property(e => e.Bride_EngName).HasComment("신부_영문명");
            entity.Property(e => e.Bride_Name).HasComment("신부_명");
            entity.Property(e => e.Bride_Parents1_Name).HasComment("신부_혼주1_명칭");
            entity.Property(e => e.Bride_Parents1_Phone).HasComment("신부_혼주1_전화");
            entity.Property(e => e.Bride_Parents2_Name).HasComment("신부_혼주2_명칭");
            entity.Property(e => e.Bride_Parents2_Phone).HasComment("신부_혼주2_전화");
            entity.Property(e => e.Bride_Phone).HasComment("신부_전화");
            entity.Property(e => e.Etc_Bus_Information).HasComment("기타_버스_안내");
            entity.Property(e => e.Etc_Car_Information).HasComment("기타_자가용_안내");
            entity.Property(e => e.Greetings).HasComment("인사말");
            entity.Property(e => e.Groom_EngName).HasComment("신랑_영문명");
            entity.Property(e => e.Groom_Name).HasComment("신랑_명");
            entity.Property(e => e.Groom_Parents1_Name).HasComment("신랑_혼주1_명칭");
            entity.Property(e => e.Groom_Parents1_Phone).HasComment("신랑_혼주1_전화");
            entity.Property(e => e.Groom_Parents2_Name).HasComment("신랑_혼주2_명칭");
            entity.Property(e => e.Groom_Parents2_Phone).HasComment("신랑_혼주2_전화");
            entity.Property(e => e.Groom_Phone).HasComment("신랑_전화");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Time_Type_Code).HasComment("시간_구분_코드");
            entity.Property(e => e.Time_Type_Eng_YN)
                .IsFixedLength()
                .HasComment("시간_구분_영문_여부");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");
            entity.Property(e => e.WeddingDD).HasComment("예식일");
            entity.Property(e => e.WeddingDate).HasComment("예식일자");
            entity.Property(e => e.WeddingHHmm).HasComment("예식시분");
            entity.Property(e => e.WeddingHallDetail).HasComment("층홀실");
            entity.Property(e => e.WeddingHour).HasComment("예식시간");
            entity.Property(e => e.WeddingMM).HasComment("예식월");
            entity.Property(e => e.WeddingMin).HasComment("예식분");
            entity.Property(e => e.WeddingWeek).HasComment("예식요일");
            entity.Property(e => e.WeddingWeek_Eng_YN)
                .IsFixedLength()
                .HasComment("예식요일_영어_여부");
            entity.Property(e => e.WeddingYY).HasComment("예식년");
            entity.Property(e => e.Weddinghall_Address).HasComment("예식장_주소1");
            entity.Property(e => e.Weddinghall_Name).HasComment("예식장_명");
            entity.Property(e => e.Weddinghall_PhoneNumber).HasComment("예식장_연락처");

            entity.HasOne(d => d.Template).WithOne(p => p.TB_Template_Detail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Template_TO_TB_Template_Detail");
        });

        modelBuilder.Entity<TB_Template_Item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("템플릿_아이템"));

            entity.Property(e => e.Item_ID).HasComment("아이템_ID");
            entity.Property(e => e.Area_ID).HasComment("영역_ID");
            entity.Property(e => e.Item_Type_Code).HasComment("텍스트\r\n이미지\r\n");
            entity.Property(e => e.Location_Left).HasComment("위치_LEFT");
            entity.Property(e => e.Location_Top).HasComment("위치_TOP");
            entity.Property(e => e.Regist_DateTime).HasComment("등록_일시");
            entity.Property(e => e.Regist_IP).HasComment("등록_IP");
            entity.Property(e => e.Regist_User_ID).HasComment("등록_사용자_ID");
            entity.Property(e => e.Resource_ID).HasComment("리소스_ID");
            entity.Property(e => e.Size_Height).HasComment("사이즈_높이");
            entity.Property(e => e.Size_Width).HasComment("사이즈_너비");
            entity.Property(e => e.Template_ID).HasComment("템플릿_ID");
            entity.Property(e => e.Update_DateTime).HasComment("수정_일시");
            entity.Property(e => e.Update_IP).HasComment("수정_IP");
            entity.Property(e => e.Update_User_ID).HasComment("수정_사용자_ID");

            entity.HasOne(d => d.Resource).WithMany(p => p.TB_Template_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Item_Resource_TO_TB_Template_Item");

            entity.HasOne(d => d.Template).WithMany(p => p.TB_Template_Item).HasConstraintName("FK_TB_Template_TO_TB_Template_Item");
        });

        modelBuilder.Entity<TB_Total_Statistic_Day>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("전체_현황_일별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Cancel_Count).HasComment("취소_수");
            entity.Property(e => e.Cancel_Refund_Price).HasComment("취소_환불_금액");
            entity.Property(e => e.Charge_Order_Count).HasComment("유료_주문_수");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Free_Order_Count).HasComment("무료_주문_수");
            entity.Property(e => e.Memberjoin_Count).HasComment("회원가입_수");
            entity.Property(e => e.Payment_Price).HasComment("결제_금액");
            entity.Property(e => e.Profit_Price).HasComment("순매출_금액");
        });

        modelBuilder.Entity<TB_Total_Statistic_Month>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("전체_현황_월별"));

            entity.Property(e => e.ID).HasComment("ID");
            entity.Property(e => e.Cancel_Count).HasComment("취소_수");
            entity.Property(e => e.Cancel_Refund_Price).HasComment("취소_환불_금액");
            entity.Property(e => e.Charge_Order_Count).HasComment("유료_주문_수");
            entity.Property(e => e.Date).HasComment("날짜");
            entity.Property(e => e.Free_Order_Count).HasComment("무료_주문_수");
            entity.Property(e => e.Memberjoin_Count).HasComment("회원가입_수");
            entity.Property(e => e.Payment_Price).HasComment("결제_금액");
            entity.Property(e => e.Profit_Price).HasComment("순매출_금액");
        });

        modelBuilder.Entity<TB_Value_Entered_Login>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("로그인시 회원이 입력한 값 저장"));

            entity.Property(e => e.RESULT_CODE).HasComment("0000 정상\n1000 없음\n2000 두명 이상\n9000 기타 오류");
        });

        modelBuilder.Entity<TB_Wish_List>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("위시리스트"));

            entity.Property(e => e.Wish_ID).HasComment("찜_ID");
            entity.Property(e => e.Product_ID).HasComment("상품_ID");
            entity.Property(e => e.User_ID).HasComment("사용자_ID");
        });

        modelBuilder.Entity<VW_Admin>(entity =>
        {
            entity.ToView("VW_Admin");
        });

        modelBuilder.Entity<VW_Statics_Produce>(entity =>
        {
            entity.ToView("VW_Statics_Produce");

            entity.Property(e => e.DATE).IsFixedLength();
        });

        modelBuilder.Entity<VW_User>(entity =>
        {
            entity.ToView("VW_User");

            entity.Property(e => e.DUPINFO).IsFixedLength();
        });

        modelBuilder.Entity<VW_User_QNA>(entity =>
        {
            entity.ToView("VW_User_QNA");

            entity.Property(e => e.QNA_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<View_RandomNumber>(entity =>
        {
            entity.ToView("View_RandomNumber");
        });

        modelBuilder.Entity<tb_test22>(entity =>
        {
            entity.Property(e => e.GUBUN).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

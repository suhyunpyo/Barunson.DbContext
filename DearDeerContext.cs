using System;
using System.Collections.Generic;
using Barunson.DbContext.DbModels.DearDeer;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext;

public partial class DearDeerContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DearDeerContext(DbContextOptions<DearDeerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<addition_service> addition_service { get; set; }

    public virtual DbSet<addresses> addresses { get; set; }

    public virtual DbSet<admin_limit_setting> admin_limit_setting { get; set; }

    public virtual DbSet<admin_limit_setting_log> admin_limit_setting_log { get; set; }

    public virtual DbSet<admin_users> admin_users { get; set; }

    public virtual DbSet<banner_images> banner_images { get; set; }

    public virtual DbSet<banners> banners { get; set; }

    public virtual DbSet<best_sample> best_sample { get; set; }

    public virtual DbSet<best_sample_product> best_sample_product { get; set; }

    public virtual DbSet<block_manager> block_manager { get; set; }

    public virtual DbSet<board> board { get; set; }

    public virtual DbSet<board_content_attached> board_content_attached { get; set; }

    public virtual DbSet<board_content_reply> board_content_reply { get; set; }

    public virtual DbSet<board_contents> board_contents { get; set; }

    public virtual DbSet<card_greeting> card_greeting { get; set; }

    public virtual DbSet<categories> categories { get; set; }

    public virtual DbSet<categories_images> categories_images { get; set; }

    public virtual DbSet<category_product> category_product { get; set; }

    public virtual DbSet<category_serial_coupon> category_serial_coupon { get; set; }

    public virtual DbSet<cj_invoice_numbers> cj_invoice_numbers { get; set; }

    public virtual DbSet<code_map_barunson> code_map_barunson { get; set; }

    public virtual DbSet<common_code> common_code { get; set; }

    public virtual DbSet<contact_content_reply> contact_content_reply { get; set; }

    public virtual DbSet<contact_contents> contact_contents { get; set; }

    public virtual DbSet<content_images> content_images { get; set; }

    public virtual DbSet<cost_manage> cost_manage { get; set; }

    public virtual DbSet<counsel_contents> counsel_contents { get; set; }

    public virtual DbSet<coupon_hist> coupon_hist { get; set; }

    public virtual DbSet<coupon_info> coupon_info { get; set; }

    public virtual DbSet<coupon_issue> coupon_issue { get; set; }

    public virtual DbSet<coupon_serial_temp> coupon_serial_temp { get; set; }

    public virtual DbSet<coupon_user> coupon_user { get; set; }

    public virtual DbSet<coupons> coupons { get; set; }

    public virtual DbSet<coupons_category> coupons_category { get; set; }

    public virtual DbSet<coupons_product> coupons_product { get; set; }

    public virtual DbSet<daily_account_log> daily_account_log { get; set; }

    public virtual DbSet<draft_history> draft_history { get; set; }

    public virtual DbSet<draft_history_comment> draft_history_comment { get; set; }

    public virtual DbSet<email> email { get; set; }

    public virtual DbSet<event_board_comments> event_board_comments { get; set; }

    public virtual DbSet<event_board_options> event_board_options { get; set; }

    public virtual DbSet<event_boards> event_boards { get; set; }

    public virtual DbSet<event_boards_coupons> event_boards_coupons { get; set; }

    public virtual DbSet<faq_board_contents> faq_board_contents { get; set; }

    public virtual DbSet<faq_boards> faq_boards { get; set; }

    public virtual DbSet<hashtag> hashtag { get; set; }

    public virtual DbSet<hashtag_product> hashtag_product { get; set; }

    public virtual DbSet<holiday_calendar> holiday_calendar { get; set; }

    public virtual DbSet<homuro_board> homuro_board { get; set; }

    public virtual DbSet<homuro_board_item> homuro_board_item { get; set; }

    public virtual DbSet<indd_create_history> indd_create_history { get; set; }

    public virtual DbSet<invitation_card_addition> invitation_card_addition { get; set; }

    public virtual DbSet<invitation_card_addition_item> invitation_card_addition_item { get; set; }

    public virtual DbSet<item_stock_manage> item_stock_manage { get; set; }

    public virtual DbSet<item_stock_manage_item_typeset> item_stock_manage_item_typeset { get; set; }

    public virtual DbSet<item_stock_manage_log> item_stock_manage_log { get; set; }

    public virtual DbSet<item_typeset> item_typeset { get; set; }

    public virtual DbSet<jobs> jobs { get; set; }

    public virtual DbSet<lguplus_paid_list> lguplus_paid_list { get; set; }

    public virtual DbSet<link_indd_order_variable> link_indd_order_variable { get; set; }

    public virtual DbSet<login_attempts> login_attempts { get; set; }

    public virtual DbSet<main_display> main_display { get; set; }

    public virtual DbSet<main_display_product> main_display_product { get; set; }

    public virtual DbSet<marketing_agreement> marketing_agreement { get; set; }

    public virtual DbSet<marketing_agreement_log> marketing_agreement_log { get; set; }

    public virtual DbSet<marketing_agreement_type> marketing_agreement_type { get; set; }

    public virtual DbSet<marketing_agreement_view> marketing_agreement_view { get; set; }

    public virtual DbSet<mds_pick_products> mds_pick_products { get; set; }

    public virtual DbSet<mds_picks> mds_picks { get; set; }

    public virtual DbSet<message_mail_template> message_mail_template { get; set; }

    public virtual DbSet<migrations> migrations { get; set; }

    public virtual DbSet<mobile_card_account> mobile_card_account { get; set; }

    public virtual DbSet<mobile_card_addition> mobile_card_addition { get; set; }

    public virtual DbSet<mobile_card_template_images> mobile_card_template_images { get; set; }

    public virtual DbSet<mobile_card_templates> mobile_card_templates { get; set; }

    public virtual DbSet<mobile_cards> mobile_cards { get; set; }

    public virtual DbSet<mobile_invitation_board> mobile_invitation_board { get; set; }

    public virtual DbSet<movie_order> movie_order { get; set; }

    public virtual DbSet<movie_order_images> movie_order_images { get; set; }

    public virtual DbSet<movie_template> movie_template { get; set; }

    public virtual DbSet<notifications> notifications { get; set; }

    public virtual DbSet<option_product> option_product { get; set; }

    public virtual DbSet<options> options { get; set; }

    public virtual DbSet<options_items> options_items { get; set; }

    public virtual DbSet<order_addition_service> order_addition_service { get; set; }

    public virtual DbSet<order_card_bases> order_card_bases { get; set; }

    public virtual DbSet<order_card_contents> order_card_contents { get; set; }

    public virtual DbSet<order_card_envelopes> order_card_envelopes { get; set; }

    public virtual DbSet<order_card_qty> order_card_qty { get; set; }

    public virtual DbSet<order_coupon_history> order_coupon_history { get; set; }

    public virtual DbSet<order_deposits> order_deposits { get; set; }

    public virtual DbSet<order_item_addition> order_item_addition { get; set; }

    public virtual DbSet<order_item_detail> order_item_detail { get; set; }

    public virtual DbSet<order_item_options> order_item_options { get; set; }

    public virtual DbSet<order_items> order_items { get; set; }

    public virtual DbSet<order_job_ticket> order_job_ticket { get; set; }

    public virtual DbSet<order_money_change_log> order_money_change_log { get; set; }

    public virtual DbSet<order_refunds> order_refunds { get; set; }

    public virtual DbSet<order_seq_autoinc> order_seq_autoinc { get; set; }

    public virtual DbSet<orders> orders { get; set; }

    public virtual DbSet<packing_manage> packing_manage { get; set; }

    public virtual DbSet<packing_manage_orders> packing_manage_orders { get; set; }

    public virtual DbSet<partner_accounts> partner_accounts { get; set; }

    public virtual DbSet<partner_shop> partner_shop { get; set; }

    public virtual DbSet<partner_user_password_reset> partner_user_password_reset { get; set; }

    public virtual DbSet<partner_users> partner_users { get; set; }

    public virtual DbSet<password_resets> password_resets { get; set; }

    public virtual DbSet<permission_role> permission_role { get; set; }

    public virtual DbSet<permissions> permissions { get; set; }

    public virtual DbSet<pick_product> pick_product { get; set; }

    public virtual DbSet<print_file_history> print_file_history { get; set; }

    public virtual DbSet<product_card_addition> product_card_addition { get; set; }

    public virtual DbSet<product_content_images> product_content_images { get; set; }

    public virtual DbSet<product_format> product_format { get; set; }

    public virtual DbSet<product_gift> product_gift { get; set; }

    public virtual DbSet<product_mcard_template> product_mcard_template { get; set; }

    public virtual DbSet<product_movie_template> product_movie_template { get; set; }

    public virtual DbSet<product_pick> product_pick { get; set; }

    public virtual DbSet<product_picks> product_picks { get; set; }

    public virtual DbSet<product_relations> product_relations { get; set; }

    public virtual DbSet<product_sets> product_sets { get; set; }

    public virtual DbSet<product_sweetday> product_sweetday { get; set; }

    public virtual DbSet<products> products { get; set; }

    public virtual DbSet<products_images> products_images { get; set; }

    public virtual DbSet<push_subscriptions> push_subscriptions { get; set; }

    public virtual DbSet<review_board> review_board { get; set; }

    public virtual DbSet<role_user> role_user { get; set; }

    public virtual DbSet<roles> roles { get; set; }

    public virtual DbSet<sample_cabinet> sample_cabinet { get; set; }

    public virtual DbSet<sample_carts> sample_carts { get; set; }

    public virtual DbSet<sample_order_items> sample_order_items { get; set; }

    public virtual DbSet<sample_order_items_dup> sample_order_items_dup { get; set; }

    public virtual DbSet<sample_orders> sample_orders { get; set; }

    public virtual DbSet<sample_orders_dup> sample_orders_dup { get; set; }

    public virtual DbSet<sample_stock_log> sample_stock_log { get; set; }

    public virtual DbSet<search_word> search_word { get; set; }

    public virtual DbSet<search_word_product> search_word_product { get; set; }

    public virtual DbSet<send_email_log> send_email_log { get; set; }

    public virtual DbSet<send_sms_log> send_sms_log { get; set; }

    public virtual DbSet<serial_coupon_issue> serial_coupon_issue { get; set; }

    public virtual DbSet<serial_coupon_user> serial_coupon_user { get; set; }

    public virtual DbSet<serial_coupons> serial_coupons { get; set; }

    public virtual DbSet<serial_coupons_category> serial_coupons_category { get; set; }

    public virtual DbSet<serial_coupons_product> serial_coupons_product { get; set; }

    public virtual DbSet<shipping_manage> shipping_manage { get; set; }

    public virtual DbSet<shopping_carts> shopping_carts { get; set; }

    public virtual DbSet<site_policy> site_policy { get; set; }

    public virtual DbSet<site_policy_benefit> site_policy_benefit { get; set; }

    public virtual DbSet<site_popup> site_popup { get; set; }

    public virtual DbSet<site_type_manager> site_type_manager { get; set; }

    public virtual DbSet<site_type_manager_column> site_type_manager_column { get; set; }

    public virtual DbSet<site_type_manager_column_items> site_type_manager_column_items { get; set; }

    public virtual DbSet<sitemap> sitemap { get; set; }

    public virtual DbSet<sms> sms { get; set; }

    public virtual DbSet<stickers> stickers { get; set; }

    public virtual DbSet<sweetday> sweetday { get; set; }

    public virtual DbSet<sweetday_board> sweetday_board { get; set; }

    public virtual DbSet<thirdparty_oauth> thirdparty_oauth { get; set; }

    public virtual DbSet<toss_account> toss_account { get; set; }

    public virtual DbSet<toss_api_logs> toss_api_logs { get; set; }

    public virtual DbSet<toss_order> toss_order { get; set; }

    public virtual DbSet<toss_stock> toss_stock { get; set; }

    public virtual DbSet<toss_stock_log> toss_stock_log { get; set; }

    public virtual DbSet<typeset_stock_log> typeset_stock_log { get; set; }

    public virtual DbSet<uploaded_images> uploaded_images { get; set; }

    public virtual DbSet<user_attache> user_attache { get; set; }

    public virtual DbSet<users> users { get; set; }

    public virtual DbSet<users_gifts> users_gifts { get; set; }

    public virtual DbSet<users_leave_log> users_leave_log { get; set; }

    public virtual DbSet<users_roles> users_roles { get; set; }

    public virtual DbSet<video_templates> video_templates { get; set; }

    public virtual DbSet<wedd_map> wedd_map { get; set; }

    public virtual DbSet<wedd_map_item> wedd_map_item { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<addition_service>(entity =>
        {
            entity.HasKey(e => e.service_type).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("부가 서비스 정보"));

            entity.Property(e => e.service_type).HasComment("서비스구분");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.is_unit)
                .IsFixedLength()
                .HasComment("단가여부");
            entity.Property(e => e.is_use)
                .IsFixedLength()
                .HasComment("사용여부");
            entity.Property(e => e.service_cost).HasComment("서비스비용");
            entity.Property(e => e.service_type_name).HasComment("서비스명");
            entity.Property(e => e.updated_at).HasComment("수정일시");
        });

        modelBuilder.Entity<addresses>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("배송주소관리"));

            entity.Property(e => e.delivery_addr1).HasComment("받는사람 기본주소");
            entity.Property(e => e.delivery_addr2).HasComment("받는사람 상세주소");
            entity.Property(e => e.delivery_email).HasComment("받는사람 이메일");
            entity.Property(e => e.delivery_message).HasComment("배송메모");
            entity.Property(e => e.delivery_name).HasComment("받는사람 이름");
            entity.Property(e => e.delivery_phone).HasComment("받는사람 전화번호");
            entity.Property(e => e.delivery_phone_add).HasComment("받는사람 전화번호 추가");
            entity.Property(e => e.delivery_zipcode).HasComment("받는사람 우편번호");
            entity.Property(e => e.order_addr1).HasComment("주문자 기본주소");
            entity.Property(e => e.order_addr2).HasComment("주문자 상세주소");
            entity.Property(e => e.order_email).HasComment("주문자이메일");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_name).HasComment("주문자이름");
            entity.Property(e => e.order_no)
                .HasDefaultValueSql("'0'")
                .HasComment("orders.order_no");
            entity.Property(e => e.order_phone).HasComment("주문자전화번호");
            entity.Property(e => e.order_phone_add).HasComment("주문자전화번호 추가");
            entity.Property(e => e.order_zipcode).HasComment("주문자우편번호");
        });

        modelBuilder.Entity<admin_limit_setting>(entity =>
        {
            entity.HasKey(e => e.type).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("초특급버튼 제한관리"));

            entity.Property(e => e.type).IsFixedLength();
            entity.Property(e => e.use_yn).IsFixedLength();
        });

        modelBuilder.Entity<admin_limit_setting_log>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("초특급버튼 제한관리 로그"));

            entity.Property(e => e.type).IsFixedLength();
            entity.Property(e => e.use_yn).IsFixedLength();
        });

        modelBuilder.Entity<admin_users>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("관리자 유저 관리(사용안함)"));
        });

        modelBuilder.Entity<banner_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("배너 이미지"));

            entity.Property(e => e.banner_id).HasComment("banners.id");
            entity.Property(e => e.path).HasComment("url");
        });

        modelBuilder.Entity<banners>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("배너관리"));

            entity.Property(e => e.banner_label).HasComment("라벨");
            entity.Property(e => e.category).HasComment("카테고리");
            entity.Property(e => e.code).HasComment("노출코드");
            entity.Property(e => e.interval).HasComment("슬라이드 시간");
            entity.Property(e => e.name).HasComment("베너명");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'left'")
                .HasComment("슬라이드방향");
            entity.Property(e => e.updater_id).HasComment("업데이트한사람");
        });

        modelBuilder.Entity<best_sample>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.mo_banner_image).HasComment("mo 업로드 이미지");
            entity.Property(e => e.mo_contents).HasComment("MO 내용");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.pc_banner_image).HasComment("pc 업로드 이미지");
            entity.Property(e => e.pc_contents).HasComment("PC 내용");
            entity.Property(e => e.samplename).HasComment("샘플명");
            entity.Property(e => e.updater_id).HasComment("수정자");
        });

        modelBuilder.Entity<best_sample_product>(entity =>
        {
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<block_manager>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("차단관리"));

            entity.Property(e => e.block_type)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("A:전체/U:특정 URL");
            entity.Property(e => e.block_url).HasComment("블럭 주소");
            entity.Property(e => e.check_ip).HasComment("IP 혹은 ID");
            entity.Property(e => e.check_type)
                .IsFixedLength()
                .HasComment("P:IP/D:ID");
            entity.Property(e => e.memo).HasComment("블럭사유");
            entity.Property(e => e.updater_id).HasComment("작성자 users.id");
            entity.Property(e => e.user_id).HasComment("차단된 users.id");
        });

        modelBuilder.Entity<board>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("게시판관리"));

            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.name).HasComment("게시판 이름");
            entity.Property(e => e.owner_id).HasComment("만든사람");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'2'")
                .HasComment("1:공지사항, 2:일반게시판, 3:고객센터");
            entity.Property(e => e.updater_id).HasComment("수정한사람");
        });

        modelBuilder.Entity<board_content_attached>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.board_contents_id).HasComment("board_contents.id");
            entity.Property(e => e.board_id).HasComment("board.id");
            entity.Property(e => e.path).HasComment("url");
        });

        modelBuilder.Entity<board_content_reply>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("게시물 리플"));

            entity.Property(e => e.attached).HasComment("첨부파일");
            entity.Property(e => e.board_contents_id).HasComment("board_contents.id");
            entity.Property(e => e.content).HasComment("내용");
            entity.Property(e => e.depth).HasComment("리플 깊이");
            entity.Property(e => e.parent_id).HasComment("board_content_reply.id");
            entity.Property(e => e.password).HasComment("비밀번호");
            entity.Property(e => e.sort_order).HasComment("정렬");
            entity.Property(e => e.subject).HasComment("리플제목");
            entity.Property(e => e.user_id).HasComment("users.id");
            entity.Property(e => e.user_name).HasComment("users.name");
        });

        modelBuilder.Entity<board_contents>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("게시판의 게시물"));

            entity.Property(e => e.attached).HasComment("첨부파일");
            entity.Property(e => e.board_id).HasComment("board.id");
            entity.Property(e => e.contents).HasComment("내용");
            entity.Property(e => e.password).HasComment("비밀번호");
            entity.Property(e => e.subject).HasComment("제목");
            entity.Property(e => e.user_id).HasComment("users.id");
            entity.Property(e => e.user_name).HasComment("users.name");
        });

        modelBuilder.Entity<card_greeting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인사말"));

            entity.Property(e => e.category1).HasComment("카테고리1");
            entity.Property(e => e.category2).HasComment("카테고리2");
            entity.Property(e => e.contents).HasComment("인사말");
            entity.Property(e => e.name).HasComment("제목");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.updater_id).HasComment("수정한사람");
        });

        modelBuilder.Entity<categories>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("상품분류"));

            entity.Property(e => e.cate_image).HasComment("대체이미지");
            entity.Property(e => e.cate_name).HasComment("분류명");
            entity.Property(e => e.contents).HasComment("분류꾸미기");
            entity.Property(e => e.depth)
                .HasDefaultValueSql("'0'")
                .HasComment("깊이");
            entity.Property(e => e.desc).HasComment("분류설명");
            entity.Property(e => e.link).HasComment("분류경로: 기본경로를 사용하지않을때 사용");
            entity.Property(e => e.parent_id).HasComment("categories.id");
            entity.Property(e => e.show_soldout)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("품절상품 정렬");
            entity.Property(e => e.show_sort)
                .HasDefaultValueSql("'NT'")
                .HasComment("상품정렬");
            entity.Property(e => e.sort_order)
                .HasDefaultValueSql("'0'")
                .HasComment("카테고리 정렬");
            entity.Property(e => e.use_decorate)
                .HasDefaultValueSql("'0'")
                .HasComment("분류꾸미기- 0:사용안함, 1:사용함");
            entity.Property(e => e.use_display)
                .HasDefaultValueSql("'0'")
                .HasComment("표시상태: 0: 사용안함, 1: 사용함");
        });

        modelBuilder.Entity<categories_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("카테고리 이미지 (사용안함)"));

            entity.HasOne(d => d.category).WithMany(p => p.categories_images).HasConstraintName("categories_images_category_id_foreign");
        });

        modelBuilder.Entity<category_product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품-카테고리 릴레이션"));

            entity.Property(e => e.category_id).HasComment("categorise.id");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.sort_order).HasComment("기본정렬순서");
        });

        modelBuilder.Entity<category_serial_coupon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카테고리-시리얼쿠폰 릴레이션"));

            entity.Property(e => e.category_id).HasComment("products.id");
            entity.Property(e => e.serial_coupon_id).HasComment("serial_coupon.id");
        });

        modelBuilder.Entity<cj_invoice_numbers>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("송장번호관리"));

            entity.Property(e => e.CRG_ST)
                .HasDefaultValueSql("'01'")
                .IsFixedLength()
                .HasComment("집하지시:01, 집하처리:11, 미집하:12, 간선상차:41, 간선하차:42, 배송출발:82, 미배달:84, 배송완료:91");
            entity.Property(e => e.dlvClsfCd).HasComment("주소정제API CLSFCD");
            entity.Property(e => e.dlvPreArrBranShortNm).HasComment("주소정제API p_clldlvbranshortnm");
            entity.Property(e => e.dlvPreArrEmpNickNm).HasComment("주소정제API p_clldlvempnm");
            entity.Property(e => e.dlvPreArrEmpNm).HasComment("주소정제API p_clldlvempnicknm");
            entity.Property(e => e.dlvSubClsfCd).HasComment("주소정제 API SUBCLSFCD");
            entity.Property(e => e.invoice_no).HasComment("송장번호");
            entity.Property(e => e.is_used)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("T: 사용함, F: 사용안함");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.pdf_path).HasComment("INVOICE_PDF_PATH");
            entity.Property(e => e.rcvrEtcAddr).HasComment("주소정제API p_clsfaddr");
        });

        modelBuilder.Entity<code_map_barunson>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("바른손-디얼디어 코드매칭"));

            entity.Property(e => e.barunson_card_code).HasComment("바른손 상품 코드");
            entity.Property(e => e.barunson_card_seq).HasComment("바른손 상품 시퀀스");
            entity.Property(e => e.base_image).HasComment("기본이미지 초안에서 사용예정이지");
            entity.Property(e => e.card_type)
                .HasDefaultValueSql("'C'")
                .IsFixedLength()
                .HasComment("C:기본(카드), I:내지, P:별첨");
            entity.Property(e => e.format_manufacture).HasComment("후가공");
            entity.Property(e => e.format_producing).HasComment("생상처");
            entity.Property(e => e.is_both_side_print)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:양면인쇄, F:단면인쇄");
            entity.Property(e => e.is_print)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:인쇄함, F:인쇄안함");
            entity.Property(e => e.is_printed)
                .IsFixedLength()
                .HasComment("인쇄제품: T, 완제품: F");
            entity.Property(e => e.item_code).HasComment("디얼디어 상품 코드");
            entity.Property(e => e.print_type).HasComment("제품타입- 0: 청첩장아님, 1: 청첩장, 2: 감사장, 6: 디지털, 7: 박광압");
            entity.Property(e => e.schedule_day).HasComment("제작일");
        });

        modelBuilder.Entity<common_code>(entity =>
        {
            entity.HasKey(e => new { e.code_group, e.code })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable(tb => tb.HasComment("공통코드"));

            entity.Property(e => e.code_group).HasComment("코드그룹");
            entity.Property(e => e.code).HasComment("코드");
            entity.Property(e => e.code_group_name).HasComment("코드그룹명");
            entity.Property(e => e.code_name).HasComment("코드명");
            entity.Property(e => e.created_at).HasComment("생성일시");
            entity.Property(e => e.deleted_at).HasComment("삭제일시");
            entity.Property(e => e.etc1).HasComment("기타");
            entity.Property(e => e.sort).HasComment("순서");
            entity.Property(e => e.updated_at).HasComment("수정일시");
        });

        modelBuilder.Entity<contact_content_reply>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("고객센터 댓글"));

            entity.Property(e => e.attached).HasComment("첨부파일 링크");
            entity.Property(e => e.contact_contents_id).HasComment("1:1게시판 아이디");
            entity.Property(e => e.contents).HasComment("리플 내용");
            entity.Property(e => e.depth).HasComment("댓글 깊이");
            entity.Property(e => e.parent_id).HasComment("댓글 부모아이디");
            entity.Property(e => e.password).HasComment("패스워드");
            entity.Property(e => e.subject).HasComment("제목");
            entity.Property(e => e.user_id).HasComment("사용자 아이디");
            entity.Property(e => e.user_name).HasComment("사용자이름");
        });

        modelBuilder.Entity<contact_contents>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("고객센터"));

            entity.Property(e => e._checked)
                .HasDefaultValueSql("'0'")
                .HasComment("확인여부");
            entity.Property(e => e.attached).HasComment("첨부파일");
            entity.Property(e => e.barunson_seq).HasComment("S2_UserQnA.qa_iid / C07 : preview_opinion.bbs_seq");
            entity.Property(e => e.contents).HasComment("내용");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.password).HasComment("비밀번호");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.subject).HasComment("제목");
            entity.Property(e => e.type).HasComment("코멘트 타입");
            entity.Property(e => e.user_id).HasComment("작성자id");
            entity.Property(e => e.user_name).HasComment("작성자 이름");
        });

        modelBuilder.Entity<content_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("상품상세 에디터에서 업로드된 이미지"));

            entity.Property(e => e.path).HasComment("url");
            entity.Property(e => e.target).HasComment("table 명");
            entity.Property(e => e.target_id).HasComment("table.id");
            entity.Property(e => e.user_id).HasComment("작성자");
        });

        modelBuilder.Entity<cost_manage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("초안비용산출"));

            entity.Property(e => e.cost).HasComment("비용");
            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.type).HasComment("타입");
        });

        modelBuilder.Entity<counsel_contents>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("고객상담 내용"));

            entity.Property(e => e._checked)
                .HasDefaultValueSql("'0'")
                .HasComment("확인 유무");
            entity.Property(e => e.checked_manager).HasComment("확인한 사람");
            entity.Property(e => e.contents).HasComment("상담 내용");
            entity.Property(e => e.manager).HasComment("상담 작성자 id");
            entity.Property(e => e.urgent)
                .HasDefaultValueSql("'0'")
                .HasComment("긴급 요청");
            entity.Property(e => e.user_id).HasComment("상담 고객");
        });

        modelBuilder.Entity<coupon_hist>(entity =>
        {
            entity.HasKey(e => new { e.id, e.std_dt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.benefit_type)
                .HasDefaultValueSql("'A'")
                .IsFixedLength();
            entity.Property(e => e.issue_limit).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<coupon_info>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.allow_diposit)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.allow_discount)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.allow_scope)
                .HasDefaultValueSql("'O'")
                .IsFixedLength();
            entity.Property(e => e.restore_after_pay)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.restore_before_pay)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.restore_exchange)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.restore_return)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.use_coupon)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
        });

        modelBuilder.Entity<coupon_issue>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("쿠폰발급내역"));

            entity.Property(e => e.coupon_id).HasComment("coupons.id");
            entity.Property(e => e.is_used)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("사용하였뉘");
            entity.Property(e => e.issue_no).HasComment("coupons.id");
            entity.Property(e => e.order_no).HasComment("order.order_no");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<coupon_serial_temp>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.coupon_direct).HasComment("임시쿠폰");
            entity.Property(e => e.coupon_id).HasComment("coupons.id");
        });

        modelBuilder.Entity<coupon_user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<coupons>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("쿠폰관리"));

            entity.Property(e => e.benefit_max_price).HasComment("최대할인금액");
            entity.Property(e => e.benefit_price).HasComment("혜택금액");
            entity.Property(e => e.benefit_round_unit).HasComment("원단위 절삭");
            entity.Property(e => e.benefit_type)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("혜택구분");
            entity.Property(e => e.coupon_desc).HasComment("설명");
            entity.Property(e => e.coupon_name).HasComment("쿠폰명");
            entity.Property(e => e.coupon_type)
                .HasDefaultValueSql("'D'")
                .IsFixedLength()
                .HasComment("쿠폰 타입 (D:기본 / P:제휴사)");
            entity.Property(e => e.include_foreign_delivery)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("해외배송비");
            entity.Property(e => e.include_region_shipping_fee)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("지역배송비");
            entity.Property(e => e.is_duplicate)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("중복할인");
            entity.Property(e => e.issue_category_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("발급대상카테고리");
            entity.Property(e => e.issue_join_type)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("제공동의 발급");
            entity.Property(e => e.issue_join_user)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("가입자대상발급");
            entity.Property(e => e.issue_limit)
                .HasDefaultValueSql("'1'")
                .HasComment("최대발급수량");
            entity.Property(e => e.issue_ord_min_count)
                .HasDefaultValueSql("'0'")
                .HasComment("최소구매수량");
            entity.Property(e => e.issue_order_path_type_serial).HasComment("주문경로");
            entity.Property(e => e.issue_product_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("발급대상상품");
            entity.Property(e => e.issue_recommender)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("추천인대상발급");
            entity.Property(e => e.issue_type)
                .HasDefaultValueSql("'MM'")
                .HasComment("발급구분");
            entity.Property(e => e.issued_level_type)
                .IsFixedLength()
                .HasComment("발급단위");
            entity.Property(e => e.qty_range).HasComment("사용가능 수량 범위 (lt:이하, gt:이상, equal:같음)");
            entity.Property(e => e.use_available_day_from).HasComment("사용기간");
            entity.Property(e => e.use_available_end_day).HasComment("사용가능 종료일");
            entity.Property(e => e.use_available_min_price).HasComment("사용가능 최소금액");
            entity.Property(e => e.use_available_min_qty).HasComment("사용가능 최소수량");
            entity.Property(e => e.use_available_period_type)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("사용기간설정");
            entity.Property(e => e.use_available_price_detail_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength();
            entity.Property(e => e.use_available_price_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("사용가능기준");
            entity.Property(e => e.use_available_qty_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("사용가능기준수량(U:제한없음/O:주문수량기준/P:상품수량기준)");
            entity.Property(e => e.use_available_start_day).HasComment("사용가능 시작일");
            entity.Property(e => e.use_category_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("쿠폰적용 카테고리타입");
            entity.Property(e => e.use_domain_type_serial)
                .HasDefaultValueSql("'0'")
                .HasComment("사용범위");
            entity.Property(e => e.use_level_type)
                .HasDefaultValueSql("'O'")
                .IsFixedLength()
                .HasComment("적용가능범위");
            entity.Property(e => e.use_pay_method_binding_type).HasComment("사용가능결제수단");
            entity.Property(e => e.use_product_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("쿠폰적용 상품 타입");
        });

        modelBuilder.Entity<coupons_category>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰-카테고리 릴레이션"));

            entity.Property(e => e.category_id).HasComment("category.id");
            entity.Property(e => e.coupons_id).HasComment("coupons.id");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("I:발급대상/U:쿠폰적용");
        });

        modelBuilder.Entity<coupons_product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰-상품 릴레이션"));

            entity.Property(e => e.coupons_id).HasComment("coupons.id");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("I:발급대상/U:쿠폰적용");
        });

        modelBuilder.Entity<daily_account_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("일별 결제 로그"));

            entity.Property(e => e.amount).HasComment("합계");
            entity.Property(e => e.count).HasComment("주문건수");
            entity.Property(e => e.date).HasComment("날짜");
            entity.Property(e => e.order_base)
                .HasDefaultValueSql("'wcard'")
                .IsFixedLength()
                .HasComment("주문타입");
            entity.Property(e => e.order_state)
                .HasDefaultValueSql("'O'")
                .IsFixedLength()
                .HasComment("상태");
        });

        modelBuilder.Entity<draft_history>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("초안수정히스토리(사용안함)"));

            entity.Property(e => e.draft_link).HasComment("초안 링크");
            entity.Property(e => e.draft_state).HasComment("초안 확정 상태");
            entity.Property(e => e.order_item_no).HasComment("order_items.order_item_no");
        });

        modelBuilder.Entity<draft_history_comment>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.attached).HasComment("첨부파일");
            entity.Property(e => e.comment).HasComment("코멘트트");
            entity.Property(e => e.comment_type).HasComment("코멘트 타입");
            entity.Property(e => e.draft_history_id).HasComment("draft_history.id");
            entity.Property(e => e.draft_state).HasComment("초안 확정 상태");
            entity.Property(e => e.order_item_no).HasComment("order_items.order_item_no");
        });

        modelBuilder.Entity<email>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("이메일관리"));

            entity.Property(e => e.body).HasComment("email 내용");
            entity.Property(e => e.email_code).HasComment("email 코드");
            entity.Property(e => e.email_desc).HasComment("email 설명");
            entity.Property(e => e.email_section).HasComment("email 섹션");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.subject).HasComment("email 제목");
        });

        modelBuilder.Entity<event_board_comments>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("이벤트 게시판 게시글"));

            entity.Property(e => e.contents).HasComment("내용");
            entity.Property(e => e.event_board_id).HasComment("event_board.id");
            entity.Property(e => e.is_auto_pass)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.issue_state)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.link).HasComment("링크");
            entity.Property(e => e.link_type).IsFixedLength();
            entity.Property(e => e.notice).IsFixedLength();
            entity.Property(e => e.option_code).HasComment("옵션코드");
            entity.Property(e => e.subject).HasComment("제목 명");
            entity.Property(e => e.user_id).HasComment("작성자 아이디");
            entity.Property(e => e.user_name)
                .IsFixedLength()
                .HasComment("작성자 이름");
        });

        modelBuilder.Entity<event_board_options>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("이벤트게시판 아이템"));

            entity.Property(e => e.code).HasComment("옵션코드");
            entity.Property(e => e.event_board_id).HasComment("event_boards.id");
            entity.Property(e => e.name).HasComment("옵션명");
        });

        modelBuilder.Entity<event_boards>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("이벤트 게시판"));

            entity.Property(e => e.btn_name).HasComment("comment 작성 버튼명");
            entity.Property(e => e.contents).HasComment("이벤트 설명");
            entity.Property(e => e.detail_banner).HasComment("디테일 페이지 베너");
            entity.Property(e => e.end_date).HasComment("이벤트 종료일");
            entity.Property(e => e.link).HasComment("링크");
            entity.Property(e => e.list_banner).HasComment("리스트 베너");
            entity.Property(e => e.moboil_contents).HasComment("모바일 상품상세 설명");
            entity.Property(e => e.owner_id).HasComment("상품 번호");
            entity.Property(e => e.sort_order).HasComment("노출 순서");
            entity.Property(e => e.start_date).HasComment("이벤트 시작일");
            entity.Property(e => e.state).HasComment("NO, START, END, ANNOUNCE");
            entity.Property(e => e.subject).HasComment("이벤트 명");
            entity.Property(e => e.summary).HasComment("이벤트 간단 설명");
            entity.Property(e => e.updater_id).HasComment("상품 번호");
            entity.Property(e => e.use_comment)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.use_coupon)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("쿠폰사용");
            entity.Property(e => e.use_link)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("링크사용");
            entity.Property(e => e.use_option)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("옵션사용");
        });

        modelBuilder.Entity<event_boards_coupons>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이벤트-쿠폰 릴레이션"));

            entity.Property(e => e.coupons_id).HasComment("coupons.id");
            entity.Property(e => e.event_boards_id).HasComment("event_boards.id");
        });

        modelBuilder.Entity<faq_board_contents>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("faq 게시물"));

            entity.Property(e => e.contents).HasComment("자주묻는 질문 내용");
            entity.Property(e => e.faq_board_id).HasComment("자주묻는 질문 게시판 ID");
            entity.Property(e => e.sort_order).HasComment("순번");
            entity.Property(e => e.subject).HasComment("자주묻는 질문 제목");
        });

        modelBuilder.Entity<faq_boards>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("faq 게시판"));

            entity.Property(e => e.board_name).HasComment("이벤트 명");
            entity.Property(e => e.sort_order).HasComment("순번");
        });

        modelBuilder.Entity<hashtag>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.is_display)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("F: 사용함, T: 사용안함");
        });

        modelBuilder.Entity<hashtag_product>(entity =>
        {
            entity.Property(e => e.hashtag_id).HasComment("id");
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<holiday_calendar>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("휴일관리"));

            entity.Property(e => e.holiday).HasComment("휴일");
            entity.Property(e => e.holiday_desc).HasComment("설명");
        });

        modelBuilder.Entity<homuro_board>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.is_best)
                .HasDefaultValueSql("'F'")
                .HasComment("T:베스트리뷰/F:일반리뷰");
            entity.Property(e => e.is_show)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("노출상태(T:노출/F:숨김)");
            entity.Property(e => e.issue_state)
                .HasDefaultValueSql("'F'")
                .HasComment("T:쿠폰발급/F:쿠본미발급");
            entity.Property(e => e.link).HasComment("sns 게시물 링크");
            entity.Property(e => e.product_id).HasComment("상품코드");
            entity.Property(e => e.starpoint)
                .HasDefaultValueSql("'0'")
                .HasComment("별점");
        });

        modelBuilder.Entity<homuro_board_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.homuro_id).HasComment("게시판 index값");
            entity.Property(e => e.product_id).HasComment("상품코드");
        });

        modelBuilder.Entity<indd_create_history>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인디자인 생성 히스토리(사용안함)"));

            entity.Property(e => e.changed_indd_link).HasComment("변경된 indd 파일 링크");
            entity.Property(e => e.indd_link).HasComment("indd 링크");
            entity.Property(e => e.is_custom)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.order_item_no).HasComment("order_items.order_item_no");
        });

        modelBuilder.Entity<invitation_card_addition>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("부가상품"));

            entity.Property(e => e.add_code).HasComment("코드");
            entity.Property(e => e.add_desc).HasComment("설명");
            entity.Property(e => e.add_name).HasComment("이름");
            entity.Property(e => e.add_price).HasComment("추가금액");
            entity.Property(e => e.add_type)
                .HasDefaultValueSql("'TIC'")
                .HasComment("타입 : T:식권, S:스티커");
            entity.Property(e => e.add_type_sub)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasComment("씰링(0:일반, 1:씰링)");
            entity.Property(e => e.addition_field).HasComment("추가 입력값 포맷 설정");
            entity.Property(e => e.divide_print_price).HasComment("판나누기 금액");
            entity.Property(e => e.divide_qty).HasComment("qty 셀렉트박스");
            entity.Property(e => e.use_addition_field)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("추가입력값 사용여부 설정 T:사용함 / F:사용안함");
            entity.Property(e => e.use_divide_print)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("판나누기 설정 T:사용함 / F:사용안함");
            entity.Property(e => e.use_divide_qty)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("수량나누기 설정 T:사용함 / F:사용안함");
            entity.Property(e => e.use_start_no)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("시작번호 사용 설정 T:사용함 / F:사용안함");
            entity.Property(e => e.view_yn)
                .HasDefaultValueSql("'N'")
                .HasComment("청첩장 구매 페이지 노출 여부");
        });

        modelBuilder.Entity<invitation_card_addition_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("부가상품 아이템"));

            entity.Property(e => e.addition_id).HasComment("부가상품 id");
            entity.Property(e => e.item_add_mark)
                .HasDefaultValueSql("'plus'")
                .HasComment("plus, minus, rate");
            entity.Property(e => e.item_add_price).HasComment("추가 금");
            entity.Property(e => e.item_code).HasComment("부가아이템 명");
            entity.Property(e => e.item_desc).HasComment("부가아이템 명");
            entity.Property(e => e.item_name).HasComment("부가아이템 명");
            entity.Property(e => e.sort_order).HasComment("정렬");
            entity.Property(e => e.uploaded_image_id)
                .HasDefaultValueSql("'0'")
                .HasComment("uploaded_image.id");
        });

        modelBuilder.Entity<item_stock_manage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("재고관리(사용안함)"));

            entity.Property(e => e.incremental_qty).HasComment("누적수량");
            entity.Property(e => e.item_per)
                .HasDefaultValueSql("'1'")
                .HasComment("차감수량: 전지 6개 1장이면 6");
            entity.Property(e => e.safety_qty).HasComment("안전재고수량");
            entity.Property(e => e.sample_safety_qty).HasComment("샘플 안전재고수량");
            entity.Property(e => e.sample_stock_qty).HasComment("샘플 재고수량");
            entity.Property(e => e.stock_code).HasComment("아이템코드");
            entity.Property(e => e.stock_qty).HasComment("재고수량");
            entity.Property(e => e.stock_type)
                .HasDefaultValueSql("'I'")
                .IsFixedLength()
                .HasComment("I:장당/P:종이");
            entity.Property(e => e.use_safety)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("안전재고사용");
            entity.Property(e => e.use_sample_safety)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("샘플 안전재고사용");
            entity.Property(e => e.use_sample_stock)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("샘플 재고 사용");
            entity.Property(e => e.use_stock)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("재고 사용");
        });

        modelBuilder.Entity<item_stock_manage_item_typeset>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("재고-인쇄규격 릴레이션(사용안함)"));

            entity.Property(e => e.item_stock_manage_id).HasComment("item_stock_manage.id");
            entity.Property(e => e.item_typeset_id).HasComment("item_typeset.id");
        });

        modelBuilder.Entity<item_stock_manage_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인쇄규격 재고 로그(사용안함)"));

            entity.Property(e => e.after).HasComment("이후수량");
            entity.Property(e => e.before).HasComment("이전수량");
            entity.Property(e => e.item_stock_manage_id).HasComment("item_stock_manage.id");
            entity.Property(e => e.log_type)
                .HasDefaultValueSql("'P'")
                .IsFixedLength()
                .HasComment("P:패킹, A:충전, M: 수동빼기");
            entity.Property(e => e.memo).HasComment("업데이트 메모");
            entity.Property(e => e.stock_base)
                .HasDefaultValueSql("'I'")
                .IsFixedLength()
                .HasComment("I:기본, S:샘플");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<item_typeset>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인쇄규격관리(사용안함)"));

            entity.Property(e => e.format_attache).HasComment("별첨");
            entity.Property(e => e.format_envelope).HasComment("봉투");
            entity.Property(e => e.format_manufacture).HasComment("후가공");
            entity.Property(e => e.format_paper).HasComment("종이");
            entity.Property(e => e.format_producing).HasComment("생산처");
            entity.Property(e => e.format_type).HasComment("청첩장 모양 구조");
            entity.Property(e => e.format_x).HasComment("가로 길이 mm");
            entity.Property(e => e.format_y).HasComment("세로 길이 mm");
            entity.Property(e => e.is_map_background)
                .IsFixedLength()
                .HasComment("배경색 변경");
            entity.Property(e => e.is_numbering)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("식권넘버링 (T:함/F:안함)");
            entity.Property(e => e.is_printed)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("T: 완제품, F: 인쇄제품");
            entity.Property(e => e.item_code).HasComment("아이템 코드");
            entity.Property(e => e.map_background).HasComment("배경색 지정");
            entity.Property(e => e.map_color).HasComment("지도 선색");
            entity.Property(e => e.map_color_type).HasComment("지도 인쇄타입");
            entity.Property(e => e.map_point).HasComment("지도 포인트 색");
            entity.Property(e => e.master_background_image).HasComment("마스터 인쇄 제품 배경 이미지 리스트형태");
            entity.Property(e => e.master_height).HasComment("마스터 세로 길이");
            entity.Property(e => e.master_width).HasComment("마스터 가로 길이");
            entity.Property(e => e.pos_cover).HasComment("표지 방향");
            entity.Property(e => e.pos_page).HasComment("내지 방향");
            entity.Property(e => e.safety_stock).HasComment("안전재고수량");
            entity.Property(e => e.sample_safety_stock).HasComment("샘플안전재고수량");
            entity.Property(e => e.sample_stock).HasComment("샘플재고수량");
            entity.Property(e => e.stock).HasComment("재고수량");
            entity.Property(e => e.type_print).HasComment("프린트 타입 : digital, master");
            entity.Property(e => e.use_background_image)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("배경이미지 T: 사용함, F: 사용안함");
            entity.Property(e => e.use_sample_stock)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("샘플재고사용여부");
            entity.Property(e => e.use_stock)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("재고사용여부");
        });

        modelBuilder.Entity<jobs>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<lguplus_paid_list>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("유플러스 결제"));

            entity.Property(e => e.LGD_ACCOUNTNUM).HasComment("가상계좌발급번호");
            entity.Property(e => e.LGD_ACCOUNTOWNER).HasComment("계좌주명");
            entity.Property(e => e.LGD_AFFILIATECODE).HasComment("신용카드제휴코드");
            entity.Property(e => e.LGD_AMOUNT).HasComment("결제금액");
            entity.Property(e => e.LGD_BUYER).HasComment("구매자명");
            entity.Property(e => e.LGD_BUYERADDRESS).HasComment("구매자주소");
            entity.Property(e => e.LGD_BUYEREMAIL).HasComment("구매자메일");
            entity.Property(e => e.LGD_BUYERID).HasComment("구매자아이디");
            entity.Property(e => e.LGD_BUYERPHONE).HasComment("구매자휴대폰번호");
            entity.Property(e => e.LGD_CARDACQUIRER).HasComment("신용카드매입사코드");
            entity.Property(e => e.LGD_CARDGUBUN1).HasComment("신용카드추가정보1");
            entity.Property(e => e.LGD_CARDGUBUN2).HasComment("신용카드추가정보2");
            entity.Property(e => e.LGD_CARDINSTALLMONTH).HasComment("신용카드할부개월");
            entity.Property(e => e.LGD_CARDNOINTYN).HasComment("신용카드무이자여부");
            entity.Property(e => e.LGD_CARDNUM).HasComment("신용카드번호");
            entity.Property(e => e.LGD_CASCAMOUNT).HasComment("현입금금액");
            entity.Property(e => e.LGD_CASFLAG).HasComment("거래종류(R:할당,I:입금,C:취소)");
            entity.Property(e => e.LGD_CASHRECEIPTKIND).HasComment("현금영수증종류");
            entity.Property(e => e.LGD_CASHRECEIPTNUM).HasComment("현금영수증승인번호");
            entity.Property(e => e.LGD_CASHRECEIPTSELFYN).HasComment("현금영수증자진발급제유무");
            entity.Property(e => e.LGD_CASSEQNO).HasComment("가상계좌일련번호");
            entity.Property(e => e.LGD_CASTAMOUNT).HasComment("입금누적금액");
            entity.Property(e => e.LGD_DCNO)
                .HasDefaultValueSql("'NO'")
                .HasComment("DC여부");
            entity.Property(e => e.LGD_DELIVERYINFO).HasComment("배송정보");
            entity.Property(e => e.LGD_DISCOUNTUSEAMOUNT).HasComment("신용카드 즉시할인 금액");
            entity.Property(e => e.LGD_DISCOUNTUSEYN).HasComment("신용카드 즉시할인 여부");
            entity.Property(e => e.LGD_ESCROWYN).HasComment("에스크로적용유무");
            entity.Property(e => e.LGD_EXCHANGERATE).HasComment("적용환율");
            entity.Property(e => e.LGD_FINANCEAUTHNUM).HasComment("결제기관승인번호");
            entity.Property(e => e.LGD_FINANCECODE).HasComment("결제기관코드");
            entity.Property(e => e.LGD_FINANCENAME).HasComment("결제기관명");
            entity.Property(e => e.LGD_HASHDATA).HasComment("해쉬데이타");
            entity.Property(e => e.LGD_MID).HasComment("LG유플러스 발급 아이디");
            entity.Property(e => e.LGD_OCBAMOUNT).HasComment("OK캐쉬백 사용금액");
            entity.Property(e => e.LGD_OCBSAVEPOINT).HasComment("OK캐쉬백 적립포인트");
            entity.Property(e => e.LGD_OCBTID).HasComment("OK캐쉬백 거래번호");
            entity.Property(e => e.LGD_OCBTOTALPOINT).HasComment("OK캐쉬백 총누적포인트");
            entity.Property(e => e.LGD_OCBUSABLEPOINT).HasComment("OK캐쉬백 사용가능포인트");
            entity.Property(e => e.LGD_OID).HasComment("이용업체 거래번호(주문번호)");
            entity.Property(e => e.LGD_PASS_FLAG)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("성공:T, 실패:F");
            entity.Property(e => e.LGD_PAYDATE).HasComment("결제일시");
            entity.Property(e => e.LGD_PAYER).HasComment("가상계좌입금자명");
            entity.Property(e => e.LGD_PAYNOW_TRANTYPE).HasDefaultValueSql("'F'");
            entity.Property(e => e.LGD_PAYTYPE).HasComment("결제수단");
            entity.Property(e => e.LGD_PCANCELFLAG).HasComment("신용카드부분취소가능여부");
            entity.Property(e => e.LGD_PCANCELSTR).HasComment("신용카드부분취소불가능사유");
            entity.Property(e => e.LGD_PRODUCTCODE).HasComment("상품코드");
            entity.Property(e => e.LGD_PRODUCTINFO).HasComment("구매내역");
            entity.Property(e => e.LGD_RECEIVER).HasComment("수취인");
            entity.Property(e => e.LGD_RECEIVERPHONE).HasComment("수취인전화번호");
            entity.Property(e => e.LGD_RESPCODE).HasComment("응답코드");
            entity.Property(e => e.LGD_RESPMSG).HasComment("응답메세지");
            entity.Property(e => e.LGD_SAOWNER).HasComment("가상계좌 입금계좌주명");
            entity.Property(e => e.LGD_TELNO).HasComment("결제휴대폰번호");
            entity.Property(e => e.LGD_TID).HasComment("LG유플러스 거래번호");
            entity.Property(e => e.LGD_TIMESTAMP).HasComment("타임스탬프");
            entity.Property(e => e.LGD_TRANSAMOUNT).HasComment("환율적용금액");
        });

        modelBuilder.Entity<link_indd_order_variable>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("indd 라벨관리 (사용안함)"));

            entity.Property(e => e.indd_key).HasDefaultValueSql("'indd_label'");
            entity.Property(e => e.indd_label).HasComment("인디자인 라벨");
            entity.Property(e => e.indd_type).HasComment("인디자인 타입(청첩장:cont, 봉투:env)");
            entity.Property(e => e.item_key).HasComment("주문 아이템 키");
            entity.Property(e => e.item_type).HasComment("주문아이템 타입(청첩장:cont, 봉투:env)");
            entity.Property(e => e.variable_desc).HasComment("변수 설명");
        });

        modelBuilder.Entity<login_attempts>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("로그인 정보"));

            entity.Property(e => e.login_time)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<main_display>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.color_primary).HasComment("배경색");
            entity.Property(e => e.color_secondary).HasComment("색상2");
            entity.Property(e => e.color_tertiary).HasComment("색상3");
            entity.Property(e => e.contents).HasComment("꾸미기 HTML");
            entity.Property(e => e.display_image).HasComment("디스플레이 타이틀 대체 이미지");
            entity.Property(e => e.is_display)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("F: 사용함, T: 사용안함");
            entity.Property(e => e.sort_order).HasComment("정렬의 절렬");
            entity.Property(e => e.subject).HasComment("디스플레이 타이틀");
        });

        modelBuilder.Entity<main_display_product>(entity =>
        {
            entity.Property(e => e.main_display_id).HasComment("main_display.id");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.sort_order)
                .HasDefaultValueSql("'1'")
                .HasComment("정렬");
        });

        modelBuilder.Entity<marketing_agreement>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("마케팅동의"));

            entity.Property(e => e.agreed_at).HasComment("동의일시");
            entity.Property(e => e.agreement_step)
                .HasDefaultValueSql("'M'")
                .IsFixedLength()
                .HasComment("동의스텝(M:회원가입,O:주문,S:샘플주문)");
            entity.Property(e => e.agreement_type).HasComment("동의구분");
            entity.Property(e => e.cancelled_at).HasComment("취소일시");
            entity.Property(e => e.chk_agreement)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("동의여부");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.updated_at).HasComment("수정일시");
            entity.Property(e => e.user_id).HasComment("회원ID");
        });

        modelBuilder.Entity<marketing_agreement_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("마케팅동의로그"));

            entity.Property(e => e.admin_id).HasComment("처리자ID");
            entity.Property(e => e.agreement_step)
                .HasDefaultValueSql("'M'")
                .IsFixedLength()
                .HasComment("동의스텝(M:회원가입,O:주문,S:샘플주문)");
            entity.Property(e => e.agreement_type).HasComment("동의구분");
            entity.Property(e => e.chk_agreement)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("동의여부");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.user_id).HasComment("회원ID");
        });

        modelBuilder.Entity<marketing_agreement_type>(entity =>
        {
            entity.HasKey(e => e.agreement_type).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("마케팅동의구분"));

            entity.Property(e => e.agreement_type).HasComment("동의구분");
            entity.Property(e => e.agreement_name).HasComment("마케팅동의명칭");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.ended).HasComment("종료일");
            entity.Property(e => e.is_use)
                .IsFixedLength()
                .HasComment("사용여부");
            entity.Property(e => e.started).HasComment("시작일");
            entity.Property(e => e.updated_at).HasComment("수정일시");
        });

        modelBuilder.Entity<marketing_agreement_view>(entity =>
        {
            entity.HasKey(e => new { e.user_id, e.agreement_step })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable(tb => tb.HasComment("마케팅동의노출"));

            entity.Property(e => e.user_id).HasComment("회원ID");
            entity.Property(e => e.agreement_step)
                .IsFixedLength()
                .HasComment("동의스텝(O:주문, S:샘플주문)");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.updated_at).HasComment("수정일시");
        });

        modelBuilder.Entity<mds_pick_products>(entity =>
        {
            entity.Property(e => e.mds_pick_id).HasComment("id");
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<mds_picks>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.mo_banner_image).HasComment("mo 업로드 이미지");
            entity.Property(e => e.mo_contents).HasComment("MO 내용");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.pc_banner_image).HasComment("pc 업로드 이미지");
            entity.Property(e => e.pc_contents).HasComment("PC 내용");
            entity.Property(e => e.updater_id).HasComment("수정자");
        });

        modelBuilder.Entity<message_mail_template>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("email"));

            entity.Property(e => e.agreement_text).HasComment("수신동의 설명");
            entity.Property(e => e.body).HasComment("메일 내용");
            entity.Property(e => e.deny_text).HasComment("수신안함 설명");
            entity.Property(e => e.directsend_id).HasComment("다이렉트센드 아이디");
            entity.Property(e => e.logo_path).HasComment("로고패스");
            entity.Property(e => e.logo_state)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasComment("logo 사용:1, 사용안함:0");
            entity.Property(e => e.mail_subject).HasComment("메일 제목");
            entity.Property(e => e.return_url).HasComment("다이렉트센드 아이디");
            entity.Property(e => e.sender).HasComment("보내는 사람 메일주소");
            entity.Property(e => e.sender_info_text).HasComment("보내는 사람 정보");
            entity.Property(e => e.sender_name).HasComment("보내는사람이름");
        });

        modelBuilder.Entity<migrations>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<mobile_card_account>(entity =>
        {
            entity.HasKey(e => new { e.target_id, e.sort, e.category })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable(tb => tb.HasComment("모바일초대장 계좌입력"));

            entity.Property(e => e.target_id).HasComment("모바일청첩장 id");
            entity.Property(e => e.sort).HasComment("정렬");
            entity.Property(e => e.category)
                .HasDefaultValueSql("'1'")
                .HasComment("신랑신부구분");
            entity.Property(e => e.account_holder).HasComment("예금주");
            entity.Property(e => e.account_number).HasComment("계좌번호");
            entity.Property(e => e.bank_code).HasComment("은행코드");
            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.send_name).HasComment("입금대상");
            entity.Property(e => e.send_target_code).HasComment("입금대상코드");
            entity.Property(e => e.updated_at).HasComment("수정일시");
        });

        modelBuilder.Entity<mobile_card_addition>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("모바일청첩장 추가입력값"));

            entity.HasIndex(e => e.add_value, "idx_add_value").HasAnnotation("MySql:IndexPrefixLength", new[] { 255 });

            entity.Property(e => e.add_color).HasComment("입력값 색상");
            entity.Property(e => e.add_cx).HasComment("중앙 위치 x = (시작점 x + ( 시작점 가로크기/ 2 ) ) ...");
            entity.Property(e => e.add_cy).HasComment("중앙 위치 y = (시작점 y + ( 시작점 세로크기/ 2 ) ) ...");
            entity.Property(e => e.add_f).HasComment("폰트크기 %");
            entity.Property(e => e.add_family).HasComment("입력값 폰트종류");
            entity.Property(e => e.add_h).HasComment("시작점 세로크기 %");
            entity.Property(e => e.add_name).HasComment("입력값 이름");
            entity.Property(e => e.add_p)
                .HasDefaultValueSql("'0'")
                .HasComment("부모");
            entity.Property(e => e.add_size).HasComment("입력값 크기");
            entity.Property(e => e.add_type).HasComment("입력값 타입 (image, text, slide)");
            entity.Property(e => e.add_value).HasComment("입력값 ");
            entity.Property(e => e.add_w).HasComment("시작점 가로크기 %");
            entity.Property(e => e.add_weight).HasComment("입력값 굵기");
            entity.Property(e => e.add_x).HasComment("시작점 x %");
            entity.Property(e => e.add_y).HasComment("시작점 y %");
            entity.Property(e => e.is_full_width)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
        });

        modelBuilder.Entity<mobile_card_template_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));
        });

        modelBuilder.Entity<mobile_card_templates>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("모바일청첩장 템플릿"));

            entity.Property(e => e.background_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.bride_father_phone).HasComment("신부 아버지 전화번호");
            entity.Property(e => e.bride_mother_phone).HasComment("신부 어머니 전화번호");
            entity.Property(e => e.font_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.groom_father_phone).HasComment("신랑 아버지 전화번호");
            entity.Property(e => e.groom_mother_phone).HasComment("신랑 어머니 전화번호");
            entity.Property(e => e.movie_link).HasComment("영상링크 유알엘");
            entity.Property(e => e.primary_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.secondary_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.use_account)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("계좌번호입력사용 T:사용함, F:사용안함");
            entity.Property(e => e.use_gallary)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.use_movie)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("영상사용. T:사용함, F:사용안함");
            entity.Property(e => e.use_telephone)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("부모님 전화 사용. T:사용함, F:사용안함");
        });

        modelBuilder.Entity<mobile_cards>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("모바일청첩장"));

            entity.Property(e => e.background_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.bride_father_phone).HasComment("신부 아버지 전화번호");
            entity.Property(e => e.bride_mother_phone).HasComment("신부 어머니 전화번호");
            entity.Property(e => e.font_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.groom_father_phone).HasComment("신랑 아버지 전화번호");
            entity.Property(e => e.groom_mother_phone).HasComment("신랑 어머니 전화번호");
            entity.Property(e => e.is_disabled)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.map_route).HasComment("오시는 길을 json으로 넣어버릴꺼야");
            entity.Property(e => e.map_route_font_size)
                .HasDefaultValueSql("'1.00'")
                .HasComment("폰트 사이즈 em");
            entity.Property(e => e.movie_link).HasComment("영상링크 유알엘");
            entity.Property(e => e.preview_image).HasComment("미리보기이미지");
            entity.Property(e => e.primary_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.secondary_color).HasDefaultValueSql("'#000000'");
            entity.Property(e => e.use_account)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("계좌번호입력사용. T:사용함, F:사용안함");
            entity.Property(e => e.use_facebook)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.use_gallary)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:슬라이드배너 / N: 썸네일형/L:리스트형");
            entity.Property(e => e.use_guestbook)
                .HasDefaultValueSql("'T'")
                .IsFixedLength();
            entity.Property(e => e.use_map)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:사용함 / F:사용안함");
            entity.Property(e => e.use_map_route)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("T:사용함 / F:사용안함");
            entity.Property(e => e.use_movie)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("영상사용. T:사용함, F:사용안함");
            entity.Property(e => e.use_scale)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:확대가능 / F:확대불가능");
            entity.Property(e => e.use_show_image)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("메인, 인사말 이미지로 표시하기. T:이미지, F:글자");
            entity.Property(e => e.use_telephone)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("부모님 전화 사용. T:사용함, F:사용안함");
            entity.Property(e => e.use_toss)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.use_flower_gift)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("화환선물 사용여부 (T:사용함, F:사용안함)");
            entity.Property(e => e.social_image).HasComment("SNS공유이미지");
        });

        modelBuilder.Entity<mobile_invitation_board>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("모바일청첩장 게시판"));
        });

        modelBuilder.Entity<movie_order>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("영상주문관리(사용안함)"));

            entity.Property(e => e.bride_father).HasComment("신부 부");
            entity.Property(e => e.bride_mother).HasComment("신부 모");
            entity.Property(e => e.bride_name).HasComment("신부이름");
            entity.Property(e => e.bride_name_en).HasComment("신부이름 영문");
            entity.Property(e => e.bride_phone).HasComment("신부 전화");
            entity.Property(e => e.bride_rank).HasComment("신부 몇째");
            entity.Property(e => e.etc).HasComment("기타내용");
            entity.Property(e => e.groom_father).HasComment("신랑 부");
            entity.Property(e => e.groom_mother).HasComment("신랑 모");
            entity.Property(e => e.groom_name).HasComment("신랑이름");
            entity.Property(e => e.groom_name_en).HasComment("신랑영문");
            entity.Property(e => e.groom_phone).HasComment("신랑 전화");
            entity.Property(e => e.groom_rank).HasComment("신랑 몇째");
            entity.Property(e => e.link).HasComment("zip 파일 링크");
            entity.Property(e => e.order_id).HasComment("order.id");
            entity.Property(e => e.order_item_id).HasComment("order_item.id");
            entity.Property(e => e.order_item_no).HasComment("order_item.order_item_no");
            entity.Property(e => e.order_no).HasComment("order.order_no");
            entity.Property(e => e.product_id).HasComment("상품 번호");
            entity.Property(e => e.user_id).HasComment("유저아이디");
            entity.Property(e => e.wedd_date).HasComment("예식일");
            entity.Property(e => e.wedd_hour).HasComment("예식 시");
            entity.Property(e => e.wedd_minute).HasComment("예식 분");
            entity.Property(e => e.wedd_name).HasComment("예식장소");
            entity.Property(e => e.wedd_place).HasComment("예식홀");
        });

        modelBuilder.Entity<movie_order_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("영상 주문 이미지(사용안함)"));

            entity.Property(e => e.file_path).HasComment("사진 위치");
            entity.Property(e => e.is_zip)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("zip파일로 만들었니??");
            entity.Property(e => e.order_item_no).HasComment("order_item.order_item_no");
        });

        modelBuilder.Entity<movie_template>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("영상 템플릿"));

            entity.Property(e => e.code).HasComment("상품고유코드");
            entity.Property(e => e.contents).HasComment("상품상세 설명");
            entity.Property(e => e.free_qty).HasDefaultValueSql("'100'");
            entity.Property(e => e.moboil_contents).HasComment("모바일 상품상세 설명");
            entity.Property(e => e.movie_label).HasComment("상품 속성 라벨");
            entity.Property(e => e.name).HasComment("상품명");
            entity.Property(e => e.owner_id).HasComment("상품 번호");
            entity.Property(e => e.represent_image).HasComment("대표이미지");
            entity.Property(e => e.summary).HasComment("상품 간단 설명");
            entity.Property(e => e.supply).HasComment("브랜드");
            entity.Property(e => e.updater_id).HasComment("상품 번호");
        });

        modelBuilder.Entity<notifications>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("노티 리스트"));
        });

        modelBuilder.Entity<option_product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("옵션-상품 릴레이션"));

            entity.HasOne(d => d.option).WithMany().HasConstraintName("option_product_option_id_foreign");

            entity.HasOne(d => d.product).WithMany().HasConstraintName("option_product_product_id_foreign");
        });

        modelBuilder.Entity<options>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("옵션"));
        });

        modelBuilder.Entity<options_items>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("옵션아이템"));

            entity.HasOne(d => d.option).WithMany(p => p.options_items).HasConstraintName("options_items_option_id_foreign");
        });

        modelBuilder.Entity<order_addition_service>(entity =>
        {
            entity.HasKey(e => new { e.order_id, e.service_type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable(tb => tb.HasComment("주문 서비스 정보"));

            entity.Property(e => e.order_id).HasComment("주문ID");
            entity.Property(e => e.service_type).HasComment("서비스구분");
            entity.Property(e => e.created_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("등록일시");
            entity.Property(e => e.qty).HasComment("수량");
            entity.Property(e => e.service_price).HasComment("서비스 금액");
            entity.Property(e => e.service_unit_price).HasComment("서비스 단가");
        });

        modelBuilder.Entity<order_card_bases>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.order_no).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<order_card_contents>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문 카드 입력정보"));

            entity.Property(e => e.order_item_no).HasDefaultValueSql("'0'");
            entity.Property(e => e.order_no).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<order_card_envelopes>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문 봉투입력정보"));

            entity.Property(e => e.is_patternless)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.is_post_mark)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.post_mark_tail).HasDefaultValueSql("'요금별납'");
            entity.Property(e => e.recv_tail).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<order_card_qty>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문수량"));

            entity.Property(e => e.order_item_no).HasDefaultValueSql("'0'");
            entity.Property(e => e.order_no).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<order_coupon_history>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문 쿠폰 사용내역"));

            entity.Property(e => e.benefit_price).HasComment("할인금액 or 할인율");
            entity.Property(e => e.benefit_type)
                .IsFixedLength()
                .HasComment("할인타입");
            entity.Property(e => e.coupon_id).HasComment("coupons.id");
            entity.Property(e => e.coupon_type)
                .IsFixedLength()
                .HasComment("쿠폰 타입 (D:기본 / P:제휴사)");
            entity.Property(e => e.discount_price).HasComment("할인적용금액");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.partner_shop_id).HasComment("partner_shop.id");
        });

        modelBuilder.Entity<order_deposits>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("무통장입금내역"));

            entity.Property(e => e.bank_name).HasComment("입금자");
            entity.Property(e => e.deposit_date).HasComment("입금일");
            entity.Property(e => e.deposit_memo).HasComment("입금 내용");
            entity.Property(e => e.deposit_money).HasComment("입금금액");
            entity.Property(e => e.deposit_progress)
                .HasDefaultValueSql("'B'")
                .HasComment("입금진행상황 - B: 입금전, E: 입금완료, C:금액변경, X:입금취소");
            entity.Property(e => e.etc_memo).HasComment("비고");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.owner_id).HasComment("남긴사람");
            entity.Property(e => e.user_id).HasComment("orders.user_id");
        });

        modelBuilder.Entity<order_item_addition>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문부가상품"));

            entity.Property(e => e.add_price).HasComment("추가금액");
            entity.Property(e => e.addition_id).HasComment("invitation_card_addition.id");
            entity.Property(e => e.addition_type).HasComment("invitation_card_addition.tadd_ype");
            entity.Property(e => e.addition_value).HasComment("추가 입력값 value");
            entity.Property(e => e.item_cnt).HasComment("주문수량");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_item_id).HasComment("order_items.id");
            entity.Property(e => e.order_item_no).HasComment("order_items.order_item_no");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.start_no).HasDefaultValueSql("'1'");
            entity.Property(e => e.total_cnt).HasComment("전체수량");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<order_item_detail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.detail_type)
                .HasDefaultValueSql("'CD'")
                .HasComment("CD:카드, EP:봉투, SK:스티커, SR:스테이셔너리, TK:티켓, ETC:일반");
            entity.Property(e => e.order_id).HasComment("오더 id");
            entity.Property(e => e.order_item_detail_no).HasComment("오더 아이템 디테일 id");
            entity.Property(e => e.order_item_id).HasComment("오더 아이템 id");
        });

        modelBuilder.Entity<order_item_options>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문옵션"));

            entity.Property(e => e.option_item_code).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<order_items>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문-아이템"));

            entity.Property(e => e.barunson_order_type)
                .HasDefaultValueSql("'base'")
                .HasComment("바른손 주문타입: base: 인쇄제품, etc: 완제품");
            entity.Property(e => e.draft_change)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.draft_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.is_create_file).HasDefaultValueSql("'F'");
            entity.Property(e => e.is_draft).HasDefaultValueSql("'F'");
            entity.Property(e => e.is_printing).HasDefaultValueSql("'F'");
            entity.Property(e => e.is_reciving)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("완선된 상품 : 입고: T, 입고안됨: F");
            entity.Property(e => e.parent_id).HasDefaultValueSql("'0'");
            entity.Property(e => e.printing_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.product_code).HasDefaultValueSql("'0'");
            entity.Property(e => e.product_name).HasDefaultValueSql("'0'");
            entity.Property(e => e.reciving_at).HasComment("완선된 상품 입고시간");
            entity.Property(e => e.red_order_item_no).HasComment("레드주문번호");
            entity.Property(e => e.status_red).HasDefaultValueSql("'PGS'");
        });

        modelBuilder.Entity<order_job_ticket>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문 업무관리"));

            entity.Property(e => e._checked)
                .HasDefaultValueSql("'0'")
                .HasComment("확인 유무");
            entity.Property(e => e.checked_manager).HasComment("확인한 사람");
            entity.Property(e => e.contents).HasComment("작업내역");
            entity.Property(e => e.manager).HasComment("작성자 id");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
        });

        modelBuilder.Entity<order_money_change_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("금액변동 로그"));

            entity.Property(e => e.after).HasComment("환불계좌");
            entity.Property(e => e.before).HasComment("환불은행");
            entity.Property(e => e.change_memo).HasComment("변경 사유메모");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.owner_id).HasComment("남긴사람");
        });

        modelBuilder.Entity<order_refunds>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("환불정보"));

            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.owner_id).HasComment("남긴사람");
            entity.Property(e => e.refund_back_account).HasComment("예금주");
            entity.Property(e => e.refund_back_name).HasComment("환불은행");
            entity.Property(e => e.refund_back_number).HasComment("환불계좌");
            entity.Property(e => e.refund_cancel_memo).HasComment("환불 취소 사유");
            entity.Property(e => e.refund_due_date).HasComment("환불예정일");
            entity.Property(e => e.refund_memo).HasComment("환불 사유메모");
            entity.Property(e => e.refund_method)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("환불방법 - A: 무통장입금, B: 카드취소");
            entity.Property(e => e.refund_money).HasComment("환불금액");
            entity.Property(e => e.refund_progress)
                .HasDefaultValueSql("'B'")
                .HasComment("환분진행상황 - B: 환불요청, R: 환불예정, E:환불완료, X:환불취소");
            entity.Property(e => e.refund_type)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("환불타입 - A: 부분환불, B:전체환불");
            entity.Property(e => e.refunded_at).HasComment("환불일자");
        });

        modelBuilder.Entity<order_seq_autoinc>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문번호 시퀀스"));

            entity.Property(e => e.browser).HasComment("브라우져");
            entity.Property(e => e.browser_ver).HasComment("브라우져 버전");
            entity.Property(e => e.device).HasComment("기기정보");
            entity.Property(e => e.is_mobile).HasComment("모바일 주문 여부");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.platform).HasComment("운영체제");
            entity.Property(e => e.platform_ver).HasComment("운영체제 버전");
        });

        modelBuilder.Entity<orders>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("주문"));

            entity.Property(e => e.accident_image).HasComment("사고건 이미지");
            entity.Property(e => e.barunson_order_flag)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("바른손에 주문성공: T, 실패: F");
            entity.Property(e => e.barunson_order_type)
                .HasDefaultValueSql("'base'")
                .HasComment("바른손 주문타입: base: 인쇄제품, etc: 완제품");
            entity.Property(e => e.barunson_status_seq).HasComment("바른손 주문상태값");
            entity.Property(e => e.base_printing_company)
                .HasDefaultValueSql("'barunson'")
                .HasComment("red, barunson");
            entity.Property(e => e.box_unit)
                .HasDefaultValueSql("'1'")
                .HasComment("박스단위");
            entity.Property(e => e.charge_unit)
                .HasDefaultValueSql("'선불'")
                .HasComment("요금단위");
            entity.Property(e => e.delivery_price).HasComment("배송비");
            entity.Property(e => e.discount_money).HasComment("할인 금액");
            entity.Property(e => e.draft_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.is_accident)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.is_create_file)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.is_printing)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.locker_no).HasComment("사물함번호");
            entity.Property(e => e.order_base)
                .HasDefaultValueSql("'wcard'")
                .HasComment("wcard, goods, mcard");
            entity.Property(e => e.order_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.order_type)
                .HasDefaultValueSql("'D'")
                .IsFixedLength()
                .HasComment("주문 타입 : D=일반, Q:빠른");
            entity.Property(e => e.original_amount).HasComment("원금 합계");
            entity.Property(e => e.packing_at).HasComment("패킹시작시간");
            entity.Property(e => e.packing_state)
                .HasDefaultValueSql("'B'")
                .IsFixedLength()
                .HasComment("패킹상태 : B:시작전,  S:시작,  E:완료");
            entity.Property(e => e.partner_shop_id).HasComment("partner_shop.id");
            entity.Property(e => e.print_degree).HasComment("인쇄차수");
            entity.Property(e => e.printing_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.red_api_state).HasDefaultValueSql("'F'");
            entity.Property(e => e.red_order_no).HasComment("레드주문번호");
            entity.Property(e => e.refund_money).HasComment("환불금액");
            entity.Property(e => e.refund_type)
                .IsFixedLength()
                .HasComment("환불타입 - A: 부분환불, B:전체환불");
            entity.Property(e => e.refunded_at).HasComment("환불일자");
            entity.Property(e => e.shipping_due_date).HasComment("배송예정일");
            entity.Property(e => e.shipping_state).HasDefaultValueSql("'B'");
            entity.Property(e => e.shipping_type)
                .HasDefaultValueSql("'P'")
                .IsFixedLength()
                .HasComment("배송타입 : P=택배, D=직접, Q:퀵, ");
            entity.Property(e => e.status_red).HasDefaultValueSql("'PGS'");
            entity.Property(e => e.use_coupon)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.volumne_unit)
                .HasDefaultValueSql("'60'")
                .HasComment("부피단위");
        });

        modelBuilder.Entity<packing_manage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("스마트 패킹(사용안함)"));

            entity.Property(e => e.is_alive)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.is_empty)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("바구니 상태");
            entity.Property(e => e.order_id).HasComment("주문건 ");
            entity.Property(e => e.order_no).HasComment("바구니 상태");
            entity.Property(e => e.packing_no).HasComment("패킹바구니 번호");
        });

        modelBuilder.Entity<packing_manage_orders>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.is_packing)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("패킹 상태");
            entity.Property(e => e.order_id).HasComment("orders.id");
            entity.Property(e => e.packing_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("패킹 시간");
            entity.Property(e => e.packing_manage_id).HasComment("packing_manage.id");
        });

        modelBuilder.Entity<partner_accounts>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.due_date).HasComment("정산일");
            entity.Property(e => e.end_date).HasComment("종료일");
            entity.Property(e => e.memo).HasComment("비고");
            entity.Property(e => e.partner_shop_id).HasComment("제휴사 id");
            entity.Property(e => e.start_date).HasComment("시작일");
            entity.Property(e => e.supply_value).HasComment("공급가액");
            entity.Property(e => e.vat).HasComment("부가세");
        });

        modelBuilder.Entity<partner_shop>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("제휴몰"));

            entity.Property(e => e.business_number).HasComment("사업자번호");
            entity.Property(e => e.commission_rate).HasComment("수수료율(%)");
            entity.Property(e => e.coupon_id).HasComment("coupons_id, 0 = 사용안함)");
            entity.Property(e => e.due_date).HasComment("정산일");
            entity.Property(e => e.end_date).HasComment("마감일");
            entity.Property(e => e.partner_addr1).HasComment("제휴사주소1");
            entity.Property(e => e.partner_addr2).HasComment("제휴사주소2");
            entity.Property(e => e.partner_name).HasComment("제휴사명");
            entity.Property(e => e.tax_type)
                .HasDefaultValueSql("'D'")
                .IsFixedLength()
                .HasComment("과세유형");
            entity.Property(e => e.use_commission)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("수수료율 사용여부 (T:사용/F:사용안함)");
            entity.Property(e => e.vat_type)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("VAT (T:포함/F:별도)");
        });

        modelBuilder.Entity<partner_user_password_reset>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("파트너 암호 재설정"));

            entity.Property(e => e.email).HasComment("이메일");
            entity.Property(e => e.token).HasComment("토큰");
        });

        modelBuilder.Entity<partner_users>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("제휴몰 샵 관리자"));

            entity.Property(e => e.email).HasComment("사용자 이메일");
            entity.Property(e => e.name).HasComment("사용자 명");
            entity.Property(e => e.partner_shop_id).HasComment("partner_shop.id");
            entity.Property(e => e.password).HasComment("암호");
            entity.Property(e => e.phone).HasComment("전화번호");
            entity.Property(e => e.remember_token).HasComment("리멤버");
            entity.Property(e => e.user_id).HasComment("유저 아이디");
        });

        modelBuilder.Entity<password_resets>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("암호 재설정"));
        });

        modelBuilder.Entity<permission_role>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));
        });

        modelBuilder.Entity<permissions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));
        });

        modelBuilder.Entity<pick_product>(entity =>
        {
            entity.Property(e => e.pick_id).HasComment("id");
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<print_file_history>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인쇄 파일 히스토리(사용안함)"));

            entity.Property(e => e.item_group).HasComment("아이템 그룹");
            entity.Property(e => e.item_link).HasComment("프린트 아이템 링크");
            entity.Property(e => e.item_type).HasComment("아이템 타입");
            entity.Property(e => e.order_item_no).HasComment("order_item_no");
            entity.Property(e => e.order_no).HasComment("order_no");
        });

        modelBuilder.Entity<product_card_addition>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("product-invitation_card_addition 릴레이션"));

            entity.Property(e => e.addition_id).HasComment("invitation_card_addition.id");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T: ticket, S: sticker");
            entity.Property(e => e.use_charge)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasComment("유료여부");
        });

        modelBuilder.Entity<product_content_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<product_format>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("인쇄규격"));

            entity.Property(e => e.color).HasDefaultValueSql("'none'");
            entity.Property(e => e.format_attache).HasComment("별첨");
            entity.Property(e => e.format_envelope).HasComment("봉투");
            entity.Property(e => e.format_font).HasComment("기타폰트");
            entity.Property(e => e.format_manufacture).HasComment("가공");
            entity.Property(e => e.format_paper).HasComment("종이");
            entity.Property(e => e.format_producing).HasComment("생산처");
            entity.Property(e => e.format_type).HasComment("구조 (F001: 2단 가로, F002: 2단 세로, F003: 3단 가로, F004: 3단 세로, F005: 단장 양면, F006: 단장 단면 2장 구성, F007: 단장 양면 2장 구성)");
            entity.Property(e => e.format_x).HasComment("가로 길이 mm");
            entity.Property(e => e.format_y).HasComment("세로 길이 mm");
            entity.Property(e => e.is_map_background)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.product_id).HasComment("product.id");
        });

        modelBuilder.Entity<product_gift>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("사은품관리"));

            entity.Property(e => e.desc).HasComment("사은품설명");
            entity.Property(e => e.end_date).HasComment("종료일");
            entity.Property(e => e.name).HasComment("사은품명");
            entity.Property(e => e.start_date).HasComment("시작일");
            entity.Property(e => e.state).HasComment("진행상태");
            entity.Property(e => e.stock).HasComment("재고");
            entity.Property(e => e.use_stock)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("재고사용여부");
        });

        modelBuilder.Entity<product_mcard_template>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품-모바일청첩장 릴레이션"));

            entity.Property(e => e.mobile_card_template_id).HasComment("mobile_card_templates.id");
            entity.Property(e => e.product_id).HasComment("products.id");
        });

        modelBuilder.Entity<product_movie_template>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("상품-영상 릴레이션"));

            entity.Property(e => e.movie_template_id).HasComment("movie_template.id");
            entity.Property(e => e.product_id).HasComment("products.id");
        });

        modelBuilder.Entity<product_pick>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.mo_banner_image).HasComment("mo 업로드 이미지");
            entity.Property(e => e.mo_contents).HasComment("MO 내용");
            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.pc_banner_image).HasComment("pc 업로드 이미지");
            entity.Property(e => e.pc_contents).HasComment("PC 내용");
            entity.Property(e => e.updater_id).HasComment("수정자");
        });

        modelBuilder.Entity<product_picks>(entity =>
        {
            entity.Property(e => e.pick_id).HasComment("id");
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<product_relations>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("관련상품(컬러옵션)"));

            entity.Property(e => e.child_add_price).HasComment("추가금액");
            entity.Property(e => e.child_color).HasComment("연관상품 컬러");
            entity.Property(e => e.child_display_type).HasComment("표시방식");
            entity.Property(e => e.child_product_id).HasComment("연결상품 products.id");
            entity.Property(e => e.child_title).HasComment("연관상품 타이틀");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.sort_order)
                .HasDefaultValueSql("'127'")
                .HasComment("표시순서");
        });

        modelBuilder.Entity<product_sets>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.cutting_mark)
                .HasDefaultValueSql("'n'")
                .IsFixedLength();
            entity.Property(e => e.cutting_price).HasDefaultValueSql("'0'");
            entity.Property(e => e.discount_mark)
                .HasDefaultValueSql("'n'")
                .IsFixedLength();
            entity.Property(e => e.discount_price).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<product_sweetday>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
            entity.Property(e => e.sweetday_id).HasComment("상품 id");
        });

        modelBuilder.Entity<products>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("상품관리"));

            entity.Property(e => e.badge)
                .HasDefaultValueSql("''")
                .HasComment("badge type");
            entity.Property(e => e.best_md).HasComment("MD추천(null:사용 안함 / 그외:sort_order)");
            entity.Property(e => e.best_monthly).HasComment("주간베스트(null:사용 안함 / 그외:sort_order)");
            entity.Property(e => e.best_review).HasComment("후기베스트(null:사용 안함 / 그외:sort_order)");
            entity.Property(e => e.default_price)
                .HasDefaultValueSql("'0.00'")
                .HasComment("300매 기준 금액");
            entity.Property(e => e.discount_rate).HasDefaultValueSql("'0'");
            entity.Property(e => e.env_print_type)
                .HasDefaultValueSql("'E'")
                .IsFixedLength()
                .HasComment("봉투인쇄 (E:일반봉투/S:스페셜봉투)");
            entity.Property(e => e.first_order_free)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("T:첫주문무료/F:사용안함");
            entity.Property(e => e.has_after_step)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
            entity.Property(e => e.is_display)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:화면표시, F:화면표시안함");
            entity.Property(e => e.is_envinsert).HasComment("봉투삽입 서비스");
            entity.Property(e => e.is_handmade).HasComment("부속부착 서비스");
            entity.Property(e => e.is_inpaper).HasComment("속지삽입 서비스");
            entity.Property(e => e.is_mcardset).HasComment("모바일뱃지셋트사용/사용안함");
            entity.Property(e => e.is_printed)
                .HasDefaultValueSql("'0'")
                .HasComment("인쇄 상태");
            entity.Property(e => e.is_special).HasComment("초특급제작");
            entity.Property(e => e.join_order_free)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasComment("Y:회원가입무료/N:사용안함");
            entity.Property(e => e.order_count)
                .HasDefaultValueSql("'0'")
                .HasComment("주문 횟수");
            entity.Property(e => e.price).HasComment("판매가");
            entity.Property(e => e.printing_company)
                .HasDefaultValueSql("'barunson'")
                .HasComment("인쇄하는 곳이지: red or barunson");
            entity.Property(e => e.qty_type)
                .HasDefaultValueSql("'option'")
                .HasComment("수량옵션 타입");
            entity.Property(e => e.sale).HasComment("공급가");
            entity.Property(e => e.sale_price).HasComment("할인가");
            entity.Property(e => e.sample_count)
                .HasDefaultValueSql("'0'")
                .HasComment("샘플 발송 횟수");
            entity.Property(e => e.taxable).HasComment("텍스");
            entity.Property(e => e.today_sales).HasComment("금일판매량");
            entity.Property(e => e.unit_type)
                .HasDefaultValueSql("'0'")
                .HasComment("주문단위(1:장,2:개,3:매,4:SET,5:BOX)");
            entity.Property(e => e.unit_value)
                .HasDefaultValueSql("'0'")
                .HasComment("단위당 수량");
            entity.Property(e => e.use_inventory).HasComment("재고수량 표시 하기- 0: 사용안함, 1: 사용함");
            entity.Property(e => e.use_relation).HasComment("연관상품 사용할것이니?");
            entity.Property(e => e.use_sale_sample)
                .HasDefaultValueSql("'0'")
                .HasComment("샘플판매상태");
            entity.Property(e => e.use_today_sales).HasComment("금일판매량 표시 하기- 0: 사용안함, 1: 사용함");
            entity.Property(e => e.warning_desc).HasComment("판매 불가 상태 메세지");
        });

        modelBuilder.Entity<products_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasOne(d => d.product).WithMany(p => p.products_images).HasConstraintName("products_images_product_id_foreign");
        });

        modelBuilder.Entity<push_subscriptions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("노티피케이션(사용안함)"));

            entity.HasOne(d => d.user).WithMany(p => p.push_subscriptions).HasConstraintName("push_subscriptions_user_id_foreign");
        });

        modelBuilder.Entity<review_board>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("이용후기"));

            entity.Property(e => e.is_best)
                .HasDefaultValueSql("'F'")
                .HasComment("T:베스트리뷰/F:일반리뷰");
            entity.Property(e => e.is_show)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("노출상태(T:노출/F:숨김)");
            entity.Property(e => e.issue_state)
                .HasDefaultValueSql("'F'")
                .HasComment("T:쿠폰발급/F:쿠본미발급");
            entity.Property(e => e.link).HasComment("sns 게시물 링크");
        });

        modelBuilder.Entity<role_user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));
        });

        modelBuilder.Entity<roles>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("권한관리"));
        });

        modelBuilder.Entity<sample_cabinet>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("샘플장관리(사용안함)"));

            entity.Property(e => e.code).HasComment("상품코드 : DDC_001");
            entity.Property(e => e.col).HasComment("행번호 순서");
            entity.Property(e => e.ip_address).HasComment("행 ip 주소 : 192.168.50.10");
            entity.Property(e => e.row).HasComment("열 열번호 : 1, 2, 3 ...");
        });

        modelBuilder.Entity<sample_carts>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("샘플장바구니"));
        });

        modelBuilder.Entity<sample_order_items>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("샘풀 주문 아이템"));

            entity.Property(e => e.api_state_result).HasComment("레드 API 전송결과");
            entity.Property(e => e.barunson_card_code).HasComment("s2_card.card_code");
            entity.Property(e => e.barunson_card_seq).HasComment("s2_card.card_seq");
            entity.Property(e => e.barunson_samlpe_order_seq).HasComment("custom_sample_order.sample_order_seq");
            entity.Property(e => e.is_changeable)
                .HasDefaultValueSql("'0'")
                .HasComment("가변샘플");
            entity.Property(e => e.item_cnt)
                .HasDefaultValueSql("'1'")
                .HasComment("주문수량");
            entity.Property(e => e.item_type)
                .HasDefaultValueSql("'wcard'")
                .HasComment("아이템타입");
            entity.Property(e => e.product_code).HasComment("products.code");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.product_name).HasComment("상품명");
            entity.Property(e => e.sample_order_id).HasComment("sample_orders.id");
            entity.Property(e => e.sample_order_item_no).HasComment("아이템번호");
            entity.Property(e => e.sample_order_no).HasComment("sample_orders.sample_order_no");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<sample_order_items_dup>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘풀 주문 아이템"));

            entity.Property(e => e.api_state_result).HasComment("레드 API 전송결과");
            entity.Property(e => e.barunson_card_code).HasComment("s2_card.card_code");
            entity.Property(e => e.barunson_card_seq).HasComment("s2_card.card_seq");
            entity.Property(e => e.barunson_samlpe_order_seq).HasComment("custom_sample_order.sample_order_seq");
            entity.Property(e => e.is_changeable)
                .HasDefaultValueSql("'0'")
                .HasComment("가변샘플");
            entity.Property(e => e.item_cnt)
                .HasDefaultValueSql("'1'")
                .HasComment("주문수량");
            entity.Property(e => e.item_type)
                .HasDefaultValueSql("'wcard'")
                .HasComment("아이템타입");
            entity.Property(e => e.product_code).HasComment("products.code");
            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.product_name).HasComment("상품명");
            entity.Property(e => e.sample_order_id).HasComment("sample_orders.id");
            entity.Property(e => e.sample_order_item_no).HasComment("아이템번호");
            entity.Property(e => e.sample_order_no).HasComment("sample_orders.sample_order_no");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<sample_orders>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("샘플주문"));

            entity.Property(e => e.addresses_id).HasComment("addresses.id");
            entity.Property(e => e.admin_memo).HasComment("관리자 메모");
            entity.Property(e => e.bank_info).HasComment("은행명");
            entity.Property(e => e.bank_name).HasComment("은행명");
            entity.Property(e => e.barunson_order_seq).HasComment("custom_samlpe_order.samlpq_order_seq");
            entity.Property(e => e.bride_fname).HasComment("신부 성");
            entity.Property(e => e.bride_fname_eng).HasComment("신부 영문 이름");
            entity.Property(e => e.bride_name).HasComment("신부 이름");
            entity.Property(e => e.bride_name_eng).HasComment("신부 영문성");
            entity.Property(e => e.cash).HasComment("무통장입금");
            entity.Property(e => e.groom_fname).HasComment("신랑 성");
            entity.Property(e => e.groom_fname_eng).HasComment("신랑 영문 이름");
            entity.Property(e => e.groom_name).HasComment("신랑 이름");
            entity.Property(e => e.groom_name_eng).HasComment("신랑 영문성");
            entity.Property(e => e.is_create_file)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("F U+ 주문취소가능 / T 취소불가 ");
            entity.Property(e => e.memo).HasComment("메모");
            entity.Property(e => e.order_ip).HasComment("주문자 ip");
            entity.Property(e => e.order_state)
                .HasDefaultValueSql("'B'")
                .HasComment("주문상태");
            entity.Property(e => e.order_step)
                .HasDefaultValueSql("'payment'")
                .HasComment("payment||fail");
            entity.Property(e => e.order_useragent).HasComment("주문자 useragent");
            entity.Property(e => e.paid_list_id).HasComment("lguplus_paid_list.id");
            entity.Property(e => e.paid_money).HasComment("전체금액");
            entity.Property(e => e.partner_shop_id).HasComment("partner_shop.id");
            entity.Property(e => e.pay_date).HasComment("결제 일자");
            entity.Property(e => e.pay_day).HasComment("결제 일");
            entity.Property(e => e.pay_month).HasComment("결제 월");
            entity.Property(e => e.pay_type).HasComment("결제 타입");
            entity.Property(e => e.pay_year).HasComment("결제 년");
            entity.Property(e => e.pg_app_no).HasComment("결제 앱 번호");
            entity.Property(e => e.pg_name).HasComment("결제회사명");
            entity.Property(e => e.pg_tno).HasComment("결제 회사 tid");
            entity.Property(e => e.printing_state)
                .HasDefaultValueSql("'B'")
                .HasComment("제작상태");
            entity.Property(e => e.refund_money).HasComment("환불금액");
            entity.Property(e => e.refund_type)
                .IsFixedLength()
                .HasComment("환불타입 - A: 부분환불, B:전체환불");
            entity.Property(e => e.refunded_at).HasComment("환불일자");
            entity.Property(e => e.sample_order_no).HasComment("주문번호");
            entity.Property(e => e.shipping_at).HasComment("샘플발송일");
            entity.Property(e => e.shipping_company).HasComment("배송사");
            entity.Property(e => e.shipping_num).HasComment("송장번호");
            entity.Property(e => e.shipping_state)
                .HasDefaultValueSql("'B'")
                .HasComment("배송상태");
            entity.Property(e => e.total_money).HasComment("전체금액");
            entity.Property(e => e.user_id).HasComment("users.id");
            entity.Property(e => e.wedd_date).HasComment("예식일");
        });

        modelBuilder.Entity<sample_orders_dup>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘플주문"));

            entity.Property(e => e.addresses_id).HasComment("addresses.id");
            entity.Property(e => e.admin_memo).HasComment("관리자 메모");
            entity.Property(e => e.bank_info).HasComment("은행명");
            entity.Property(e => e.bank_name).HasComment("은행명");
            entity.Property(e => e.barunson_order_seq).HasComment("custom_samlpe_order.samlpq_order_seq");
            entity.Property(e => e.bride_fname).HasComment("신부 성");
            entity.Property(e => e.bride_fname_eng).HasComment("신부 영문 이름");
            entity.Property(e => e.bride_name).HasComment("신부 이름");
            entity.Property(e => e.bride_name_eng).HasComment("신부 영문성");
            entity.Property(e => e.cash).HasComment("무통장입금");
            entity.Property(e => e.groom_fname).HasComment("신랑 성");
            entity.Property(e => e.groom_fname_eng).HasComment("신랑 영문 이름");
            entity.Property(e => e.groom_name).HasComment("신랑 이름");
            entity.Property(e => e.groom_name_eng).HasComment("신랑 영문성");
            entity.Property(e => e.is_create_file)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("F U+ 주문취소가능 / T 취소불가 ");
            entity.Property(e => e.memo).HasComment("메모");
            entity.Property(e => e.order_ip).HasComment("주문자 ip");
            entity.Property(e => e.order_state)
                .HasDefaultValueSql("'B'")
                .HasComment("주문상태");
            entity.Property(e => e.order_step)
                .HasDefaultValueSql("'payment'")
                .HasComment("payment||fail");
            entity.Property(e => e.order_useragent).HasComment("주문자 useragent");
            entity.Property(e => e.paid_list_id).HasComment("lguplus_paid_list.id");
            entity.Property(e => e.paid_money).HasComment("전체금액");
            entity.Property(e => e.partner_shop_id).HasComment("partner_shop.id");
            entity.Property(e => e.pay_date).HasComment("결제 일자");
            entity.Property(e => e.pay_day).HasComment("결제 일");
            entity.Property(e => e.pay_month).HasComment("결제 월");
            entity.Property(e => e.pay_type).HasComment("결제 타입");
            entity.Property(e => e.pay_year).HasComment("결제 년");
            entity.Property(e => e.pg_app_no).HasComment("결제 앱 번호");
            entity.Property(e => e.pg_name).HasComment("결제회사명");
            entity.Property(e => e.pg_tno).HasComment("결제 회사 tid");
            entity.Property(e => e.printing_state)
                .HasDefaultValueSql("'B'")
                .HasComment("제작상태");
            entity.Property(e => e.refund_money).HasComment("환불금액");
            entity.Property(e => e.refund_type)
                .IsFixedLength()
                .HasComment("환불타입 - A: 부분환불, B:전체환불");
            entity.Property(e => e.refunded_at).HasComment("환불일자");
            entity.Property(e => e.sample_order_no).HasComment("주문번호");
            entity.Property(e => e.shipping_at).HasComment("샘플발송일");
            entity.Property(e => e.shipping_company).HasComment("배송사");
            entity.Property(e => e.shipping_num).HasComment("송장번호");
            entity.Property(e => e.shipping_state)
                .HasDefaultValueSql("'B'")
                .HasComment("배송상태");
            entity.Property(e => e.total_money).HasComment("전체금액");
            entity.Property(e => e.user_id).HasComment("users.id");
            entity.Property(e => e.wedd_date).HasComment("예식일");
        });

        modelBuilder.Entity<sample_stock_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("샘플재고 로그(사용안함)"));

            entity.Property(e => e.after).HasComment("변경된수량");
            entity.Property(e => e.before).HasComment("이전수량");
            entity.Property(e => e.cnt).HasComment("수량");
            entity.Property(e => e.code).HasComment("item_typeset.item_code");
            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.item_typeset_id).HasComment("item_typeset.id");
            entity.Property(e => e.sample_order_no).HasComment("샘플주문번호");
            entity.Property(e => e.type)
                .IsFixedLength()
                .HasComment("M:마이너스, P:플러스");
        });

        modelBuilder.Entity<search_word>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.color_font).HasComment("폰트색");
            entity.Property(e => e.is_display)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("F: 사용안함, T: 사용 함");
            entity.Property(e => e.is_main)
                .IsFixedLength()
                .HasComment("F: 사용안함, T: 사용 함 검색 타이틀여부 ");
            entity.Property(e => e.keyword).HasComment("키워드");
            entity.Property(e => e.link_url).HasComment("이동경로 url");
            entity.Property(e => e.sort_order).HasComment("정렬");
            entity.Property(e => e.target).HasComment("_self : 본창 / _blank : 새창 이동 ");
        });

        modelBuilder.Entity<search_word_product>(entity =>
        {
            entity.Property(e => e.product_id).HasComment("상품 id");
            entity.Property(e => e.search_word_id).HasComment("id");
            entity.Property(e => e.sort_order).HasComment("상품 sort");
        });

        modelBuilder.Entity<send_email_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("email 전송로그"));

            entity.Property(e => e.body).HasComment("내용");
            entity.Property(e => e.email_id).HasComment("email.id");
            entity.Property(e => e.recipients).HasComment("발송 email");
            entity.Property(e => e.result).HasComment("응답메세지");
            entity.Property(e => e.subject).HasComment("제목");
        });

        modelBuilder.Entity<send_sms_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("sms 전송로그"));

            entity.Property(e => e.message).HasComment("메세지");
            entity.Property(e => e.recipients).HasComment("전송");
            entity.Property(e => e.result).HasComment("응답메세지");
            entity.Property(e => e.sms_id).HasComment("sms.id");
        });

        modelBuilder.Entity<serial_coupon_issue>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("시리얼쿠폰 발급"));

            entity.Property(e => e.is_used)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("사용하였뉘");
            entity.Property(e => e.issue_no).HasComment("coupons.id");
            entity.Property(e => e.order_no).HasComment("order.order_no");
            entity.Property(e => e.serial_coupon_id).HasComment("serial_coupons.id");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<serial_coupon_user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("시리얼쿠폰-유저 릴레이션"));

            entity.Property(e => e.end_datetime).HasComment("user idx");
            entity.Property(e => e.serial_coupon_id).HasComment("user idx");
            entity.Property(e => e.start_datetime).HasComment("user idx");
            entity.Property(e => e.user_id).HasComment("user idx");
        });

        modelBuilder.Entity<serial_coupons>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("시리얼쿠폰"));

            entity.Property(e => e.benefit_max_price).HasComment("혜택구분 최대금액");
            entity.Property(e => e.benefit_percent).HasComment("혜택구분 퍼센트");
            entity.Property(e => e.benefit_price).HasComment("혜택금액 금액");
            entity.Property(e => e.benefit_round_unit).HasComment("퍼센트 절사 : 절사안함 : 0.1, 1 : 1, 10 : 10, 100 : 100, 1000 : 1000");
            entity.Property(e => e.benefit_sub_type)
                .IsFixedLength()
                .HasComment("혜택구분 기본배송비 할인일때 > 전액할인 : E, 할인율 : I, 할인금액 : H");
            entity.Property(e => e.benefit_type).HasComment("혜택구분 필수 >  할인금액 : A, 할인율 : B, 적립금액 : C, 적립율 : D, 기본배송비할인 : E, 즉시 적립 : F, 예치금 지급 : G");
            entity.Property(e => e.coupon_desc).HasComment("쿠폰설명");
            entity.Property(e => e.coupon_direct).HasComment("쿠폰 직접 등록");
            entity.Property(e => e.coupon_name).HasComment("쿠폰이름 필수");
            entity.Property(e => e.include_foreign_delivery)
                .IsFixedLength()
                .HasComment("해외배송 포함여부 >  포함 : T,  미포함 : F");
            entity.Property(e => e.include_region_shipping_fee)
                .IsFixedLength()
                .HasComment("지역별 배송비 포함여부 >  포함 : T,  미포함 : F");
            entity.Property(e => e.is_max_issue_count_for_user)
                .IsFixedLength()
                .HasComment("동일인 재발급 여부 >  불가능 : F,  가능 : T");
            entity.Property(e => e.issue_for_price_calculate)
                .IsFixedLength()
                .HasComment("적용 계산 기준 > 할인(쿠폰 제외) 적용 전 결제 금액 : E, 할인(쿠폰 제외) 적용 후 결제 금액 : I");
            entity.Property(e => e.linked_coupon_id).HasComment("coupons.id");
            entity.Property(e => e.max_issue_count).HasComment("최대 발급 수량 설정 필수");
            entity.Property(e => e.max_issue_count_for_user).HasComment("동일인 재발급 수량");
            entity.Property(e => e.max_use_count_for_order).HasComment("동일쿠폰사용 설정 (주문서당 n개 까지 사용가능)");
            entity.Property(e => e.serial_gen_method)
                .IsFixedLength()
                .HasComment("시리얼 번호 생성 방법자동 생성 : A, 직접 등록 : M, 엑셀 업로드 : E");
            entity.Property(e => e.serial_no_length).HasComment("시리얼 번호 생성 방법자동 생성 : 10 : 10, 11 : 11, 12 : 12, 13 : 13, 14 : 14, 15 : 15, 16 : 16, 17 : 17, 18 : 18, 19 : 19, 20 : 20, 21 : 21, 22 : 22, 23 : 23, 24 : 24, 25 : 25, 26 : 26, 27 : 27, 28 : 28, 29 : 29, 30 : 30, 31 : 31, 32 : 32, 33 : 33, 34 : 34, 35 : 35");
            entity.Property(e => e.serial_no_type)
                .IsFixedLength()
                .HasComment("시리얼 번호 생성 기준 > 랜덤 번호 생성 : R,  동일 번호 생성 : S");
            entity.Property(e => e.use_available_day_from).HasComment("사용가능 ~ 일간");
            entity.Property(e => e.use_available_end_day).HasComment("사용가능 종료일");
            entity.Property(e => e.use_available_min_price).HasComment("사용가능 기준금액 (모든 상품의 주문 금액:U, 쿠폰 적용 상품의 주문 금액:I)");
            entity.Property(e => e.use_available_period_type)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("사용 기간 : 기간기간 설정 : F, 쿠폰 발급일 기준 : R, 쿠폰 발급 당월 말일까지 : M");
            entity.Property(e => e.use_available_price_detail_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("사용가능 기준금액 (모든 상품의 주문 금액:U, 쿠폰 적용 상품의 주문 금액:I)");
            entity.Property(e => e.use_available_price_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("사용가능 기준금액 (제한 없음:U, 주문 금액 기준:O, 상품 금액 기준:P)");
            entity.Property(e => e.use_available_start_day).HasComment("사용가능 시작일");
            entity.Property(e => e.use_category_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("쿠폰적용 카테고리선택 (모두 적용:U, 선택한 분류 적용:I, 선택한 분류 제외하고 적용:E)");
            entity.Property(e => e.use_domain_type_serial)
                .HasDefaultValueSql("'0'")
                .HasComment("사용범위  (PC: W, 모바일: M) ");
            entity.Property(e => e.use_level_type)
                .HasDefaultValueSql("'O'")
                .IsFixedLength()
                .HasComment("적용범위 ( 주문서쿠폰:O, 상품 쿠폰:P )");
            entity.Property(e => e.use_pay_method_binding_type).HasComment("사용가능 결제수단 (무통장입금: R, 가상계좌: E, 카드결제: C,   실시간계좌이체: A, 휴대폰결제: H)");
            entity.Property(e => e.use_place).HasComment("쿠폰 사용처");
            entity.Property(e => e.use_product_binding_type)
                .HasDefaultValueSql("'U'")
                .IsFixedLength()
                .HasComment("쿠폰적용상품 선택 (모두 적용:U, 선택한 상품 적용:I, 선택한 상품 제외하고 적용:E)");
        });

        modelBuilder.Entity<serial_coupons_category>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("시리얼쿠폰-카테고리 릴레이션"));

            entity.Property(e => e.category_id).HasComment("products.id");
            entity.Property(e => e.serial_coupons_id).HasComment("serial_coupon.id");
        });

        modelBuilder.Entity<serial_coupons_product>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("시리얼쿠폰-상품 릴레이션"));

            entity.Property(e => e.product_id).HasComment("products.id");
            entity.Property(e => e.serial_coupon_id).HasComment("serial_coupon.id");
        });

        modelBuilder.Entity<shipping_manage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("배송비관리"));

            entity.Property(e => e.state)
                .HasDefaultValueSql("'F'")
                .IsFixedLength();
        });

        modelBuilder.Entity<shopping_carts>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("장바구니(사용안함)"));
        });

        modelBuilder.Entity<site_policy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("운영관리"));

            entity.Property(e => e.code).HasComment("코드");
            entity.Property(e => e.name)
                .HasDefaultValueSql("'0'")
                .HasComment("이름");
            entity.Property(e => e.type)
                .HasDefaultValueSql("'0'")
                .HasComment("타입");
            entity.Property(e => e.use_policy)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("T:사용함, F:사용안함");
        });

        modelBuilder.Entity<site_policy_benefit>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("투인원 할인율관리"));

            entity.Property(e => e.site_policy_id).HasComment("site_policy.id");
        });

        modelBuilder.Entity<site_popup>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("메인 팝업"));

            entity.Property(e => e.owner_id).HasComment("작성자");
            entity.Property(e => e.popup_desc).HasComment("팝업설명");
            entity.Property(e => e.popup_name).HasComment("팝업명");
            entity.Property(e => e.position_left).HasComment("브라우저 좌표 x");
            entity.Property(e => e.position_top).HasComment("브라우저 좌표 y");
            entity.Property(e => e.size_height).HasComment("팝업세로크기");
            entity.Property(e => e.size_width).HasComment("팝업가로크기");
            entity.Property(e => e.state).HasComment("노출상태");
            entity.Property(e => e.updater_id).HasComment("수정자");
        });

        modelBuilder.Entity<site_type_manager>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("타입메니져(사용안함)"));

            entity.Property(e => e.manage_label).HasComment("테이블 라벨");
            entity.Property(e => e.manage_name).HasComment("테이블 명");
            entity.Property(e => e.owner_id).HasComment("생성자  users.id");
            entity.Property(e => e.updater_id).HasComment("업데이트  users.id");
        });

        modelBuilder.Entity<site_type_manager_column>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.column_label).HasComment("컬럼명 라벨");
            entity.Property(e => e.column_name).HasComment("실제 컬럼명");
            entity.Property(e => e.site_type_manager_id).HasComment("site_type_manager.id");
        });

        modelBuilder.Entity<site_type_manager_column_items>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.item_label).HasComment("아이템 라벨");
            entity.Property(e => e.item_value).HasComment("아이템 값");
            entity.Property(e => e.site_type_manager_column_id).HasComment("site_type_manager_column.id");
            entity.Property(e => e.site_type_manager_id).HasComment("site_type_manager.id");
        });

        modelBuilder.Entity<sitemap>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("기본사이트맵 정보"));

            entity.Property(e => e.add_type)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("A: Auto, M: Manual");
            entity.Property(e => e.changefreq)
                .HasDefaultValueSql("'always'")
                .HasComment("always, hourly, daily, weekly, monthly, yearly, never");
            entity.Property(e => e.loc).HasComment("URL을 넣어주세요.");
            entity.Property(e => e.priority)
                .HasDefaultValueSql("'9'")
                .HasComment("10 ~ 1");
        });

        modelBuilder.Entity<sms>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("sms 템플릿"));

            entity.Property(e => e.sms_code).HasComment("sms 코드");
            entity.Property(e => e.sms_desc).HasComment("sms 설명");
            entity.Property(e => e.sms_message).HasComment("sms 내용");
            entity.Property(e => e.sms_section).HasComment("sms 섹션");
        });

        modelBuilder.Entity<stickers>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("스티커"));

            entity.Property(e => e.id).HasComment("스티커_ID");
            entity.Property(e => e.code).HasComment("제품_코드");
            entity.Property(e => e.default_qty).HasDefaultValueSql("'300'");
            entity.Property(e => e.max_qty)
                .HasDefaultValueSql("'1000'")
                .HasComment("최대_주문_수량");
            entity.Property(e => e.product_id).HasComment("제품_ID");
            entity.Property(e => e.qty)
                .HasDefaultValueSql("'20'")
                .HasComment("기본_수량");
        });

        modelBuilder.Entity<sweetday>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
        });

        modelBuilder.Entity<sweetday_board>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.is_best)
                .HasDefaultValueSql("'F'")
                .HasComment("T:베스트리뷰/F:일반리뷰");
            entity.Property(e => e.is_show)
                .HasDefaultValueSql("'T'")
                .IsFixedLength()
                .HasComment("노출상태(T:노출/F:숨김)");
            entity.Property(e => e.issue_state)
                .HasDefaultValueSql("'F'")
                .HasComment("T:쿠폰발급/F:쿠본미발급");
            entity.Property(e => e.link).HasComment("sns 게시물 링크");
        });

        modelBuilder.Entity<thirdparty_oauth>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("oauth 관리"));

            entity.Property(e => e.accessKey).HasComment("accessKey");
            entity.Property(e => e.accessToken).HasComment("accessToken");
            entity.Property(e => e.base_url).HasComment("기본url");
            entity.Property(e => e.encrypt).HasComment("암호화타입");
            entity.Property(e => e.expireToken).HasComment("expireToken");
            entity.Property(e => e.refreshToken).HasComment("refreshToken");
            entity.Property(e => e.secretKey).HasComment("secretKey");
            entity.Property(e => e.type).HasComment("회사");
        });

        modelBuilder.Entity<toss_account>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("토스 축의금송금 계정(사용안함)"));

            entity.Property(e => e.target).HasComment("타겟");
            entity.Property(e => e.target_id).HasComment("타겟.id");
            entity.Property(e => e.toss_bank1).HasComment("받는분은행");
            entity.Property(e => e.toss_bankaccount1).HasComment("받는분 계좌");
            entity.Property(e => e.toss_owner1).HasComment("받는분");
        });

        modelBuilder.Entity<toss_api_logs>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("토스 API 로그(사용안함)"));

            entity.Property(e => e.mcard_code).HasComment("uuid");
            entity.Property(e => e.remote_addr).HasComment("remote_address");
            entity.Property(e => e.url).HasComment("order_item_no");
            entity.Property(e => e.user_agent).HasComment("user_agent");
            entity.Property(e => e.uuid).HasComment("uuid");
        });

        modelBuilder.Entity<toss_order>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("토스 주문(사용안함)"));

            entity.Property(e => e.content).HasComment("메세지");
            entity.Property(e => e.delivery_addr1).HasComment("수취인 주소1");
            entity.Property(e => e.delivery_addr2).HasComment("수취인 주소2");
            entity.Property(e => e.delivery_email).HasComment("수취인 이메일");
            entity.Property(e => e.delivery_money).HasComment("보낼 금액");
            entity.Property(e => e.delivery_name).HasComment("수취인명");
            entity.Property(e => e.delivery_phone).HasComment("수취인 연락처");
            entity.Property(e => e.delivery_phone_add).HasComment("수취인 추가 연락처");
            entity.Property(e => e.delivery_zipcode).HasComment("수취인 우편번호");
            entity.Property(e => e.hash).HasComment("toss에서 보내준 hash 값");
            entity.Property(e => e.memo).HasComment("메세지 내용");
            entity.Property(e => e.order_addr1).HasComment("주문자 주소1");
            entity.Property(e => e.order_addr2).HasComment("주문자 주소2");
            entity.Property(e => e.order_email).HasComment("주문자 이메일");
            entity.Property(e => e.order_name).HasComment("주문자명");
            entity.Property(e => e.order_no).HasComment("orders.order_no");
            entity.Property(e => e.order_phone).HasComment("주문자 연락처");
            entity.Property(e => e.order_phone_add).HasComment("주문자 추가 연락처");
            entity.Property(e => e.order_zipcode).HasComment("주문자 우편번호");
            entity.Property(e => e.product_code).HasComment("카드 종류");
        });

        modelBuilder.Entity<toss_stock>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("토스 재고(사용안함)"));

            entity.Property(e => e.code).HasComment("코드");
            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.money).HasComment("금액");
            entity.Property(e => e.safety_stock).HasComment("안전재고수량");
            entity.Property(e => e.stock).HasComment("재고수량");
        });

        modelBuilder.Entity<toss_stock_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("토스 재고 로그(사용안함)"));

            entity.Property(e => e.after).HasComment("변경된수량");
            entity.Property(e => e.before).HasComment("이전수량");
            entity.Property(e => e.cnt).HasComment("수량");
            entity.Property(e => e.code).HasComment("toss_stock.code");
            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.order_no).HasComment("주문번호");
            entity.Property(e => e.toss_stock_id).HasComment("toss_stock.id");
            entity.Property(e => e.type)
                .IsFixedLength()
                .HasComment("M:마이너스, P:플러스");
        });

        modelBuilder.Entity<typeset_stock_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.after).HasComment("변경된수량");
            entity.Property(e => e.before).HasComment("이전수량");
            entity.Property(e => e.cnt).HasComment("수량");
            entity.Property(e => e.code).HasComment("item_typeset.item_code");
            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.item_typeset_id).HasComment("item_typeset.id");
            entity.Property(e => e.order_no).HasComment("주문번호");
            entity.Property(e => e.type)
                .IsFixedLength()
                .HasComment("M:마이너스, P:플러스");
        });

        modelBuilder.Entity<uploaded_images>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("업로드 이미지 관리"));

            entity.Property(e => e.desc).HasComment("설명");
            entity.Property(e => e.link).HasComment("노출 url");
            entity.Property(e => e.order_no).HasComment("주문번호-모바일청첩장에서사용");
            entity.Property(e => e.origin).HasComment("업로드이미지");
            entity.Property(e => e.target).HasComment("{table}");
            entity.Property(e => e.target_id)
                .HasDefaultValueSql("'0'")
                .HasComment("{table}.id");
            entity.Property(e => e.thumb1).HasComment("썸네일1");
            entity.Property(e => e.thumb2).HasComment("썸네일2");
            entity.Property(e => e.thumb3).HasComment("썸네일3");
            entity.Property(e => e.thumb4).HasComment("썸네일4");
            entity.Property(e => e.thumb5).HasComment("썸네일5");
            entity.Property(e => e.user_id).HasComment("users.id");
        });

        modelBuilder.Entity<user_attache>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("(사용안함)"));

            entity.Property(e => e.origin).HasComment("원본파일");
            entity.Property(e => e.thumbnail).HasComment("썸네일파일");
            entity.Property(e => e.type).HasComment("I: 이미지, F: 파일");
            entity.Property(e => e.user_id).HasComment("유저 아이디");
        });

        modelBuilder.Entity<users>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("사용자관리"));

            entity.Property(e => e.addr1).HasComment("주소1");
            entity.Property(e => e.addr2).HasComment("주소2");
            entity.Property(e => e.age).HasComment("나이");
            entity.Property(e => e.birthday).HasComment("생일");
            entity.Property(e => e.birthday_type)
                .HasDefaultValueSql("'S'")
                .IsFixedLength()
                .HasComment("생일구분");
            entity.Property(e => e.chk_mail)
                .HasDefaultValueSql("'Y'")
                .IsFixedLength()
                .HasComment("이메일 수신동의여부");
            entity.Property(e => e.chk_sms)
                .HasDefaultValueSql("'Y'")
                .IsFixedLength()
                .HasComment("SMS 수신동의여부");
            entity.Property(e => e.conninfo).HasComment("고유번호");
            entity.Property(e => e.dupinfo).HasComment("중복가입확인번호");
            entity.Property(e => e.email).HasComment("이메일");
            entity.Property(e => e.event_date)
                .HasDefaultValueSql("''")
                .HasComment("회원가입 예상 예식일자");
            entity.Property(e => e.gender)
                .IsFixedLength()
                .HasComment("성별 - F: 여자, M: 남자");
            entity.Property(e => e.hall).HasComment("예식장");
            entity.Property(e => e.hall_type)
                .HasDefaultValueSql("'W'")
                .IsFixedLength()
                .HasComment("예식장구분");
            entity.Property(e => e.is_test)
                .HasDefaultValueSql("'F'")
                .IsFixedLength()
                .HasComment("테스트 계정");
            entity.Property(e => e.join_channel).HasComment("가입채널");
            entity.Property(e => e.last_login).HasComment("최종로그인");
            entity.Property(e => e.name).HasComment("이름");
            entity.Property(e => e.partner_planner).HasComment("제휴사 플래너명");
            entity.Property(e => e.partner_shop_id).HasComment("제휴사 id");
            entity.Property(e => e.password).HasComment("비밀번호");
            entity.Property(e => e.phone).HasComment("휴대전화");
            entity.Property(e => e.post).HasComment("우편번호");
            entity.Property(e => e.social_key).HasComment("소셜 로그인 아이디");
            entity.Property(e => e.tel).HasComment("전화번호");
            entity.Property(e => e.user_id).HasComment("아이디");
        });

        modelBuilder.Entity<users_leave_log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("회원탈퇴로그"));

            entity.Property(e => e.created_at).HasComment("등록일시");
            entity.Property(e => e.id).HasComment("ID");
            entity.Property(e => e.user_id).HasComment("회원ID");
        });

        modelBuilder.Entity<users_roles>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("유저-권한 릴레이션"));

            entity.HasOne(d => d.role).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_roles_role_id_foreign");

            entity.HasOne(d => d.user).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_roles_user_id_foreign");
        });

        modelBuilder.Entity<video_templates>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("영상템플릿(사용안함)"));

            entity.Property(e => e.code).HasComment("상품고유코드");
            entity.Property(e => e.contents).HasComment("상품상세 설명");
            entity.Property(e => e.moboil_contents).HasComment("모바일 상품상세 설명");
            entity.Property(e => e.name).HasComment("상품명");
            entity.Property(e => e.owner_id).HasComment("상품 번호");
            entity.Property(e => e.represent_image).HasComment("대표이미지");
            entity.Property(e => e.summary).HasComment("상품 간단 설명");
            entity.Property(e => e.updater_id).HasComment("상품 번호");
            entity.Property(e => e.video_label).HasComment("상품 속성 라벨");
        });

        modelBuilder.Entity<wedd_map>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("약도관리"));

            entity.Property(e => e.is_convert_error).HasComment("COREL TO AI 변환 에러 , 0: 정상, 1:에러");
            entity.Property(e => e.is_popular).HasComment("인기쟁이");
            entity.Property(e => e.wedd_addr1).HasComment("주소1 지번주소");
            entity.Property(e => e.wedd_addr2).HasComment("주소2 도로명주소");
            entity.Property(e => e.wedd_name).HasComment("예식장 이름");
            entity.Property(e => e.wedd_phone).HasComment("주소2 도로명주소");
            entity.Property(e => e.wedd_prev).HasComment("파일명");
        });

        modelBuilder.Entity<wedd_map_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("약도 상세"));

            entity.Property(e => e.item_desc).HasComment("예식장 설명");
            entity.Property(e => e.item_height).HasComment("지도 세로크기");
            entity.Property(e => e.item_indd).HasComment("예식장 지도 INDD");
            entity.Property(e => e.item_png).HasComment("예식장 지도 PNG");
            entity.Property(e => e.item_width).HasComment("지도 가로크기");
            entity.Property(e => e.road_name1).HasComment("교통편1");
            entity.Property(e => e.road_name2).HasComment("교통편2");
            entity.Property(e => e.road_name3).HasComment("교통편3");
            entity.Property(e => e.road_name4).HasComment("교통편4");
            entity.Property(e => e.road_name5).HasComment("교통편5");
            entity.Property(e => e.road_value1).HasComment("교통편1 상세");
            entity.Property(e => e.road_value2).HasComment("교통편2 상세");
            entity.Property(e => e.road_value3).HasComment("교통편3 상세");
            entity.Property(e => e.road_value4).HasComment("교통편4 상세");
            entity.Property(e => e.road_value5).HasComment("교통편5 상세");
            entity.Property(e => e.wedd_map_id).HasComment("wedd_map.id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Barunson.DbContext.DbModels.BarShop;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext;

public partial class BarShopContext : Microsoft.EntityFrameworkCore.DbContext
{
    public BarShopContext(DbContextOptions<BarShopContext> options)
       : base(options)
    {
    }

    public virtual DbSet<ADMIN_CONNECT> ADMIN_CONNECT { get; set; }

    public virtual DbSet<ADMIN_DISPLAY_UPDATE_LOG> ADMIN_DISPLAY_UPDATE_LOG { get; set; }

    public virtual DbSet<ADMIN_LIMIT_SETTING> ADMIN_LIMIT_SETTING { get; set; }

    public virtual DbSet<ADMIN_LIMIT_SETTING_LOG> ADMIN_LIMIT_SETTING_LOG { get; set; }

    public virtual DbSet<ADMIN_LST> ADMIN_LST { get; set; }

    public virtual DbSet<ADMIN_PRICE_LOGINFO> ADMIN_PRICE_LOGINFO { get; set; }

    public virtual DbSet<APP_VERSION_MST> APP_VERSION_MST { get; set; }

    public virtual DbSet<AUTO_CHOAN_APP_STATUS_LOG> AUTO_CHOAN_APP_STATUS_LOG { get; set; }

    public virtual DbSet<AUTO_CHOAN_LOG> AUTO_CHOAN_LOG { get; set; }

    public virtual DbSet<Admin_LoginIpInfo> Admin_LoginIpInfo { get; set; }

    public virtual DbSet<Admin_Menu> Admin_Menu { get; set; }

    public virtual DbSet<AgaBarunson_Member> AgaBarunson_Member { get; set; }

    public virtual DbSet<AliveCheck> AliveCheck { get; set; }

    public virtual DbSet<AliveCheck_Info> AliveCheck_Info { get; set; }

    public virtual DbSet<Authorization_SMS> Authorization_SMS { get; set; }

    public virtual DbSet<BANNER_MST> BANNER_MST { get; set; }

    public virtual DbSet<BARUNN_INTEGRATE_USER_CHANGE_PROGRESS_LOG> BARUNN_INTEGRATE_USER_CHANGE_PROGRESS_LOG { get; set; }

    public virtual DbSet<BBarunson_Config> BBarunson_Config { get; set; }

    public virtual DbSet<BC_Career> BC_Career { get; set; }

    public virtual DbSet<BC_CareerContent> BC_CareerContent { get; set; }

    public virtual DbSet<BEAUTYBOX_ITEM_MST> BEAUTYBOX_ITEM_MST { get; set; }

    public virtual DbSet<BENEFIT_BANNER> BENEFIT_BANNER { get; set; }

    public virtual DbSet<BEWEDDING_CONTENT> BEWEDDING_CONTENT { get; set; }

    public virtual DbSet<BEWEDDING_CONTENT_IMAGE> BEWEDDING_CONTENT_IMAGE { get; set; }

    public virtual DbSet<BEWEDDING_NAVIGATION> BEWEDDING_NAVIGATION { get; set; }

    public virtual DbSet<BEWEDDING_SOURCE> BEWEDDING_SOURCE { get; set; }

    public virtual DbSet<BEWEDDING_SOURCE_IMAGE> BEWEDDING_SOURCE_IMAGE { get; set; }

    public virtual DbSet<BHANDS_MEMBER_TEMP_TABLE> BHANDS_MEMBER_TEMP_TABLE { get; set; }

    public virtual DbSet<BHANDS_WEEKLY_HOTDEAL> BHANDS_WEEKLY_HOTDEAL { get; set; }

    public virtual DbSet<BRANCH_MEMBER_OUT> BRANCH_MEMBER_OUT { get; set; }

    public virtual DbSet<BRANCH_VISIT_SITE> BRANCH_VISIT_SITE { get; set; }

    public virtual DbSet<BRANCH_WISHMADE_UPDATE> BRANCH_WISHMADE_UPDATE { get; set; }

    public virtual DbSet<BSMALL_MAIN_PRODUCT> BSMALL_MAIN_PRODUCT { get; set; }

    public virtual DbSet<BSTORE_DAILY_MMS> BSTORE_DAILY_MMS { get; set; }

    public virtual DbSet<BarunWorkerLog> BarunWorkerLog { get; set; }

    public virtual DbSet<BarunWorkerTask> BarunWorkerTask { get; set; }

    public virtual DbSet<BestRanking> BestRanking { get; set; }

    public virtual DbSet<BestRankingB2B> BestRankingB2B { get; set; }

    public virtual DbSet<BestRanking_new> BestRanking_new { get; set; }

    public virtual DbSet<Branch_Card_Plan> Branch_Card_Plan { get; set; }

    public virtual DbSet<Branch_Member> Branch_Member { get; set; }

    public virtual DbSet<Branch_QA_Tbl> Branch_QA_Tbl { get; set; }

    public virtual DbSet<Branch_card_discount_Rate> Branch_card_discount_Rate { get; set; }

    public virtual DbSet<Branch_card_discount_season> Branch_card_discount_season { get; set; }

    public virtual DbSet<Branch_card_display> Branch_card_display { get; set; }

    public virtual DbSet<Branch_notice> Branch_notice { get; set; }

    public virtual DbSet<Branch_special_discount_rate> Branch_special_discount_rate { get; set; }

    public virtual DbSet<Branch_user_comment> Branch_user_comment { get; set; }

    public virtual DbSet<CALLCENTER_SIGNAL_LAMP_MST> CALLCENTER_SIGNAL_LAMP_MST { get; set; }

    public virtual DbSet<CARD> CARD { get; set; }

    public virtual DbSet<CARD_BRAND> CARD_BRAND { get; set; }

    public virtual DbSet<CARD_CATE> CARD_CATE { get; set; }

    public virtual DbSet<CARD_CATEGORY> CARD_CATEGORY { get; set; }

    public virtual DbSet<CARD_COREL> CARD_COREL { get; set; }

    public virtual DbSet<CARD_ChoanBasic> CARD_ChoanBasic { get; set; }

    public virtual DbSet<CARD_Cont> CARD_Cont { get; set; }

    public virtual DbSet<CARD_DISCOUNT_RATE> CARD_DISCOUNT_RATE { get; set; }

    public virtual DbSet<CARD_DISCOUNT_RATE_WED> CARD_DISCOUNT_RATE_WED { get; set; }

    public virtual DbSet<CARD_DISPLAY_POLICY> CARD_DISPLAY_POLICY { get; set; }

    public virtual DbSet<CARD_Dev> CARD_Dev { get; set; }

    public virtual DbSet<CARD_ENV> CARD_ENV { get; set; }

    public virtual DbSet<CARD_ISHAVE_HISTORY> CARD_ISHAVE_HISTORY { get; set; }

    public virtual DbSet<CARD_JAEGO> CARD_JAEGO { get; set; }

    public virtual DbSet<CARD_JAEGO_HISTORY> CARD_JAEGO_HISTORY { get; set; }

    public virtual DbSet<CARD_SEASON_IMAGE_STR> CARD_SEASON_IMAGE_STR { get; set; }

    public virtual DbSet<CARD_SEASON_STYLE> CARD_SEASON_STYLE { get; set; }

    public virtual DbSet<CARD_SEASON_STYLEITEM> CARD_SEASON_STYLEITEM { get; set; }

    public virtual DbSet<CARD_SET> CARD_SET { get; set; }

    public virtual DbSet<CARD_SETItem> CARD_SETItem { get; set; }

    public virtual DbSet<CARD_STYLE> CARD_STYLE { get; set; }

    public virtual DbSet<CARD_USER_COMMNET> CARD_USER_COMMNET { get; set; }

    public virtual DbSet<CARD_VSTAT> CARD_VSTAT { get; set; }

    public virtual DbSet<CARD_WEIGHT> CARD_WEIGHT { get; set; }

    public virtual DbSet<CARD_corelinfo> CARD_corelinfo { get; set; }

    public virtual DbSet<CART> CART { get; set; }

    public virtual DbSet<CASAMIA_DAILY_INFO> CASAMIA_DAILY_INFO { get; set; }

    public virtual DbSet<CHG_ENV_log> CHG_ENV_log { get; set; }

    public virtual DbSet<CHOAN_CALENDAR_ITEM> CHOAN_CALENDAR_ITEM { get; set; }

    public virtual DbSet<CHOAN_CORELDRAW_ITEM> CHOAN_CORELDRAW_ITEM { get; set; }

    public virtual DbSet<CHOAN_OBJECT_COMMON_CODE> CHOAN_OBJECT_COMMON_CODE { get; set; }

    public virtual DbSet<CJ_API_LOG> CJ_API_LOG { get; set; }

    public virtual DbSet<CJ_DELCODE> CJ_DELCODE { get; set; }

    public virtual DbSet<CJ_DELCODE_ERROR> CJ_DELCODE_ERROR { get; set; }

    public virtual DbSet<CJ_DELCODE_EXCEPT> CJ_DELCODE_EXCEPT { get; set; }

    public virtual DbSet<CJ_DELCODE_TEMP> CJ_DELCODE_TEMP { get; set; }

    public virtual DbSet<CJ_DELCODE_UPDATE> CJ_DELCODE_UPDATE { get; set; }

    public virtual DbSet<CJ_DELCODE_USAGE_LOG> CJ_DELCODE_USAGE_LOG { get; set; }

    public virtual DbSet<CJ_ONEDAYTOKEN> CJ_ONEDAYTOKEN { get; set; }

    public virtual DbSet<CJ_ZIPCODE> CJ_ZIPCODE { get; set; }

    public virtual DbSet<CMS_Detail_LOG> CMS_Detail_LOG { get; set; }

    public virtual DbSet<CMS_LOG> CMS_LOG { get; set; }

    public virtual DbSet<COMMON_CODE> COMMON_CODE { get; set; }

    public virtual DbSet<COMPANY> COMPANY { get; set; }

    public virtual DbSet<COMPANY_MEMO> COMPANY_MEMO { get; set; }

    public virtual DbSet<COMPANY_Nanum_History> COMPANY_Nanum_History { get; set; }

    public virtual DbSet<COMPANY_Nanum_Price> COMPANY_Nanum_Price { get; set; }

    public virtual DbSet<COMPETITOR_CARD_MST> COMPETITOR_CARD_MST { get; set; }

    public virtual DbSet<CONNECT> CONNECT { get; set; }

    public virtual DbSet<CONNECT_PATH> CONNECT_PATH { get; set; }

    public virtual DbSet<CONTRACT_TBL> CONTRACT_TBL { get; set; }

    public virtual DbSet<COOP_DISCOUNT> COOP_DISCOUNT { get; set; }

    public virtual DbSet<COOP_VSTAT> COOP_VSTAT { get; set; }

    public virtual DbSet<COUPON> COUPON { get; set; }

    public virtual DbSet<COUPON_APPLY_CARD> COUPON_APPLY_CARD { get; set; }

    public virtual DbSet<COUPON_APPLY_SERVICE> COUPON_APPLY_SERVICE { get; set; }

    public virtual DbSet<COUPON_APPLY_SITE> COUPON_APPLY_SITE { get; set; }

    public virtual DbSet<COUPON_APPLY_USER> COUPON_APPLY_USER { get; set; }

    public virtual DbSet<COUPON_DETAIL> COUPON_DETAIL { get; set; }

    public virtual DbSet<COUPON_ISSUE> COUPON_ISSUE { get; set; }

    public virtual DbSet<COUPON_MST> COUPON_MST { get; set; }

    public virtual DbSet<CS_HappyCall> CS_HappyCall { get; set; }

    public virtual DbSet<CUCKOOS_DAILY_INFO> CUCKOOS_DAILY_INFO { get; set; }

    public virtual DbSet<CUCKOOS_DAILY_INFO_CANCEL> CUCKOOS_DAILY_INFO_CANCEL { get; set; }

    public virtual DbSet<CUCKOOS_INBOUND> CUCKOOS_INBOUND { get; set; }

    public virtual DbSet<CUSTOM_CARD_DISPLAY_POLICY> CUSTOM_CARD_DISPLAY_POLICY { get; set; }

    public virtual DbSet<CUSTOM_CART_SP> CUSTOM_CART_SP { get; set; }

    public virtual DbSet<CUSTOM_ETC_ORDER> CUSTOM_ETC_ORDER { get; set; }

    public virtual DbSet<CUSTOM_ETC_ORDER_GIFT_ITEM> CUSTOM_ETC_ORDER_GIFT_ITEM { get; set; }

    public virtual DbSet<CUSTOM_ETC_ORDER_ITEM> CUSTOM_ETC_ORDER_ITEM { get; set; }

    public virtual DbSet<CUSTOM_ETC_ORDER_WeddInfo> CUSTOM_ETC_ORDER_WeddInfo { get; set; }

    public virtual DbSet<CUSTOM_ORDER_ADMIN_MENT> CUSTOM_ORDER_ADMIN_MENT { get; set; }

    public virtual DbSet<CUSTOM_ORDER_CHASU> CUSTOM_ORDER_CHASU { get; set; }

    public virtual DbSet<CUSTOM_ORDER_COPY> CUSTOM_ORDER_COPY { get; set; }

    public virtual DbSet<CUSTOM_ORDER_COPY_DETAIL> CUSTOM_ORDER_COPY_DETAIL { get; set; }

    public virtual DbSet<CUSTOM_ORDER_COPY_PlcCode> CUSTOM_ORDER_COPY_PlcCode { get; set; }

    public virtual DbSet<CUSTOM_ORDER_COUPON> CUSTOM_ORDER_COUPON { get; set; }
    public virtual DbSet<Custom_Order_Review_Count> Custom_Order_Review_Count { get; set; }

    public virtual DbSet<CUSTOM_PRIVATE_CHOICE> CUSTOM_PRIVATE_CHOICE { get; set; }

    public virtual DbSet<CUSTOM_SAMPLE_ORDER> CUSTOM_SAMPLE_ORDER { get; set; }
    public virtual DbSet<Custom_Sample_Order_Statistics> Custom_Sample_Order_Statistics { get; set; }

    public virtual DbSet<CUSTOM_SAMPLE_ORDER_ITEM> CUSTOM_SAMPLE_ORDER_ITEM { get; set; }

    public virtual DbSet<CUSTOM_SAMPLE_ORDER_ITEM_COUNT> CUSTOM_SAMPLE_ORDER_ITEM_COUNT { get; set; }

    public virtual DbSet<CUSTOM_SAMPLE_ORDER_ITEM_deardup> CUSTOM_SAMPLE_ORDER_ITEM_deardup { get; set; }

    public virtual DbSet<CUSTOM_SAMPLE_ORDER_deardup> CUSTOM_SAMPLE_ORDER_deardup { get; set; }

    public virtual DbSet<Callcenter_Log> Callcenter_Log { get; set; }

    public virtual DbSet<CardRanking> CardRanking { get; set; }

    public virtual DbSet<Card_Disrate_View> Card_Disrate_View { get; set; }

    public virtual DbSet<Card_News> Card_News { get; set; }

    public virtual DbSet<Card_News_TEMP> Card_News_TEMP { get; set; }

    public virtual DbSet<Category_Manage> Category_Manage { get; set; }

    public virtual DbSet<Category_Manage_Plus> Category_Manage_Plus { get; set; }

    public virtual DbSet<CopperPlateExclude> CopperPlateExclude { get; set; }

    public virtual DbSet<CopperPlateInfo> CopperPlateInfo { get; set; }

    public virtual DbSet<Custom_etc_basket> Custom_etc_basket { get; set; }

    public virtual DbSet<Custom_order_Group> Custom_order_Group { get; set; }

    public virtual DbSet<Custom_order_Group_backup> Custom_order_Group_backup { get; set; }

    public virtual DbSet<Custom_order_item_backup> Custom_order_item_backup { get; set; }

    public virtual DbSet<DACOM_PayTBL> DACOM_PayTBL { get; set; }

    public virtual DbSet<DD_BANLIST> DD_BANLIST { get; set; }

    public virtual DbSet<DD_JEHU_LINK> DD_JEHU_LINK { get; set; }

    public virtual DbSet<DEARDEER_JEHU> DEARDEER_JEHU { get; set; }

    public virtual DbSet<DEARDEER_SAMPLE_ORDER_ITEM> DEARDEER_SAMPLE_ORDER_ITEM { get; set; }

    public virtual DbSet<DEARDEER_SAMPLE_ORDER_MST> DEARDEER_SAMPLE_ORDER_MST { get; set; }

    public virtual DbSet<DELIVERY_CODE> DELIVERY_CODE { get; set; }

    public virtual DbSet<DELIVERY_CODE_TEST> DELIVERY_CODE_TEST { get; set; }

    public virtual DbSet<DELIVERY_INFO> DELIVERY_INFO { get; set; }

    public virtual DbSet<DELIVERY_INFO_DELCODE> DELIVERY_INFO_DELCODE { get; set; }

    public virtual DbSet<DELIVERY_INFO_DETAIL> DELIVERY_INFO_DETAIL { get; set; }

    public virtual DbSet<DELIVERY_INFO_GROUP> DELIVERY_INFO_GROUP { get; set; }

    public virtual DbSet<DELIVERY_REG_LOG> DELIVERY_REG_LOG { get; set; }

    public virtual DbSet<DELIVERY_SEND_LOG> DELIVERY_SEND_LOG { get; set; }

    public virtual DbSet<DELIVERY_STOP_ZIPCODE> DELIVERY_STOP_ZIPCODE { get; set; }

    public virtual DbSet<DISCOUNT_POLICY> DISCOUNT_POLICY { get; set; }

    public virtual DbSet<DISPLAY_CATEGORY> DISPLAY_CATEGORY { get; set; }

    public virtual DbSet<tbDatabase> tbDatabase { get; set; }

    public virtual DbSet<DatabaseChangeHistory> DatabaseChangeHistory { get; set; }

    public virtual DbSet<DeliveryPriceInfo> DeliveryPriceInfo { get; set; }

    public virtual DbSet<Delivery_Price_Info> Delivery_Price_Info { get; set; }

    public virtual DbSet<DesignBettle> DesignBettle { get; set; }

    public virtual DbSet<Designer> Designer { get; set; }

    public virtual DbSet<Discount_Delete_Admin_Log> Discount_Delete_Admin_Log { get; set; }

    public virtual DbSet<Discount_Paper> Discount_Paper { get; set; }

    public virtual DbSet<Drop_Invo_Order_Seq> Drop_Invo_Order_Seq { get; set; }

    public virtual DbSet<ENV_SIZE> ENV_SIZE { get; set; }

    public virtual DbSet<ERP_Price> ERP_Price { get; set; }

    public virtual DbSet<ERR_TBL> ERR_TBL { get; set; }

    public virtual DbSet<ESTIMATE_REQUEST> ESTIMATE_REQUEST { get; set; }

    public virtual DbSet<EVENT_5hang> EVENT_5hang { get; set; }

    public virtual DbSet<EVENT_5hang_str> EVENT_5hang_str { get; set; }

    public virtual DbSet<EVENT_DELIVERY_INFO> EVENT_DELIVERY_INFO { get; set; }

    public virtual DbSet<EVENT_DigitalPhoto> EVENT_DigitalPhoto { get; set; }

    public virtual DbSet<EVENT_ENTER_MEMBER> EVENT_ENTER_MEMBER { get; set; }

    public virtual DbSet<EVENT_ETLAND> EVENT_ETLAND { get; set; }

    public virtual DbSet<EVENT_FACEBOOKSHARE> EVENT_FACEBOOKSHARE { get; set; }

    public virtual DbSet<EVENT_GIFT> EVENT_GIFT { get; set; }

    public virtual DbSet<EVENT_LMS_CONTENT> EVENT_LMS_CONTENT { get; set; }

    public virtual DbSet<EVENT_MARKETING_AGREEMENT> EVENT_MARKETING_AGREEMENT { get; set; }

    public virtual DbSet<EVENT_MMS_LOG> EVENT_MMS_LOG { get; set; }

    public virtual DbSet<EVENT_SAMSUNG> EVENT_SAMSUNG { get; set; }

    public virtual DbSet<EVENT_talklove> EVENT_talklove { get; set; }

    public virtual DbSet<EVTPAGE_MARKETING_AGREEMENT_LOG> EVTPAGE_MARKETING_AGREEMENT_LOG { get; set; }

    public virtual DbSet<EVT_BHANDS_COUPLES> EVT_BHANDS_COUPLES { get; set; }

    public virtual DbSet<EVT_BHANDS_COUPLES_VOTE> EVT_BHANDS_COUPLES_VOTE { get; set; }

    public virtual DbSet<EVT_GIFT_LIKE> EVT_GIFT_LIKE { get; set; }

    public virtual DbSet<EVT_HOLLOWEEN> EVT_HOLLOWEEN { get; set; }

    public virtual DbSet<EVT_HOTDEAL_STOCK> EVT_HOTDEAL_STOCK { get; set; }

    public virtual DbSet<EVT_LINK_HIT> EVT_LINK_HIT { get; set; }

    public virtual DbSet<EVT_WEDDINGBOX> EVT_WEDDINGBOX { get; set; }

    public virtual DbSet<Error_User> Error_User { get; set; }

    public virtual DbSet<EveCard_Order_Info> EveCard_Order_Info { get; set; }

    public virtual DbSet<EveCard_Prd_Info> EveCard_Prd_Info { get; set; }

    public virtual DbSet<Event_View_Log> Event_View_Log { get; set; }

    public virtual DbSet<EverydayCard> EverydayCard { get; set; }

    public virtual DbSet<Evt_Banner> Evt_Banner { get; set; }

    public virtual DbSet<Evt_Plus_Friends> Evt_Plus_Friends { get; set; }

    public virtual DbSet<Evt_Plus_Friends_uid> Evt_Plus_Friends_uid { get; set; }

    public virtual DbSet<Evt_three_six_nine_board> Evt_three_six_nine_board { get; set; }

    public virtual DbSet<Ewedd_After_Note> Ewedd_After_Note { get; set; }

    public virtual DbSet<GIFT_DAILY_MMS> GIFT_DAILY_MMS { get; set; }

    public virtual DbSet<GREETING> GREETING { get; set; }

    public virtual DbSet<GREETING_CATEGORY> GREETING_CATEGORY { get; set; }

    public virtual DbSet<Greeting_barshop> Greeting_barshop { get; set; }

    public virtual DbSet<HANJIN_ZIPCODE> HANJIN_ZIPCODE { get; set; }

    public virtual DbSet<HYUNDAI_DAILY_INFO> HYUNDAI_DAILY_INFO { get; set; }

    public virtual DbSet<HYUNDAI_DAILY_INFO_CANCEL> HYUNDAI_DAILY_INFO_CANCEL { get; set; }

    public virtual DbSet<HardCodingList> HardCodingList { get; set; }

    public virtual DbSet<HeadCol_TEMP> HeadCol_TEMP { get; set; }

    public virtual DbSet<ILOOM_DAILY_INFO> ILOOM_DAILY_INFO { get; set; }

    public virtual DbSet<INTEGRATION_ADMIN_MENU> INTEGRATION_ADMIN_MENU { get; set; }

    public virtual DbSet<INTEGRATION_ADMIN_MENU_AUTH> INTEGRATION_ADMIN_MENU_AUTH { get; set; }

    public virtual DbSet<INTEGRATION_MEMBER_SIGN_UP_LOG> INTEGRATION_MEMBER_SIGN_UP_LOG { get; set; }

    public virtual DbSet<JEHU_COUPONBOX_ISSUE> JEHU_COUPONBOX_ISSUE { get; set; }

    public virtual DbSet<JEHU_MARKETING_DAILY_INFO> JEHU_MARKETING_DAILY_INFO { get; set; }

    public virtual DbSet<KT_DAILY_INFO> KT_DAILY_INFO { get; set; }

    public virtual DbSet<KT_DAILY_INFO_CANCEL> KT_DAILY_INFO_CANCEL { get; set; }

    public virtual DbSet<LMS_SEND_TARGET_GROUP> LMS_SEND_TARGET_GROUP { get; set; }

    public virtual DbSet<LMS_SEND_TARGET_USER> LMS_SEND_TARGET_USER { get; set; }

    public virtual DbSet<LOGO_CATEGORY> LOGO_CATEGORY { get; set; }

    public virtual DbSet<LOG_AGENT_CHECK> LOG_AGENT_CHECK { get; set; }

    public virtual DbSet<LOG_MST> LOG_MST { get; set; }

    public virtual DbSet<LT_DELCODE> LT_DELCODE { get; set; }

    public virtual DbSet<LT_DELCODE_USAGE_LOG> LT_DELCODE_USAGE_LOG { get; set; }

    public virtual DbSet<LT_ZIPCODE> LT_ZIPCODE { get; set; }

    public virtual DbSet<Logo_TBL> Logo_TBL { get; set; }

    public virtual DbSet<MAIN_POPUP_IMAGE> MAIN_POPUP_IMAGE { get; set; }

    public virtual DbSet<MAIN_POPUP_MST> MAIN_POPUP_MST { get; set; }

    public virtual DbSet<MARKET_PRICE> MARKET_PRICE { get; set; }

    public virtual DbSet<MCARD_IMAGE_DELETE> MCARD_IMAGE_DELETE { get; set; }

    public virtual DbSet<MCARD_INVITATION_FLOW> MCARD_INVITATION_FLOW { get; set; }

    public virtual DbSet<MCARD_INVITATION_FOR_OTHER_SITE> MCARD_INVITATION_FOR_OTHER_SITE { get; set; }

    public virtual DbSet<MD_GIFT_EVENT_CHANEL> MD_GIFT_EVENT_CHANEL { get; set; }

    public virtual DbSet<MEMPLUS_DAILY_INFO> MEMPLUS_DAILY_INFO { get; set; }

    public virtual DbSet<MEMPLUS_DAILY_INFO_CANCEL> MEMPLUS_DAILY_INFO_CANCEL { get; set; }

    public virtual DbSet<MMS_LOG> MMS_LOG { get; set; }

    public virtual DbSet<MMS_MSG> MMS_MSG { get; set; }

    public virtual DbSet<MMS_TARGET_CUSTOMER> MMS_TARGET_CUSTOMER { get; set; }

    public virtual DbSet<MO_MAP> MO_MAP { get; set; }

    public virtual DbSet<MO_TRAN> MO_TRAN { get; set; }

    public virtual DbSet<MYOMEE_DAILY_INFO> MYOMEE_DAILY_INFO { get; set; }

    public virtual DbSet<Mcard_MoneyGift> Mcard_MoneyGift { get; set; }

    public virtual DbSet<NAVER_MAINADD_MOBILE> NAVER_MAINADD_MOBILE { get; set; }

    public virtual DbSet<OB_CATALOGUE> OB_CATALOGUE { get; set; }

    public virtual DbSet<OB_MD_ITEM> OB_MD_ITEM { get; set; }

    public virtual DbSet<OB_NOTICE_T> OB_NOTICE_T { get; set; }

    public virtual DbSet<OB_REF_CODE> OB_REF_CODE { get; set; }

    public virtual DbSet<ORDER_DETAIL_CHANGE> ORDER_DETAIL_CHANGE { get; set; }

    public virtual DbSet<OUTLET_CARD> OUTLET_CARD { get; set; }

    public virtual DbSet<OUTLET_ORDER> OUTLET_ORDER { get; set; }

    public virtual DbSet<OUTSOURCING_ORDER_MST> OUTSOURCING_ORDER_MST { get; set; }

    public virtual DbSet<OUTSOURCING_ORDER_MST_BACK_DATA> OUTSOURCING_ORDER_MST_BACK_DATA { get; set; }

    public virtual DbSet<PHOTOBOOK_ADMIN_MENT> PHOTOBOOK_ADMIN_MENT { get; set; }

    public virtual DbSet<PHOTOBOOK_BASKET> PHOTOBOOK_BASKET { get; set; }

    public virtual DbSet<PHOTOBOOK_BOARD_RE> PHOTOBOOK_BOARD_RE { get; set; }

    public virtual DbSet<PHOTOBOOK_COMMENT> PHOTOBOOK_COMMENT { get; set; }

    public virtual DbSet<PHOTOBOOK_COUPON> PHOTOBOOK_COUPON { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_BLOG> PHOTOBOOK_EVENT_BLOG { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_COUPON> PHOTOBOOK_EVENT_COUPON { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_PHOTOCLIP> PHOTOBOOK_EVENT_PHOTOCLIP { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_PHOTOCLIP_REPLY> PHOTOBOOK_EVENT_PHOTOCLIP_REPLY { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_REMIND> PHOTOBOOK_EVENT_REMIND { get; set; }

    public virtual DbSet<PHOTOBOOK_EVENT_REPLY> PHOTOBOOK_EVENT_REPLY { get; set; }

    public virtual DbSet<PHOTOBOOK_FAQ> PHOTOBOOK_FAQ { get; set; }

    public virtual DbSet<PHOTOBOOK_MEMBER> PHOTOBOOK_MEMBER { get; set; }

    public virtual DbSet<PHOTOBOOK_MEMBER_OUT> PHOTOBOOK_MEMBER_OUT { get; set; }

    public virtual DbSet<PHOTOBOOK_MEMBER_tmp> PHOTOBOOK_MEMBER_tmp { get; set; }

    public virtual DbSet<PHOTOBOOK_MYCOUPON> PHOTOBOOK_MYCOUPON { get; set; }

    public virtual DbSet<PHOTOBOOK_OPEN> PHOTOBOOK_OPEN { get; set; }

    public virtual DbSet<PHOTOBOOK_ORDER> PHOTOBOOK_ORDER { get; set; }

    public virtual DbSet<PHOTOBOOK_ORDER_DETAIL> PHOTOBOOK_ORDER_DETAIL { get; set; }

    public virtual DbSet<PHOTOBOOK_POINT> PHOTOBOOK_POINT { get; set; }

    public virtual DbSet<PHOTOBOOK_PROD> PHOTOBOOK_PROD { get; set; }

    public virtual DbSet<PHOTOBOOK_PROD_B2B> PHOTOBOOK_PROD_B2B { get; set; }

    public virtual DbSet<PHOTOBOOK_PROD_DETAIL> PHOTOBOOK_PROD_DETAIL { get; set; }

    public virtual DbSet<PHOTOBOOK_PROD_ERP> PHOTOBOOK_PROD_ERP { get; set; }

    public virtual DbSet<PHOTOBOOK_PROD_OPTION> PHOTOBOOK_PROD_OPTION { get; set; }

    public virtual DbSet<PHOTOBOOK_SKIN> PHOTOBOOK_SKIN { get; set; }

    public virtual DbSet<PHOTOBOOK_TROUBLE> PHOTOBOOK_TROUBLE { get; set; }

    public virtual DbSet<PHOTOBOOK_ZZIM> PHOTOBOOK_ZZIM { get; set; }

    public virtual DbSet<POLLCONTENT> POLLCONTENT { get; set; }

    public virtual DbSet<POLLCOUNT> POLLCOUNT { get; set; }

    public virtual DbSet<PREVIEW> PREVIEW { get; set; }

    public virtual DbSet<PREVIEW_NOTICE> PREVIEW_NOTICE { get; set; }

    public virtual DbSet<PREVIEW_OPINION> PREVIEW_OPINION { get; set; }

    public virtual DbSet<PRE_CARD_INFO> PRE_CARD_INFO { get; set; }

    public virtual DbSet<PRIVATE_CHOICE> PRIVATE_CHOICE { get; set; }

    public virtual DbSet<PartnerClient> PartnerClient { get; set; }

    public virtual DbSet<PartnerClientToken> PartnerClientToken { get; set; }

    public virtual DbSet<PrintChasuGroup> PrintChasuGroup { get; set; }

    public virtual DbSet<PrintChasuGroupDetail> PrintChasuGroupDetail { get; set; }

    public virtual DbSet<RECENT_VIEW_CARD_ITEM> RECENT_VIEW_CARD_ITEM { get; set; }

    public virtual DbSet<RECENT_VIEW_CARD_MST> RECENT_VIEW_CARD_MST { get; set; }

    public virtual DbSet<RESEARCH_ANS> RESEARCH_ANS { get; set; }

    public virtual DbSet<RESEARCH_CARD> RESEARCH_CARD { get; set; }

    public virtual DbSet<RESEARCH_QLIST> RESEARCH_QLIST { get; set; }

    public virtual DbSet<Roulette_Item> Roulette_Item { get; set; }

    public virtual DbSet<Roulette_Main> Roulette_Main { get; set; }

    public virtual DbSet<Roulette_Member> Roulette_Member { get; set; }

    public virtual DbSet<Roulette_ST> Roulette_ST { get; set; }

    public virtual DbSet<S2_Acc> S2_Acc { get; set; }

    public virtual DbSet<S2_Accgr> S2_Accgr { get; set; }

    public virtual DbSet<S2_AdminList> S2_AdminList { get; set; }

    public virtual DbSet<S2_BestTotalRanking> S2_BestTotalRanking { get; set; }

    public virtual DbSet<S2_CARD_ERP_STOCK> S2_CARD_ERP_STOCK { get; set; }

    public virtual DbSet<S2_CARD_ERP_STOCK_DEARDEER> S2_CARD_ERP_STOCK_DEARDEER { get; set; }

    public virtual DbSet<S2_CARD_FREE_FOOD_TICKET_MST> S2_CARD_FREE_FOOD_TICKET_MST { get; set; }

    public virtual DbSet<S2_CARD_FREE_FOOD_TICKET_MST_TEST> S2_CARD_FREE_FOOD_TICKET_MST_TEST { get; set; }

    public virtual DbSet<S2_CARD_FREE_GIFT> S2_CARD_FREE_GIFT { get; set; }

    public virtual DbSet<S2_CARD_FREE_GIFT_LOG> S2_CARD_FREE_GIFT_LOG { get; set; }

    public virtual DbSet<S2_CARD_FREE_GIFT_TARGET_CARD> S2_CARD_FREE_GIFT_TARGET_CARD { get; set; }

    public virtual DbSet<S2_CARD_LIKE> S2_CARD_LIKE { get; set; }

    public virtual DbSet<S2_CARD_SAMPLE_FREE_GIFT> S2_CARD_SAMPLE_FREE_GIFT { get; set; }

    public virtual DbSet<S2_Card> S2_Card { get; set; }

    public virtual DbSet<S2_CardCorelTemplateInfo> S2_CardCorelTemplateInfo { get; set; }

    public virtual DbSet<S2_CardDesigner> S2_CardDesigner { get; set; }

    public virtual DbSet<S2_CardDetail> S2_CardDetail { get; set; }

    public virtual DbSet<S2_CardDetailEtc> S2_CardDetailEtc { get; set; }

    public virtual DbSet<S2_CardDetailSmart> S2_CardDetailSmart { get; set; }

    public virtual DbSet<S2_CardDigitalColor> S2_CardDigitalColor { get; set; }

    public virtual DbSet<S2_CardDiscount> S2_CardDiscount { get; set; }

    public virtual DbSet<S2_CardDiscountInfo> S2_CardDiscountInfo { get; set; }

    public virtual DbSet<S2_CardImage> S2_CardImage { get; set; }

    public virtual DbSet<S2_CardInReferer> S2_CardInReferer { get; set; }

    public virtual DbSet<S2_CardItemGroup> S2_CardItemGroup { get; set; }

    public virtual DbSet<S2_CardItemGroupInfo> S2_CardItemGroupInfo { get; set; }

    public virtual DbSet<S2_CardKind> S2_CardKind { get; set; }

    public virtual DbSet<S2_CardKindInfo> S2_CardKindInfo { get; set; }

    public virtual DbSet<S2_CardOption> S2_CardOption { get; set; }

    public virtual DbSet<S2_CardOption_UsrImg> S2_CardOption_UsrImg { get; set; }

    public virtual DbSet<S2_CardPrintInfo> S2_CardPrintInfo { get; set; }

    public virtual DbSet<S2_CardRank> S2_CardRank { get; set; }

    public virtual DbSet<S2_CardSalesBest> S2_CardSalesBest { get; set; }

    public virtual DbSet<S2_CardSalesPrice> S2_CardSalesPrice { get; set; }

    public virtual DbSet<S2_CardSalesSite> S2_CardSalesSite { get; set; }

    public virtual DbSet<S2_CardSalesSite_backup> S2_CardSalesSite_backup { get; set; }

    public virtual DbSet<S2_CardSamplePrice> S2_CardSamplePrice { get; set; }

    public virtual DbSet<S2_CardSet_PriceTemp> S2_CardSet_PriceTemp { get; set; }

    public virtual DbSet<S2_CardSite> S2_CardSite { get; set; }

    public virtual DbSet<S2_CardSort> S2_CardSort { get; set; }

    public virtual DbSet<S2_CardStyle> S2_CardStyle { get; set; }

    public virtual DbSet<S2_CardStyleItem> S2_CardStyleItem { get; set; }

    public virtual DbSet<S2_CardTechnic> S2_CardTechnic { get; set; }

    public virtual DbSet<S2_CardView> S2_CardView { get; set; }

    public virtual DbSet<S2_CardViewChasu> S2_CardViewChasu { get; set; }

    public virtual DbSet<S2_CardViewDisplay> S2_CardViewDisplay { get; set; }

    public virtual DbSet<S2_CardViewMerge> S2_CardViewMerge { get; set; }

    public virtual DbSet<S2_CardViewN> S2_CardViewN { get; set; }

    public virtual DbSet<S2_CardViewNew> S2_CardViewNew { get; set; }

    public virtual DbSet<S2_CardViewOption> S2_CardViewOption { get; set; }

    public virtual DbSet<S2_CardViewSMART> S2_CardViewSMART { get; set; }

    public virtual DbSet<S2_CardView_TEST> S2_CardView_TEST { get; set; }

    public virtual DbSet<S2_Card_Detail_Sub> S2_Card_Detail_Sub { get; set; }

    public virtual DbSet<S2_CardxmlData> S2_CardxmlData { get; set; }

    public virtual DbSet<S2_CsPoll> S2_CsPoll { get; set; }

    public virtual DbSet<S2_CsPollAns> S2_CsPollAns { get; set; }

    public virtual DbSet<S2_CsPollAnsDetail> S2_CsPollAnsDetail { get; set; }

    public virtual DbSet<S2_CustomizedCard> S2_CustomizedCard { get; set; }

    public virtual DbSet<S2_Event> S2_Event { get; set; }

    public virtual DbSet<S2_EventAdmin_Log> S2_EventAdmin_Log { get; set; }

    public virtual DbSet<S2_EventBlog> S2_EventBlog { get; set; }

    public virtual DbSet<S2_EventUse> S2_EventUse { get; set; }

    public virtual DbSet<S2_Event_flow> S2_Event_flow { get; set; }

    public virtual DbSet<S2_Event_love> S2_Event_love { get; set; }

    public virtual DbSet<S2_FAQ> S2_FAQ { get; set; }

    public virtual DbSet<S2_MailDomain> S2_MailDomain { get; set; }

    public virtual DbSet<S2_McardClickCount> S2_McardClickCount { get; set; }

    public virtual DbSet<S2_MediaContents> S2_MediaContents { get; set; }

    public virtual DbSet<S2_MediaView> S2_MediaView { get; set; }

    public virtual DbSet<S2_News> S2_News { get; set; }

    public virtual DbSet<S2_Notice> S2_Notice { get; set; }

    public virtual DbSet<S2_OrderViewMerge> S2_OrderViewMerge { get; set; }

    public virtual DbSet<S2_OrderViewMerge_For_ChasuGroupSet> S2_OrderViewMerge_For_ChasuGroupSet { get; set; }

    public virtual DbSet<S2_OrderViewMerge_For_ChasuGroupSet_Admin> S2_OrderViewMerge_For_ChasuGroupSet_Admin { get; set; }

    public virtual DbSet<S2_OrderViewMerge_New> S2_OrderViewMerge_New { get; set; }

    public virtual DbSet<S2_OrderViewMerge_New_Admin> S2_OrderViewMerge_New_Admin { get; set; }

    public virtual DbSet<S2_PTRequest> S2_PTRequest { get; set; }

    public virtual DbSet<S2_ProductImage> S2_ProductImage { get; set; }

    public virtual DbSet<S2_RecommendCard> S2_RecommendCard { get; set; }

    public virtual DbSet<S2_Report> S2_Report { get; set; }

    public virtual DbSet<S2_SampleBasket> S2_SampleBasket { get; set; }

    public virtual DbSet<S2_Toss_Bank> S2_Toss_Bank { get; set; }

    public virtual DbSet<S2_USERBYE_SECESSION_CAUSE> S2_USERBYE_SECESSION_CAUSE { get; set; }

    public virtual DbSet<S2_USERINFO_AUTH_INFO> S2_USERINFO_AUTH_INFO { get; set; }

    public virtual DbSet<S2_USERINFO_SIGNUP_DEVICE> S2_USERINFO_SIGNUP_DEVICE { get; set; }

    public virtual DbSet<S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT> S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT { get; set; }

    public virtual DbSet<S2_USER_DEVICE_TOKEN> S2_USER_DEVICE_TOKEN { get; set; }

    public virtual DbSet<S2_UserBye> S2_UserBye { get; set; }

    public virtual DbSet<S2_UserCardView> S2_UserCardView { get; set; }

    public virtual DbSet<S2_UserComment> S2_UserComment { get; set; }

    public virtual DbSet<S2_UserCommentBest> S2_UserCommentBest { get; set; }

    public virtual DbSet<S2_UserComment_Copy> S2_UserComment_Copy { get; set; }

    public virtual DbSet<S2_UserComment_ETC_reply> S2_UserComment_ETC_reply { get; set; }

    public virtual DbSet<S2_UserComment_Reply> S2_UserComment_Reply { get; set; }

    public virtual DbSet<S2_UserComment_etc> S2_UserComment_etc { get; set; }

    public virtual DbSet<S2_UserComment_photo> S2_UserComment_photo { get; set; }

    public virtual DbSet<S2_UserComment_photo_the> S2_UserComment_photo_the { get; set; }

    public virtual DbSet<S2_UserInfo> S2_UserInfo { get; set; }

    public virtual DbSet<S2_UserInfo_BHands> S2_UserInfo_BHands { get; set; }

    public virtual DbSet<S2_UserInfo_Deardeer> S2_UserInfo_Deardeer { get; set; }

    public virtual DbSet<S2_UserInfo_Deardeer_Marketing> S2_UserInfo_Deardeer_Marketing { get; set; }

    public virtual DbSet<S2_UserInfo_Deardeer_Marketing_View> S2_UserInfo_Deardeer_Marketing_View { get; set; }

    public virtual DbSet<S2_UserInfo_Jehu> S2_UserInfo_Jehu { get; set; }

    public virtual DbSet<S2_UserInfo_TheCard> S2_UserInfo_TheCard { get; set; }

    public virtual DbSet<S2_UserQnA> S2_UserQnA { get; set; }

    public virtual DbSet<S2_UserQnA_Boton> S2_UserQnA_Boton { get; set; }

    public virtual DbSet<S2_Userinfo_HiPlaza_Log> S2_Userinfo_HiPlaza_Log { get; set; }

    public virtual DbSet<S2_Userinfo_HiPlaza_store> S2_Userinfo_HiPlaza_store { get; set; }

    public virtual DbSet<S2_Userinfo_HiPlaza_zipcode> S2_Userinfo_HiPlaza_zipcode { get; set; }

    public virtual DbSet<S2_UsrBasket> S2_UsrBasket { get; set; }

    public virtual DbSet<S2_WishCard> S2_WishCard { get; set; }

    public virtual DbSet<S2_WishGreeting> S2_WishGreeting { get; set; }

    public virtual DbSet<S2_WishMap> S2_WishMap { get; set; }

    public virtual DbSet<S2_eCardBest> S2_eCardBest { get; set; }

    public virtual DbSet<S2_eCardBoard> S2_eCardBoard { get; set; }

    public virtual DbSet<S2_eCardOrder> S2_eCardOrder { get; set; }

    public virtual DbSet<S2_mCardOrder> S2_mCardOrder { get; set; }

    public virtual DbSet<S2_media> S2_media { get; set; }

    public virtual DbSet<S2_orderLst> S2_orderLst { get; set; }

    public virtual DbSet<S2_orderLstN> S2_orderLstN { get; set; }

    public virtual DbSet<S2_orderLstN_> S2_orderLstN_ { get; set; }

    public virtual DbSet<S2_orderLstN_20201113> S2_orderLstN_20201113 { get; set; }

    public virtual DbSet<S2_price_code> S2_price_code { get; set; }

    public virtual DbSet<S2_price_tb_code> S2_price_tb_code { get; set; }

    public virtual DbSet<S2_product> S2_product { get; set; }

    public virtual DbSet<S2_search_result> S2_search_result { get; set; }

    public virtual DbSet<S4_BHANDS_EVENT_BANNER> S4_BHANDS_EVENT_BANNER { get; set; }

    public virtual DbSet<S4_BestTotalRanking_BHands> S4_BestTotalRanking_BHands { get; set; }

    public virtual DbSet<S4_BestTotalRanking_BSmall> S4_BestTotalRanking_BSmall { get; set; }

    public virtual DbSet<S4_BestTotalRanking_Barunson> S4_BestTotalRanking_Barunson { get; set; }

    public virtual DbSet<S4_BestTotalRanking_Premier> S4_BestTotalRanking_Premier { get; set; }

    public virtual DbSet<S4_BestTotalRanking_TheCard> S4_BestTotalRanking_TheCard { get; set; }

    public virtual DbSet<S4_CART> S4_CART { get; set; }

    public virtual DbSet<S4_COUPON> S4_COUPON { get; set; }

    public virtual DbSet<S4_COUPON_ADDON_CARD_SEQ> S4_COUPON_ADDON_CARD_SEQ { get; set; }

    public virtual DbSet<S4_COUPON_GURIM> S4_COUPON_GURIM { get; set; }

    public virtual DbSet<S4_COUPON_WEEKLY_SPECIAL> S4_COUPON_WEEKLY_SPECIAL { get; set; }

    public virtual DbSet<S4_CPC_Statics> S4_CPC_Statics { get; set; }

    public virtual DbSet<S4_CPC_Sub_Statics> S4_CPC_Sub_Statics { get; set; }

    public virtual DbSet<S4_CS_Member> S4_CS_Member { get; set; }

    public virtual DbSet<S4_CardClickCount> S4_CardClickCount { get; set; }

    public virtual DbSet<S4_CardImage_Str> S4_CardImage_Str { get; set; }

    public virtual DbSet<S4_Card_Talk> S4_Card_Talk { get; set; }

    public virtual DbSet<S4_Change_intra_id> S4_Change_intra_id { get; set; }

    public virtual DbSet<S4_Coupon_OKC> S4_Coupon_OKC { get; set; }

    public virtual DbSet<S4_EVENT_MUSIC_REPLY_PARENT_WEDDING_EVENT> S4_EVENT_MUSIC_REPLY_PARENT_WEDDING_EVENT { get; set; }

    public virtual DbSet<S4_EventBlog> S4_EventBlog { get; set; }

    public virtual DbSet<S4_EventBlog_Gifticon> S4_EventBlog_Gifticon { get; set; }

    public virtual DbSet<S4_EventManager> S4_EventManager { get; set; }

    public virtual DbSet<S4_EventManagerComment> S4_EventManagerComment { get; set; }

    public virtual DbSet<S4_EventMusic_Reply> S4_EventMusic_Reply { get; set; }

    public virtual DbSet<S4_EventMusic_Str> S4_EventMusic_Str { get; set; }

    public virtual DbSet<S4_EventMusic_Str_Temp> S4_EventMusic_Str_Temp { get; set; }

    public virtual DbSet<S4_EventOnliving> S4_EventOnliving { get; set; }

    public virtual DbSet<S4_EventOnliving_Count> S4_EventOnliving_Count { get; set; }

    public virtual DbSet<S4_EventOnliving_Reply> S4_EventOnliving_Reply { get; set; }

    public virtual DbSet<S4_EventPoll> S4_EventPoll { get; set; }

    public virtual DbSet<S4_EventPoll_item> S4_EventPoll_item { get; set; }

    public virtual DbSet<S4_EventPoll_item_etc> S4_EventPoll_item_etc { get; set; }

    public virtual DbSet<S4_EventRelay> S4_EventRelay { get; set; }

    public virtual DbSet<S4_EventRelay_Reply> S4_EventRelay_Reply { get; set; }

    public virtual DbSet<S4_Event_Blank_Keyword> S4_Event_Blank_Keyword { get; set; }

    public virtual DbSet<S4_Event_Halloween> S4_Event_Halloween { get; set; }

    public virtual DbSet<S4_Event_Raina> S4_Event_Raina { get; set; }

    public virtual DbSet<S4_Event_Review> S4_Event_Review { get; set; }

    public virtual DbSet<S4_Event_ReviewBest> S4_Event_ReviewBest { get; set; }

    public virtual DbSet<S4_Event_Review_New> S4_Event_Review_New { get; set; }

    public virtual DbSet<S4_Event_Review_Status> S4_Event_Review_Status { get; set; }

    public virtual DbSet<S4_Event_Review_Status_New> S4_Event_Review_Status_New { get; set; }

    public virtual DbSet<S4_Event_Review_Sub> S4_Event_Review_Sub { get; set; }

    public virtual DbSet<S4_Event_Review_photo> S4_Event_Review_photo { get; set; }

    public virtual DbSet<S4_Event_install> S4_Event_install { get; set; }

    public virtual DbSet<S4_Holiday> S4_Holiday { get; set; }

    public virtual DbSet<S4_LinkPrice_Log> S4_LinkPrice_Log { get; set; }

    public virtual DbSet<S4_LoginIpInfo> S4_LoginIpInfo { get; set; }

    public virtual DbSet<S4_MARKETING_AGREEMENT_LOG> S4_MARKETING_AGREEMENT_LOG { get; set; }

    public virtual DbSet<S4_MD_Choice> S4_MD_Choice { get; set; }

    public virtual DbSet<S4_MD_Choice_ProdBanner> S4_MD_Choice_ProdBanner { get; set; }

    public virtual DbSet<S4_MD_Choice_Str> S4_MD_Choice_Str { get; set; }

    public virtual DbSet<S4_MD_Choice_Str_UsedYN> S4_MD_Choice_Str_UsedYN { get; set; }

    public virtual DbSet<S4_MD_Choice_Str_temp> S4_MD_Choice_Str_temp { get; set; }

    public virtual DbSet<S4_MD_Choice_UseCoupon> S4_MD_Choice_UseCoupon { get; set; }

    public virtual DbSet<S4_MD_Choice_weeklyhotdeal> S4_MD_Choice_weeklyhotdeal { get; set; }

    public virtual DbSet<S4_McardEditInfo> S4_McardEditInfo { get; set; }

    public virtual DbSet<S4_McardImageInfo> S4_McardImageInfo { get; set; }

    public virtual DbSet<S4_MyCoupon> S4_MyCoupon { get; set; }

    public virtual DbSet<S4_MySweetWedding> S4_MySweetWedding { get; set; }

    public virtual DbSet<S4_NICE_Log> S4_NICE_Log { get; set; }

    public virtual DbSet<S4_NonUserInfo_Sms> S4_NonUserInfo_Sms { get; set; }

    public virtual DbSet<S4_PhotoStory> S4_PhotoStory { get; set; }

    public virtual DbSet<S4_PhotoStory_Reply> S4_PhotoStory_Reply { get; set; }

    public virtual DbSet<S4_Poll> S4_Poll { get; set; }

    public virtual DbSet<S4_Poll_item> S4_Poll_item { get; set; }

    public virtual DbSet<S4_Poll_itemComment> S4_Poll_itemComment { get; set; }

    public virtual DbSet<S4_Poll_item_etc> S4_Poll_item_etc { get; set; }

    public virtual DbSet<S4_Portfolio> S4_Portfolio { get; set; }

    public virtual DbSet<S4_Premier_Business_Card> S4_Premier_Business_Card { get; set; }

    public virtual DbSet<S4_Premier_Business_Img> S4_Premier_Business_Img { get; set; }

    public virtual DbSet<S4_Premier_Movie> S4_Premier_Movie { get; set; }

    public virtual DbSet<S4_Premier_SNS> S4_Premier_SNS { get; set; }

    public virtual DbSet<S4_Ranking_Sort> S4_Ranking_Sort { get; set; }

    public virtual DbSet<S4_Ranking_Sort_Plus> S4_Ranking_Sort_Plus { get; set; }

    public virtual DbSet<S4_Ranking_Sort_Table> S4_Ranking_Sort_Table { get; set; }

    public virtual DbSet<S4_Ranking_Sort_Table_Plus> S4_Ranking_Sort_Table_Plus { get; set; }

    public virtual DbSet<S4_Review_URL> S4_Review_URL { get; set; }

    public virtual DbSet<S4_ShopHelper> S4_ShopHelper { get; set; }

    public virtual DbSet<S4_ShopHelper_Reply> S4_ShopHelper_Reply { get; set; }

    public virtual DbSet<S4_Stock_Alarm> S4_Stock_Alarm { get; set; }

    public virtual DbSet<S4_UserOpinion> S4_UserOpinion { get; set; }

    public virtual DbSet<S4_mCardBoard> S4_mCardBoard { get; set; }

    public virtual DbSet<S5_Event_Item> S5_Event_Item { get; set; }

    public virtual DbSet<S5_Event_Member> S5_Event_Member { get; set; }

    public virtual DbSet<S5_Happy_Price_Item> S5_Happy_Price_Item { get; set; }

    public virtual DbSet<S5_Happy_Price_Main> S5_Happy_Price_Main { get; set; }

    public virtual DbSet<S5_Plus_Friends> S5_Plus_Friends { get; set; }

    public virtual DbSet<S5_Plus_Friends_UID> S5_Plus_Friends_UID { get; set; }

    public virtual DbSet<S5_Supporters_User> S5_Supporters_User { get; set; }

    public virtual DbSet<S5_TodayViewItems> S5_TodayViewItems { get; set; }

    public virtual DbSet<S5_nmCardBoard> S5_nmCardBoard { get; set; }

    public virtual DbSet<S5_nmCardImageInfo> S5_nmCardImageInfo { get; set; }

    public virtual DbSet<S5_nmCardOrder> S5_nmCardOrder { get; set; }

    public virtual DbSet<S5_nmCardShowInfo> S5_nmCardShowInfo { get; set; }

    public virtual DbSet<SAMPLE_DELIVERY_PRICE_INFO> SAMPLE_DELIVERY_PRICE_INFO { get; set; }

    public virtual DbSet<SAMPLE_DIRECTION_INFO> SAMPLE_DIRECTION_INFO { get; set; }

    public virtual DbSet<SAMPLE_LIKE_CHECK> SAMPLE_LIKE_CHECK { get; set; }

    public virtual DbSet<SAMSUNG_BRANCH> SAMSUNG_BRANCH { get; set; }

    public virtual DbSet<SAMSUNG_DAILY_DISCOUNT> SAMSUNG_DAILY_DISCOUNT { get; set; }

    public virtual DbSet<SAMSUNG_DAILY_INFO> SAMSUNG_DAILY_INFO { get; set; }

    public virtual DbSet<SAMSUNG_DELETE_MEMBER> SAMSUNG_DELETE_MEMBER { get; set; }

    public virtual DbSet<SAMSUNG_DELIVERY> SAMSUNG_DELIVERY { get; set; }

    public virtual DbSet<SAMSUNG_MARKETING_AGREEMENT> SAMSUNG_MARKETING_AGREEMENT { get; set; }

    public virtual DbSet<SC_LOG> SC_LOG { get; set; }

    public virtual DbSet<SC_TRAN> SC_TRAN { get; set; }

    public virtual DbSet<SEASON_MEMBER> SEASON_MEMBER { get; set; }

    public virtual DbSet<SEOInfo> SEOInfo { get; set; }

    public virtual DbSet<SEOKeyValue> SEOKeyValue { get; set; }

    public virtual DbSet<SEONonexistLog> SEONonexistLog { get; set; }

    public virtual DbSet<SESSION_GENERATER> SESSION_GENERATER { get; set; }

    public virtual DbSet<SH_Notice> SH_Notice { get; set; }

    public virtual DbSet<SMARTAD_CONTACT_US> SMARTAD_CONTACT_US { get; set; }

    public virtual DbSet<SMARTAD_COUPON_MST> SMARTAD_COUPON_MST { get; set; }

    public virtual DbSet<SMARTAD_COUPON_SUB> SMARTAD_COUPON_SUB { get; set; }

    public virtual DbSet<SMARTAD_EVENT_INFO> SMARTAD_EVENT_INFO { get; set; }

    public virtual DbSet<SMARTAD_EVENT_REQUEST> SMARTAD_EVENT_REQUEST { get; set; }

    public virtual DbSet<SMARTAD_MYCOUPON> SMARTAD_MYCOUPON { get; set; }

    public virtual DbSet<SMSSendMaster> SMSSendMaster { get; set; }

    public virtual DbSet<SMSSendTargetList> SMSSendTargetList { get; set; }

    public virtual DbSet<SNS_CLICK> SNS_CLICK { get; set; }

    public virtual DbSet<SQM_QA_TBL> SQM_QA_TBL { get; set; }

    public virtual DbSet<SS_MMS_SEND_20190910> SS_MMS_SEND_20190910 { get; set; }

    public virtual DbSet<STORE_BARUNSON_ORDER_MATCHING> STORE_BARUNSON_ORDER_MATCHING { get; set; }

    public virtual DbSet<STORE_ORDER_DATE_SEND_LOG> STORE_ORDER_DATE_SEND_LOG { get; set; }

    public virtual DbSet<SampleBook> SampleBook { get; set; }

    public virtual DbSet<SampleBook_History> SampleBook_History { get; set; }

    public virtual DbSet<Sample_Addon> Sample_Addon { get; set; }

    public virtual DbSet<Season_estimate> Season_estimate { get; set; }

    public virtual DbSet<SendEmailContent> SendEmailContent { get; set; }

    public virtual DbSet<SendEmailContentItem> SendEmailContentItem { get; set; }

    public virtual DbSet<SendEmailMaster> SendEmailMaster { get; set; }

    public virtual DbSet<SendEmailRecipient> SendEmailRecipient { get; set; }

    public virtual DbSet<Sheet1_20200520> Sheet1_20200520 { get; set; }

    public virtual DbSet<SmartADNotice> SmartADNotice { get; set; }

    public virtual DbSet<SmartAD_Partner> SmartAD_Partner { get; set; }

    public virtual DbSet<SmartAD_Partner_AD> SmartAD_Partner_AD { get; set; }

    public virtual DbSet<SmartAD_Partner_AD_IMAGE> SmartAD_Partner_AD_IMAGE { get; set; }

    public virtual DbSet<StdMonth> StdMonth { get; set; }

    public virtual DbSet<SurveyAnswer> SurveyAnswer { get; set; }

    public virtual DbSet<SurveyMaster> SurveyMaster { get; set; }

    public virtual DbSet<SurveyQuestion> SurveyQuestion { get; set; }

    public virtual DbSet<SurveyResponse> SurveyResponse { get; set; }

    public virtual DbSet<TB_Holiday> TB_Holiday { get; set; }

    public virtual DbSet<TB_PB_COVERS> TB_PB_COVERS { get; set; }

    public virtual DbSet<TB_PB_EPILOGUE> TB_PB_EPILOGUE { get; set; }

    public virtual DbSet<TB_PB_OASIS> TB_PB_OASIS { get; set; }

    public virtual DbSet<TB_PB_PRODUCT> TB_PB_PRODUCT { get; set; }

    public virtual DbSet<TB_PB_PROLOGUE> TB_PB_PROLOGUE { get; set; }

    public virtual DbSet<TB_PB_SIZE> TB_PB_SIZE { get; set; }

    public virtual DbSet<TB_PB_SKIN> TB_PB_SKIN { get; set; }

    public virtual DbSet<TB_PRODUCT_SIZE> TB_PRODUCT_SIZE { get; set; }

    public virtual DbSet<TB_RESP_ACCOUNT> TB_RESP_ACCOUNT { get; set; }

    public virtual DbSet<TB_RESP_BRANCH> TB_RESP_BRANCH { get; set; }

    public virtual DbSet<TB_RESP_CARD> TB_RESP_CARD { get; set; }

    public virtual DbSet<TB_RESP_CARD_BMC> TB_RESP_CARD_BMC { get; set; }

    public virtual DbSet<TB_RESP_ETC> TB_RESP_ETC { get; set; }

    public virtual DbSet<TB_RESP_EWED> TB_RESP_EWED { get; set; }

    public virtual DbSet<TB_RESP_EWEDD_BMC> TB_RESP_EWEDD_BMC { get; set; }

    public virtual DbSet<TB_RESP_EWEDD_CBR> TB_RESP_EWEDD_CBR { get; set; }

    public virtual DbSet<TB_RESP_LOG> TB_RESP_LOG { get; set; }

    public virtual DbSet<TB_RESP_PHOTOBOOK_BMC> TB_RESP_PHOTOBOOK_BMC { get; set; }

    public virtual DbSet<TB_RESP_PHOTOBOOK_CBR> TB_RESP_PHOTOBOOK_CBR { get; set; }

    public virtual DbSet<TB_RESP_SAMPLE> TB_RESP_SAMPLE { get; set; }

    public virtual DbSet<TB_RESP_SAMPLE_BMC> TB_RESP_SAMPLE_BMC { get; set; }

    public virtual DbSet<TB_RESP_SAMPLE_CAS> TB_RESP_SAMPLE_CAS { get; set; }

    public virtual DbSet<TB_RESP_SAMPLE_CBR> TB_RESP_SAMPLE_CBR { get; set; }

    public virtual DbSet<TB_RESP_SEASON_BMC> TB_RESP_SEASON_BMC { get; set; }

    public virtual DbSet<TB_RESP_SEASON_CBR> TB_RESP_SEASON_CBR { get; set; }

    public virtual DbSet<TB_RESP_WEDD> TB_RESP_WEDD { get; set; }

    public virtual DbSet<TB_RESP_WEDD_BMC> TB_RESP_WEDD_BMC { get; set; }

    public virtual DbSet<TB_RESP_WEDD_CAS> TB_RESP_WEDD_CAS { get; set; }

    public virtual DbSet<TB_RESP_WEDD_CBR> TB_RESP_WEDD_CBR { get; set; }

    public virtual DbSet<THE_MEMBER_OUT> THE_MEMBER_OUT { get; set; }

    public virtual DbSet<THE_ZZIM> THE_ZZIM { get; set; }

    public virtual DbSet<TODAY_PRINTJOB> TODAY_PRINTJOB { get; set; }

    public virtual DbSet<TU_Bestcard> TU_Bestcard { get; set; }

    public virtual DbSet<TU_Member> TU_Member { get; set; }

    public virtual DbSet<T_CCG> T_CCG { get; set; }

    public virtual DbSet<The_Card_overture> The_Card_overture { get; set; }

    public virtual DbSet<The_Card_overture_history> The_Card_overture_history { get; set; }

    public virtual DbSet<The_Ewed_BGM> The_Ewed_BGM { get; set; }

    public virtual DbSet<The_Ewed_Best> The_Ewed_Best { get; set; }

    public virtual DbSet<The_Ewed_Coupon> The_Ewed_Coupon { get; set; }

    public virtual DbSet<The_Ewed_FAQ> The_Ewed_FAQ { get; set; }

    public virtual DbSet<The_Ewed_MyBGM> The_Ewed_MyBGM { get; set; }

    public virtual DbSet<The_Ewed_Order> The_Ewed_Order { get; set; }

    public virtual DbSet<The_Ewed_Order_DELETE> The_Ewed_Order_DELETE { get; set; }

    public virtual DbSet<The_Ewed_Product> The_Ewed_Product { get; set; }

    public virtual DbSet<The_Member> The_Member { get; set; }

    public virtual DbSet<TiaraBestRanking> TiaraBestRanking { get; set; }

    public virtual DbSet<Tiara_Event> Tiara_Event { get; set; }

    public virtual DbSet<Tiara_Member> Tiara_Member { get; set; }

    public virtual DbSet<Tiara_ProdView> Tiara_ProdView { get; set; }

    public virtual DbSet<Tiara_basket> Tiara_basket { get; set; }

    public virtual DbSet<Tiara_board> Tiara_board { get; set; }

    public virtual DbSet<UserInfo_Bhands_ci> UserInfo_Bhands_ci { get; set; }

    public virtual DbSet<UserInfo_TheCard_ci> UserInfo_TheCard_ci { get; set; }

    public virtual DbSet<UserInfo_ci> UserInfo_ci { get; set; }

    public virtual DbSet<UserTokenInfo> UserTokenInfo { get; set; }

    public virtual DbSet<User_Certification_Log> User_Certification_Log { get; set; }

    public virtual DbSet<Util_Date> Util_Date { get; set; }

    public virtual DbSet<VIEW_DELIVERYLST_TEST> VIEW_DELIVERYLST_TEST { get; set; }

    public virtual DbSet<VSTAT_CARD> VSTAT_CARD { get; set; }

    public virtual DbSet<VSTAT_ICON> VSTAT_ICON { get; set; }

    public virtual DbSet<VSTAT_SITE> VSTAT_SITE { get; set; }

    public virtual DbSet<VSTAT_SITE_EPOST> VSTAT_SITE_EPOST { get; set; }

    public virtual DbSet<VW_COUPONTYPE_ORDER_AMT> VW_COUPONTYPE_ORDER_AMT { get; set; }

    public virtual DbSet<VW_COUPON_CALC_FOR_CO> VW_COUPON_CALC_FOR_CO { get; set; }

    public virtual DbSet<VW_COUPON_CALC_FOR_CO_20200303_bak> VW_COUPON_CALC_FOR_CO_20200303_bak { get; set; }

    public virtual DbSet<VW_COUPON_CALC_FOR_CO_TEST> VW_COUPON_CALC_FOR_CO_TEST { get; set; }

    public virtual DbSet<VW_COUPON_CALC_FOR_CO_nsm> VW_COUPON_CALC_FOR_CO_nsm { get; set; }

    public virtual DbSet<VW_COUPON_USER_LIST> VW_COUPON_USER_LIST { get; set; }

    public virtual DbSet<VW_DELIVERY_MST> VW_DELIVERY_MST { get; set; }

    public virtual DbSet<VW_HALL_SALES_STATICS> VW_HALL_SALES_STATICS { get; set; }

    public virtual DbSet<VW_MO_TRAN> VW_MO_TRAN { get; set; }

    public virtual DbSet<VW_OUTSOURCING_ORDER_MST> VW_OUTSOURCING_ORDER_MST { get; set; }

    public virtual DbSet<VW_USER_INFO> VW_USER_INFO { get; set; }

    public virtual DbSet<VW_USER_INFO_ASTERISK> VW_USER_INFO_ASTERISK { get; set; }

    public virtual DbSet<VW_WEDDING_HALL> VW_WEDDING_HALL { get; set; }

    public virtual DbSet<V_BoardList> V_BoardList { get; set; }

    public virtual DbSet<V_OrderGroupDetailList> V_OrderGroupDetailList { get; set; }

    public virtual DbSet<V_OrderGroupList> V_OrderGroupList { get; set; }

    public virtual DbSet<V_order_list> V_order_list { get; set; }

    public virtual DbSet<V_order_list_v2> V_order_list_v2 { get; set; }

    public virtual DbSet<Visit_Reservation> Visit_Reservation { get; set; }

    public virtual DbSet<WEDD_FAQ> WEDD_FAQ { get; set; }

    public virtual DbSet<WEDD_MAIL> WEDD_MAIL { get; set; }

    public virtual DbSet<WeddingHall> WeddingHall { get; set; }

    public virtual DbSet<WeddingHall_Image> WeddingHall_Image { get; set; }

    public virtual DbSet<WeddingHall_Log> WeddingHall_Log { get; set; }

    public virtual DbSet<WeddingMagazine> WeddingMagazine { get; set; }

    public virtual DbSet<WeddingMagazine_Click_Statistics> WeddingMagazine_Click_Statistics { get; set; }

    public virtual DbSet<WeddingNews> WeddingNews { get; set; }

    public virtual DbSet<WeddingNewsResult> WeddingNewsResult { get; set; }

    public virtual DbSet<WeddingNewsResultLog> WeddingNewsResultLog { get; set; }

    public virtual DbSet<WeddingNewsTemplate> WeddingNewsTemplate { get; set; }

    public virtual DbSet<Weddinghall_location> Weddinghall_location { get; set; }

    public virtual DbSet<Wish_OSI> Wish_OSI { get; set; }

    public virtual DbSet<XBBS_ARTICLE> XBBS_ARTICLE { get; set; }

    public virtual DbSet<XBBS_INFO> XBBS_INFO { get; set; }

    public virtual DbSet<Yoosami> Yoosami { get; set; }

    public virtual DbSet<__tmp_canonicaltag_0627> __tmp_canonicaltag_0627 { get; set; }

    public virtual DbSet<antHall> antHall { get; set; }

    public virtual DbSet<ata_banlist> ata_banlist { get; set; }

    public virtual DbSet<ata_mmt_log> ata_mmt_log { get; set; }

    public virtual DbSet<ata_mmt_log_201803> ata_mmt_log_201803 { get; set; }

    public virtual DbSet<ata_mmt_log_201804> ata_mmt_log_201804 { get; set; }

    public virtual DbSet<ata_mmt_log_201805> ata_mmt_log_201805 { get; set; }

    public virtual DbSet<ata_mmt_log_201806> ata_mmt_log_201806 { get; set; }

    public virtual DbSet<ata_mmt_log_201807> ata_mmt_log_201807 { get; set; }

    public virtual DbSet<ata_mmt_log_201808> ata_mmt_log_201808 { get; set; }

    public virtual DbSet<ata_mmt_log_201809> ata_mmt_log_201809 { get; set; }

    public virtual DbSet<ata_mmt_log_201810> ata_mmt_log_201810 { get; set; }

    public virtual DbSet<ata_mmt_log_201811> ata_mmt_log_201811 { get; set; }

    public virtual DbSet<ata_mmt_log_201812> ata_mmt_log_201812 { get; set; }

    public virtual DbSet<ata_mmt_log_201901> ata_mmt_log_201901 { get; set; }

    public virtual DbSet<ata_mmt_log_201902> ata_mmt_log_201902 { get; set; }

    public virtual DbSet<ata_mmt_log_201903> ata_mmt_log_201903 { get; set; }

    public virtual DbSet<ata_mmt_log_201904> ata_mmt_log_201904 { get; set; }

    public virtual DbSet<ata_mmt_log_201905> ata_mmt_log_201905 { get; set; }

    public virtual DbSet<ata_mmt_log_201906> ata_mmt_log_201906 { get; set; }

    public virtual DbSet<ata_mmt_log_201907> ata_mmt_log_201907 { get; set; }

    public virtual DbSet<ata_mmt_log_201908> ata_mmt_log_201908 { get; set; }

    public virtual DbSet<ata_mmt_log_201909> ata_mmt_log_201909 { get; set; }

    public virtual DbSet<ata_mmt_log_201910> ata_mmt_log_201910 { get; set; }

    public virtual DbSet<ata_mmt_log_201911> ata_mmt_log_201911 { get; set; }

    public virtual DbSet<ata_mmt_log_201912> ata_mmt_log_201912 { get; set; }

    public virtual DbSet<ata_mmt_log_202001> ata_mmt_log_202001 { get; set; }

    public virtual DbSet<ata_mmt_log_202002> ata_mmt_log_202002 { get; set; }

    public virtual DbSet<ata_mmt_log_202003> ata_mmt_log_202003 { get; set; }

    public virtual DbSet<ata_mmt_log_202004> ata_mmt_log_202004 { get; set; }

    public virtual DbSet<ata_mmt_log_202005> ata_mmt_log_202005 { get; set; }

    public virtual DbSet<ata_mmt_log_202006> ata_mmt_log_202006 { get; set; }

    public virtual DbSet<ata_mmt_log_202007> ata_mmt_log_202007 { get; set; }

    public virtual DbSet<ata_mmt_log_202008> ata_mmt_log_202008 { get; set; }

    public virtual DbSet<ata_mmt_log_202009> ata_mmt_log_202009 { get; set; }

    public virtual DbSet<ata_mmt_log_202010> ata_mmt_log_202010 { get; set; }

    public virtual DbSet<ata_mmt_log_202011> ata_mmt_log_202011 { get; set; }

    public virtual DbSet<ata_mmt_log_202012> ata_mmt_log_202012 { get; set; }

    public virtual DbSet<ata_mmt_log_202101> ata_mmt_log_202101 { get; set; }

    public virtual DbSet<ata_mmt_log_202102> ata_mmt_log_202102 { get; set; }

    public virtual DbSet<ata_mmt_log_202103> ata_mmt_log_202103 { get; set; }

    public virtual DbSet<ata_mmt_log_202104> ata_mmt_log_202104 { get; set; }

    public virtual DbSet<ata_mmt_log_202105> ata_mmt_log_202105 { get; set; }

    public virtual DbSet<ata_mmt_log_202106> ata_mmt_log_202106 { get; set; }

    public virtual DbSet<ata_mmt_log_202107> ata_mmt_log_202107 { get; set; }

    public virtual DbSet<ata_mmt_log_202108> ata_mmt_log_202108 { get; set; }

    public virtual DbSet<ata_mmt_log_202109> ata_mmt_log_202109 { get; set; }

    public virtual DbSet<ata_mmt_log_202110> ata_mmt_log_202110 { get; set; }

    public virtual DbSet<ata_mmt_log_202111> ata_mmt_log_202111 { get; set; }

    public virtual DbSet<ata_mmt_log_202112> ata_mmt_log_202112 { get; set; }

    public virtual DbSet<ata_mmt_log_202201> ata_mmt_log_202201 { get; set; }

    public virtual DbSet<ata_mmt_log_202202> ata_mmt_log_202202 { get; set; }

    public virtual DbSet<ata_mmt_log_202203> ata_mmt_log_202203 { get; set; }

    public virtual DbSet<ata_mmt_log_202204> ata_mmt_log_202204 { get; set; }

    public virtual DbSet<ata_mmt_log_202205> ata_mmt_log_202205 { get; set; }

    public virtual DbSet<ata_mmt_log_202206> ata_mmt_log_202206 { get; set; }

    public virtual DbSet<ata_mmt_log_202207> ata_mmt_log_202207 { get; set; }

    public virtual DbSet<ata_mmt_log_202208> ata_mmt_log_202208 { get; set; }

    public virtual DbSet<ata_mmt_log_202209> ata_mmt_log_202209 { get; set; }

    public virtual DbSet<ata_mmt_log_202210> ata_mmt_log_202210 { get; set; }

    public virtual DbSet<ata_mmt_log_202211> ata_mmt_log_202211 { get; set; }

    public virtual DbSet<ata_mmt_log_202212> ata_mmt_log_202212 { get; set; }

    public virtual DbSet<ata_mmt_log_202301> ata_mmt_log_202301 { get; set; }

    public virtual DbSet<ata_mmt_log_202302> ata_mmt_log_202302 { get; set; }

    public virtual DbSet<ata_mmt_log_202303> ata_mmt_log_202303 { get; set; }

    public virtual DbSet<ata_mmt_log_202304> ata_mmt_log_202304 { get; set; }

    public virtual DbSet<ata_mmt_log_202305> ata_mmt_log_202305 { get; set; }

    public virtual DbSet<ata_mmt_log_202306> ata_mmt_log_202306 { get; set; }

    public virtual DbSet<ata_mmt_log_202307> ata_mmt_log_202307 { get; set; }

    public virtual DbSet<ata_mmt_log_230126_230309> ata_mmt_log_230126_230309 { get; set; }

    public virtual DbSet<ata_mmt_tran> ata_mmt_tran { get; set; }

    public virtual DbSet<barunToclosed_history_log> barunToclosed_history_log { get; set; }

    public virtual DbSet<barunToclosed_log> barunToclosed_log { get; set; }

    public virtual DbSet<barunson_authinfo> barunson_authinfo { get; set; }

    public virtual DbSet<barunson_day_count> barunson_day_count { get; set; }

    public virtual DbSet<bbarunson_log> bbarunson_log { get; set; }

    public virtual DbSet<bbarunson_notice> bbarunson_notice { get; set; }

    public virtual DbSet<bhands_day_count> bhands_day_count { get; set; }

    public virtual DbSet<board_basic_info> board_basic_info { get; set; }

    public virtual DbSet<board_filter_info> board_filter_info { get; set; }

    public virtual DbSet<bsmall_main_view> bsmall_main_view { get; set; }

    public virtual DbSet<card_bbs> card_bbs { get; set; }

    public virtual DbSet<card_design> card_design { get; set; }

    public virtual DbSet<card_design_detail> card_design_detail { get; set; }

    public virtual DbSet<card_discount> card_discount { get; set; }

    public virtual DbSet<card_discount_rate_2u> card_discount_rate_2u { get; set; }

    public virtual DbSet<card_discount_season> card_discount_season { get; set; }

    public virtual DbSet<card_faq> card_faq { get; set; }

    public virtual DbSet<card_printinfo> card_printinfo { get; set; }

    public virtual DbSet<chk_session_log> chk_session_log { get; set; }

    public virtual DbSet<choan_admin_log> choan_admin_log { get; set; }

    public virtual DbSet<concierge_wedding_info> concierge_wedding_info { get; set; }

    public virtual DbSet<coperation> coperation { get; set; }

    public virtual DbSet<cost_zipcode> cost_zipcode { get; set; }

    public virtual DbSet<coupon_complete_error_message> coupon_complete_error_message { get; set; }

    public virtual DbSet<coupon_complete_log> coupon_complete_log { get; set; }

    public virtual DbSet<custom_card_faq> custom_card_faq { get; set; }

    public virtual DbSet<custom_cms_msg> custom_cms_msg { get; set; }

    public virtual DbSet<custom_info> custom_info { get; set; }

    public virtual DbSet<custom_order> custom_order { get; set; }

    public virtual DbSet<custom_order_OtherInfo> custom_order_OtherInfo { get; set; }

    public virtual DbSet<custom_order_WeddInfo> custom_order_WeddInfo { get; set; }

    public virtual DbSet<custom_order_WeddInfo_backup> custom_order_WeddInfo_backup { get; set; }

    public virtual DbSet<custom_order_agreement> custom_order_agreement { get; set; }

    public virtual DbSet<custom_order_backup> custom_order_backup { get; set; }

    public virtual DbSet<custom_order_copy_backup> custom_order_copy_backup { get; set; }

    public virtual DbSet<custom_order_copy_detail_backup> custom_order_copy_detail_backup { get; set; }

    public virtual DbSet<custom_order_cprice> custom_order_cprice { get; set; }

    public virtual DbSet<custom_order_files> custom_order_files { get; set; }

    public virtual DbSet<custom_order_history> custom_order_history { get; set; }

    public virtual DbSet<custom_order_item> custom_order_item { get; set; }

    public virtual DbSet<custom_order_log> custom_order_log { get; set; }

    public virtual DbSet<custom_order_passbook> custom_order_passbook { get; set; }

    public virtual DbSet<custom_order_plist> custom_order_plist { get; set; }

    public virtual DbSet<custom_order_plistAddD> custom_order_plistAddD { get; set; }

    public virtual DbSet<custom_order_plistAddD_backup> custom_order_plistAddD_backup { get; set; }

    public virtual DbSet<custom_order_plistAddG> custom_order_plistAddG { get; set; }

    public virtual DbSet<custom_order_plistAddG_backup> custom_order_plistAddG_backup { get; set; }

    public virtual DbSet<custom_order_plistAddN> custom_order_plistAddN { get; set; }

    public virtual DbSet<custom_order_plistAddN_backup> custom_order_plistAddN_backup { get; set; }

    public virtual DbSet<custom_order_plistAddT> custom_order_plistAddT { get; set; }

    public virtual DbSet<custom_order_plistAddT_backup> custom_order_plistAddT_backup { get; set; }

    public virtual DbSet<custom_order_plistAddText> custom_order_plistAddText { get; set; }

    public virtual DbSet<custom_order_plistSVG> custom_order_plistSVG { get; set; }

    public virtual DbSet<custom_order_plist_backup> custom_order_plist_backup { get; set; }

    public virtual DbSet<custom_order_plist_svg> custom_order_plist_svg { get; set; }

    public virtual DbSet<custom_order_printW> custom_order_printW { get; set; }

    public virtual DbSet<custom_order_print_state> custom_order_print_state { get; set; }

    public virtual DbSet<custom_order_printjob> custom_order_printjob { get; set; }

    public virtual DbSet<custom_order_quick> custom_order_quick { get; set; }

    public virtual DbSet<custom_order_refund> custom_order_refund { get; set; }

    public virtual DbSet<custom_order_tax> custom_order_tax { get; set; }

    public virtual DbSet<custom_order_tmap> custom_order_tmap { get; set; }

    public virtual DbSet<custom_order_trouble> custom_order_trouble { get; set; }

    public virtual DbSet<custom_order_trouble2> custom_order_trouble2 { get; set; }

    public virtual DbSet<custom_order_unicef> custom_order_unicef { get; set; }

    public virtual DbSet<data_dump_dt> data_dump_dt { get; set; }

    public virtual DbSet<dcake_address> dcake_address { get; set; }

    public virtual DbSet<deardeer_order_rel> deardeer_order_rel { get; set; }

    public virtual DbSet<deardeer_product> deardeer_product { get; set; }

    public virtual DbSet<del_tmp> del_tmp { get; set; }

    public virtual DbSet<delivery_info_backup> delivery_info_backup { get; set; }

    public virtual DbSet<delivery_info_detail_backup> delivery_info_detail_backup { get; set; }

    public virtual DbSet<design_env_group> design_env_group { get; set; }

    public virtual DbSet<drop_invo_area> drop_invo_area { get; set; }

    public virtual DbSet<eco_card_list> eco_card_list { get; set; }

    public virtual DbSet<env_image> env_image { get; set; }

    public virtual DbSet<err_chk_log> err_chk_log { get; set; }

    public virtual DbSet<event_CardDiscount> event_CardDiscount { get; set; }

    public virtual DbSet<event_sale_carddiscount> event_sale_carddiscount { get; set; }

    public virtual DbSet<event_sms_coupon> event_sms_coupon { get; set; }

    public virtual DbSet<evt_himo_coupon> evt_himo_coupon { get; set; }

    public virtual DbSet<evt_leaflet_Card> evt_leaflet_Card { get; set; }

    public virtual DbSet<evt_mem_regist_gift> evt_mem_regist_gift { get; set; }

    public virtual DbSet<evt_memoerybook_gift> evt_memoerybook_gift { get; set; }

    public virtual DbSet<evt_travelpack_st> evt_travelpack_st { get; set; }

    public virtual DbSet<ewed_ATTEND_LIST> ewed_ATTEND_LIST { get; set; }

    public virtual DbSet<ewed_BUY_CARD> ewed_BUY_CARD { get; set; }

    public virtual DbSet<ewed_BUY_CARD_CONTENT> ewed_BUY_CARD_CONTENT { get; set; }

    public virtual DbSet<ewed_BUY_SETTLE_INFO> ewed_BUY_SETTLE_INFO { get; set; }

    public virtual DbSet<ewed_CARD_INFO> ewed_CARD_INFO { get; set; }

    public virtual DbSet<ewed_CARD_USER_COMMNET> ewed_CARD_USER_COMMNET { get; set; }

    public virtual DbSet<ewed_Music_Data> ewed_Music_Data { get; set; }

    public virtual DbSet<ewed_Notice> ewed_Notice { get; set; }

    public virtual DbSet<ewed_Notice_daum> ewed_Notice_daum { get; set; }

    public virtual DbSet<ewed_Open_Text> ewed_Open_Text { get; set; }

    public virtual DbSet<ewed_Order_Detail> ewed_Order_Detail { get; set; }

    public virtual DbSet<ewed_Order_MemoDay> ewed_Order_MemoDay { get; set; }

    public virtual DbSet<ewed_Order_Photo> ewed_Order_Photo { get; set; }

    public virtual DbSet<ewed_Order_Settle> ewed_Order_Settle { get; set; }

    public virtual DbSet<ewed_RESULT_LIST> ewed_RESULT_LIST { get; set; }

    public virtual DbSet<ewed_SMS> ewed_SMS { get; set; }

    public virtual DbSet<ewed_SMS_Service> ewed_SMS_Service { get; set; }

    public virtual DbSet<ewed_VISIT_NOTE> ewed_VISIT_NOTE { get; set; }

    public virtual DbSet<ewed_Visit> ewed_Visit { get; set; }

    public virtual DbSet<ewed_Wedding_Attend> ewed_Wedding_Attend { get; set; }

    public virtual DbSet<ewed_address> ewed_address { get; set; }

    public virtual DbSet<ewed_coupon> ewed_coupon { get; set; }

    public virtual DbSet<ewed_event_mailing> ewed_event_mailing { get; set; }

    public virtual DbSet<ewed_event_question> ewed_event_question { get; set; }

    public virtual DbSet<ewed_miniCD_INFO> ewed_miniCD_INFO { get; set; }

    public virtual DbSet<ewed_order_detail_B> ewed_order_detail_B { get; set; }

    public virtual DbSet<ewed_order_detail_D> ewed_order_detail_D { get; set; }

    public virtual DbSet<ewed_order_detail_P1> ewed_order_detail_P1 { get; set; }

    public virtual DbSet<ewed_order_detail_P2> ewed_order_detail_P2 { get; set; }

    public virtual DbSet<ewed_order_detail_P3> ewed_order_detail_P3 { get; set; }

    public virtual DbSet<ewed_order_detail_P4> ewed_order_detail_P4 { get; set; }

    public virtual DbSet<ewed_order_detail_T> ewed_order_detail_T { get; set; }

    public virtual DbSet<ewed_order_info> ewed_order_info { get; set; }

    public virtual DbSet<ewed_order_opinion> ewed_order_opinion { get; set; }

    public virtual DbSet<ewed_order_weddinfo> ewed_order_weddinfo { get; set; }

    public virtual DbSet<ewed_order_work> ewed_order_work { get; set; }

    public virtual DbSet<ewed_user_mailgroup> ewed_user_mailgroup { get; set; }

    public virtual DbSet<eweddCD> eweddCD { get; set; }

    public virtual DbSet<except_choan_view_list> except_choan_view_list { get; set; }

    public virtual DbSet<getOverture> getOverture { get; set; }

    public virtual DbSet<gift_company_tel> gift_company_tel { get; set; }

    public virtual DbSet<greeting_category_nvarchar> greeting_category_nvarchar { get; set; }

    public virtual DbSet<greeting_nvarchar> greeting_nvarchar { get; set; }

    public virtual DbSet<guestbook_order> guestbook_order { get; set; }

    public virtual DbSet<gurim_coupon_event> gurim_coupon_event { get; set; }

    public virtual DbSet<hanjin_ErrLog> hanjin_ErrLog { get; set; }

    public virtual DbSet<hanssem> hanssem { get; set; }

    public virtual DbSet<history> history { get; set; }

    public virtual DbSet<holidays> holidays { get; set; }

    public virtual DbSet<image_order> image_order { get; set; }

    public virtual DbSet<image_order_admin> image_order_admin { get; set; }

    public virtual DbSet<image_order_item> image_order_item { get; set; }

    public virtual DbSet<image_order_pg> image_order_pg { get; set; }

    public virtual DbSet<inipay_vbank_log> inipay_vbank_log { get; set; }

    public virtual DbSet<interparktour_coupon_event> interparktour_coupon_event { get; set; }

    public virtual DbSet<iwedding_Sending> iwedding_Sending { get; set; }

    public virtual DbSet<jehu_memo> jehu_memo { get; set; }

    public virtual DbSet<jehu_no_coupon_event> jehu_no_coupon_event { get; set; }

    public virtual DbSet<jehu_send_mms> jehu_send_mms { get; set; }

    public virtual DbSet<jehucoupon_noCard> jehucoupon_noCard { get; set; }

    public virtual DbSet<lgdacom_cas_log> lgdacom_cas_log { get; set; }

    public virtual DbSet<m_count> m_count { get; set; }

    public virtual DbSet<manage_code> manage_code { get; set; }

    public virtual DbSet<mcard_Admin> mcard_Admin { get; set; }

    public virtual DbSet<mcard_Auth> mcard_Auth { get; set; }

    public virtual DbSet<mcard_Comment> mcard_Comment { get; set; }

    public virtual DbSet<mcard_Gallery> mcard_Gallery { get; set; }

    public virtual DbSet<mcard_Gift> mcard_Gift { get; set; }

    public virtual DbSet<mcard_Greeting> mcard_Greeting { get; set; }

    public virtual DbSet<mcard_Invitation> mcard_Invitation { get; set; }

    public virtual DbSet<mcard_InvitationBaby> mcard_InvitationBaby { get; set; }

    public virtual DbSet<mcard_InvitationGiftRel> mcard_InvitationGiftRel { get; set; }

    public virtual DbSet<mcard_InvitationParty> mcard_InvitationParty { get; set; }

    public virtual DbSet<mcard_InvitationWedding> mcard_InvitationWedding { get; set; }

    public virtual DbSet<mcard_Invitation_log> mcard_Invitation_log { get; set; }

    public virtual DbSet<mcard_LogInvitation> mcard_LogInvitation { get; set; }

    public virtual DbSet<mcard_Skin> mcard_Skin { get; set; }

    public virtual DbSet<mcard_TmpInvitation> mcard_TmpInvitation { get; set; }

    public virtual DbSet<mcard_TmpInvitationGiftRel> mcard_TmpInvitationGiftRel { get; set; }

    public virtual DbSet<mcard_TmpInvitationOption> mcard_TmpInvitationOption { get; set; }

    public virtual DbSet<metingg> metingg { get; set; }

    public virtual DbSet<mobile_ad_visit> mobile_ad_visit { get; set; }

    public virtual DbSet<oneclick_sample> oneclick_sample { get; set; }

    public virtual DbSet<ordList_new> ordList_new { get; set; }

    public virtual DbSet<orderLst> orderLst { get; set; }

    public virtual DbSet<orderLst_20080922> orderLst_20080922 { get; set; }

    public virtual DbSet<orderLst_new> orderLst_new { get; set; }

    public virtual DbSet<orderLst_test> orderLst_test { get; set; }

    public virtual DbSet<photobook_myCouponList> photobook_myCouponList { get; set; }

    public virtual DbSet<photobook_order_detailV> photobook_order_detailV { get; set; }

    public virtual DbSet<photobook_order_detail_erp> photobook_order_detail_erp { get; set; }

    public virtual DbSet<photobook_prod_price> photobook_prod_price { get; set; }

    public virtual DbSet<preView_ChkList> preView_ChkList { get; set; }

    public virtual DbSet<printjob_order_seq> printjob_order_seq { get; set; }

    public virtual DbSet<recycle_agree_log> recycle_agree_log { get; set; }

    public virtual DbSet<research_log> research_log { get; set; }

    public virtual DbSet<research_qlist_Detail> research_qlist_Detail { get; set; }

    public virtual DbSet<s2_card_dd> s2_card_dd { get; set; }

    public virtual DbSet<s2_event_UserComment_url> s2_event_UserComment_url { get; set; }

    public virtual DbSet<s4_CardBest100> s4_CardBest100 { get; set; }

    public virtual DbSet<s4_md_choice_jehu> s4_md_choice_jehu { get; set; }

    public virtual DbSet<s4_poll_user_reply> s4_poll_user_reply { get; set; }

    public virtual DbSet<sb_samplebook_item> sb_samplebook_item { get; set; }

    public virtual DbSet<shakr_coupon_event> shakr_coupon_event { get; set; }

    public virtual DbSet<sticker_count> sticker_count { get; set; }

    public virtual DbSet<super7day_sms> super7day_sms { get; set; }

    public virtual DbSet<tCouponMst> tCouponMst { get; set; }

    public virtual DbSet<tCouponMst_SmartAD> tCouponMst_SmartAD { get; set; }

    public virtual DbSet<tCouponOff> tCouponOff { get; set; }

    public virtual DbSet<tCouponSub> tCouponSub { get; set; }

    public virtual DbSet<tCouponSub1> tCouponSub1 { get; set; }

    public virtual DbSet<tCouponSub_SmartAD> tCouponSub_SmartAD { get; set; }

    public virtual DbSet<tCouponTarget> tCouponTarget { get; set; }

    public virtual DbSet<tCouponTermBrand> tCouponTermBrand { get; set; }

    public virtual DbSet<tCouponTermCategory> tCouponTermCategory { get; set; }

    public virtual DbSet<tCouponTermEvent> tCouponTermEvent { get; set; }

    public virtual DbSet<tCouponTermItem> tCouponTermItem { get; set; }

    public virtual DbSet<tCouponTermVnd> tCouponTermVnd { get; set; }

    public virtual DbSet<tCouponUseItem> tCouponUseItem { get; set; }

    public virtual DbSet<tEvent> tEvent { get; set; }

    public virtual DbSet<tEventBotItem> tEventBotItem { get; set; }

    public virtual DbSet<tEventBotTemplete> tEventBotTemplete { get; set; }

    public virtual DbSet<tEventRelationBanner> tEventRelationBanner { get; set; }

    public virtual DbSet<tJobCode> tJobCode { get; set; }

    public virtual DbSet<tMember_secede> tMember_secede { get; set; }

    public virtual DbSet<tNeo_Queue> tNeo_Queue { get; set; }

    public virtual DbSet<tUserInfo> tUserInfo { get; set; }

    public virtual DbSet<t_card> t_card { get; set; }

    public virtual DbSet<temp0307> temp0307 { get; set; }

    public virtual DbSet<temp0322> temp0322 { get; set; }

    public virtual DbSet<temp190405> temp190405 { get; set; }

    public virtual DbSet<temp_choansum> temp_choansum { get; set; }

    public virtual DbSet<temp_deardeer_member> temp_deardeer_member { get; set; }

    public virtual DbSet<temp_gift_company> temp_gift_company { get; set; }

    public virtual DbSet<temp_year> temp_year { get; set; }

    public virtual DbSet<tj_test> tj_test { get; set; }

    public virtual DbSet<tmp_20200622> tmp_20200622 { get; set; }

    public virtual DbSet<tmp_order_flow_180314> tmp_order_flow_180314 { get; set; }

    public virtual DbSet<tmp_restore> tmp_restore { get; set; }

    public virtual DbSet<tmp_sample_order> tmp_sample_order { get; set; }

    public virtual DbSet<toss_vaccount> toss_vaccount { get; set; }

    public virtual DbSet<toss_vaccount_log> toss_vaccount_log { get; set; }

    public virtual DbSet<vCardWeight> vCardWeight { get; set; }

    public virtual DbSet<vPB_PROD> vPB_PROD { get; set; }

    public virtual DbSet<view_Bestseller> view_Bestseller { get; set; }

    public virtual DbSet<view_Comment> view_Comment { get; set; }

    public virtual DbSet<view_CopyItem> view_CopyItem { get; set; }

    public virtual DbSet<view_DeliveryLst> view_DeliveryLst { get; set; }

    public virtual DbSet<view_OB_Card> view_OB_Card { get; set; }

    public virtual DbSet<view_OB_Company> view_OB_Company { get; set; }

    public virtual DbSet<view_OB_Order> view_OB_Order { get; set; }

    public virtual DbSet<view_S4EventInstall> view_S4EventInstall { get; set; }

    public virtual DbSet<view_SampleList> view_SampleList { get; set; }

    public virtual DbSet<view_UsrInfo> view_UsrInfo { get; set; }

    public virtual DbSet<view_UsrQnA> view_UsrQnA { get; set; }

    public virtual DbSet<view_UsrQnA_for_Excel> view_UsrQnA_for_Excel { get; set; }

    public virtual DbSet<view_cardRank> view_cardRank { get; set; }

    public virtual DbSet<view_emBoard> view_emBoard { get; set; }

    public virtual DbSet<wed_Notice> wed_Notice { get; set; }

    public virtual DbSet<wedd_biztalk> wedd_biztalk { get; set; }

    public virtual DbSet<weddinghall_information> weddinghall_information { get; set; }

    public virtual DbSet<weddinghall_tmp> weddinghall_tmp { get; set; }

    public virtual DbSet<weddinghallbest_click> weddinghallbest_click { get; set; }

    public virtual DbSet<wish_rate> wish_rate { get; set; }

    public virtual DbSet<zip_busan> zip_busan { get; set; }

    public virtual DbSet<zip_ch_buk> zip_ch_buk { get; set; }

    public virtual DbSet<zip_ch_nam> zip_ch_nam { get; set; }

    public virtual DbSet<zip_daegu> zip_daegu { get; set; }

    public virtual DbSet<zip_daejeon> zip_daejeon { get; set; }

    public virtual DbSet<zip_gangwon> zip_gangwon { get; set; }

    public virtual DbSet<zip_gwangju> zip_gwangju { get; set; }

    public virtual DbSet<zip_gyeonggi> zip_gyeonggi { get; set; }

    public virtual DbSet<zip_incheon> zip_incheon { get; set; }

    public virtual DbSet<zip_jeju> zip_jeju { get; set; }

    public virtual DbSet<zip_junbuk> zip_junbuk { get; set; }

    public virtual DbSet<zip_junnam> zip_junnam { get; set; }

    public virtual DbSet<zip_ks_buk> zip_ks_buk { get; set; }

    public virtual DbSet<zip_ks_nam> zip_ks_nam { get; set; }

    public virtual DbSet<zip_sejong> zip_sejong { get; set; }

    public virtual DbSet<zip_seoul> zip_seoul { get; set; }

    public virtual DbSet<zip_ulsan> zip_ulsan { get; set; }

    public virtual DbSet<zipcode> zipcode { get; set; }

    public virtual DbSet<zipcode_hanjin> zipcode_hanjin { get; set; }

    public virtual DbSet<zipcode_new> zipcode_new { get; set; }

    public virtual DbSet<zipcode_street> zipcode_street { get; set; }

    public virtual DbSet<zipcode_street_N> zipcode_street_N { get; set; }

    public virtual DbSet<zipcode_tbl> zipcode_tbl { get; set; }

    public virtual DbSet<PolicyInfo> PolicyInfo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ADMIN_CONNECT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 접속정보"));

            entity.Property(e => e.admin_id).HasComment("관리자 아이디");
            entity.Property(e => e.last_update).HasComment("최종접속시간");
            entity.Property(e => e.login_date).HasComment("접속일");
            entity.Property(e => e.login_ip).HasComment("아이피");
        });

        modelBuilder.Entity<ADMIN_DISPLAY_UPDATE_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 전시설정 변경 로그"));

            entity.Property(e => e.AfterIsDisplay).IsFixedLength();
            entity.Property(e => e.AfterIsJumun).IsFixedLength();
            entity.Property(e => e.PreIsDisplay).IsFixedLength();
            entity.Property(e => e.PreIsJumun).IsFixedLength();
        });

        modelBuilder.Entity<ADMIN_LIMIT_SETTING>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 제한 설정"));

            entity.Property(e => e.TYPE).IsFixedLength();
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<ADMIN_LIMIT_SETTING_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 제한 설정 로그"));

            entity.Property(e => e.TYPE).IsFixedLength();
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<ADMIN_LST>(entity =>
        {
            entity.HasKey(e => e.ADMIN_ID).HasName("PK__ADMIN_LST__5EBF139D");

            entity.ToTable(tb => tb.HasComment("빠른손 관리자 목록"));

            entity.Property(e => e.ADMIN_ID).HasComment("관리자ID");
            entity.Property(e => e.ADMIN_LEVEL).HasComment("1일때 전체권한,0일때 e청첩장 관리");
            entity.Property(e => e.CMS_ID).HasComment("콜센터 어드민 아이디");
            entity.Property(e => e.CMS_NUM).HasComment("콜센터 접속 전화번호");
            entity.Property(e => e.COMPANY_TYPE)
                .IsFixedLength()
                .HasComment("1:온라인,2:매장/영업");
            entity.Property(e => e.NState).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isAlba)
                .IsFixedLength()
                .HasComment("1일때 외부 재택 작업자");
            entity.Property(e => e.isCS)
                .IsFixedLength()
                .HasComment("1일때 CS 콜센터");
            entity.Property(e => e.isDesigner)
                .IsFixedLength()
                .HasComment("1일때 초안작업자");
            entity.Property(e => e.isDeveloper)
                .IsFixedLength()
                .HasComment("1일때 빠른손 로그인 가능");
            entity.Property(e => e.isDown)
                .IsFixedLength()
                .HasComment("1일때 해당 작업자 주문코렐 다운로드");
            entity.Property(e => e.isPackingSMS)
                .IsFixedLength()
                .HasComment("1일때 재택/퀵 포장완료시  문자발송");
            entity.Property(e => e.isViewNoticeYN).IsFixedLength();

            entity.HasOne(d => d.COMPANY_SEQNavigation).WithMany(p => p.ADMIN_LST)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ADMIN_LST__COMPA__52793849");
        });

        modelBuilder.Entity<ADMIN_PRICE_LOGINFO>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 상품가격변경 로그"));
        });

        modelBuilder.Entity<AUTO_CHOAN_LOG>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_AUTO_CHOAN_HISTORY");

            entity.ToTable(tb => tb.HasComment("자동초안 로그"));

            entity.Property(e => e.ORDER_SEQ).HasComment("주문seq");
        });

        modelBuilder.Entity<Admin_LoginIpInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 접속 로그"));

            entity.Property(e => e.seq).HasComment("순번");
            entity.Property(e => e.referer_url).HasComment("유입 url");
            entity.Property(e => e.uid).HasComment("관리자id");
            entity.Property(e => e.umail).HasComment("관리자 이메일");
            entity.Property(e => e.uname).HasComment("관리자명");
        });

        modelBuilder.Entity<Admin_Menu>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드전용 관리자 메뉴"));

            entity.Property(e => e.AM_Code1).IsFixedLength();
            entity.Property(e => e.AM_Code2).IsFixedLength();
            entity.Property(e => e.AM_Code3).IsFixedLength();
        });

        modelBuilder.Entity<AgaBarunson_Member>(entity =>
        {
            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.isLunar).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<AliveCheck>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("실사용자확인"));

            entity.Property(e => e.Gubun).IsFixedLength();
        });

        modelBuilder.Entity<AliveCheck_Info>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("라이브체크정보"));

            entity.Property(e => e.Order_Check).IsFixedLength();
            entity.Property(e => e.Sample_Check).IsFixedLength();
            entity.Property(e => e.Settle_Check).IsFixedLength();
        });

        modelBuilder.Entity<Authorization_SMS>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SMS 인증 로그"));

            entity.Property(e => e.SEQ).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BANNER_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 배너관리"));

            entity.Property(e => e.BANNER_TYPE)
                .IsFixedLength()
                .HasComment("M메인배너_L왼쪽소배너_R오른쪽소배너_P팝업배너_N공지팝업");
            entity.Property(e => e.DISPLAY_YN).IsFixedLength();
        });

        modelBuilder.Entity<BARUNN_INTEGRATE_USER_CHANGE_PROGRESS_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("전환 진행중 상태  로그"));
        });

        modelBuilder.Entity<BBarunson_Config>(entity =>
        {
            entity.Property(e => e.clsControl_Use).IsFixedLength();
        });

        modelBuilder.Entity<BC_Career>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("채용관련"));

            entity.Property(e => e.AnyTime).IsFixedLength();
            entity.Property(e => e.Hidden).IsFixedLength();
        });

        modelBuilder.Entity<BC_CareerContent>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("채용내용"));
        });

        modelBuilder.Entity<BEAUTYBOX_ITEM_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("BEAUTYBOX_ITEM_MST"));

            entity.Property(e => e.STOCK_YORN).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<BENEFIT_BANNER>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("혜택배너"));

            entity.Property(e => e.ALWAYS_YN).HasComment("상시노출(Y:상시 N)");
            entity.Property(e => e.B_BACK_COLOR).HasComment("배경 컬러코드");
            entity.Property(e => e.B_IMG).HasComment("배너 이미지 경로");
            entity.Property(e => e.B_TYPE).HasComment("타입(L:대메뉴 M:중메뉴 S:소메뉴)별 위치");
            entity.Property(e => e.B_TYPE_NO).HasComment("1:진행 2:대기 3:대체");
            entity.Property(e => e.DELETE_YN).HasComment("기간이 남은 리스트를 삭제한 경우Y");
            entity.Property(e => e.DISPLAY_YN).HasComment("전시유무(Y:전시 N:비전시)");
            entity.Property(e => e.END_YN).HasComment("종료유무(Y:종료 N:미종료)");
            entity.Property(e => e.EVENT_E_DT).HasComment("이벤트 종료일");
            entity.Property(e => e.EVENT_S_DT).HasComment("이벤트 시작일");
            entity.Property(e => e.JEHU_YN).HasComment("제휴배너");
            entity.Property(e => e.MAIN_TITLE).HasComment("메인 타이틀(제목)");
            entity.Property(e => e.NEW_BLANK_YN).HasComment("새창띄움");
            entity.Property(e => e.PAGE_URL).HasComment("페이지 연결URL");
            entity.Property(e => e.REPLACE_YN).HasComment("대체유무(Y:대체 N:미대체)");
            entity.Property(e => e.SUB_TITLE).HasComment("서브 타이틀(내용)");
            entity.Property(e => e.WING_IMG).HasComment("윙배너 이미지 경로");
            entity.Property(e => e.WING_YN).HasComment("윙배너노출");
        });

        modelBuilder.Entity<BEWEDDING_CONTENT>(entity =>
        {
            entity.Property(e => e.DEL_YN).IsFixedLength();
            entity.Property(e => e.INTERNAL_LINK_YORN).IsFixedLength();
            entity.Property(e => e.LOGO_DISPLAY_YN).IsFixedLength();
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<BEWEDDING_NAVIGATION>(entity =>
        {
            entity.Property(e => e.DELETE_YORN).IsFixedLength();
            entity.Property(e => e.DISPLAY_YORN).IsFixedLength();
            entity.Property(e => e.INTERNAL_LINK_YORN).IsFixedLength();
        });

        modelBuilder.Entity<BEWEDDING_SOURCE>(entity =>
        {
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<BHANDS_WEEKLY_HOTDEAL>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__BHANDS_W__CA1E3C88E4767BE0");

            entity.ToTable(tb => tb.HasComment("이벤트 핫딜기간 관리"));

            entity.Property(e => e.END_DT).HasComment("종료일");
            entity.Property(e => e.START_DT).HasComment("시작일");
            entity.Property(e => e.W_NUM).HasComment("카드 정렬순서");
        });

        modelBuilder.Entity<BRANCH_MEMBER_OUT>(entity =>
        {
            entity.Property(e => e.ans1).IsFixedLength();
            entity.Property(e => e.ans2).IsFixedLength();
            entity.Property(e => e.ans3).IsFixedLength();
            entity.Property(e => e.ans4).IsFixedLength();
            entity.Property(e => e.ans5).IsFixedLength();
            entity.Property(e => e.ans6).IsFixedLength();
            entity.Property(e => e.ans7).IsFixedLength();
            entity.Property(e => e.reg_date).IsFixedLength();
        });

        modelBuilder.Entity<BRANCH_VISIT_SITE>(entity =>
        {
            entity.HasIndex(e => new { e.VDATE, e.VDOMAIN, e.COMPANY_SEQ }, "IDX_BRANCH_VISIT_SITE")
                .IsUnique()
                .IsClustered();
        });

        modelBuilder.Entity<BSMALL_MAIN_PRODUCT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("바른손몰 메인 페이지 카드 관리"));

            entity.Property(e => e.BRAND_KIND).HasComment("BrandCollection일 경우 사용.");
            entity.Property(e => e.GRADE).HasComment("등급(A/B/C)");
            entity.Property(e => e.GUBUN).HasComment("BC:브랜드컬렉션 , B:BEST , N:NEW , S:SALE");
            entity.Property(e => e.JEHU_VIEW_DIV).IsFixedLength();
            entity.Property(e => e.LINK_TARGET).HasComment("새창사용여부");
            entity.Property(e => e.VIEW_DIV).IsFixedLength();
        });

        modelBuilder.Entity<BestRanking>(entity =>
        {
            entity.Property(e => e.Gubun)
                .IsFixedLength()
                .HasComment("1:주간, 2:월간, 3:샘플구매, 4:찜카드, 5:이용후기");
            entity.Property(e => e.Ranking).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
        });

        modelBuilder.Entity<BestRankingB2B>(entity =>
        {
            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.Ranking).IsFixedLength();
        });

        modelBuilder.Entity<BestRanking_new>(entity =>
        {
            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
        });

        modelBuilder.Entity<Branch_Card_Plan>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Branch_Member>(entity =>
        {
            entity.HasIndex(e => e.uid, "clu_uid")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.jumin, "nind_jumin").HasFillFactor(90);

            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<Branch_QA_Tbl>(entity =>
        {
            entity.Property(e => e.QA_IID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Branch_card_discount_Rate>(entity =>
        {
            entity.Property(e => e.disrate_type).IsFixedLength();
        });

        modelBuilder.Entity<Branch_card_discount_season>(entity =>
        {
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.produce_year).IsFixedLength();
        });

        modelBuilder.Entity<Branch_card_display>(entity =>
        {
            entity.Property(e => e.best_yes_or_no).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
        });

        modelBuilder.Entity<Branch_notice>(entity =>
        {
            entity.Property(e => e.div).IsFixedLength();
        });

        modelBuilder.Entity<Branch_special_discount_rate>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Branch_user_comment>(entity =>
        {
            entity.Property(e => e.IsBest).IsFixedLength();
        });

        modelBuilder.Entity<CALLCENTER_SIGNAL_LAMP_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("콜선터 신호등"));
        });

        modelBuilder.Entity<CARD>(entity =>
        {
            entity.HasKey(e => e.CARD_SEQ).HasName("PK__CARD__79C80F94");

            entity.ToTable(tb =>
            {
                tb.HasComment("Old 카드 정보");
                tb.HasTrigger("CARD_INSERT");
            });

            entity.HasIndex(e => e.CARD_GROUP, "IDX_CARD_CARDGROUP").HasFillFactor(90);

            entity.HasIndex(e => e.CARD_CATEGORY_SEQ, "IDX__CARD__CARD_CATEGORY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.CARD_CODE, "IDX__CARD__CARD_CODE").HasFillFactor(90);

            entity.HasIndex(e => e.CARD_PRICE_CUSTOMER, "IDX__CARD__CARD_PRICE_CUSTOMER").HasFillFactor(90);

            entity.HasIndex(e => new { e.CARD_SEQ, e.CARD_CATEGORY_SEQ }, "IDX_card_seq_card_category_seq").HasFillFactor(90);

            entity.Property(e => e.CARD_SEQ).ValueGeneratedNever();
            entity.Property(e => e.B2B_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.BEST_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.BestRangking).HasComment("월간 판매순위, 아침에 SP가 정보 update시");
            entity.Property(e => e.CARD_CATE).IsFixedLength();
            entity.Property(e => e.CARD_DIV).IsFixedLength();
            entity.Property(e => e.CARD_FPrint).IsFixedLength();
            entity.Property(e => e.CARD_GROUP).HasComment("0:barunson,1:thecard");
            entity.Property(e => e.CARD_KIND).HasComment("1:청첩장,2:감사장,3:초대장");
            entity.Property(e => e.Card_Shape)
                .IsFixedLength()
                .HasComment("카드형태  1: 가로형, 2:세로형, 3:정사각형");
            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.DISRATE_TYPE).IsFixedLength();
            entity.Property(e => e.ISHAVE)
                .IsFixedLength()
                .HasComment("청첩장에서 0 일때는 재고갯수 관리해 줄것.");
            entity.Property(e => e.ISInPaper)
                .IsFixedLength()
                .HasComment("0:속지없음,1:붙이기,2:끼우기,3:금사");
            entity.Property(e => e.Is100).IsFixedLength();
            entity.Property(e => e.Is1001).IsFixedLength();
            entity.Property(e => e.Is1002).IsFixedLength();
            entity.Property(e => e.Is1003)
                .IsFixedLength()
                .HasComment("포토청첩장");
            entity.Property(e => e.Is1004)
                .IsFixedLength()
                .HasComment("이니셜청첩장");
            entity.Property(e => e.Is1005)
                .IsFixedLength()
                .HasComment("");
            entity.Property(e => e.Is1006)
                .IsFixedLength()
                .HasComment("세일청첩장 (티아라카드)");
            entity.Property(e => e.Is1009)
                .IsFixedLength()
                .HasComment("초특가 청첩장 여부");
            entity.Property(e => e.Is200).IsFixedLength();
            entity.Property(e => e.Is300)
                .IsFixedLength()
                .HasComment("회갑,고희,돌");
            entity.Property(e => e.Is3001).IsFixedLength();
            entity.Property(e => e.Is400)
                .IsFixedLength()
                .HasComment("개업인사,초대장");
            entity.Property(e => e.Is500).IsFixedLength();
            entity.Property(e => e.IsColorInpaper).IsFixedLength();
            entity.Property(e => e.IsEmbo).IsFixedLength();
            entity.Property(e => e.IsEnvInsert).IsFixedLength();
            entity.Property(e => e.IsFPrint).IsFixedLength();
            entity.Property(e => e.IsFlower).IsFixedLength();
            entity.Property(e => e.IsFreeEmbo).IsFixedLength();
            entity.Property(e => e.IsFreehandmade).IsFixedLength();
            entity.Property(e => e.IsGold).IsFixedLength();
            entity.Property(e => e.IsHandMade).IsFixedLength();
            entity.Property(e => e.IsHanji).IsFixedLength();
            entity.Property(e => e.IsHeart).IsFixedLength();
            entity.Property(e => e.IsInitial).IsFixedLength();
            entity.Property(e => e.IsOBDisplay).IsFixedLength();
            entity.Property(e => e.IsOffBest).IsFixedLength();
            entity.Property(e => e.IsOffDDisplay).IsFixedLength();
            entity.Property(e => e.IsOffDisplay).IsFixedLength();
            entity.Property(e => e.IsOsiGaro).IsFixedLength();
            entity.Property(e => e.IsRibon).IsFixedLength();
            entity.Property(e => e.IsSBaesong).IsFixedLength();
            entity.Property(e => e.IsSample).IsFixedLength();
            entity.Property(e => e.IsSelfEdit).IsFixedLength();
            entity.Property(e => e.IsSilk).IsFixedLength();
            entity.Property(e => e.IsSpecialThank).IsFixedLength();
            entity.Property(e => e.IsUsrComment)
                .IsFixedLength()
                .HasComment("사용자 코멘트 여부");
            entity.Property(e => e.IsUsrimg1)
                .IsFixedLength()
                .HasComment("사용자 이미지1 업로딩 여부");
            entity.Property(e => e.IsUsrimg2)
                .IsFixedLength()
                .HasComment("사용자 이미지2 업로딩 여부");
            entity.Property(e => e.IsUsrimg3)
                .IsFixedLength()
                .HasComment("사용자 이미지3 업로딩 여부");
            entity.Property(e => e.IsWonang).IsFixedLength();
            entity.Property(e => e.IsYu).IsFixedLength();
            entity.Property(e => e.JUMUN_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.NEW_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.PRODUCE_YEAR).HasComment("0일 경우 단종상품");
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.isButterfly).IsFixedLength();
            entity.Property(e => e.isColorPrt).IsFixedLength();
            entity.Property(e => e.isElegant).IsFixedLength();
            entity.Property(e => e.isHologram).IsFixedLength();
            entity.Property(e => e.isModern).IsFixedLength();
            entity.Property(e => e.isPearl).IsFixedLength();
            entity.Property(e => e.isPress).IsFixedLength();
            entity.Property(e => e.isRomantic).IsFixedLength();
            entity.Property(e => e.isStylish).IsFixedLength();
            entity.Property(e => e.isSweet).IsFixedLength();
            entity.Property(e => e.isTie).IsFixedLength();
            entity.Property(e => e.isTrendy).IsFixedLength();
            entity.Property(e => e.isWinitial).IsFixedLength();
            entity.Property(e => e.online_yes_or_no).IsFixedLength();
        });

        modelBuilder.Entity<CARD_BRAND>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드브랜드"));

            entity.Property(e => e.id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CARD_CATE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드카테고리"));

            entity.Property(e => e.card_cate1).IsFixedLength();
        });

        modelBuilder.Entity<CARD_CATEGORY>(entity =>
        {
            entity.HasKey(e => e.CARD_CATEGORY_SEQ).HasName("PK__CARD_CATEGORY__7BB05806");

            entity.ToTable(tb => tb.HasComment("Old 카드 카테고리"));

            entity.HasIndex(e => e.CATEGORY_NAME, "IDX__CARD_CATEGORY__CARD_CATEGORY_NAME").HasFillFactor(90);

            entity.HasIndex(e => e.CATEGORY_UPPER_CODE, "IDX__CARD_CATEGORY__CATEGORY_UPPER_CODE").HasFillFactor(90);

            entity.Property(e => e.CARD_CATEGORY_SEQ).ValueGeneratedNever();
            entity.Property(e => e.CATEGORY_DIV).IsFixedLength();
            entity.Property(e => e.CATEGORY_USED).IsFixedLength();
            entity.Property(e => e.SAMPLE_SUPPLY).IsFixedLength();
        });

        modelBuilder.Entity<CARD_COREL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드코렐정보관리"));

            entity.Property(e => e.card_code).HasComment("제품코드");
            entity.Property(e => e.AUTO_CHOAN_REGISTER_YORN).IsFixedLength();
            entity.Property(e => e.AUTO_CHOAN_YORN)
                .IsFixedLength()
                .HasComment("자동초안템플릿여부");
            entity.Property(e => e.BOTH_SIDE_YORN).IsFixedLength();
            entity.Property(e => e.BlankSpace).HasComment("코렐 병합시 밑단 공백 크기");
            entity.Property(e => e.CUTTING_LINE_DIRECTION).IsFixedLength();
            entity.Property(e => e.FPrintX).HasComment("카드 앞면 인쇄위치 X");
            entity.Property(e => e.FPrintY).HasComment("카드 앞면 인쇄위치 Y");
            entity.Property(e => e.GBFont).HasComment("신랑,신부 폰트체");
            entity.Property(e => e.GBFontSize1).HasComment("신랑,신부 부모님 폰트체");
            entity.Property(e => e.GBFontSize2).HasComment("신랑,신부 서열 폰트체");
            entity.Property(e => e.GBFontSize3).HasComment("신랑,신부 폰트체");
            entity.Property(e => e.GBX).HasComment("신랑,신부 인쇄위치 X");
            entity.Property(e => e.GBY).HasComment("신랑,신부 인쇄위치 Y");
            entity.Property(e => e.GreetFont).HasComment("인사말 폰트체");
            entity.Property(e => e.GreetFontSize).HasComment("인사말 폰트 사이즈");
            entity.Property(e => e.GreetX).HasComment("인사말 인쇄위치 X");
            entity.Property(e => e.GreetY).HasComment("인사말 인쇄위치 Y");
            entity.Property(e => e.Hstandard).HasComment("최저높이");
            entity.Property(e => e.HstandardMax).HasComment("최고높이");
            entity.Property(e => e.INNER_WORK_YORN).IsFixedLength();
            entity.Property(e => e.IsAlbaDown).IsFixedLength();
            entity.Property(e => e.IsExPreview)
                .IsFixedLength()
                .HasComment("사용안함");
            entity.Property(e => e.IsFPrint)
                .IsFixedLength()
                .HasComment("카드 앞면 인쇄 여부");
            entity.Property(e => e.IsInpaperBothSide).IsFixedLength();
            entity.Property(e => e.IsMapFront)
                .IsFixedLength()
                .HasComment("약도 카드 앞면 삽입 여부");
            entity.Property(e => e.IsMapGaro)
                .IsFixedLength()
                .HasComment("약도 가로형 여부");
            entity.Property(e => e.Lstandard).HasComment("왼쪽 기준선");
            entity.Property(e => e.Rstandard).HasComment("오른쪽기준선");
            entity.Property(e => e.Vstandard).HasComment("세로기준");
            entity.Property(e => e.WEPOD_YORN).IsFixedLength();
            entity.Property(e => e.WhenFont).HasComment("예식 일시 폰트체");
            entity.Property(e => e.WhenFontSize).HasComment("예식 일시 폰트 사이즈");
            entity.Property(e => e.WhenX).HasComment("예식 일시 위치 X");
            entity.Property(e => e.WhenY).HasComment("예식 일시 위치 Y");
            entity.Property(e => e.WhereFont).HasComment("예식 장소 폰트체");
            entity.Property(e => e.WhereFontSize).HasComment("예식 장소 폰트 사이즈");
            entity.Property(e => e.WhereY).HasComment("예식 장소 인쇄위치 Y");
            entity.Property(e => e.card_type)
                .IsFixedLength()
                .HasComment("C:카드,I:내지, E:봉투");
            entity.Property(e => e.env_num).HasComment("사용안함");
            entity.Property(e => e.guideLineH).HasComment("가이드라인(가로)");
            entity.Property(e => e.guideLineV).HasComment("가이드라인(세로)");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isBackColor)
                .IsFixedLength()
                .HasComment("카드 속면 배경 삽입 여부");
            entity.Property(e => e.isBackPoint)
                .IsFixedLength()
                .HasComment("카드 속면 코렐 연동 방식(1일 경우 위치 지정)");
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isFBackColor)
                .IsFixedLength()
                .HasComment("카드 앞면 배경 삽입 여부");
            entity.Property(e => e.isOsiGaro)
                .IsFixedLength()
                .HasComment("코렐 병합시 접선 방식");
            entity.Property(e => e.isReverse)
                .IsFixedLength()
                .HasComment("코렐 병합시 역방향 여부");
            entity.Property(e => e.mapPositionX).HasComment("약도 삽입위치 X");
            entity.Property(e => e.mapPositionY).HasComment("약도 삽입위치 Y");
            entity.Property(e => e.osiH).HasComment("카드 가로접선");
            entity.Property(e => e.osiV).HasComment("카드 세로접선");
            entity.Property(e => e.pageSizeH).HasComment("카드세로크기");
            entity.Property(e => e.pageSizeW).HasComment("카드가로크기");
            entity.Property(e => e.print_size).HasComment("코렐 병합시 용지 사이즈");
        });

        modelBuilder.Entity<CARD_ChoanBasic>(entity =>
        {
            entity.Property(e => e.card_type).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isBackColor).IsFixedLength();
            entity.Property(e => e.isBackPoint).IsFixedLength();
            entity.Property(e => e.isFBackColor).IsFixedLength();
            entity.Property(e => e.isMapGaro).IsFixedLength();
            entity.Property(e => e.isOsiGaro).IsFixedLength();
            entity.Property(e => e.isReverse).IsFixedLength();
        });

        modelBuilder.Entity<CARD_DISCOUNT_RATE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("OLD 카드 할인율 정보"));

            entity.Property(e => e.card_Group).IsFixedLength();
            entity.Property(e => e.card_kind)
                .IsFixedLength()
                .HasComment("disrate_type=P 일때 카드 가격,I일때는 카드 키값");
            entity.Property(e => e.discount_rate).HasComment("할인율");
            entity.Property(e => e.disrate_type)
                .IsFixedLength()
                .HasComment("I:카드 개별 할인율,P:가격대별 할인율");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.max_count).HasComment("미만");
            entity.Property(e => e.min_count).HasComment("이상");
        });

        modelBuilder.Entity<CARD_DISCOUNT_RATE_WED>(entity =>
        {
            entity.Property(e => e.card_group).IsFixedLength();
            entity.Property(e => e.card_kind).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
        });

        modelBuilder.Entity<CARD_DISPLAY_POLICY>(entity =>
        {
            entity.HasOne(d => d.CATEGORY_SEQNavigation).WithMany(p => p.CARD_DISPLAY_POLICY)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CARD_DISP__CATEG__1B5E0D89");
        });

        modelBuilder.Entity<CARD_Dev>(entity =>
        {
            entity.Property(e => e.B2B_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.BEST_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.CARD_CATE).IsFixedLength();
            entity.Property(e => e.CARD_FPrint).IsFixedLength();
            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.DISRATE_TYPE).IsFixedLength();
            entity.Property(e => e.ISHAVE).IsFixedLength();
            entity.Property(e => e.ISInPaper).IsFixedLength();
            entity.Property(e => e.Is100).IsFixedLength();
            entity.Property(e => e.Is1001).IsFixedLength();
            entity.Property(e => e.Is1002).IsFixedLength();
            entity.Property(e => e.Is1003).IsFixedLength();
            entity.Property(e => e.Is1004).IsFixedLength();
            entity.Property(e => e.Is1005).IsFixedLength();
            entity.Property(e => e.Is1009).IsFixedLength();
            entity.Property(e => e.Is200).IsFixedLength();
            entity.Property(e => e.Is300).IsFixedLength();
            entity.Property(e => e.Is400).IsFixedLength();
            entity.Property(e => e.Is500).IsFixedLength();
            entity.Property(e => e.IsEmbo).IsFixedLength();
            entity.Property(e => e.IsEnvInsert).IsFixedLength();
            entity.Property(e => e.IsFPrint).IsFixedLength();
            entity.Property(e => e.IsFlower).IsFixedLength();
            entity.Property(e => e.IsGold).IsFixedLength();
            entity.Property(e => e.IsHandMade).IsFixedLength();
            entity.Property(e => e.IsHanji).IsFixedLength();
            entity.Property(e => e.IsHeart).IsFixedLength();
            entity.Property(e => e.IsOBDisplay).IsFixedLength();
            entity.Property(e => e.IsOffBest).IsFixedLength();
            entity.Property(e => e.IsOffDDisplay).IsFixedLength();
            entity.Property(e => e.IsOffDisplay).IsFixedLength();
            entity.Property(e => e.IsOsiGaro).IsFixedLength();
            entity.Property(e => e.IsRibon).IsFixedLength();
            entity.Property(e => e.IsSBaesong).IsFixedLength();
            entity.Property(e => e.IsSample).IsFixedLength();
            entity.Property(e => e.IsSilk).IsFixedLength();
            entity.Property(e => e.IsUsrComment).IsFixedLength();
            entity.Property(e => e.IsUsrimg1).IsFixedLength();
            entity.Property(e => e.IsUsrimg2).IsFixedLength();
            entity.Property(e => e.IsUsrimg3).IsFixedLength();
            entity.Property(e => e.IsWonang).IsFixedLength();
            entity.Property(e => e.IsYu).IsFixedLength();
            entity.Property(e => e.NEW_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.online_yes_or_no).IsFixedLength();
        });

        modelBuilder.Entity<CARD_ENV>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("봉투정보"));
        });

        modelBuilder.Entity<CARD_ISHAVE_HISTORY>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_CARD_ISHAVE_CHANGE");
        });

        modelBuilder.Entity<CARD_JAEGO_HISTORY>(entity =>
        {
            entity.HasIndex(e => e.card_code, "IX_CARD_JAEGO_HISTORY").HasFillFactor(90);
        });

        modelBuilder.Entity<CARD_SEASON_IMAGE_STR>(entity =>
        {
            entity.HasKey(e => e.card_seq).HasName("PK_CARD_IMAGE_STR_1");

            entity.ToTable(tb => tb.HasComment("CARD_SEASON_IMAGE_STR"));

            entity.Property(e => e.card_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CARD_SEASON_STYLE>(entity =>
        {
            entity.HasIndex(e => e.card_seq, "IDX_CARD_SEASON_STYLE__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.cardstyle_seq, "IDX_CARD_SEASON_STYLE_cardstyle_seq").HasFillFactor(90);
        });

        modelBuilder.Entity<CARD_SEASON_STYLEITEM>(entity =>
        {
            entity.Property(e => e.cardstyle_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CARD_SET>(entity =>
        {
            entity.Property(e => e.set_Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CARD_SETItem>(entity =>
        {
            entity.HasKey(e => new { e.set_seq, e.card_seq }).HasName("PK_CARD_SETLIST");
        });

        modelBuilder.Entity<CARD_STYLE>(entity =>
        {
            entity.Property(e => e.style_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CARD_USER_COMMNET>(entity =>
        {
            entity.HasKey(e => new { e.CARD_SEQ, e.CMT_SEQ })
                .HasName("PK__CARD_USER_COMMNE__7F80E8EA")
                .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("Old 유저 코멘트"));

            entity.HasIndex(e => e.REGDATE, "clu_REGDATE")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "nind_company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.MEMBER_UID, "nind_member_uid").HasFillFactor(90);

            entity.Property(e => e.CMT_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.DIV).IsFixedLength();
            entity.Property(e => e.IsBest).IsFixedLength();
            entity.Property(e => e.IsDP).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
        });

        modelBuilder.Entity<CARD_VSTAT>(entity =>
        {
            entity.Property(e => e.card_type).IsFixedLength();
        });

        modelBuilder.Entity<CARD_WEIGHT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("FAQ무게검증기초데이터관련"));

            entity.Property(e => e.card_weight1).HasComment("단위무게");
            entity.Property(e => e.mod_date).HasComment("수정일");
            entity.Property(e => e.reg_date).HasComment("등록일");
        });

        modelBuilder.Entity<CARD_corelinfo>(entity =>
        {
            entity.HasKey(e => e.id).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("카드초안기초상세정보"));

            entity.HasIndex(e => e.card_code, "IX_CARD_corelinfo")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.card_code).HasComment("카드 코드");
            entity.Property(e => e.font_name).HasComment("폰트명");
            entity.Property(e => e.font_size).HasComment("폰트사이즈");
            entity.Property(e => e.isFPrint)
                .IsFixedLength()
                .HasComment("1이면 겉면에 인쇄");
            entity.Property(e => e.mod_date).HasComment("변경일");
            entity.Property(e => e.point_align).HasComment("0:좌측, 9:중앙, 8:우측");
            entity.Property(e => e.point_str).HasComment("입력문구 뿌려줘야 할 경우 해당 스트링");
            entity.Property(e => e.point_type).HasComment("0:약도,1:영문이름,2:한글이름,3:영문이니셜,4:영문+한글이름,5:예식일,9:기타,");
            entity.Property(e => e.point_x).HasComment("포인트 X값");
            entity.Property(e => e.point_y).HasComment("포인트 Y값");
        });

        modelBuilder.Entity<CART>(entity =>
        {
            entity.HasKey(e => e.CART_SEQ).HasName("PK__CART__035179CE");

            entity.HasIndex(e => new { e.CART_OWNER, e.OWNER_SESSION_ID }, "IDX__CART__CART_OWNER_OWNER_IP").HasFillFactor(90);

            entity.Property(e => e.ORDER_TYPE)
                .IsFixedLength()
                .HasComment("S:샘플");
        });

        modelBuilder.Entity<CASAMIA_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__CASAMIA___DDDFBCBE03B2DCE5");
        });

        modelBuilder.Entity<CHOAN_CALENDAR_ITEM>(entity =>
        {
            entity.Property(e => e.OBJ_CODE).IsFixedLength();
        });

        modelBuilder.Entity<CHOAN_CORELDRAW_ITEM>(entity =>
        {
            entity.Property(e => e.OBJ_CODE).IsFixedLength();
        });

        modelBuilder.Entity<CHOAN_OBJECT_COMMON_CODE>(entity =>
        {
            entity.Property(e => e.OBJ_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<CJ_DELCODE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("CJ 송장코드"));

            entity.Property(e => e.DELCODE_SEQ)
                .ValueGeneratedNever()
                .HasComment("");
            entity.Property(e => e.API_YN).IsFixedLength();
            entity.Property(e => e.CODE).HasComment("송장번호");
            entity.Property(e => e.CODESEQ).HasComment("");
            entity.Property(e => e.ISUSE)
                .IsFixedLength()
                .HasComment("사용유무 (0:사용안함, 1:사용완료)");
            entity.Property(e => e.IS_USE).HasComment("");
        });

        modelBuilder.Entity<CJ_DELCODE_ERROR>(entity =>
        {
            entity.Property(e => e.code).IsFixedLength();
        });

        modelBuilder.Entity<CJ_DELCODE_TEMP>(entity =>
        {
            entity.HasKey(e => e.DELCODE_SEQ).HasName("PK_CJ_DELCODE_20110814_TEMP");

            entity.Property(e => e.ISUSE).IsFixedLength();
        });

        modelBuilder.Entity<CJ_DELCODE_UPDATE>(entity =>
        {
            entity.Property(e => e.flag).IsFixedLength();
            entity.Property(e => e.ncode).IsFixedLength();
            entity.Property(e => e.pcode).IsFixedLength();
        });

        modelBuilder.Entity<CJ_DELCODE_USAGE_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("송장코드 사용로그"));

            entity.Property(e => e.DELIVERY_CODE_NUM).HasComment("송장번호");
            entity.Property(e => e.ORDER_SEQ).HasComment("주문번호");
            entity.Property(e => e.REG_DATE).HasComment("등록일");
        });

        modelBuilder.Entity<CJ_ZIPCODE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초안 택배 소속 정보"));

            entity.Property(e => e.CLDV_EMP_NM).HasComment("배송담당자");
            entity.Property(e => e.DONG_ADDR).HasComment("동");
            entity.Property(e => e.MAN_BRAN_NM).HasComment("소속");
            entity.Property(e => e.MODI_DTIME).HasComment("수정일");
            entity.Property(e => e.MODI_EMP_ID).HasComment("PR_RSPSDIV");
            entity.Property(e => e.MODI_YMD).HasComment("수정일(YYYYMMDD)");
            entity.Property(e => e.REG_DTIME).HasComment("등록일");
            entity.Property(e => e.REG_EMP_ID).HasComment("PR_RSPSDIV");
            entity.Property(e => e.SIDO_ADDR).HasComment("시");
            entity.Property(e => e.SKK_ADDR).HasComment("구");
            entity.Property(e => e.UP_BRAN_NM).HasComment("지점");
        });

        modelBuilder.Entity<CMS_LOG>(entity =>
        {
            entity.HasIndex(e => e.info1, "nind_info1").HasFillFactor(90);
        });

        modelBuilder.Entity<COMMON_CODE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("코드 관리"));

            entity.Property(e => e.CMMN_CODE).IsFixedLength();
            entity.Property(e => e.CLSS_CODE).IsFixedLength();
            entity.Property(e => e.DISPLAY_YORN).IsFixedLength();
            entity.Property(e => e.DTL_CLSS).IsFixedLength();
            entity.Property(e => e.LANG_CODE).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<COMPANY>(entity =>
        {
            entity.HasKey(e => e.COMPANY_SEQ).HasName("PK__COMPANY__07220AB2");

            entity.ToTable(tb =>
            {
                tb.HasComment("제휴사 정보");
                tb.HasTrigger("COMPANY_INSERT");
            });

            entity.HasIndex(e => e.COMPANY_NAME, "IDX_company__name").HasFillFactor(90);

            entity.HasIndex(e => e.SALES_GUBUN, "NCI_COMPANY_SALES_GUBUN").HasFillFactor(90);

            entity.Property(e => e.ACCOUNT_NO).HasComment("정산은행 계좌번호");
            entity.Property(e => e.ACC_E_MAIL).HasComment("정산담당자 이메일");
            entity.Property(e => e.ACC_HP_NO).HasComment("정산담당자 핸드폰 번호");
            entity.Property(e => e.ACC_NM).HasComment("정산담당자 이름");
            entity.Property(e => e.ACC_TEL_NO).HasComment("정산담당자 연락처");
            entity.Property(e => e.BACK_ADDR).HasComment("주소 뒷부분");
            entity.Property(e => e.BANK_NM).HasComment("정산은행이름");
            entity.Property(e => e.BOSS_NM).HasComment("대표자 이름");
            entity.Property(e => e.BOSS_TEL_NO).HasComment("대표 번호");
            entity.Property(e => e.CHG_DT).HasComment("최종 변경일");
            entity.Property(e => e.CHG_ID).HasComment("변경 관리자 아이디");
            entity.Property(e => e.COMPANY_NAME).HasComment("업체명");
            entity.Property(e => e.COMPANY_NUM).HasComment("사업자 번호");
            entity.Property(e => e.END_DATE).HasComment("마감일");
            entity.Property(e => e.ERP_Dept)
                .IsFixedLength()
                .HasComment("1: 영업1본부, 2: 영업2본부");
            entity.Property(e => e.ERP_PGcheck)
                .IsFixedLength()
                .HasComment("");
            entity.Property(e => e.ERP_PayLater)
                .IsFixedLength()
                .HasComment("Y:후불정산업체");
            entity.Property(e => e.ERP_PriceLevel)
                .IsFixedLength()
                .HasComment("1:대리점가,2:출고가,3:소비자가");
            entity.Property(e => e.ERP_TaxType)
                .IsFixedLength()
                .HasComment("10 : 일반과세, 22: 매출영수증");
            entity.Property(e => e.E_MAIL).HasComment("이메일");
            entity.Property(e => e.FAX_NO).HasComment("업체 팩스번호");
            entity.Property(e => e.FIRST_ALARM).IsFixedLength();
            entity.Property(e => e.FRONT_ADDR).HasComment("주소 앞부분");
            entity.Property(e => e.IMG_DIR).HasComment("사용안함");
            entity.Property(e => e.INFO_TMP).HasComment("대리점의 경우 업체 URL");
            entity.Property(e => e.INFO_TMP3).HasComment("메인 이미지");
            entity.Property(e => e.INFO_TMP4).HasComment("1일 경우 무료식권 제공");
            entity.Property(e => e.JAEHU_KIND).HasComment("W:웹,D:대리점,O:오프영업,M:EC대리점,C:EC 커스터마이징,B:EC B2B,E:e청첩장");
            entity.Property(e => e.JUMUN_TYPE)
                .IsFixedLength()
                .HasComment("0:기본값(사이트링크),1:결제안함(제휴사매출),2:결제함(바른손매출)");
            entity.Property(e => e.LOGIN_ID).HasComment("로그인 아이디");
            entity.Property(e => e.MNG_E_MAIL).HasComment("관리자 이메일");
            entity.Property(e => e.MNG_NM).HasComment("관리자 이름");
            entity.Property(e => e.MNG_TEL_NO).HasComment("관리자 연락처");
            entity.Property(e => e.ONOFF)
                .IsFixedLength()
                .HasComment("온/오프 제휴");
            entity.Property(e => e.PASSWD).HasComment("비밀번호");
            entity.Property(e => e.REGIST_DATE).HasComment("등록일");
            entity.Property(e => e.REG_ID).HasComment("등록 관리자 아이디");
            entity.Property(e => e.SALES_GUBUN).HasComment("W:웹,D:대리점,O:오프영업");
            entity.Property(e => e.SASIK_GUBUN).IsFixedLength();
            entity.Property(e => e.START_DATE).HasComment("시작일");
            entity.Property(e => e.STATUS).HasComment("상태 (S1:대기,S2:진행,S3:삭제)");
            entity.Property(e => e.SUPPLY_DISRATE).HasComment("기본 할인율");
            entity.Property(e => e.UP_TAE).HasComment("업태 (ERP 연동시 tax 타입으로 사용,22:매출영수증,10:매출일반과세)");
            entity.Property(e => e.ZIP_CODE).HasComment("우편번호");
            entity.Property(e => e.mypage_url).HasComment("고객에게 발송되는 메일에서 링크될 mypage주소");
        });

        modelBuilder.Entity<COMPANY_Nanum_History>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("나눔 히스토리"));
        });

        modelBuilder.Entity<COMPANY_Nanum_Price>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("나눔 가격"));
        });

        modelBuilder.Entity<COMPETITOR_CARD_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("타사이트 카드정보"));

            entity.HasIndex(e => e.REG_DATE, "NCI_REG_DATE").HasFillFactor(90);
        });

        modelBuilder.Entity<CONNECT>(entity =>
        {
            entity.Property(e => e.idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CONNECT_PATH>(entity =>
        {
            entity.Property(e => e.idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CONTRACT_TBL>(entity =>
        {
            entity.Property(e => e.CON_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<COOP_DISCOUNT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("제휴 할인"));

            entity.Property(e => e.cardbrand).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
        });

        modelBuilder.Entity<COOP_VSTAT>(entity =>
        {
            entity.Property(e => e.inout)
                .IsFixedLength()
                .HasComment("0:in, 1:out");
        });

        modelBuilder.Entity<COUPON>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_coupon_Test");

            entity.ToTable(tb => tb.HasComment("old 쿠폰"));

            entity.HasIndex(e => e.code, "nind_code").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "nind_company_seq").HasFillFactor(90);

            entity.Property(e => e.discount_type)
                .IsFixedLength()
                .HasComment("R:할인율, P:금액차감");
            entity.Property(e => e.isJaehu)
                .IsFixedLength()
                .HasComment("1:제휴사 발행 쿠폰");
            entity.Property(e => e.isUsable).IsFixedLength();
            entity.Property(e => e.isUse).IsFixedLength();
            entity.Property(e => e.use_type)
                .IsFixedLength()
                .HasComment("W:청첩장,E:e청첩장");
        });

        modelBuilder.Entity<COUPON_APPLY_CARD>(entity =>
        {
            entity.HasKey(e => e.COUPON_APPLY_CARD_SEQ).HasName("PK_COUPON_APPLY_CARD_LIST");

            entity.ToTable(tb => tb.HasComment("일부상품적용제외리스트"));

            entity.Property(e => e.COUPON_APPLY_CARD_SEQ).HasComment("SEQ");
            entity.Property(e => e.CARD_ALLOW_YN).HasComment("상품허용구분(N:제외,Y:등록)");
            entity.Property(e => e.CARD_SEQ).HasComment("카드코드(S2_CARD.CARD_SEQ)");
            entity.Property(e => e.COUPON_MST_SEQ).HasComment("COUPON_MST.COUPON_MST_SEQ");

            entity.HasOne(d => d.COUPON_MST_SEQNavigation).WithMany(p => p.COUPON_APPLY_CARD)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_APPLY_CARD_LIST_COUPON_MST_SEQ_COUPON_MST_COUPON_MST_SEQ");
        });

        modelBuilder.Entity<COUPON_APPLY_SERVICE>(entity =>
        {
            entity.HasKey(e => e.COUPON_APPLY_SERVICE_SEQ).HasName("PK_COUPON_APPLY_SERVICE_LIST");

            entity.ToTable(tb => tb.HasComment("적용상품범위"));

            entity.Property(e => e.COUPON_APPLY_SERVICE_SEQ).HasComment("SEQ");
            entity.Property(e => e.CLSS_CODE).HasComment("그룹코드(COMMON_CODE.CLSS_CODE)");
            entity.Property(e => e.CMMN_CODE).HasComment("상세코드(COMMON_CODE.CMMN_CODE)");
            entity.Property(e => e.COUPON_MST_SEQ).HasComment("COUPON_MST.COUPON_MST_SEQ");

            entity.HasOne(d => d.COUPON_MST_SEQNavigation).WithMany(p => p.COUPON_APPLY_SERVICE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_APPLY_SERVICE_LIST_COUPON_MST_SEQ_COUPON_MST_COUPON_MST_SEQ");
        });

        modelBuilder.Entity<COUPON_APPLY_SITE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰 발급 사이트"));

            entity.Property(e => e.COUPON_APPLY_SITE_SEQ).HasComment("SEQ");
            entity.Property(e => e.COMPANY_SEQ).HasComment("COMPANY_SEQ");
            entity.Property(e => e.COUPON_MST_SEQ).HasComment("COUPON_MST.COUPON_MST_SEQ");

            entity.HasOne(d => d.COUPON_MST_SEQNavigation).WithMany(p => p.COUPON_APPLY_SITE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_APPLY_SITE_COUPON_MST_SEQ_COUPON_MST_COUPON_MST_SEQ");
        });

        modelBuilder.Entity<COUPON_APPLY_USER>(entity =>
        {
            entity.HasKey(e => e.COUPON_APPLY_USER_SEQ).HasName("PK_COUPON_APPLY_USER_LIST");

            entity.ToTable(tb => tb.HasComment("회원제외추가리스트"));

            entity.Property(e => e.COUPON_APPLY_USER_SEQ).HasComment("SEQ");
            entity.Property(e => e.COUPON_MST_SEQ).HasComment("COUPON_MST.COUPON_MST_SEQ");
            entity.Property(e => e.UID).HasComment("UID");
            entity.Property(e => e.USER_ALLOW_YN).HasComment("회원허구분(N:제외,Y:등록)");

            entity.HasOne(d => d.COUPON_MST_SEQNavigation).WithMany(p => p.COUPON_APPLY_USER)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_APPLY_USER_LIST_COUPON_MST_SEQ_COUPON_MST_COUPON_MST_SEQ");
        });

        modelBuilder.Entity<COUPON_DETAIL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰코드정보"));

            entity.HasIndex(e => e.COUPON_CODE, "NCI_COUPON_CODE").HasFillFactor(90);

            entity.HasIndex(e => e.COUPON_MST_SEQ, "NCI_COUPON_MST_SEQ").HasFillFactor(90);

            entity.Property(e => e.COUPON_DETAIL_SEQ).HasComment("SEQ");
            entity.Property(e => e.COUPON_CODE).HasComment("쿠폰코드");
            entity.Property(e => e.COUPON_MST_SEQ).HasComment("COUPON_MST.COUPON_MST_SEQ");
            entity.Property(e => e.DOWNLOAD_ACTIVE_YN).HasComment("다운로드가능여부(Y/N)");

            entity.HasOne(d => d.COUPON_MST_SEQNavigation).WithMany(p => p.COUPON_DETAIL)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_DETAIL_COUPON_MST_SEQ_COUPON_MST_COUPON_MST_SEQ");
        });

        modelBuilder.Entity<COUPON_ISSUE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰발급리스트"));

            entity.HasIndex(e => e.ACTIVE_YN, "NCI_ACTIVE_YN").HasFillFactor(90);

            entity.HasIndex(e => e.COUPON_DETAIL_SEQ, "NCI_COUPON_DETAIL_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.UID, "NCI_UID").HasFillFactor(90);

            entity.HasIndex(e => new { e.UID, e.ACTIVE_YN }, "NCI_UID_ACTIVE_YN").HasFillFactor(90);

            entity.Property(e => e.COUPON_ISSUE_SEQ).HasComment("SEQ");
            entity.Property(e => e.ACTIVE_YN).HasComment("사용가능여부(Y/N)");
            entity.Property(e => e.COMPANY_SEQ).HasComment("COMPANY_SEQ");
            entity.Property(e => e.COUPON_DETAIL_SEQ).HasComment("COUPON_DETAIL.COUPON_DETAIL_SEQ");
            entity.Property(e => e.END_DATE).HasComment("종료일");
            entity.Property(e => e.REG_DATE).HasComment("등록일");
            entity.Property(e => e.SALES_GUBUN).HasComment("사이트구분");
            entity.Property(e => e.UID).HasComment("유저ID");

            entity.HasOne(d => d.COUPON_DETAIL_SEQNavigation).WithMany(p => p.COUPON_ISSUE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COUPON_ISSUE_COUPON_DETAIL_SEQ_COUPON_DETAIL_COUPON_DETAIL_SEQ");
        });

        modelBuilder.Entity<COUPON_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쿠폰마스터 정보"));

            entity.Property(e => e.COUPON_MST_SEQ).HasComment("SEQ");
            entity.Property(e => e.CARD_ORDER_CNT).HasComment("청첩장 주문 구매수");
            entity.Property(e => e.CARD_ORDER_TYPE).HasComment("청첩장주문여부");
            entity.Property(e => e.COUPON_DESC).HasComment("쿠폰설명(안내문구)");
            entity.Property(e => e.COUPON_GROUP_CODE).HasComment("쿠폰종류(A:기본 B:중복,그오 )");
            entity.Property(e => e.COUPON_ISSUE_CNT).HasComment("발행개수(0:무제한)");
            entity.Property(e => e.COUPON_ISSUE_END_DATE).HasComment("발행기간 종료일");
            entity.Property(e => e.COUPON_ISSUE_START_DATE).HasComment("발행기간 시작일");
            entity.Property(e => e.COUPON_NAME).HasComment("쿠폰명");
            entity.Property(e => e.COUPON_TYPE_CODE).HasComment("쿠폰속성(A:기본 B:중복 C:중중복)");
            entity.Property(e => e.DISCOUNT_FIXED_RATE_TYPE).HasComment("할인방법(W:정액, P:정률)");
            entity.Property(e => e.DISCOUNT_MAX_AMT).HasComment("최대할인금액(0:제한없음)");
            entity.Property(e => e.DISCOUNT_VALUE).HasComment("할인값");
            entity.Property(e => e.DOWNLOADED_CNT).HasComment("다운로드된 수량");
            entity.Property(e => e.DOWNLOAD_KIND).HasComment("발급방식(M:수동, A:자동)");
            entity.Property(e => e.DOWNLOAD_LIMIT_PER_PERSON_QTY).HasComment("다운로드 개인별 제한수량(0:제한없음)");
            entity.Property(e => e.DOWNLOAD_USER_GB).HasComment("발급대상(A:전체, P:특정[COUPON_APPLY_USER])");
            entity.Property(e => e.DUP_COUPON_ALLOW_YN).HasComment("중복허용여부(Y:가능,N:불가능)");
            entity.Property(e => e.EXPIRY_CUSTOM_VALUE).HasComment("가변종료일(발급일로부터의 유효기간)");
            entity.Property(e => e.EXPIRY_END_DATE).HasComment("다운로드 종료일");
            entity.Property(e => e.EXPIRY_START_DATE).HasComment("다운로드 시작일");
            entity.Property(e => e.EXPIRY_TYPE).HasComment("쿠폰유효기간(A:없음, V:가변, P:기간)");
            entity.Property(e => e.ORDER_AMT).HasComment("구매제한금액(0:제한없음)");
            entity.Property(e => e.ORDER_APPLY_TYPE).HasComment("적용가능주문형태(O:원주문 A:추가주무)");
            entity.Property(e => e.REFERER_SALES_GUBUN).HasComment("가입SITE(구분자:| REFERER_SALES_GUBUN)");
            entity.Property(e => e.REG_DATE).HasComment("등록일");
            entity.Property(e => e.REG_USER_ID).HasComment("등록자");
            entity.Property(e => e.SAMPLE_ORDER_END_DATE).HasComment("샘플주문 종료일");
            entity.Property(e => e.SAMPLE_ORDER_START_DATE).HasComment("샘플주문 시작일(CUSTOM_SAMPLE_ORDER.REQUEST_DATE)");
            entity.Property(e => e.SAMPLE_ORDER_TYPE).HasComment("샘플주문여부");
            entity.Property(e => e.UPDATE_DATE).HasComment("수정일");
            entity.Property(e => e.UPDATE_USER_ID).HasComment("수정자");
            entity.Property(e => e.USER_REG_END_DATE).HasComment("가입일 종료");
            entity.Property(e => e.USER_REG_START_DATE).HasComment("가입일 시작");
            entity.Property(e => e.USE_DEVICE).HasComment("사용가능디바이스(P:PC, M:모바일)");
            entity.Property(e => e.USE_PLACE).HasComment("사용처(ALL :전체, ON:온라인, OFF:오프라인)");
            entity.Property(e => e.WEDDING_END_DATE).HasComment("결혼예정 종료일");
            entity.Property(e => e.WEDDING_START_DATE).HasComment("결혼예정 시작일");
            entity.Property(e => e.WEDD_PLACE).HasComment("예식지역(구분자 : | )");
        });

        modelBuilder.Entity<CS_HappyCall>(entity =>
        {
            entity.HasKey(e => e.idx).HasName("PK_MASTER");
        });

        modelBuilder.Entity<CUCKOOS_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__CUCKOOS___DDDFBCBEB08E874F");
        });

        modelBuilder.Entity<CUSTOM_CARD_DISPLAY_POLICY>(entity =>
        {
            entity.HasKey(e => new { e.CATEGORY_SEQ, e.CARD_SEQ }).HasName("PK__CUSTOM_CARD_DISP__5224328E");

            entity.HasOne(d => d.CATEGORY_SEQNavigation).WithMany(p => p.CUSTOM_CARD_DISPLAY_POLICY)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOM_CA__CATEG__1F2E9E6D");
        });

        modelBuilder.Entity<CUSTOM_CART_SP>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("OLD 장바구니"));

            entity.HasIndex(e => e.CARD_SEQ, "nind_card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.MEMBER_ID, "nind_member_id").HasFillFactor(90);

            entity.Property(e => e.ishave).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<CUSTOM_ETC_ORDER>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_CUSTOM_ETC_ORDER_1");

            entity.ToTable(tb => tb.HasComment("부가상품주문내역"));

            entity.HasIndex(e => e.order_g_seq, "IDX_CUSTOM_ETC_ORDER_G_SEQ").HasFillFactor(90);

            entity.HasIndex(e => new { e.member_id, e.order_type }, "custom_etc_order_ccg").HasFillFactor(90);

            entity.HasIndex(e => e.member_id, "custom_etc_order_memid").HasFillFactor(90);

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.card_nointyn).IsFixedLength();
            entity.Property(e => e.coupon_price).HasComment("쿠폰차감금액");
            entity.Property(e => e.couponseq).HasComment("쿠폰번호");
            entity.Property(e => e.delivery_code).HasComment("송장코드");
            entity.Property(e => e.delivery_com)
                .IsFixedLength()
                .HasComment("배송업체");
            entity.Property(e => e.delivery_date).HasComment("배송일자");
            entity.Property(e => e.delivery_method)
                .IsFixedLength()
                .HasComment("배송방법");
            entity.Property(e => e.delivery_price).HasComment("배송비");
            entity.Property(e => e.isAscrow).IsFixedLength();
            entity.Property(e => e.isHJ).IsFixedLength();
            entity.Property(e => e.isReceipt)
                .IsFixedLength()
                .HasComment("영수증발급여부");
            entity.Property(e => e.option_price).HasComment("옵션선택비용");
            entity.Property(e => e.order_email).HasComment("주문자 이메일");
            entity.Property(e => e.order_g_seq).HasComment("더카드전용 통합SEQ");
            entity.Property(e => e.order_hphone).HasComment("주문자 핸드폰번호");
            entity.Property(e => e.order_name).HasComment("주문자 이름");
            entity.Property(e => e.order_phone).HasComment("주문자 전화번호");
            entity.Property(e => e.order_type).HasComment("manage_code.code (code_type =etcprod)");
            entity.Property(e => e.pg_receipt_tid).HasComment("영수증발급ID");
            entity.Property(e => e.pg_resultinfo).HasComment("결제결과-결제정보");
            entity.Property(e => e.pg_resultinfo2).HasComment("결제결과-결제자명");
            entity.Property(e => e.pg_shopid).HasComment("데이콤 PG아이디");
            entity.Property(e => e.pg_tid).HasComment("데이콤 주문번호 or 이니시스 연동 TID");
            entity.Property(e => e.prepare_date).HasComment("준비일자");
            entity.Property(e => e.recv_address).HasComment("수취인 주소");
            entity.Property(e => e.recv_address_detail).HasComment("수취인 상세주소");
            entity.Property(e => e.recv_hphone).HasComment("수취인 핸드폰 번호");
            entity.Property(e => e.recv_msg).HasComment("배송 메시지");
            entity.Property(e => e.recv_name).HasComment("수취인 인름");
            entity.Property(e => e.recv_phone).HasComment("수취인 전화번호");
            entity.Property(e => e.recv_zip).HasComment("수취인 우편번호");
            entity.Property(e => e.sales_gubun).HasComment("판매사이트구분");
            entity.Property(e => e.settle_Cancel_Date).HasComment("결제취소일");
            entity.Property(e => e.settle_date).HasComment("결제일");
            entity.Property(e => e.settle_method)
                .IsFixedLength()
                .HasComment("결제방법");
            entity.Property(e => e.settle_price).HasComment("결제금액");
            entity.Property(e => e.site_gubun).IsFixedLength();
            entity.Property(e => e.status_seq).HasComment("주문상태");
        });

        modelBuilder.Entity<CUSTOM_ETC_ORDER_ITEM>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("부가상품 주문상세정보"));

            entity.Property(e => e.card_opt).HasComment("제품선택옵션");
            entity.Property(e => e.card_price).HasComment("상품소비자가격");
            entity.Property(e => e.card_sale_price).HasComment("상품할인구매가");
            entity.Property(e => e.isChange)
                .IsFixedLength()
                .HasComment("시즌카드의 경우 카드교체여부");
            entity.Property(e => e.order_count).HasComment("주문수량");
            entity.Property(e => e.order_tbl)
                .IsFixedLength()
                .HasComment("W:청첩장 테이블,E:etc 테이블");
        });

        modelBuilder.Entity<CUSTOM_ETC_ORDER_WeddInfo>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_custom_etc_order_weddinfo");

            entity.ToTable(tb => tb.HasComment("CUSTOM_ETC_ORDER_WeddInfo"));

            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CUSTOM_ORDER_ADMIN_MENT>(entity =>
        {
            entity.HasKey(e => e.ID).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("CS 처리 상세 (관리메모)"));

            entity.HasIndex(e => e.REG_DATE, "clu_reg_date")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ORDER_SEQ, "nind_corder_seq").HasFillFactor(90);

            entity.Property(e => e.ADMIN_ID).HasComment("등록 어드민");
            entity.Property(e => e.ISWOrder)
                .IsFixedLength()
                .HasComment("1:청첩장관련,0:식권 또는 샘플");
            entity.Property(e => e.MENT).HasComment("메모");
            entity.Property(e => e.PCHECK).HasComment("유형(0:일반,1:포장지시,2:사고,3/5:취소)");
            entity.Property(e => e.REG_DATE).HasComment("등록일");
            entity.Property(e => e.STATUS).HasComment("처리여부(0:등록,9:처리완료)");
            entity.Property(e => e.isJumun).IsFixedLength();
        });

        modelBuilder.Entity<CUSTOM_ORDER_CHASU>(entity =>
        {
            entity.HasKey(e => e.id).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("초대장 인쇄차수"));

            entity.HasIndex(e => e.pdate, "clu_pDate")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "nind_order_seq").HasFillFactor(90);

            entity.HasIndex(e => e.pdate_Real, "nind_pdate").HasFillFactor(90);

            entity.HasIndex(e => e.pseq, "nind_pseq").HasFillFactor(90);

            entity.Property(e => e.order_seq).HasComment("주문번호");
            entity.Property(e => e.oseq).HasComment("한 차수내의 순서");
            entity.Property(e => e.pdate).HasComment("차수일");
            entity.Property(e => e.pdate_Real).HasComment("인쇄 예정일");
            entity.Property(e => e.proc_date1).HasComment("원고검토일");
            entity.Property(e => e.proc_date2).HasComment("원고검토마감일");
            entity.Property(e => e.proc_date3).HasComment("차수지정일");
            entity.Property(e => e.proc_date4).HasComment("코렐병합일");
            entity.Property(e => e.pseq).HasComment("차수");
        });

        modelBuilder.Entity<CUSTOM_ORDER_COPY>(entity =>
        {
            entity.HasKey(e => new { e.order_seq, e.delivery_seq }).HasName("PK_CUSTOM_ORDER_COPY_1");

            entity.ToTable(tb => tb.HasComment("청첩장 지시서 검증내용"));

            entity.Property(e => e.delivery_seq).HasComment("배송지순서");
            entity.Property(e => e.delivery_method).HasComment("배송방법");
            entity.Property(e => e.embo_str).HasComment("엠보인쇄");
            entity.Property(e => e.isQuick)
                .IsFixedLength()
                .HasComment("퀵처리 여부");
            entity.Property(e => e.isRisk)
                .IsFixedLength()
                .HasComment("주의요망 여부");
            entity.Property(e => e.jebon_str).HasComment("제본처리");
            entity.Property(e => e.print_str).HasComment("특수인쇄");
        });

        modelBuilder.Entity<CUSTOM_ORDER_COPY_DETAIL>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_CUSTOM_ORDER_COPY");

            entity.ToTable(tb => tb.HasComment("청첩장 지시서 내역"));

            entity.HasIndex(e => e.order_seq, "nind_order_seq").HasFillFactor(90);

            entity.Property(e => e.delivery_seq).HasComment("배송지 순서");
            entity.Property(e => e.etc1).HasComment("기타내용");
            entity.Property(e => e.isPItem)
                .IsFixedLength()
                .HasComment("1:인쇄판제품,0:비인쇄판제품");
            entity.Property(e => e.item_code).HasComment("코드");
            entity.Property(e => e.item_count).HasComment("수량");
            entity.Property(e => e.item_seq).HasComment("순서");
            entity.Property(e => e.item_title).HasComment("항목명");
            entity.Property(e => e.item_type)
                .IsFixedLength()
                .HasComment("아이템 항목");
            entity.Property(e => e.pack_count).HasComment("무게검증 수량");
            entity.Property(e => e.pack_weight).HasComment("무게검증 무게");
        });

        modelBuilder.Entity<CUSTOM_ORDER_COPY_PlcCode>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("지시서 코드 관리"));

            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.plc_code).IsFixedLength();
            entity.Property(e => e.plc_type).IsFixedLength();
        });

        modelBuilder.Entity<CUSTOM_ORDER_COUPON>(entity =>
        {
            entity.HasKey(e => e.ORDER_COUPON_SEQ).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("쿠폰 적용 내역"));

            entity.HasIndex(e => e.ORDER_COUPON_SEQ, "CI_ORDER_COUPON_SEQ").IsClustered();
        });

        modelBuilder.Entity<CUSTOM_PRIVATE_CHOICE>(entity =>
        {
            entity.HasIndex(e => e.CARD_SEQ, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.MEMBER_ID, "IDX__member_id").HasFillFactor(90);

            entity.Property(e => e.CARD_TYPE)
                .IsFixedLength()
                .HasComment("W:청첩장,E:E청첩장");
        });

        modelBuilder.Entity<CUSTOM_SAMPLE_ORDER>(entity =>
        {
            entity.HasKey(e => e.sample_order_seq)
                .HasName("PK__CUSTOM_SAMPLE_OR__1EF99443")
                .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("샘플주문정보"));

            entity.HasIndex(e => new { e.COMPANY_SEQ, e.sample_order_seq, e.STATUS_SEQ }, "CUSTOM_SAMPLE_ORDER67").HasFillFactor(90);

            entity.HasIndex(e => e.MEMBER_EMAIL, "MEMBER_EMAIL").HasFillFactor(90);

            entity.HasIndex(e => e.MEMBER_ID, "MEMBER_ID").HasFillFactor(90);

            entity.HasIndex(e => e.REQUEST_DATE, "NCI_REQUEST_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.SETTLE_DATE, "clu")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.sample_order_seq).ValueGeneratedNever();
            entity.Property(e => e.BUY_CONF).IsFixedLength();
            entity.Property(e => e.CANCEL_DATE).HasComment("주문취소일");
            entity.Property(e => e.CANCEL_REASON).HasComment("주문취소 사유");
            entity.Property(e => e.COMPANY_SEQ).HasComment("제휴업체");
            entity.Property(e => e.DELIVERY_CHANGO).HasComment("배송창고 1:본사출고");
            entity.Property(e => e.DELIVERY_CODE_NUM).HasComment("배송 송장번호");
            entity.Property(e => e.DELIVERY_COM)
                .IsFixedLength()
                .HasComment("택배사 코드(CJ:CJ택배)");
            entity.Property(e => e.DELIVERY_DATE).HasComment("배송처리일");
            entity.Property(e => e.DELIVERY_METHOD)
                .IsFixedLength()
                .HasComment("1:택배");
            entity.Property(e => e.DELIVERY_PRICE).HasComment("배송비");
            entity.Property(e => e.DSP_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.INVOICE_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.ISDACOM)
                .IsFixedLength()
                .HasComment("영수증 발행여부");
            entity.Property(e => e.JOB_ORDER_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.MEMBER_ADDRESS).HasComment("수취인 주소");
            entity.Property(e => e.MEMBER_ADDRESS_DETAIL).HasComment("수취인 상세주소");
            entity.Property(e => e.MEMBER_EMAIL).HasComment("주문자 이메일");
            entity.Property(e => e.MEMBER_FAX).HasComment("사용안함");
            entity.Property(e => e.MEMBER_HPHONE).HasComment("주문자 핸드폰번호");
            entity.Property(e => e.MEMBER_ID).HasComment("회원ID");
            entity.Property(e => e.MEMBER_NAME).HasComment("주문자 이름");
            entity.Property(e => e.MEMBER_PHONE).HasComment("주문자 전화번호");
            entity.Property(e => e.MEMBER_ZIP).HasComment("수취인 우편번호");
            entity.Property(e => e.MEMO).HasComment("배송메모");
            entity.Property(e => e.MULTI_PACK_REG_DATE).HasComment("묶음배송 등록일");
            entity.Property(e => e.MULTI_PACK_SEQ).HasComment("묶음배송 seq");
            entity.Property(e => e.MULTI_PACK_SUB_SEQ).HasComment("묶음배송 건수 (1,2)");
            entity.Property(e => e.PG_CALDATE).HasComment("PG수금일");
            entity.Property(e => e.PG_FEE).HasComment("PG수수료");
            entity.Property(e => e.PG_MERTID).HasComment("PG상점 아이디");
            entity.Property(e => e.PG_PAYDATE).HasComment("PG정산일");
            entity.Property(e => e.PG_RECALDATE).HasComment("PG환불수금일");
            entity.Property(e => e.PG_REFEE).HasComment("pG환불 수수료");
            entity.Property(e => e.PG_REPAYDATE).HasComment("PG환불정산일");
            entity.Property(e => e.PG_RESULTINFO).HasComment("PG결제결과");
            entity.Property(e => e.PG_RESULTINFO2).HasComment("PG결제결과 (입금자 이름)");
            entity.Property(e => e.PG_TID).HasComment("이니시스 TID");
            entity.Property(e => e.PREPARE_DATE).HasComment("카드준비일");
            entity.Property(e => e.REQUEST_DATE).HasComment("주문일");
            entity.Property(e => e.SALES_GUBUN).HasComment("manage_code.sales_gubun");
            entity.Property(e => e.SETTLE_CANCEL)
                .IsFixedLength()
                .HasComment("결제취소여부(사용안함)");
            entity.Property(e => e.SETTLE_DATE).HasComment("결제일");
            entity.Property(e => e.SETTLE_HPHONE).HasComment("결제 핸드폰");
            entity.Property(e => e.SETTLE_METHOD)
                .IsFixedLength()
                .HasComment("결제방법");
            entity.Property(e => e.SETTLE_MOBILID)
                .IsFixedLength()
                .HasComment("사용안함");
            entity.Property(e => e.SETTLE_PRICE).HasComment("결제금액");
            entity.Property(e => e.SRC_ERP_DATE).HasComment("ERP전송일");
            entity.Property(e => e.STATUS_SEQ).HasComment("주문상태 1:주문완료(결제전),3:결제완료,10:카드준비중,12:발송완료");
            entity.Property(e => e.WEDD_DATE).HasComment("예식일");
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.card_nointyn).IsFixedLength();
            entity.Property(e => e.isAscrow)
                .IsFixedLength()
                .HasComment("에스크로 거래건 여부");
            entity.Property(e => e.isHJ)
                .IsFixedLength()
                .HasComment("한진택배 EDI 전송여부");
            entity.Property(e => e.isOneClickSample).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.join_division).HasComment("mobile,Web 구분");
            entity.Property(e => e.order_g_seq).HasComment("더카드 그룹 seq");
        });

        modelBuilder.Entity<CUSTOM_SAMPLE_ORDER_ITEM>(entity =>
        {
            entity.HasKey(e => new { e.SAMPLE_ORDER_SEQ, e.CARD_SEQ }).HasName("PK__CUSTOM_SAMPLE_OR__540C7B00");

            entity.ToTable(tb => tb.HasComment("샘플주문 상세정보"));

            entity.Property(e => e.CARD_PRICE).HasComment("샘플 판매가");
            entity.Property(e => e.REG_DATE).HasComment("주문일");
            entity.Property(e => e.isChu).IsFixedLength();
            entity.Property(e => e.md_recommend).IsFixedLength();

            entity.HasOne(d => d.SAMPLE_ORDER_SEQNavigation).WithMany(p => p.CUSTOM_SAMPLE_ORDER_ITEM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOM_SA__SAMPL__668030F6");
        });

        modelBuilder.Entity<CUSTOM_SAMPLE_ORDER_ITEM_COUNT>(entity =>
        {
            entity.HasKey(e => new { e.CARD_SEQ, e.REG_DATE }).HasName("PK_CARD_SEQ_CUSTOM_SAMPLE_ORDER_ITEM_201411_1");
        });

        modelBuilder.Entity<CUSTOM_SAMPLE_ORDER_ITEM_deardup>(entity =>
        {
            entity.Property(e => e.isChu).IsFixedLength();
            entity.Property(e => e.md_recommend).IsFixedLength();
        });

        modelBuilder.Entity<CUSTOM_SAMPLE_ORDER_deardup>(entity =>
        {
            entity.Property(e => e.BUY_CONF).IsFixedLength();
            entity.Property(e => e.DELIVERY_COM).IsFixedLength();
            entity.Property(e => e.DELIVERY_METHOD).IsFixedLength();
            entity.Property(e => e.DSP_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.INVOICE_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.ISDACOM).IsFixedLength();
            entity.Property(e => e.JOB_ORDER_PRINT_YORN).IsFixedLength();
            entity.Property(e => e.SETTLE_CANCEL).IsFixedLength();
            entity.Property(e => e.SETTLE_METHOD).IsFixedLength();
            entity.Property(e => e.SETTLE_MOBILID).IsFixedLength();
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.card_nointyn).IsFixedLength();
            entity.Property(e => e.isAscrow).IsFixedLength();
            entity.Property(e => e.isHJ).IsFixedLength();
            entity.Property(e => e.isOneClickSample).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
        });

        modelBuilder.Entity<Callcenter_Log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("콜센터 로그"));

            entity.HasIndex(e => e.YRDATE, "IX_Callcenter_Log_RDATE")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.YCallerID, "IX_Callcenter_Log_YCallerID").HasFillFactor(90);

            entity.HasIndex(e => e.YIVR, "IX_Callcenter_Log_YIVR").HasFillFactor(90);
        });

        modelBuilder.Entity<Card_Disrate_View>(entity =>
        {
            entity.Property(e => e.card_group).IsFixedLength();
            entity.Property(e => e.display_yes_or_no).IsFixedLength();
            entity.Property(e => e.num100).IsFixedLength();
            entity.Property(e => e.num1000).IsFixedLength();
            entity.Property(e => e.num150).IsFixedLength();
            entity.Property(e => e.num200).IsFixedLength();
            entity.Property(e => e.num250).IsFixedLength();
            entity.Property(e => e.num300).IsFixedLength();
            entity.Property(e => e.num350).IsFixedLength();
            entity.Property(e => e.num400).IsFixedLength();
            entity.Property(e => e.num450).IsFixedLength();
            entity.Property(e => e.num50).IsFixedLength();
            entity.Property(e => e.num500).IsFixedLength();
            entity.Property(e => e.num550).IsFixedLength();
            entity.Property(e => e.num600).IsFixedLength();
            entity.Property(e => e.num650).IsFixedLength();
            entity.Property(e => e.num700).IsFixedLength();
            entity.Property(e => e.num800).IsFixedLength();
            entity.Property(e => e.num900).IsFixedLength();
        });

        modelBuilder.Entity<Card_News>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_Card_News__seq");

            entity.ToTable(tb => tb.HasComment("카드뉴스"));

            entity.Property(e => e.List_View_YN).IsFixedLength();
            entity.Property(e => e.View_YN).IsFixedLength();
        });

        modelBuilder.Entity<Card_News_TEMP>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_Card_News_TEMP__seq");

            entity.Property(e => e.View_YN).IsFixedLength();
        });

        modelBuilder.Entity<Category_Manage>(entity =>
        {
            entity.Property(e => e.CM_Idx).HasComment("Sequence");
            entity.Property(e => e.CM_Code1)
                .IsFixedLength()
                .HasComment("1차코드");
            entity.Property(e => e.CM_Code2)
                .IsFixedLength()
                .HasComment("2차코드");
            entity.Property(e => e.CM_Code3)
                .IsFixedLength()
                .HasComment("3차코드");
            entity.Property(e => e.CM_Code_Merge).HasComment("통합코드");
            entity.Property(e => e.CM_Name).HasComment("카테고리명");
            entity.Property(e => e.CM_Regdate).HasComment("등록일");
            entity.Property(e => e.CM_SiteID).HasComment("사이트고유ID");
            entity.Property(e => e.CM_Status).HasComment("0:비전시, 1:전시");
        });

        modelBuilder.Entity<Category_Manage_Plus>(entity =>
        {
            entity.Property(e => e.CM_Idx).HasComment("Sequence");
            entity.Property(e => e.CM_Code1)
                .IsFixedLength()
                .HasComment("1차코드");
            entity.Property(e => e.CM_Code2)
                .IsFixedLength()
                .HasComment("2차코드");
            entity.Property(e => e.CM_Code3)
                .IsFixedLength()
                .HasComment("3차코드");
            entity.Property(e => e.CM_Code_Merge).HasComment("통합코드");
            entity.Property(e => e.CM_Name).HasComment("카테고리명");
            entity.Property(e => e.CM_Regdate).HasComment("등록일");
            entity.Property(e => e.CM_SiteID).HasComment("사이트고유ID");
            entity.Property(e => e.CM_Status).HasComment("0:비전시, 1:전시");
        });

        modelBuilder.Entity<CopperPlateExclude>(entity =>
        {
            entity.HasKey(e => e.card_seq).IsClustered(false);

            entity.Property(e => e.card_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<CopperPlateInfo>(entity =>
        {
            entity.HasKey(e => new { e.card_seq, e.isFPrint }).IsClustered(false);

            entity.Property(e => e.isFPrint).IsFixedLength();
        });

        modelBuilder.Entity<Custom_etc_basket>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_Custom_etc_basket__seq");

            entity.Property(e => e.order_type).IsFixedLength();
        });

        modelBuilder.Entity<Custom_order_Group>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드전용 카드주문 그룹"));

            entity.HasIndex(e => e.company_seq, "NCI_CUSTOM_ORDER_GROUP_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.member_id, "NCI_CUSTOM_ORDER_GROUP_MEMBER_ID").HasFillFactor(90);

            entity.HasIndex(e => new { e.member_id, e.company_seq }, "NCI_CUSTOM_ORDER_GROUP_MEMBER_ID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.isAscrow).IsFixedLength();
            entity.Property(e => e.isReceipt).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<Custom_order_Group_backup>(entity =>
        {
            entity.Property(e => e.isAscrow).IsFixedLength();
            entity.Property(e => e.isReceipt).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<Custom_order_item_backup>(entity =>
        {
            entity.Property(e => e.item_type).IsFixedLength();
        });

        modelBuilder.Entity<DD_BANLIST>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__DD_BANLI__DDDFBCBE0A140B88");
        });

        modelBuilder.Entity<DELIVERY_CODE>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<DELIVERY_CODE_TEST>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<DELIVERY_INFO>(entity =>
        {
            entity.HasKey(e => new { e.ORDER_SEQ, e.DELIVERY_SEQ }).HasName("PK__DELIVERY_INFO__73BA3083");

            entity.ToTable(tb => tb.HasComment("배송정보"));

            entity.HasIndex(e => e.DELIVERY_DATE, "IX_DELIVERY_DELDATE")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.PACKING_ADMIN_ID, "IX_DELIVERY_PACKDATE")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.PACKING_DATE, "IX_DELIVERY_PACKING_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.DELIVERY_CODE_NUM, "nind_DELIVERY_CODE_NUM").HasFillFactor(90);

            entity.HasIndex(e => e.ID, "nind_id").HasFillFactor(90);

            entity.Property(e => e.ADDR).HasComment("배달지 주소");
            entity.Property(e => e.ADDR_DETAIL).HasComment("배달지 상세주소");
            entity.Property(e => e.DELIVERY_CODE_NUM).HasComment("송장번호");
            entity.Property(e => e.DELIVERY_COM)
                .IsFixedLength()
                .HasComment("택배사 코드(HJ:한진택배,CJ:CJ택배)");
            entity.Property(e => e.DELIVERY_DATE).HasComment("발송일");
            entity.Property(e => e.DELIVERY_INFO1).HasComment("배송 메시지");
            entity.Property(e => e.DELIVERY_MEMO).HasComment("배송관련 관리자 메모");
            entity.Property(e => e.DELIVERY_METHOD).HasComment("1:택배,2:퀵,3:방문");
            entity.Property(e => e.DELIVERY_PAY).IsFixedLength();
            entity.Property(e => e.Delivery_Type).IsFixedLength();
            entity.Property(e => e.EMAIL).HasComment("수취인 이메일(사용안함)");
            entity.Property(e => e.HPHONE).HasComment("수취인 핸드폰 번호");
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.NAME).HasComment("수취인 이름");
            entity.Property(e => e.PACKING_ADMIN_ID).HasComment("포장 담당자");
            entity.Property(e => e.PACKING_DATE).HasComment("포장일");
            entity.Property(e => e.PHONE).HasComment("수취인 전화번호");
            entity.Property(e => e.ZIP).HasComment("배달지 우편번호");
            entity.Property(e => e.isNewCopy).IsFixedLength();
            entity.Property(e => e.nt_code)
                .IsFixedLength()
                .HasComment("국가코드(KOR:한국,USA:미국)");
            entity.Property(e => e.receivecode).HasComment("지시서 검증일(아직 사용안함)");
        });

        modelBuilder.Entity<DELIVERY_INFO_DELCODE>(entity =>
        {
            entity.Property(e => e.delivery_code_num).HasComment("송장코드");
            entity.Property(e => e.delivery_com).HasComment("택배사 코드(HJ:한진택배,CJ:CJ택배)");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isHJ)
                .IsFixedLength()
                .HasComment("한진택배 전송 여부");
        });

        modelBuilder.Entity<DELIVERY_INFO_DETAIL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("배송정보상세"));

            entity.HasIndex(e => e.delivery_id, "nind_delivery_id").HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "nind_order_Seq").HasFillFactor(90);

            entity.Property(e => e.delivery_id).HasComment("delivery_info.id");
            entity.Property(e => e.item_count).HasComment("수량");
            entity.Property(e => e.item_id).HasComment("item_type=P:custom_order_plist.id / item_type=O:custom_order_item.id");
            entity.Property(e => e.item_title).HasComment("판 이름 또는 제품명");
            entity.Property(e => e.item_type)
                .IsFixedLength()
                .HasComment("C:카드,E:봉투,O:기타");
        });

        modelBuilder.Entity<DELIVERY_INFO_GROUP>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("묶음배송"));

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.ADDR).HasComment("주소");
            entity.Property(e => e.ADDR_DETAIL).HasComment("상세주소");
            entity.Property(e => e.DELIVERY_COM).IsFixedLength();
            entity.Property(e => e.DELIVERY_INFO).HasComment("배송 메모");
            entity.Property(e => e.DELIVERY_PAY).IsFixedLength();
            entity.Property(e => e.DELIVERY_PRICE).HasComment("배송비");
            entity.Property(e => e.EMAIL).HasComment("이메일");
            entity.Property(e => e.HPHONE).HasComment("헨드폰번호");
            entity.Property(e => e.NAME).HasComment("이름");
            entity.Property(e => e.PHONE).HasComment("전화번호");
            entity.Property(e => e.ZIP).HasComment("우편번호");
            entity.Property(e => e.isNewCopy).IsFixedLength();
            entity.Property(e => e.nt_code)
                .IsFixedLength()
                .HasComment("국가코드");
        });

        modelBuilder.Entity<DELIVERY_REG_LOG>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DELIVERY_SEND_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("배송 로그"));

            entity.Property(e => e.DELIVERY_CODE).HasComment("송장번호");
            entity.Property(e => e.ORDER_TABLE_NAME).HasComment("주문테이블");
            entity.Property(e => e.RESULT_CODE).HasComment("결과코드");
            entity.Property(e => e.RESULT_MSG).HasComment("결과메세지");
        });

        modelBuilder.Entity<DELIVERY_STOP_ZIPCODE>(entity =>
        {
            entity.Property(e => e.GUBUN).IsFixedLength();
        });

        modelBuilder.Entity<DISCOUNT_POLICY>(entity =>
        {
            entity.HasKey(e => e.DISCOUNT_SEQ).HasName("PK__DISCOUNT_POLICY__4A8310C6");

            entity.ToTable(tb => tb.HasComment("할인율 관리"));

            entity.HasIndex(e => e.MAX_COUNT, "IDX__DISCOUNT_POLICY__MAX_COUNT").HasFillFactor(90);

            entity.HasIndex(e => e.MAX_PRICE, "IDX__DISCOUNT_POLICY__MAX_PRICE").HasFillFactor(90);

            entity.HasIndex(e => e.MIN_COUNT, "IDX__DISCOUNT_POLICY__MIN_COUNT").HasFillFactor(90);

            entity.HasIndex(e => e.MIN_PRICE, "IDX__DISCOUNT_POLICY__MIN_PRICE").HasFillFactor(90);

            entity.Property(e => e.DISCOUNT_SEQ).ValueGeneratedNever();

            entity.HasOne(d => d.CARD_CATEGORY_SEQNavigation).WithMany(p => p.DISCOUNT_POLICY)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DISCOUNT___CARD___6D2D2E85");
        });

        modelBuilder.Entity<DISPLAY_CATEGORY>(entity =>
        {
            entity.HasKey(e => e.CATEGORY_SEQ).HasName("PK__DISPLAY_CATEGORY__2BFE89A6");

            entity.Property(e => e.CATEGORY_SEQ).ValueGeneratedNever();
        });

        modelBuilder.Entity<DatabaseChangeHistory>(entity =>
        {
            entity.HasKey(e => e.EventID)
                .HasName("XPKSPLOG")
                .IsClustered(false);
        });

        modelBuilder.Entity<DesignBettle>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("디자인배틀이벤트"));

            entity.Property(e => e.Gubun)
                .IsFixedLength()
                .HasComment("1: 별디자인, 2:달디자인");
            entity.Property(e => e.Num).HasComment("배틀 회차");
            entity.Property(e => e.RegDate).HasComment("등록일");
        });

        modelBuilder.Entity<Designer>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("디자이너 정보"));

            entity.Property(e => e.Pwd).IsFixedLength();
        });

        modelBuilder.Entity<Discount_Delete_Admin_Log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("할인율 삭제 히스토리"));

            entity.Property(e => e.SEQ).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Drop_Invo_Order_Seq>(entity =>
        {
            entity.Property(e => e.Gubun).IsFixedLength();
        });

        modelBuilder.Entity<ERP_Price>(entity =>
        {
            entity.Property(e => e.DesignCode).IsFixedLength();
            entity.Property(e => e.ItemCode).IsFixedLength();
            entity.Property(e => e.UpdateDate).IsFixedLength();
        });

        modelBuilder.Entity<ERR_TBL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("빠른손 오류 로그"));

            entity.Property(e => e.err_desc).HasComment("해당 내용");
            entity.Property(e => e.err_time).HasComment("발생시각");
            entity.Property(e => e.login_id).HasComment("에러 발생 관리 아이디");
        });

        modelBuilder.Entity<ESTIMATE_REQUEST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("커스텀 제작/견적 문의"));

            entity.Property(e => e.seq).HasComment("일련번호");
            entity.Property(e => e.CREATED_TMSTMP).HasComment("생성일");
            entity.Property(e => e.CREATED_USERID).HasComment("생성자");
            entity.Property(e => e.admin_content).HasComment("관리자 메모");
            entity.Property(e => e.chk_admin).HasComment("관리자확인 여부");
            entity.Property(e => e.chk_date).HasComment("관리자확인 일자");
            entity.Property(e => e.company_location).HasComment("회사위치");
            entity.Property(e => e.company_name).HasComment("회사명");
            entity.Property(e => e.company_seq).HasComment("사이트구분 번호");
            entity.Property(e => e.delete_ind).HasComment("삭제여부");
            entity.Property(e => e.etc_content).HasComment("기타정보 추가문의");
            entity.Property(e => e.etc_upfile).HasComment("기타정보 파일첨부");
            entity.Property(e => e.person_email).HasComment("이메일");
            entity.Property(e => e.person_name).HasComment("성함");
            entity.Property(e => e.person_phone1).HasComment("연락처1");
            entity.Property(e => e.person_phone2).HasComment("연락처2");
            entity.Property(e => e.person_phone3).HasComment("연락처3");
            entity.Property(e => e.product_content).HasComment("제작정보 문의사항");
            entity.Property(e => e.product_count).HasComment("제작정보 요청수량");
            entity.Property(e => e.product_duedate).HasComment("제작정보 납기예상일");
            entity.Property(e => e.product_type).HasComment("제작정보 타입");
            entity.Property(e => e.sales_gubun).HasComment("사이트구분 코드");
        });

        modelBuilder.Entity<EVENT_DELIVERY_INFO>(entity =>
        {
            entity.Property(e => e.ORDER_SEQ).ValueGeneratedNever();
        });

        modelBuilder.Entity<EVENT_DigitalPhoto>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.isUse).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<EVENT_ENTER_MEMBER>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__EVENT_EN__CA1938C01FC24D06");
        });

        modelBuilder.Entity<EVENT_ETLAND>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.isUse).IsFixedLength();
        });

        modelBuilder.Entity<EVENT_FACEBOOKSHARE>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<EVENT_LMS_CONTENT>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__EVENT_LM__CA1938C05CFBAF7A");
        });

        modelBuilder.Entity<EVENT_MARKETING_AGREEMENT>(entity =>
        {
            entity.HasKey(e => e.uid).HasName("PK__EVENT_MA__DD701264C7E3EBEB");
        });

        modelBuilder.Entity<EVENT_SAMSUNG>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.c_sex).IsFixedLength();
            entity.Property(e => e.isAns).IsFixedLength();
            entity.Property(e => e.isBarunson).IsFixedLength();
        });

        modelBuilder.Entity<EVENT_talklove>(entity =>
        {
            entity.Property(e => e.talk_div).IsFixedLength();
        });

        modelBuilder.Entity<EVT_BHANDS_COUPLES>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__EVT_BHAN__DDDFBCBE29A1DB52");

            entity.ToTable(tb => tb.HasComment("카카오 동영상 이벤트"));
        });

        modelBuilder.Entity<EVT_BHANDS_COUPLES_VOTE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카카오 동영상 추천 이벤트"));

            entity.Property(e => e.Idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EVT_GIFT_LIKE>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__EVT_GIFT__CA1938C095A07F70");
        });

        modelBuilder.Entity<EVT_HOLLOWEEN>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("할로윈 이벤트"));
        });

        modelBuilder.Entity<EVT_HOTDEAL_STOCK>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("핫딜 이벤트"));
        });

        modelBuilder.Entity<EVT_WEDDINGBOX>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__EVT_WEDD__CA1938C04B2418DE");
        });

        modelBuilder.Entity<Error_User>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("에러로그"));
        });

        modelBuilder.Entity<EveCard_Order_Info>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_CIDX_EveCard_Order_Info__SEQ");

            entity.HasIndex(e => e.CP_LoginDate, "IDX__CP_LoginDate").HasFillFactor(90);

            entity.Property(e => e.Order_Status).IsFixedLength();
        });

        modelBuilder.Entity<EveCard_Prd_Info>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_CIDX_EveCard_Prd_Info__SEQ");

            entity.HasIndex(e => e.CP_LoginDate, "IDX__CP_LoginDate").HasFillFactor(90);

            entity.Property(e => e.Order_Status).IsFixedLength();
        });

        modelBuilder.Entity<EverydayCard>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_CIDX_EverydayCard__SEQ");

            entity.HasIndex(e => e.Prd_Code, "IDX__Prd_Code").HasFillFactor(90);

            entity.Property(e => e.Prd_Size).IsFixedLength();
            entity.Property(e => e.Prd_View).IsFixedLength();
        });

        modelBuilder.Entity<Evt_Banner>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__Evt_Bann__DDDFBCBE2FC13613");

            entity.ToTable(tb => tb.HasComment("비핸즈 이벤트 배너관리"));
        });

        modelBuilder.Entity<Evt_Plus_Friends>(entity =>
        {
            entity.HasKey(e => e.pf_idx).HasName("PK__Evt_Plus__62C7162E75642BD6");
        });

        modelBuilder.Entity<Evt_Plus_Friends_uid>(entity =>
        {
            entity.HasKey(e => e.p_idx).HasName("PK__Evt_Plus__02C266CD887F2A5C");
        });

        modelBuilder.Entity<Evt_three_six_nine_board>(entity =>
        {
            entity.HasKey(e => e.b_idx).HasName("PK__Evt_thre__68F2F1B60A9F18AB");
        });

        modelBuilder.Entity<Ewedd_After_Note>(entity =>
        {
            entity.Property(e => e.CMT_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.DIV).IsFixedLength();
        });

        modelBuilder.Entity<GREETING>(entity =>
        {
            entity.HasKey(e => e.GREETING_SEQ).HasName("PK__GREETING__4B7734FF");

            entity.ToTable(tb => tb.HasComment("인사말"));

            entity.Property(e => e.GREETING_SEQ).ValueGeneratedNever();
            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.GREETING_CATEGORY_SEQ).HasComment("카테고리");
            entity.Property(e => e.GREETING_CONTENT).HasComment("인사말 내용");
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.USE_IMAGE).IsFixedLength();

            entity.HasOne(d => d.GREETING_CATEGORY_SEQNavigation).WithMany(p => p.GREETING)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GREETING__GREETI__14B10FFA");
        });

        modelBuilder.Entity<GREETING_CATEGORY>(entity =>
        {
            entity.HasKey(e => e.GREETING_CATEGORY_SEQ).HasName("PK__GREETING_CATEGOR__367C1819");

            entity.ToTable(tb => tb.HasComment("인사말 카테고리"));

            entity.Property(e => e.GREETING_CATEGORY_SEQ)
                .ValueGeneratedNever()
                .HasComment("카테고리 키");
            entity.Property(e => e.CATEGORY_DESCRIPTION).HasComment("카테고리 설명");
            entity.Property(e => e.CATEGORY_UPPER_CODE).HasComment("상위 카테고리");
            entity.Property(e => e.CATEGORY_USED).IsFixedLength();
            entity.Property(e => e.GREETING_CATEGORY_NAME).HasComment("카테고리명");
        });

        modelBuilder.Entity<Greeting_barshop>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("인사말"));

            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.USE_IMAGE).IsFixedLength();
        });

        modelBuilder.Entity<HANJIN_ZIPCODE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("한진택배 우편번호"));
        });

        modelBuilder.Entity<HYUNDAI_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__HYUNDAI___DDDFBCBE13D43A9A");
        });

        modelBuilder.Entity<HardCodingList>(entity =>
        {
            entity.HasKey(e => new { e.HardID, e.HardCode }).HasName("PK__HardCodi__64A1E7794ADB5373");

            entity.Property(e => e.HardUse).IsFixedLength();
            entity.Property(e => e.MultiUse).IsFixedLength();
        });

        modelBuilder.Entity<HeadCol_TEMP>(entity =>
        {
            entity.Property(e => e.BHands).IsFixedLength();
            entity.Property(e => e.CardBrand).IsFixedLength();
            entity.Property(e => e.TheCard).IsFixedLength();
        });

        modelBuilder.Entity<ILOOM_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__ILOOM_DA__DDDFBCBED6113754");
        });

        modelBuilder.Entity<INTEGRATION_ADMIN_MENU>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("관리자 메뉴 관리"));

            entity.Property(e => e.FOLDER_YORN).IsFixedLength();
            entity.Property(e => e.PUBLIC_YORN).IsFixedLength();
        });

        modelBuilder.Entity<INTEGRATION_ADMIN_MENU_AUTH>(entity =>
        {
            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<INTEGRATION_MEMBER_SIGN_UP_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("통합아이디 회원가입 액션 로그"));

            entity.HasIndex(e => e.INTEGRATION_USER_ID, "NCI_INTEGRATION_MEMBER_SIGN_UP_LOG_INTEGRATION_USER_ID").HasFillFactor(90);

            entity.HasIndex(e => e.REFERER_SITE, "NCI_INTEGRATION_MEMBER_SIGN_UP_LOG_REFERER_SITE").HasFillFactor(90);

            entity.HasIndex(e => e.USER_ID, "NCI_INTEGRATION_MEMBER_SIGN_UP_LOG_USER_ID").HasFillFactor(90);

            entity.Property(e => e.INTEGRATION_USER_ID).HasComment("통합아이디");
            entity.Property(e => e.REFERER_SITE).HasComment("접근 사이트");
            entity.Property(e => e.SELECT_ID).HasComment("선택 ID");
            entity.Property(e => e.SELECT_SITE).HasComment("선택 사이트");
        });

        modelBuilder.Entity<JEHU_COUPONBOX_ISSUE>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__JEHU_COU__CA1938C007274940");
        });

        modelBuilder.Entity<KT_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__KT_DAILY__DDDFBCBED0ED308F");
        });

        modelBuilder.Entity<LMS_SEND_TARGET_USER>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_barunsoncard_temp_table_2");

            entity.HasIndex(e => e.GROUP_SEQ, "NCI_").HasFillFactor(90);

            entity.HasIndex(e => e.UID, "NCI_UID").HasFillFactor(90);

            entity.Property(e => e.MK_EVENT_YORN).IsFixedLength();
            entity.Property(e => e.SMS_YORN).IsFixedLength();
        });

        modelBuilder.Entity<LOGO_CATEGORY>(entity =>
        {
            entity.Property(e => e.lcategory).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LOG_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("로그파일"));
        });

        modelBuilder.Entity<LT_DELCODE>(entity =>
        {
            entity.HasKey(e => e.DELCODE_SEQ).HasName("PK_LT_DELCODE_DELCODE_SEQ");

            entity.ToTable(tb => tb.HasComment("CJ 송장코드"));

            entity.Property(e => e.DELCODE_SEQ).HasComment("");
            entity.Property(e => e.CODE).HasComment("송장번호");
            entity.Property(e => e.CODESEQ).HasComment("");
            entity.Property(e => e.IMG_YN).IsFixedLength();
            entity.Property(e => e.ISUSE)
                .IsFixedLength()
                .HasComment("사용유무 (0:사용안함, 1:사용완료)");
            entity.Property(e => e.IS_USE).HasComment("");
        });

        modelBuilder.Entity<LT_DELCODE_USAGE_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("송장코드 사용로그"));

            entity.Property(e => e.DELIVERY_CODE_NUM).HasComment("송장번호");
            entity.Property(e => e.ORDER_SEQ).HasComment("주문번호");
            entity.Property(e => e.REG_DATE).HasComment("등록일");
        });

        modelBuilder.Entity<Logo_TBL>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_Logo_tmp");

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.flag).IsFixedLength();
        });

        modelBuilder.Entity<MAIN_POPUP_IMAGE>(entity =>
        {
            entity.HasKey(e => new { e.MST_SEQ, e.COMPANY_SEQ }).HasName("PK__MAIN_POP__71ACEAFCAC30EE53");
        });

        modelBuilder.Entity<MAIN_POPUP_MST>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__MAIN_POP__CA1938C070F69398");
        });

        modelBuilder.Entity<MCARD_IMAGE_DELETE>(entity =>
        {
            entity.Property(e => e.DELETE_DATE).HasComment("이미지삭제일자");
            entity.Property(e => e.INVITATIONID).HasComment("삭제ID(F)-MCARD_INVITATION.INVITATIONID");
        });

        modelBuilder.Entity<MCARD_INVITATION_FLOW>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("모바일초대장 진행 관리"));

            entity.Property(e => e.PCM).HasComment("유입경로 : PC / MOBILE");
            entity.Property(e => e.UID).HasComment("고객ID");
            entity.Property(e => e.CREATE_DATE).HasComment("등록일");
            entity.Property(e => e.MEM_GB).HasComment("회원여부(Y:회원 , N:비회원)");
            entity.Property(e => e.STEP0).HasComment("약관동의");
            entity.Property(e => e.STEP1).HasComment("스킨선택");
            entity.Property(e => e.STEP2).HasComment("정보입력");
            entity.Property(e => e.STEP3).HasComment("갤러리관리");
            entity.Property(e => e.STEP4).HasComment("제작완료");
            entity.Property(e => e.UPDATE_DATE).HasComment("수정일");
        });

        modelBuilder.Entity<MD_GIFT_EVENT_CHANEL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샤넬 이벤트"));

            entity.Property(e => e.REMAIN_CNT).HasComment("잔여수");
        });

        modelBuilder.Entity<MEMPLUS_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__MEMPLUS___DDDFBCBE10E1C646");
        });

        modelBuilder.Entity<MMS_LOG>(entity =>
        {
            entity.HasIndex(e => e.REQDATE, "MMS_LOG_IDX2").HasFillFactor(90);

            entity.HasIndex(e => e.PHONE, "MMS_LOG_IDX3").HasFillFactor(90);

            entity.Property(e => e.MSGKEY).ValueGeneratedNever();
        });

        modelBuilder.Entity<MMS_MSG>(entity =>
        {
            entity.HasIndex(e => e.REQDATE, "MMS_MSG_IDX2").HasFillFactor(90);

            entity.HasIndex(e => e.PHONE, "MMS_MSG_IDX3").HasFillFactor(90);

            entity.HasIndex(e => e.STATUS, "MMS_MSG_IDX4").HasFillFactor(90);
        });

        modelBuilder.Entity<MO_MAP>(entity =>
        {
            entity.HasIndex(e => e.MO_NUMBER, "MO_MAP_IDX1").HasFillFactor(90);
        });

        modelBuilder.Entity<MO_TRAN>(entity =>
        {
            entity.HasIndex(e => e.MO_ACCEPTTIME, "MO_TRAN_IDX1").HasFillFactor(90);

            entity.HasIndex(e => e.MO_SENDER, "MO_TRAN_IDX2").HasFillFactor(90);

            entity.HasIndex(e => e.MO_STATUS, "MO_TRAN_IDX3").HasFillFactor(90);

            entity.HasIndex(e => e.MO_SN, "MO_TRAN_IDX4").HasFillFactor(90);
        });

        modelBuilder.Entity<MYOMEE_DAILY_INFO>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__MYOMEE_D__DDDFBCBE0BBB8812");

            entity.ToTable(tb => tb.HasComment("광고-롯데렌탈(묘미) 데이터"));
        });

        modelBuilder.Entity<Mcard_MoneyGift>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("모바일초대장-Toss축의금사용정보"));

            entity.Property(e => e.InvitationID).ValueGeneratedNever();
            entity.Property(e => e.Birde_Account).HasComment("신부계좌번호");
            entity.Property(e => e.Birde_BankCode).HasComment("신부은행코드");
            entity.Property(e => e.Birde_URL).HasComment("송금서비스이용 등록 API 응답-신부송금페이지링크");
            entity.Property(e => e.DisableYN).HasComment("신랑신부 계좌번호변경시 사용함");
            entity.Property(e => e.Groom_Account).HasComment("신랑계좌번호");
            entity.Property(e => e.Groom_BankCode).HasComment("신랑은행코드");
            entity.Property(e => e.Groom_URL).HasComment("송금서비스이용 등록 API 응답-신랑송금페이지링크");
            entity.Property(e => e.InvitationCode).HasComment("초대장주문번호");
            entity.Property(e => e.Return_AccountBirdeName).HasComment("신부예금주명");
            entity.Property(e => e.Return_AccountGroomName).HasComment("신랑예금주명");
            entity.Property(e => e.Return_Birde_AccountCode).HasComment("계좌유효성체크 신부 응답코드");
            entity.Property(e => e.Return_Birde_AccountMessage).HasComment("계좌유효성체크 신부 응답메시지");
            entity.Property(e => e.Return_Code).HasComment("송금 서비스 이용 등록 API 응답코드");
            entity.Property(e => e.Return_CoupleKey).HasComment("추후 등록된 계좌 정보를 disable 처리할 경우에 필요한 값");
            entity.Property(e => e.Return_Disable_Code).HasComment("계좌 정보 disable 처리 응답코드");
            entity.Property(e => e.Return_Groom_AccountCode).HasComment("계좌유효성체크 신랑 응답코드");
            entity.Property(e => e.Return_Groom_AccountMessage).HasComment("계좌유효성체크 신랑응답메시지");
            entity.Property(e => e.Return_Message).HasComment("송금 서비스 이용 등록 API 응답메시지");
            entity.Property(e => e.Return_Updated_Tmstmp).HasComment("응답코드받은시간");
            entity.Property(e => e.Wedding_Date).HasComment("예식일");
        });

        modelBuilder.Entity<OB_NOTICE_T>(entity =>
        {
            entity.Property(e => e.Type).IsFixedLength();
            entity.Property(e => e.gubun).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
        });

        modelBuilder.Entity<OB_REF_CODE>(entity =>
        {
            entity.Property(e => e.Code_No).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OUTLET_CARD>(entity =>
        {
            entity.Property(e => e.B2B_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.BEST_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.CARD_CATE).IsFixedLength();
            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.DISRATE_TYPE).IsFixedLength();
            entity.Property(e => e.ISHAVE).IsFixedLength();
            entity.Property(e => e.ISInPaper).IsFixedLength();
            entity.Property(e => e.Is100).IsFixedLength();
            entity.Property(e => e.Is1001).IsFixedLength();
            entity.Property(e => e.Is1002).IsFixedLength();
            entity.Property(e => e.Is1003).IsFixedLength();
            entity.Property(e => e.Is1004).IsFixedLength();
            entity.Property(e => e.Is1005).IsFixedLength();
            entity.Property(e => e.Is1006).IsFixedLength();
            entity.Property(e => e.Is1007).IsFixedLength();
            entity.Property(e => e.Is1008).IsFixedLength();
            entity.Property(e => e.Is1009).IsFixedLength();
            entity.Property(e => e.Is200).IsFixedLength();
            entity.Property(e => e.Is300).IsFixedLength();
            entity.Property(e => e.Is400).IsFixedLength();
            entity.Property(e => e.IsFlower).IsFixedLength();
            entity.Property(e => e.IsGold).IsFixedLength();
            entity.Property(e => e.IsHandMade).IsFixedLength();
            entity.Property(e => e.IsHeart).IsFixedLength();
            entity.Property(e => e.IsOffBest).IsFixedLength();
            entity.Property(e => e.IsOffDDisplay).IsFixedLength();
            entity.Property(e => e.IsOffDisplay).IsFixedLength();
            entity.Property(e => e.IsRibon).IsFixedLength();
            entity.Property(e => e.IsSample).IsFixedLength();
            entity.Property(e => e.IsWonang).IsFixedLength();
            entity.Property(e => e.IsYu).IsFixedLength();
            entity.Property(e => e.NEW_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.ONLINE_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
        });

        modelBuilder.Entity<OUTLET_ORDER>(entity =>
        {
            entity.HasKey(e => e.ORDER_SEQ).HasName("PK__OUTLET_ORDER__3B95D2F1");

            entity.Property(e => e.ORDER_SEQ).ValueGeneratedNever();
            entity.Property(e => e.BUYER_ZIP).IsFixedLength();
            entity.Property(e => e.ISDACOM).IsFixedLength();
            entity.Property(e => e.ORDER_TYPE).IsFixedLength();
            entity.Property(e => e.RECV_ZIP).IsFixedLength();
            entity.Property(e => e.SALES_GUBUN).IsFixedLength();
            entity.Property(e => e.SETTLE_METHOD).IsFixedLength();
            entity.Property(e => e.SETTLE_MOBILID).IsFixedLength();
        });

        modelBuilder.Entity<OUTSOURCING_ORDER_MST>(entity =>
        {
            entity.Property(e => e.BOTH_SIDE_YORN).IsFixedLength();
            entity.Property(e => e.CUTOUT_YORN).IsFixedLength();
            entity.Property(e => e.DEV_FLAG).IsFixedLength();
            entity.Property(e => e.EDGE_YORN).IsFixedLength();
            entity.Property(e => e.GLOSSY_YORN).IsFixedLength();
            entity.Property(e => e.LASER_CUT_YORN).IsFixedLength();
            entity.Property(e => e.OSI_YORN).IsFixedLength();
            entity.Property(e => e.PRESS_YORN).IsFixedLength();
        });

        modelBuilder.Entity<OUTSOURCING_ORDER_MST_BACK_DATA>(entity =>
        {
            entity.Property(e => e.BOTH_SIDE_YORN).IsFixedLength();
            entity.Property(e => e.CUTOUT_YORN).IsFixedLength();
            entity.Property(e => e.EDGE_YORN).IsFixedLength();
            entity.Property(e => e.GLOSSY_YORN).IsFixedLength();
            entity.Property(e => e.LASER_CUT_YORN).IsFixedLength();
            entity.Property(e => e.OSI_YORN).IsFixedLength();
            entity.Property(e => e.OUTSOURCING_ORDER_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.PRESS_YORN).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_ADMIN_MENT>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PHOTOBOOK_BASKET>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_PHOTOBOOK_ORDER");

            entity.HasIndex(e => e.member_id, "nind_member_id").HasFillFactor(90);

            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
            entity.Property(e => e.status).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_COMMENT>(entity =>
        {
            entity.Property(e => e.comm_div).IsFixedLength();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.score).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_COUPON>(entity =>
        {
            entity.HasIndex(e => e.coupon_code, "nind_coupon_code").HasFillFactor(90);

            entity.Property(e => e.Isthrowaway)
                .IsFixedLength()
                .HasComment("일회용쿠폰");
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
            entity.Property(e => e.use_yn).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_BLOG>(entity =>
        {
            entity.Property(e => e.isbest).IsFixedLength();
            entity.Property(e => e.iscoupon)
                .IsFixedLength()
                .HasComment("0:확인중, 1:지급완료, 2:지급불가");
            entity.Property(e => e.isview).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_COUPON>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_PHOTOBOOK_EVENT_COUPON__seq");

            entity.Property(e => e.send_yn).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_PHOTOCLIP>(entity =>
        {
            entity.HasKey(e => e.clip_seq).HasName("PK_CIDX_PHOTOBOOK_EVENT_PHOTOCLIP__clip_seq");
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_PHOTOCLIP_REPLY>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_PHOTOBOOK_EVENT_PHOTOCLIP_REPLY__seq");
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_REMIND>(entity =>
        {
            entity.Property(e => e.isview).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_EVENT_REPLY>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_PHOTOBOOK_EVENT_REPLY__seq");

            entity.Property(e => e.event_div).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_FAQ>(entity =>
        {
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
            entity.Property(e => e.site_code).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_MEMBER>(entity =>
        {
            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.isAutoClass).IsFixedLength();
            entity.Property(e => e.isLunar).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.member_class).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.ustatus).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_MEMBER_OUT>(entity =>
        {
            entity.Property(e => e.ans1).IsFixedLength();
            entity.Property(e => e.ans2).IsFixedLength();
            entity.Property(e => e.ans3).IsFixedLength();
            entity.Property(e => e.ans4).IsFixedLength();
            entity.Property(e => e.ans5).IsFixedLength();
            entity.Property(e => e.ans6).IsFixedLength();
            entity.Property(e => e.ans7).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_MEMBER_tmp>(entity =>
        {
            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_OPEN>(entity =>
        {
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isOpen).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_ORDER>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_PHOTOBOOK_ORDER_1");

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.card_installmonth).HasComment("할부개월수");
            entity.Property(e => e.card_nointyn)
                .IsFixedLength()
                .HasComment("무이자할부여부");
            entity.Property(e => e.discount_type).IsFixedLength();
            entity.Property(e => e.isBalju).IsFixedLength();
            entity.Property(e => e.isOpen).IsFixedLength();
            entity.Property(e => e.isReceipt).IsFixedLength();
            entity.Property(e => e.isSystemUpdate).IsFixedLength();
            entity.Property(e => e.pay_type)
                .IsFixedLength()
                .HasComment("1:정상,4:사고건");
            entity.Property(e => e.recv_zip).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
            entity.Property(e => e.worder_gubun).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_ORDER_DETAIL>(entity =>
        {
            entity.HasIndex(e => e.order_id, "IDX_PHOTOBOOK_ORDER_DETAIL_OID").HasFillFactor(90);

            entity.HasIndex(e => e.product_order_id, "IDX_PHOTOBOOK_ORDER_DETAIL_POID").HasFillFactor(90);

            entity.Property(e => e.express_id).IsFixedLength();
            entity.Property(e => e.iscomment).IsFixedLength();
            entity.Property(e => e.isopen).IsFixedLength();
            entity.Property(e => e.isput).IsFixedLength();
            entity.Property(e => e.item_option).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_PROD>(entity =>
        {
            entity.Property(e => e.cover_style)
                .IsFixedLength()
                .HasComment("S:소프트커버,H:하드커버");
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.isChgCover).IsFixedLength();
            entity.Property(e => e.isChgSize).IsFixedLength();
            entity.Property(e => e.isDP).IsFixedLength();
            entity.Property(e => e.isEpilog).IsFixedLength();
            entity.Property(e => e.isProlog).IsFixedLength();
            entity.Property(e => e.isSaleBlog).IsFixedLength();
            entity.Property(e => e.isSaleGift)
                .IsFixedLength()
                .HasComment("기프트앨범");
            entity.Property(e => e.isSaleGroup)
                .IsFixedLength()
                .HasComment("단체앨범 판매여부");
            entity.Property(e => e.isTest).IsFixedLength();
            entity.Property(e => e.makecom_code)
                .IsFixedLength()
                .HasComment("1:학술,2:포토아비즈");
            entity.Property(e => e.site_code).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_PROD_DETAIL>(entity =>
        {
            entity.Property(e => e.isDP).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_PROD_ERP>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PHOTOBOOK_PROD_OPTION>(entity =>
        {
            entity.Property(e => e.mc_prod_img).IsFixedLength();
        });

        modelBuilder.Entity<PHOTOBOOK_TROUBLE>(entity =>
        {
            entity.Property(e => e.order_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PREVIEW>(entity =>
        {
            entity.HasKey(e => e.preview_seq).HasName("PK_preView");

            entity.HasIndex(e => e.order_Seq, "nind_order_Seq").HasFillFactor(90);

            entity.Property(e => e.preview_seq).ValueGeneratedNever();
            entity.Property(e => e.CE).IsFixedLength();
            entity.Property(e => e.preview_type).HasComment("C:카드,E:봉투,M:미니청첩장");
        });

        modelBuilder.Entity<PREVIEW_NOTICE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초안관련 고객에게 전달사항"));

            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PREVIEW_OPINION>(entity =>
        {
            entity.HasKey(e => e.BBS_SEQ).HasName("PK_PREVIEW_OPINION_");

            entity.ToTable(tb => tb.HasComment("초안 수정요청 내용"));

            entity.HasIndex(e => e.ORDER_SEQ, "nind_corder_seq").HasFillFactor(90);

            entity.Property(e => e.NOTIFY_EMAIL_YESORNO).IsFixedLength();
            entity.Property(e => e.ORDER_TYPE).IsFixedLength();
            entity.Property(e => e.STATUS).IsFixedLength();
        });

        modelBuilder.Entity<PRE_CARD_INFO>(entity =>
        {
            entity.HasKey(e => e.PRE_CARD_SEQ).HasName("PK__PRE_CARD_INFO__3A4CA8FD");

            entity.Property(e => e.PRE_CARD_SEQ).ValueGeneratedNever();
        });

        modelBuilder.Entity<PRIVATE_CHOICE>(entity =>
        {
            entity.Property(e => e.ORDER_TYPE).IsFixedLength();
        });

        modelBuilder.Entity<PrintChasuGroup>(entity =>
        {
            entity.Property(e => e.GroupType).IsFixedLength();
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<PrintChasuGroupDetail>(entity =>
        {
            entity.Property(e => e.PrintType).IsFixedLength();
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RESEARCH_ANS>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isReceive).IsFixedLength();
        });

        modelBuilder.Entity<RESEARCH_CARD>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RESEARCH_QLIST>(entity =>
        {
            entity.Property(e => e.ans7_cnt).IsFixedLength();
            entity.Property(e => e.status)
                .IsFixedLength()
                .HasComment("0:사용안함,1:사용함");
        });

        modelBuilder.Entity<Roulette_Item>(entity =>
        {
            entity.Property(e => e.roti_couponCD).HasComment("쿠폰번호");
            entity.Property(e => e.roti_edate).HasComment("유효기간종료일");
            entity.Property(e => e.roti_sdate).HasComment("유효기간시작일");
            entity.Property(e => e.roti_type)
                .IsFixedLength()
                .HasComment("아이템종류(P:상품, C:쿠폰)");
        });

        modelBuilder.Entity<Roulette_Main>(entity =>
        {
            entity.Property(e => e.comment_code).HasComment("하단 덧글게시판 코드");
            entity.Property(e => e.ing_ST)
                .IsFixedLength()
                .HasComment("회차중 마지막 참여한 순번");
            entity.Property(e => e.last_ST).HasComment("총 제품종류(8개 아이템이면:8)");
            entity.Property(e => e.rot_Edate).HasComment("종료일");
            entity.Property(e => e.rot_ST).HasComment("진행중회차");
            entity.Property(e => e.rot_Status).HasComment("상태");
            entity.Property(e => e.rot_limit_price).HasComment("참여가능 최소금액 - 0원일때는 체크안함");
            entity.Property(e => e.rot_regdate).HasComment("등록일");
            entity.Property(e => e.rot_sDate).HasComment("시작일");
            entity.Property(e => e.rot_title).HasComment("룰렛이벤트명");
        });

        modelBuilder.Entity<Roulette_Member>(entity =>
        {
            entity.Property(e => e.rotm_Idx).ValueGeneratedOnAdd();
            entity.Property(e => e.rotm_UID).HasComment("참여회원아이디");
            entity.Property(e => e.rotm_ST).HasComment("참여회차");
            entity.Property(e => e.rotm_coupon_code).HasComment("쿠폰적용시 쿠폰입력코드");
            entity.Property(e => e.rotm_order_seq).HasComment("청첩장 주문번호");
            entity.Property(e => e.rotm_phone).HasComment("핸드폰번호");
            entity.Property(e => e.rotm_regdate).HasComment("당첨일");
            entity.Property(e => e.rotm_rot_idx).HasComment("참여룰렛");
            entity.Property(e => e.rotm_rots_Idx).HasComment("당첨아이템");
            entity.Property(e => e.rotm_status).HasComment("상태(0:대기중, 1:완료)");
        });

        modelBuilder.Entity<Roulette_ST>(entity =>
        {
            entity.Property(e => e.rots_Idx).ValueGeneratedOnAdd();
            entity.Property(e => e.rot_idx).HasComment("참조키");
            entity.Property(e => e.rots_CNT).HasComment("수량(소진시킬수량)");
            entity.Property(e => e.rots_OCNT).HasComment("초기등록수량");
            entity.Property(e => e.rots_ST).HasComment("회차");
            entity.Property(e => e.rots_ord).HasComment("아이템순번");
            entity.Property(e => e.rots_regdate).HasComment("등록일");
            entity.Property(e => e.rots_roti_Idx).HasComment("아이템코드");
            entity.Property(e => e.rots_status).HasComment("상태 0:기본전시");
            entity.Property(e => e.rots_title).HasComment("회차아이템명");
        });

        modelBuilder.Entity<S2_Acc>(entity =>
        {
            entity.Property(e => e.brand).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
        });

        modelBuilder.Entity<S2_AdminList>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_AdminList__seq");

            entity.ToTable(tb => tb.HasComment("관리자 아이디"));

            entity.Property(e => e.is_errorMail).IsFixedLength();
            entity.Property(e => e.is_reviewMail).IsFixedLength();
            entity.Property(e => e.is_reviewSMS).IsFixedLength();
        });

        modelBuilder.Entity<S2_BestTotalRanking>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S2_BestTotalRank__7C694927");

            entity.ToTable(tb => tb.HasComment("청첩장 배치 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_CARD_FREE_FOOD_TICKET_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("식권 무료관리"));

            entity.Property(e => e.USE_JEHU_YORN).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<S2_CARD_FREE_FOOD_TICKET_MST_TEST>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK__S2_CARD___CA1938C079FA4D31");
        });

        modelBuilder.Entity<S2_CARD_FREE_GIFT>(entity =>
        {
            entity.Property(e => e.END_DATE).HasComment("종료일");
            entity.Property(e => e.FREE_GIFT_DESC).HasComment("사은품명");
            entity.Property(e => e.LIMIT_DELIVERY_GU_STR).HasComment("배송지제한(구단위)");
            entity.Property(e => e.LIMIT_DELIVERY_REGION_STR).HasComment("배송지제한");
            entity.Property(e => e.LIMIT_ORDER_COUNT).HasComment("주문수량제한");
            entity.Property(e => e.LIMIT_ORDER_PRICE).HasComment("주문액제한");
            entity.Property(e => e.LIMIT_ORDER_TYPE_STR).HasComment("주문타입제한");
            entity.Property(e => e.QTY).HasComment("잔여수량");
            entity.Property(e => e.REG_DATE).HasComment("가입일");
            entity.Property(e => e.START_DATE).HasComment("시작일");
            entity.Property(e => e.USE_YORN)
                .IsFixedLength()
                .HasComment("사용여부");
        });

        modelBuilder.Entity<S2_CARD_FREE_GIFT_LOG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("(받은)사은품로그"));

            entity.Property(e => e.FREE_GIFT_SEQ).HasComment("S2_CARD_FREE_GIFT.free_gift_seq");
            entity.Property(e => e.ORDER_SEQ).HasComment("");
            entity.Property(e => e.UID).HasComment("회원ID");
        });

        modelBuilder.Entity<S2_CARD_FREE_GIFT_TARGET_CARD>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("사은품 주는 카드관리"));
        });

        modelBuilder.Entity<S2_CARD_SAMPLE_FREE_GIFT>(entity =>
        {
            entity.Property(e => e.END_DATE).HasComment("종료일");
            entity.Property(e => e.LIMIT_DELIVERY_REGION_STR).HasComment("지역제한");
            entity.Property(e => e.LIMIT_ORDER_COUNT).HasComment("수량제한");
            entity.Property(e => e.LIMIT_ORDER_PRICE).HasComment("금액제한");
            entity.Property(e => e.LIMIT_ORDER_TYPE_STR).HasComment("주문타입제한");
            entity.Property(e => e.QTY).HasComment("잔여수량");
            entity.Property(e => e.REG_DATE).HasComment("가입일");
            entity.Property(e => e.START_DATE).HasComment("시작일");
            entity.Property(e => e.USE_YORN)
                .IsFixedLength()
                .HasComment("사용여부");
            entity.Property(e => e.WeddingHall).IsFixedLength();
        });

        modelBuilder.Entity<S2_Card>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드정보"));

            entity.HasIndex(e => e.Card_Code, "IDX__card_code").HasFillFactor(90);

            entity.HasIndex(e => e.Card_ERPCode, "IDX__card_erpcode").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Name, "IDX__card_name").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Price, "IDX__card_price").HasFillFactor(90);

            entity.HasIndex(e => e.CardSet_Price, "IDX__cardset_price").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Seq, "IX_S2_Card").HasFillFactor(90);

            entity.Property(e => e.CARD_GROUP)
                .IsFixedLength()
                .HasComment("I:초대장, X:시즌카드");
            entity.Property(e => e.CardBrand)
                .IsFixedLength()
                .HasComment("B:바른손카드, N:비핸즈,W:위시메이드,S:프페 Z:기타");
            entity.Property(e => e.CardSet_Price).HasComment("제품 셋트가(카드에만 적용)");
            entity.Property(e => e.Card_Div)
                .IsFixedLength()
                .HasComment("A01:카드,A02:내지,A03:인사말카드,A04:약도카드 B01:봉투,B02:봉투라이닝 C01:신랑봉투,C02:신부봉투,C03:미니,C04:스티커,C05:사은품,C06:식권셋트");
            entity.Property(e => e.Card_ERPCode).HasComment("ERP연동코드");
            entity.Property(e => e.Card_HSize).HasComment("제품 세로 사이즈");
            entity.Property(e => e.Card_Image).HasComment("제품썸네일이미지(주문단에 사용)");
            entity.Property(e => e.Card_Price).HasComment("단품가격 (추후 추가주문 등 단품 판매 기준가격)");
            entity.Property(e => e.DISPLAY_YORN).IsFixedLength();
            entity.Property(e => e.ERP_EXPECTED_ARRIVAL_DATE).HasComment("사용안함");
            entity.Property(e => e.Explain).HasComment("내용");
            entity.Property(e => e.FPRINT_YORN).IsFixedLength();
            entity.Property(e => e.Option_Name).HasComment("부가상품_옵션명");
            entity.Property(e => e.Tip).HasComment("구매팁");
            entity.Property(e => e.Unit).HasComment("단위");
            entity.Property(e => e.Unit_Value).HasComment("단위수량");
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.admin_id).HasComment("수정자");
            entity.Property(e => e.t_env_code).HasComment("봉투코드");
        });

        modelBuilder.Entity<S2_CardCorelTemplateInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("ERP카드그룹 관리<br>"));
        });

        modelBuilder.Entity<S2_CardDesigner>(entity =>
        {
            entity.HasKey(e => e.designer_id).HasName("PK_CIDX_S2_CardDesigner__designer_id");

            entity.ToTable(tb => tb.HasComment("카드디자이너 정보"));
        });

        modelBuilder.Entity<S2_CardDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드상세정보"));

            entity.HasIndex(e => e.Acc1_GroupSeq, "IDX__acc1_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.Acc1_Seq, "IDX__acc1_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Acc2_GroupSeq, "IDX__acc2_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.Acc2_Seq, "IDX__acc2_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Env_GroupSeq, "IDX__env_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.Env_Seq, "IDX__env_seq").HasFillFactor(90);

            entity.HasIndex(e => e.GreetingCard_GroupSeq, "IDX__greetingcard_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.GreetingCard_Seq, "IDX__greetingcard_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Inpaper_GroupSeq, "IDX__inpaper_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.Inpaper_Seq, "IDX__inpaper_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Lining_GroupSeq, "IDX__lining_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.Lining_Seq, "IDX__lining_seq").HasFillFactor(90);

            entity.HasIndex(e => e.MapCard_GroupSeq, "IDX__mapcard_groupseq").HasFillFactor(90);

            entity.HasIndex(e => e.MapCard_Seq, "IDX__mapcard_seq").HasFillFactor(90);

            entity.Property(e => e.Card_Seq).ValueGeneratedNever();
            entity.Property(e => e.Acc1_GroupSeq).HasComment("부속품1 그룹");
            entity.Property(e => e.Acc1_Seq).HasComment("부속품1");
            entity.Property(e => e.Acc2_GroupSeq).HasComment("부속품2 그룹");
            entity.Property(e => e.Acc2_Seq).HasComment("부속품2");
            entity.Property(e => e.AddMinimum_count).HasComment("추가주문시 최소 주문수량");
            entity.Property(e => e.Card_Content).HasComment("제품간략설명");
            entity.Property(e => e.Card_Folding).HasComment("E0:접선없음, G1:가로1번,G2,G3 S1:세로1번, S2:세로2번,S3:세로3번,S4:세로4번");
            entity.Property(e => e.Card_Keyword).HasComment("제품 키워드(위시/해피)");
            entity.Property(e => e.Card_Material).HasComment("카드 재질");
            entity.Property(e => e.Card_PrintMethod)
                .IsFixedLength()
                .HasComment("사용안함");
            entity.Property(e => e.Card_PrintOffice)
                .IsFixedLength()
                .HasComment("사용안함");
            entity.Property(e => e.Card_Shape)
                .IsFixedLength()
                .HasComment("사용안함");
            entity.Property(e => e.Card_Text).HasComment("제품설명");
            entity.Property(e => e.Card_Text_Premier).HasComment("프리미어페이퍼 제품설명");
            entity.Property(e => e.ColorInpaper_seq).HasComment("칼라내지");
            entity.Property(e => e.CuttingLineType).IsFixedLength();
            entity.Property(e => e.EnvCharge).IsFixedLength();
            entity.Property(e => e.Env_GroupSeq).HasComment("봉투 그룹");
            entity.Property(e => e.Env_Seq).HasComment("봉투 SEQ");
            entity.Property(e => e.GreetingCard_GroupSeq).HasComment("인사말카드 그룹");
            entity.Property(e => e.GreetingCard_Seq).HasComment("인사말카드");
            entity.Property(e => e.Inpaper_GroupSeq).HasComment("내지 그룹");
            entity.Property(e => e.Inpaper_Seq).HasComment("내지");
            entity.Property(e => e.Lining_GroupSeq).HasComment("라이닝 그룹");
            entity.Property(e => e.Lining_Seq).HasComment("라이닝");
            entity.Property(e => e.MapCard_GroupSeq).HasComment("약도카드 그룹");
            entity.Property(e => e.MapCard_Seq).HasComment("약도카드");
            entity.Property(e => e.Minimum_Count).HasComment("최소 주문수량");
            entity.Property(e => e.Sticker_GroupSeq).HasComment("스티커그룹");
            entity.Property(e => e.Sticker_seq).HasComment("스티커");
            entity.Property(e => e.Unit_Count)
                .IsFixedLength()
                .HasComment("단위 주문수량");
            entity.Property(e => e.seal_seq).HasComment("씰카드");
        });

        modelBuilder.Entity<S2_CardDetailEtc>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("답례품상세정보"));

            entity.Property(e => e.card_seq).ValueGeneratedNever();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isNew).IsFixedLength();
            entity.Property(e => e.isPlan).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardDetailSmart>(entity =>
        {
            entity.Property(e => e.card_seq).ValueGeneratedNever();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isNew).IsFixedLength();
            entity.Property(e => e.isPlan).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardDigitalColor>(entity =>
        {
            entity.Property(e => e.color_code).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardDiscount>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("할인율정보	"));

            entity.HasIndex(e => e.CardDiscount_Seq, "IDX__carddiscount_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Discount_Rate, "IDX__discount_rate").HasFillFactor(90);

            entity.HasIndex(e => e.MaxCount, "IDX__maxcount").HasFillFactor(90);

            entity.HasIndex(e => e.MinCount, "IDX__mincount").HasFillFactor(90);

            entity.Property(e => e.MinCount).HasComment("시작 주문수량");
            entity.Property(e => e.MaxCount).HasComment("최대 주문수량");
            entity.Property(e => e.Discount_Rate).HasComment("할인율");
        });

        modelBuilder.Entity<S2_CardDiscountInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("할인율관리	"));

            entity.Property(e => e.CardDiscount_Seq).HasComment("할인율 키");
            entity.Property(e => e.CardDiscount_Code).HasComment("관리 코드");
            entity.Property(e => e.CardDiscount_Div)
                .IsFixedLength()
                .HasComment("cardbrand");
            entity.Property(e => e.CardDiscount_Type)
                .IsFixedLength()
                .HasComment("R 할인율");
        });

        modelBuilder.Entity<S2_CardImage>(entity =>
        {
            entity.HasKey(e => e.CardImage_Seq).IsClustered(false);

            entity.HasIndex(e => e.CardImage_HSize, "IDX__cardimage_hsize").HasFillFactor(90);

            entity.HasIndex(e => e.CardImage_WSize, "IDX__cardimage_wsize").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Seq, "clu_Card_Seq")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CardImage_Div).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardInReferer>(entity =>
        {
            entity.Property(e => e.Use_YorN).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardItemGroup>(entity =>
        {
            entity.HasIndex(e => e.Card_Seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.CardItemGroup_Seq, "IDX__carditemgroup_seq").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_CardKind>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드종류"));

            entity.HasIndex(e => e.Card_Seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.CardKind_Seq, "IDX__cardkind_seq").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_CardKindInfo>(entity =>
        {
            entity.HasKey(e => e.CardKind_Seq).HasName("PK_S2_CardKind");

            entity.ToTable(tb => tb.HasComment("카드종류정보"));

            entity.Property(e => e.CardKind_Seq)
                .ValueGeneratedNever()
                .HasComment("주문타입");
            entity.Property(e => e.CardKind).HasComment("주문타입설명");
        });

        modelBuilder.Entity<S2_CardOption>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드옵션정보"));

            entity.Property(e => e.Card_Seq).ValueGeneratedNever();
            entity.Property(e => e.DigitalColor).HasComment("디지털 인쇄 칼라색상 종류");
            entity.Property(e => e.IsAdd)
                .IsFixedLength()
                .HasComment("추가주문 (0:불가,1:가능)");
            entity.Property(e => e.IsColorInpaper).IsFixedLength();
            entity.Property(e => e.IsColorPrint)
                .IsFixedLength()
                .HasComment("칼라인쇄 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsEmbo)
                .IsFixedLength()
                .HasComment("엠보인쇄 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsEmboColor)
                .IsFixedLength()
                .HasComment("엠보인쇄칼라(1:기본,2:진회색,3:은색,4:갈색,5:짙은청색,6:자주색)");
            entity.Property(e => e.IsEnvInsert)
                .IsFixedLength()
                .HasComment("봉투삽입 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsFChoice).IsFixedLength();
            entity.Property(e => e.IsHandmade)
                .IsFixedLength()
                .HasComment("부속품제본 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsHandmade2).IsFixedLength();
            entity.Property(e => e.IsHanji)
                .IsFixedLength()
                .HasComment("한지여부(1:일반한지,2:가로형고급한지,3:세로형고급한지)");
            entity.Property(e => e.IsInPaper).IsFixedLength();
            entity.Property(e => e.IsJaebon)
                .IsFixedLength()
                .HasComment("내지 끼우기 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsLiningJaebon)
                .IsFixedLength()
                .HasComment("봉투라이닝 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsOutsideInitial)
                .IsFixedLength()
                .HasComment("겉면인쇄여부");
            entity.Property(e => e.IsQuick)
                .IsFixedLength()
                .HasComment("초특급 가능 여부");
            entity.Property(e => e.IsSample)
                .IsFixedLength()
                .HasComment("샘플주문 (0:불가,1:가능)");
            entity.Property(e => e.IsSampleEnd).IsFixedLength();
            entity.Property(e => e.IsSensInpaper)
                .IsFixedLength()
                .HasComment("감성내지 (0:없음,1:있음)");
            entity.Property(e => e.IsSticker)
                .IsFixedLength()
                .HasComment("스티커제공 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.IsUsrComment)
                .IsFixedLength()
                .HasComment("주문시 사용자 멘트(0:없음,1:필요)");
            entity.Property(e => e.IsUsrImg1)
                .IsFixedLength()
                .HasComment("주문시 사용자 이미지업로드(0:없음,1:필요)");
            entity.Property(e => e.IsUsrImg2)
                .IsFixedLength()
                .HasComment("주문시 사용자 이미지업로드(0:없음,1:필요)");
            entity.Property(e => e.IsUsrImg3)
                .IsFixedLength()
                .HasComment("주문시 사용자 이미지업로드(0:없음,1:필요)");
            entity.Property(e => e.IsUsrImg4).IsFixedLength();
            entity.Property(e => e.Master_2Color).IsFixedLength();
            entity.Property(e => e.PrintMethod).HasComment("인쇄방법(XXX 세자리 캐릭터값이 다음과 같이 주어진다) G:금박,S:은박, B:먹박,0:박없음, 1:유광,0:무광, 1:형압,0:압없음");
            entity.Property(e => e.SpecialAccYN).IsFixedLength();
            entity.Property(e => e.embo_print).HasComment("엠보인쇄되는 항목(C:카드,P:약도카드,I:내지 등)");
            entity.Property(e => e.isColorMaster).IsFixedLength();
            entity.Property(e => e.isCustomDColor).IsFixedLength();
            entity.Property(e => e.isDesigner).HasComment("카드 디자이너");
            entity.Property(e => e.isDigitalColor)
                .IsFixedLength()
                .HasComment("디지털 인쇄 여부");
            entity.Property(e => e.isEngWedding).IsFixedLength();
            entity.Property(e => e.isEnvDesignType).IsFixedLength();
            entity.Property(e => e.isEnvSpecial)
                .IsFixedLength()
                .HasComment("고급봉투 가능여부");
            entity.Property(e => e.isEnvSpecialPrint).IsFixedLength();
            entity.Property(e => e.isFSC).IsFixedLength();
            entity.Property(e => e.isGreeting).IsFixedLength();
            entity.Property(e => e.isGroomBrideYN).IsFixedLength();
            entity.Property(e => e.isHappyPrice).IsFixedLength();
            entity.Property(e => e.isHoneyMoon).IsFixedLength();
            entity.Property(e => e.isInternalDigital).IsFixedLength();
            entity.Property(e => e.isJigunamu).IsFixedLength();
            entity.Property(e => e.isLInitial).IsFixedLength();
            entity.Property(e => e.isLanguage)
                .IsFixedLength()
                .HasComment("0:사용안함, 1:한글만, 2:영문만, 3:한/영선택");
            entity.Property(e => e.isLaser).IsFixedLength();
            entity.Property(e => e.isLaserCard).IsFixedLength();
            entity.Property(e => e.isLetterPress).IsFixedLength();
            entity.Property(e => e.isMasterDigital).IsFixedLength();
            entity.Property(e => e.isMasterPrintColor).IsFixedLength();
            entity.Property(e => e.isMiniCard).IsFixedLength();
            entity.Property(e => e.isMoneyEnv).IsFixedLength();
            entity.Property(e => e.isNewEvent).IsFixedLength();
            entity.Property(e => e.isNewGubun).IsFixedLength();
            entity.Property(e => e.isPhrase).IsFixedLength();
            entity.Property(e => e.isPutGiveCard).IsFixedLength();
            entity.Property(e => e.isRepinart).IsFixedLength();
            entity.Property(e => e.isSelfEditor)
                .IsFixedLength()
                .HasComment("셀프초안주문 (0:불가,1:가능)");
            entity.Property(e => e.isSpringYN).IsFixedLength();
            entity.Property(e => e.isStarcard).IsFixedLength();
            entity.Property(e => e.isTechnic).HasComment("테크닉가공 정보");
            entity.Property(e => e.isUsrImg_info).IsFixedLength();
            entity.Property(e => e.isWongoYN).IsFixedLength();
            entity.Property(e => e.isstickerspecial).IsFixedLength();
            entity.Property(e => e.outsourcing_print).HasComment("외부업체인쇄되는 항목(C:카드,P:약도카드,I:내지 등)");
        });

        modelBuilder.Entity<S2_CardOption_UsrImg>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("(더카드)포토카드 업로드 설명	"));

            entity.Property(e => e.uimg_info_img).HasComment("청첩장펼친이미지명");
            entity.Property(e => e.uimg_info_text).HasComment("업로드사진 설명");
            entity.Property(e => e.uimg_number).HasComment("사진갯수");
            entity.Property(e => e.uimg_subtitle).HasComment("사진위치");
            entity.Property(e => e.uimg_title).HasComment("제목");
        });

        modelBuilder.Entity<S2_CardPrintInfo>(entity =>
        {
            entity.Property(e => e.print_back).IsFixedLength();
            entity.Property(e => e.print_front).IsFixedLength();
            entity.Property(e => e.print_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardRank>(entity =>
        {
            entity.HasIndex(e => e.Card_Seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Company_Seq, "IDX__company_seq").HasFillFactor(90);

            entity.Property(e => e.Rank_Div).IsFixedLength();
            entity.Property(e => e.Rank_UpDown).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardSalesBest>(entity =>
        {
            entity.HasKey(e => new { e.Company_Seq, e.card_seq }).HasName("PK__S2_CardS__E49235E22F9ED46A");
        });

        modelBuilder.Entity<S2_CardSalesPrice>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S2_CardSalesSite>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("사이트별 카드 판매정보	"));

            entity.HasIndex(e => e.Company_Seq, "IDX__company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.IsDisplay, "IDX__isdisplay").HasFillFactor(90);

            entity.HasIndex(e => e.Ranking, "IDX__ranking").HasFillFactor(90);

            entity.Property(e => e.AppSample)
                .IsFixedLength()
                .HasComment("추천샘플 제품(고객 샘플 주문시 함께 발송카드)");
            entity.Property(e => e.IsBest)
                .IsFixedLength()
                .HasComment("베스트 상품");
            entity.Property(e => e.IsDisplay).IsFixedLength();
            entity.Property(e => e.IsExtra)
                .IsFixedLength()
                .HasComment("초특가제품");
            entity.Property(e => e.IsExtra2)
                .IsFixedLength()
                .HasComment("베스트 아이콘(임시)");
            entity.Property(e => e.IsInProduct).IsFixedLength();
            entity.Property(e => e.IsJehyu)
                .IsFixedLength()
                .HasComment("제휴카드 여부");
            entity.Property(e => e.IsJumun)
                .IsFixedLength()
                .HasComment("판매여부(1:판매가능,0:판매불가,2:원주문결제/추가주문가능,3:원주문결제만 가능,4:추가주문만 가능");
            entity.Property(e => e.IsNew)
                .IsFixedLength()
                .HasComment("신상품 여부");
            entity.Property(e => e.IsSale).IsFixedLength();
            entity.Property(e => e.Ranking_m).HasComment("월 랭킹");
            entity.Property(e => e.Ranking_w).HasComment("주 랭킹");
            entity.Property(e => e.input_date).HasComment("등록일");
            entity.Property(e => e.isDigitalCard).IsFixedLength();
            entity.Property(e => e.isNotCoupon)
                .IsFixedLength()
                .HasComment("쿠폰적용 불가 상품");
            entity.Property(e => e.isSummary).HasComment("설명");
        });

        modelBuilder.Entity<S2_CardSalesSite_backup>(entity =>
        {
            entity.Property(e => e.AppSample).IsFixedLength();
            entity.Property(e => e.IsBest).IsFixedLength();
            entity.Property(e => e.IsDisplay).IsFixedLength();
            entity.Property(e => e.IsExtra).IsFixedLength();
            entity.Property(e => e.IsExtra2).IsFixedLength();
            entity.Property(e => e.IsInProduct).IsFixedLength();
            entity.Property(e => e.IsJehyu).IsFixedLength();
            entity.Property(e => e.IsJumun).IsFixedLength();
            entity.Property(e => e.IsNew).IsFixedLength();
            entity.Property(e => e.IsSale).IsFixedLength();
            entity.Property(e => e.isDigitalCard).IsFixedLength();
            entity.Property(e => e.isNotCoupon).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardSamplePrice>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__S2_CardS__3213E83F27CC9EA1");

            entity.Property(e => e.id).ValueGeneratedNever();
        });

        modelBuilder.Entity<S2_CardSet_PriceTemp>(entity =>
        {
            entity.HasKey(e => e.Card_Code).HasName("PK__S2_CardS__6284A6BF1589FCAC");
        });

        modelBuilder.Entity<S2_CardSite>(entity =>
        {
            entity.Property(e => e.company_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<S2_CardSort>(entity =>
        {
            entity.HasIndex(e => e.Card_Code, "IDX__card_code").HasFillFactor(90);

            entity.HasIndex(e => e.ranking, "IDX__ranking").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_CardStyle>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드속성 카테고리"));

            entity.HasIndex(e => e.Card_Seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.CardStyle_Seq, "IDX__cardstyle_seq").HasFillFactor(90);

            entity.Property(e => e.CardStyle_Seq).HasComment("S2_CardStyleItme.cardstyle_seq");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S2_CardStyleItem>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드속성 카테고리정보	"));

            entity.HasIndex(e => e.CardStyle_Category, "IDX__cardstyle_category").HasFillFactor(90);

            entity.HasIndex(e => e.CardStyle_Site, "IDX__cardstyle_site").HasFillFactor(90);

            entity.Property(e => e.CardStyle_Seq).ValueGeneratedNever();
            entity.Property(e => e.CardStyle_Category).IsFixedLength();
            entity.Property(e => e.CardStyle_Num).HasComment("스타일명");
            entity.Property(e => e.CardStyle_Site).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardTechnic>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_CardTechnic__seq");

            entity.Property(e => e.technic_comment).HasComment("테크닉 설명");
            entity.Property(e => e.technic_image).HasComment("테크닉 참고이미지");
            entity.Property(e => e.technic_name).HasComment("테크닉 이름");
        });

        modelBuilder.Entity<S2_CardView>(entity =>
        {
            entity.ToView("S2_CardView");

            entity.Property(e => e.card_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewChasu>(entity =>
        {
            entity.ToView("S2_CardViewChasu");

            entity.Property(e => e.card_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewDisplay>(entity =>
        {
            entity.ToView("S2_CardViewDisplay");

            entity.Property(e => e.isDisplay).IsFixedLength();
            entity.Property(e => e.isJumun).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewMerge>(entity =>
        {
            entity.ToView("S2_CardViewMerge");

            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isHanji).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewN>(entity =>
        {
            entity.ToView("S2_CardViewN");

            entity.Property(e => e.card_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewNew>(entity =>
        {
            entity.ToView("S2_CardViewNew");

            entity.Property(e => e.card_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewOption>(entity =>
        {
            entity.ToView("S2_CardViewOption");

            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isHanji).IsFixedLength();
            entity.Property(e => e.isInitial).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardViewSMART>(entity =>
        {
            entity.ToView("S2_CardViewSMART");

            entity.Property(e => e.isDisplay).IsFixedLength();
            entity.Property(e => e.isJumun).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardView_TEST>(entity =>
        {
            entity.ToView("S2_CardView_TEST");

            entity.Property(e => e.card_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_Card_Detail_Sub>(entity =>
        {
            entity.Property(e => e.Step_1).IsFixedLength();
            entity.Property(e => e.Step_2).IsFixedLength();
            entity.Property(e => e.Step_3).IsFixedLength();
            entity.Property(e => e.Step_4).IsFixedLength();
            entity.Property(e => e.Step_5).IsFixedLength();
            entity.Property(e => e.Step_6).IsFixedLength();
        });

        modelBuilder.Entity<S2_CardxmlData>(entity =>
        {
            entity.HasIndex(e => e.Brand, "IDX__brand").HasFillFactor(90);

            entity.HasIndex(e => e.Card_Code, "IDX__card_code").HasFillFactor(90);

            entity.HasIndex(e => e.Gubun, "IDX__gubun").HasFillFactor(90);

            entity.Property(e => e.Brand).IsFixedLength();
            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.ImgSize).IsFixedLength();
        });

        modelBuilder.Entity<S2_CsPoll>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("cs 평가 질문/답변 관리"));

            entity.Property(e => e.qtype)
                .IsFixedLength()
                .HasComment("1:라디오,2:체크박스,3:구문입력");
            entity.Property(e => e.status).IsFixedLength();
        });

        modelBuilder.Entity<S2_CsPollAns>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("cs 평가 고객 답변"));
        });

        modelBuilder.Entity<S2_CsPollAnsDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("cs 평가 고객 주관식 답변"));
        });

        modelBuilder.Entity<S2_CustomizedCard>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_CustomizedCard__seq");

            entity.Property(e => e.custom_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_Event>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_Event__seq");

            entity.HasIndex(e => e.charge_use_num, "IDX__charge_use_num").HasFillFactor(90);

            entity.HasIndex(e => e.charge_use_seq, "IDX__charge_use_seq").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "IDX__company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.sales_gubun, "IDX__sales_gubun").HasFillFactor(90);

            entity.HasIndex(e => e.uid, "IDX__uid").HasFillFactor(90);

            entity.Property(e => e.charge_use).IsFixedLength();
        });

        modelBuilder.Entity<S2_EventAdmin_Log>(entity =>
        {
            entity.Property(e => e.charge_use).IsFixedLength();
        });

        modelBuilder.Entity<S2_EventBlog>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_EventBlog__seq");

            entity.HasIndex(e => e.company_seq, "IDX__company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.sales_gubun, "IDX__sales_gubun").HasFillFactor(90);

            entity.HasIndex(e => e.uid, "IDX__uid").HasFillFactor(90);

            entity.Property(e => e.provide).IsFixedLength();
            entity.Property(e => e.provide_no).IsFixedLength();
        });

        modelBuilder.Entity<S2_EventUse>(entity =>
        {
            entity.HasKey(e => e.charge_use_seq).HasName("PK_CIDX_S2_EventUse__charge_use_seq");

            entity.Property(e => e.charge_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_Event_flow>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_Event_flow__seq");
        });

        modelBuilder.Entity<S2_Event_love>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_Event_love__seq");
        });

        modelBuilder.Entity<S2_FAQ>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_FAQ__seq");

            entity.Property(e => e.blank_).IsFixedLength();
        });

        modelBuilder.Entity<S2_MailDomain>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_MailDomain__seq");

            entity.ToTable(tb => tb.HasComment("이메일 도메인"));
        });

        modelBuilder.Entity<S2_McardClickCount>(entity =>
        {
            entity.HasIndex(e => e.OrderSeq, "IDX_S2_McardClickCount_OrderSeq").HasFillFactor(90);

            entity.HasIndex(e => e.RegDate, "IDX_S2_McardClickCount_RegDate").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_MediaContents>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_MediaContents__seq");
        });

        modelBuilder.Entity<S2_MediaView>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_MediaView__seq");

            entity.Property(e => e.viewdiv).IsFixedLength();
        });

        modelBuilder.Entity<S2_News>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("뉴스기사"));

            entity.Property(e => e.URL_TARGET_BLANK_YORN).IsFixedLength();
            entity.Property(e => e.isdp).IsFixedLength();
        });

        modelBuilder.Entity<S2_Notice>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_Notice__seq");

            entity.ToTable(tb => tb.HasComment("공지사항"));

            entity.Property(e => e.blank_).IsFixedLength();
            entity.Property(e => e.notice_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_OrderViewMerge>(entity =>
        {
            entity.ToView("S2_OrderViewMerge");

            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isFPrint).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_OrderViewMerge_For_ChasuGroupSet>(entity =>
        {
            entity.ToView("S2_OrderViewMerge_For_ChasuGroupSet");

            entity.Property(e => e.GroupType).IsFixedLength();
            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isLaserCut).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_OrderViewMerge_For_ChasuGroupSet_Admin>(entity =>
        {
            entity.ToView("S2_OrderViewMerge_For_ChasuGroupSet_Admin");

            entity.Property(e => e.GroupType).IsFixedLength();
            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isLaserCut).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_OrderViewMerge_New>(entity =>
        {
            entity.ToView("S2_OrderViewMerge_New");

            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isLaserCut).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_OrderViewMerge_New_Admin>(entity =>
        {
            entity.ToView("S2_OrderViewMerge_New_Admin");

            entity.Property(e => e.card_div).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isLaserCut).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_PTRequest>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_PTRequest__seq");

            entity.ToTable(tb => tb.HasComment("제휴문의"));
        });

        modelBuilder.Entity<S2_ProductImage>(entity =>
        {
            entity.Property(e => e.CardImage_DIV).IsFixedLength();
        });

        modelBuilder.Entity<S2_RecommendCard>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_RecommendCard__seq");

            entity.HasIndex(e => e.card_seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "IDX__site_div").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_SampleBasket>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_SampleBasket__seq");

            entity.ToTable(tb => tb.HasComment("샘플장바구니"));

            entity.Property(e => e.MD_recommend).IsFixedLength();
        });

        modelBuilder.Entity<S2_Toss_Bank>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("모바일초대장 Toss은행코드"));

            entity.Property(e => e.BANK_CODE).HasComment("은행코드");
            entity.Property(e => e.BANK_NAME).HasComment("은행명");
            entity.Property(e => e.USE_YN).HasComment("사용유무");
        });

        modelBuilder.Entity<S2_USERBYE_SECESSION_CAUSE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("탈퇴 사유"));
        });

        modelBuilder.Entity<S2_USERINFO_SIGNUP_DEVICE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("고객 접근 디바이스 정보"));
        });

        modelBuilder.Entity<S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("3자 마케팅동의 로그"));
        });

        modelBuilder.Entity<S2_USER_DEVICE_TOKEN>(entity =>
        {
            entity.HasKey(e => e.S2_USER_DEVICE_TOKEN_SEQ).HasName("PK_S2_USER_TOKEN");
        });

        modelBuilder.Entity<S2_UserBye>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_UserBye__seq");

            entity.ToTable(tb => tb.HasComment("탈퇴 관리"));

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.NationalInfo).IsFixedLength();
            entity.Property(e => e.reason_1).IsFixedLength();
            entity.Property(e => e.reason_2).IsFixedLength();
            entity.Property(e => e.reason_3).IsFixedLength();
            entity.Property(e => e.reason_4).IsFixedLength();
            entity.Property(e => e.reason_5).IsFixedLength();
            entity.Property(e => e.reason_6).IsFixedLength();
            entity.Property(e => e.reason_7).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserCardView>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_S2_UserCardView1");

            entity.Property(e => e.site_div).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserComment>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_UserComment__seq");

            entity.ToTable(tb => tb.HasComment("바비프몰 이용후기"));

            entity.HasIndex(e => e.card_code, "IDX__card_code").HasFillFactor(90);

            entity.HasIndex(e => e.card_seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "IDX__company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "IDX__order_seq").HasFillFactor(90);

            entity.HasIndex(e => e.sales_gubun, "IDX__sales_gubun").HasFillFactor(90);

            entity.HasIndex(e => e.reg_date, "NCI_REG_DATE").HasFillFactor(90);

            entity.Property(e => e.EVENT_STATUS_CODE).IsFixedLength();
            entity.Property(e => e.comm_div).IsFixedLength();
            entity.Property(e => e.isBest)
                .IsFixedLength()
                .HasComment(" 0:심사중 , 1:당첨축하 , 3:승인보류");
            entity.Property(e => e.isDP)
                .IsFixedLength()
                .HasComment("전시여부");
            entity.Property(e => e.score).HasComment("별점");
        });

        modelBuilder.Entity<S2_UserCommentBest>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이용후기 베스트"));

            entity.HasIndex(e => e.best_date, "IX_CommentBest_date")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasOne(d => d.best_seqNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsrCommentBest_Comment");
        });

        modelBuilder.Entity<S2_UserComment_Copy>(entity =>
        {
            entity.Property(e => e.EVENT_STATUS_CODE).IsFixedLength();
            entity.Property(e => e.comm_div).IsFixedLength();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isDP).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S2_UserComment_ETC_reply>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("프페부가상품 이용후기"));
        });

        modelBuilder.Entity<S2_UserComment_Reply>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이용후기 답변"));
        });

        modelBuilder.Entity<S2_UserComment_etc>(entity =>
        {
            entity.Property(e => e.isDP).IsFixedLength();
            entity.Property(e => e.isbest).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S2_UserComment_photo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이용후기 사진업로드 관련"));
        });

        modelBuilder.Entity<S2_UserComment_photo_the>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("(더카드)이용후기 사진업로드 관련"));

            entity.Property(e => e.img_name).HasComment("이미지원본파일명");
            entity.Property(e => e.upimg_name).HasComment("이미지업로드파일명");
        });

        modelBuilder.Entity<S2_UserInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("고객정보"));

            entity.HasIndex(e => e.reg_date, "IDX_S2_UserInfo_Reg_Date").HasFillFactor(90);

            entity.HasIndex(e => e.umail, "IDX_S2_UserInfo_umail").HasFillFactor(90);

            entity.HasIndex(e => new { e.hand_phone1, e.hand_phone2, e.hand_phone3 }, "IDX_hand_phone123").HasFillFactor(90);

            entity.HasIndex(e => new { e.phone1, e.phone2, e.phone3 }, "IDX_phone123").HasFillFactor(90);

            entity.HasIndex(e => e.ConnInfo, "NCI_CONNINFO").HasFillFactor(90);

            entity.HasIndex(e => e.DupInfo, "NCI_DUPINFO").HasFillFactor(90);

            entity.HasIndex(e => e.REFERER_SALES_GUBUN, "NCI_REFERER_SALES_GUBUN").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "NCI_SITE_DIV").HasFillFactor(90);

            entity.HasIndex(e => new { e.uid, e.DupInfo }, "NCI_USERINFO_UID_DUPINFO").HasFillFactor(90);

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.DupInfo).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.INTEGRATION_MEMBER_YORN).IsFixedLength();
            entity.Property(e => e.NationalInfo).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.birth_div).IsFixedLength();
            entity.Property(e => e.chk_DM).IsFixedLength();
            entity.Property(e => e.chk_DormancyAccount).IsFixedLength();
            entity.Property(e => e.chk_iloommembership).IsFixedLength();
            entity.Property(e => e.chk_lgmembership).IsFixedLength();
            entity.Property(e => e.chk_mail_input).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_myomee).IsFixedLength();
            entity.Property(e => e.chk_smembership).IsFixedLength();
            entity.Property(e => e.chk_smembership_coop).IsFixedLength();
            entity.Property(e => e.chk_smembership_leave).IsFixedLength();
            entity.Property(e => e.chk_smembership_per).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isMCardAble).IsFixedLength();
            entity.Property(e => e.is_appSample).IsFixedLength();
            entity.Property(e => e.mkt_chk_flag).IsFixedLength();
            entity.Property(e => e.smembership_chk_flag).IsFixedLength();
            entity.Property(e => e.wedd_pgubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserInfo_BHands>(entity =>
        {
            entity.HasKey(e => new { e.uid, e.jumin }).HasName("PK_CIDX_S2_UserInfo_BHands__uid");

            entity.ToTable(tb => tb.HasComment("비핸즈 회원테이블"));

            entity.HasIndex(e => e.reg_date, "IDX_S2_UserInfo_Bhands_Reg_Date").HasFillFactor(90);

            entity.HasIndex(e => e.hand_phone1, "IDX_hand_phone1").HasFillFactor(90);

            entity.HasIndex(e => new { e.hand_phone1, e.hand_phone2, e.hand_phone3 }, "IDX_hand_phone123").HasFillFactor(90);

            entity.HasIndex(e => e.hand_phone2, "IDX_hand_phone2").HasFillFactor(90);

            entity.HasIndex(e => e.hand_phone3, "IDX_hand_phone3").HasFillFactor(90);

            entity.HasIndex(e => e.phone1, "IDX_phone1").HasFillFactor(90);

            entity.HasIndex(e => new { e.phone1, e.phone2, e.phone3 }, "IDX_phone123").HasFillFactor(90);

            entity.HasIndex(e => e.phone2, "IDX_phone2").HasFillFactor(90);

            entity.HasIndex(e => e.phone3, "IDX_phone3").HasFillFactor(90);

            entity.HasIndex(e => e.ConnInfo, "NCI_CONNINFO").HasFillFactor(90);

            entity.HasIndex(e => e.DupInfo, "NCI_DUPINFO").HasFillFactor(90);

            entity.HasIndex(e => e.REFERER_SALES_GUBUN, "NCI_REFERER_SALES_GUBUN").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "NCI_SITE_DIV").HasFillFactor(90);

            entity.HasIndex(e => new { e.uid, e.DupInfo }, "NCI_USERINFO_BHANDS_UID_DUPINFO").HasFillFactor(90);

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.DupInfo).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.INTEGRATION_MEMBER_YORN).IsFixedLength();
            entity.Property(e => e.NationalInfo).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.addr_flag).HasComment("0:구주소,1:신도로주");
            entity.Property(e => e.birth_div).IsFixedLength();
            entity.Property(e => e.chk_DM).IsFixedLength();
            entity.Property(e => e.chk_DormancyAccount).IsFixedLength();
            entity.Property(e => e.chk_iloommembership).IsFixedLength();
            entity.Property(e => e.chk_lgmembership).IsFixedLength();
            entity.Property(e => e.chk_mail_input).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_myomee).IsFixedLength();
            entity.Property(e => e.chk_smembership).IsFixedLength();
            entity.Property(e => e.chk_smembership_coop).IsFixedLength();
            entity.Property(e => e.chk_smembership_leave).IsFixedLength();
            entity.Property(e => e.chk_smembership_per).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isMCardAble).IsFixedLength();
            entity.Property(e => e.is_appSample).IsFixedLength();
            entity.Property(e => e.mkt_chk_flag).IsFixedLength();
            entity.Property(e => e.smembership_chk_flag).IsFixedLength();
            entity.Property(e => e.var1).HasComment("이지웰 연동 회원일 경우 유저키값을 저장");
            entity.Property(e => e.wedd_pgubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserInfo_Deardeer>(entity =>
        {
            entity.HasKey(e => e.uid)
                .HasName("PRIMARY")
                .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("사용자관리"));

            entity.Property(e => e.uid).HasComment("아이디");
            entity.Property(e => e.addr_detail).HasComment("주소2");
            entity.Property(e => e.address).HasComment("주소1");
            entity.Property(e => e.birth).HasComment("생일");
            entity.Property(e => e.birth_div)
                .IsFixedLength()
                .HasComment("생일구분");
            entity.Property(e => e.chk_mailservice)
                .IsFixedLength()
                .HasComment("이메일 수신동의여부");
            entity.Property(e => e.chk_sms)
                .IsFixedLength()
                .HasComment("SMS 수신동의여부");
            entity.Property(e => e.conninfo).HasComment("고유번호");
            entity.Property(e => e.dupinfo).HasComment("중복가입확인번호");
            entity.Property(e => e.gender)
                .IsFixedLength()
                .HasComment("성별 - F: 여자, M: 남자");
            entity.Property(e => e.hand_phone1).HasComment("휴대전화1");
            entity.Property(e => e.hand_phone2).HasComment("휴대전화2");
            entity.Property(e => e.hand_phone3).HasComment("휴대전화3");
            entity.Property(e => e.mod_date).HasComment("수정일");
            entity.Property(e => e.phone1).HasComment("휴대전화");
            entity.Property(e => e.phone2).HasComment("전화번호2");
            entity.Property(e => e.phone3).HasComment("전화번호3");
            entity.Property(e => e.reg_date).HasComment("등록일");
            entity.Property(e => e.site_div).HasComment("가입채널");
            entity.Property(e => e.umail).HasComment("이메일");
            entity.Property(e => e.uname).HasComment("이름");
            entity.Property(e => e.wedd_day).HasComment("예식일");
            entity.Property(e => e.wedd_month).HasComment("예식월");
            entity.Property(e => e.wedd_pggubun).IsFixedLength();
            entity.Property(e => e.wedd_year).HasComment("회원가입 예상 예식일자");
            entity.Property(e => e.zip1).HasComment("우편번호1");
            entity.Property(e => e.zip2).HasComment("우편번호2");
        });

        modelBuilder.Entity<S2_UserInfo_Deardeer_Marketing>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("마케팅동의(신규)"));

            entity.Property(e => e.seq).HasComment("마케팅동의ID");
            entity.Property(e => e.agree_date).HasComment("동의일시");
            entity.Property(e => e.agreement_step).IsFixedLength();
            entity.Property(e => e.agreement_type).HasComment("동의구분");
            entity.Property(e => e.cancel_date).HasComment("취소일시");
            entity.Property(e => e.cancel_uid).HasComment("취소아이디");
            entity.Property(e => e.chk_agreement)
                .IsFixedLength()
                .HasComment("동의여부");
            entity.Property(e => e.uid).HasComment("회원ID");
        });

        modelBuilder.Entity<S2_UserInfo_Deardeer_Marketing_View>(entity =>
        {
            entity.HasKey(e => new { e.uid, e.agreement_step }).IsClustered(false);

            entity.Property(e => e.agreement_step).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserInfo_Jehu>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PartnerCode }).HasName("PK_S2_UserInfo_Jehu_1");
        });

        modelBuilder.Entity<S2_UserInfo_TheCard>(entity =>
        {
            entity.HasKey(e => new { e.uid, e.jumin }).HasName("PK_CIDX_S2_UserInfo_TheCard__uid");

            entity.ToTable(tb => tb.HasComment("더카드 회원테이블"));

            entity.HasIndex(e => e.reg_date, "IDX_S2_UserInfo_TheCard_Reg_Date").HasFillFactor(90);

            entity.HasIndex(e => new { e.hand_phone1, e.hand_phone2, e.hand_phone3 }, "IDX_hand_phone123").HasFillFactor(90);

            entity.HasIndex(e => e.hand_phone2, "IDX_hand_phone2").HasFillFactor(90);

            entity.HasIndex(e => e.hand_phone3, "IDX_hand_phone3").HasFillFactor(90);

            entity.HasIndex(e => new { e.phone1, e.phone2, e.phone3 }, "IDX_phone123").HasFillFactor(90);

            entity.HasIndex(e => e.phone2, "IDX_phone2").HasFillFactor(90);

            entity.HasIndex(e => e.phone3, "IDX_phone3").HasFillFactor(90);

            entity.HasIndex(e => e.ConnInfo, "NCI_CONNINFO").HasFillFactor(90);

            entity.HasIndex(e => e.DupInfo, "NCI_DUPINFO").HasFillFactor(90);

            entity.HasIndex(e => e.INTERGRATION_DATE, "NCI_INTERGRATION_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.REFERER_SALES_GUBUN, "NCI_REFERER_SALES_GUBUN").HasFillFactor(90);

            entity.HasIndex(e => e.SELECT_SALES_GUBUN, "NCI_SELECT_SALES_GUBUN").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "NCI_SITE_DIV").HasFillFactor(90);

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.DupInfo).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.INTEGRATION_MEMBER_YORN).IsFixedLength();
            entity.Property(e => e.NationalInfo).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.birth_div).IsFixedLength();
            entity.Property(e => e.chk_DM).IsFixedLength();
            entity.Property(e => e.chk_DormancyAccount).IsFixedLength();
            entity.Property(e => e.chk_iloommembership).IsFixedLength();
            entity.Property(e => e.chk_lgmembership).IsFixedLength();
            entity.Property(e => e.chk_mail_input).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_myomee).IsFixedLength();
            entity.Property(e => e.chk_smembership).IsFixedLength();
            entity.Property(e => e.chk_smembership_coop).IsFixedLength();
            entity.Property(e => e.chk_smembership_leave).IsFixedLength();
            entity.Property(e => e.chk_smembership_per).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isMCardAble).IsFixedLength();
            entity.Property(e => e.is_appSample).IsFixedLength();
            entity.Property(e => e.mkt_chk_flag).IsFixedLength();
            entity.Property(e => e.smembership_chk_flag).IsFixedLength();
            entity.Property(e => e.wedd_pgubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_UserQnA>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("고객문의"));

            entity.HasIndex(e => e.qa_iid, "CI_S2_USERQNA")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "NCI_S2_USERQNA_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.member_id, "NCI_S2_USERQNA_MEMBER_ID").HasFillFactor(90);

            entity.Property(e => e.a_content).HasComment("답변한 내용");
            entity.Property(e => e.a_dt).HasComment("답변한 날짜");
            entity.Property(e => e.a_id).HasComment("답변한 상담원 아이디");
            entity.Property(e => e.a_research1).IsFixedLength();
            entity.Property(e => e.a_research2).IsFixedLength();
            entity.Property(e => e.a_research_date).IsFixedLength();
            entity.Property(e => e.a_stat).HasComment("답변 구분(S1:등록, S2:처리중, S3:답변등록, S4:삭제)");
            entity.Property(e => e.card_code).HasComment("제품코드");
            entity.Property(e => e.chk_mail_input)
                .IsFixedLength()
                .HasComment("이메일 입력 방법 (Y:직접입력, N:선택입력)");
            entity.Property(e => e.e_mail).HasComment("이메일");
            entity.Property(e => e.isMail)
                .IsFixedLength()
                .HasComment("메일 수신 여부 (0:no, 1:yes)");
            entity.Property(e => e.isSMS)
                .IsFixedLength()
                .HasComment("sms 문자 수신 여부 (0:no, 1:yes)");
            entity.Property(e => e.isSecret)
                .IsFixedLength()
                .HasComment("비공개 (0:no, 1:yes)");
            entity.Property(e => e.member_id).HasComment("회원ID");
            entity.Property(e => e.member_name).HasComment("이름");
            entity.Property(e => e.order_seq).HasComment("주문번호");
            entity.Property(e => e.q_content).HasComment("질문 내용");
            entity.Property(e => e.q_kind).HasComment("질문 구분 (K2:결제부분, K4:배송관련, K5:상품문의, K7:추가주문문의, K8:서비스문의, K9:이벤트문의, K10:시스템문의, K11:개인정보문의)");
            entity.Property(e => e.q_title).HasComment("질문 제목");
            entity.Property(e => e.qa_iid).ValueGeneratedOnAdd();
            entity.Property(e => e.reg_dt).HasComment("작성일");
            entity.Property(e => e.tel_no).HasComment("연락처");
            entity.Property(e => e.user_upfile1).HasComment("첨부파일1");
            entity.Property(e => e.user_upfile2).HasComment("첨부파일2");
        });

        modelBuilder.Entity<S2_UserQnA_Boton>(entity =>
        {
            entity.Property(e => e.a_research1).IsFixedLength();
            entity.Property(e => e.a_research2).IsFixedLength();
            entity.Property(e => e.a_research_date).IsFixedLength();
            entity.Property(e => e.chk_mail_input).IsFixedLength();
            entity.Property(e => e.isMail).IsFixedLength();
            entity.Property(e => e.isSMS).IsFixedLength();
            entity.Property(e => e.isSecret).IsFixedLength();
            entity.Property(e => e.qa_iid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S2_Userinfo_HiPlaza_Log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_S2_Userinfo_HiPlaza_Log_1");

            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.P_RQST_FLAG).HasComment("유입경로(디얼디어:DEAR, 바른손:BSON)");
            entity.Property(e => e.reg_date).HasComment("LG 하이플라자 가입 정보 발송 로그");
        });

        modelBuilder.Entity<S2_Userinfo_HiPlaza_store>(entity =>
        {
            entity.HasKey(e => new { e.si_do, e.gu_gun }).HasName("PK_S2_Userinfo_HiPlaza_Store");

            entity.Property(e => e.org_cd).IsFixedLength();
            entity.Property(e => e.stock_org_cd).IsFixedLength();
        });

        modelBuilder.Entity<S2_Userinfo_HiPlaza_zipcode>(entity =>
        {
            entity.Property(e => e.zipcode).IsFixedLength();
        });

        modelBuilder.Entity<S2_WishCard>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_WishCard__seq");

            entity.HasIndex(e => e.card_seq, "IDX__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "IDX__site_div").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_WishGreeting>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_WishGreeting__seq");

            entity.HasIndex(e => e.greeting_seq, "IDX__greeting_seq").HasFillFactor(90);

            entity.HasIndex(e => e.site_div, "IDX__site_div").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_WishMap>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S2_WishMap__seq");

            entity.HasIndex(e => e.site_div, "IDX__site_div").HasFillFactor(90);

            entity.HasIndex(e => e.weddimg_idx, "IDX__weddimg_idx").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_eCardBest>(entity =>
        {
            entity.Property(e => e.Order_Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<S2_eCardBoard>(entity =>
        {
            entity.HasIndex(e => e.Order_Seq, "IDX__S2_eCardBoard__Order_Seq").HasFillFactor(90);
        });

        modelBuilder.Entity<S2_eCardOrder>(entity =>
        {
            entity.HasIndex(e => e.worder_seq, "IDX__S2_eCardOrder__worder_seq").HasFillFactor(90);

            entity.HasIndex(e => e.Company_Seq, "NCI_S2_ECARDORDER_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.Uid, "NCI_S2_ECARDORDER_UID").HasFillFactor(90);

            entity.HasIndex(e => new { e.Uid, e.Company_Seq }, "NCI_S2_ECARDORDER_UID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.Order_Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.IsOpen).IsFixedLength();
            entity.Property(e => e.Skin_Seq).IsFixedLength();
            entity.Property(e => e.event_ampm).IsFixedLength();
            entity.Property(e => e.order_state)
                .IsFixedLength()
                .HasComment("0:삭제, 1:사용");
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.status_seq).HasComment("2:주문완료");
            entity.Property(e => e.weddinghall_type).IsFixedLength();
        });

        modelBuilder.Entity<S2_mCardOrder>(entity =>
        {
            entity.HasIndex(e => e.worder_seq, "IDX_S2_mCardOrder_WOrder_Seq")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Company_Seq, "NCI_S2_MCARDORDER_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.Uid, "NCI_S2_MCARDORDER_UID").HasFillFactor(90);

            entity.Property(e => e.IsOpen).IsFixedLength();
            entity.Property(e => e.event_ampm).IsFixedLength();
            entity.Property(e => e.order_state).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<S2_media>(entity =>
        {
            entity.Property(e => e.isdp).IsFixedLength();
        });

        modelBuilder.Entity<S2_orderLst>(entity =>
        {
            entity.ToView("S2_orderLst");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.fetype).IsFixedLength();
            entity.Property(e => e.ftype).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isCCG).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvInsert).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_orderLstN>(entity =>
        {
            entity.ToView("S2_orderLstN");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isCCG).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvCharge).IsFixedLength();
            entity.Property(e => e.isEnvInsert).IsFixedLength();
            entity.Property(e => e.isEnvSpecial).IsFixedLength();
            entity.Property(e => e.isLiningJaebon).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_orderLstN_>(entity =>
        {
            entity.ToView("S2_orderLstN_");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvCharge).IsFixedLength();
            entity.Property(e => e.isEnvInsert).IsFixedLength();
            entity.Property(e => e.isEnvSpecial).IsFixedLength();
            entity.Property(e => e.isLiningJaebon).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_orderLstN_20201113>(entity =>
        {
            entity.ToView("S2_orderLstN_20201113");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvCharge).IsFixedLength();
            entity.Property(e => e.isEnvInsert).IsFixedLength();
            entity.Property(e => e.isEnvSpecial).IsFixedLength();
            entity.Property(e => e.isLiningJaebon).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<S2_price_code>(entity =>
        {
            entity.Property(e => e.brand).IsFixedLength();
        });

        modelBuilder.Entity<S2_product>(entity =>
        {
            entity.Property(e => e.jumun_1).IsFixedLength();
            entity.Property(e => e.jumun_2).IsFixedLength();
            entity.Property(e => e.jumun_3).IsFixedLength();
        });

        modelBuilder.Entity<S4_BHANDS_EVENT_BANNER>(entity =>
        {
            entity.Property(e => e.BAND_BANNER_YN).IsFixedLength();
            entity.Property(e => e.EVENT_OPEN_YORN).IsFixedLength();
            entity.Property(e => e.JEHU_VIEW_DIV).IsFixedLength();
            entity.Property(e => e.SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.VIEW_DIV).IsFixedLength();
            entity.Property(e => e.WING_BANNER_YN).IsFixedLength();
        });

        modelBuilder.Entity<S4_BestTotalRanking_BHands>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S4_BestT__BC6E615610903D65");

            entity.ToTable(tb => tb.HasComment("비핸즈 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S4_BestTotalRanking_BSmall>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S4_BestT__BC6E61569E801409");

            entity.ToTable(tb => tb.HasComment("바른손몰 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S4_BestTotalRanking_Barunson>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S4_BestT__BC6E615629D0EC7B");

            entity.ToTable(tb => tb.HasComment("바른손 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S4_BestTotalRanking_Premier>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S4_BestT__BC6E61560E72EAC9");

            entity.ToTable(tb => tb.HasComment("프리미어 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S4_BestTotalRanking_TheCard>(entity =>
        {
            entity.HasKey(e => new { e.Gubun_date, e.Gubun, e.SubGubun, e.RankNo }).HasName("PK__S4_BestT__BC6E61560BCB8848");

            entity.ToTable(tb => tb.HasComment("더카드 랭킹"));

            entity.Property(e => e.Gubun).IsFixedLength();
            entity.Property(e => e.SubGubun).IsFixedLength();
        });

        modelBuilder.Entity<S4_CART>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 장바구니"));

            entity.HasIndex(e => e.COMPANY_SEQ, "NCI_S4_CART_CART_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.CART_OWNER_ID, "NCI_S4_CART_CART_OWNER_ID").HasFillFactor(90);

            entity.HasIndex(e => new { e.CART_OWNER_ID, e.COMPANY_SEQ }, "NCI_S4_CART_CART_OWNER_ID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.CART_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.ORDER_TYPE)
                .IsFixedLength()
                .HasComment("O:시판주문,S:샘플주문");
        });

        modelBuilder.Entity<S4_COUPON>(entity =>
        {
            entity.HasIndex(e => e.coupon_code, "NCI_COUPON_CODE").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "NCI_S4_COUPON_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.uid, "NCI_S4_COUPON_UID").HasFillFactor(90);

            entity.HasIndex(e => new { e.uid, e.company_seq }, "NCI_S4_COUPON_UID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.cardbrand).IsFixedLength();
            entity.Property(e => e.discount_type).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isRecycle).IsFixedLength();
            entity.Property(e => e.isWeddingCoupon).IsFixedLength();
            entity.Property(e => e.isYN).IsFixedLength();
        });

        modelBuilder.Entity<S4_CPC_Sub_Statics>(entity =>
        {
            entity.HasIndex(e => new { e.S4_CPC_Sub_Code, e.S4_CPC_Sub_Regdate }, "IX_S4_CPC_Sub_Statics").HasFillFactor(90);
        });

        modelBuilder.Entity<S4_CS_Member>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_CS_Member__seq");

            entity.ToTable(tb => tb.HasComment("cs 팀원 정보"));

            entity.Property(e => e.act_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_CardImage_Str>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드)이미지 설명"));
        });

        modelBuilder.Entity<S4_Card_Talk>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Card_Talk__seq");

            entity.ToTable(tb => tb.HasComment("더카드)카드질문"));

            entity.Property(e => e.seq).ValueGeneratedNever();
            entity.Property(e => e.chk_send_mail).IsFixedLength();
            entity.Property(e => e.chk_send_sms).IsFixedLength();
        });

        modelBuilder.Entity<S4_Change_intra_id>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_Coupon_OKC>(entity =>
        {
            entity.Property(e => e.isAdminYN).IsFixedLength();
            entity.Property(e => e.isYN).IsFixedLength();
        });

        modelBuilder.Entity<S4_EventBlog>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.isOpen).IsFixedLength();
            entity.Property(e => e.isSelection).IsFixedLength();
        });

        modelBuilder.Entity<S4_EventBlog_Gifticon>(entity =>
        {
            entity.Property(e => e.gifticon_type).IsFixedLength();
            entity.Property(e => e.isSms).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_EventManager>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_EventManagerComment>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_EventManagerComment__seq");
        });

        modelBuilder.Entity<S4_EventMusic_Reply>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_EventMusic_Reply__seq");

            entity.ToTable(tb => tb.HasComment("이벤트 댓글"));
        });

        modelBuilder.Entity<S4_EventMusic_Str>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("댓글 이벤트"));

            entity.Property(e => e.duplication_yn)
                .IsFixedLength()
                .HasComment("이벤트 중복참여 가능여부, Y : 중복참여가능");
        });

        modelBuilder.Entity<S4_EventMusic_Str_Temp>(entity =>
        {
            entity.Property(e => e.duplication_yn).IsFixedLength();
        });

        modelBuilder.Entity<S4_EventOnliving>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_EventOnliving__seq");

            entity.ToTable(tb => tb.HasComment("더카드 이벤트"));
        });

        modelBuilder.Entity<S4_EventOnliving_Reply>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_EventOnliving_Reply__seq");

            entity.Property(e => e.isDisplay).IsFixedLength();
        });

        modelBuilder.Entity<S4_EventRelay_Reply>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_EventRelay_Reply__seq");
        });

        modelBuilder.Entity<S4_Event_Blank_Keyword>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("프리미어 빈칸이벤트"));
        });

        modelBuilder.Entity<S4_Event_Halloween>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("할로윈 이벤트"));
        });

        modelBuilder.Entity<S4_Event_Raina>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("3자동의"));

            entity.Property(e => e.inflow_route).IsFixedLength();
        });

        modelBuilder.Entity<S4_Event_Review>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘플이용후기"));

            entity.HasIndex(e => e.ER_Card_Seq, "IDX_S4_Event_Review_ER_CardSeq").HasFillFactor(90);

            entity.HasIndex(e => e.ER_Regdate, "NCI_ER_REGDATE").HasFillFactor(90);

            entity.HasIndex(e => e.ER_isBest, "NCI_ISBEST").HasFillFactor(90);

            entity.HasIndex(e => e.ER_UserId, "NCI_S4_EVENT_REVIEW_ER_USERID").HasFillFactor(90);

            entity.Property(e => e.ER_Comm_Div).IsFixedLength();
            entity.Property(e => e.ER_Status).HasComment("승인여");
            entity.Property(e => e.ER_View).HasComment("전시/비전시여부");
            entity.Property(e => e.ER_isBest).IsFixedLength();
            entity.Property(e => e.ER_isPhoto).IsFixedLength();
        });

        modelBuilder.Entity<S4_Event_ReviewBest>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이용후기 베스트"));

            entity.Property(e => e.best_date).HasComment("");
            entity.Property(e => e.best_seq).HasComment("");
            entity.Property(e => e.comment).HasComment("");
            entity.Property(e => e.reg_date).HasComment("");

            entity.HasOne(d => d.best_seqNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_ReviewBest_Comment");
        });

        modelBuilder.Entity<S4_Event_Review_New>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 샘플이용후기"));

            entity.HasIndex(e => e.ER_Company_Seq, "NCI_S4_EVENTREVIEW_NEW_ER_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.ER_UserId, "NCI_S4_EVENTREVIEW_NEW_ER_USERID").HasFillFactor(90);

            entity.HasIndex(e => new { e.ER_UserId, e.ER_Company_Seq }, "NCI_S4_EVENTREVIEW_NEW_ER_USERID_ER_COMPANY_SEQ").HasFillFactor(90);
        });

        modelBuilder.Entity<S4_Event_Review_Status>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘플이용후기 관리자답변"));

            entity.HasIndex(e => e.ERA_ER_idx, "NCI_ERA_ER_IDX").HasFillFactor(90);

            entity.HasIndex(e => e.ERA_Status, "NCI_ERA_STATUS").HasFillFactor(90);

            entity.Property(e => e.ERA_Coupon_Status).HasComment("실쿠폰 전송여부 0:미전송, 1:전");
            entity.Property(e => e.ERA_Status).HasComment("글상태 0:승인대기, 1:승인완료, 2:발급취소");
        });

        modelBuilder.Entity<S4_Event_Review_Status_New>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 샘플이용후기 관리자답변"));
        });

        modelBuilder.Entity<S4_Event_Review_photo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘플후기 사진업로드 관련"));
        });

        modelBuilder.Entity<S4_Event_install>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("바로가기.즐겨찾기 참여"));

            entity.Property(e => e.desktop_install).IsFixedLength();
            entity.Property(e => e.favorite_install).IsFixedLength();
            entity.Property(e => e.isSelection).IsFixedLength();
            entity.Property(e => e.isUsed).IsFixedLength();
        });

        modelBuilder.Entity<S4_Holiday>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("휴일 관리"));

            entity.Property(e => e.TYPE).IsFixedLength();
        });

        modelBuilder.Entity<S4_LoginIpInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("로그인 정보"));

            entity.HasIndex(e => e.COMPANY_SEQ, "NCI-COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.IP, "NCI-IP").HasFillFactor(90);

            entity.HasIndex(e => e.REGDATE, "NCI-REGDATE").HasFillFactor(90);

            entity.HasIndex(e => e.UID, "NCI-UID").HasFillFactor(90);

            entity.HasIndex(e => e.SEQ, "PK_CIDX_S4_LoginIpInfo")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.SEQ).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_MARKETING_AGREEMENT_LOG>(entity =>
        {
            entity.Property(e => e.SEQ).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_MD_Choice>(entity =>
        {
            entity.HasKey(e => e.SEQ).HasName("PK_CIDX_S4_MD_Choice__seq");

            entity.ToTable(tb => tb.HasComment("기획전 등록 제품"));

            entity.Property(e => e.EVENT_OPEN_YORN).IsFixedLength();
            entity.Property(e => e.JEHU_VIEW_DIV).IsFixedLength();
            entity.Property(e => e.SNS_SHARE_YORN).IsFixedLength();
            entity.Property(e => e.VIEW_DIV).IsFixedLength();
        });

        modelBuilder.Entity<S4_MD_Choice_ProdBanner>(entity =>
        {
            entity.Property(e => e.banner_status).IsFixedLength();
            entity.Property(e => e.item_type1_yorn).IsFixedLength();
            entity.Property(e => e.item_type2_yorn).IsFixedLength();
            entity.Property(e => e.mo_content).HasComment("Mobile 배너 설명");
            entity.Property(e => e.mo_new_win_yorn).IsFixedLength();
            entity.Property(e => e.mo_show_yorn).IsFixedLength();
            entity.Property(e => e.mo_title).HasComment("Mobile 배너 제목");
            entity.Property(e => e.pc_content).HasComment("Pc 배너 설명");
            entity.Property(e => e.pc_new_win_yorn).IsFixedLength();
            entity.Property(e => e.pc_show_yorn).IsFixedLength();
            entity.Property(e => e.pc_title).HasComment("Pc 배너 제목");
            entity.Property(e => e.target_type).IsFixedLength();
            entity.Property(e => e.use_yorn).IsFixedLength();
        });

        modelBuilder.Entity<S4_MD_Choice_Str>(entity =>
        {
            entity.HasKey(e => e.md_seq).HasName("PK_CIDX_S4_MD_Choice_Str__md_seq");

            entity.ToTable(tb => tb.HasComment("기획전"));

            entity.Property(e => e.cardtitle_yn).IsFixedLength();
            entity.Property(e => e.choice_div).IsFixedLength();
            entity.Property(e => e.customimg_yn).IsFixedLength();
        });

        modelBuilder.Entity<S4_MD_Choice_Str_UsedYN>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("메뉴 오픈여부"));

            entity.Property(e => e.used_yn).IsFixedLength();
        });

        modelBuilder.Entity<S4_MD_Choice_Str_temp>(entity =>
        {
            entity.HasKey(e => e.md_seq).HasName("PK__S4_MD_Ch__42D89E12ACE2FFD7");
        });

        modelBuilder.Entity<S4_MD_Choice_weeklyhotdeal>(entity =>
        {
            entity.Property(e => e.seq).HasComment("유일값");
            entity.Property(e => e.choice_seq).HasComment("MD 상품 유일값");
            entity.Property(e => e.hotdeal_price).HasComment("핫딜가격");
        });

        modelBuilder.Entity<S4_McardEditInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전모바일청첩장"));
        });

        modelBuilder.Entity<S4_McardImageInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전모바일청첩장"));

            entity.HasIndex(e => e.Order_Seq, "IDX_S4_McardImageInfo")
                .IsDescending()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<S4_MyCoupon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("고객 쿠폰 발급 내역"));

            entity.HasIndex(e => e.id, "CI_S4_MYCOUPON")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.coupon_code, "NCI_COUPON_CODE").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "NCI_S4_MYCOUPON_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.uid, "NCI_S4_MYCOUPON_UID").HasFillFactor(90);

            entity.HasIndex(e => new { e.uid, e.company_seq }, "NCI_S4_MYCOUPON_UID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isMyYN).IsFixedLength();
        });

        modelBuilder.Entity<S4_MySweetWedding>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.casamia1).IsFixedLength();
            entity.Property(e => e.casamia2).IsFixedLength();
            entity.Property(e => e.clubmed1).IsFixedLength();
            entity.Property(e => e.clubmed2).IsFixedLength();
            entity.Property(e => e.goldendew1).IsFixedLength();
            entity.Property(e => e.goldendew2).IsFixedLength();
        });

        modelBuilder.Entity<S4_NICE_Log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("nice 인증 로그"));

            entity.Property(e => e.NIC_Idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_NonUserInfo_Sms>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("비회원 S M S  여부 관리"));

            entity.Property(e => e.inflow_route).IsFixedLength();
        });

        modelBuilder.Entity<S4_PhotoStory>(entity =>
        {
            entity.HasKey(e => new { e.event_num, e.seq }).HasName("PK_S4_PhotoStory_1");

            entity.Property(e => e.seq).ValueGeneratedOnAdd();
            entity.Property(e => e.isVisible).IsFixedLength();
        });

        modelBuilder.Entity<S4_Poll>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Poll__seq");

            entity.ToTable(tb => tb.HasComment("설문이벤트"));

            entity.Property(e => e.poll_type).IsFixedLength();
            entity.Property(e => e.view_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_Poll_item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("설문지 내용"));

            entity.Property(e => e.item_etc_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_Poll_itemComment>(entity =>
        {
            entity.Property(e => e.isOpen).IsFixedLength();
        });

        modelBuilder.Entity<S4_Poll_item_etc>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Poll_item_etc__seq");
        });

        modelBuilder.Entity<S4_Portfolio>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Portfolio__seq");

            entity.ToTable(tb => tb.HasComment("협찬 Portfolio"));
        });

        modelBuilder.Entity<S4_Premier_Business_Card>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전모바일청첩장"));

            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_Premier_Business_Img>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전 프리미어페이퍼 이미지경로"));
        });

        modelBuilder.Entity<S4_Premier_Movie>(entity =>
        {
            entity.HasIndex(e => e.order_seq, "IX_S4_Premier_Movie")
                .IsUnique()
                .IsDescending()
                .HasFillFactor(90);

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.isComplete).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S4_Premier_SNS>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Premier_SNS__seq");

            entity.ToTable(tb => tb.HasComment("프리미어 페이퍼 SNS"));

            entity.Property(e => e.best_div).IsFixedLength();
            entity.Property(e => e.sns_div).IsFixedLength();
            entity.Property(e => e.view_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_Ranking_Sort>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("메뉴별 카드 순위 관리"));

            entity.HasIndex(e => new { e.ST_SDate, e.ST_Edate }, "IX_S4_Ranking_Sort").HasFillFactor(90);

            entity.HasIndex(e => new { e.ST_company_seq, e.ST_tabgubun, e.ST_brand }, "IX_S4_Ranking_Sort_1").HasFillFactor(90);
        });

        modelBuilder.Entity<S4_Ranking_Sort_Plus>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드) 답례품 순위관리"));

            entity.Property(e => e.ST_Code).HasComment("카테고리코");
            entity.Property(e => e.ST_brand).HasComment("제품브랜드");
            entity.Property(e => e.ST_tabgubun).HasComment("정렬탭코드(추천순, 신상품순 등)");
        });

        modelBuilder.Entity<S4_Ranking_Sort_Table>(entity =>
        {
            entity.HasIndex(e => e.RK_ST_SEQ, "IX_S4_Ranking_Sort_Table").HasFillFactor(90);
        });

        modelBuilder.Entity<S4_ShopHelper>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_ShopHelper__seq");

            entity.Property(e => e.view_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_ShopHelper_Reply>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_ShopHelper_Reply__seq");
        });

        modelBuilder.Entity<S4_Stock_Alarm>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_Stock_Alarm__seq");

            entity.ToTable(tb => tb.HasComment("품절카드 입고 문자 관리"));

            entity.Property(e => e.isAlarm_send)
                .IsFixedLength()
                .HasComment("발송 여부");
            entity.Property(e => e.reg_date).HasComment("등록일");
            entity.Property(e => e.send_date).HasComment("발송일");
        });

        modelBuilder.Entity<S4_UserOpinion>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_S4_UserOpinion__seq");

            entity.Property(e => e.hot_line).IsFixedLength();
            entity.Property(e => e.view_div).IsFixedLength();
            entity.Property(e => e.wr_div).IsFixedLength();
        });

        modelBuilder.Entity<S4_mCardBoard>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전모바일방명록"));

            entity.HasIndex(e => e.Order_Seq, "IDX_S4_mCardBoard")
                .IsDescending()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<S5_Event_Item>(entity =>
        {
            entity.Property(e => e.CE_Idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S5_Event_Member>(entity =>
        {
            entity.Property(e => e.CEM_Idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S5_Happy_Price_Item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 할인 카드"));

            entity.Property(e => e.hpi_idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S5_Happy_Price_Main>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드 할인 회차 관리"));
        });

        modelBuilder.Entity<S5_Plus_Friends>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이벤트 더카드 친구소개"));

            entity.HasIndex(e => new { e.PF_UID, e.PF_FUID }, "IX_S5_Plus_Friends").HasFillFactor(90);

            entity.Property(e => e.PF_Coupon_Status).IsFixedLength();
            entity.Property(e => e.PF_Coupon_Status_F).IsFixedLength();
        });

        modelBuilder.Entity<S5_Plus_Friends_UID>(entity =>
        {
            entity.HasIndex(e => e.P_UID, "IX_S5_Plus_Friends_UID").HasFillFactor(90);

            entity.Property(e => e.P_Coupon_Status).IsFixedLength();
        });

        modelBuilder.Entity<S5_Supporters_User>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드)서포터즈 이벤트"));

            entity.HasIndex(e => e.SP_Company_seq, "NCI_S5_SUPPORTERS_USER_SP_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => e.SP_UserID, "NCI_S5_SUPPORTERS_USER_SP_USERID").HasFillFactor(90);

            entity.HasIndex(e => e.SP_Company_seq, "NCI_S5_SUPPORTERS_USER_SP_USERID_SP_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.SP_Best)
                .IsFixedLength()
                .HasComment("N:미승인, Y:베스트승인");
            entity.Property(e => e.SP_Level).HasComment("0:미승인, 1:미, 2:선, 3:진");
            entity.Property(e => e.SP_Status).HasComment("0:미승인, 1:승인");
        });

        modelBuilder.Entity<S5_TodayViewItems>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<S5_nmCardBoard>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("예전모바일청첩장"));

            entity.HasIndex(e => e.Order_Seq, "NCI_ORDER_SEQ").HasFillFactor(90);
        });

        modelBuilder.Entity<S5_nmCardImageInfo>(entity =>
        {
            entity.HasKey(e => new { e.Order_Seq, e.FileType, e.FileIndex }).HasName("PK_ORDER_SEQ_FILETYPE_FILEINDEX");

            entity.ToTable(tb => tb.HasComment("예전모바일청첩장"));
        });

        modelBuilder.Entity<S5_nmCardOrder>(entity =>
        {
            entity.HasKey(e => e.Order_Seq).HasName("PK_S5_nmCardOrder_1");

            entity.ToTable(tb =>
            {
                tb.HasComment("예전모바일초대장");
                tb.HasTrigger("INSERT_TRIGGER");
                tb.HasTrigger("UPDATE_TRIGGER");
            });

            entity.HasIndex(e => e.Addr, "NCI_ADDR").HasFillFactor(90);

            entity.HasIndex(e => new { e.Addr, e.Company_Seq }, "NCI_ADDR_COMPANY_SEQ").HasFillFactor(90);

            entity.HasIndex(e => new { e.Uid, e.Company_Seq }, "NCI_S5_NMCARDORDER_UID_COMPANY_SEQ").HasFillFactor(90);

            entity.Property(e => e.event_ampm).IsFixedLength();
            entity.Property(e => e.lunar_yorn).IsFixedLength();
            entity.Property(e => e.order_state).IsFixedLength();
        });

        modelBuilder.Entity<S5_nmCardShowInfo>(entity =>
        {
            entity.Property(e => e.ShowIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.DelFlag).IsFixedLength();
            entity.Property(e => e.PurchasedStatus).IsFixedLength();
        });

        modelBuilder.Entity<SAMPLE_DELIVERY_PRICE_INFO>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("샘플 배송비 관리"));

            entity.Property(e => e.SALES_GUBUN).HasComment("사이트구분");
            entity.Property(e => e.DELIVERY_PRICE).HasComment("첫 주문 이후 배송비");
            entity.Property(e => e.FIRST_DELIVERY_PRICE).HasComment("첫 주문 배송비");
        });

        modelBuilder.Entity<SAMPLE_LIKE_CHECK>(entity =>
        {
            entity.Property(e => e.LIKE_SEQ).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SAMSUNG_BRANCH>(entity =>
        {
            entity.Property(e => e.status).IsFixedLength();
        });

        modelBuilder.Entity<SAMSUNG_DAILY_DISCOUNT>(entity =>
        {
            entity.Property(e => e.chk_smembership).IsFixedLength();
            entity.Property(e => e.chk_smembership_leave).IsFixedLength();
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<SAMSUNG_DAILY_INFO>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("삼성전자동의 전송 데이터"));

            entity.Property(e => e.wedd_pgubun).HasComment("웨딩장소");
        });

        modelBuilder.Entity<SAMSUNG_DELETE_MEMBER>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("삼성전자동의 취소 데이터"));
        });

        modelBuilder.Entity<SC_LOG>(entity =>
        {
            entity.HasIndex(e => new { e.TR_SENDDATE, e.TR_SENDSTAT }, "SC_LOG_1").HasFillFactor(90);

            entity.HasIndex(e => new { e.TR_ID, e.TR_RSLTSTAT }, "SC_LOG_2").HasFillFactor(90);
        });

        modelBuilder.Entity<SC_TRAN>(entity =>
        {
            entity.HasKey(e => e.TR_NUM).HasName("PK__SC_TRAN__4012D150");

            entity.HasIndex(e => e.TR_NUM, "SC_TRAN_0")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.TR_SENDDATE, e.TR_SENDSTAT }, "SC_TRAN_1").HasFillFactor(90);

            entity.HasIndex(e => new { e.TR_ID, e.TR_RSLTSTAT }, "SC_TRAN_2").HasFillFactor(90);

            entity.HasIndex(e => e.TR_MODIFIED, "SC_TRAN_3").HasFillFactor(90);
        });

        modelBuilder.Entity<SEASON_MEMBER>(entity =>
        {
            entity.HasKey(e => e.uid).HasName("PK_CIDX_SEASON_UserInfo__uid");

            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.out_yorn).IsFixedLength();
        });

        modelBuilder.Entity<SEOInfo>(entity =>
        {
            entity.Property(e => e.SeoSeq).HasComment("고유번호");
            entity.Property(e => e.CanonicalUri).HasComment("link 태그에 출력할 캐노니컬 url");
            entity.Property(e => e.Category).HasComment("URL 메인 카테고리");
            entity.Property(e => e.Description).HasComment("웹페이지에 meta tag에 출력할 설명글");
            entity.Property(e => e.Device)
                .IsFixedLength()
                .HasComment("유입경로 (P:PC, M:Mobile)");
            entity.Property(e => e.KeyCount).HasComment("KeyValueString에 포함됨 파라메터 갯수");
            entity.Property(e => e.KeyValueString).HasComment("QueryString과 매칭할 파라메터 값");
            entity.Property(e => e.RegDate).HasComment("등록일시");
            entity.Property(e => e.SiteCode).HasComment("사이트 구분코드 (SB:바른손카드, SS:프리미어페이퍼, B:바른손몰)");
            entity.Property(e => e.TitleName).HasComment("웹에 표시할 Title명");
            entity.Property(e => e.Url).HasComment("url 절대경로 / 로 시작해야함");
            entity.Property(e => e.UseFlag).HasComment("사용여부 (1:사용 0:미사용)");
        });

        modelBuilder.Entity<SEOKeyValue>(entity =>
        {
            entity.Property(e => e.SeoSeq).HasComment("고유번호");
            entity.Property(e => e.KeyValue).HasComment("SEOInfo의 KeyValueString값을 Split한 값");
        });

        modelBuilder.Entity<SEONonexistLog>(entity =>
        {
            entity.Property(e => e.SiteCode).HasComment("사이트 구분코드 (SB:바른손카드, SS:프리미어페이퍼, B:바른손몰)");
            entity.Property(e => e.Device)
                .IsFixedLength()
                .HasComment("유입경로 (P:PC, M:Mobile)");
            entity.Property(e => e.Url).HasComment("url 절대경로 / 로 시작해야함");
            entity.Property(e => e.QueryString).HasComment("넘겨진 querystring값");
            entity.Property(e => e.Seq)
                .ValueGeneratedOnAdd()
                .HasComment("고유번호");
        });

        modelBuilder.Entity<SESSION_GENERATER>(entity =>
        {
            entity.HasKey(e => e.TCNT).HasName("PK__SESSION_GENERATE__40F9A68C");

            entity.Property(e => e.TCNT).ValueGeneratedNever();
        });

        modelBuilder.Entity<SH_Notice>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("old) 방명록"));

            entity.HasIndex(e => e.N_id, "nind_N_id").HasFillFactor(90);

            entity.HasIndex(e => e.N_insdate, "nind_N_insdate").HasFillFactor(90);

            entity.Property(e => e.view_div).IsFixedLength();
        });

        modelBuilder.Entity<SMARTAD_CONTACT_US>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 1:1문의"));
        });

        modelBuilder.Entity<SMARTAD_COUPON_MST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 쿠폰정보"));

            entity.Property(e => e.PROMOTION_TYPE).IsFixedLength();
        });

        modelBuilder.Entity<SMARTAD_EVENT_INFO>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 지문방명록 이벤트"));

            entity.Property(e => e.COUPON_CODE).IsFixedLength();
            entity.Property(e => e.DEL_YN).IsFixedLength();
            entity.Property(e => e.STATUS_CODE).IsFixedLength();
        });

        modelBuilder.Entity<SMARTAD_EVENT_REQUEST>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 지문방명록 이벤트 수정요청(초안)"));
        });

        modelBuilder.Entity<SMARTAD_MYCOUPON>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 받은쿠폰"));

            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<SMSSendMaster>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("문자발송관리 마스터"));

            entity.Property(e => e.Class).HasComment("분류: 1.광고, 2. 정보");
            entity.Property(e => e.FailCount).HasComment("발송실패 수");
            entity.Property(e => e.RegDate).HasComment("등록일");
            entity.Property(e => e.RegUserId).HasComment("등록자ID");
            entity.Property(e => e.RegUserName).HasComment("등록자명");
            entity.Property(e => e.SendTime).HasComment("즉시발송시 발송 시작 시간(발송대기 업데이트), 예약발송시 예약 날짜시간");
            entity.Property(e => e.SendType).HasComment("발송유형: 1.즉시발송, 2.예약발송");
            entity.Property(e => e.SenderPhone).HasComment("발신번호");
            entity.Property(e => e.Status).HasComment("상태: 0.작성중, 50.취소, 90. 테스트발송대기, 99. 테스트 발송완료, 100. 발송대기, 105. 발송중, 110.발송완료,  ");
            entity.Property(e => e.SuccessCount).HasComment("발송성공 수");
            entity.Property(e => e.TargetCount).HasComment("발송대상 수");
            entity.Property(e => e.TestSendTarget).HasComment("테스트발송대상: 이름^전화번호|이름^전화번호");
            entity.Property(e => e.Title).HasComment("제목");
        });

        modelBuilder.Entity<SMSSendTargetList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Seq }).HasName("PK_SMSSendTargetList_1");

            entity.Property(e => e.Name).HasComment("이름");
            entity.Property(e => e.PhoneNo).HasComment("발송대상번호");
            entity.Property(e => e.SendTime).HasComment("발송시간");
            entity.Property(e => e.Status).HasComment("50: 등록실패, 100. 발송대기, 105. 발송중, 110.발송완료,");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.SMSSendTargetList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSSendTargetList_SMSSendMaster");
        });

        modelBuilder.Entity<SQM_QA_TBL>(entity =>
        {
            entity.HasKey(e => e.QA_IID).IsClustered(false);

            entity.HasIndex(e => e.COMPANY_SEQ, "clu_company_seq")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.a_research1).IsFixedLength();
            entity.Property(e => e.a_research2).IsFixedLength();
            entity.Property(e => e.a_research_date).IsFixedLength();
            entity.Property(e => e.isEmail).IsFixedLength();
            entity.Property(e => e.isSMS).IsFixedLength();
            entity.Property(e => e.isSecret).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<STORE_BARUNSON_ORDER_MATCHING>(entity =>
        {
            entity.Property(e => e.Uid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SampleBook>(entity =>
        {
            entity.HasKey(e => e.SampleBook_ID).HasName("PK_SampleBook_1");

            entity.Property(e => e.Delivery_YN).IsFixedLength();
            entity.Property(e => e.SampleBook_Condition).IsFixedLength();
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SampleBook_History>(entity =>
        {
            entity.HasKey(e => new { e.Seq, e.SampleBook_ID }).HasName("PK_SampleBook_History_1");

            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.SampleBook_Condition).IsFixedLength();
        });

        modelBuilder.Entity<Sample_Addon>(entity =>
        {
            entity.HasKey(e => e.Sample_Addon_Seq).HasName("PK_SAMPLE_ADDON");

            entity.Property(e => e.Promotion_Month).IsFixedLength();
            entity.Property(e => e.Promotion_Year).IsFixedLength();
            entity.Property(e => e.Use_YN).IsFixedLength();
        });

        modelBuilder.Entity<Season_estimate>(entity =>
        {
            entity.Property(e => e.card_div)
                .IsFixedLength()
                .HasComment("N:연하장, C:크리스마스");
            entity.Property(e => e.color_opt)
                .IsFixedLength()
                .HasComment("N:안함, C:속지만, E:봉투만, A:모두");
            entity.Property(e => e.isembo)
                .IsFixedLength()
                .HasComment("0:신청안함, 1:신청함");
            entity.Property(e => e.isenvinsert)
                .IsFixedLength()
                .HasComment("0:신청안함, 1:신청함");
            entity.Property(e => e.ishandmade)
                .IsFixedLength()
                .HasComment("0:신청안함, 1:신청함");
            entity.Property(e => e.isinpaper)
                .IsFixedLength()
                .HasComment("0:신청안함, 1:신청함");
            entity.Property(e => e.isprintadd)
                .IsFixedLength()
                .HasComment("0:신청안함, 1:신청함");
            entity.Property(e => e.osheet_div)
                .IsFixedLength()
                .HasComment("E:완제품카드, P:주문카드, D:맞춤제작");
            entity.Property(e => e.reply_yn)
                .IsFixedLength()
                .HasComment("");
        });

        modelBuilder.Entity<SendEmailContent>(entity =>
        {
            entity.Property(e => e.EmailFormCode).HasComment("패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-> Customer 관련 첫번재 메일폼");
            entity.Property(e => e.SendYn).HasComment("기본값: false, 내용 수정시 false 변경");
            entity.Property(e => e.ToEmailAddress).HasComment("추가 수신 대상이 있을 경우");
            entity.Property(e => e.ToName).HasComment("추가 수신 대상이 있을 경우");
        });

        modelBuilder.Entity<SendEmailContentItem>(entity =>
        {
            entity.HasOne(d => d.Content).WithMany(p => p.SendEmailContentItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SendEmailContentItem_SendEmailContent");
        });

        modelBuilder.Entity<SendEmailMaster>(entity =>
        {
            entity.Property(e => e.EmailFormCode).HasComment("패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-> Customer 관련 첫번재 메일폼");
            entity.Property(e => e.ContentDescription).HasComment("([이메일] - 신청자 메일 주소, [문의사항] - 문의사항내용 ) 등 콘텐트에 치환될 내용 설명(참고용)");
            entity.Property(e => e.Contents).HasComment("메일 본문 또는 본문 페이지 URL");
        });

        modelBuilder.Entity<SendEmailRecipient>(entity =>
        {
            entity.Property(e => e.EmailFormCode).HasComment("패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-> Customer 관련 첫번재 메일폼");

            entity.HasOne(d => d.EmailFormCodeNavigation).WithMany(p => p.SendEmailRecipient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SendEmailRecipient_SendEmailMaster");
        });

        modelBuilder.Entity<SmartADNotice>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_SmartADNotice__seq");

            entity.ToTable(tb => tb.HasComment("SmartAD 공지사항"));

            entity.Property(e => e.display_YN).IsFixedLength();
            entity.Property(e => e.notice_div).IsFixedLength();
        });

        modelBuilder.Entity<SmartAD_Partner>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 광고업체"));

            entity.Property(e => e.USE_YN).IsFixedLength();
        });

        modelBuilder.Entity<SmartAD_Partner_AD>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 광고업체가 등록한 광고정보"));

            entity.Property(e => e.AD_TYPE).IsFixedLength();
            entity.Property(e => e.DISPLAY_YN).IsFixedLength();
            entity.Property(e => e.PROMOTION_TYPE).IsFixedLength();
        });

        modelBuilder.Entity<SmartAD_Partner_AD_IMAGE>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SmartAD 광고업체가 등록한 광고이미지"));
        });

        modelBuilder.Entity<StdMonth>(entity =>
        {
            entity.HasKey(e => new { e.yyyymm, e.LangID }).HasName("PK__StdMonth__976094E2318EF298");

            entity.Property(e => e.yyyymm).IsFixedLength();
            entity.Property(e => e.LangID).IsFixedLength();
            entity.Property(e => e.MonthEnd).IsFixedLength();
            entity.Property(e => e.MonthStart).IsFixedLength();
            entity.Property(e => e.yyyymmS).IsFixedLength();
            entity.Property(e => e.yyyyq).IsFixedLength();
        });

        modelBuilder.Entity<SurveyAnswer>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("설문이벤트 답변"));

            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<SurveyMaster>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드)설문 이벤트"));

            entity.Property(e => e.SalesGubun).IsFixedLength();
            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<SurveyQuestion>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("설문이벤트 질문"));

            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<SurveyResponse>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("설문이벤트 답변참여"));

            entity.Property(e => e.ResponseNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TB_Holiday>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("연휴관리"));

            entity.Property(e => e.hday).IsFixedLength();
            entity.Property(e => e.hmonth).IsFixedLength();
            entity.Property(e => e.hyear).IsFixedLength();
        });

        modelBuilder.Entity<TB_PRODUCT_SIZE>(entity =>
        {
            entity.Property(e => e.COVER_GROUP).IsFixedLength();
            entity.Property(e => e.PAGE_NUMBER).IsFixedLength();
            entity.Property(e => e.PAPER_CODE).IsFixedLength();
            entity.Property(e => e.SIZE).IsFixedLength();
            entity.Property(e => e.WH).IsFixedLength();
        });

        modelBuilder.Entity<TB_RESP_ACCOUNT>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_ACCOUNT_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_BRANCH>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_BRANCH_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_CARD>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_CARD_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_CARD_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_CARD_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_ETC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_ETC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_EWED>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_EWED_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_EWEDD_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_EWEDD_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_EWEDD_CBR>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_EWEDD_CBR_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_PHOTOBOOK_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_PHOTOBOOK_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_PHOTOBOOK_CBR>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_PHOTOBOOK_CBR_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SAMPLE>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("[TB_RESP_SAMPLE_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SAMPLE_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("[TB_RESP_SAMPLE_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SAMPLE_CAS>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("[TB_RESP_SAMPLE_CAS_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SAMPLE_CBR>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("[TB_RESP_SAMPLE_CBR_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SEASON_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_SEASON_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_SEASON_CBR>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_SEASON_CBR_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_WEDD>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_WEDD_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_WEDD_BMC>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_WEDD_BMC_INSERT"));
        });

        modelBuilder.Entity<TB_RESP_WEDD_CBR>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TB_RESP_WEDD_CBR_INSERT"));
        });

        modelBuilder.Entity<THE_MEMBER_OUT>(entity =>
        {
            entity.Property(e => e.sales_gubun).IsFixedLength();
            entity.Property(e => e.ans1).IsFixedLength();
            entity.Property(e => e.ans2).IsFixedLength();
            entity.Property(e => e.ans3).IsFixedLength();
            entity.Property(e => e.ans4).IsFixedLength();
            entity.Property(e => e.ans5).IsFixedLength();
            entity.Property(e => e.ans6).IsFixedLength();
            entity.Property(e => e.ans7).IsFixedLength();
            entity.Property(e => e.reg_date).IsFixedLength();
        });

        modelBuilder.Entity<THE_ZZIM>(entity =>
        {
            entity.Property(e => e.zzim_type)
                .IsFixedLength()
                .HasComment("G:인사말,M:약도");
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<TODAY_PRINTJOB>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.ptype).IsFixedLength();
        });

        modelBuilder.Entity<TU_Bestcard>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_TU_Bestcard__seq");

            entity.Property(e => e.best_view).IsFixedLength();
            entity.Property(e => e.detail_view).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<TU_Member>(entity =>
        {
            entity.HasIndex(e => e.jumin, "nind_jumin").HasFillFactor(90);

            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.isLunar).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<The_Card_overture>(entity =>
        {
            entity.Property(e => e.B_REMOTE_ADDR).IsFixedLength();
            entity.Property(e => e.MOM_OVERTURE_ID).IsFixedLength();
            entity.Property(e => e.REMOTE_ADDR).IsFixedLength();
        });

        modelBuilder.Entity<The_Card_overture_history>(entity =>
        {
            entity.Property(e => e.REMOTE_ADDR).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_BGM>(entity =>
        {
            entity.Property(e => e.Free).IsFixedLength();
            entity.Property(e => e.Price).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_Best>(entity =>
        {
            entity.Property(e => e.Sales_Gubun).IsFixedLength();
            entity.Property(e => e.best_month).IsFixedLength();
            entity.Property(e => e.best_week).IsFixedLength();
            entity.Property(e => e.best_year).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_Coupon>(entity =>
        {
            entity.Property(e => e.iscoupon_kind)
                .IsFixedLength()
                .HasComment("(O:주문발행, S:스티커발행)");
            entity.Property(e => e.isuse_yn)
                .IsFixedLength()
                .HasComment("(Y,N)");
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<The_Ewed_FAQ>(entity =>
        {
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_MyBGM>(entity =>
        {
            entity.Property(e => e.Sales_Gubun).IsFixedLength();
            entity.Property(e => e.my_state).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_Order>(entity =>
        {
            entity.HasIndex(e => e.Order_Seq, "IDX_The_Ewed_Order_Order_Seq")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Sales_gubun, e.is_display }, "com_gubun_display").HasFillFactor(90);

            entity.HasIndex(e => e.linkurl, "nind_linkurl").HasFillFactor(90);

            entity.HasIndex(e => e.member_id, "nind_member_id").HasFillFactor(90);

            entity.HasIndex(e => e.order_email, "nind_order_email").HasFillFactor(90);

            entity.Property(e => e.Event_AmPm).IsFixedLength();
            entity.Property(e => e.Event_Day).IsFixedLength();
            entity.Property(e => e.Event_Hour).IsFixedLength();
            entity.Property(e => e.Event_Minute).IsFixedLength();
            entity.Property(e => e.Event_Month).IsFixedLength();
            entity.Property(e => e.Event_WeekName).IsFixedLength();
            entity.Property(e => e.Event_Year).IsFixedLength();
            entity.Property(e => e.Sales_gubun).IsFixedLength();
            entity.Property(e => e.ac_State)
                .IsFixedLength()
                .HasComment("데이콤 정산일");
            entity.Property(e => e.is_coupon_yn).IsFixedLength();
            entity.Property(e => e.is_display).IsFixedLength();
            entity.Property(e => e.order_result).IsFixedLength();
            entity.Property(e => e.pg_paydate).HasComment("데이콤 수금일");
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_Order_DELETE>(entity =>
        {
            entity.Property(e => e.Order_ID).ValueGeneratedNever();
            entity.Property(e => e.Event_AmPm).IsFixedLength();
            entity.Property(e => e.Event_Day).IsFixedLength();
            entity.Property(e => e.Event_Hour).IsFixedLength();
            entity.Property(e => e.Event_Minute).IsFixedLength();
            entity.Property(e => e.Event_Month).IsFixedLength();
            entity.Property(e => e.Event_WeekName).IsFixedLength();
            entity.Property(e => e.Event_Year).IsFixedLength();
            entity.Property(e => e.ac_State).IsFixedLength();
            entity.Property(e => e.order_result).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<The_Ewed_Product>(entity =>
        {
            entity.Property(e => e.Product_Div)
                .IsFixedLength()
                .HasComment("W:청첩장 , V:초대장");
            entity.Property(e => e.Sales_Gubun).IsFixedLength();
        });

        modelBuilder.Entity<The_Member>(entity =>
        {
            entity.HasIndex(e => e.jumin, "nind_jumin").HasFillFactor(90);

            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.isLunar).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<TiaraBestRanking>(entity =>
        {
            entity.Property(e => e.Gubun)
                .IsFixedLength()
                .HasComment("MB:월간베스트\r\nWB:주간베스트\r\nSB:샘플베스트\r\nSF:여성베스트\r\nSM:남성베스트\r\nAA:20대베스트\r\nAB:30대베스트\r\nAC:40대베스트\r\nAD:50대베스트\r\nPA:300~600원대\r\nPB:700~1000원대\r\nPC:1100~1400원대\r\nPD:1500원이상\r\nBA:티아라,유사미디자인스\r\nBB:바른손카드\r\nBC:신상품\r\nBD:위시메이드\r\nBE:해피카드\r\nBF:스튜디오진,벨라피오레");
        });

        modelBuilder.Entity<Tiara_Event>(entity =>
        {
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<Tiara_Member>(entity =>
        {
            entity.HasIndex(e => e.jumin, "nind_jumin").HasFillFactor(90);

            entity.HasIndex(e => e.uid, "nind_uid").HasFillFactor(90);

            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.isBaro).IsFixedLength();
            entity.Property(e => e.isLunar).IsFixedLength();
            entity.Property(e => e.isSample).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<Tiara_ProdView>(entity =>
        {
            entity.ToView("Tiara_ProdView");

            entity.Property(e => e.BEST_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.ISHAVE).IsFixedLength();
            entity.Property(e => e.ISSAMPLE).IsFixedLength();
            entity.Property(e => e.NEW_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.card_shape).IsFixedLength();
            entity.Property(e => e.display_yes_or_no).IsFixedLength();
            entity.Property(e => e.is100).IsFixedLength();
            entity.Property(e => e.is200).IsFixedLength();
            entity.Property(e => e.is300).IsFixedLength();
            entity.Property(e => e.isButterFly).IsFixedLength();
            entity.Property(e => e.isElegant).IsFixedLength();
            entity.Property(e => e.isFlower).IsFixedLength();
            entity.Property(e => e.isGold).IsFixedLength();
            entity.Property(e => e.isHeart).IsFixedLength();
            entity.Property(e => e.isHologram).IsFixedLength();
            entity.Property(e => e.isPearl).IsFixedLength();
            entity.Property(e => e.isPress).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isRomantic).IsFixedLength();
            entity.Property(e => e.isSelfEdit).IsFixedLength();
            entity.Property(e => e.isStylish).IsFixedLength();
            entity.Property(e => e.isSweet).IsFixedLength();
            entity.Property(e => e.isTie).IsFixedLength();
            entity.Property(e => e.isTrendy).IsFixedLength();
            entity.Property(e => e.isWinitial).IsFixedLength();
            entity.Property(e => e.isYu).IsFixedLength();
            entity.Property(e => e.issbaesong).IsFixedLength();
            entity.Property(e => e.online_yes_or_no).IsFixedLength();
            entity.Property(e => e.recomend_yes_or_no).IsFixedLength();
        });

        modelBuilder.Entity<Tiara_board>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.isCoupon).IsFixedLength();
            entity.Property(e => e.isSecret).IsFixedLength();
            entity.Property(e => e.zipcode).IsFixedLength();
        });

        modelBuilder.Entity<UserTokenInfo>(entity =>
        {
            entity.Property(e => e.guid_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<User_Certification_Log>(entity =>
        {
            entity.Property(e => e.CertSeq).HasComment("시퀀스");
            entity.Property(e => e.CertData).HasComment("인증 데이터");
            entity.Property(e => e.CertID).HasComment("인증고유 ID (웹에서 db access용으로 사용)");
            entity.Property(e => e.CertType).HasComment("인증방식 구분 ( CPClient:통합인증, IPIN:아이핀, NONE:인증없이 di전달용)");
            entity.Property(e => e.DupInfo).HasComment("고유 개인정보");
            entity.Property(e => e.RegDate).HasComment("등록일시");
        });

        modelBuilder.Entity<VIEW_DELIVERYLST_TEST>(entity =>
        {
            entity.ToView("VIEW_DELIVERYLST_TEST");
        });

        modelBuilder.Entity<VSTAT_CARD>(entity =>
        {
            entity.Property(e => e.card_type).IsFixedLength();
        });

        modelBuilder.Entity<VW_COUPONTYPE_ORDER_AMT>(entity =>
        {
            entity.ToView("VW_COUPONTYPE_ORDER_AMT");
        });

        modelBuilder.Entity<VW_COUPON_CALC_FOR_CO>(entity =>
        {
            entity.ToView("VW_COUPON_CALC_FOR_CO");
        });

        modelBuilder.Entity<VW_COUPON_CALC_FOR_CO_20200303_bak>(entity =>
        {
            entity.ToView("VW_COUPON_CALC_FOR_CO_20200303_bak");
        });

        modelBuilder.Entity<VW_COUPON_CALC_FOR_CO_TEST>(entity =>
        {
            entity.ToView("VW_COUPON_CALC_FOR_CO_TEST");
        });

        modelBuilder.Entity<VW_COUPON_CALC_FOR_CO_nsm>(entity =>
        {
            entity.ToView("VW_COUPON_CALC_FOR_CO_nsm");
        });

        modelBuilder.Entity<VW_COUPON_USER_LIST>(entity =>
        {
            entity.ToView("VW_COUPON_USER_LIST");
        });

        modelBuilder.Entity<VW_DELIVERY_MST>(entity =>
        {
            entity.ToView("VW_DELIVERY_MST");

            entity.Property(e => e.ISHJ).IsFixedLength();
        });

        modelBuilder.Entity<VW_HALL_SALES_STATICS>(entity =>
        {
            entity.ToView("VW_HALL_SALES_STATICS");
        });

        modelBuilder.Entity<VW_MO_TRAN>(entity =>
        {
            entity.ToView("VW_MO_TRAN");

            entity.Property(e => e.MO_NUM).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VW_OUTSOURCING_ORDER_MST>(entity =>
        {
            entity.ToView("VW_OUTSOURCING_ORDER_MST");

            entity.Property(e => e.BOTH_SIDE_YORN).IsFixedLength();
            entity.Property(e => e.CUTOUT_YORN).IsFixedLength();
            entity.Property(e => e.DEV_FLAG).IsFixedLength();
            entity.Property(e => e.EDGE_YORN).IsFixedLength();
            entity.Property(e => e.GLOSSY_YORN).IsFixedLength();
            entity.Property(e => e.LASER_CUT_YORN).IsFixedLength();
            entity.Property(e => e.OSI_YORN).IsFixedLength();
            entity.Property(e => e.PRESS_YORN).IsFixedLength();
        });

        modelBuilder.Entity<VW_USER_INFO>(entity =>
        {
            entity.ToView("VW_USER_INFO");

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.BIRTH_DATE_TYPE).IsFixedLength();
            entity.Property(e => e.CHK_MYOMEE).IsFixedLength();
            entity.Property(e => e.CHOICE_AGREEMENT_FOR_SAMSUNG_CHOICE_PERSONAL_DATA).IsFixedLength();
            entity.Property(e => e.CHOICE_AGREEMENT_FOR_SAMSUNG_MEMBERSHIP).IsFixedLength();
            entity.Property(e => e.CHOICE_AGREEMENT_FOR_SAMSUNG_THIRDPARTY).IsFixedLength();
            entity.Property(e => e.DupInfo).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.INTEGRATION_MEMBER_YORN).IsFixedLength();
            entity.Property(e => e.NATIONAL_INFO).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.WEDDING_HALL).IsFixedLength();
            entity.Property(e => e.chk_iloommembership).IsFixedLength();
            entity.Property(e => e.chk_lgmembership).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isMCardAble).IsFixedLength();
            entity.Property(e => e.mkt_chk_flag).IsFixedLength();
        });

        modelBuilder.Entity<VW_USER_INFO_ASTERISK>(entity =>
        {
            entity.ToView("VW_USER_INFO_ASTERISK");

            entity.Property(e => e.AuthType).IsFixedLength();
            entity.Property(e => e.DupInfo).IsFixedLength();
            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.INTEGRATION_MEMBER_YORN).IsFixedLength();
            entity.Property(e => e.NationalInfo).IsFixedLength();
            entity.Property(e => e.USE_YORN).IsFixedLength();
            entity.Property(e => e.birth_div).IsFixedLength();
            entity.Property(e => e.chk_DM).IsFixedLength();
            entity.Property(e => e.chk_DormancyAccount).IsFixedLength();
            entity.Property(e => e.chk_mail_input).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_smembership).IsFixedLength();
            entity.Property(e => e.chk_smembership_coop).IsFixedLength();
            entity.Property(e => e.chk_smembership_leave).IsFixedLength();
            entity.Property(e => e.chk_smembership_per).IsFixedLength();
            entity.Property(e => e.chk_sms).IsFixedLength();
            entity.Property(e => e.isJehu).IsFixedLength();
            entity.Property(e => e.isMCardAble).IsFixedLength();
            entity.Property(e => e.is_appSample).IsFixedLength();
            entity.Property(e => e.mkt_chk_flag).IsFixedLength();
            entity.Property(e => e.smembership_chk_flag).IsFixedLength();
            entity.Property(e => e.wedd_pgubun).IsFixedLength();
        });

        modelBuilder.Entity<VW_WEDDING_HALL>(entity =>
        {
            entity.ToView("VW_WEDDING_HALL");

            entity.Property(e => e.flag).IsFixedLength();
            entity.Property(e => e.isAutoWeddInfo).IsFixedLength();
            entity.Property(e => e.isAutoupdate).IsFixedLength();
            entity.Property(e => e.isIllur).IsFixedLength();
            entity.Property(e => e.isIllur_update).IsFixedLength();
            entity.Property(e => e.isUpdate).IsFixedLength();
            entity.Property(e => e.iscorel).IsFixedLength();
        });

        modelBuilder.Entity<V_BoardList>(entity =>
        {
            entity.ToView("V_BoardList");
        });

        modelBuilder.Entity<V_OrderGroupDetailList>(entity =>
        {
            entity.ToView("V_OrderGroupDetailList");

            entity.Property(e => e.Method).IsFixedLength();
            entity.Property(e => e.PayType).IsFixedLength();
            entity.Property(e => e.deliveryCountry).IsFixedLength();
        });

        modelBuilder.Entity<V_OrderGroupList>(entity =>
        {
            entity.ToView("V_OrderGroupList");

            entity.Property(e => e.Method).IsFixedLength();
            entity.Property(e => e.OrderSeq).ValueGeneratedOnAdd();
            entity.Property(e => e.PayType).IsFixedLength();
            entity.Property(e => e.deliveryCountry).IsFixedLength();
        });

        modelBuilder.Entity<V_order_list>(entity =>
        {
            entity.ToView("V_order_list");

            entity.Property(e => e.delivery_com).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<V_order_list_v2>(entity =>
        {
            entity.ToView("V_order_list_v2");

            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<Visit_Reservation>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("방문상담 예약 정보"));
        });

        modelBuilder.Entity<WEDD_FAQ>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("고객FAQ"));

            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<WEDD_MAIL>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("메일,SMS 발송관리"));

            entity.Property(e => e.USE_YORN).IsFixedLength();
        });

        modelBuilder.Entity<WeddingHall>(entity =>
        {
            entity.HasKey(e => e.wedd_idx).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("웨딩홀정보"));

            entity.HasIndex(e => e.Wname, "IX_WeddingHall")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.WRoadNameAddress).HasComment("도로명주소");
            entity.Property(e => e.Waddress).HasComment("주소");
            entity.Property(e => e.Wname).HasComment("예식장명");
            entity.Property(e => e.Wphone).HasComment("예식장 연락처");
            entity.Property(e => e.flag).IsFixedLength();
            entity.Property(e => e.isAutoWeddInfo).IsFixedLength();
            entity.Property(e => e.isAutoupdate).IsFixedLength();
            entity.Property(e => e.isIllur).IsFixedLength();
            entity.Property(e => e.isIllur_update).IsFixedLength();
            entity.Property(e => e.isUpdate).IsFixedLength();
            entity.Property(e => e.iscorel).IsFixedLength();
            entity.Property(e => e.wedd_keyword).HasComment("키워드");
        });

        modelBuilder.Entity<WeddingHall_Image>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("웨딩홀 약도이미지"));

            entity.HasIndex(e => e.Wedd_IDX, "IX_WeddingHall_Image").HasFillFactor(90);

            entity.HasIndex(e => e.WeddImg_IDX, "NCI-WEDDIMG_IDX").HasFillFactor(90);

            entity.Property(e => e.isColor).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isDP).IsFixedLength();
            entity.Property(e => e.isR).IsFixedLength();
        });

        modelBuilder.Entity<WeddingHall_Log>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WeddingMagazine>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_WeddingMagazine__seq");

            entity.ToTable(tb => tb.HasComment("카드뉴스"));

            entity.Property(e => e.CateGory).IsFixedLength();
            entity.Property(e => e.List_View_YN).IsFixedLength();
            entity.Property(e => e.View_YN).IsFixedLength();
        });

        modelBuilder.Entity<WeddingMagazine_Click_Statistics>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_WeddingMagazine_Click_Statistics__seq");

            entity.Property(e => e.Gubun).IsFixedLength();
        });

        modelBuilder.Entity<WeddingNews>(entity =>
        {
            entity.Property(e => e.WeddingNewsIdx).HasComment("글번호");
            entity.Property(e => e.AdminMemo).HasComment("관리자메모");
            entity.Property(e => e.ImgMode).HasComment("1:직접등록 0:제공이미지");
            entity.Property(e => e.OrderSeq).HasComment("주문번호");
            entity.Property(e => e.Status)
                .IsFixedLength()
                .HasComment("기사상태 W:작성중, I:기사전송, N:반려,  U: 수정접수, Y:완료 ");
            entity.Property(e => e.TemplateIdx).HasComment("템플릿번호");
        });

        modelBuilder.Entity<WeddingNewsResult>(entity =>
        {
            entity.Property(e => e.WeddingNewsIdx)
                .ValueGeneratedNever()
                .HasComment("글번호");
            entity.Property(e => e.Content).HasComment("업체에서 전달받은 데이터");
            entity.Property(e => e.ModDate).HasComment("수정일");
            entity.Property(e => e.RejectComment).HasComment("반려사유");
            entity.Property(e => e.RejectCommentType)
                .IsFixedLength()
                .HasComment("반려사유타입 1:이미지불충분, 2:텍스트오류, 3:내용불충분, 4:기타");
            entity.Property(e => e.RejectCount).HasComment("반려횟수");
            entity.Property(e => e.Title).HasComment("제목");
            entity.Property(e => e.Url).HasComment("기사URL");
        });

        modelBuilder.Entity<WeddingNewsResultLog>(entity =>
        {
            entity.HasKey(e => new { e.WeddingNewsIdx, e.RegDate }).HasName("PK_WeddingNewsResultLog2");

            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<WeddingNewsTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateIdx).HasName("PK_WeddingNewsTemplate2");

            entity.Property(e => e.TemplateIdx).HasComment("템플릿번호");
            entity.Property(e => e.AdditionChoice).HasComment("추가선택사항");
            entity.Property(e => e.AdditionDescription).HasComment("추가설명");
            entity.Property(e => e.AdminId).HasComment("등록자");
            entity.Property(e => e.BrideAgeYn).HasComment("신부나이여부");
            entity.Property(e => e.BrideFatherRadioYn).HasComment("신부부선택여부");
            entity.Property(e => e.BrideFatherYn).HasComment("신부부여부");
            entity.Property(e => e.BrideMotherYn).HasComment("신부모여부");
            entity.Property(e => e.BrideNameRadioYn).HasComment("신부이름선택여부");
            entity.Property(e => e.BrideNameYn).HasComment("신부이름여부");
            entity.Property(e => e.BrideRankYn).HasComment("신부서열여부");
            entity.Property(e => e.CompanyYn).HasComment("회사여부");
            entity.Property(e => e.Contents).HasComment("내용");
            entity.Property(e => e.FatherJobYn).HasComment("부직업여부");
            entity.Property(e => e.GroomAgeYn).HasComment("신랑나이여부");
            entity.Property(e => e.GroomFatherRadioYn).HasComment("신랑부선택여부");
            entity.Property(e => e.GroomFatherYn).HasComment("신랑부여부");
            entity.Property(e => e.GroomMotherYn).HasComment("신랑모여부");
            entity.Property(e => e.GroomNameRadioYn).HasComment("신랑이름선택여부");
            entity.Property(e => e.GroomNameYn).HasComment("신랑이름여부");
            entity.Property(e => e.GroomRankYn).HasComment("신랑서열여부");
            entity.Property(e => e.ModDate).HasComment("수정일");
            entity.Property(e => e.PositionYn).HasComment("직급여부");
            entity.Property(e => e.RegDate).HasComment("등록일");
            entity.Property(e => e.Sort).HasComment("순서(노출순서)");
            entity.Property(e => e.Title).HasComment("제목");
            entity.Property(e => e.UseYn).HasComment("사용여부");
            entity.Property(e => e.WeddDateYn).HasComment("예식날짜여부");
            entity.Property(e => e.WeddNameYn).HasComment("예식장정보여부");
            entity.Property(e => e.WeddPlaceYn).HasComment("층홀실여부");
            entity.Property(e => e.WeddingTimeYn).HasComment("예식시간여부");
        });

        modelBuilder.Entity<Weddinghall_location>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("웨딩홀 위치"));

            entity.Property(e => e.loc_code).ValueGeneratedNever();
        });

        modelBuilder.Entity<XBBS_ARTICLE>(entity =>
        {
            entity.HasKey(e => e.XA_SEQ).HasName("PK__XBBS_ARTICLE__4DB4832C");

            entity.HasIndex(e => e.XI_SEQ, "IDX__XBBS_ARTICLE__XI_SEQ").HasFillFactor(90);

            entity.HasOne(d => d.XI_SEQNavigation).WithMany(p => p.XBBS_ARTICLE).HasConstraintName("FK__XBBS_ARTI__XI_SE__789EE131");
        });

        modelBuilder.Entity<XBBS_INFO>(entity =>
        {
            entity.HasKey(e => e.XI_SEQ).HasName("PK__XBBS_INFO__44CA3770");

            entity.Property(e => e.XI_PUBLIC)
                .IsFixedLength()
                .HasComment("0:공지사항게시판,1:자유게시판");
        });

        modelBuilder.Entity<Yoosami>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();
            entity.Property(e => e.Site).IsFixedLength();
            entity.Property(e => e.Source).IsFixedLength();
        });

        modelBuilder.Entity<antHall>(entity =>
        {
            entity.ToView("antHall");

            entity.Property(e => e.isAutoWeddInfo).IsFixedLength();
            entity.Property(e => e.isColor).IsFixedLength();
            entity.Property(e => e.isUpdate).IsFixedLength();
            entity.Property(e => e.iscorel).IsFixedLength();
            entity.Property(e => e.wid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ata_banlist>(entity =>
        {
            entity.HasKey(e => new { e.service_type, e.ban_seq }).HasName("PK__ata_banl__7F4D396326EE1F86");

            entity.ToTable(tb => tb.HasComment("비즈톡 스팸등록"));

            entity.Property(e => e.service_type)
                .IsFixedLength()
                .HasComment("서비스 메시지 전송 타입(3-알림톡)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ban_status_yn)
                .IsFixedLength()
                .HasComment("전송 차단 여부(Y:차단, N:취소)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ban_type)
                .IsFixedLength()
                .HasComment("스팸 차단 구분 R-수신 번호(recipient_num필드와 비교) , T-메시지 내용(content필드와 비교)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content)
                .HasComment("스팸 문구")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.reg_date).HasComment("등록 시간");
            entity.Property(e => e.reg_user).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.send_yn)
                .IsFixedLength()
                .HasComment("스팸 문구 전송 여부 (Y:발송 N:발송안함)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.update_user).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E19235D1F6");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag).IsFixedLength();
            entity.Property(e => e.ata_id).IsFixedLength();
            entity.Property(e => e.crypto_yn).IsFixedLength();
            entity.Property(e => e.kko_btn_type).IsFixedLength();
            entity.Property(e => e.msg_status).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.report_code).IsFixedLength();
        });

        modelBuilder.Entity<ata_mmt_log_201803>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E132ABEC08");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201804>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1EC236CBD");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201805>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1374B3F05");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201806>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E18487CA44");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201807>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1F22D3BAB");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201808>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1EBBEBF65");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201809>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1342BDABF");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201810>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E192ECE1B7");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201811>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E16E16E89D");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201812>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E15A9B3B47");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201901>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E16CA89851");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201902>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E18B8C9570");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201903>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E16EC0B83B");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201904>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1CB481F6F");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201905>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1721B2671");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201906>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E142CF3645");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201907>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1F508A034");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201908>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1A1870904");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201909>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1B2E38058");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201910>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E16250BEF9");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201911>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1C3BF3044");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_201912>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E122E11261");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202001>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1B0CF4525");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202002>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E129F8C5B2");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202003>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E13DCD5657");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202004>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1AC04D27E");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202005>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E15DA7FC01");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202006>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1CE4EF898");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202007>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E161A38D42");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202008>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E14915BE1D");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202009>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1C1F21357");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202010>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E19E2A1012");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202011>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1F403BBCC");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202012>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E12D5AD77E");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202101>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E13CE1929F");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202102>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E13228BD9E");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202103>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1F6E50B94");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202104>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E120A58A19");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202105>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1186346A7");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202106>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1B326073C");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202107>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1A95F7432");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202108>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1978DA50D");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202109>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1E212E324");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202110>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1C27D0EC0");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202111>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E148F95108");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202112>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1EA631E70");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202201>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1EC5973BB");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202202>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E130131273");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202203>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E156D80723");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202204>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1C1617AAB");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202205>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E19031BDBB");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202206>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1D6F1E09D");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202207>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E130DBC756");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202208>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E119C14362");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202209>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E10FE4624E");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202210>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1647E3ACF");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202211>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E18A43C122");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202212>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E11B20106D");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202301>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E19C89050F");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202302>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1EB87BDC2");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202303>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E137AC02F0");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202304>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1F1221BD8");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202305>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E14CB9C95C");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202306>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1FB266BCF");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_202307>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E13FC07747");

            entity.Property(e => e.mt_pr).ValueGeneratedNever();
            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_1).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.mt_refkey).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code).UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<ata_mmt_log_230126_230309>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E17C163C69");

            entity.Property(e => e.ad_flag).IsFixedLength();
            entity.Property(e => e.ata_id).IsFixedLength();
            entity.Property(e => e.crypto_yn).IsFixedLength();
            entity.Property(e => e.kko_btn_type).IsFixedLength();
            entity.Property(e => e.msg_status).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.report_code).IsFixedLength();
        });

        modelBuilder.Entity<ata_mmt_tran>(entity =>
        {
            entity.HasKey(e => e.mt_pr).HasName("PK__ata_mmt___910A22E1257DEFA8");

            entity.ToTable(tb => tb.HasComment("비즈톡 발송"));

            entity.Property(e => e.ad_flag)
                .IsFixedLength()
                .HasComment("카카오톡 친구톡 발송시 광고성메시지")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.ata_id)
                .IsFixedLength()
                .HasComment("ATA 이중화시 사용되는 ID")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.callback)
                .HasComment("발신자 전화 번호")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.content)
                .HasComment("전송 메시지")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.country_code)
                .HasComment("국가 코드")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.crypto_yn)
                .IsFixedLength()
                .HasComment("암호화 사용 유무")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.date_client_req).HasComment("전송 예약 시간");
            entity.Property(e => e.date_mt_report).HasComment("Biz talk 으로부터 결과 수신한 시간");
            entity.Property(e => e.date_mt_sent).HasComment("Biz talk G/W 접수 시간");
            entity.Property(e => e.date_rslt).HasComment("단말기 도착 시간");
            entity.Property(e => e.etc_num_1).HasComment("유저 기타필드)company_seq");
            entity.Property(e => e.etc_text_1)
                .HasComment("유저 기타필드)sales_gubun")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_2)
                .HasComment("유저 기타필드)호출프로시저")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.etc_text_3).UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_link)
                .HasComment("친구톡 이미지 클릭시 이동할 URL")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.img_url)
                .HasComment("친구톡 이미지 URL")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_info)
                .HasComment("버튼템플릿 전송시 버튼 정보")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.kko_btn_type)
                .IsFixedLength()
                .HasComment("카카오톡 전송방식 1-format string 2-JSON 3-XML")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_status)
                .IsFixedLength()
                .HasComment("메시지 상태 (1-전송대기, 2-결과대기, 3-완료)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.msg_type).HasComment("메시지 종류(1008-알림톡, 1009-친구톡)");
            entity.Property(e => e.mt_refkey)
                .HasComment("부서 코드 (참조용 필드)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.priority)
                .IsFixedLength()
                .HasComment("메시지 우선 순위")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.recipient_num)
                .HasComment("수신자 전화 번호")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.reg_date).HasComment("데이터 등록일자");
            entity.Property(e => e.report_code)
                .IsFixedLength()
                .HasComment("전송 결과(1000-성공, 기타-실패)")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.response_method)
                .HasComment("메시지 발송 방식")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.rs_id)
                .HasComment("전송된 Biz talk G/W 정보")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.sender_key)
                .HasComment("발신 프로필 키")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.subject)
                .HasComment("메시지 제목")
                .UseCollation("Korean_Wansung_CS_AS");
            entity.Property(e => e.template_code)
                .HasComment("메시지 유형 템플릿 코드")
                .UseCollation("Korean_Wansung_CS_AS");
        });

        modelBuilder.Entity<barunToclosed_history_log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("혼수폐쇄몰 회원이동 history Log"));

            entity.Property(e => e.linked_tmstmp).HasComment("방문시간");
            entity.Property(e => e.uid).HasComment("회원아이디");
        });

        modelBuilder.Entity<barunToclosed_log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("혼수폐쇄몰 회원이동log 테이블"));

            entity.Property(e => e.uid).HasComment("회원아이디");
            entity.Property(e => e.created_tmstmp).HasComment("최초방문일");
            entity.Property(e => e.device_gb).HasComment("PC/M구분 (P/M)");
            entity.Property(e => e.linked_cnt).HasComment("이동횟수");
            entity.Property(e => e.site_div).HasComment("최초 이동시 진입사이트");
            entity.Property(e => e.updated_tmstmp).HasComment("최종방문일");
        });

        modelBuilder.Entity<barunson_authinfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("barunson_authinfo"));
        });

        modelBuilder.Entity<barunson_day_count>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("barunson_day_count"));

            entity.Property(e => e.day).IsFixedLength();
        });

        modelBuilder.Entity<bbarunson_log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("빠른손 로그"));

            entity.HasIndex(e => new { e.id, e.gubun, e.admin_id, e.reg_date, e.key_idx }, "IDX_bbarunson_log").HasFillFactor(90);

            entity.Property(e => e.act_sql).HasComment("작업 쿼리문");
            entity.Property(e => e.gubun).HasComment("구분");
        });

        modelBuilder.Entity<bbarunson_notice>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("빠른손 공지"));

            entity.Property(e => e.UpdateContent).HasComment("공시사항");
            entity.Property(e => e.UpdateDT).HasComment("공지일");
            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<bhands_day_count>(entity =>
        {
            entity.Property(e => e.day).IsFixedLength();
        });

        modelBuilder.Entity<board_basic_info>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("게시판기본정보"));

            entity.Property(e => e.Idx).ValueGeneratedOnAdd();
            entity.Property(e => e.answer).IsFixedLength();
            entity.Property(e => e.editor).IsFixedLength();
            entity.Property(e => e.pwd).IsFixedLength();
            entity.Property(e => e.reply).IsFixedLength();
            entity.Property(e => e.status).IsFixedLength();
        });

        modelBuilder.Entity<board_filter_info>(entity =>
        {
            entity.Property(e => e.my_cnt).IsFixedLength();
            entity.Property(e => e.protect).IsFixedLength();
        });

        modelBuilder.Entity<bsmall_main_view>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__bsmall_m__DDDFBCBE9769B270");

            entity.ToTable(tb => tb.HasComment("제휴 메인 페이지 관리"));

            entity.Property(e => e.jehu_grade).HasComment("제휴등급(A,B,C)");
            entity.Property(e => e.view_gb).HasComment("메인 메뉴구분");
            entity.Property(e => e.view_num).HasComment("메인 메뉴 순서번호");
        });

        modelBuilder.Entity<card_bbs>(entity =>
        {
            entity.HasKey(e => e.pk_id).HasName("PK__card_bbs__23893F36");
        });

        modelBuilder.Entity<card_design>(entity =>
        {
            entity.Property(e => e.design_type)
                .IsFixedLength()
                .HasComment("1:기본,2:특이");
            entity.Property(e => e.isBackground).IsFixedLength();
            entity.Property(e => e.isFPrint).IsFixedLength();
            entity.Property(e => e.isMapFPrint).IsFixedLength();
        });

        modelBuilder.Entity<card_design_detail>(entity =>
        {
            entity.Property(e => e.rtype).HasComment("1:인+이+일,2:약도,3:교통편,");
            entity.Property(e => e.alignment).HasComment("0:\"중앙,1:왼쪽,2:오른쪽 정렬");
            entity.Property(e => e.isFPrint).IsFixedLength();
        });

        modelBuilder.Entity<card_discount>(entity =>
        {
            entity.Property(e => e.card_group).IsFixedLength();
            entity.Property(e => e.card_kind).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<card_discount_rate_2u>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드할인율"));

            entity.Property(e => e.card_Group).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
        });

        modelBuilder.Entity<card_discount_season>(entity =>
        {
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.produce_year).IsFixedLength();
        });

        modelBuilder.Entity<card_faq>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("FAQ 관련"));

            entity.Property(e => e.pkid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<card_printinfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("제퓸별 인쇄(병합)정보"));

            entity.HasIndex(e => e.card_code, "IX_card_code").HasFillFactor(90);

            entity.HasIndex(e => e.print_type, "IX_print_type").HasFillFactor(90);

            entity.HasIndex(e => e.print_group, "IX_printer_group").HasFillFactor(90);

            entity.Property(e => e.print_type)
                .IsFixedLength()
                .HasComment("제품 타입(C/I/G/P/E)");
            entity.Property(e => e.card_code).HasComment("카드 코드");
            entity.Property(e => e.BOTH_SIDE_YORN).IsFixedLength();
            entity.Property(e => e.F_isBackImg).IsFixedLength();
            entity.Property(e => e.F_isBarcode).IsFixedLength();
            entity.Property(e => e.F_isDPrint).IsFixedLength();
            entity.Property(e => e.F_rotate_type).IsFixedLength();
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.isBackImg)
                .IsFixedLength()
                .HasComment("1이면 절단선 삽입");
            entity.Property(e => e.isBarcode).IsFixedLength();
            entity.Property(e => e.isBothSidePrinterYN).IsFixedLength();
            entity.Property(e => e.isDPrint)
                .IsFixedLength()
                .HasComment("1이면 양면인쇄");
            entity.Property(e => e.print_sizeH).HasComment("포인트 Y값");
            entity.Property(e => e.print_sizeW).HasComment("포인트 X값");
            entity.Property(e => e.printer_group).HasComment("사내 인쇄소(0:기본 마스터, 1:기본내지,2:디지털인쇄실)");
            entity.Property(e => e.rotate_type)
                .IsFixedLength()
                .HasComment("1이면 회전각 사용, 그 외의 경우 가로가 길 경우만 회전각 사용");
        });

        modelBuilder.Entity<choan_admin_log>(entity =>
        {
            entity.HasKey(e => e.seq).IsClustered(false);
        });

        modelBuilder.Entity<coperation>(entity =>
        {
            entity.Property(e => e.coperation_seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<cost_zipcode>(entity =>
        {
            entity.HasKey(e => e.C_ZIPCODE).HasName("PK__cost_zip__03D9801DDDC78697");
        });

        modelBuilder.Entity<custom_card_faq>(entity =>
        {
            entity.HasKey(e => e.pkid).HasName("PK__custom_card_faq__2759D01A");

            entity.ToTable(tb => tb.HasComment("고객센터)자주묻는질문"));
        });

        modelBuilder.Entity<custom_cms_msg>(entity =>
        {
            entity.Property(e => e.cms_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
        });

        modelBuilder.Entity<custom_info>(entity =>
        {
            entity.ToView("custom_info");

            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<custom_order>(entity =>
        {
            entity.HasKey(e => e.order_seq)
                .HasName("PK_custom_order_1")
                .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("주문관련정보"));

            entity.HasIndex(e => e.JebonExpectedDate, "IDX_corder__JebonExpectedDate").HasFillFactor(90);

            entity.HasIndex(e => e.PACKING_EXPECTED_DATE, "IDX_corder__PACKING_EXPECTED_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.company_seq, "IDX_corder__company_seq").HasFillFactor(90);

            entity.HasIndex(e => e.member_id, "IDX_corder__member_id").HasFillFactor(90);

            entity.HasIndex(e => e.src_ap_date, "IDX_corder__order_apdate").HasFillFactor(90);

            entity.HasIndex(e => e.order_email, "IDX_corder__order_email").HasFillFactor(90);

            entity.HasIndex(e => e.order_hphone, "IDX_corder__order_hphone").HasFillFactor(90);

            entity.HasIndex(e => e.order_name, "IDX_corder__order_name").HasFillFactor(90);

            entity.HasIndex(e => e.order_phone, "IDX_corder__order_phone").HasFillFactor(90);

            entity.HasIndex(e => e.sales_Gubun, "IDX_corder__sales_gubun").HasFillFactor(90);

            entity.HasIndex(e => e.settle_date, "IDX_corder__settle_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_CloseCopy_date, "IDX_corder__src_closecopy_date")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.src_compose_date, "IDX_corder__src_compose_date")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.src_compose_mod_date, "IDX_corder__src_compose_mod_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_confirm_date, "IDX_corder__src_confirm_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_jebon_date, "IDX_corder__src_jebon_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_packing_date, "IDX_corder__src_packing_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_print_commit_date, "IDX_corder__src_print_commit_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_print_date, "IDX_corder__src_print_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_printW_date, "IDX_corder__src_printw_date").HasFillFactor(90);

            entity.HasIndex(e => e.src_send_date, "IDX_corder__src_send_date").HasFillFactor(90);

            entity.HasIndex(e => e.up_order_seq, "IDX_corder__up_order_seq").HasFillFactor(90);

            entity.HasIndex(e => e.order_g_seq, "IDX_orger_g_seq").HasFillFactor(90);

            entity.HasIndex(e => e.order_count, "NCI_ORDER_COUNT").HasFillFactor(90);

            entity.HasIndex(e => e.order_type, "NCI_ORDER_TYPE").HasFillFactor(90);

            entity.HasIndex(e => e.order_date, "clu_order_date")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.pg_caldate, e.src_compose_admin_id }, "custom_order60").HasFillFactor(90);

            entity.HasIndex(e => e.pg_tid, "nind_pg_tid").HasFillFactor(90);

            entity.HasIndex(e => new { e.status_seq, e.settle_status }, "nind_status_seq_settle_status").HasFillFactor(90);

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.IsThanksCard).IsFixedLength();
            entity.Property(e => e.LiningJaebon_price).HasComment("라이닝제본비용");
            entity.Property(e => e.PACKING_EXPECTED_CHECK).IsFixedLength();
            entity.Property(e => e.PB_Coupon).HasComment("포토북 쿠폰");
            entity.Property(e => e.PosFlag)
                .IsFixedLength()
                .HasComment("포스 전송 여부");
            entity.Property(e => e.ProcLevel).HasComment("우선처리도.숫자 높을수록 우선처리.");
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.addition_couponseq).HasComment("중복쿠폰번호");
            entity.Property(e => e.addition_reduce_price).HasComment("중복쿠폰할인액");
            entity.Property(e => e.card_nointyn).IsFixedLength();
            entity.Property(e => e.card_opt).HasComment("staff몰에서 주문시 직원 이름");
            entity.Property(e => e.cont_price).HasComment("칼라내지 비용");
            entity.Property(e => e.coop_orderid).HasComment("제휴사측의 주문번호");
            entity.Property(e => e.coop_sale_price).HasComment("사용 안함");
            entity.Property(e => e.couponseq).HasComment("사용쿠폰번호");
            entity.Property(e => e.delivery_price).HasComment("배송비");
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.discount_rate).HasComment("할인율");
            entity.Property(e => e.embo_price).HasComment("엠보인쇄 비용");
            entity.Property(e => e.etc_price).HasComment("기타비용");
            entity.Property(e => e.etc_price_ment).HasComment("기타금액변동 사유");
            entity.Property(e => e.fticket_price).HasComment("식권비용");
            entity.Property(e => e.isAscrow)
                .IsFixedLength()
                .HasComment("에스크로 신청여부");
            entity.Property(e => e.isBaesongRisk)
                .IsFixedLength()
                .HasComment("1:급초안처리요망");
            entity.Property(e => e.isCCG).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper)
                .IsFixedLength()
                .HasComment("1:고급내지 옵션선택");
            entity.Property(e => e.isColorPrint)
                .IsFixedLength()
                .HasComment("0:일반인쇄 / 1:칼라 일반인쇄 / 2:한면 칼라인쇄 /3:양면 칼라인쇄");
            entity.Property(e => e.isColorPrt_card)
                .IsFixedLength()
                .HasComment("내지 칼라인쇄여부");
            entity.Property(e => e.isColorPrt_env)
                .IsFixedLength()
                .HasComment("봉투 칼라인쇄여부");
            entity.Property(e => e.isCompose)
                .IsFixedLength()
                .HasComment("코렐 작성 여부");
            entity.Property(e => e.isContAdd)
                .IsFixedLength()
                .HasComment("1:급매송처리요망");
            entity.Property(e => e.isCorel)
                .IsFixedLength()
                .HasComment("사용 안함.");
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvAdd)
                .IsFixedLength()
                .HasComment("1:카드인쇄판 추가");
            entity.Property(e => e.isEnvCharge).IsFixedLength();
            entity.Property(e => e.isEnvInsert)
                .IsFixedLength()
                .HasComment("1:봉투인쇄판추가");
            entity.Property(e => e.isEnvSpecial)
                .IsFixedLength()
                .HasComment("고급봉투 신청여부");
            entity.Property(e => e.isFTicket)
                .IsFixedLength()
                .HasComment("1:식권주문");
            entity.Property(e => e.isLanguage).HasComment("0:사용안함, KOR:한글, ENG:영문");
            entity.Property(e => e.isLiningJaebon)
                .IsFixedLength()
                .HasComment("봉투라이닝 (0:없음,1:유료,2:무료)");
            entity.Property(e => e.isMiniCard).IsFixedLength();
            entity.Property(e => e.isMoneyEnv).IsFixedLength();
            entity.Property(e => e.isPDF)
                .IsFixedLength()
                .HasComment("포토내지 청첩장 PDF작성 여부(사용안함)");
            entity.Property(e => e.isPerfume).IsFixedLength();
            entity.Property(e => e.isPrintCopy)
                .IsFixedLength()
                .HasComment("지시서 검증 여부(아직 사용안함)");
            entity.Property(e => e.isReceipt)
                .IsFixedLength()
                .HasComment("1:현금영수증 발행");
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial)
                .IsFixedLength()
                .HasComment("1:초특급 서비스 요청");
            entity.Property(e => e.isStoreRequisit).IsFixedLength();
            entity.Property(e => e.isVar)
                .IsFixedLength()
                .HasComment("기타 관리(현재는 T-map 신청여부)");
            entity.Property(e => e.isWMovie)
                .IsFixedLength()
                .HasComment("동영상 신청여부(프리미어비핸즈)");
            entity.Property(e => e.ishandmade)
                .IsFixedLength()
                .HasComment("1:핸드메이드서비스 가능");
            entity.Property(e => e.isinpaper)
                .IsFixedLength()
                .HasComment("1:속지부착 서비스 가능");
            entity.Property(e => e.jebon_price).HasComment("제본비");
            entity.Property(e => e.label_price).HasComment("라벨비용");
            entity.Property(e => e.last_total_price).HasComment("최종ERP전송금액");
            entity.Property(e => e.member_id).HasComment("주문 회원 아이디");
            entity.Property(e => e.mini_price).HasComment("미니청첩장");
            entity.Property(e => e.mini_status_seq).HasComment("미니청첩장 인쇄 진행 상태");
            entity.Property(e => e.option_price).HasComment("인쇄판추가비용");
            entity.Property(e => e.order_add_flag)
                .IsFixedLength()
                .HasComment("0:수정사항 없는 추가주문,1:수정추가주문");
            entity.Property(e => e.order_add_type)
                .IsFixedLength()
                .HasComment("0:셋트주문,2:봉투주문,3:백봉투주문");
            entity.Property(e => e.order_bname).HasComment("신부 이름");
            entity.Property(e => e.order_count).HasComment("주문수량");
            entity.Property(e => e.order_date).HasComment("주문일");
            entity.Property(e => e.order_email).HasComment("주문자 이메일");
            entity.Property(e => e.order_etc_comment).HasComment("주문 요구사항");
            entity.Property(e => e.order_faxphone).HasComment("주문자팩스번호");
            entity.Property(e => e.order_gname).HasComment("신랑 이름");
            entity.Property(e => e.order_hphone).HasComment("주문자 핸드폰 번호");
            entity.Property(e => e.order_name).HasComment("주문자 이름");
            entity.Property(e => e.order_phone).HasComment("주문자 전화번호");
            entity.Property(e => e.order_price).HasComment("카드정가합계");
            entity.Property(e => e.order_total_price).HasComment("카드할인가합계(카드 할인가 + env_price)");
            entity.Property(e => e.order_type).HasComment("주문타입 (1:청첩장 2:감사장 3:초대장 4,시즌카드 5:미니청첩장 6:포토/디지탈 7:이니셜 8:포토미니)");
            entity.Property(e => e.pay_Type)
                .IsFixedLength()
                .HasComment("0:pg 결제,1:주문영업결제,2:제휴사 후불,4:사고건");
            entity.Property(e => e.pg_caldate).HasComment("PG환불정산일");
            entity.Property(e => e.pg_fee).HasComment("PG수수료");
            entity.Property(e => e.pg_paydate).HasComment("PG정산일");
            entity.Property(e => e.pg_payprice).HasComment("사용안함");
            entity.Property(e => e.pg_recaldate).HasComment("PG환불수금일");
            entity.Property(e => e.pg_receipt_tid).HasComment("현금영수증 이니시스 TID");
            entity.Property(e => e.pg_repaydate).HasComment("PG수금일");
            entity.Property(e => e.pg_resultinfo).HasComment("PG결제메세지");
            entity.Property(e => e.pg_resultinfo2).HasComment("가상계좌일 경우 입금자 이름");
            entity.Property(e => e.pg_shopid).HasComment("PG아이디");
            entity.Property(e => e.pg_status).HasComment("사용안함");
            entity.Property(e => e.pg_tid).HasComment("이니시스 TID");
            entity.Property(e => e.point_price).HasComment("적립금");
            entity.Property(e => e.printW_status).HasComment("인쇄 대기 상태");
            entity.Property(e => e.print_color).HasComment("칼라내지 인쇄 색상");
            entity.Property(e => e.print_price).HasComment("인쇄비");
            entity.Property(e => e.print_type).HasComment("이니셜 청첩장의 인쇄타입");
            entity.Property(e => e.reduce_price).HasComment("쿠폰할인금액");
            entity.Property(e => e.sales_Gubun).HasComment("B:제휴,H:프페 제휴, SA:비핸즈, SS:프페,SB: 바른손, ST:더카드,D:대리점 , P:아웃바운드, Q:지역대리점");
            entity.Property(e => e.sasik_price).HasComment("사식비");
            entity.Property(e => e.settle_cancel_date).HasComment("결제취소일");
            entity.Property(e => e.settle_date).HasComment("결제일");
            entity.Property(e => e.settle_method)
                .IsFixedLength()
                .HasComment("결제방법(1:계좌이체,3:무통장,2,6:카드, 8:카카오페이)");
            entity.Property(e => e.settle_price).HasComment("결제금액");
            entity.Property(e => e.settle_status).HasComment("결제상태 (0:결제이전/ 1:가상계좌입금전/ 2:결제완료/ 3,5:결제취소)");
            entity.Property(e => e.site_gubun)
                .IsFixedLength()
                .HasComment("(0:원래의 사이트,1:제휴사,3:제휴사 커스터마이징,4:사고건)");
            entity.Property(e => e.src_CloseCopy_date).HasComment("원고마감 처리일");
            entity.Property(e => e.src_PrintCopy_admin_id).HasComment("원고출력자");
            entity.Property(e => e.src_ap_admin_id).HasComment("주문승인 처리자");
            entity.Property(e => e.src_cancel_admin_id).HasComment("주문 취소자");
            entity.Property(e => e.src_cancel_date).HasComment("주문 취소일");
            entity.Property(e => e.src_compose_admin_id).HasComment("초안작성자");
            entity.Property(e => e.src_compose_date).HasComment("초안작성일");
            entity.Property(e => e.src_compose_mod_admin_id).HasComment("초안수정자");
            entity.Property(e => e.src_compose_mod_date).HasComment("초안 최종 수정일");
            entity.Property(e => e.src_confirm_date).HasComment("초안 확정일");
            entity.Property(e => e.src_erp_date).HasComment("ERP전송일");
            entity.Property(e => e.src_jebon_commit_date).HasComment("제본 완료일");
            entity.Property(e => e.src_jebon_date).HasComment("제본시작일");
            entity.Property(e => e.src_mini_cut_date).HasComment("사용 안함");
            entity.Property(e => e.src_mini_packing_date).HasComment("사용 안함");
            entity.Property(e => e.src_mini_print_date).HasComment("사용 안함");
            entity.Property(e => e.src_modRequest_date).HasComment("초안 최종 수정 요청일");
            entity.Property(e => e.src_packing_date).HasComment("포장 처리일");
            entity.Property(e => e.src_printCopy_date).HasComment("원고출력 처리일");
            entity.Property(e => e.src_printW_date).HasComment("인쇄대기 처리일");
            entity.Property(e => e.src_print_admin_id).HasComment("인쇄처리자");
            entity.Property(e => e.src_print_commit_date).HasComment("인쇄 완료일");
            entity.Property(e => e.src_print_date).HasComment("인쇄 처리일");
            entity.Property(e => e.src_printer_seq).HasComment("인쇄소(0:내부,1:내부-구분,2:내부-3층,3:학술,4:성원,5:대리점)");
            entity.Property(e => e.src_sendW_date).HasComment("배송대기 처리일(현재 사용안함)");
            entity.Property(e => e.src_send_date).HasComment("배송 처리일");
            entity.Property(e => e.status_seq).HasComment("1:주문 삭제 / 0:주문진행중 / 1:주문완료/ 3:주문취소/ 5:결제취소/ 6:초안수정요청/ 7:초안등록/ 8:초안수정등록/ 9:컨펌완료/ 10:인쇄대기/ 11:인쇄중/ 12:인쇄완료/ 13:제본/ 14:포장/ 15:발송");
            entity.Property(e => e.sticker_price).HasComment("유료스티커");
            entity.Property(e => e.trouble_type).HasComment("사고유형");
            entity.Property(e => e.unicef_price).HasComment("유니세스 기부금");
            entity.Property(e => e.up_order_seq).HasComment("추가주문일 경우 원 주문번호");
            entity.Property(e => e.weddinfo_id).HasComment(".order_seq추가주문이거나 사고건인 경우 원주문의 order_Seq가 된다.");
        });

        modelBuilder.Entity<custom_order_OtherInfo>(entity =>
        {
            entity.HasKey(e => e.ORDER_SEQ).HasName("PK__custom_o__6F0E90B89192D41F");

            entity.Property(e => e.ORDER_SEQ).ValueGeneratedNever();
        });

        modelBuilder.Entity<custom_order_WeddInfo>(entity =>
        {
            entity.HasKey(e => e.iid).IsClustered(false);

            entity.ToTable(tb => tb.HasComment("카드인쇄정보"));

            entity.HasIndex(e => e.weddimg_idx, "NCI-WEDDIMG_IDX").HasFillFactor(90);

            entity.HasIndex(e => e.wedd_idx, "NCI-WEDD_IDX").HasFillFactor(90);

            entity.HasIndex(e => e.wedd_date, "NCI_WEDD_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "custom_order_WeddInfo3")
                .IsDescending()
                .HasFillFactor(90);

            entity.Property(e => e.MiniCard_Opt).IsFixedLength();
            entity.Property(e => e.bride_Fname_eng).HasComment("미니청첩장용 영문 성");
            entity.Property(e => e.bride_father).HasComment("신부 아버지");
            entity.Property(e => e.bride_father_fname).HasComment("신부 아버지 성");
            entity.Property(e => e.bride_father_header).HasComment("신부 아버지 故");
            entity.Property(e => e.bride_father_tail).HasComment("신부 아버지 세례명");
            entity.Property(e => e.bride_fname).HasComment("신부 성");
            entity.Property(e => e.bride_initial)
                .IsFixedLength()
                .HasComment("스토리러브 청첩장중, 이니셜 신부 이니셜");
            entity.Property(e => e.bride_initial1).IsFixedLength();
            entity.Property(e => e.bride_mother).HasComment("신부 어머니");
            entity.Property(e => e.bride_mother_fname).HasComment("신부 어머니 성");
            entity.Property(e => e.bride_mother_header).HasComment("신부 어머니 故");
            entity.Property(e => e.bride_mother_tail).HasComment("신부 어머니 세례명");
            entity.Property(e => e.bride_name).HasComment("신부이름");
            entity.Property(e => e.bride_name_eng).HasComment("미니청첩장용 영문 이름");
            entity.Property(e => e.bride_rank).HasComment("신부 관계");
            entity.Property(e => e.bride_star).IsFixedLength();
            entity.Property(e => e.bride_tail).HasComment("신부 세례명");
            entity.Property(e => e.etc_comment).HasComment("기타 요청사항");
            entity.Property(e => e.etc_file).HasComment("기타 요청사항 첨부파일");
            entity.Property(e => e.event_Day).HasComment("예식 일");
            entity.Property(e => e.event_ampm).HasComment("예식 오전/오후/낮 표기");
            entity.Property(e => e.event_hour).HasComment("예식 시");
            entity.Property(e => e.event_minute).HasComment("예식 분");
            entity.Property(e => e.event_month).HasComment("예식 월");
            entity.Property(e => e.event_weekname).HasComment("예식 요일");
            entity.Property(e => e.event_year).HasComment("예식 년");
            entity.Property(e => e.fetype)
                .IsFixedLength()
                .HasComment("봉투 폰트타입");
            entity.Property(e => e.ftype)
                .IsFixedLength()
                .HasComment("폰트타입(0:A type,1:B type,2:C type,3:E type) ,한지카드의 경우 2:가로형,3:세로형");
            entity.Property(e => e.greeting_content).HasComment("인사말 내용");
            entity.Property(e => e.groom_Fname_eng).HasComment("미니청첩장용 영문 성");
            entity.Property(e => e.groom_father).HasComment("신랑 아버지");
            entity.Property(e => e.groom_father_fname).HasComment("신랑 아버지 성");
            entity.Property(e => e.groom_father_header).HasComment("신랑 아버지 故");
            entity.Property(e => e.groom_father_tail).HasComment("신랑 아버지 세례명");
            entity.Property(e => e.groom_fname).HasComment("신랑 성");
            entity.Property(e => e.groom_initial)
                .IsFixedLength()
                .HasComment("스토리러브 청첩장중, 이니셜 신랑 이니셜");
            entity.Property(e => e.groom_initial1).IsFixedLength();
            entity.Property(e => e.groom_mother).HasComment("신랑 어머지");
            entity.Property(e => e.groom_mother_fname).HasComment("신랑 어머니 성");
            entity.Property(e => e.groom_mother_header).HasComment("신랑 어머니 故");
            entity.Property(e => e.groom_mother_tail).HasComment("신랑 어머니 세례명");
            entity.Property(e => e.groom_name).HasComment("신랑이름");
            entity.Property(e => e.groom_name_eng).HasComment("미니청첩장용 영문 이름");
            entity.Property(e => e.groom_rank).HasComment("신랑 관계");
            entity.Property(e => e.groom_star).IsFixedLength();
            entity.Property(e => e.groom_tail).HasComment("신랑 세례명");
            entity.Property(e => e.invite_name).HasComment("초대장일 경우 초대인 이름");
            entity.Property(e => e.isNotMapPrint)
                .IsFixedLength()
                .HasComment("1:약도인쇄안함");
            entity.Property(e => e.isbride_tail)
                .IsFixedLength()
                .HasComment("신부 세례명 표기 여부");
            entity.Property(e => e.isgroom_tail)
                .IsFixedLength()
                .HasComment("신랑 세례명 표기 여부");
            entity.Property(e => e.keyimg).HasComment("현재는 티맵 키워드 저장");
            entity.Property(e => e.lunar_event_Date).HasComment("음력일");
            entity.Property(e => e.lunar_yes_or_no).HasComment("음력표기 여부");
            entity.Property(e => e.map_id).HasComment("자동초안주문인 경우 사용 약도ID");
            entity.Property(e => e.map_info).HasComment("예식장 추가정보");
            entity.Property(e => e.map_trans_method)
                .IsFixedLength()
                .HasComment("약도 전송 방법");
            entity.Property(e => e.map_uploadfile).HasComment("사용안함");
            entity.Property(e => e.picture1).HasComment("포토청첩장일 경우 사용자 이미지");
            entity.Property(e => e.picture2).HasComment("포토청첩장일 경우 사용자 이미지");
            entity.Property(e => e.picture3).HasComment("포토청첩장일 경우 사용자 이미지");
            entity.Property(e => e.traffic_id).HasComment("자동초안주문인 경우 사용 교통편ID");
            entity.Property(e => e.wedd_addr).HasComment("예식장 주소");
            entity.Property(e => e.wedd_date).HasComment("예식일(주문단에서 입력받은 행사일 정보 조합)");
            entity.Property(e => e.wedd_idx).HasComment("바른손 예식장 키값");
            entity.Property(e => e.wedd_name).HasComment("예식장 이름");
            entity.Property(e => e.wedd_phone).HasComment("예식장 전화번호");
            entity.Property(e => e.wedd_place).HasComment("예식장소");
            entity.Property(e => e.weddimg_idx).HasComment("바른손 약도 키값");
        });

        modelBuilder.Entity<custom_order_WeddInfo_backup>(entity =>
        {
            entity.Property(e => e.MiniCard_Opt).IsFixedLength();
            entity.Property(e => e.bride_initial).IsFixedLength();
            entity.Property(e => e.bride_initial1).IsFixedLength();
            entity.Property(e => e.bride_star).IsFixedLength();
            entity.Property(e => e.fetype).IsFixedLength();
            entity.Property(e => e.ftype).IsFixedLength();
            entity.Property(e => e.groom_initial).IsFixedLength();
            entity.Property(e => e.groom_initial1).IsFixedLength();
            entity.Property(e => e.groom_star).IsFixedLength();
            entity.Property(e => e.isNotMapPrint).IsFixedLength();
            entity.Property(e => e.isbride_tail).IsFixedLength();
            entity.Property(e => e.isgroom_tail).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_agreement>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CUSTOM_ORDER_AGREEMENT");

            entity.Property(e => e.seq).HasComment("increment");
            entity.Property(e => e.agreement_type).HasComment("동의 타입 (africa, unicef)");
            entity.Property(e => e.is_agreemented).HasComment("동의여부 0, 1");
            entity.Property(e => e.is_print).HasComment("봉투 프린트 여부 0, 1");
            entity.Property(e => e.order_seq).HasComment("custom_order.order_seq");
            entity.Property(e => e.reg_date).HasComment("등록시간");
        });

        modelBuilder.Entity<custom_order_backup>(entity =>
        {
            entity.Property(e => e.IsThanksCard).IsFixedLength();
            entity.Property(e => e.PACKING_EXPECTED_CHECK).IsFixedLength();
            entity.Property(e => e.PosFlag).IsFixedLength();
            entity.Property(e => e.WisaFlag).IsFixedLength();
            entity.Property(e => e.card_nointyn).IsFixedLength();
            entity.Property(e => e.discount_in_advance).IsFixedLength();
            entity.Property(e => e.isAscrow).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isCCG).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isColorPrt_card).IsFixedLength();
            entity.Property(e => e.isColorPrt_env).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isContAdd).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isEnvAdd).IsFixedLength();
            entity.Property(e => e.isEnvCharge).IsFixedLength();
            entity.Property(e => e.isEnvInsert).IsFixedLength();
            entity.Property(e => e.isEnvSpecial).IsFixedLength();
            entity.Property(e => e.isFTicket).IsFixedLength();
            entity.Property(e => e.isLiningJaebon).IsFixedLength();
            entity.Property(e => e.isMiniCard).IsFixedLength();
            entity.Property(e => e.isMoneyEnv).IsFixedLength();
            entity.Property(e => e.isPDF).IsFixedLength();
            entity.Property(e => e.isPerfume).IsFixedLength();
            entity.Property(e => e.isPrintCopy).IsFixedLength();
            entity.Property(e => e.isReceipt).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.isStoreRequisit).IsFixedLength();
            entity.Property(e => e.isVar).IsFixedLength();
            entity.Property(e => e.isWMovie).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_copy_backup>(entity =>
        {
            entity.Property(e => e.isQuick).IsFixedLength();
            entity.Property(e => e.isRisk).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_copy_detail_backup>(entity =>
        {
            entity.Property(e => e.isPItem).IsFixedLength();
            entity.Property(e => e.item_type).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_cprice>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<custom_order_files>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("제휴 인쇄cdr 파일 관리"));

            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<custom_order_history>(entity =>
        {
            entity.HasKey(e => e.id)
                .HasName("PK_custom_order_choan_history")
                .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("빠른손-처리히스토리 내역"));

            entity.HasIndex(e => e.htype, "NCI-HTYPE").HasFillFactor(90);

            entity.HasIndex(e => new { e.order_seq, e.htype, e.reg_date }, "NCI-ORDER_SEQ-HTYPE-REG_DATE").HasFillFactor(90);

            entity.HasIndex(e => e.reg_date, "NCI-REG_DATE").HasFillFactor(90);

            entity.HasIndex(e => new { e.order_seq, e.reg_date, e.memo }, "nind_order_seq")
                .IsDescending(true, true, false)
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.admin_id).HasComment("담당자");
            entity.Property(e => e.htype).HasComment("수정섹션");
            entity.Property(e => e.ipAddress).HasComment("아이피정보");
            entity.Property(e => e.isVisible)
                .IsFixedLength()
                .HasComment("히스토리보기 여부");
            entity.Property(e => e.order_seq).HasComment("주문번호");
            entity.Property(e => e.system_sql).HasComment("관련 쿼리문");
        });

        modelBuilder.Entity<custom_order_item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주문상세내역"));

            entity.HasIndex(e => e.card_seq, "IDX_iorder__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.item_count, "IDX_iorder__item_count").HasFillFactor(90);

            entity.HasIndex(e => e.item_type, "IDX_iorder__item_type").HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "IDX_iorder__order_seq").HasFillFactor(90);

            entity.Property(e => e.addnum_price).HasComment("추가수량비용(셋트 이외의 수량에 대한 합계비용)");
            entity.Property(e => e.discount_rate).HasComment("할인율");
            entity.Property(e => e.item_count).HasComment("주문수량");
            entity.Property(e => e.item_price).HasComment("소비자가");
            entity.Property(e => e.item_sale_price).HasComment("판매가");
            entity.Property(e => e.item_type)
                .IsFixedLength()
                .HasComment("manage_code.itemt_type");
            entity.Property(e => e.memo1).HasComment("기타정보(미니청첩장의경우 인쇄색상등)");
        });

        modelBuilder.Entity<custom_order_log>(entity =>
        {
            entity.Property(e => e.flag).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_passbook>(entity =>
        {
            entity.Property(e => e.passbook_type_code).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_plist>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_custom_order_plist_last");

            entity.ToTable(tb => tb.HasComment("주문관련 인쇄판정보"));

            entity.HasIndex(e => e.card_seq, "IDX_porder__card_seq").HasFillFactor(90);

            entity.HasIndex(e => e.print_count, "IDX_porder__print_count").HasFillFactor(90);

            entity.HasIndex(e => e.print_date, "IDX_porder__print_date").HasFillFactor(90);

            entity.HasIndex(e => e.print_type, "IDX_porder__print_type").HasFillFactor(90);

            entity.HasIndex(e => e.order_seq, "custom_order_plist8").HasFillFactor(90);

            entity.HasIndex(e => e.isNotPrint, "nind_isnotprint").HasFillFactor(90);

            entity.Property(e => e.choan_date).HasComment("초안작성일");
            entity.Property(e => e.choanmerge_date).HasComment("코렐 병합일");
            entity.Property(e => e.env_addr).HasComment("주소");
            entity.Property(e => e.env_addr_detail).HasComment("상세주소");
            entity.Property(e => e.env_hphone).HasComment("핸드폰 번호");
            entity.Property(e => e.env_hphone2).HasComment("보내는 사람 연락처");
            entity.Property(e => e.env_person1).HasComment("이름1");
            entity.Property(e => e.env_person1_header).HasComment("故");
            entity.Property(e => e.env_person1_tail).HasComment("이름1 세례명");
            entity.Property(e => e.env_person2).HasComment("이름2");
            entity.Property(e => e.env_person2_header).HasComment("故");
            entity.Property(e => e.env_person2_tail).HasComment("이름2 세례명");
            entity.Property(e => e.env_person_Tail).HasComment("귀하");
            entity.Property(e => e.env_phone).HasComment("전화번호");
            entity.Property(e => e.env_zip).HasComment("우편번호");
            entity.Property(e => e.etc_comment).HasComment("기타 요청 내용");
            entity.Property(e => e.etc_info_s).HasComment("기타 정보(미니 인쇄 색상 등)");
            entity.Property(e => e.imgFolder).HasComment("초안이미지 저장 폴더");
            entity.Property(e => e.imgName).HasComment("초안이미지 파일명");
            entity.Property(e => e.isBasic)
                .IsFixedLength()
                .HasComment("기본인쇄판 여부");
            entity.Property(e => e.isEnv_person_tail).IsFixedLength();
            entity.Property(e => e.isFPrint)
                .IsFixedLength()
                .HasComment("1일 경우 앞면 인쇄판");
            entity.Property(e => e.isNotPrint)
                .IsFixedLength()
                .HasComment("1: 인쇄를 안하는 경우(백봉투) / 2:세로형 봉투:축하해 주셔서 감사합니다. /3:세로형 봉투:\"\"\"\"祝賀해 주셔서 感謝합니다. /4:가로형 봉투:축하해 주셔서 감사합니다. /5:가로형 봉투:\"\"\"\"祝賀해 주셔서 感謝합니다.");
            entity.Property(e => e.isNotPrint_Addr).IsFixedLength();
            entity.Property(e => e.isNotSet)
                .IsFixedLength()
                .HasComment("추가 주문시, 카드없이 내지만 주문하는 경우 1");
            entity.Property(e => e.isPostMark)
                .IsFixedLength()
                .HasComment("요금별납 인쇄 여부");
            entity.Property(e => e.isQrcode)
                .IsFixedLength()
                .HasComment("QRCODE 인쇄여부");
            entity.Property(e => e.isZipBox)
                .IsFixedLength()
                .HasComment("받는 사람 우편번호 박스 표기 여부");
            entity.Property(e => e.option_price).HasComment("옵션 비용");
            entity.Property(e => e.order_filename).HasComment("판정보를 파일 업로드시 파일명.");
            entity.Property(e => e.postname).HasComment("요금별납 인쇄일 경우 해당 우체국명");
            entity.Property(e => e.postname_tail).HasComment("요금별납 인쇄할 경우 우체국/우편집중국 등의 정보");
            entity.Property(e => e.preview_seq).HasComment("관련 초안정보(변환 이전 데이터, 사용안함)");
            entity.Property(e => e.print_admin_id).HasComment("인쇄 담당자");
            entity.Property(e => e.print_count).HasComment("인쇄 수량");
            entity.Property(e => e.print_date).HasComment("인쇄일");
            entity.Property(e => e.print_type)
                .IsFixedLength()
                .HasComment("C:카드,I:내지,E:봉투, M:미니,P:약도카드");
            entity.Property(e => e.pstatus).HasComment("0:요청, 1:초안등록");
            entity.Property(e => e.recv_tail).HasComment("받는 사람 명칭정보(귀하 등)");
            entity.Property(e => e.title).HasComment("판이름");
            entity.Property(e => e.up_id).HasComment("추가주문시 주문한 원주문의 판정보");
        });

        modelBuilder.Entity<custom_order_plistAddD>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드 추가판 날짜 정보"));

            entity.Property(e => e.addr_gb).HasComment("0:둘다선택, 1:둘다선택안함, 2:지번주소만, 3:도로명주소만");
            entity.Property(e => e.event_ampm).HasComment("예식 오전/오후/낮 표기");
            entity.Property(e => e.event_day).HasComment("예식 일");
            entity.Property(e => e.event_hour).HasComment("예식 시");
            entity.Property(e => e.event_minute).HasComment("예식 분");
            entity.Property(e => e.event_month).HasComment("예식 월");
            entity.Property(e => e.event_weekname).HasComment("예식 요일");
            entity.Property(e => e.event_year).HasComment("예식 년");
            entity.Property(e => e.isNotMapPrint).IsFixedLength();
            entity.Property(e => e.lunar_event_date).HasComment("음력일");
            entity.Property(e => e.lunar_yes_or_no).HasComment("음력표기 여부");
            entity.Property(e => e.map_id).HasComment("AI 약도 아이디");
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.traffic_id).HasComment("AI 교통편 아이디");
            entity.Property(e => e.wedd_addr).HasComment("예식장 주소");
            entity.Property(e => e.wedd_idx).HasComment("바른손 예식장 키값");
            entity.Property(e => e.wedd_imgidx).HasComment("바른손 약도 키값");
            entity.Property(e => e.wedd_name).HasComment("예식장 이름");
            entity.Property(e => e.wedd_phone).HasComment("예식장 전화번호");
            entity.Property(e => e.wedd_place).HasComment("예식장소");
            entity.Property(e => e.wedd_road_Addr).HasComment("도로명주소");
        });

        modelBuilder.Entity<custom_order_plistAddD_backup>(entity =>
        {
            entity.Property(e => e.isNotMapPrint).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_plistAddG>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드 추가판 인사말 정보"));

            entity.Property(e => e.greeting_content).HasComment("인사말");
        });

        modelBuilder.Entity<custom_order_plistAddN>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드 추가판 이름 정보"));

            entity.Property(e => e.bride_father).HasComment("신부 아버지");
            entity.Property(e => e.bride_father_fname).HasComment("신부 아버지 성");
            entity.Property(e => e.bride_father_header).HasComment("신부 아버지 故");
            entity.Property(e => e.bride_father_tail).HasComment("신부 아버지 세례명");
            entity.Property(e => e.bride_fname).HasComment("신부 성");
            entity.Property(e => e.bride_mother).HasComment("신부 어머니");
            entity.Property(e => e.bride_mother_fname).HasComment("신부 어머니 성");
            entity.Property(e => e.bride_mother_header).HasComment("신부 어머니 故");
            entity.Property(e => e.bride_mother_tail).HasComment("신부 어머니 세례명");
            entity.Property(e => e.bride_name).HasComment("신부이름");
            entity.Property(e => e.bride_rank).HasComment("신부 관계");
            entity.Property(e => e.bride_tail).HasComment("신부 세례명");
            entity.Property(e => e.groom_father).HasComment("신랑 아버지");
            entity.Property(e => e.groom_father_fname).HasComment("신랑 아버지 성");
            entity.Property(e => e.groom_father_header).HasComment("신랑 아버지 故");
            entity.Property(e => e.groom_father_tail).HasComment("신랑 아버지 세례명");
            entity.Property(e => e.groom_fname).HasComment("신랑 성");
            entity.Property(e => e.groom_mother).HasComment("신랑 어머니");
            entity.Property(e => e.groom_mother_fname).HasComment("신랑 어머니 성");
            entity.Property(e => e.groom_mother_header).HasComment("신랑 어머니 故");
            entity.Property(e => e.groom_mother_tail).HasComment("신랑 어머니 세례명");
            entity.Property(e => e.groom_name).HasComment("신랑이름");
            entity.Property(e => e.groom_rank).HasComment("신랑 관계");
            entity.Property(e => e.groom_tail).HasComment("신랑 세례명");
            entity.Property(e => e.invite_name).HasComment("초대장일 경우 초대인 이름");
            entity.Property(e => e.isbride_tail)
                .IsFixedLength()
                .HasComment("신부 세례명 표기 여부");
            entity.Property(e => e.isgroom_tail)
                .IsFixedLength()
                .HasComment("신랑 세례명 표기 여부");
        });

        modelBuilder.Entity<custom_order_plistAddN_backup>(entity =>
        {
            entity.Property(e => e.isbride_tail).IsFixedLength();
            entity.Property(e => e.isgroom_tail).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_plistAddT>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("카드 추가판 기타내용"));
        });

        modelBuilder.Entity<custom_order_plistSVG>(entity =>
        {
            entity.Property(e => e.pid).ValueGeneratedNever();
        });

        modelBuilder.Entity<custom_order_plist_backup>(entity =>
        {
            entity.Property(e => e.isBasic).IsFixedLength();
            entity.Property(e => e.isEnv_person_tail).IsFixedLength();
            entity.Property(e => e.isFPrint).IsFixedLength();
            entity.Property(e => e.isNotPrint).IsFixedLength();
            entity.Property(e => e.isNotPrint_Addr).IsFixedLength();
            entity.Property(e => e.isNotSet).IsFixedLength();
            entity.Property(e => e.isPostMark).IsFixedLength();
            entity.Property(e => e.isQrcode).IsFixedLength();
            entity.Property(e => e.isZipBox).IsFixedLength();
            entity.Property(e => e.print_type).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_plist_svg>(entity =>
        {
            entity.Property(e => e.pid).ValueGeneratedNever();
        });

        modelBuilder.Entity<custom_order_printW>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<custom_order_printjob>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.ptype).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_quick>(entity =>
        {
            entity.Property(e => e.sender_code).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_refund>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_custom_order_refund_1");

            entity.ToTable(tb => tb.HasComment("환불 관련"));

            entity.Property(e => e.REFUND_TYPE_CODE).HasComment("환불세부유형 manage_code.code");
            entity.Property(e => e.bank_account).HasComment("환불은행계좌");
            entity.Property(e => e.bank_name).HasComment("환물은행명");
            entity.Property(e => e.bank_user).HasComment("환불은행 예금주");
            entity.Property(e => e.order_name).HasComment("주문자명");
            entity.Property(e => e.refund_date).HasComment("환불일");
            entity.Property(e => e.refund_gubun).HasComment("환불 유형");
            entity.Property(e => e.refund_msg).HasComment("메모");
            entity.Property(e => e.refund_price).HasComment("환불금액");
            entity.Property(e => e.settle_date).HasComment("결제일");
            entity.Property(e => e.settle_method)
                .IsFixedLength()
                .HasComment("결제방법 (1:계좌이체,3:무통장,2,6:카드)");
            entity.Property(e => e.settle_price).HasComment("결제금액");
        });

        modelBuilder.Entity<custom_order_tmap>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("old) TMAP"));

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.rstatus).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_trouble>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK__custom_o__82F29E50399ADDCB");

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.RequestOutDate).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_trouble2>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK__custom_o__82F29E50F838FD28");

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.RequestOutDate).IsFixedLength();
        });

        modelBuilder.Entity<custom_order_unicef>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("유니세프 기부금관련정보"));

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.isjumin).IsFixedLength();
            entity.Property(e => e.isulogo_print).IsFixedLength();
            entity.Property(e => e.jumin).IsFixedLength();
        });

        modelBuilder.Entity<deardeer_order_rel>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<delivery_info_backup>(entity =>
        {
            entity.Property(e => e.DELIVERY_COM).IsFixedLength();
            entity.Property(e => e.DELIVERY_PAY).IsFixedLength();
            entity.Property(e => e.Delivery_Type).IsFixedLength();
            entity.Property(e => e.isNewCopy).IsFixedLength();
            entity.Property(e => e.nt_code).IsFixedLength();
        });

        modelBuilder.Entity<delivery_info_detail_backup>(entity =>
        {
            entity.Property(e => e.item_type).IsFixedLength();
        });

        modelBuilder.Entity<err_chk_log>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__err_chk___DDDFBCBEF53DE4F4");
        });

        modelBuilder.Entity<event_sms_coupon>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__event_sm__DDDFBCBEA8108DDE");
        });

        modelBuilder.Entity<evt_himo_coupon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("하이모 이벤트"));
        });

        modelBuilder.Entity<evt_mem_regist_gift>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__evt_mem___DDDFBCBEB791D5B5");
        });

        modelBuilder.Entity<ewed_ATTEND_LIST>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_ATTEND_LIST__seq");

            entity.Property(e => e.seq).ValueGeneratedNever();
            entity.Property(e => e.result).IsFixedLength();
        });

        modelBuilder.Entity<ewed_BUY_CARD>(entity =>
        {
            entity.Property(e => e.buy_card_SEQ).ValueGeneratedNever();
        });

        modelBuilder.Entity<ewed_BUY_CARD_CONTENT>(entity =>
        {
            entity.Property(e => e.buy_card_SEQ).ValueGeneratedNever();
            entity.Property(e => e.buy_AMPM).IsFixedLength();
            entity.Property(e => e.buy_DAY).IsFixedLength();
            entity.Property(e => e.buy_HOUR).IsFixedLength();
            entity.Property(e => e.buy_MINUTE).IsFixedLength();
            entity.Property(e => e.buy_MONTH).IsFixedLength();
            entity.Property(e => e.buy_WEEK).IsFixedLength();
            entity.Property(e => e.buy_YEAR).IsFixedLength();
            entity.Property(e => e.place_file_insert).IsFixedLength();

            entity.HasOne(d => d.buy_card_SEQNavigation).WithOne(p => p.ewed_BUY_CARD_CONTENT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ewed_BUY_CARD_CONTENT_ewed_BUY_CARD");
        });

        modelBuilder.Entity<ewed_BUY_SETTLE_INFO>(entity =>
        {
            entity.Property(e => e.buy_card_SEQ).ValueGeneratedNever();
            entity.Property(e => e.CardQuota).IsFixedLength();
            entity.Property(e => e.QuotaInterest).IsFixedLength();
            entity.Property(e => e.ResultCode).IsFixedLength();

            entity.HasOne(d => d.buy_card_SEQNavigation).WithOne(p => p.ewed_BUY_SETTLE_INFO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ewed_BUY_SETTLE_INFO_ewed_BUY_CARD");
        });

        modelBuilder.Entity<ewed_CARD_INFO>(entity =>
        {
            entity.Property(e => e.CATE_L_CODE).IsFixedLength();
            entity.Property(e => e.CATE_S_CODE).IsFixedLength();
            entity.Property(e => e.attend_use_yn).IsFixedLength();
            entity.Property(e => e.auto_yn).IsFixedLength();
            entity.Property(e => e.bujoo_yn).IsFixedLength();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isDisplay).IsFixedLength();
            entity.Property(e => e.isFull).IsFixedLength();
            entity.Property(e => e.isNew).IsFixedLength();
            entity.Property(e => e.isview_yn).IsFixedLength();
            entity.Property(e => e.miniCD_use_yn).IsFixedLength();
            entity.Property(e => e.music_yn).IsFixedLength();
            entity.Property(e => e.sms_yn).IsFixedLength();
            entity.Property(e => e.swf_type).IsFixedLength();
            entity.Property(e => e.visit_use_yn).IsFixedLength();
            entity.Property(e => e.wd_size).IsFixedLength();
        });

        modelBuilder.Entity<ewed_CARD_USER_COMMNET>(entity =>
        {
            entity.Property(e => e.DIV).IsFixedLength();
            entity.Property(e => e.IsBest).IsFixedLength();
        });

        modelBuilder.Entity<ewed_Music_Data>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_Music_Data__seq");
        });

        modelBuilder.Entity<ewed_Notice>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_Notice__seq");

            entity.Property(e => e.div).IsFixedLength();
        });

        modelBuilder.Entity<ewed_Notice_daum>(entity =>
        {
            entity.Property(e => e.div).IsFixedLength();
        });

        modelBuilder.Entity<ewed_Open_Text>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_Open_Text__seq");
        });

        modelBuilder.Entity<ewed_Order_Detail>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_CIDX_ewed_Order_Detail__order_seq");

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.attend_use_yn).IsFixedLength();
            entity.Property(e => e.lunar_yn).IsFixedLength();
            entity.Property(e => e.map_send_way).IsFixedLength();
            entity.Property(e => e.music_use_yn).IsFixedLength();
            entity.Property(e => e.order_div).IsFixedLength();
            entity.Property(e => e.p_input_yn).IsFixedLength();
            entity.Property(e => e.photo_use_yn).IsFixedLength();
            entity.Property(e => e.place_data_way).IsFixedLength();
            entity.Property(e => e.visit_use_yn).IsFixedLength();
            entity.Property(e => e.we_use_yn).IsFixedLength();
        });

        modelBuilder.Entity<ewed_Order_MemoDay>(entity =>
        {
            entity.HasKey(e => e.m_seq).HasName("PK_CIDX_ewed_Order_MemoDay__m_seq");

            entity.HasIndex(e => e.order_seq, "IDX__order_seq").HasFillFactor(90);

            entity.HasIndex(e => e.seq, "IDX__seq").HasFillFactor(90);
        });

        modelBuilder.Entity<ewed_Order_Photo>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_CIDX_ewed_Order_Photo__order_seq");

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.order_div).IsFixedLength();
        });

        modelBuilder.Entity<ewed_Order_Settle>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_CIDX_ewed_Order_Settle__order_seq");

            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.isdacom)
                .IsFixedLength()
                .HasComment("1일 경우 데이콤 거래");
            entity.Property(e => e.order_div).IsFixedLength();
        });

        modelBuilder.Entity<ewed_RESULT_LIST>(entity =>
        {
            entity.Property(e => e.seq_idx).ValueGeneratedNever();
        });

        modelBuilder.Entity<ewed_SMS>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_SMS__seq");
        });

        modelBuilder.Entity<ewed_SMS_Service>(entity =>
        {
            entity.Property(e => e.isMember).IsFixedLength();
        });

        modelBuilder.Entity<ewed_VISIT_NOTE>(entity =>
        {
            entity.HasKey(e => e.v_seq).HasName("PK_CIDX_ewed_VISIT_NOTE__v_seq");
        });

        modelBuilder.Entity<ewed_Wedding_Attend>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_Wedding_Attend__seq");

            entity.Property(e => e.seq).ValueGeneratedNever();
            entity.Property(e => e.attend_yn).IsFixedLength();
            entity.Property(e => e.senderDiv).IsFixedLength();
        });

        modelBuilder.Entity<ewed_address>(entity =>
        {
            entity.HasKey(e => e.no).IsClustered(false);

            entity.HasIndex(e => new { e.uid, e.name }, "CIDX_UID")
                .IsClustered()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ewed_coupon>(entity =>
        {
            entity.Property(e => e.use_type).IsFixedLength();
            entity.Property(e => e.isUsable).IsFixedLength();
        });

        modelBuilder.Entity<ewed_event_mailing>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_event_mailing__seq");

            entity.Property(e => e.send).IsFixedLength();
        });

        modelBuilder.Entity<ewed_event_question>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_CIDX_ewed_event_question__seq");
        });

        modelBuilder.Entity<ewed_miniCD_INFO>(entity =>
        {
            entity.Property(e => e.CATE_L_CODE).IsFixedLength();
            entity.Property(e => e.CATE_S_CODE).IsFixedLength();
            entity.Property(e => e.attend_use_yn).IsFixedLength();
            entity.Property(e => e.auto_yn).IsFixedLength();
            entity.Property(e => e.card_seq).ValueGeneratedOnAdd();
            entity.Property(e => e.isBest).IsFixedLength();
            entity.Property(e => e.isDisplay).IsFixedLength();
            entity.Property(e => e.isFull).IsFixedLength();
            entity.Property(e => e.isNew).IsFixedLength();
            entity.Property(e => e.miniCD_use_yn).IsFixedLength();
            entity.Property(e => e.swf_type).IsFixedLength();
            entity.Property(e => e.visit_use_yn).IsFixedLength();
            entity.Property(e => e.wd_size).IsFixedLength();
        });

        modelBuilder.Entity<ewed_order_detail_B>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<ewed_order_detail_D>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<ewed_order_detail_P2>(entity =>
        {
            entity.Property(e => e.food).IsFixedLength();
        });

        modelBuilder.Entity<ewed_order_info>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.bj_use).IsFixedLength();
            entity.Property(e => e.isAuto).IsFixedLength();
            entity.Property(e => e.isNew).IsFixedLength();
            entity.Property(e => e.is_bujoo).IsFixedLength();
            entity.Property(e => e.minicd_adm_msg).HasComment("미니CD주문시 관리자 특이사항 기재");
            entity.Property(e => e.order_div).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
            entity.Property(e => e.settle_type).IsFixedLength();
            entity.Property(e => e.shop_card_seq).HasComment("미니CD주문시 e청첩장 주문 카드번호");
            entity.Property(e => e.shop_order_div)
                .IsFixedLength()
                .HasComment("미니CD주문시 e청첩장 주문 카드구문");
            entity.Property(e => e.zipcode).IsFixedLength();
        });

        modelBuilder.Entity<ewed_order_opinion>(entity =>
        {
            entity.Property(e => e.BBS_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.NOTIFY_EMAIL_YESORNO).IsFixedLength();
            entity.Property(e => e.STATUS).IsFixedLength();
        });

        modelBuilder.Entity<ewed_order_weddinfo>(entity =>
        {
            entity.Property(e => e.order_seq).ValueGeneratedNever();
            entity.Property(e => e.linkchk).IsFixedLength();
            entity.Property(e => e.place_data_way).IsFixedLength();
        });

        modelBuilder.Entity<eweddCD>(entity =>
        {
            entity.Property(e => e.ewedd_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<greeting_nvarchar>(entity =>
        {
            entity.Property(e => e.isDP).IsFixedLength();
        });

        modelBuilder.Entity<guestbook_order>(entity =>
        {
            entity.HasKey(e => e.order_seq).HasName("PK_guest_order");
        });

        modelBuilder.Entity<gurim_coupon_event>(entity =>
        {
            entity.Property(e => e.used).IsFixedLength();
        });

        modelBuilder.Entity<hanjin_ErrLog>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("한진택배 오류"));

            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.order_type).IsFixedLength();
        });

        modelBuilder.Entity<history>(entity =>
        {
            entity.HasIndex(e => new { e.YDatetime, e.YType }, "IDX_history_").HasFillFactor(90);
        });

        modelBuilder.Entity<holidays>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("공휴일관리"));

            entity.Property(e => e.YID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<image_order>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이미지_주문"));

            entity.Property(e => e.io_seq).HasComment("이미지_주문_고유번호");
            entity.Property(e => e.io_no).HasComment("이미지_주문_번호");
            entity.Property(e => e.io_pg_seq).HasComment("결제_일련번호");
            entity.Property(e => e.order_email).HasComment("이메일");
            entity.Property(e => e.order_hphone).HasComment("휴대전화");
            entity.Property(e => e.order_name).HasComment("주문자명");
            entity.Property(e => e.order_phone).HasComment("유선전화");
            entity.Property(e => e.order_price).HasComment("주문_금액");
            entity.Property(e => e.order_status).HasComment("주문_상태 (1:주문 2:결제완료 3:결제취소 9:결제실패)");
            entity.Property(e => e.reg_date).HasComment("주문_일시");
            entity.Property(e => e.settle_price).HasComment("결제_금액");
            entity.Property(e => e.uid).HasComment("회원ID");

            entity.HasOne(d => d.io_pg_seqNavigation).WithMany(p => p.image_order).HasConstraintName("FK_image_order_pg_to_image_order");
        });

        modelBuilder.Entity<image_order_admin>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이미지_주문_관리자"));

            entity.Property(e => e.admin_id).HasComment("관리자_ID");
            entity.Property(e => e.admin_name).HasComment("이름");
            entity.Property(e => e.admin_pwd).HasComment("비밀번호");
            entity.Property(e => e.admin_role).HasComment("롤");
        });

        modelBuilder.Entity<image_order_item>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이미지_주문_항목"));

            entity.Property(e => e.io_item_seq).HasComment("항목_고유번호");
            entity.Property(e => e.io_seq).HasComment("이미지_주문_고유번호");
            entity.Property(e => e.item_count).HasComment("주문_수량");
            entity.Property(e => e.item_price).HasComment("주문_금액");
            entity.Property(e => e.item_type).HasComment("주문_항목_구분 (1:고급사진보정 2:스피드보정)");
            entity.Property(e => e.item_unit_price).HasComment("주문_단위_금액");
            entity.Property(e => e.reg_date).HasComment("등록_일시");

            entity.HasOne(d => d.io_seqNavigation).WithMany(p => p.image_order_item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_image_order_to_image_order_item");
        });

        modelBuilder.Entity<image_order_pg>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("이미지_주문_결제"));

            entity.Property(e => e.io_pg_seq).HasComment("결제_일련번호");
            entity.Property(e => e.buyer_name).HasComment("주문자_이름");
            entity.Property(e => e.cancel_date).HasComment("결제_취소일");
            entity.Property(e => e.card_install_month).HasComment("할무_개월");
            entity.Property(e => e.card_noint_yn)
                .IsFixedLength()
                .HasComment("무이자_여부");
            entity.Property(e => e.cash_receipt_yn)
                .IsFixedLength()
                .HasComment("현금영수증_여부");
            entity.Property(e => e.dacom_tid).HasComment("데이콤_거래ID");
            entity.Property(e => e.escrow_yn)
                .IsFixedLength()
                .HasComment("에스크로_여부");
            entity.Property(e => e.finance_authnum).HasComment("결제기관_승인번호");
            entity.Property(e => e.finance_code).HasComment("결제기관_코드");
            entity.Property(e => e.finance_name).HasComment("결제기관_명");
            entity.Property(e => e.io_no).HasComment("이미지_주문_번호");
            entity.Property(e => e.pay_status).HasComment("결제_상태 (1:결제 2:결제취소 9:결제실패)");
            entity.Property(e => e.pay_type).HasComment("결제_유형");
            entity.Property(e => e.pg_request_date).HasComment("결제요청_일시");
            entity.Property(e => e.pg_resp_code).HasComment("결과_코드");
            entity.Property(e => e.pg_resp_msg).HasComment("결과_메세지");
            entity.Property(e => e.pg_result_date).HasComment("결제처리_일시");
            entity.Property(e => e.pg_shopid).HasComment("가맹점_ID");
            entity.Property(e => e.pg_tid).HasComment("PG_거래ID");
            entity.Property(e => e.productinfo).HasComment("주문_상품명");
            entity.Property(e => e.receipt_url).HasComment("영수증 url");
            entity.Property(e => e.reg_date).HasComment("등록_일자");
            entity.Property(e => e.settle_price).HasComment("결제_금액");
        });

        modelBuilder.Entity<inipay_vbank_log>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("inipay 로그"));

            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<interparktour_coupon_event>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("인터파크 쿠폰 이벤트"));
        });

        modelBuilder.Entity<iwedding_Sending>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("제휴사 iwedding 데이터"));

            entity.Property(e => e.order_seq)
                .ValueGeneratedNever()
                .HasComment("아이웨딩에 발송완료 주문정보 넘겨진 주문번호");
        });

        modelBuilder.Entity<jehu_no_coupon_event>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__jehu_no___DDDFBCBE90C075F7");
        });

        modelBuilder.Entity<jehu_send_mms>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("제휴광고 mms 문자발송"));
        });

        modelBuilder.Entity<lgdacom_cas_log>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK_lgdacon_cas_log");
        });

        modelBuilder.Entity<m_count>(entity =>
        {
            entity.Property(e => e.day).IsFixedLength();
        });

        modelBuilder.Entity<manage_code>(entity =>
        {
            entity.HasKey(e => e.code_id).HasName("PK_manage_code_1");

            entity.ToTable(tb => tb.HasComment("공통기준코드값"));

            entity.Property(e => e.code).HasComment("코드");
            entity.Property(e => e.code_type).HasComment("코드타입");
            entity.Property(e => e.code_value).HasComment("코드명");
            entity.Property(e => e.parent_id).HasComment("상위id");
            entity.Property(e => e.use_yorn)
                .IsFixedLength()
                .HasComment("사용여부");
        });

        modelBuilder.Entity<mcard_Admin>(entity =>
        {
            entity.HasKey(e => e.AdminID).HasName("PK_dbo.mcard_Admin");

            entity.Property(e => e.AdminID).HasComment("관리자일련번호");
            entity.Property(e => e.AdminName).HasComment("관리자명");
            entity.Property(e => e.AdminPassword).HasComment("관리자비밀번호");
            entity.Property(e => e.AdminRole).HasComment("관리자역할");
            entity.Property(e => e.AdminUserID).HasComment("관리자ID");
            entity.Property(e => e.RegisterTime).HasComment("등록시간");
        });

        modelBuilder.Entity<mcard_Auth>(entity =>
        {
            entity.HasKey(e => e.AuthID).HasName("PK_dbo.mcard_Auth");

            entity.Property(e => e.MemberYN).IsFixedLength();
        });

        modelBuilder.Entity<mcard_Comment>(entity =>
        {
            entity.HasKey(e => e.CommentID).HasName("PK_dbo.mcard_Comment");

            entity.ToTable(tb => tb.HasComment("방명록"));

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.CommentID).HasComment("방명록일련번호");
            entity.Property(e => e.Commentary).HasComment("내용");
            entity.Property(e => e.GuestName).HasComment("방문객명");
            entity.Property(e => e.InvitationCode).HasComment("초대장코드");
            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");
            entity.Property(e => e.Password).HasComment("비밀번호");
            entity.Property(e => e.RegisterIP).HasComment("등록지IP");
            entity.Property(e => e.RegisterTime).HasComment("등록시간");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_Comment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Comment_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_Gallery>(entity =>
        {
            entity.HasKey(e => e.GalleryID).HasName("PK_dbo.mcard_Gallery");

            entity.ToTable(tb => tb.HasComment("포토갤러리"));

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.GalleryID).HasComment("갤러리일련번호");
            entity.Property(e => e.ImageHeight).HasComment("이미지세로");
            entity.Property(e => e.ImageOrder).HasComment("이미지순서");
            entity.Property(e => e.ImagePath).HasComment("이미지경로");
            entity.Property(e => e.ImageSize).HasComment("이미지용량");
            entity.Property(e => e.ImageWidth).HasComment("이미지가로");
            entity.Property(e => e.InvitationCode).HasComment("초대장코드");
            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");
            entity.Property(e => e.RegisterTime).HasComment("등록시간");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_Gallery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Gallery_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_Gift>(entity =>
        {
            entity.HasKey(e => e.GiftID).HasName("PK_dbo.mcard_Gift");
        });

        modelBuilder.Entity<mcard_Greeting>(entity =>
        {
            entity.HasKey(e => e.GreetingID).HasName("PK_dbo.mcard_Greeting");

            entity.Property(e => e.InvitationType).IsFixedLength();
        });

        modelBuilder.Entity<mcard_Invitation>(entity =>
        {
            entity.HasKey(e => e.InvitationID).HasName("PK_dbo.mcard_Invitation");

            entity.ToTable(tb => tb.HasComment("모바일초대장"));

            entity.HasIndex(e => new { e.InvitationCode, e.DeleteYN }, "IX1_MCARD_INVITATION").HasFillFactor(90);

            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");
            entity.Property(e => e.AdDisplayYN).HasComment("광고배너사용여부");
            entity.Property(e => e.AuthCode).HasComment("인증코드(아이디,이메일)");
            entity.Property(e => e.AuthYN)
                .IsFixedLength()
                .HasComment("인증여부");
            entity.Property(e => e.CommentYN)
                .IsFixedLength()
                .HasComment("방명록사용여부");
            entity.Property(e => e.CompletedTime).HasComment("초대장작성완료시간");
            entity.Property(e => e.DeleteYN)
                .IsFixedLength()
                .HasComment("삭제여부");
            entity.Property(e => e.EtcAfter).HasComment("피로연정보");
            entity.Property(e => e.EtcBus).HasComment("버스정보");
            entity.Property(e => e.EtcCar).HasComment("자가용정보");
            entity.Property(e => e.EtcGuide).HasComment("기타추가정보");
            entity.Property(e => e.EtcInfo).HasComment("기타정보");
            entity.Property(e => e.EtcParking).HasComment("주차정보");
            entity.Property(e => e.EtcSubway).HasComment("지하철정보");
            entity.Property(e => e.EventDate).HasComment("행사일");
            entity.Property(e => e.EventEndTime).HasComment("행사종료시간");
            entity.Property(e => e.EventTime).HasComment("행사시간");
            entity.Property(e => e.ExpireYN)
                .IsFixedLength()
                .HasComment("만료여부");
            entity.Property(e => e.GalleryType)
                .IsFixedLength()
                .HasComment("갤러리종류");
            entity.Property(e => e.GalleryYN)
                .IsFixedLength()
                .HasComment("갤러리사용여부");
            entity.Property(e => e.GiftYN)
                .IsFixedLength()
                .HasComment("선물사용여부");
            entity.Property(e => e.Greeting).HasComment("인사말");
            entity.Property(e => e.GuideYN)
                .IsFixedLength()
                .HasComment("기타정보사용여부");
            entity.Property(e => e.HostYN)
                .IsFixedLength()
                .HasComment("혼주정보사용여부(웨딩)");
            entity.Property(e => e.InvitationCode).HasComment("초대장코드(주문번호)");
            entity.Property(e => e.InvitationTitle).HasComment("초대장제목");
            entity.Property(e => e.InvitationType)
                .IsFixedLength()
                .HasComment("초대장종류");
            entity.Property(e => e.LastModifiedTime).HasComment("마지막수정시간");
            entity.Property(e => e.LocationAddr).HasComment("행사장주소");
            entity.Property(e => e.LocationDetail).HasComment("행사장상세정보");
            entity.Property(e => e.LocationMapImage).HasComment("행사장약도");
            entity.Property(e => e.LocationMapImageHeight).HasComment("행사장약도이미지세로");
            entity.Property(e => e.LocationMapImageSize).HasComment("행사장약도이미지용량");
            entity.Property(e => e.LocationMapImageWidth).HasComment("행사장약도이미지가로");
            entity.Property(e => e.LocationMapLat).HasComment("행사장좌표Lat");
            entity.Property(e => e.LocationMapLng).HasComment("행사장좌표Lng");
            entity.Property(e => e.LocationMapType)
                .IsFixedLength()
                .HasComment("행사장약도종류");
            entity.Property(e => e.LocationName).HasComment("행사장명");
            entity.Property(e => e.LocationTel).HasComment("행사장연락처");
            entity.Property(e => e.MainImage).HasComment("메인(SNS)이미지");
            entity.Property(e => e.MainImageHeight).HasComment("메인이미지세로");
            entity.Property(e => e.MainImageSize).HasComment("메인이미지용량");
            entity.Property(e => e.MainImageWidth).HasComment("메인이미지가로");
            entity.Property(e => e.MoneyGiftYN).HasComment("축의금기능사용여부");
            entity.Property(e => e.OnlineYN)
                .IsFixedLength()
                .HasComment("초대장온라인여부");
            entity.Property(e => e.OrderSeq).HasComment("주문일련번호");
            entity.Property(e => e.OrdererEmail).HasComment("주문자이메일");
            entity.Property(e => e.OrdererMobile).HasComment("주문자연락처");
            entity.Property(e => e.OrdererName).HasComment("주문자명");
            entity.Property(e => e.PublishYN)
                .IsFixedLength()
                .HasComment("초대장퍼블리시여부");
            entity.Property(e => e.RegisterIP).HasComment("등록지IP");
            entity.Property(e => e.RegisterTime).HasComment("등록시간");
            entity.Property(e => e.SiteCode).HasComment("유입사이트코드");
            entity.Property(e => e.SkinCode).HasComment("초대장스킨코드");
            entity.Property(e => e.SkinID).HasComment("스킨일련번호");
            entity.Property(e => e.SmsInvitationYN)
                .IsFixedLength()
                .HasComment("초대장SMS전송여부");
            entity.Property(e => e.SmsMypageYN)
                .IsFixedLength()
                .HasComment("초대장SMS전송여뷰(마이페이지)");
            entity.Property(e => e.VideoType).HasComment("동영상종류");
            entity.Property(e => e.VideoURL).HasComment("동영상주소");
            entity.Property(e => e.VideoYN)
                .IsFixedLength()
                .HasComment("동영상사용여부");

            entity.HasOne(d => d.Skin).WithMany(p => p.mcard_Invitation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Invitation_dbo.Skin_SkinID");
        });

        modelBuilder.Entity<mcard_InvitationBaby>(entity =>
        {
            entity.HasKey(e => e.BabyID).HasName("PK_dbo.mcard_InvitationBaby");

            entity.ToTable(tb => tb.HasComment("돐초대장"));

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.BabyID).HasComment("돌초대장일련번호");
            entity.Property(e => e.BabyBirth).HasComment("아이생일");
            entity.Property(e => e.BabyName).HasComment("아이이름");
            entity.Property(e => e.DadMobile).HasComment("아빠연락처");
            entity.Property(e => e.DadName).HasComment("아빠이름");
            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");
            entity.Property(e => e.MomMobile).HasComment("엄마연락처");
            entity.Property(e => e.MomName).HasComment("엄마이름");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_InvitationBaby)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvitationBaby_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_InvitationGiftRel>(entity =>
        {
            entity.HasKey(e => new { e.InvitationID, e.GiftID }).HasName("PK_dbo.mcard_InvitationGiftRel");

            entity.HasIndex(e => e.GiftID, "IX_GiftID").HasFillFactor(90);

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.SelectYN).IsFixedLength();

            entity.HasOne(d => d.Gift).WithMany(p => p.mcard_InvitationGiftRel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvitationGiftRel_dbo.Gift_GiftID");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_InvitationGiftRel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvitationGiftRel_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_InvitationParty>(entity =>
        {
            entity.HasKey(e => e.PartyID).HasName("PK_dbo.mcard_InvitationParty");

            entity.ToTable(tb => tb.HasComment("모바일초대장 기본정보(문의하기)"));

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.PartyID).HasComment("기타초대장일련번호");
            entity.Property(e => e.GroupMobile).HasComment("주최사(자)담당연락처");
            entity.Property(e => e.GroupName).HasComment("주최사(자)명");
            entity.Property(e => e.GuideName).HasComment("주요정보타이틀명");
            entity.Property(e => e.GuideNote).HasComment("주요정보내용");
            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_InvitationParty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvitationParty_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_InvitationWedding>(entity =>
        {
            entity.HasKey(e => e.WeddingID).HasName("PK_dbo.mcard_InvitationWedding");

            entity.ToTable(tb => tb.HasComment("모바일초대장 신부신랑정보"));

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.WeddingID).HasComment("청첩장일련번호");
            entity.Property(e => e.BrideHostMobile1).HasComment("신부측혼주연락처1");
            entity.Property(e => e.BrideHostMobile2).HasComment("신부측혼주연락처2");
            entity.Property(e => e.BrideHostName1).HasComment("신부측혼주이름1");
            entity.Property(e => e.BrideHostName2).HasComment("신부측혼주이름2");
            entity.Property(e => e.BrideHostRel1).HasComment("신부측혼주관계1");
            entity.Property(e => e.BrideHostRel2).HasComment("신부측혼주관계2");
            entity.Property(e => e.BrideMobile).HasComment("신부연락처");
            entity.Property(e => e.BrideName).HasComment("신부이름");
            entity.Property(e => e.GroomHostMobile1).HasComment("신랑측혼주연락처1");
            entity.Property(e => e.GroomHostMobile2).HasComment("신랑측혼주연락처2");
            entity.Property(e => e.GroomHostName1).HasComment("신랑측혼주이름1");
            entity.Property(e => e.GroomHostName2).HasComment("신랑측혼주이름2");
            entity.Property(e => e.GroomHostRel1).HasComment("신랑측혼주관계1");
            entity.Property(e => e.GroomHostRel2).HasComment("신랑측혼주관계2");
            entity.Property(e => e.GroomMobile).HasComment("신랑연락처");
            entity.Property(e => e.GroomName).HasComment("신랑이름");
            entity.Property(e => e.InvitationID).HasComment("초대장일련번호");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_InvitationWedding)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvitationWedding_dbo.Invitation_InvitationID");
        });

        modelBuilder.Entity<mcard_Invitation_log>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<mcard_LogInvitation>(entity =>
        {
            entity.HasKey(e => e.LogID).HasName("PK_dbo.mcard_LogInvitation");

            entity.Property(e => e.LogID).ValueGeneratedNever();
        });

        modelBuilder.Entity<mcard_Skin>(entity =>
        {
            entity.HasKey(e => e.SkinID).HasName("PK_dbo.mcard_Skin");

            entity.ToTable(tb => tb.HasComment("모바일 스킨정보"));

            entity.Property(e => e.SkinID).HasComment("스킨일련번호");
            entity.Property(e => e.DateENKR)
                .IsFixedLength()
                .HasComment("날짜언어");
            entity.Property(e => e.DateSeparater)
                .IsFixedLength()
                .HasComment("날짜구분자");
            entity.Property(e => e.InvitationType)
                .IsFixedLength()
                .HasComment("초대장종류");
            entity.Property(e => e.MainImageYN)
                .IsFixedLength()
                .HasComment("메인이미지사용여부");
            entity.Property(e => e.MainRatioH).HasComment("스킨비율세로");
            entity.Property(e => e.MainRatioW).HasComment("스킨비율가로");
            entity.Property(e => e.SkinCode).HasComment("스킨코드");
            entity.Property(e => e.SkinNameEN).HasComment("스킨명(영어)");
            entity.Property(e => e.SkinNameKR).HasComment("스킨명(한글)");
            entity.Property(e => e.SkinPath).HasComment("스킨경로");
        });

        modelBuilder.Entity<mcard_TmpInvitation>(entity =>
        {
            entity.HasKey(e => e.InvitationID).HasName("PK_dbo.mcard_TmpInvitation");

            entity.HasIndex(e => e.SkinID, "IX_SkinID").HasFillFactor(90);

            entity.Property(e => e.AuthYN).IsFixedLength();
            entity.Property(e => e.CommentYN).IsFixedLength();
            entity.Property(e => e.ExpireYN).IsFixedLength();
            entity.Property(e => e.GalleryType).IsFixedLength();
            entity.Property(e => e.GalleryYN).IsFixedLength();
            entity.Property(e => e.GiftYN).IsFixedLength();
            entity.Property(e => e.GuideYN).IsFixedLength();
            entity.Property(e => e.HostYN).IsFixedLength();
            entity.Property(e => e.InvitationType).IsFixedLength();
            entity.Property(e => e.LocationMapType).IsFixedLength();
            entity.Property(e => e.OnlineYN).IsFixedLength();
            entity.Property(e => e.PublishYN).IsFixedLength();
            entity.Property(e => e.SmsInvitationYN).IsFixedLength();
            entity.Property(e => e.SmsMypageYN).IsFixedLength();
            entity.Property(e => e.VideoYN).IsFixedLength();

            entity.HasOne(d => d.Skin).WithMany(p => p.mcard_TmpInvitation).HasConstraintName("FK_dbo.TmpInvitation_dbo.Skin_SkinID");
        });

        modelBuilder.Entity<mcard_TmpInvitationGiftRel>(entity =>
        {
            entity.HasKey(e => new { e.InvitationID, e.GiftID }).HasName("PK_dbo.mcard_TmpInvitationGiftRel");

            entity.HasIndex(e => e.GiftID, "IX_GiftID").HasFillFactor(90);

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.Property(e => e.SelectYN).IsFixedLength();

            entity.HasOne(d => d.Gift).WithMany(p => p.mcard_TmpInvitationGiftRel).HasConstraintName("FK_dbo.TmpInvitationGiftRel_dbo.Gift_GiftID");

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_TmpInvitationGiftRel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TmpInvitationGiftRel_dbo.TmpInvitation_InvitationID");
        });

        modelBuilder.Entity<mcard_TmpInvitationOption>(entity =>
        {
            entity.HasKey(e => e.OptionID).HasName("PK_dbo.mcard_TmpInvitationOption");

            entity.HasIndex(e => e.InvitationID, "IX_InvitationID").HasFillFactor(90);

            entity.HasOne(d => d.Invitation).WithMany(p => p.mcard_TmpInvitationOption)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TmpInvitationOption_dbo.TmpInvitation_InvitationID");
        });

        modelBuilder.Entity<oneclick_sample>(entity =>
        {
            entity.HasKey(e => e.oc_Sample_Seq).HasName("PK__oneclick__16A02C3ACD0DA562");

            entity.ToTable(tb => tb.HasComment("원클릭샘플이벤트"));

            entity.Property(e => e.Use_YN).HasComment("사용여부");
            entity.Property(e => e.evt_nm).HasComment("샘플그룹명");
        });

        modelBuilder.Entity<ordList_new>(entity =>
        {
            entity.ToView("ordList_new");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<orderLst>(entity =>
        {
            entity.ToView("orderLst");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<orderLst_20080922>(entity =>
        {
            entity.ToView("orderLst_20080922");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<orderLst_new>(entity =>
        {
            entity.ToView("orderLst_new");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isColorInpaper).IsFixedLength();
            entity.Property(e => e.isColorPrint).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isEmbo).IsFixedLength();
            entity.Property(e => e.isHanji).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<orderLst_test>(entity =>
        {
            entity.ToView("orderLst_test");

            entity.Property(e => e.Expr1).IsFixedLength();
            entity.Property(e => e.isBaesongRisk).IsFixedLength();
            entity.Property(e => e.isChoanRisk).IsFixedLength();
            entity.Property(e => e.isCompose).IsFixedLength();
            entity.Property(e => e.isCorel).IsFixedLength();
            entity.Property(e => e.isRibon).IsFixedLength();
            entity.Property(e => e.isSpecial).IsFixedLength();
            entity.Property(e => e.ishandmade).IsFixedLength();
            entity.Property(e => e.isinpaper).IsFixedLength();
            entity.Property(e => e.map_trans_method).IsFixedLength();
            entity.Property(e => e.order_add_flag).IsFixedLength();
            entity.Property(e => e.order_add_type).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
            entity.Property(e => e.pay_Type).IsFixedLength();
            entity.Property(e => e.sales_Gubun).IsFixedLength();
            entity.Property(e => e.site_gubun).IsFixedLength();
        });

        modelBuilder.Entity<photobook_myCouponList>(entity =>
        {
            entity.ToView("photobook_myCouponList");

            entity.Property(e => e.Isthrowaway).IsFixedLength();
            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.site_code).IsFixedLength();
            entity.Property(e => e.use_yn).IsFixedLength();
        });

        modelBuilder.Entity<photobook_order_detailV>(entity =>
        {
            entity.ToView("photobook_order_detailV");

            entity.Property(e => e.cover_style).IsFixedLength();
            entity.Property(e => e.item_option).IsFixedLength();
            entity.Property(e => e.makecom_code).IsFixedLength();
        });

        modelBuilder.Entity<photobook_order_detail_erp>(entity =>
        {
            entity.ToView("photobook_order_detail_erp");
        });

        modelBuilder.Entity<photobook_prod_price>(entity =>
        {
            entity.ToView("photobook_prod_price");

            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.makecom_code).IsFixedLength();
        });

        modelBuilder.Entity<preView_ChkList>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("초안 체크리스트"));

            entity.Property(e => e.isCard).IsFixedLength();
            entity.Property(e => e.order_type).IsFixedLength();
        });

        modelBuilder.Entity<recycle_agree_log>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__recycle___DDDFBCBE17EAA7B8");
        });

        modelBuilder.Entity<research_log>(entity =>
        {
            entity.Property(e => e.ans1).IsFixedLength();
            entity.Property(e => e.ans2).IsFixedLength();
            entity.Property(e => e.ans3).IsFixedLength();
            entity.Property(e => e.ans3_1).IsFixedLength();
            entity.Property(e => e.ans4).IsFixedLength();
            entity.Property(e => e.ans5).IsFixedLength();
            entity.Property(e => e.ans5_1).IsFixedLength();
            entity.Property(e => e.ans6).IsFixedLength();
        });

        modelBuilder.Entity<s2_event_UserComment_url>(entity =>
        {
            entity.HasKey(e => e.c_idx).HasName("PK__s2_event__0656B781A22EAF3C");
        });

        modelBuilder.Entity<s4_CardBest100>(entity =>
        {
            entity.HasKey(e => new { e.Card_seq, e.Company_seq }).HasName("PK__s4_CardB__80D3BA1A047F6C3B");

            entity.Property(e => e.Gubun01).IsFixedLength();
            entity.Property(e => e.Gubun02).IsFixedLength();
            entity.Property(e => e.Gubun03).IsFixedLength();
            entity.Property(e => e.Gubun04).IsFixedLength();
            entity.Property(e => e.Gubun05).IsFixedLength();
            entity.Property(e => e.Gubun06).IsFixedLength();
            entity.Property(e => e.Gubun07).IsFixedLength();
        });

        modelBuilder.Entity<sb_samplebook_item>(entity =>
        {
            entity.HasKey(e => e.seq).HasName("PK__sb_sampl__DDDFBCBE2D0C8B54");
        });

        modelBuilder.Entity<shakr_coupon_event>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("쉐이커 쿠폰 이벤트"));
        });

        modelBuilder.Entity<super7day_sms>(entity =>
        {
            entity.Property(e => e.idx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tCouponMst>(entity =>
        {
            entity.HasKey(e => e.CouponCD).HasName("pk_tCouponMst");

            entity.ToTable(tb => tb.HasComment("(old) 더카드 쿠폰"));

            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ApplyType).HasComment("쿠폰적용여부 ( ONLY : 한상품만, MULTI : 제한없음 )");
            entity.Property(e => e.Cd).IsFixedLength();
            entity.Property(e => e.DeliveryOverSaleYN)
                .IsFixedLength()
                .HasComment("배송비쿠폰설정 - 다른쿠폰과 중복사용 가능한가..");
            entity.Property(e => e.DeliveryYN)
                .IsFixedLength()
                .HasComment("배송비 지원쿠폰 여부");
            entity.Property(e => e.EmpYN).IsFixedLength();
            entity.Property(e => e.IssueDayCnt).HasComment("발급일기준 몇일까지인가..");
            entity.Property(e => e.IssueYN)
                .IsFixedLength()
                .HasComment("발급일기준");
            entity.Property(e => e.LimitAmtChkYN).IsFixedLength();
            entity.Property(e => e.LimitSaleItemCD)
                .IsFixedLength()
                .HasComment("지정상품설정");
            entity.Property(e => e.LimitSaleItemCnt).HasComment("지정상품 몇개이상 구매시 이용가능한지..");
            entity.Property(e => e.LimitSaleItemYN)
                .IsFixedLength()
                .HasComment("지정상품 사용여부");
            entity.Property(e => e.LimitSalePrice).HasComment("판매단가 ~ 이상일경우 사용가능");
            entity.Property(e => e.LimitSalePriceUseYN)
                .IsFixedLength()
                .HasComment("판매단가 제한여부");
            entity.Property(e => e.MobileOnlyYN).IsFixedLength();
            entity.Property(e => e.MultiUseYN).IsFixedLength();
            entity.Property(e => e.SalePriceViewYN).IsFixedLength();
            entity.Property(e => e.TermBrandUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정브랜드");
            entity.Property(e => e.TermCategoryUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정카테고리지정");
            entity.Property(e => e.TermEventUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정이벤트지정");
            entity.Property(e => e.TermItemUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정상품지정");
            entity.Property(e => e.TermMargin).HasComment("기준마진율");
            entity.Property(e => e.TermMarginUseYN)
                .IsFixedLength()
                .HasComment("조건설정_마진율");
            entity.Property(e => e.TermType)
                .IsFixedLength()
                .HasComment("대상품목 자동등록 여부 ( A : 자동, M : 수동 )");
            entity.Property(e => e.TermVndUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정업체지정");
            entity.Property(e => e.UseTarget).IsFixedLength();
            entity.Property(e => e.partnerYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponMst_SmartAD>(entity =>
        {
            entity.HasKey(e => e.CouponCD).HasName("pk_tCouponMst_SmartAD");

            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ApplyType).HasComment("쿠폰적용여부 ( ONLY : 한상품만, MULTI : 제한없음 )");
            entity.Property(e => e.Cd).IsFixedLength();
            entity.Property(e => e.DeliveryOverSaleYN)
                .IsFixedLength()
                .HasComment("배송비쿠폰설정 - 다른쿠폰과 중복사용 가능한가..");
            entity.Property(e => e.DeliveryYN)
                .IsFixedLength()
                .HasComment("배송비 지원쿠폰 여부");
            entity.Property(e => e.EmpYN).IsFixedLength();
            entity.Property(e => e.IssueDayCnt).HasComment("발급일기준 몇일까지인가..");
            entity.Property(e => e.IssueYN)
                .IsFixedLength()
                .HasComment("발급일기준");
            entity.Property(e => e.LimitAmtChkYN).IsFixedLength();
            entity.Property(e => e.LimitSaleItemCD)
                .IsFixedLength()
                .HasComment("지정상품설정");
            entity.Property(e => e.LimitSaleItemCnt).HasComment("지정상품 몇개이상 구매시 이용가능한지..");
            entity.Property(e => e.LimitSaleItemYN)
                .IsFixedLength()
                .HasComment("지정상품 사용여부");
            entity.Property(e => e.LimitSalePrice).HasComment("판매단가 ~ 이상일경우 사용가능");
            entity.Property(e => e.LimitSalePriceUseYN)
                .IsFixedLength()
                .HasComment("판매단가 제한여부");
            entity.Property(e => e.MobileOnlyYN).IsFixedLength();
            entity.Property(e => e.MultiUseYN).IsFixedLength();
            entity.Property(e => e.SalePriceViewYN).IsFixedLength();
            entity.Property(e => e.TermBrandUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정브랜드");
            entity.Property(e => e.TermCategoryUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정카테고리지정");
            entity.Property(e => e.TermEventUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정이벤트지정");
            entity.Property(e => e.TermItemUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정상품지정");
            entity.Property(e => e.TermMargin).HasComment("기준마진율");
            entity.Property(e => e.TermMarginUseYN)
                .IsFixedLength()
                .HasComment("조건설정_마진율");
            entity.Property(e => e.TermType)
                .IsFixedLength()
                .HasComment("대상품목 자동등록 여부 ( A : 자동, M : 수동 )");
            entity.Property(e => e.TermVndUseYN)
                .IsFixedLength()
                .HasComment("조건설정_특정업체지정");
            entity.Property(e => e.UseTarget).IsFixedLength();
            entity.Property(e => e.partnerYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponOff>(entity =>
        {
            entity.HasKey(e => new { e.CouponCD, e.OffCD }).HasName("pk_tCouponOff");

            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.OffCD).IsFixedLength();
            entity.Property(e => e.CouponNum).IsFixedLength();
            entity.Property(e => e.PrintYN).IsFixedLength();
            entity.Property(e => e.TakeYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponSub>(entity =>
        {
            entity.HasKey(e => new { e.CouponCD, e.CouponNum }).HasName("PK_tCouponSub_1");

            entity.HasIndex(e => e.UserID, "NCI_TCOUPONSUB_USERID").HasFillFactor(90);

            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.TakeYN).IsFixedLength();
            entity.Property(e => e.TimeCD).IsFixedLength();
            entity.Property(e => e.UseYN).IsFixedLength();
            entity.Property(e => e.sendMailYN).IsFixedLength();
            entity.Property(e => e.userDelYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponSub1>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.TakeYN).IsFixedLength();
            entity.Property(e => e.TimeCD).IsFixedLength();
            entity.Property(e => e.UseYN).IsFixedLength();
            entity.Property(e => e.sendMailYN).IsFixedLength();
            entity.Property(e => e.userDelYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponSub_SmartAD>(entity =>
        {
            entity.HasKey(e => new { e.CouponCD, e.CouponNum }).HasName("PK_tCouponSub_SmartAD_1");

            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.TakeYN).IsFixedLength();
            entity.Property(e => e.TimeCD).IsFixedLength();
            entity.Property(e => e.UseYN).IsFixedLength();
            entity.Property(e => e.sendMailYN).IsFixedLength();
            entity.Property(e => e.userDelYN).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTarget>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTermBrand>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ProcType).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTermCategory>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.CatLCD).IsFixedLength();
            entity.Property(e => e.CatMCD).IsFixedLength();
            entity.Property(e => e.CatSCD).IsFixedLength();
            entity.Property(e => e.CatVCD).IsFixedLength();
            entity.Property(e => e.Idx).ValueGeneratedOnAdd();
            entity.Property(e => e.ProcType).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTermEvent>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ProcType).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTermItem>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ItemCD).IsFixedLength();
            entity.Property(e => e.ProcType).IsFixedLength();
        });

        modelBuilder.Entity<tCouponTermVnd>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.VndCD).IsFixedLength();
            entity.Property(e => e.ProcType).IsFixedLength();
        });

        modelBuilder.Entity<tCouponUseItem>(entity =>
        {
            entity.Property(e => e.CouponCD).IsFixedLength();
            entity.Property(e => e.ItemCD).IsFixedLength();
        });

        modelBuilder.Entity<tEvent>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("더카드이벤트 관리"));

            entity.Property(e => e.CatLCD).IsFixedLength();
            entity.Property(e => e.FSEventYN).IsFixedLength();
            entity.Property(e => e.ItemCD).IsFixedLength();
            entity.Property(e => e.NaviYN)
                .IsFixedLength()
                .HasComment("Y:내부 네비게이션 사용, N:내부 네비게이션 미사용");
            entity.Property(e => e.PageWidth)
                .IsFixedLength()
                .HasComment("");
            entity.Property(e => e.SnsYN).IsFixedLength();
            entity.Property(e => e.TitleBarType)
                .IsFixedLength()
                .HasComment("P:타이틀 Bar 형식 일반형식, N:타이틀 Bar 형식 네비형식");
            entity.Property(e => e.ViewYN).IsFixedLength();
            entity.Property(e => e.projectYN)
                .IsFixedLength()
                .HasComment("기본노출 Y:사용, N:미사용");
            entity.Property(e => e.templateYN).IsFixedLength();
        });

        modelBuilder.Entity<tEventBotItem>(entity =>
        {
            entity.Property(e => e.BotItemCD).IsFixedLength();
            entity.Property(e => e.BotItemIdx).ValueGeneratedOnAdd();
            entity.Property(e => e.BotSize).IsFixedLength();
        });

        modelBuilder.Entity<tEventBotTemplete>(entity =>
        {
            entity.HasKey(e => e.BotIdx).HasName("PK_tEventBotTempleteNew");

            entity.Property(e => e.BotType).IsFixedLength();
            entity.Property(e => e.addBtnYN).IsFixedLength();
        });

        modelBuilder.Entity<tEventRelationBanner>(entity =>
        {
            entity.Property(e => e.PartnerYN).IsFixedLength();
            entity.Property(e => e.UseYN).IsFixedLength();
        });

        modelBuilder.Entity<tJobCode>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("직업코드"));

            entity.Property(e => e.code).IsFixedLength();
        });

        modelBuilder.Entity<tMember_secede>(entity =>
        {
            entity.Property(e => e.ms_idx).ValueGeneratedOnAdd();
            entity.Property(e => e.ms_reason).IsFixedLength();
        });

        modelBuilder.Entity<tNeo_Queue>(entity =>
        {
            entity.HasKey(e => e.mid).HasName("PK_CIDX_tNeo_Queue__mid");

            entity.ToTable(tb => tb.HasComment("메일발송리스토리"));

            entity.HasIndex(e => e.org_date, "IDX_tNEO_Queue__org_date")
                .IsDescending()
                .HasFillFactor(90);

            entity.Property(e => e.c_category).IsFixedLength();
            entity.Property(e => e.c_site).IsFixedLength();
            entity.Property(e => e.cardno).IsFixedLength();
            entity.Property(e => e.isSend).IsFixedLength();
            entity.Property(e => e.msave).IsFixedLength();
            entity.Property(e => e.mstatus).IsFixedLength();
            entity.Property(e => e.mtype).IsFixedLength();
        });

        modelBuilder.Entity<tUserInfo>(entity =>
        {
            entity.HasKey(e => e.uid).IsClustered(false);

            entity.HasIndex(e => e.mail, "IDX_mail").HasFillFactor(90);

            entity.HasIndex(e => e.name, "nind_name").HasFillFactor(90);

            entity.HasIndex(e => e.jumin, "tUserInfo_Index_1")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.addressCHK).IsFixedLength();
            entity.Property(e => e.chk_ad).IsFixedLength();
            entity.Property(e => e.chk_event).IsFixedLength();
            entity.Property(e => e.chk_mailservice).IsFixedLength();
            entity.Property(e => e.chk_penpal).IsFixedLength();
            entity.Property(e => e.is_marriage).IsFixedLength();
            entity.Property(e => e.job).IsFixedLength();
            entity.Property(e => e.phoneCHK).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.site_div).IsFixedLength();
            entity.Property(e => e.zip1).IsFixedLength();
            entity.Property(e => e.zip2).IsFixedLength();
        });

        modelBuilder.Entity<t_card>(entity =>
        {
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tj_test>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedNever();
        });

        modelBuilder.Entity<toss_vaccount>(entity =>
        {
            entity.Property(e => e.order_type)
                .IsFixedLength()
                .HasComment("주문구분 (W:청첩장 S:샘플 E:부가상품)");
            entity.Property(e => e.order_seq).HasComment("주문번호(주문 구분별)");
            entity.Property(e => e.toss_orderid).HasComment("주문번호 (각 주문테이블의 pg_tid)");
            entity.Property(e => e.bank_name).HasComment("은행명");
            entity.Property(e => e.due_date).HasComment("입금만료일");
            entity.Property(e => e.reg_date).HasComment("등록일시");
            entity.Property(e => e.settle_price).HasComment("입금 예정금액");
            entity.Property(e => e.status).HasComment("로그 구분 (1:입급대기 2:입금완료 3:입금실패 4:입금취소)");
            entity.Property(e => e.toss_secret).HasComment("거래 검증키");
            entity.Property(e => e.vacct_name).HasComment("예금주");
            entity.Property(e => e.vacct_number).HasComment("계좌번호");
            entity.Property(e => e.vacct_seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<toss_vaccount_log>(entity =>
        {
            entity.Property(e => e.log_seq).HasComment("고유번호");
            entity.Property(e => e.barun_msg).HasComment("내부 처리 결과");
            entity.Property(e => e.reg_date).HasComment("로그 등록일시");
            entity.Property(e => e.toss_created_date).HasComment("webhook 생성일시");
            entity.Property(e => e.toss_orderid).HasComment("주문번호 (각 주문테이블의 pg_tid)");
            entity.Property(e => e.toss_secret).HasComment("거래 검증키");
            entity.Property(e => e.toss_status).HasComment("toss 거래 상태값");
            entity.Property(e => e.toss_trankey).HasComment("toss 거래키");
        });

        modelBuilder.Entity<vCardWeight>(entity =>
        {
            entity.ToView("vCardWeight");
        });

        modelBuilder.Entity<vPB_PROD>(entity =>
        {
            entity.ToView("vPB_PROD");
        });

        modelBuilder.Entity<view_Bestseller>(entity =>
        {
            entity.ToView("view_Bestseller");

            entity.Property(e => e.disrate_type).IsFixedLength();
            entity.Property(e => e.gubun).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
        });

        modelBuilder.Entity<view_Comment>(entity =>
        {
            entity.ToView("view_Comment");

            entity.Property(e => e.card_cate).IsFixedLength();
        });

        modelBuilder.Entity<view_CopyItem>(entity =>
        {
            entity.ToView("view_CopyItem");

            entity.Property(e => e.item_type).IsFixedLength();
            entity.Property(e => e.plc_code).IsFixedLength();
        });

        modelBuilder.Entity<view_DeliveryLst>(entity =>
        {
            entity.ToView("view_DeliveryLst");
        });

        modelBuilder.Entity<view_OB_Card>(entity =>
        {
            entity.ToView("view_OB_Card");

            entity.Property(e => e.B2B_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.BEST_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.CARD_CATE).IsFixedLength();
            entity.Property(e => e.CARD_FPrint).IsFixedLength();
            entity.Property(e => e.DISPLAY_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.DISRATE_TYPE).IsFixedLength();
            entity.Property(e => e.ISHAVE).IsFixedLength();
            entity.Property(e => e.ISInPaper).IsFixedLength();
            entity.Property(e => e.Is100).IsFixedLength();
            entity.Property(e => e.Is1001).IsFixedLength();
            entity.Property(e => e.Is1002).IsFixedLength();
            entity.Property(e => e.Is1003).IsFixedLength();
            entity.Property(e => e.Is1004).IsFixedLength();
            entity.Property(e => e.Is1005).IsFixedLength();
            entity.Property(e => e.Is1009).IsFixedLength();
            entity.Property(e => e.Is200).IsFixedLength();
            entity.Property(e => e.Is300).IsFixedLength();
            entity.Property(e => e.Is400).IsFixedLength();
            entity.Property(e => e.Is500).IsFixedLength();
            entity.Property(e => e.IsEmbo).IsFixedLength();
            entity.Property(e => e.IsEnvInsert).IsFixedLength();
            entity.Property(e => e.IsFPrint).IsFixedLength();
            entity.Property(e => e.IsFlower).IsFixedLength();
            entity.Property(e => e.IsGold).IsFixedLength();
            entity.Property(e => e.IsHandMade).IsFixedLength();
            entity.Property(e => e.IsHanji).IsFixedLength();
            entity.Property(e => e.IsHeart).IsFixedLength();
            entity.Property(e => e.IsOBDisplay).IsFixedLength();
            entity.Property(e => e.IsOffBest).IsFixedLength();
            entity.Property(e => e.IsOffDDisplay).IsFixedLength();
            entity.Property(e => e.IsOffDisplay).IsFixedLength();
            entity.Property(e => e.IsOsiGaro).IsFixedLength();
            entity.Property(e => e.IsRibon).IsFixedLength();
            entity.Property(e => e.IsSBaesong).IsFixedLength();
            entity.Property(e => e.IsSample).IsFixedLength();
            entity.Property(e => e.IsSilk).IsFixedLength();
            entity.Property(e => e.IsUsrComment).IsFixedLength();
            entity.Property(e => e.IsUsrimg1).IsFixedLength();
            entity.Property(e => e.IsUsrimg2).IsFixedLength();
            entity.Property(e => e.IsUsrimg3).IsFixedLength();
            entity.Property(e => e.IsWonang).IsFixedLength();
            entity.Property(e => e.IsYu).IsFixedLength();
            entity.Property(e => e.NEW_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.RECOMEND_YES_OR_NO).IsFixedLength();
            entity.Property(e => e.online_yes_or_no).IsFixedLength();
        });

        modelBuilder.Entity<view_OB_Company>(entity =>
        {
            entity.ToView("view_OB_Company");

            entity.Property(e => e.COMPANY_SEQ).ValueGeneratedOnAdd();
            entity.Property(e => e.ERP_Dept).IsFixedLength();
            entity.Property(e => e.ERP_PGcheck).IsFixedLength();
            entity.Property(e => e.ERP_PriceLevel).IsFixedLength();
            entity.Property(e => e.ERP_TaxType).IsFixedLength();
            entity.Property(e => e.JUMUN_TYPE).IsFixedLength();
            entity.Property(e => e.ONOFF).IsFixedLength();
            entity.Property(e => e.SALES_GUBUN).IsFixedLength();
            entity.Property(e => e.SASIK_GUBUN).IsFixedLength();
        });

        modelBuilder.Entity<view_OB_Order>(entity =>
        {
            entity.ToView("view_OB_Order");

            entity.Property(e => e.isReceipt).IsFixedLength();
            entity.Property(e => e.item_type).IsFixedLength();
            entity.Property(e => e.posflag).IsFixedLength();
            entity.Property(e => e.settle_method).IsFixedLength();
        });

        modelBuilder.Entity<view_S4EventInstall>(entity =>
        {
            entity.ToView("view_S4EventInstall");

            entity.Property(e => e.desktop_install).IsFixedLength();
            entity.Property(e => e.favorite_install).IsFixedLength();
            entity.Property(e => e.isSelection).IsFixedLength();
            entity.Property(e => e.isUsed).IsFixedLength();
        });

        modelBuilder.Entity<view_SampleList>(entity =>
        {
            entity.ToView("view_SampleList");

            entity.Property(e => e.MEMBER_ZIP).IsFixedLength();
        });

        modelBuilder.Entity<view_UsrInfo>(entity =>
        {
            entity.ToView("view_UsrInfo");
        });

        modelBuilder.Entity<view_UsrQnA>(entity =>
        {
            entity.ToView("view_UsrQnA");

            entity.Property(e => e.a_research1).IsFixedLength();
            entity.Property(e => e.a_research2).IsFixedLength();
            entity.Property(e => e.a_research_date).IsFixedLength();
        });

        modelBuilder.Entity<view_UsrQnA_for_Excel>(entity =>
        {
            entity.ToView("view_UsrQnA_for_Excel");

            entity.Property(e => e.a_research1).IsFixedLength();
            entity.Property(e => e.a_research2).IsFixedLength();
            entity.Property(e => e.a_research_date).IsFixedLength();
        });

        modelBuilder.Entity<view_cardRank>(entity =>
        {
            entity.ToView("view_cardRank");
        });

        modelBuilder.Entity<view_emBoard>(entity =>
        {
            entity.ToView("view_emBoard");
        });

        modelBuilder.Entity<wed_Notice>(entity =>
        {
            entity.Property(e => e.auth)
                .IsFixedLength()
                .HasComment("0:전체,1:부분");
            entity.Property(e => e.div).IsFixedLength();
            entity.Property(e => e.sales_gubun).IsFixedLength();
            entity.Property(e => e.seq).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<wedd_biztalk>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__wedd_biz__3214EC27F5567D6C");

            entity.ToTable(tb => tb.HasComment("비즈톡 템플릿"));
        });

        modelBuilder.Entity<weddinghall_information>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("웨딩홀 소개"));

            entity.Property(e => e.wedd_idx).ValueGeneratedNever();
        });

        modelBuilder.Entity<weddinghall_tmp>(entity =>
        {
            entity.Property(e => e.status).IsFixedLength();
        });

        modelBuilder.Entity<zip_busan>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-부산"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_ch_buk>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-충청북도"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_ch_nam>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-충전남도"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_daegu>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-대구"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_daejeon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-대전"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_gangwon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-강원"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_gwangju>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-광주"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_gyeonggi>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-경기도"));

            entity.HasIndex(e => new { e.gungu, e.sigungu_build_name }, "build_name").HasFillFactor(90);

            entity.HasIndex(e => new { e.gungu, e.b_name }, "dong").HasFillFactor(90);

            entity.HasIndex(e => new { e.gungu, e.b_name, e.jibun_no }, "dong_jibun").HasFillFactor(90);

            entity.HasIndex(e => e.gungu, "sigungu").HasFillFactor(90);

            entity.HasIndex(e => new { e.gungu, e.street_name }, "street_name").HasFillFactor(90);

            entity.HasIndex(e => new { e.gungu, e.street_name, e.build_no }, "street_name_build_no").HasFillFactor(90);

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_incheon>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-인천광역시"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_jeju>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-제주"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_junbuk>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-전라북도"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_junnam>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-전라남도"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_ks_buk>(entity =>
        {
            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_ks_nam>(entity =>
        {
            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_sejong>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-세종"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_seoul>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-서울"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zip_ulsan>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("주소-울산"));

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zipcode>(entity =>
        {
            entity.HasIndex(e => e.juso, "IDX_juso").HasFillFactor(90);
        });

        modelBuilder.Entity<zipcode_new>(entity =>
        {
            entity.HasIndex(e => e.juso, "IX_zipcode").HasFillFactor(90);
        });

        modelBuilder.Entity<zipcode_street>(entity =>
        {
            entity.HasIndex(e => e.b_name, "IDX_b_name").HasFillFactor(90);

            entity.HasIndex(e => e.b_name_merge, "IDX_b_name_merge").HasFillFactor(90);

            entity.HasIndex(e => e.b_ri, "IDX_b_ri").HasFillFactor(90);

            entity.HasIndex(e => e.build_no, "IDX_build_no").HasFillFactor(90);

            entity.HasIndex(e => e.build_sub_no, "IDX_build_sub_no").HasFillFactor(90);

            entity.HasIndex(e => e.gungu, "IDX_gungu").HasFillFactor(90);

            entity.HasIndex(e => e.jibun_no, "IDX_jibun_no").HasFillFactor(90);

            entity.HasIndex(e => e.jibun_sub_no, "IDX_jibun_sub_no").HasFillFactor(90);

            entity.HasIndex(e => new { e.street_name, e.build_no, e.sigungu_build_name, e.b_name }, "IDX_search1").HasFillFactor(90);

            entity.HasIndex(e => e.sido, "IDX_sido").HasFillFactor(90);

            entity.HasIndex(e => e.sigungu_build_name, "IDX_sigungu_build_name").HasFillFactor(90);

            entity.HasIndex(e => e.street_name, "IDX_street_name").HasFillFactor(90);

            entity.HasIndex(e => e.zipcode, "IDX_zipcode").HasFillFactor(90);

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<zipcode_street_N>(entity =>
        {
            entity.HasIndex(e => e.b_name, "IDX_b_name").HasFillFactor(90);

            entity.HasIndex(e => e.b_name_merge, "IDX_b_name_merge").HasFillFactor(90);

            entity.HasIndex(e => e.b_ri, "IDX_b_ri").HasFillFactor(90);

            entity.HasIndex(e => e.build_no, "IDX_build_no").HasFillFactor(90);

            entity.HasIndex(e => e.build_sub_no, "IDX_build_sub_no").HasFillFactor(90);

            entity.HasIndex(e => e.gungu, "IDX_gungu").HasFillFactor(90);

            entity.HasIndex(e => e.jibun_no, "IDX_jibun_no").HasFillFactor(90);

            entity.HasIndex(e => e.jibun_sub_no, "IDX_jibun_sub_no").HasFillFactor(90);

            entity.HasIndex(e => new { e.street_name, e.build_no, e.sigungu_build_name, e.b_name }, "IDX_search1").HasFillFactor(90);

            entity.HasIndex(e => e.sido, "IDX_sido").HasFillFactor(90);

            entity.HasIndex(e => e.sigungu_build_name, "IDX_sigungu_build_name").HasFillFactor(90);

            entity.HasIndex(e => e.street_name, "IDX_street_name").HasFillFactor(90);

            entity.HasIndex(e => e.zipcode, "IDX_zipcode").HasFillFactor(90);

            entity.Property(e => e.b_san).IsFixedLength();
            entity.Property(e => e.under_street).IsFixedLength();
        });

        modelBuilder.Entity<Custom_Order_Review_Count>(entity =>
        {
            entity.HasKey(e => new { e.CompaySeq, e.CardSeq, e.SumDate });
        });

        modelBuilder.HasSequence<int>("EtcOrderSeq").StartsAt(3222000L);
        modelBuilder.HasSequence<int>("OrderSeq").StartsAt(4309000L);
        modelBuilder.HasSequence<int>("SampleOrderSeq").StartsAt(2170000L);
        modelBuilder.HasSequence<int>("TestSeqByOrderSeq").StartsAt(4500000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

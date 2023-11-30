using System;
using System.Collections.Generic;
using Barunson.DbContext.DbModels.MoSvr;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext;

public partial class MoSvrContext : Microsoft.EntityFrameworkCore.DbContext
{
    public MoSvrContext(DbContextOptions<MoSvrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SDK_FMS_RECEIVE> SDK_FMS_RECEIVE { get; set; }

    public virtual DbSet<SDK_FMS_REPORT> SDK_FMS_REPORT { get; set; }

    public virtual DbSet<SDK_FMS_REPORT_DETAIL> SDK_FMS_REPORT_DETAIL { get; set; }

    public virtual DbSet<SDK_FMS_SEND> SDK_FMS_SEND { get; set; }

    public virtual DbSet<SDK_MMS_REPORT> SDK_MMS_REPORT { get; set; }

    public virtual DbSet<SDK_MMS_REPORT_DETAIL> SDK_MMS_REPORT_DETAIL { get; set; }

    public virtual DbSet<SDK_MMS_SEND> SDK_MMS_SEND { get; set; }

    public virtual DbSet<SDK_RECV_STAT> SDK_RECV_STAT { get; set; }

    public virtual DbSet<SDK_SEND_STAT> SDK_SEND_STAT { get; set; }

    public virtual DbSet<SDK_SMS_RECEIVE> SDK_SMS_RECEIVE { get; set; }

    public virtual DbSet<SDK_SMS_REPORT> SDK_SMS_REPORT { get; set; }

    public virtual DbSet<SDK_SMS_REPORT_DETAIL> SDK_SMS_REPORT_DETAIL { get; set; }

    public virtual DbSet<SDK_SMS_SEND> SDK_SMS_SEND { get; set; }

    public virtual DbSet<SDK_VMS_REPORT> SDK_VMS_REPORT { get; set; }

    public virtual DbSet<SDK_VMS_REPORT_DETAIL> SDK_VMS_REPORT_DETAIL { get; set; }

    public virtual DbSet<SDK_VMS_SEND> SDK_VMS_SEND { get; set; }

    public virtual DbSet<T_CODE> T_CODE { get; set; }

    public virtual DbSet<T_DUP_MSG> T_DUP_MSG { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_01> T_LMS_HIST_SD_01 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_02> T_LMS_HIST_SD_02 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_03> T_LMS_HIST_SD_03 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_04> T_LMS_HIST_SD_04 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_05> T_LMS_HIST_SD_05 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_06> T_LMS_HIST_SD_06 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_07> T_LMS_HIST_SD_07 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_08> T_LMS_HIST_SD_08 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_09> T_LMS_HIST_SD_09 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_10> T_LMS_HIST_SD_10 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_11> T_LMS_HIST_SD_11 { get; set; }

    public virtual DbSet<T_LMS_HIST_SD_12> T_LMS_HIST_SD_12 { get; set; }

    public virtual DbSet<T_LMS_SD> T_LMS_SD { get; set; }

    public virtual DbSet<T_MMS_HIST_RV> T_MMS_HIST_RV { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_01> T_MMS_HIST_RV_01 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_02> T_MMS_HIST_RV_02 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_03> T_MMS_HIST_RV_03 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_04> T_MMS_HIST_RV_04 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_05> T_MMS_HIST_RV_05 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_06> T_MMS_HIST_RV_06 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_07> T_MMS_HIST_RV_07 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_08> T_MMS_HIST_RV_08 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_09> T_MMS_HIST_RV_09 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_10> T_MMS_HIST_RV_10 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_11> T_MMS_HIST_RV_11 { get; set; }

    public virtual DbSet<T_MMS_HIST_RV_12> T_MMS_HIST_RV_12 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_01> T_MMS_HIST_SD_01 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_02> T_MMS_HIST_SD_02 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_03> T_MMS_HIST_SD_03 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_04> T_MMS_HIST_SD_04 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_05> T_MMS_HIST_SD_05 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_06> T_MMS_HIST_SD_06 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_07> T_MMS_HIST_SD_07 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_08> T_MMS_HIST_SD_08 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_09> T_MMS_HIST_SD_09 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_10> T_MMS_HIST_SD_10 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_11> T_MMS_HIST_SD_11 { get; set; }

    public virtual DbSet<T_MMS_HIST_SD_12> T_MMS_HIST_SD_12 { get; set; }

    public virtual DbSet<T_MMS_SD> T_MMS_SD { get; set; }

    public virtual DbSet<T_MSG_STAT_DAY> T_MSG_STAT_DAY { get; set; }

    public virtual DbSet<T_MSG_STAT_HOUR> T_MSG_STAT_HOUR { get; set; }

    public virtual DbSet<T_MSG_STAT_MONTH> T_MSG_STAT_MONTH { get; set; }

    public virtual DbSet<T_SMS_HIST_RV> T_SMS_HIST_RV { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_01> T_SMS_HIST_RV_01 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_02> T_SMS_HIST_RV_02 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_03> T_SMS_HIST_RV_03 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_04> T_SMS_HIST_RV_04 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_05> T_SMS_HIST_RV_05 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_06> T_SMS_HIST_RV_06 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_07> T_SMS_HIST_RV_07 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_08> T_SMS_HIST_RV_08 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_09> T_SMS_HIST_RV_09 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_10> T_SMS_HIST_RV_10 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_11> T_SMS_HIST_RV_11 { get; set; }

    public virtual DbSet<T_SMS_HIST_RV_12> T_SMS_HIST_RV_12 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_01> T_SMS_HIST_SD_01 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_02> T_SMS_HIST_SD_02 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_03> T_SMS_HIST_SD_03 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_04> T_SMS_HIST_SD_04 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_05> T_SMS_HIST_SD_05 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_06> T_SMS_HIST_SD_06 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_07> T_SMS_HIST_SD_07 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_08> T_SMS_HIST_SD_08 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_09> T_SMS_HIST_SD_09 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_10> T_SMS_HIST_SD_10 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_11> T_SMS_HIST_SD_11 { get; set; }

    public virtual DbSet<T_SMS_HIST_SD_12> T_SMS_HIST_SD_12 { get; set; }

    public virtual DbSet<T_SMS_SD> T_SMS_SD { get; set; }

    public virtual DbSet<T_SPAM_NO> T_SPAM_NO { get; set; }

    public virtual DbSet<T_USER_INFO> T_USER_INFO { get; set; }

    public virtual DbSet<V_LMS_HIST_SD> V_LMS_HIST_SD { get; set; }

    public virtual DbSet<V_MMS_HIST_RV> V_MMS_HIST_RV { get; set; }

    public virtual DbSet<V_MMS_HIST_SD> V_MMS_HIST_SD { get; set; }

    public virtual DbSet<V_SMS_HIST_RV> V_SMS_HIST_RV { get; set; }

    public virtual DbSet<V_SMS_HIST_SD> V_SMS_HIST_SD { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SDK_FMS_RECEIVE>(entity =>
        {
            entity.HasKey(e => e.JOB_ID).HasName("PK__SDK_FMS___2AC9D60A6D4E34A2");

            entity.Property(e => e.JOB_ID).ValueGeneratedNever();
            entity.Property(e => e.MSG_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SDK_FMS_REPORT>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_FMS___825DA51C90B26988");

            entity.Property(e => e.MSG_ID).ValueGeneratedNever();
            entity.Property(e => e.MSG_SUBTYPE).HasDefaultValueSql("((20))");
        });

        modelBuilder.Entity<SDK_FMS_REPORT_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.MSG_ID, e.SUBJOB_ID }).HasName("PK__SDK_FMS___843CA10421EE5EC8");
        });

        modelBuilder.Entity<SDK_FMS_SEND>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_FMS___825DA51C442ED890");

            entity.Property(e => e.MSG_SUBTYPE).HasDefaultValueSql("((20))");
        });

        modelBuilder.Entity<SDK_MMS_REPORT>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_MMS___825DA51C1192B0E4");

            entity.Property(e => e.MSG_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<SDK_MMS_REPORT_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.MSG_ID, e.SUBJOB_ID }).HasName("PK__SDK_MMS___843CA104251D000C");
        });

        modelBuilder.Entity<SDK_MMS_SEND>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_MMS___825DA51C5B44FCDD");
        });

        modelBuilder.Entity<SDK_RECV_STAT>(entity =>
        {
            entity.HasKey(e => new { e.RECV_YEAR, e.RECV_MONTH, e.RECV_DAY, e.RECV_HOUR }).HasName("PK__SDK_RECV__4C611A0D19967FB1");

            entity.Property(e => e.RECV_YEAR).IsFixedLength();
            entity.Property(e => e.RECV_MONTH).IsFixedLength();
            entity.Property(e => e.RECV_DAY).IsFixedLength();
            entity.Property(e => e.RECV_HOUR).IsFixedLength();
        });

        modelBuilder.Entity<SDK_SEND_STAT>(entity =>
        {
            entity.HasKey(e => new { e.SEND_YEAR, e.SEND_MONTH, e.SEND_DAY, e.SEND_HOUR, e.USER_ID }).HasName("PK__SDK_SEND__123567E7229EE99F");

            entity.Property(e => e.SEND_YEAR).IsFixedLength();
            entity.Property(e => e.SEND_MONTH).IsFixedLength();
            entity.Property(e => e.SEND_DAY).IsFixedLength();
            entity.Property(e => e.SEND_HOUR).IsFixedLength();
        });

        modelBuilder.Entity<SDK_SMS_RECEIVE>(entity =>
        {
            entity.HasKey(e => e.JOB_ID).HasName("PK__SDK_SMS___2AC9D60A73601395");

            entity.Property(e => e.JOB_ID).ValueGeneratedNever();
            entity.Property(e => e.MSG_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SDK_SMS_REPORT>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_SMS___825DA51CE2AF71C6");

            entity.Property(e => e.MSG_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<SDK_SMS_REPORT_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.MSG_ID, e.SUBJOB_ID }).HasName("PK__SDK_SMS___843CA10482DCEE9A");
        });

        modelBuilder.Entity<SDK_SMS_SEND>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_SMS___825DA51C29D675D1");
        });

        modelBuilder.Entity<SDK_VMS_REPORT>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_VMS___825DA51CFE5CE955");

            entity.Property(e => e.MSG_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<SDK_VMS_REPORT_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.MSG_ID, e.SUBJOB_ID }).HasName("PK__SDK_VMS___843CA1048ABE9C92");
        });

        modelBuilder.Entity<SDK_VMS_SEND>(entity =>
        {
            entity.HasKey(e => e.MSG_ID).HasName("PK__SDK_VMS___825DA51CBDAEFEEC");
        });

        modelBuilder.Entity<T_CODE>(entity =>
        {
            entity.Property(e => e.CODE_GROUP).IsFixedLength();
            entity.Property(e => e.DELETE_YN).IsFixedLength();
        });

        modelBuilder.Entity<T_LMS_HIST_SD_01>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_01_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_02>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_02_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_03>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_03_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_04>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_04_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_05>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_05_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_06>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_06_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_07>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_07_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_08>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_08_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_09>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_09_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_10>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_10_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_11>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_11_PK");
        });

        modelBuilder.Entity<T_LMS_HIST_SD_12>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TLmsHistSd_12_PK");
        });

        modelBuilder.Entity<T_LMS_SD>(entity =>
        {
            entity.HasKey(e => e.MSG_KEY).HasName("TLmsSd_PK");

            entity.Property(e => e.ORDER_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_RESULT).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_STS).HasDefaultValueSql("((-1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
            entity.Property(e => e.TR_SECT).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv");

            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_01>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_01");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_01_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_02>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_02");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_02_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_03>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_03");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_03_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_04>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_04");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_04_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_05>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_05");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_05_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_06>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_06");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_06_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_07>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_07");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_07_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_08>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_08");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_08_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_09>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_09");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_09_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_10>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_10");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_10_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_11>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_11");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_11_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_RV_12>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistRv_12");

            entity.ToTable(tb => tb.HasTrigger("TR_T_MMS_HIST_RV_12_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_01>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_01_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_02>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_02_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_03>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_03_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_04>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_04_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_05>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_05_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_06>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_06_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_07>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_07_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_08>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_08_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_09>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_09_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_10>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_10_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_11>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_11_PK");
        });

        modelBuilder.Entity<T_MMS_HIST_SD_12>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TMmsHistSd_12_PK");
        });

        modelBuilder.Entity<T_MMS_SD>(entity =>
        {
            entity.HasKey(e => e.MSG_KEY).HasName("TMmsSd_PK");

            entity.Property(e => e.ORDER_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_RESULT).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_STS).HasDefaultValueSql("((-1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
            entity.Property(e => e.TR_SECT).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_MSG_STAT_DAY>(entity =>
        {
            entity.HasKey(e => new { e.RAISE_DATE, e.MSG_TYPE, e.SERVICE_CODE, e.DIRECTION, e.SR_SECT }).HasName("TMsgStatDay_PK");
        });

        modelBuilder.Entity<T_MSG_STAT_HOUR>(entity =>
        {
            entity.HasKey(e => new { e.RAISE_DATE, e.MSG_TYPE, e.SERVICE_CODE, e.DIRECTION, e.SR_SECT }).HasName("TMsgStatHour_PK");
        });

        modelBuilder.Entity<T_MSG_STAT_MONTH>(entity =>
        {
            entity.HasKey(e => new { e.RAISE_DATE, e.MSG_TYPE, e.SERVICE_CODE, e.DIRECTION, e.SR_SECT }).HasName("TMsgStatMonth_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_RV>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv");

            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_01>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_01");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_01_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_02>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_02");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_02_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_03>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_03");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_03_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_04>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_04");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_04_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_05>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_05");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_05_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_06>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_06");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_06_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_07>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_07");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_07_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_08>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_08");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_08_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_09>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_09");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_09_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_10>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_10");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_10_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_11>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_11");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_11_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_RV_12>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistRv_12");

            entity.ToTable(tb => tb.HasTrigger("TR_T_SMS_HIST_RV_12_INSERT"));

            entity.Property(e => e.MSG_KEY).ValueGeneratedOnAdd();
            entity.Property(e => e.MSG_TYPE).HasDefaultValueSql("((0))");
            entity.Property(e => e.READ_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.RV_SECT).HasDefaultValueSql("((1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_01>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_01_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_02>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_02_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_03>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_03_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_04>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_04_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_05>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_05_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_06>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_06_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_07>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_07_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_08>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_08_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_09>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_09_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_10>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_10_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_11>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_11_PK");
        });

        modelBuilder.Entity<T_SMS_HIST_SD_12>(entity =>
        {
            entity.HasKey(e => new { e.MSG_KEY, e.IN_TIME }).HasName("TSmsHistSd_12_PK");
        });

        modelBuilder.Entity<T_SMS_SD>(entity =>
        {
            entity.HasKey(e => e.MSG_KEY).HasName("TSmsSd_PK");

            entity.Property(e => e.ORDER_FLAG).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_RESULT).HasDefaultValueSql("((0))");
            entity.Property(e => e.PROC_STS).HasDefaultValueSql("((-1))");
            entity.Property(e => e.SERVICE_CODE).HasDefaultValueSql("((0))");
            entity.Property(e => e.TR_SECT).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<T_SPAM_NO>(entity =>
        {
            entity.HasKey(e => new { e.MSG_TYPE, e.NO_KIND, e.PHONE_NO }).HasName("TSpamNo_PK");
        });

        modelBuilder.Entity<T_USER_INFO>(entity =>
        {
            entity.HasKey(e => e.USER_ID).HasName("TUserInfo_PK");

            entity.Property(e => e.LOGIN_STS).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<V_LMS_HIST_SD>(entity =>
        {
            entity.ToView("V_LMS_HIST_SD");
        });

        modelBuilder.Entity<V_MMS_HIST_RV>(entity =>
        {
            entity.ToView("V_MMS_HIST_RV");
        });

        modelBuilder.Entity<V_MMS_HIST_SD>(entity =>
        {
            entity.ToView("V_MMS_HIST_SD");
        });

        modelBuilder.Entity<V_SMS_HIST_RV>(entity =>
        {
            entity.ToView("V_SMS_HIST_RV");
        });

        modelBuilder.Entity<V_SMS_HIST_SD>(entity =>
        {
            entity.ToView("V_SMS_HIST_SD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

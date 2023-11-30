using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("ConnInfo", "file_dt", Name = "nci_MEMPLUS_DAILY_INFO_ConnInfo_file_dt")]
public partial class MEMPLUS_DAILY_INFO
{
    [Key]
    public int seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? file_dt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? regdate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code4 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code6 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code7 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? type_code8 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ConnInfo { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }
}

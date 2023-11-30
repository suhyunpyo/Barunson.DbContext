using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class guestbook_order
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string item_name1 { get; set; } = null!;

    public int item_count1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? up_img1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? up_file1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_status { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? order_memo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? request_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? print_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? print_commit_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? request_admin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? item_name2 { get; set; }

    public int? item_count2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? item_name3 { get; set; }

    public int? item_count3 { get; set; }
}

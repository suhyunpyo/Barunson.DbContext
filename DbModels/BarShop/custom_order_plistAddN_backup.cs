using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("pid", Name = "IX_custom_order_plistAddN_backup_pid")]
public partial class custom_order_plistAddN_backup
{
    public int pid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? groom_father_header { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? groom_father_fname { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? groom_father { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? groom_father_tail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? groom_mother_header { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? groom_mother_fname { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? groom_mother { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? groom_mother_tail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? groom_rank { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? groom_fname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? groom_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? groom_tail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? bride_father_header { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? bride_father_fname { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? bride_father { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? bride_father_tail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? bride_mother_header { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? bride_mother_fname { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? bride_mother { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? bride_mother_tail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? bride_rank { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? bride_fname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? bride_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? bride_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isgroom_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isbride_tail { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? invite_name { get; set; }
}

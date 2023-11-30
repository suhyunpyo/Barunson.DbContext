using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Order_Photo
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string order_div { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? photo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_book6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? book_ment6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_tmp1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_tmp2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo_tmp3 { get; set; }
}

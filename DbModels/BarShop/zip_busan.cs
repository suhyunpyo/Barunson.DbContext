using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 주소-부산
/// </summary>
[Keyless]
public partial class zip_busan
{
    [StringLength(6)]
    public string? zipcode { get; set; }

    [StringLength(3)]
    public string? seq { get; set; }

    [StringLength(30)]
    public string? sido { get; set; }

    [StringLength(30)]
    public string? e_sido { get; set; }

    [StringLength(30)]
    public string? gungu { get; set; }

    [StringLength(50)]
    public string? e_gungu { get; set; }

    [StringLength(30)]
    public string? myoun { get; set; }

    [StringLength(50)]
    public string? e_myoun { get; set; }

    [StringLength(14)]
    public string? street_code { get; set; }

    [StringLength(50)]
    public string? street_name { get; set; }

    [StringLength(100)]
    public string? e_street_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? under_street { get; set; }

    public int? build_no { get; set; }

    public int? build_sub_no { get; set; }

    [StringLength(50)]
    public string? build_mng_no { get; set; }

    [StringLength(50)]
    public string? delivery_name { get; set; }

    [StringLength(50)]
    public string? sigungu_build_name { get; set; }

    [StringLength(10)]
    public string? b_code { get; set; }

    [StringLength(20)]
    public string? b_name { get; set; }

    [StringLength(20)]
    public string? b_ri { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? b_san { get; set; }

    public int? jibun_no { get; set; }

    [StringLength(6)]
    public string? dong_no { get; set; }

    public int? jibun_sub_no { get; set; }

    [StringLength(200)]
    public string? street_name_merge { get; set; }

    [StringLength(200)]
    public string? b_name_merge { get; set; }
}

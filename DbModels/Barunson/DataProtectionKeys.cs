using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

public partial class DataProtectionKeys
{
    [Key]
    public int Id { get; set; }

    public string? FriendlyName { get; set; }

    public string? Xml { get; set; }
}

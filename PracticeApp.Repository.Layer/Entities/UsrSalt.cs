using System;
using System.Collections.Generic;

namespace PracticeApp.Entity.Layer.Entities;

public partial class UsrSalt
{
    public Guid SaltId { get; set; }

    public string? SaltKey { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}

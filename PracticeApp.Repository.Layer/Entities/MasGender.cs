using System;
using System.Collections.Generic;

namespace PracticeApp.Entity.Layer.Entities;

public partial class MasGender
{
    public Guid GenderId { get; set; }

    public string Name { get; set; } = null!;
    public int UniqueSeqNo { get; set; }
    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual AdminUser CreatedByNavigation { get; set; } = null!;

    public virtual AdminUser? UpdatedByNavigation { get; set; }
}

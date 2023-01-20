using System;
using System.Collections.Generic;

namespace PracticeApp.Entity.Layer.Entities;

public partial class UsrProfile
{
    public Guid UserId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual AdminUser CreatedByNavigation { get; set; } = null!;

    public virtual AdminUser? UpdatedByNavigation { get; set; }
}

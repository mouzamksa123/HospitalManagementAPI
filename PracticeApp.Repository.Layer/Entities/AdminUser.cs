using System;
using System.Collections.Generic;

namespace PracticeApp.Entity.Layer.Entities;

public partial class AdminUser
{
    public Guid AdminUserId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<MasGender> MasGenderCreatedByNavigations { get; } = new List<MasGender>();

    public virtual ICollection<MasGender> MasGenderUpdatedByNavigations { get; } = new List<MasGender>();

    public virtual ICollection<UsrProfile> UsrProfileCreatedByNavigations { get; } = new List<UsrProfile>();

    public virtual ICollection<UsrProfile> UsrProfileUpdatedByNavigations { get; } = new List<UsrProfile>();
}

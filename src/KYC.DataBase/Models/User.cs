using KYC.DataBase.Models.Types;

namespace KYC.DataBase.Models;

public class User
{
    public Status Status { get; set; }
    public string RecordId { get; set; } = null!;
    public string? RefId { get; set; }
    public int? SubmitCount { get; set; }
    public string? BlockPassID { get; set; }
    public bool? IsArchived { get; set; }
    public string? InreviewDate { get; set; }
    public string? WaitingDate { get; set; }
    public string? ApprovedDate { get; set; }
}
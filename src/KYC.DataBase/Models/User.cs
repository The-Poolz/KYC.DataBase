namespace KYC.DataBase.Models;

public class User
{
    public string Guid { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string ClientId { get; set; } = null!;
    public string RecordId { get; set; } = null!;
    public string? RefId { get; set; }
    public int? SubmitCount { get; set; }
    public string? BlockPassID { get; set; }
    public bool? IsArchived { get; set; }
    public string? InreviewDate { get; set; }
    public string? WaitingDate { get; set; }
    public string? ApprovedDate { get; set; }
}
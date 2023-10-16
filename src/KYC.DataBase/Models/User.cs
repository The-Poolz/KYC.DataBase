namespace KYC.DataBase.Models;

public class User
{
    public string Status { get; set; } = null!;
    public string RecordId { get; set; } = null!;
    public int? SubmitCount { get; set; }
    public string? BlockPassID { get; set; }
    public bool? IsArchived { get; set; }
    public string? InreviewDate { get; set; }
    public string? WaitingDate { get; set; }
    public string? ApprovedDate { get; set; }
}
namespace UniversalPrivilegeTax.Core.Models
{
    public class TaxSubmission
    {
        public Guid Id { get; set; }
        public string TaxpayerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"
    }
}

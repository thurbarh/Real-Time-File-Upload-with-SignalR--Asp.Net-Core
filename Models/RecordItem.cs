namespace FileUpload.Models
{
    public class RecordItem
    {
        public string Company { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string StrAmount
        {
            get
            {
                return Amount.ToString("#,##0.00;(#,##0.00)");

            }
        }
    }
}

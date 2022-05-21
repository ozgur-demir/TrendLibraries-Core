namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Eposta { get; set; }
        public int Yas { get; set; }
        public string FullInfo { get; set; }
        public string FullInfoManual { get; set; }

        public string CreditCardNumber { get; set; }
        public DateTime CreditCardValidDate { get; set; }
    }
}

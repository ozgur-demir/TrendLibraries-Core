namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public IList<Address> Addresses { get; set; }
        public Gender Gender { get; set; }

        public string GetFullInfo() //AutoMapper will take after "Get" word then match with DTO. Current Json:[{"id": 1,"isim": "Özd","eposta": "ldasld","yas": 24,"fullInfo": "Özd-ldasld-24"}]
        {
            return $"{Name}-{Email}-{Age}";
        }
        public string FullInfoManual() //manual define
        {
            return $"{Name}-{Email}-{Age}";
        }
    }
}

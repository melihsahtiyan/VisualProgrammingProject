using Core.Domain.Abstract;

namespace Core.Domain.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string TaxNumber { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
    }
}
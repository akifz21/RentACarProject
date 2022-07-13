using Core.Entities;

namespace Entitites.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }

    }   
}

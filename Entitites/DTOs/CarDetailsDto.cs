using Core.Entities;

namespace Entitites.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ImagePath { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }

    }   
}

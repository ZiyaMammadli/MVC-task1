using MvcTask1.Models;

namespace MvcTask1.ViewModels
{
    public class HomeViewModels
    {
       public List<Service> Services { get; set; }    
        public List<Testimonial> Testimonials { get; set;}
        public List<Portfolio> Portfolios { get; set; } 
        public List<Team> Teams { get; set; }
    }
}

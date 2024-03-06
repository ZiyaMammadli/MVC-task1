using Microsoft.AspNetCore.Mvc;
using MvcTask1.Models;
using MvcTask1.ViewModels;

namespace MvcTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> Services = new List<Service>();
            Service srvc1 = new Service()
            {
                Icon="bi bi-activity",
                Title="Urek nebzi",
                Description="Sehifenin nebzine bax",
                Url= "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext="go to website"
            };
            Service srvc2 = new Service()
            {
                Icon = "bi bi-broadcast",
                Title = "Telkommunikasiya",
                Description = "Sistemler arasi elaqe",
                Url = "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext = "go to website"
            };
            Service srvc3 = new Service()
            {
                Icon = "bi bi-easel",
                Title = "Lovhe",
                Description = "senin ucun onemli olan elave qeydler apar",
                Url = "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext = "go to website"
            };
            Service srvc4 = new Service()
            {
                Icon = "bi bi-bounding-box-circles",
                Title = "Sistem arxitekturasi",
                Description = "Bu arxitekturaya sende qosul",
                Url = "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext = "go to website"
            };
            Service srvc5 = new Service()
            {
                Icon = "bi bi-calendar4-week",
                Title = "Kalendar",
                Description = "Her hadiseden vaxtinda xeber tut",
                Url = "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext = "go to website"
            };
            Service srvc6 = new Service()
            {
                Icon = "bi bi-chat-square-text",
                Title = "Comment",
                Description = "Serbest sekilde oz fikirlerini bildir ",
                Url = "https://translate.google.com/?sl=en&tl=az&op=translate",
                Urltext = "go to website"
            };
            Services.Add(srvc1);
            Services.Add(srvc2);
            Services.Add(srvc3);
            Services.Add(srvc4);   
            Services.Add(srvc5);
            Services.Add(srvc6);

            List<Testimonial> testimonials = new List<Testimonial>()
            {
                new Testimonial
                {
                    
                    PersonName="Elman Qasimov",
                    PersonPosition="Web development",
                    PersonImage="https://t3.ftcdn.net/jpg/02/43/12/34/360_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg",
                    PersonIcon1="bi bi-quote quote-icon-left",
                    PersonIcon2="bi bi-star-fill",
                    PersonDescription="10 illik is tecrubesine malikdir"
                },
                new Testimonial
                {
                   
                    PersonName="Seyyub Selimov",
                    PersonPosition="Enginer",
                    PersonImage="https://upload.wikimedia.org/wikipedia/commons/a/a0/Pierre-Person.jpg",
                    PersonIcon1="bi bi-quote quote-icon-left",
                    PersonIcon2="bi bi-star-fill",
                    PersonDescription="Isinin esl pesekaridir"
                },
                new Testimonial
                {
                    
                    PersonName="Nermin Quliyeva",
                    PersonPosition="Musiqici",
                    PersonImage="https://engineering.unl.edu/images/staff/Kayla-Person.jpg",
                    PersonIcon1="bi bi-quote quote-icon-left",
                    PersonIcon2="bi bi-star-fill",
                    PersonDescription="Musiqini derinden hiss edir ve eletdirir sesi mukemmeldir"
                },
                new Testimonial
                {
                   
                    PersonName="Ziya Memmedli",
                    PersonPosition="Lider",
                    PersonImage="https://akm-img-a-in.tosshub.com/indiatoday/images/story/media_bank/202309/elon-musk-252648408-16x9.jpg?VersionId=9KYZpqpoY3WvH8eVZg54mmkpTGfvPCWj&size=690:388",
                    PersonIcon1="bi bi-quote quote-icon-left",
                    PersonIcon2="bi bi-star-fill",
                    PersonDescription="Eziyyet cek behresin gor"
                }

            };
            ViewData["Testimonials"] = "Emekdaslarimiz";
            ViewData["Testimonials2"] = "Her  biri yuksek standartlara ve keyfiyyetlere malikdir";
            

            List<Portfolio> portfolios = new List<Portfolio>()
            {
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/61jVZeCAjCL._AC_SX679_.jpg",
                    title="Amazfit GTS 2e Smart Watch",
                    description="EXTENDED BATTERY LIFE: With deeply optimized system battery management, the smartwatch enables 14-day battery life for typical usage and 24-day battery life for basic usage, always ready to escort you on your journeys without worrying about charging."

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/71t-9BTIg9L._AC_SY879_.jpg",
                    title="LEVOIT Air Purifier",
                    description="A 45W long-life high-torque motor, a versatile 8.7\" x 8.7\" x 14.2\" size, a 7.48 lb weight, a 141CFM CADR and up to 1095 ft² of purification area for original filter. Levoit Original Filter is HEPA-grade while operating in Sleep Mode, as tested by an independent lab"

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/71dD4ZZPiaL._AC_SX679_.jpg",
                    title="DEWALT 20V MAX Impact Driver",
                    description="BRUSHLESS MOTOR delivers 1,825 in-lbs of torque and 3,400 RPM to drive large diameter screws"

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/91SZVWfPjdL._AC_SX679_.jpg",
                    title="SAMSUNG 27\" CF39 Series",
                    description="IMMERSIVE VIEWING EXPERIENCE: The 1800R curvature of the screen lets you enjoy big, bold and stunning panoramic views while you work or play at home or the office"

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/71O0Is7QpeL._AC_SX679_.jpg",
                    title="Keurig K-Express Coffee Maker",
                    description="STRONG BREW: Increases the strength and bold taste of your coffee’s flavor.3 CUP SIZES: Brew an 8, 10, or 12 oz. cup at the push of a button."

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/41NqnEJDnVL._SX300_SY300_QL70_FMwebp_.jpg",
                    title="Waterpik Cordless Pearl ",
                    description="RECHARGEABLE CORDLESS WATER FLOSSER: Waterpik Cordless Pearl will help you maintain healthier gums and brighter teeth whether you are at home or on the go. It features a rechargeable battery and handheld portable design."

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/71b2Xt12OTL._SX522_.jpg",
                    title="EUHOMY Commercial Ice Maker Machine",
                    description="Euhomy ICE MAKER- Say goodbye to ice shortage worries with Euhomy's commercial ice maker! It produces 99 lbs of ice per day, stores 33 lbs, and prevents overflow. Portable and suitable for household and commercial use, this ice maker is perfect for home, indoor/outdoor kitchens, restaurants, bars, hotels, and grocery stores. Upgrade your ice game with Euhomy's ice maker!"

                },
                new Portfolio
                {
                    image="https://m.media-amazon.com/images/I/61g8GuhbeuL._AC_SX679_.jpg",
                    title="Smart Stages Scooter",
                    description="Pretend scooter musical ride-on toy with realistic design, turn-key clicker, and motion-activated learning songs, sounds and phrases"

                }
            };
           
            ViewData["HeadDesc"] = "Bunlarda sirketmizin hazirladigi mehsullardir";

            List<Team> teams = new List<Team>()
            {
                new Team
                {
                    PersonImage="https://www.washingtonpost.com/wp-apps/imrs.php?src=https://arc-anglerfish-washpost-prod-washpost.s3.amazonaws.com/public/U6PMNLLFATSSOZAODKKJN2RH4U.jpg&w=750&h=495",
                    PersonName="Jozef Makler",
                    PersonPosition="CEO"
                },
                new Team
                {
                    PersonImage="https://www.dmarge.com/wp-content/uploads/2021/01/dwayne-the-rock-.jpg",
                    PersonName="Escobar Danielle",
                    PersonPosition="CEO komekcisi"
                },
                new Team
                {
                    PersonImage="https://w7.pngwing.com/pngs/419/675/png-transparent-happy-person-hand-photography-people.png",
                    PersonName="Tom Blossom",
                    PersonPosition="SMM"
                },
                new Team
                {
                    PersonImage="https://www.pngarts.com/files/3/Happy-Men-PNG-Image-with-Transparent-Background.png",
                    PersonName="Jerry Salbador",
                    PersonPosition="Menecer"
                },
            };
            ViewData["headDesc"] = "Sirketimizin idare heyeti";
            HomeViewModels homeViewModels = new HomeViewModels()
            {
                Services = Services,
                Testimonials = testimonials,
                Portfolios = portfolios,
                Teams = teams
            };
            return View(homeViewModels);
        }
    }
}

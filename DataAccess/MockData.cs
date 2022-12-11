using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class SeedDataExtensions
    {
        public static void SeedCars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car[]
            {
                new Car()
                {
                    Id = 1,
                    Model = "F8 Spider",
                    ColorId = (int)Colors.Yellow,
                    StoKMh = 2.1,
                    Price = 450,
                    Description = "The F8 Spider’s greatest achievement is the fact that it unleashes its power instantaneously with zero turbo lag, whilst retaining this V8’s unique and very special soundtrack.",
                    ImagePath = @"https://i.wpimg.pl/1920x0/m.autokult.pl/ferrari-f8-spider-4-be8031ebb9c0.jpg"
                },

                new Car()
                {
                    Id = 2,
                    Model = "Ferrari Portofino M",
                    ColorId = (int)Colors.Silver,
                    StoKMh = 3.45,
                    Price = 420,
                    Description = "The Ferrari Portofino M’s engine belongs to the V8 turbo family voted “International Engine of the Year” on four consecutive occasions. The power unit can punch out 620 cv, 20 more than the Ferrari Portofino, thanks to new cam profiles and the introduction of a new speed sensor on the turbocharger assembly to measure the turbine revolutions. A new Gasoline Particulate Filter allows the car to comply with the strictest European anti-pollution standards (Euro-6D) without compromising driving pleasure.",
                    ImagePath = @"https://ocdn.eu/images/pulscms/MTE7MDA_/a4ee38a1d3741562afa4faa20746f704.jpg"
                },

                new Car()
                {
                    Id = 3,
                    Model = "FERRARI 812 COMPETIZIONE",
                    ColorId = (int)Colors.SpaceGray,
                    StoKMh = 2.9,
                    Price = 430,
                    Description = "To maintain the traditional, incredibly high standard of engine sound whilst simultaneously introducing a GPF (Gasoline Particulate Filter), a new exhaust tailpipe was added. This design solution reinstates medium-high frequency sound. In order to deliver excellent acoustics, performance and aesthetics, the exhaust tailpipes are visible to underscore their function and the car’s track-inspired character. The addition of a second pair of resonators enhances the engine’s more noble combustion order harmonics, creating the perfect melding of the sound from the exhaust and from the intake system.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2021/05/Ferrari-812-Competizione.jpg"
                },

                new Car()
                {
                    Id = 4,
                    Model = "Ferrari 812 GTS",
                    ColorId = (int)Colors.SpaceGray,
                    StoKMh = 3,
                    Price = 480,
                    Description = "Exactly 50 years on from the debut of the last spider in the Ferrari range to sport a front-mounted V12, the 812 GTS hails a triumphant return for a model type that has played a pivotal role in the marque’s history since its foundation.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2022/05/Ferrari-SP48-Unica.jpg"
                },

                new Car()
                {
                    Id = 5,
                    Model = "Ferrari 296 GTB",
                    ColorId = (int)Colors.Gray,
                    StoKMh = 2.5,
                    Price = 470,
                    Description = "From the outside, the design of the Ferrari 296 GTB borrows heavily from the larger SF90 as well as the classic 1960s Ferrari 250 LM.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2021/06/Ferrari-296-GTB-hybryda-z-V6.jpg"
                },

                new Car()
                {
                    Id = 6,
                    Model = "Ferrari SF90 Spider",
                    ColorId = (int)Colors.Gold,
                    StoKMh = 2.75,
                    Price = 500,
                    Description = "The sky overhead appears just 14 seconds after pressing the button, and the entire operation of opening and folding the roof can be carried out while driving.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2020/11/Ferrari-SF90-Spider-hybryda-plug-in-z-napedem-na-4-kola-i-moca-1000-KM.jpg"
                },

                new Car()
                {
                    Id = 7,
                    Model = "Ferrari SF90 Stradale",
                    ColorId = (int)Colors.SpaceGray,
                    StoKMh = 2.65,
                    Price = 490,
                    Description = "Thanks to the changes made, the Ferrari SF90 Stradale produces 780 hp and 800 Nm of torque. An additional 217 hp is provided by three electric motors - two located at the front and one located between the engine and gearbox. The total power of the propulsion system is reportedly 1000 hp.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2019/05/Ferrari-SF90-Stradale.jpg"
                },

                new Car()
                {
                    Id = 8,
                    Model = "Ferrari 488 Pista",
                    ColorId = (int)Colors.Red,
                    StoKMh = 3.10,
                    Price = 510,
                    Description = "Pista is Italian for track. This nickname was given by Ferrari to the successor of the 458 Speciale, revealing its main asset at the outset. Ladies and gentlemen, this is the Ferrari 488 Pista.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2018/02/Ferrari-488-Pista.jpg"
                },

                new Car()
                {
                    Id = 9,
                    Model = "Ferrari F8 Spider Novitec",
                    ColorId = (int)Colors.Black,
                    StoKMh = 2.8,
                    Price = 415,
                    Description = "To improve high-speed stability, the Ferrari F8 Spider features a two-piece carbon fiber front spoiler. Carbon has also been spared on the door handles, mirrors, engine cover and rear wing. The entire bodywork was fine-tuned for aerodynamics in the wind tunnel.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2021/09/Ferrari-F8-Spider-Novitec.jpg"
                },

                new Car()
                {
                    Id = 10,
                    Model = "Ferrari Daytona SP3",
                    ColorId = (int)Colors.Red,
                    StoKMh = 2,
                    Price = 560,
                    Description = "Particularly noteworthy is the rear fins, which dissipate heat from the engine compartment and, together with the powerful diffuser, provide the right downforce. At a speed of 200 km/h, it is as much as 240 kg.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2021/11/Ferrari-Daytona-SP3.jpg"
                }
            });
        }
        public static void SeedColors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(new Color[]
            {
                new Color() { Id = (int)Colors.Silver, Name = "Silver" },
                new Color() { Id = (int)Colors.Black, Name = "Black" },
                new Color() { Id = (int)Colors.Yellow, Name = "Yellow" },
                new Color() { Id = (int)Colors.SpaceGray, Name = "Space Gray" },
                new Color() { Id = (int)Colors.Red, Name = "Red" },
                new Color() { Id = (int)Colors.White, Name = "White" },
                new Color() { Id = (int)Colors.Lime, Name = "Lime" },
                new Color() { Id = (int)Colors.Gold, Name = "Gold" },
                new Color() { Id = (int)Colors.Aqua, Name = "Aqua" },
                new Color() { Id = (int)Colors.Gray, Name = "Gray" },
            });
        }
    }
}

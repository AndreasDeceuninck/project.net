using System.ComponentModel.DataAnnotations;
namespace Orders.Models
{
    public class Order
    {
        public double totaleprijs { get; set; }

        [Required(ErrorMessage = "Geef je naam in")]
        public string? Naam { get; set; }

        [Required(ErrorMessage = "Geef het aantal Bickybroodjes in")]
        public int? AantalBicky { get; set; }
        public readonly double BickyPrice = 3.50;

        [Required(ErrorMessage = "Geef het aantal broodjes boulet in")]
        public int? AantalBoulet { get; set; }
        public readonly double BouletPrice = 3.00;


        [Required(ErrorMessage = "Geef het aantal Zalmbroodjes in")]
        public int? AantalZalm { get; set; }
        public readonly double ZalmPrice = 4.50;

        public Dictionary<string, List<string>> Broodjes { get; set; }

        public int GetAantal(string broodjeSoort)
        {
            int aantal = 0;

            switch (broodjeSoort)
            {
                case "Bicky":
                    aantal = AantalBicky ?? 0;
                    break;
                case "Boulet":
                    aantal = AantalBoulet ?? 0;
                    break;
                case "Zalm":
                    aantal = AantalZalm ?? 0;
                    break;
                default:
                    break;
            }

            return aantal;
        }

        public Order()
        {
            Broodjes = new Dictionary<string, List<string>>
            {
                {"Bicky", new List<string>{"Bicky saus","Préparé", "Ei", "Groenten"}},
                {"Boulet", new List<string>{"Boulet", "Mayonaise", "Ei", "Groenten"}},
                {"Zalm", new List<string>{"Zalm", "Kruidenkaas", "Ei", "Groenten"}}
            };
        }
    }
}

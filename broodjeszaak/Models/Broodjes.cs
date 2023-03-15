namespace broodjeszaak.Models
{
    public class Broodjes
    {
        public int BroodjeID { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public decimal Prijs { get; set; }
        public List<String> Ingredienten { get; set; }
    }
}

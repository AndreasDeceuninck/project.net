namespace broodjeszaak.Models
{
    public class Custommers
    {
        public int CustommerID { get; set; }
        public string Naam { get; set; }
        public string WWachtwoord { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }
        public string Telefoonnummer { get; set; }
        public string Email { get; set; } 
        public bool IsAdmin { get; set; }
    }
}

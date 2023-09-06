namespace WebAPI_Urm.Models
{
    public class Kasutaja
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Kasutaja(int id, string username, string password, string name, string surname)
        {
            ID = id;
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
        }  
    }
}

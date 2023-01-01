namespace programMain;
public class Country : IReturnToString
{
     public int Id { get; }
     public string CountryName { get; set; }

     public Country(int countryId, string caption)
     {
          Id = countryId;
          CountryName = caption;
     }
     public override string ToString() => $"Id:{Id} Country:{CountryName}";
}
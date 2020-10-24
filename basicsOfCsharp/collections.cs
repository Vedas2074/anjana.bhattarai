using System.Collections.Generic;

public class Collections
{
    public void LearnAboutList()
    {
        List<string> names= new List<string> {"Ishan","Rojina"};
        names.Add("Bipin");
        names.Add("Sunar");
        names.Add("Biapin");
        names.Add("Baipin");
        names.Sort();
    }

    public void LearnAboutDictionary()
    {
        //holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>()
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };
        countryCapitals.Add("Nepal","Kathmandu");
        countryCapitals.Add("India","Delhi");
        countryCapitals.Add("Russia","Mosco");
        
    }
}
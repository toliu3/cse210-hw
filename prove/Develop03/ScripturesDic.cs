using System;
public class ScripturesDic
 // Store scriptures as dictionaries in a list and choice a scripture by random.
{
    private int _randomInt;
    private Dictionary<string, string> _scripture;
    

    public Dictionary<string, string> GetScrpture() // This function will return a scripture.
    {    
        List<Dictionary<string, string>> scriptures = new List<Dictionary<string, string>>();
        Dictionary<string, string> scripture1 = new Dictionary<string, string>();
        scripture1["Book"] = "Nephi";
        scripture1["Chapter"] = "3";
        scripture1["StartVerse"] = "7";
        scripture1["EndVerse"] = "0";
        scripture1["Text"] = "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        scriptures.Add(scripture1);

        Dictionary<string, string> scripture2 = new Dictionary<string, string>();
        scripture2["Book"] = "Proverbs";
        scripture2["Chapter"] = "3";
        scripture2["StartVerse"] = "5";
        scripture2["EndVerse"] = "6";
        scripture2["Text"] = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        scriptures.Add(scripture2);

       Dictionary<string, string> scripture3 = new Dictionary<string, string>();
        scripture3["Book"] = "Psalm";
        scripture3["Chapter"] = "24";
        scripture3["StartVerse"] = "3";
        scripture3["EndVerse"] = "4";
        scripture3["Text"] = "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.";
        scriptures.Add(scripture3);

        Dictionary<string, string> scripture4 = new Dictionary<string, string>();
        scripture4["Book"] = "D&C";
        scripture4["Chapter"] = "6";
        scripture4["StartVerse"] = "36";
        scripture4["EndVerse"] = "0";
        scripture4["Text"] = "Look unto me in every thought; doubt not, fear not.";
        scriptures.Add(scripture4);

        Dictionary<string, string> scripture5 = new Dictionary<string, string>();
        scripture5["Book"] = "John";
        scripture5["Chapter"] = "17";
        scripture5["StartVerse"] = "3";
        scripture5["EndVerse"] = "0";
        scripture5["Text"] = "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.";
        scriptures.Add(scripture5);

        
        
        // Choose a scripture from a list by random.
        Random random = new Random();
        _randomInt = random.Next(0,5);
        _scripture = scriptures[_randomInt];

        return _scripture; // Return a chosen scripture.
    }


}
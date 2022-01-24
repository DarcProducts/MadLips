using System.Text;
using UnityEngine;

public enum TypeOfWord
{
    None,
    Noun,
    Adjective,
    PluralNoun,
    PastTenseVerb,
    Verb,
    Verb_ed,
    Verb_ing,
    Colors,
    Foods,
    Places,
    Things,
    Animals,
    BoysNames,
    GirlsNames
}

public class MadLips : MonoBehaviour
{
    public WordList[] AllWords;
    [SerializeField] TMPro.TMP_Text displayText;

    void Start() => InitWords();

    void InitWords()
    {
        foreach (var wList in AllWords)
            wList.InitWordList();
    }

    public string GetTypeOfWordRandomlyFromList(TypeOfWord type)
    {
        foreach (var w in AllWords)
            if (w.WordType == type)
                return w.GetRandomWord();
        return "Craig Hussey";
    }

    public void DisplayRandomUnicornStory()
    {
        if (displayText == null) return;
        displayText.text =
            $"Unicorns are not simliar to a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Animals)}. " +
            $"They are " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}, {GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}, " +
            $"and " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}. " +
            $"People think they look like a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Colors)}-colored {GetTypeOfWordRandomlyFromList(TypeOfWord.Animals)}, " +
            $"with " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Animals)} " +
            $"feet and a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"mane of hair, but they do not. Unicorns are " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Colors)}" +
            $"-colored and look like a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Animals)} " +
            $"that is " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}." +
            $" Some " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"people don't believe unicorns are " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"but I believe they are. I would really love to " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"a unicorn in a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Places)} " +
            $"when I run out of " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PluralNoun)}. " +
            $"One thing I've always " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb_ed)} " +
            $"about is whether unicorns" +
            $" {GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"rainbows, or is their " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Noun)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"like any other animal's?";
    }

    public void DisplayRandomThreePigsStory()
    {
        if (displayText == null) return;
        string animal = GetTypeOfWordRandomlyFromList(TypeOfWord.Animals);
        string badAnimal = GetTypeOfWordRandomlyFromList(TypeOfWord.Animals);
        displayText.text =
            $"Once upon a time, there where three " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"{animal}'s. One day, their mother said, \"you are all grown up and must " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"on your own.\" So they left to " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)}" +
            $" their houses. The first little {animal} only wanted to " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"all day and quickly built its house out of " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PluralNoun)}. " +
            $"The second {animal} wanted to " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"and " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"all day so it " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)} " +
            $"its house with " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PluralNoun)}. " +
            $"The third " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"{animal} knew the {badAnimal} lived nearby and worked hard to " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"its house out of " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Colors)} {GetTypeOfWordRandomlyFromList(TypeOfWord.PluralNoun)}. " +
            $"One day, the {badAnimal} knocked on the first " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}" +
            $" {animal}'s house. Let me in or I'll " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Verb)} " +
            $"you're house down! The {animal} didn't, so the {badAnimal} " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)} " +
            $"and " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Noun)} " +
            $"and the house came down. The {badAnimal} knocked on the second " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"{animal}'s house. Let me in or I'll blow your " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"house down! The {animal} didn't, so the {badAnimal} " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)} " +
            $"down the {animal}'s " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)}. " +
            $"Then, the {badAnimal} knocked on the third {animal}'s door. Let me in or I'll blow the house down. The little {animal} didn't, so the {badAnimal} " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)} " +
            $"and " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)}. " +
            $"It could not blow the house down. All the {animal}'s went to live in the " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Noun)} " +
            $"house and they all " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PastTenseVerb)} " +
            $"happily ever after.";
    }

    public void DisplayRandomHalloweenStory()
    {
        if (displayText == null) return;
        displayText.text =
            "They say my school is haunted. My " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"friend ";
        string girlName = GetTypeOfWordRandomlyFromList(TypeOfWord.GirlsNames);
        displayText.text +=
            $"{char.ToUpper(girlName[0]) + girlName.Substring(1)} " +
            $"says she saw a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Noun)} " +
            $"floating at the end of the hall near the " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Places)}. " +
            $"Some say if you look down that hallway at night, you'll hear a " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Animals)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Verb_ing)} nearby. My " +
            $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} " +
            $"friend ";
        string boyName = GetTypeOfWordRandomlyFromList(TypeOfWord.BoysNames);
        displayText.text +=
        $"{char.ToUpper(boyName[0]) + boyName.Substring(1)} " +
        $"saw a " +
        $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Adjective)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Noun)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Verb_ing)} " +
        $"under the tables once. I hope I never see any " +
        $"{GetTypeOfWordRandomlyFromList(TypeOfWord.PluralNoun)} {GetTypeOfWordRandomlyFromList(TypeOfWord.Verb_ing)}, " +
        $"because eating my " +
        $"{GetTypeOfWordRandomlyFromList(TypeOfWord.Foods)} " +
        $"there is scary enough!";
    }

    public void DisplayRandomZooStory()
    {
        if (displayText == null) return;
    }
}
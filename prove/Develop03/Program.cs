using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture object with Alma 12:26 as reference
        Reference alma12_26 = new Reference("Alma", 12, 26);
        Scripture almaScripture1 = new Scripture(alma12_26,
            "And thus mercy can satisfy the demands of justice, and encircles them in the arms of safety, " +
            "while he that exercises no faith unto repentance is exposed to the whole law of the demands of justice; " +
            "therefore only unto him that has faith unto repentance is brought about the great and eternal plan of redemption.");

        // Create a Scripture object with Alma 37:37 as reference
        Reference alma37_37 = new Reference("Alma", 37, 37);
        Scripture almaScripture2 = new Scripture(alma37_37,
            "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, " +
            "that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; " +
            "and if ye do these things, ye shall be lifted up at the last day.");

        // Add Alma 37:6
        Reference alma37_6 = new Reference("Alma", 37, 6);
        Scripture almaScripture3 = new Scripture(alma37_6,
            "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; " +
            "and small means in many instances doth confound the wise.");

        // Add Proverbs 3:15-17
        Reference proverbs3_15_17 = new Reference("Proverbs", 3, 15, 17);
        Scripture proverbsScripture = new Scripture(proverbs3_15_17,
            "She is more precious than rubies: and all the things thou canst desire are not to be compared unto her. " +
            "Length of days is in her right hand; and in her left hand riches and honour. " +
            "Her ways are ways of pleasantness, and all her paths are peace.");

        // Add Mosiah 5:15
        Reference mosiah5_15 = new Reference("Mosiah", 5, 15);
        Scripture mosiahScripture = new Scripture(mosiah5_15,
            "Therefore, I would that ye should be steadfast and immovable, always abounding in good works, " +
            "that Christ, the Lord God Omnipotent, may seal you his, that you may be brought to heaven, " +
            "that ye may have everlasting salvation and eternal life, through the wisdom, and power, and justice, and mercy of him who created all things, in heaven and in earth, who is God above all. Amen.");

        // Add Romans 12:17-21
        Reference romans12_17_21 = new Reference("Romans", 12, 17, 21);
        Scripture romansScripture = new Scripture(romans12_17_21,
            "Recompense to no man evil for evil. Provide things honest in the sight of all men. " +
            "If it be possible, as much as lieth in you, live peaceably with all men. " +
            "Dearly beloved, avenge not yourselves, but rather give place unto wrath: for it is written, Vengeance is mine; I will repay, saith the Lord. " +
            "Therefore if thine enemy hunger, feed him; if he thirst, give him drink: for in so doing thou shalt heap coals of fire on his head. " +
            "Be not overcome of evil, but overcome evil with good.");

        // Call Scripture Memorization function for all scriptures
        Console.Clear();
        Console.WriteLine("Memorize the following scriptures:");

        // Memorize each scripture one at a time
        MemorizeScripture(almaScripture1);
        MemorizeScripture(almaScripture2);
        MemorizeScripture(almaScripture3);
        MemorizeScripture(proverbsScripture);
        MemorizeScripture(mosiahScripture);
        MemorizeScripture(romansScripture);
    }

    // Function to memorize and hide words
    static void MemorizeScripture(Scripture scripture)
    {
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("\nAll words are hidden. Well done!");
        }
    }
}

// Scripture class to handle the verse and hiding logic
class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int numberOfWordsToHide = 3; // Number of words to hide each time

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int randomIndex = rand.Next(words.Count);
            words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = reference.GetDisplayText() + ": ";

        foreach (Word word in words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText.Trim();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

// Reference class to handle scripture references
class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse == 0 ? startVerse : endVerse;
    }

    public string GetDisplayText()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}

// Word class to handle individual words
class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string GetDisplayText()
    {
        return hidden ? "_____" : text;
    }
}

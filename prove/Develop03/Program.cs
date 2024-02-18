using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John 3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs 3:5-6"), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Matthew 16:15"), "Later in His ministry, Jesus asked His disciples who people thought He was. They replied with the names of several prophets. Jesus then asked, “But whom say ye that I am?”" ),
            new Scripture(new Reference("John 1:41"),"When they heard this, they followed Jesus. One of them, Andrew, found his brother Simon Peter and announced, “We have found … the Christ”"),
            new Scripture(new Reference("John 1:36"),"At the start of His mortal ministry, two disciples of John the Baptist heard John say of Jesus, “Behold the Lamb of God!”"),
            new Scripture(new Reference("3 Nephi 2:1"),"A lack of belief in Jesus Christ is not unique to our day. For example, even after the Lamanites and Nephites saw remarkable “signs and wonders” of the Savior’s birth, the people soon became “less astonished … and began to disbelieve all which they had heard and seen”"),
            new Scripture(new Reference("Matthew 11:7-24"),"Imagine you lived in Palestine during the time of the Lord’s ministry. You have heard many amazing things about a teacher called Jesus of Nazareth and have a strong desire to go and hear Him for yourself. The day you find Him, Jesus is teaching a large group of people. He declares the greatness of John the Baptist and rebukes people for their unbelief"),
            new Scripture(new Reference("Mosiah 3:2"),"And the things which I shall tell you are made known unto me by an aangel from God. And he said unto me: bAwake; and I awoke, and behold he stood before me."),
            new Scripture(new Reference("Mosiah 3:3"),"And he said unto me: Awake, and hear the words which I shall tell thee; for behold, I am come to declare unto you the aglad tidings of great bjoy."),
            new Scripture(new Reference("Mosiah 3:4"),"For the Lord hath heard thy prayers, and hath judged of thy arighteousness, and hath sent me to declare unto thee that thou mayest rejoice; and that thou mayest declare unto thy people, that they may also be filled with joy."),
            new Scripture(new Reference("Mosiah 3:6"),"And he shall cast out adevils, or the bevil spirits which dwell in the hearts of the children of men."),
            new Scripture(new Reference("Mosiah 3:12"),"But wo, wo unto him who knoweth that he arebelleth against God! For salvation cometh to none such except it be through repentance and faith on the bLord Jesus Christ."),
            new Scripture(new Reference("Mosiah 3:14"),"14 Yet the Lord God saw that his people were a astiffnecked people, and he appointed unto them a blaw, even the claw of Moses."),
            new Scripture(new Reference("Mosiah 3:20"),"And moreover, I say unto you, that the time shall come when the aknowledge of a bSavior shall spread throughout cevery nation, kindred, tongue, and people."),
           
        };

        Random _random = new Random();
        Scripture _selectedScripture = _scriptures[_random.Next(_scriptures.Count)];

        while (!_selectedScripture.AllWordsHidden())
        {
            _selectedScripture.HideRandomWord();
            _selectedScripture.DisplayScripture();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit: ");
            string _userInput = Console.ReadLine();

            if (_userInput.ToLower() == "quit")
            {
                break;
            }
        }

        Console.WriteLine("Program ending.");
    }
}



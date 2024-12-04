using System;
using TheShadowKnight;

public class CharacterCreation
{
    static String ans, charName, charRace, charGender, hairStyle, hairColor,
    eyeColor, skinTone, charMass, charClass, charElement, charFaction;
    static int statsInput, maxStatsLimit = 50, charStr = 1, charAgi = 1, charInt = 1, charDex = 1, charLuck = 1;
    static bool hasMoustache = false, hasBeard = false, hasGoatee = false, hasHeadband = false, hasEarrings = false,
    hasNecklace = false, hasRing = false;
    public static void Character()
    {
        Console.WriteLine("CREATE A NEW CHARACTER");
        while (true)
        {
            Console.Write("Enter Character Name[Max of 20 characters]: ");
            charName = Console.ReadLine();
            if (charName.Length <= 20)
            {
                break;
            }
            else
            {
                Console.WriteLine("Name exceeds limit of 20 characters! Please try again.");
                continue;
            }
        }

        while (true)
        {
            Console.WriteLine("Character Race");
            Console.WriteLine("[1] Human");
            Console.WriteLine("[2] Elf");
            Console.WriteLine("[3] Dwarf");
            Console.WriteLine("[4] Fairy");
            Console.WriteLine("[5] Beastman");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();
            if (ans.Equals("1"))
            {
                charRace = "Human";
                break;
            }
            else if (ans.Equals("2"))
            {
                charRace = "Elf";
                break;
            }
            else if (ans.Equals("3"))
            {
                charRace = "Dwarf";
                break;
            }
            else if (ans.Equals("4"))
            {
                charRace = "Fairy";
                break;
            }
            else if (ans.Equals("5"))
            {
                charRace = "Beastman";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Gender");
            Console.WriteLine("[M]ale");
            Console.WriteLine("[F]emale");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.ToUpper().Equals("M"))
            {
                charGender = "Male";
                break;
            }
            else if (ans.ToUpper().Equals("F"))
            {
                charGender = "Female";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Hair Style");
            Console.WriteLine("[1] Wavy");
            Console.WriteLine("[2] Spiky");
            Console.WriteLine("[3] Buzz Cut");
            Console.WriteLine("[4] Curly");
            Console.WriteLine("[5] Slicked Back");
            Console.WriteLine("[6] Fringe");
            Console.WriteLine("[7] Straight Long");
            Console.WriteLine("[8] Wavy Long");
            Console.WriteLine("[9] Braided");
            Console.WriteLine("[10] Ponytail");
            Console.WriteLine("[11] Dreadlocks");
            Console.WriteLine("[12] Fringe Long");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                hairStyle = "Wavy";
                break;
            }
            else if (ans.Equals("2"))
            {
                hairStyle = "Spiky";
                break;
            }
            else if (ans.Equals("3"))
            {
                hairStyle = "Buzz Cut";
                break;
            }
            else if (ans.Equals("4"))
            {
                hairStyle = "Curly";
                break;
            }
            else if (ans.Equals("5"))
            {
                hairStyle = "Slicked Back";
                break;
            }
            else if (ans.Equals("6"))
            {
                hairStyle = "Fringe";
                break;
            }
            else if (ans.Equals("7"))
            {
                hairStyle = "Straight Long";
                break;
            }
            else if (ans.Equals("8"))
            {
                hairStyle = "Wavy Long";
                break;
            }
            else if (ans.Equals("9"))
            {
                hairStyle = "Braided";
                break;
            }
            else if (ans.Equals("10"))
            {
                hairStyle = "Ponytail";
                break;
            }
            else if (ans.Equals("11"))
            {
                hairStyle = "Dreadlocks";
                break;
            }
            else if (ans.Equals("12"))
            {
                hairStyle = "Fringe Long";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Hair Color");
            Console.WriteLine("[1] Black");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Red");
            Console.WriteLine("[4] Brown");
            Console.WriteLine("[5] Gold");
            Console.WriteLine("[6] Green");
            Console.WriteLine("[7] Purple");
            Console.WriteLine("[8] Yellow");
            Console.WriteLine("[9] Gray");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                hairColor = "Black";
                break;
            }
            else if (ans.Equals("2"))
            {
                hairColor = "Blue";
                break;
            }
            else if (ans.Equals("3"))
            {
                hairColor = "Red";
                break;
            }
            else if (ans.Equals("4"))
            {
                hairColor = "Brown";
                break;
            }
            else if (ans.Equals("5"))
            {
                hairColor = "Gold";
                break;
            }
            else if (ans.Equals("6"))
            {
                hairColor = "Green";
                break;
            }
            else if (ans.Equals("7"))
            {
                hairColor = "Purple";
                break;
            }
            else if (ans.Equals("8"))
            {
                hairColor = "Yellow";
                break;
            }
            else if (ans.Equals("9"))
            {
                hairColor = "Gray";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Eye Color");
            Console.WriteLine("[1] Black");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Red");
            Console.WriteLine("[4] Brown");
            Console.WriteLine("[5] Gold");
            Console.WriteLine("[6] Green");
            Console.WriteLine("[7] Purple");
            Console.WriteLine("[8] Yellow");
            Console.WriteLine("[9] Gray");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                eyeColor = "Black";
                break;
            }
            else if (ans.Equals("2"))
            {
                eyeColor = "Blue";
                break;
            }
            else if (ans.Equals("3"))
            {
                eyeColor = "Red";
                break;
            }
            else if (ans.Equals("4"))
            {
                eyeColor = "Brown";
                break;
            }
            else if (ans.Equals("5"))
            {
                eyeColor = "Gold";
                break;
            }
            else if (ans.Equals("6"))
            {
                eyeColor = "Green";
                break;
            }
            else if (ans.Equals("7"))
            {
                eyeColor = "Purple";
                break;
            }
            else if (ans.Equals("8"))
            {
                eyeColor = "Yellow";
                break;
            }
            else if (ans.Equals("9"))
            {
                eyeColor = "Gray";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Skin Tone");
            Console.WriteLine("[1] Light");
            Console.WriteLine("[2] Fair");
            Console.WriteLine("[3] Light Brown");
            Console.WriteLine("[4] Deep Brown");
            Console.WriteLine("[5] Dark");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                skinTone = "Light";
                break;
            }
            else if (ans.Equals("2"))
            {
                skinTone = "Fair";
                break;
            }
            else if (ans.Equals("3"))
            {
                skinTone = "Light Brown";
                break;
            }
            else if (ans.Equals("4"))
            {
                skinTone = "Deep Brown";
                break;
            }
            else if (ans.Equals("5"))
            {
                skinTone = "Dark";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Mass");
            Console.WriteLine("[1] Small");
            Console.WriteLine("[2] Medium");
            Console.WriteLine("[3] Normal");
            Console.WriteLine("[4] Muscular");
            Console.WriteLine("[5] Bodybuilder");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                charMass = "Small";
                break;
            }
            else if (ans.Equals("2"))
            {
                charMass = "Medium";
                break;
            }
            else if (ans.Equals("3"))
            {
                charMass = "Normal";
                break;
            }
            else if (ans.Equals("4"))
            {
                charMass = "Muscular";
                break;
            }
            else if (ans.Equals("5"))
            {
                charMass = "Bodybuilder";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Class");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Archer");
            Console.WriteLine("[3] Berserker");
            Console.WriteLine("[4] Mage");
            Console.WriteLine("[5] Healer");
            Console.WriteLine("[6] Assassin");
            Console.WriteLine("[7] Scout");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                charClass = "Warrior";
                break;
            }
            else if (ans.Equals("2"))
            {
                charClass = "Archer";
                break;
            }
            else if (ans.Equals("3"))
            {
                charClass = "Berserker";
                break;
            }
            else if (ans.Equals("4"))
            {
                charClass = "Mage";
                break;
            }
            else if (ans.Equals("5"))
            {
                charClass = "Healer";
                break;
            }
            else if (ans.Equals("6"))
            {
                charClass = "Assassin";
                break;
            }
            else if (ans.Equals("7"))
            {
                charClass = "Scout";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Element");
            Console.WriteLine("[1] Heat");
            Console.WriteLine("[2] Rain");
            Console.WriteLine("[3] Earth");
            Console.WriteLine("[4] Sky");
            Console.WriteLine("[5] Light");
            Console.WriteLine("[6] Darkness");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                charElement = "Heat";
                break;
            }
            else if (ans.Equals("2"))
            {
                charElement = "Rain";
                break;
            }
            else if (ans.Equals("3"))
            {
                charElement = "Earth";
                break;
            }
            else if (ans.Equals("4"))
            {
                charElement = "Sky";
                break;
            }
            else if (ans.Equals("5"))
            {
                charElement = "Light";
                break;
            }
            else if (ans.Equals("6"))
            {
                charElement = "Darkness";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.WriteLine("Character Faction");
            Console.WriteLine("[1] Knight's Order");
            Console.WriteLine("[2] Mercenaries' Guild");
            Console.WriteLine("[3] Merchants' Guild");
            Console.WriteLine("[4] Holy Church");
            Console.WriteLine("[5] Adventurers' Guild");
            Console.Write("Enter option: ");
            ans = Console.ReadLine();

            if (ans.Equals("1"))
            {
                charFaction = "Knight's Order";
                break;
            }
            else if (ans.Equals("2"))
            {
                charFaction = "Mercenaries' Guild";
                break;
            }
            else if (ans.Equals("3"))
            {
                charFaction = "Merchants' Guild";
                break;
            }
            else if (ans.Equals("4"))
            {
                charFaction = "Holy Church";
                break;
            }
            else if (ans.Equals("5"))
            {
                charFaction = "Adventurers' Guild";
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }

        while (maxStatsLimit > 0)
        {
            Console.WriteLine("Character Stats");
            Console.WriteLine("[1]Character Strength: " + charStr);
            Console.WriteLine("[2]Character Agility: " + charAgi);
            Console.WriteLine("[3]Character Intelligence: " + charInt);
            Console.WriteLine("[4]Character Dexterity: " + charDex);
            Console.WriteLine("[5]Character Luck: " + charLuck);
            Console.WriteLine("Remaining points to be added in stats: " + maxStatsLimit);
            Console.WriteLine("Enter option: ");
            ans = Console.ReadLine();
            if (ans.Equals("1"))
            {
                Console.WriteLine("Add stats to Character Strength: ");
                statsInput = Convert.ToInt32(Console.ReadLine());

                if (statsInput <= maxStatsLimit)
                {
                    charStr += statsInput;
                    maxStatsLimit -= statsInput;
                }
                else
                {
                    Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                }
            }
            else if (ans.Equals("2"))
            {
                Console.WriteLine("Add stats to Character Agility: ");
                statsInput = Convert.ToInt32(Console.ReadLine());

                if (statsInput <= maxStatsLimit)
                {
                    charAgi += statsInput;
                    maxStatsLimit -= statsInput;
                }
                else
                {
                    Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                }
            }
            else if (ans.Equals("3"))
            {
                Console.WriteLine("Add stats to Character Intelligence: ");
                statsInput = Convert.ToInt32(Console.ReadLine());

                if (statsInput <= maxStatsLimit)
                {
                    charInt += statsInput;
                    maxStatsLimit -= statsInput;
                }
                else
                {
                    Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                }
            }
            else if (ans.Equals("4"))
            {
                Console.WriteLine("Add stats to Character Dexterity: ");
                statsInput = Convert.ToInt32(Console.ReadLine());

                if (statsInput <= maxStatsLimit)
                {
                    charDex += statsInput;
                    maxStatsLimit -= statsInput;
                }
                else
                {
                    Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                }
            }
            else if (ans.Equals("5"))
            {
                Console.WriteLine("Add stats to Character Luck: ");
                statsInput = Convert.ToInt32(Console.ReadLine());

                if (statsInput <= maxStatsLimit)
                {
                    charLuck += statsInput;
                    maxStatsLimit -= statsInput;
                }
                else
                {
                    Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        Console.WriteLine("You have no remaining points left to be added in Character Stats.");

        Console.WriteLine("Character Additional Features");
        while (true)
        {
            Console.Write("Put a moustache on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasMoustache = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasMoustache = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put a beard on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasBeard = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasBeard = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put a goatee on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasGoatee = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasGoatee = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put a headband on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasHeadband = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasHeadband = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put an earrings on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasEarrings = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasEarrings = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put a necklace on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasNecklace = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasNecklace = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        while (true)
        {
            Console.Write("Put a ring on your character? [Y/N]: ");
            ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y"))
            {
                hasRing = true;
                break;
            }
            else if (ans.ToUpper().Equals("N"))
            {
                hasRing = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                continue;
            }
        }
        Console.WriteLine("Character has been created.");
        Console.WriteLine("Character Name: " + charName);
        Console.WriteLine("Character Race: " + charRace);
        Console.WriteLine("Character Gender: " + charGender);
        Console.WriteLine("Character Hair Color: " + hairColor);
        Console.WriteLine("Character Eye Color: " + eyeColor);
        Console.WriteLine("Character Skin Tone: " + skinTone);
        Console.WriteLine("Character Mass: " + charMass);
        Console.WriteLine("Character Class: " + charClass);
        Console.WriteLine("Character Element: " + charElement);
        Console.WriteLine("Character Faction: " + charFaction);
        Console.WriteLine("Character Stats");
        Console.WriteLine("   Character Strength: " + charStr);
        Console.WriteLine("   Character Agility: " + charAgi);
        Console.WriteLine("   Character Intelligence: " + charInt);
        Console.WriteLine("   Character Dexterity: " + charDex);
        Console.WriteLine("   Character Luck: " + charLuck);
        Console.WriteLine("Character Additional Features");
        Console.WriteLine("   Character Moustache: " + hasMoustache);
        Console.WriteLine("   Character Beard: " + hasBeard);
        Console.WriteLine("   Character Goatee: " + hasGoatee);
        Console.WriteLine("   Character Headband: " + hasHeadband);
        Console.WriteLine("   Character Earrings: " + hasEarrings);
        Console.WriteLine("   Character Necklace: " + hasNecklace);
        Console.WriteLine("   Character Ring: " + hasRing);
    }
}

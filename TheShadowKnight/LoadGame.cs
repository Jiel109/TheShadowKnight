using System;
using System.Collections;
using System.Data.SqlClient;

namespace TheShadowKnight
{
    class LoadGame
    {
        static int ansInt, charID, charStr, charAgi, charInt, charDex, charLuck;
        static String charName, charRace, charGender, hairStyle, hairColor, eyeColor, skinTone, charMass, charClass, charElement, charFaction;
        static bool hasMoustache, hasBeard, hasGoatee, hasHeadband, hasEarrings, hasNecklace, hasRing;
        public static void LoadCharacter()
        {
            Console.WriteLine("\nLOAD GAME");
            SqlConnection connection;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\LEIJ\SOURCE\REPOS\THESHADOWKNIGHT\THESHADOWKNIGHT\DATABASE1.MDF;Integrated Security=True";
            string selectQueryDB = "SELECT char_id, char_name, char_race, char_gender, char_hairstyle, char_haircolor, char_eyecolor, char_skintone, char_mass, char_class, char_element, char_faction, char_str, char_agi, char_int, char_dex, char_luck, has_moustache, has_beard, has_goatee, has_headband, has_earrings, has_necklace, has_ring FROM dbo.CHARACTER_INFO";

            List<StoreCharInfo> charInfo = new List<StoreCharInfo>();

            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand selectFromDB = new SqlCommand(selectQueryDB, connection);

                try
                {
                    connection.Open();
                    SqlDataReader dbReader = selectFromDB.ExecuteReader();

                    while (dbReader.Read())
                    {
                        charID = Convert.ToInt32(dbReader["char_id"]);
                        charName = dbReader["char_name"].ToString();
                        charRace = dbReader["char_race"].ToString();
                        charGender = dbReader["char_gender"].ToString();
                        hairStyle = dbReader["char_hairstyle"].ToString();
                        hairColor = dbReader["char_haircolor"].ToString();
                        eyeColor = dbReader["char_eyecolor"].ToString();
                        skinTone = dbReader["char_skintone"].ToString();
                        charMass = dbReader["char_mass"].ToString();
                        charClass = dbReader["char_class"].ToString();
                        charElement = dbReader["char_element"].ToString();
                        charFaction = dbReader["char_faction"].ToString();
                        charStr = Convert.ToInt32(dbReader["char_str"]);
                        charAgi = Convert.ToInt32(dbReader["char_agi"]);
                        charInt = Convert.ToInt32(dbReader["char_int"]);
                        charDex = Convert.ToInt32(dbReader["char_dex"]);
                        charLuck = Convert.ToInt32(dbReader["char_luck"]);
                        hasMoustache = Convert.ToBoolean(dbReader["has_moustache"]);
                        hasBeard = Convert.ToBoolean(dbReader["has_beard"]);
                        hasGoatee = Convert.ToBoolean(dbReader["has_goatee"]);
                        hasHeadband = Convert.ToBoolean(dbReader["has_headband"]);
                        hasEarrings = Convert.ToBoolean(dbReader["has_earrings"]);
                        hasNecklace = Convert.ToBoolean(dbReader["has_necklace"]);
                        hasRing = Convert.ToBoolean(dbReader["has_ring"]);

                        charInfo.Add(new StoreCharInfo(charID, charName, charRace, charGender, hairStyle, hairColor, eyeColor, skinTone, charMass, charClass, charElement, charFaction, charStr, charAgi, charInt, charDex, charLuck, hasMoustache, hasBeard, hasGoatee, hasHeadband, hasEarrings, hasNecklace, hasRing));

                        Console.WriteLine("[" + charID + "] " + charName);
                    }

                    dbReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to load existing characters.");
                    Console.WriteLine(ex.Message);
                }
                while (true)
                {
                    Console.WriteLine("Enter the number of the character to load: ");
                    ansInt = Convert.ToInt32(Console.ReadLine());
                        
                    StoreCharInfo findChar = charInfo.Find(character => character.ID == ansInt);
                    if (findChar != null)
                    {
                        Console.WriteLine("Character Information");
                        Console.WriteLine("Character Name: " + findChar.Name);
                    }
                    else
                    {
                        Console.WriteLine("Character not found! Please try again.");
                        continue;
                    }
                }
            }
        }
    }
}
    class StoreCharInfo
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Race { get; set; }
        public String Gender { get; set; }
        public String HairStyle { get; set; }
        public String HairColor { get; set; }
        public String EyeColor { get; set; }
        public String SkinTone { get; set; }
        public String Mass { get; set; }
        public String Class { get; set; }
        public String Element { get; set; }
        public String Faction { get; set; }
        public int Str {  get; set; }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Dex { get; set; }
        public int Luck { get; set; }
        public bool Moustache { get; set; }
        public bool Beard { get; set; }
        public bool Goatee { get; set; }
        public bool Headband { get; set; }
        public bool Earrings { get; set; }
        public bool Necklace { get; set; }
        public bool Ring { get; set; }

        public StoreCharInfo(int id, String name, String race, String gender, String hairstyle, String haircolor, String eyecolor, String skintone, String mass, String job, String element, String faction, int str, int agi, int inte, int dex, int luck, bool moustache, bool beard, bool goatee, bool headband, bool earrings, bool necklace, bool ring)
        {
            ID = id;
            Name = name;
            Race = race;
            Gender = gender;
            HairStyle = hairstyle;
            HairColor = haircolor;
            EyeColor = eyecolor;
            SkinTone = skintone;
            Mass = mass;
            Class = job;
            Element = element;
            Faction = faction;
            Str = str;
            Agi = agi;
            Int = inte;
            Dex = dex;
            Luck = luck;
            Moustache = moustache;
            Beard = beard;
            Goatee = goatee;
            Headband = headband;
            Earrings = earrings;
            Necklace = necklace;
            Ring = ring;
        }
}

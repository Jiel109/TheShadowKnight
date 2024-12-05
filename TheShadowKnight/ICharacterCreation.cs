using System;
namespace TheShadowKnight
{
    interface ICharacterCreation
    {
        void setInfo(string PN, string PR, string PG, string PHS, string PHC, string PEC, string PST, string PM, string PC, string PE, string PF);
        void setInfo(int strength, int agility, int intelligence, int dexterity, int luck);
        void setInfo(bool moustache, bool beard, bool goatee, bool headband, bool earrings, bool necklace, bool ring);
        void showInfo();
        void showStats();
        void showAdditionals();
    }
}

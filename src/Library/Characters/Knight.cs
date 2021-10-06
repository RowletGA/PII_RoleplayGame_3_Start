using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: ICharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Knight(string name)
        {
            this.Name = name;
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}
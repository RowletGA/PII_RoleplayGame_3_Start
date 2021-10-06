using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight : Personaje
    {
       
        public Knight(string name):base(name)
        {
            this.Name = name;
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}
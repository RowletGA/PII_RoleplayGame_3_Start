namespace RoleplayGame
{
    public class Enemy : Personaje 
    {
        public Enemy(string name, int VPmalo):base(name)

        {
            this.VPenemy = VPmalo;

        }
        public int VPenemy
        {
            get;set;
        } 
    }
}
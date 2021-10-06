namespace RoleplayGame
{
    public class Kaido : Enemy 
    {
        public Kaido (string name, int VPmalo):base (name, VPmalo)
        {
            this.AddItem(new Helmet());
            this.AddItem(new Axe());
        }
    }
}
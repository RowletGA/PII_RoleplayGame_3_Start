namespace RoleplayGame
{
    public class DonFlamingo : Enemy 
    {
        public DonFlamingo (string name, int VPmalo):base (name, VPmalo)
        {
            this.AddItem(new Helmet());
            this.AddItem(new Bow());
        }
    }
}
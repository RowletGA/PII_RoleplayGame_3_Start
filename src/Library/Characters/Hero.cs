namespace RoleplayGame

{
    public class Hero : Personaje
    {
        public Hero(string name):base(name)
        {

        }
        public int VP
        {
            get
            {
                return this.VP;
            }
            set
            {
                this.VP = value;
            }
        }

            public void AcumulaVP(Enemy enemies)
            {
                this.VP += enemies.VPenemy;
            }
        }
    }
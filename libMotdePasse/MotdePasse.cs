namespace libMotdePasse
{
    public class MotdePasse
    {

        private string Login;
        private string mdp;

        public MotdePasse(string a, string b)
        {
            this.Login = a;
            this.mdp = b;
        }
        public bool Verifier(string password)
        {
            bool flag = false;
            if(this.mdp == password)
            {
            flag = true;
        }
           return flag;
        }
        public bool Longeur()
        {
            bool flag= false;
            if(this.mdp.Length > 11)
            {
                flag = true;
            }
                return flag;
        }
        public bool EstNumeric()
        {
            bool flag= false;
            if (this.mdp.Char.IsNumber
        }
    }
}

 
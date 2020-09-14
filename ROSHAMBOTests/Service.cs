namespace ROSHAMBOTests
{
    internal class Service
    {
        public Service()
        {
        }
        public string Play (string firstReveal, string secondReveal)
        {
            if (secondReveal == "Paper" && firstReveal == "Rock")
            {
                return "Paper wins";
            }
            return "Rock Wins";
        }
    }
}
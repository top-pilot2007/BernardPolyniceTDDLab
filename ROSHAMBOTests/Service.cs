namespace ROSHAMBOTests
{
    internal class Service
    {
        public Service()
        {
        }
        public string Play (string firstReveal, string secondReveal)
        {
            if (firstReveal == "Rock" && secondReveal == "Scissors")
            {
                return "Rock beats Scissors";
            }
            return "Scissors Wins";
        }
    }
}
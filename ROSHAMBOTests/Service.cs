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
            if (firstReveal == "Paper" && secondReveal == "Rock")
            {
                return "Paper beats Rock";
            }
            if (firstReveal == "Scissors" && secondReveal == "Paper")
            {
                return "Scissors beats Paper";
            }
            return "It's a Draw";
        }
    }
}
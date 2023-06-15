namespace Full_GRASP_And_SOLID
{
    class Client : TimerClient
    {
        public Recipe MyRecipe { get; set; }
        public Client(Recipe recipe)
        {
            this.MyRecipe = recipe;
        }

        public void TimeOut()
        {
            this.MyRecipe.Cooked = true;
        }
    }
}
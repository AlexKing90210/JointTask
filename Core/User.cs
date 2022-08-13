namespace Core
{
    public class User
    {
        private string fio;
        private string amount;

        public User(string fio, string amount)
        {
            this.fio = fio;
            this.amount = amount;
        }

        public string GetFio()
        {
            return fio;
        }

        public string GetAmount()
        {
            return amount;
        }

        //напрягает публичный! сеттер который никак не обрабатывает
        public void SetAmount(string sum)
        {
            this.amount = sum;
        }


    }
}
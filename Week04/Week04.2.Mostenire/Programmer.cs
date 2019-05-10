namespace Week04._2.Mostenire
{
    public class Programmer : Employee
    {
        public string Technology { get; set; }

        public void Print()
        {
            var x = this.someProtectedField; //accesam prop / meth din instanta curenta
            var y = base.Age; //accesam prop / meth din clasa de baza
        }
    }
}
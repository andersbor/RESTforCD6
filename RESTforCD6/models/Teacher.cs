namespace RESTforCD6.models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        public void ValidateSalary()
        {
            if (Salary < 0)
            {
                throw new ArgumentOutOfRangeException("Salary is too low");
            }
        }
    }
}

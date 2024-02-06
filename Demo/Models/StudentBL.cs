namespace Demo.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id=1,Name="Ahmed",Age=22,Image="m.png"});
            students.Add(new Student() { Id = 2, Name = "soha", Age = 22, Image = "2.jpg" });
            students.Add(new Student() { Id = 3, Name = "basma", Age = 22, Image = "2.jpg" });
            students.Add(new Student() { Id = 4, Name = "Ali", Age = 22, Image = "m.png" });
        }
        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students.FirstOrDefault(s=>s.Id==id);
        }

    }
}

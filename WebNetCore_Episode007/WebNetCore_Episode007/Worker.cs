using Microsoft.EntityFrameworkCore;
using WebNetCore_Episode007.Entities;

namespace WebNetCore_Episode007
{
    public class Worker : BackgroundService
    {
        private readonly StudentDbContext _db;
        public Worker(StudentDbContext db)
        {
            _db = db;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _db.Persons.AddRange(
                new PersonInfo
                {
                    Name = "Test Name",
                    Address = "Moon",
                    Email = "frace@marteja.com",
                    BirthDay = new DateTime(2000, 2, 2),
                    Age = 111
                },
                new PersonInfo
                {
                    Name = "2nd name",
                    Address = "Sun",
                    Email = "pro@grammer.com",
                    BirthDay = new DateTime(2000, 3, 3),
                    Age = 222
                });
            await _db.SaveChangesAsync();

            //C - Create
            /*await InsertStudent(new Student { 
                Name = "Frace M",
                Address = "Far from what you think",
                BirthDay = new DateTime(1999,1,1)
            });*/
            //R - Retrieve
            /*var students = await GetStudents();
            foreach(var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.BirthDay?.ToString("MM/dd/yyyy")}");
            }*/
            /*
            Console.WriteLine("GetById");
            var studentById = await GetStudentById(1);
            Console.WriteLine(studentById?.Name);

            Console.WriteLine("GetByName");
            var studentByName = await GetStudentByName("Frace M");
            Console.WriteLine(studentByName?.Name);
            */
            //await UpdateStudentName(1, "Frace Marteja - Updated Version");
            //await DeleteStudent(1);
        }

        private async Task<List<Student>> GetStudents()
        {
            return await _db.Students.ToListAsync();
        }

        private async Task<Student> GetStudentById(int id)
        {
            return await _db.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        private async Task<Student> GetStudentByName(string name)
        {
            return await _db.Students
                .Where(s => s.Name == name)
                .FirstOrDefaultAsync();
        }

        private async Task UpdateStudentName(int id, string name)
        {
            var student = await GetStudentById(id);
            if(student != null)
            {
                student.Name = name;
                _db.SaveChangesAsync();
            }
        }
        private async Task DeleteStudent(int id)
        {
            _db.Students.Remove(await GetStudentById(id));
            await _db.SaveChangesAsync();
        }

        public async Task InsertStudent(Student student)
        {
            _db.Students.Add(student);
            await _db.SaveChangesAsync();
        }
    }
}
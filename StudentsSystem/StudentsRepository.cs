using System.Collections.Generic;

namespace StudentsSystem
{
    class StudentsRepository
    {
        private List<Student> _students = new List<Student>();



        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public IEnumerable<Student> Students
        {
            get { return _students; }
        }
    }
}

namespace StudentsSystem
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _group;

        public Student(string firstName, string lastName, string @group)
        {
            _firstName = firstName;
            _lastName = lastName;
            _group = @group;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string Group
        {
            get { return _group; }
        }
    }
}

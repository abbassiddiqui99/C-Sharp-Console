namespace C_Sharp_Console
{
    public class Student
    {
        public string name;
        public string field;
        public float gpa;
        
        public Student(string aName,string aField,float aGpa)
        {
            name = aName;
            field = aField;
            gpa = aGpa;
        }

        public bool Abroad() {
            if (gpa > 3.0) {
                return true;
            } 
            return false;
        }
    }
}   
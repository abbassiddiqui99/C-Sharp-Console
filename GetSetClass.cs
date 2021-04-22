namespace C_Sharp_Console
{
    public class GetSetClass
    {
        // Example of getter and setter
        public string name;
        private string department;
        public GetSetClass(string aName,string aDepartment)
        {
            name = aName;
            Department = aDepartment;
        }

        public string Department {
            get { return department; }
            set {
                if (value == "IT" || value == "DEV" || value == "LC") {
                    department = value;
                }
                else {
                    department = "N/A";
                }
            }
        }
    }
}
namespace RecordType
{
    internal class Student_As_Class
    {
        public Student_As_Class(Guid guid, string studName, int studSem)
        {
            studID = guid;
            this.studName = studName;
            this.studSem = studSem;
        }

        public Guid studID { get; set; }
        public string studName { get; set; }
        public int studSem { get; set; }

        public void getInfo()
        {
            Console.WriteLine( "\n Student Details : " );
            Console.WriteLine("\t studID : " + this.studID );
            Console.WriteLine("\t studName : " + this.studName);
            Console.WriteLine("\t studSem : " + this.studSem);
        }

    }
}
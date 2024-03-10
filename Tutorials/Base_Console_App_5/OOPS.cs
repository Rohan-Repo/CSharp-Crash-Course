using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordType
{
    internal class OOPS
    {

        public record Student_As_Record(Guid studID, string studName, int studSem);

        public struct Student_As_Struct
        {
            public Guid StudID { get; init;  }
            public string StudName { get; init;  }
            public int StudSem { get; init; }

            //public void Student_As_Struct( Guid studID, string studName, int studSem)
            //{
            //    StudID = studID;
            //    StudName = studName;
            //    StudSem = studSem;

            //}
        }

        //static void Main(string[] args)
        //{
        //    /*
        //        Create User-Defined Data-types using record, struct or classes:
        //        records: just to create Getters and Setters but they are immutable - Cannot be changed  
        //        objects are stored in heap memory and given a pointer to that object
        //        struct: to store primitive data-types, exists on the execution stack of the program - runs on the memory provided for your thread - so really useful for small data-types - to have readily accesible values for small data-types in memory
        //        struct are value types so if any changes are made a new object is created rather than a reference of that object - Readonly copy created - quick access like counters for example can use structs
        //        classes: used to model normal OOPS like complex objects, methods, properties, has 5 access modifiers:
        //            - public : visible and accessible everywhere
        //            - private : visible and accessible to only the scope 
        //            - protected : visible and accessible to class and it's children
        //            - internal : visible and accessible in the assembly
        //            - file : visible and accessible in just this file
        //        classes can be inherited, abstract to inherit
        //        interface just defines a function or value but implementation is AbandonedMutexException in the child class
            //*/

            
        //    Student_As_Class student_1 = new RecordType.Student_As_Class( Guid.NewGuid(), "Jane Doe", 1 );
        //    Console.WriteLine("Student_As_Class : " + student_1 );
        //    student_1.getInfo();

        //    Student_As_Record student_2 = new Student_As_Record( Guid.NewGuid(), "Mary Smith", 2 );
        //    Console.WriteLine( "Student_As_Record : \n \t " + student_2 );

        //    Student_As_Struct student_3 = new Student_As_Struct
        //    {
        //        StudID = Guid.NewGuid(),
        //        StudName = "John Doe",
        //        StudSem = 8
        //    };

        //    Console.WriteLine( "Student_As_Struct : \n \t " + student_3 );

        //    /*
        //        student_3.StudName = "Kelly" - Gives an error:
        //        Init-only property or indexer 'OOPS.Student_As_Struct.StudName' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor
        //    */
        //}
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3_que1
{
    internal class course
    {
        private string courseName;
        private string instructorId;
        private int grade;

        /*public course(string _courseName , string _instrutorId , int _grade )
        {
             CourseName = _courseName;
            
        }*/

        public string CourseName => courseName; //Read only

        public int Grade
        {
            get => grade;
            set
            {
                if (!(0<grade && grade<100))
                {
                    Console.WriteLine("invalid.");
                }

                else
                {
                    grade = value;
                }

                
            }
            
                

        }

        public string InstructorId
        {
            get => instructorId;
            set => instructorId = value;
        }



        public void SetInstructorName()
        {
            Console.WriteLine("Enter Instructor name: ");
            string name = Console.ReadLine();

            if (!(name == null)) 
            {
                InstructorId = name;

            }
        }

        
    }
}

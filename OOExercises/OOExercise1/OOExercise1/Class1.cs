using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1
{ 
    

    public abstract class Person 
    {
        private string Fname { get; set; }
        private string Gender { get; set; }
        private string Lname { get; set; }

        public Person (string nm, string gndr, string lNm)
        {
            if (gndr == "M" || gndr == "F")
            {
                Fname = nm;
                Gender = gndr;
                Lname = lNm;
            }
            else
            {
                Console.WriteLine("Invalid Gender Passed to Person Constructor");
            }
            
        }

        public Person (string gndr)
        {
            switch (gndr)
            {
                case "M":
                    {
                        Fname = "John";
                        Lname = "Doe";
                        break;
                    }

                case "F":
                    {
                        Fname = "Jane";
                        Lname = "Doe";
                        break;
                    }
        
                default:
                    break;
            }
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public string GetGender()
        {
            return Gender;
        }

        public abstract string Work();
    }

    public class Hobo : Person
    {
        public Hobo (string pNm, string pGndr, string pLnm) : base(pNm, pGndr, pLnm)
        {
        }

        public Hobo(string pGndr): base(pGndr)
        {
        }

        public override string Work()
        {
            return "Find A Place To Sleep";
        }
    }

    public class Student : Person
    {
        private string StudentID { get; set; }

        public Student(string pNm, string pGndr, string pLnm, string pStudentID) : base(pNm, pGndr, pLnm)
        {
            StudentID = pStudentID;
        }

        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }
    }

    


    public abstract class Teacher : Person 
    {
        private int StaffID { get; set; }
        public ITeach TeachBehaviour;

        public Teacher(string pNm, string pGndr, string pLnm, int pStaffID) : base (pNm, pGndr, pLnm)
        {
            StaffID = pStaffID;
        }

        public override string GetOccupation()
        {
            return "Teacher";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }

    }

    public class SecondaryTeacher : Teacher
    {

        public SecondaryTeacher(string pNm, string pGndr, string pLnm, int pStaffID) : base(pNm, pGndr, pLnm, pStaffID)
        {
            TeachBehaviour = new TeachHighSchool();
        }
        

        public override string GetOccupation()
        {
            return "Secondary Teacher";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();

        }
    }

    public class PAVETeacher : Teacher
    {

        public PAVETeacher (string pNm, string pGndr, string pLnm, int pStaffID) : base(pNm, pGndr, pLnm, pStaffID)
        {
            TeachBehaviour = new TeachPAVE();
        }

        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }
    }

    public class SpecialNeedsTeacher : Teacher
    {
        public SpecialNeedsTeacher(string pNm, string pGndr, string pLnm, int pStaffID) : base(pNm, pGndr, pLnm, pStaffID)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }

        public override string GetOccupation()
        {
            return "Teach Special Needs";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }
    }

    public class TeachHighSchool :ITeach
    {
        public string Teach()
        {
            return "Teach High School Brats";
        }
    }

    public class TeachPAVE : ITeach
    {
        public string Teach()
        {
            return "Teach Awesome SWD Students";
        }
    }

    public class TeachSpecialNeeds : ITeach
    {
        public string Teach()
        {
            return "Teach Special Needs";
        }
    }

    public interface ITeach
    {
        string Teach();
    }

    

}

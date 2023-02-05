using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Lecture_Example___Selection_Box___ListBox_and_Combo_Box__
{
    public class Student
    {
        //fileds
        private string firstName;
        private string lastName;
        private double cSIgrade;
        private double genEdGrade;

        public Student(string firstName, string lastName, double cSIgrade, double genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIgrade = cSIgrade;
            GenEdGrade = genEdGrade;
        }

        //override our Tostring();
        public override string ToString()
        {
            return FirstName + " " + LastName + "--" + CSIgrade + "--" + GenEdGrade;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double CSIgrade { get => cSIgrade; set => cSIgrade = value; }
        public double GenEdGrade { get => genEdGrade; set => genEdGrade = value; }

    }
}

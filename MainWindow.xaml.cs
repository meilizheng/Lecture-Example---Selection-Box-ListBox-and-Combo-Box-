using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Meili Zheng;
//Lecture Example Selection Box
//02/05/2023

namespace Lecture_Example___Selection_Box___ListBox_and_Combo_Box__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Student selectedsudent = null;

        public MainWindow()
        {
           
            InitializeComponent();
            // how to add items to a selection box;
            // Add the selection by ACCESS its items list;
            Preload();
            DisplayToListBox();
            DisplayToComboBox();
            List<string> name = new List<string>();
            name.Clear();
            //Automatically select the first item in our listbox on load;
            
            lbDisplay.SelectedIndex = 0;
            cbDisplay.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string UserInput = txtAddToList.Text;
            lbDisplay.Items.Add(UserInput);
        }

        public void DisplayToListBox()
        {
            //Use the .Clear() method to clear all item from our list box;
            lbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                lbDisplay.Items.Add(students[i]);
            }
        }
        public void DisplayToComboBox()
        {
            //Use the .Clear() method to clear all item from our list box;
            cbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i].FirstName;
                string lastName = students[i].LastName;
                string fullName = firstName + " " + lastName;
                cbDisplay.Items.Add(fullName);               
            }
        }
        public void Preload()
        {
            Student student = new Student("Meili", "Zheng", 90.05, 90.88);
            students.Add(student);
            students.Add(new Student("Hannah", "Angel", 100, 100));
            students.Add(new Student("Dylan", "Register", 101, 99));
            students.Add(new Student("Kris", "Taniguchi", 100, 100));
        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            //you can access the select item, by using .selectindex.
            int selectindex = lbDisplay.SelectedIndex;
            if (selectindex < 0)
            {
                MessageBox.Show("Please select a name from the list box");
            }
            else
            {
                DisplayStudentInformation(selectedsudent);
            }
            
        }
        public void DisplayStudentInformation(Student student)
        {

            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCSIGrade.Text = student.CSIgrade.ToString();
            txtGenED.Text = student.GenEdGrade.ToString();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string CSI = txtCSIGrade.Text;
            string GenED = txtGenED.Text;
            double CSIgrade = double.Parse(txtGenED.Text);
            double GenEdGrade = double.Parse(txtGenED.Text);
            students.Add(new Student(fName, lName, CSIgrade, GenEdGrade));
            DisplayToListBox();
        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            //remove by index;
            //int selectedIndex = lbDisplay.SelectedIndex;
            //students.RemoveAt(selectedIndex);
            //remove by object
            int selectindex = lbDisplay.SelectedIndex;
          
            students.RemoveAt(selectindex);
            DisplayToListBox();
        }

        public void DisplayUpdatedInformation(int selectedindex)
        {
            selectedsudent = students[selectedindex];
            DisplayStudentInformation(selectedsudent);
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayUpdatedInformation(lbDisplay.SelectedIndex);
        }

        private void cbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayUpdatedInformation(cbDisplay.SelectedIndex);
        }
    }
}

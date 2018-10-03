using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using CsvHelper;
using System.Runtime.Serialization.Formatters.Binary;

//Golovinov Timur
//18/09/2018
/*This programm allows user to keep track of eployees database
 add, delete, and update employee's information. The library stored in binary file 
 and can be saved and/or loaded. */

namespace EmployeesData
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            BinaryRead();
        }

        // INPUT AND OUTPUT

        // #1
        //Create a list of employees
        List<Employees> myEmployees = new List<Employees>();

        // #2
        //Read data from binary file
        public void BinaryRead()
        {
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream("employees.bin", FileMode.Open));
            }
            catch (Exception fe)
            {
                MessageBox.Show("File Is Not Open " + fe.Message);
                return;
            }
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                Employees newEmployee = new Employees();
                try
                {
                    newEmployee.Name = br.ReadString();
                    newEmployee.Age = br.ReadString();
                    newEmployee.Salary = br.ReadString();
                    newEmployee.Experience = br.ReadString();
                    newEmployee.Position = br.ReadString();
                    newEmployee.Department = br.ReadString();
                    myEmployees.Add(newEmployee);
                }
                catch (Exception fe)
                {
                    MessageBox.Show("Cannot read file " + fe.Message);
                    break;
                }
            }
            br.Close();
            DisplayRecords();
        }

        // #3
        //Write data to binary file
        public void BinaryWrite()
        {
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream("employees.bin", FileMode.Create));
            }
            catch (Exception fe)
            {
                MessageBox.Show("File Is Not Created " + fe.Message);
                return;
            }
            try
            {
                foreach (Employees employee in myEmployees)
                {
                    bw.Write(employee.Name);
                    bw.Write(employee.Age);
                    bw.Write(employee.Salary);
                    bw.Write(employee.Experience);
                    bw.Write(employee.Position);
                    bw.Write(employee.Department);
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show("File Is Not Written" + fe.Message);
            }
            bw.Close();
        }

        // #4
        //Method to display fields im the List Box
        //Show all the records in the list
        public void DisplayRecords()
        {
            //Clear the list before displaying the records
            listOfEmployees.Items.Clear();
            //Loop through the List<> and showing the details
            foreach (var employee in myEmployees)
            {
                listOfEmployees.Items.Add(employee.Name + "   " + employee.Position + "  "
                    + employee.Department + "   ");
            }
        }

        // BUTTONS

        // #5 
        //Button "Add"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create new employee
            Employees newEmployee = new Employees();
            //Receive data from the text boxes
            newEmployee.Name = textName.Text;
            newEmployee.Age = textAge.Text;
            newEmployee.Salary = textSalary.Text;
            newEmployee.Experience = textExperience.Text;
            newEmployee.Position = textPosition.Text;
            newEmployee.Department = textDepartment.Text;

            //Check if text box has data
            //If null or empty set hasData to false
            bool hasData = true;
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Please enter full name of the Employee");
                hasData = false;
                return;
            }
            if (String.IsNullOrEmpty(textAge.Text))
            {
                MessageBox.Show("Please enter the age");
                hasData = false;
                return;
            }
            if (String.IsNullOrEmpty(textSalary.Text))
            {
                MessageBox.Show("Please enter the salary");
                hasData = false;
                return;
            }
            if (String.IsNullOrEmpty(textExperience.Text))
            {
                MessageBox.Show("Please enter employee's years of experience");
                hasData = false;
                return;
            }
            if (String.IsNullOrEmpty(textPosition.Text))
            {
                MessageBox.Show("Please enter employee's position");
                hasData = false;
                return;
            }
            if (String.IsNullOrEmpty(textDepartment.Text))
            {
                MessageBox.Show("Please enter employee's department");
                hasData = false;
                return;
            }

            //If data is valid, add the record
            bool duplicateFound = myEmployees.Exists(x => x.Name == textName.Text);

            if (hasData && !duplicateFound)
            {
                //Add record to the list<>
                myEmployees.Add(newEmployee);

                //Empty the field for the next record
                textName.Text = "";
                textAge.Text = "";
                textSalary.Text = "";
                textExperience.Text = "";
                textPosition.Text = "";
                textDepartment.Text = "";

                //Display the record in the list box
                DisplayRecords();

                //Write in binary file
                BinaryWrite();
            }
            else
            {
                MessageBox.Show("This Employee has already been added");
            }

        }

        // #6
        //Button "Update"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Create updated details
            Employees updatedEmployee = new Employees();
            updatedEmployee.Name = textName.Text;
            updatedEmployee.Age = textAge.Text;
            updatedEmployee.Salary = textSalary.Text;
            updatedEmployee.Experience = textExperience.Text;
            updatedEmployee.Position = textPosition.Text;
            updatedEmployee.Department = textDepartment.Text;

            //Update selected employee
            if (listOfEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select a record from the List Box");
            }
            else
            {
                string curItem = listOfEmployees.SelectedItem.ToString();
                int indx = listOfEmployees.FindString(curItem);
                myEmployees[indx].Name = updatedEmployee.Name;
                myEmployees[indx].Age = updatedEmployee.Age;
                myEmployees[indx].Salary = updatedEmployee.Salary;
                myEmployees[indx].Experience = updatedEmployee.Experience;
                myEmployees[indx].Position = updatedEmployee.Position;
                myEmployees[indx].Department = updatedEmployee.Department;

                //Empty the field for the next record
                textName.Text = "";
                textAge.Text = "";
                textSalary.Text = "";
                textExperience.Text = "";
                textPosition.Text = "";
                textDepartment.Text = "";

                DisplayRecords();
            }
        }

        // #7
        //Button "Delete"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check if a record has been selected from the list box
            //then remove that record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (listOfEmployees.SelectedIndex == -1)
                {
                    MessageBox.Show("Select the Record from the List Box");
                }
                else
                {
                    string curItem = listOfEmployees.SelectedItem.ToString();
                    int indx = listOfEmployees.FindString(curItem);
                    listOfEmployees.SetSelected(indx, true);
                    myEmployees.RemoveAt(indx);

                    //Empty the field for the next record
                    textName.Text = "";
                    textAge.Text = "";
                    textSalary.Text = "";
                    textExperience.Text = "";
                    textPosition.Text = "";
                    textDepartment.Text = "";

                    DisplayRecords();
                }
            }
            else if (result == DialogResult.No)
            {
                //MessageBox.Show("Canceled");
            }
            else if (result == DialogResult.Cancel)
            {
                // MessageBox.Show("Canceled");
            }

        }

        // #8
        //Button "Search"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search Employee by Name
            //Employee must be sorted alphabetically before search
            void nameSearch()
            {
                int min = 0;
                int max = myEmployees.Count - 1;
                Employees tempEmployee = new Employees();
                string targetName = textName.Text;
                bool found = false;
                while (min <= max)
                {
                    int mid = ((min + max) / 2);
                    string curElement = myEmployees.ElementAt(mid).Name.ToString();
                    if (targetName.CompareTo(curElement) == 0)
                    {
                        textName.Text = myEmployees[mid].Name;
                        textAge.Text = myEmployees[mid].Age;
                        textSalary.Text = myEmployees[mid].Salary;
                        textExperience.Text = myEmployees[mid].Experience;
                        textPosition.Text = myEmployees[mid].Position;
                        textDepartment.Text = myEmployees[mid].Department;
                        found = true;
                        break;
                    }
                    else if (targetName.CompareTo(curElement) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                if (!(found))
                {
                    textName.Text = "";
                    textAge.Text = "";
                    textSalary.Text = "";
                    textExperience.Text = "";
                    textPosition.Text = "";
                    textDepartment.Text = "";
                    MessageBox.Show("Not Found");
                    found = true;
                }
            }

            nameSearch();
        }

        // #9
        //Button "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            BinaryWrite();
            MessageBox.Show("Saved Successfully");
        }

        // #10
        //Button "Load"
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Loading previous library may create duplicates?",
                                  "Do you want to proceed?",
                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BinaryRead();
            }
            else if (result == DialogResult.No)
            {
                //MessageBox.Show("Canceled");
            }
            else if (result == DialogResult.Cancel)
            {
                // MessageBox.Show("Canceled");
            }
        }

        // #11
        //Button "Clear"
        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textAge.Text = "";
            textSalary.Text = "";
            textExperience.Text = "";
            textPosition.Text = "";
            textDepartment.Text = "";
        }

        // #12
        //Button "Sort"
        private void btnSort_Click(object sender, EventArgs e)
        {
            myEmployees.Sort();
            DisplayRecords();
        }


        // ADDITIONAL FEATURES

        //... Save data before closing
        private void Library_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryWrite();
        }

        // ... Show details of highlighted employee
        private void listOfEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOfEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Employee from the List Box");
            }
            else
            {
                string curItem = listOfEmployees.SelectedItem.ToString();
                int indx = listOfEmployees.FindString(curItem);
                listOfEmployees.SetSelected(indx, true);
                textName.Text = myEmployees[indx].Name;
                textAge.Text = myEmployees[indx].Age;
                textSalary.Text = myEmployees[indx].Salary;
                textExperience.Text = myEmployees[indx].Experience;
                textPosition.Text = myEmployees[indx].Position;
                textDepartment.Text = myEmployees[indx].Department;
            }
        }

        //Calculate hourly rate based on salary
        private void btnRate_Click(object sender, EventArgs e)
        {
            if (listOfEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Employee from the List Box");
            }
            else
            {
                string curItem = listOfEmployees.SelectedItem.ToString();
                int indx = listOfEmployees.FindString(curItem);
                listOfEmployees.SetSelected(indx, true);

                double rate = 0;

                if (!Double.TryParse(myEmployees[indx].Salary, out rate))
                {
                    rate = -1;
                }
                accList.Items.Clear();
                accList.Items.Add(myEmployees[indx].Name + "'s hourly rate is: $" + Math.Round(rate/2080, 2));
            }
        }

        //Calculate Superannuation
        private void btnSupa_Click(object sender, EventArgs e)
        {
            if (listOfEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Employee from the List Box");
            }
            else
            {
                string curItem = listOfEmployees.SelectedItem.ToString();
                int indx = listOfEmployees.FindString(curItem);
                listOfEmployees.SetSelected(indx, true);

                double supa = 0;

                if (!Double.TryParse(myEmployees[indx].Salary, out supa))
                {
                    supa = -1;
                }
                accList.Items.Clear();
                accList.Items.Add(myEmployees[indx].Name + "'s superannuation is: $" + Math.Round(supa * 0.095, 2) + " per year");
            }
        }

        //Calculate PAYG
        private void btnPAYG_Click(object sender, EventArgs e)
        {
            if (listOfEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Employee from the List Box");
            }
            else
            {
                string curItem = listOfEmployees.SelectedItem.ToString();
                int indx = listOfEmployees.FindString(curItem);
                listOfEmployees.SetSelected(indx, true);

                double payg = 0;

                if (!Double.TryParse(myEmployees[indx].Salary, out payg))
                {
                    payg = -1;
                }
                accList.Items.Clear();
                accList.Items.Add(myEmployees[indx].Name + "'s PAYG Witheld: $" + Math.Round(payg * 0.39, 2) + "per year");
            }
        }
    }
}
namespace EmployeesData
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textExperience = new System.Windows.Forms.TextBox();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.Label();
            this.empAge = new System.Windows.Forms.Label();
            this.empSalary = new System.Windows.Forms.Label();
            this.empExperience = new System.Windows.Forms.Label();
            this.empPosition = new System.Windows.Forms.Label();
            this.empDepartment = new System.Windows.Forms.Label();
            this.listOfEmployees = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnPAYG = new System.Windows.Forms.Button();
            this.btnSupa = new System.Windows.Forms.Button();
            this.accList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(391, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textName, "FirstName of Employee");
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(391, 63);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textAge, "Employee\'s Age");
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(391, 89);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(100, 20);
            this.textSalary.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textSalary, "Yearly Salary");
            // 
            // textExperience
            // 
            this.textExperience.Location = new System.Drawing.Point(391, 115);
            this.textExperience.Name = "textExperience";
            this.textExperience.Size = new System.Drawing.Size(100, 20);
            this.textExperience.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textExperience, "Years of Experience");
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(391, 141);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(100, 20);
            this.textPosition.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textPosition, "Position in the Company");
            // 
            // textDepartment
            // 
            this.textDepartment.Location = new System.Drawing.Point(391, 167);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(100, 20);
            this.textDepartment.TabIndex = 5;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Cursor = System.Windows.Forms.Cursors.Default;
            this.empName.Location = new System.Drawing.Point(328, 40);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(57, 13);
            this.empName.TabIndex = 6;
            this.empName.Text = "First Name";
            this.toolTip1.SetToolTip(this.empName, "First Name of Employee");
            // 
            // empAge
            // 
            this.empAge.AutoSize = true;
            this.empAge.Location = new System.Drawing.Point(359, 66);
            this.empAge.Name = "empAge";
            this.empAge.Size = new System.Drawing.Size(26, 13);
            this.empAge.TabIndex = 7;
            this.empAge.Text = "Age";
            this.toolTip1.SetToolTip(this.empAge, "Employee\'s Age");
            // 
            // empSalary
            // 
            this.empSalary.AutoSize = true;
            this.empSalary.Location = new System.Drawing.Point(349, 92);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(36, 13);
            this.empSalary.TabIndex = 8;
            this.empSalary.Text = "Salary";
            this.toolTip1.SetToolTip(this.empSalary, "Yearly Salary");
            // 
            // empExperience
            // 
            this.empExperience.AutoSize = true;
            this.empExperience.Location = new System.Drawing.Point(325, 118);
            this.empExperience.Name = "empExperience";
            this.empExperience.Size = new System.Drawing.Size(60, 13);
            this.empExperience.TabIndex = 9;
            this.empExperience.Text = "Experience";
            this.toolTip1.SetToolTip(this.empExperience, "Years of Experience");
            // 
            // empPosition
            // 
            this.empPosition.AutoSize = true;
            this.empPosition.Location = new System.Drawing.Point(341, 144);
            this.empPosition.Name = "empPosition";
            this.empPosition.Size = new System.Drawing.Size(44, 13);
            this.empPosition.TabIndex = 10;
            this.empPosition.Text = "Position";
            this.toolTip1.SetToolTip(this.empPosition, "Position in the Company");
            // 
            // empDepartment
            // 
            this.empDepartment.AutoSize = true;
            this.empDepartment.Location = new System.Drawing.Point(323, 170);
            this.empDepartment.Name = "empDepartment";
            this.empDepartment.Size = new System.Drawing.Size(62, 13);
            this.empDepartment.TabIndex = 11;
            this.empDepartment.Text = "Department";
            this.toolTip1.SetToolTip(this.empDepartment, "Department\'s Name");
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.listOfEmployees.FormattingEnabled = true;
            this.listOfEmployees.Location = new System.Drawing.Point(12, 37);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Size = new System.Drawing.Size(280, 394);
            this.listOfEmployees.TabIndex = 12;
            this.toolTip1.SetToolTip(this.listOfEmployees, "List of Employees");
            this.listOfEmployees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listOfEmployees_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(391, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Add New Employee");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(391, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "Update Exising Employee");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(391, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Selected Employee");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(391, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.btnSearch, "Search Employee by Name or Position");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save the Library");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(391, 350);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 23);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.toolTip1.SetToolTip(this.btnLoad, "Load the Library");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(391, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear the List Box");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(391, 408);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 20;
            this.btnSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.btnSort, "Sort Alphabetically");
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(732, 339);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(98, 23);
            this.btnRate.TabIndex = 21;
            this.btnRate.Text = "Hourly Rate";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnPAYG
            // 
            this.btnPAYG.Location = new System.Drawing.Point(836, 339);
            this.btnPAYG.Name = "btnPAYG";
            this.btnPAYG.Size = new System.Drawing.Size(98, 23);
            this.btnPAYG.TabIndex = 22;
            this.btnPAYG.Text = "PAYG";
            this.btnPAYG.UseVisualStyleBackColor = true;
            this.btnPAYG.Click += new System.EventHandler(this.btnPAYG_Click);
            // 
            // btnSupa
            // 
            this.btnSupa.Location = new System.Drawing.Point(628, 339);
            this.btnSupa.Name = "btnSupa";
            this.btnSupa.Size = new System.Drawing.Size(98, 23);
            this.btnSupa.TabIndex = 23;
            this.btnSupa.Text = "Superannuation";
            this.btnSupa.UseVisualStyleBackColor = true;
            this.btnSupa.Click += new System.EventHandler(this.btnSupa_Click);
            // 
            // accList
            // 
            this.accList.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accList.FormattingEnabled = true;
            this.accList.ItemHeight = 19;
            this.accList.Location = new System.Drawing.Point(628, 393);
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(306, 42);
            this.accList.TabIndex = 24;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 447);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.btnSupa);
            this.Controls.Add(this.btnPAYG);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOfEmployees);
            this.Controls.Add(this.empDepartment);
            this.Controls.Add(this.empPosition);
            this.Controls.Add(this.empExperience);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.empAge);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.textExperience);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Name = "Library";
            this.Text = "Employees Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Library_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textExperience;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empAge;
        private System.Windows.Forms.Label empSalary;
        private System.Windows.Forms.Label empExperience;
        private System.Windows.Forms.Label empPosition;
        private System.Windows.Forms.Label empDepartment;
        private System.Windows.Forms.ListBox listOfEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnPAYG;
        private System.Windows.Forms.Button btnSupa;
        private System.Windows.Forms.ListBox accList;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademy
{
    public partial class Student_Info : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        
        
       
        public Student_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student_Tasks metask = new Student_Tasks();
            
            metask.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Student_Tasks mytask = new Student_Tasks();
            mytask.Stud_Id = Convert.ToInt32(this.lblcagir.Text);
            mytask.ShowDialog();
        }

        
    }
}

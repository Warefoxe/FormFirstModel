using FormFIrstModel.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFIrstModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Context context = new Context();
            var students = context.Students2.ToList();
            Students student = students[0];

            context.Groups.FirstOrDefault(t => t.Id == students.GroupId).Name;
            InitializeComponent();

        }
    }
}

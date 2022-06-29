using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace AditionalTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using(ConnectionString db = new ConnectionString())
            {
                dataGridView1.DataSource = db.MyTables.ToList();
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //using(ConnectionString db = new ConnectionString())
            //{
            //    db.MyTables.Add(new MyTable() { Id = 1, Name = "Vasya", LastName = "Popov", Age = 32 });
            //    db.MyTables.Add(new MyTable { Id = 2, Name = "Petya", LastName = "Dropkin", Age = 44 });
            //    db.MyTables.Add(new MyTable { Id = 3, Name = "Grisha", LastName = "Obidin", Age = 26 });                    
            //    db.SaveChanges();
            //}
        }
    }
}

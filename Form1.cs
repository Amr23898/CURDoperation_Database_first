using EF.Model;
namespace EF
{
    public partial class Form1 : Form
    {
        ITIContext context;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
              context = new ITIContext();
           
            dgvstudent.DataSource = context.Students.Select(s=>new {s.St_Id,s.St_Fname,s.St_Lname,s.St_Address,s.St_Age,s.Dept_Id,s.St_super}).ToList();

            combo_deptid.DataSource=context.Departments.ToList();
            combo_deptid.DisplayMember = "dept_name";
            combo_deptid.ValueMember = "dept_id";
            combo_sup.DataSource = context.Students.ToList();
            combo_sup.DisplayMember = "st_fname";
            combo_sup.ValueMember = "st_id";
            btn_update.Enabled = false;
                
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            Student sts=new Student();
            sts.St_Id =int.Parse(text_id.Text);
            sts.St_Fname = text_fname.Text;
            sts.St_Lname = text_lname.Text;
            sts.St_Age =int.Parse(text_age.Text);
            sts.St_Address= text_address.Text;
            sts.Dept_Id = (int)combo_deptid.SelectedValue;
            sts.St_super = (int)combo_sup.SelectedValue;
            context.Students.Add(sts);
            context.SaveChanges();
            dgvstudent.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Address, s.St_Age, s.Dept_Id, s.St_super }).ToList();
            text_id.Text = text_lname.Text = text_fname.Text = text_age.Text = text_address.Text = " ";
            lab_state.Text = "Inseted Successfully";
         }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgvstudent.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Address, s.St_Age, s.Dept_Id, s.St_super }).Where(n => n.St_Id == int.Parse(text_id.Text)).ToList();

        }


        private void dgvstudent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((MessageBox.Show("Are you sure to delete yhis row ?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                int id = (int)dgvstudent.SelectedRows[0].Cells[0].Value;
                Student s = context.Students.Where(s => s.St_Id == id).SingleOrDefault();
                context.Students.Remove(s);
                context.SaveChanges();
                dgvstudent.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Address, s.St_Age, s.Dept_Id, s.St_super }).ToList();
                
                lab_state.Text = "Deleted successfully";

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Student s = context.Students.Where(s => s.St_Id == int.Parse(text_id.Text)).SingleOrDefault();
            context.Students.Remove(s);
            context.SaveChanges();
            dgvstudent.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Address, s.St_Age, s.Dept_Id, s.St_super }).ToList();
            text_id.Text = text_lname.Text = text_fname.Text = text_age.Text = text_address.Text = " ";
            lab_state.Text = "Deleted successfully";
            text_id.Text = " ";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = context.Students.Where(s => s.St_Id == int.Parse(text_id.Text)).SingleOrDefault();
            s.St_Fname = text_fname.Text;
            s.St_Lname = text_lname.Text;
            s.St_Age = int.Parse(text_age.Text);
            s.St_Address = text_address.Text;
            s.Dept_Id =(int) combo_deptid.SelectedValue;
            context.SaveChanges();
            dgvstudent.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Address, s.St_Age, s.Dept_Id, s.St_super }).ToList();
            text_id.Text = text_lname.Text = text_fname.Text = text_age.Text = text_address.Text = " ";
            btn_ins.Enabled = true;
            text_id.Enabled = true;
            btn_update.Enabled = false;
            lab_state.Text = "UpDated successfully";



        }

        private void dgvstudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvstudent.SelectedRows[0].Cells[0].Value;
            Student s = context.Students.Where(s => s.St_Id == id).SingleOrDefault();
            text_id.Enabled = false;
            btn_update.Enabled = true;
            btn_ins.Enabled = false;
            text_id.Text = s.St_Id.ToString();
            text_fname.Text = s.St_Fname;
            text_lname.Text = s.St_Lname;
            text_age.Text= s.St_Age.ToString();
            text_address.Text = s.St_Address;
            combo_deptid.SelectedValue=s.Dept_Id;
        }
    }
}
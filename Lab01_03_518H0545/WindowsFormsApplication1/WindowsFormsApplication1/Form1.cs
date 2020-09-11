using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc là muốn thoát đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void HuyDangKy_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc là muốn xóa tất cả thông tin \n Thông tin sau khi xóa sẽ không được lưu"
                                        , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if(this.Controls[i] is TextBox || this.Controls[i] is ComboBox)
                    {
                        this.Controls[i].ResetText();
                    }
                    else if(this.Controls[i] is CheckedListBox)
                    {
                        foreach (int j in monHoc.CheckedIndices)
                        {
                            monHoc.SetItemCheckState(j, CheckState.Unchecked);
                        }
                    }
                    else if(this.Controls[i] is RadioButton)
                    {
                        this.radioButton1.Checked = false;
                        this.radioButton2.Checked = false;
                        this.radioButton3.Checked = false;
                        this.radioButton4.Checked = false;
                    }
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MSSV.Text) 
                || string.IsNullOrEmpty(HovaTen.Text)
                || NienKhoa.Text == ""
                || Lop.Text == ""
                || monHoc.SelectedIndex < 0)
            {
                var Dangky_error = MessageBox.Show("Bạn chưa hoàn thành mục nào đó \nVui lòng hãy hoàn thành", "Thông báo", MessageBoxButtons.OK);
            }
            else if(this.radioButton1.Checked == false 
                    && this.radioButton2.Checked == false
                    && this.radioButton3.Checked == false
                    && this.radioButton4.Checked == false)
            {
                var HK_error = MessageBox.Show("Bạn chưa chọn học kì \nVui lòng hãy hoàn thành", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string message1 = "MSSV: " + this.MSSV.Text
                                + "\nHọ và tên: " + this.HovaTen.Text
                                + "\nNiên khóa: " + this.NienKhoa.Text
                                + "\nLớp: " + this.Lop.Text;

                string message2 = "";

                if (this.radioButton1.Checked == true)
                {
                    message2 = "\nĐã đăng ký học Học kỳ 1 Các môn học sau";
                }

                else if (this.radioButton2.Checked == true)
                {
                    message2 = "\nĐã đăng ký học Học kỳ 2 Các môn học sau";
                }

                else if (this.radioButton3.Checked == true)
                {
                    message2 = "\nĐã đăng ký học Học kỳ 3 Các môn học sau";
                }

                else if (this.radioButton4.Checked == true)
                {
                    message2 = "\nĐã đăng ký học Học kỳ 4 Các môn học sau";
                }

                // get selected value from checkboxlist
                string message3 = "\n";

                /*for(int i = 0; i < monHoc.Items.Count; i++)
                {
                    if(monHoc.GetItemChecked(i) == true)
                    {
                        Console.WriteLine(monHoc.GetItemText(i));                        
                        message3 += "\n";
                    }
                }*/

                foreach (var item in monHoc.CheckedItems)
                {
                    message3 += item.ToString();
                    message3 += "\n";

                }

                string caption = "Thông tin đăng ký";
                var result = MessageBox.Show(message1 + message2 + message3, caption, MessageBoxButtons.OK);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TestBaiTapLonWinform2
{
    public partial class LuongCunt : Form
    {
		bool isSearching = false;
		SqlConnection connection;
		SqlCommand command;
		string str = "Data Source=MYLAPTOP\\SQLEXPRESS;Initial Catalog=QlDauBep;Integrated Security=True";
		DataTable dt = new DataTable();
		DataTable original = new DataTable(); // Biến tạm để lưu trữ cơ sở dữ liệu cũ
		SqlDataAdapter adapter = new SqlDataAdapter();
		string imgLocation = Path.Combine(Directory.GetCurrentDirectory(), "noImages.jpg");
		public LuongCunt()
        {
            InitializeComponent();
        }
		void LoadData()
		{
			command = connection.CreateCommand();
			command.CommandText = "Select * from DauBep";
			using (SqlDataReader reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					string imgPath = reader.GetString(reader.GetOrdinal("imageFile"));
					if (File.Exists(imgPath))
					{
						pictureBox1.Image = Image.FromFile(imgPath);
					}
				}
			}
			adapter.SelectCommand = command;
			dt.Clear();
			adapter.Fill(dt);
			dsDauBep.DataSource = dt;
			original = dt.Copy();
		}
		private void LuongCunt_Resize(object sender, EventArgs e)
		{

		}

		private void LuongCunt_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			LoadData();
		}
		String ShowResultRadio()
		{
			RadioButton rdb = null;
			foreach (RadioButton item in panel4.Controls)
			{
				if (item != null)
				{
					if (item.Checked)
					{
						rdb = item;
						break;
					}
				}
			}
			if (rdb != null)
			{
				return rdb.Text;
			}
			return null;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string gender = ShowResultRadio();
			if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtTrinhDo.Text) || string.IsNullOrEmpty(txtStudy.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(txtPhone.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
			}
			else
			{
				command = connection.CreateCommand();
				command.CommandText = "insert DauBep(MaDauBep, TenDauBep,MaTrinhDo,MaNoiHoc,DiaChia,GioiTinh,DienThoai, imageFile)  values('" + txtMaNV.Text + "', N'" + txtTen.Text + "', N'" + txtTrinhDo.Text + "', N'" + txtStudy.Text + "', N'" + txtAddress.Text + "',N'" + gender + "', '" + txtPhone.Text + "', N'" + imgLocation + "')\r\n";
				command.ExecuteNonQuery();
				LoadData();
			}
		}

		private void dsDauBep_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string gender = ShowResultRadio();
			string imgPath;
			txtMaNV.ReadOnly = true;
			int i;
			i = dsDauBep.CurrentRow.Index;
			txtMaNV.Text = dsDauBep.Rows[i].Cells[0].Value.ToString();
			txtTen.Text = dsDauBep.Rows[i].Cells[1].Value.ToString();
			txtTrinhDo.Text = dsDauBep.Rows[i].Cells[2].Value.ToString();
			txtStudy.Text = dsDauBep.Rows[i].Cells[3].Value.ToString();
			txtAddress.Text = dsDauBep.Rows[i].Cells[4].Value.ToString();
			gender = dsDauBep.Rows[i].Cells[5].Value.ToString();
			if (gender == radioButton1.Text)
			{
				radioButton1.Checked = true;
			}
			else if (gender == radioButton2.Text) { radioButton2.Checked = true; }
			txtPhone.Text = dsDauBep.Rows[i].Cells[6].Value.ToString();
			imgPath = dsDauBep.Rows[i].Cells[9].Value.ToString();
			if (File.Exists(imgPath))
			{
				pictureBox1.Image = Image.FromFile(imgPath);

			}
			else
			{
				MessageBox.Show("Không tìm thấy ảnh");
			}
		}
	}
}

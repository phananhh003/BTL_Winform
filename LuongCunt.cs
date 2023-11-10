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
using Excel = Microsoft.Office.Interop.Excel;

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

		private void btnRep_Click(object sender, EventArgs e)
		{
			string gender = ShowResultRadio();
			command = connection.CreateCommand();
			command.CommandText = "Update DauBep set TenDauBep = N'" + txtTen.Text + "', MaTrinhDo = '" + txtTrinhDo.Text + "', MaNoiHoc = '" + txtStudy.Text + "', DiaChia = N'" + txtAddress.Text + "', GioiTinh =N'" + gender + "',DienThoai = '" + txtPhone.Text + "', imageFile = N'" + imgLocation + "'  where MaDauBep = '" + txtMaNV.Text + "'";
			command.ExecuteNonQuery();
			LoadData();
		}

		private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			command = connection.CreateCommand();
			command.CommandText = "Delete from DauBep where MaDauBep = '" + txtMaNV.Text + "'";
			command.ExecuteNonQuery();
			LoadData();
		}

		private void btnUpLoad_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg; *.jpeg)|*.jpg;*.jpeg", Multiselect = false })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show(ofd.FileName);
					imgLocation = ofd.FileName.ToString();
					pictureBox1.Image = Image.FromFile(imgLocation);
				}
			}
		}
		void loadDataDefault()
		{
			txtMaNV.ReadOnly = false;
			txtMaNV.Text = " ";
			txtMaNV.Text = " ";
			txtTen.Text = " ";
			txtTrinhDo.Text = " ";
			txtStudy.Text = " ";
			txtAddress.Text = " ";
			txtTimKiem.Text = " ";
			txtPhone.Text = " ";
			foreach (RadioButton item in panel4.Controls)
			{
				item.Checked = false;
			}
		}
		void ReloadDataGrid()
		{
			dt.Clear();
			dt = original.Copy();
			dsDauBep.DataSource = dt;
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			loadDataDefault();
			if (isSearching)
			{
				btnSearch_Click(sender, e);
				isSearching = false;
			}
			ReloadDataGrid();
		}

		void loadDataSearch()
		{
			string timKiem = txtTimKiem.Text;
			string cmd = "SELECT * FROM DauBep WHERE TenDauBep = @TimKiem OR TenNoiHoc = @TimKiem OR TenTrinhDo = @TimKiem";
			command = connection.CreateCommand();
			command.CommandText = cmd;
			command.Parameters.AddWithValue("@TimKiem", timKiem);

			dt.Clear();
			adapter.SelectCommand = command;
			adapter.Fill(dt);
			dsDauBep.DataSource = dt;
			isSearching = true;
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			loadDataSearch();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{

			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1]; //Thể hiện rằng file này có 1 trang tính
			Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // Con trỏ chạy vào ô A1 
			exRange.Font.Size = 15;
			exRange.Font.Bold = true;
			exRange.Font.Color = Color.Blue;
			exRange.Value = "Thông tin chi tiết";

			exSheet.Range["D4"].Font.Size = 20;
			exSheet.Range["D4"].Font.Color = Color.Red;
			exSheet.Range["D4"].Font.Bold = true;
			exSheet.Range["D4"].Value = "Nhân viên Đầu Bếp";

			//In các thông tin chung
			exSheet.Range["A6:H6"].Font.Size = 12;
			exSheet.Range["A6:H6"].ColumnWidth = 17;
			exSheet.Range["A6:H6"].Font.Bold = true;
			exSheet.Range["A6:H6"].Font.Color = Color.Black;

			exSheet.Range["A6"].Value = "STT";
			exSheet.Range["B6"].Value = "Mã nhân viên";
			exSheet.Range["C6"].Value = "Họ và Tên";
			exSheet.Range["D6"].Value = "Mã trình độ";
			exSheet.Range["E6"].Value = "Mã nơi học";
			exSheet.Range["F6"].Value = "Địa chỉ";
			exSheet.Range["G6"].Value = "Giới tính";
			exSheet.Range["H6"].Value = "Điện thoại";
			//In danh sách các chi tiết nhân viên
			int dong = 7;
			for (int i = 0; i < dsDauBep.Rows.Count - 1; i++)
			{
				exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
				exSheet.Range["B" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[0].Value.ToString();
				exSheet.Range["C" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[1].Value.ToString();
				exSheet.Range["D" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[2].Value.ToString();
				exSheet.Range["E" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[3].Value.ToString();
				exSheet.Range["F" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[4].Value.ToString();
				exSheet.Range["G" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[5].Value.ToString();
				exSheet.Range["H" + (dong + i).ToString()].Value = dsDauBep.Rows[i].Cells[6].Value.ToString();
			}
			dong = dong + dsDauBep.Rows.Count;
			exSheet.Range["F" + dong.ToString()].Value = "Được thực hiển bởi quản lý";
			exSheet.Name = "Đầu Bếp";
			exBook.Activate();
			//Lưu file
			SaveFileDialog save = new SaveFileDialog();
			if (save.ShowDialog() == DialogResult.OK)
			{
				exBook.SaveAs(save.FileName.ToLower());
				MessageBox.Show("Lưu file thành công");
			}
			exApp.Quit();
		}
	}
}

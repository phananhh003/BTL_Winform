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
using System.Diagnostics.Eventing.Reader;

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
			dsDauBep.ReadOnly = true;
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
		String XuatMaTrinhDo()
		{
			string maTrinhDo;
			int i = dsDauBep.CurrentRow.Index;
			if (txtTrinhDo.SelectedIndex == -1)
			{
				maTrinhDo = dsDauBep.Rows[i].Cells[2].Value.ToString();
			}
			else
			{
				maTrinhDo = txtTrinhDo.SelectedItem.ToString();
			}
			if (maTrinhDo == "Xuất Sắc") return  "G001";
			else if (maTrinhDo == "Giỏi") return  "G002";
			else if (maTrinhDo == "Khá") return  "K001";
			else if (maTrinhDo == "TB-Khá") return  "K002";
			else if (maTrinhDo == "Trung Bình") return  "TB001";
			else if (maTrinhDo == "Học viên") return  "TB002";
			else return  "Y001";

		}
		String XuatMaNoiHoc()
		{
			string noiHoc;
			int i = dsDauBep.CurrentRow.Index;
			if (txtTrinhDo.SelectedIndex == -1)
			{
				noiHoc = dsDauBep.Rows[i].Cells[3].Value.ToString();
			}
			else
			{
				noiHoc = txtStudy.SelectedItem.ToString();
			}
			if (noiHoc == "Trường S") return  "S00";
			else if (noiHoc == "Trường A") return  "A00";
			else if (noiHoc == "Trường B") return  "B00";
			else return  "C00";
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string maTrinhDo = XuatMaTrinhDo();
			string maNoiHoc = XuatMaNoiHoc();
			string gender = ShowResultRadio();
			if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtTrinhDo.Text) || string.IsNullOrEmpty(txtStudy.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(txtPhone.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
			}
			else
			{
				command = connection.CreateCommand();
				command.CommandText = "insert DauBep(MaDauBep, TenDauBep,MaTrinhDo,MaNoiHoc,DiaChia,GioiTinh,DienThoai, imageFile)  values('" + txtMaNV.Text + "', N'" + txtTen.Text + "', N'" + maTrinhDo + "', N'" + maNoiHoc + "', N'" + txtAddress.Text + "',N'" + gender + "', '" + txtPhone.Text + "', N'" + imgLocation + "')\r\n";
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
			string maTrinhDo = dsDauBep.Rows[i].Cells[2].Value.ToString();
			string maNoiHoc = dsDauBep.Rows[i].Cells[3].Value.ToString();

			txtMaNV.Text = dsDauBep.Rows[i].Cells[0].Value.ToString();
			txtTen.Text = dsDauBep.Rows[i].Cells[1].Value.ToString();

			if (maTrinhDo == "G001") txtTrinhDo.Text = "Xuất Sắc";
			else if (maTrinhDo == "G002") txtTrinhDo.Text = "Giỏi";
			else if (maTrinhDo == "K001") txtTrinhDo.Text = "Khá";
			else if (maTrinhDo == "K002") txtTrinhDo.Text = "TB-Khá";
			else if (maTrinhDo == "TB001") txtTrinhDo.Text = "Trung Bình";
			else if (maTrinhDo == "TB002") txtTrinhDo.Text = "Học Viên";
			else txtTrinhDo.Text = "Thử việc";

			if (maNoiHoc == "S00") txtStudy.Text= "Trường S";
			else if (maNoiHoc == "A00") txtStudy.Text = "Trường A";
			else if (maNoiHoc == "B00") txtStudy.Text ="Trường B";
			else txtStudy.Text = "Cao Đẳng C";

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
			string tenCopy, TDCopy, NHCopy, DiaChiCopy, GenderCop, PhoneCop, imgLocateCop;
			string trinhDoTemp, noiHocTemp;
			int i = dsDauBep.CurrentRow.Index;
			tenCopy = dsDauBep.Rows[i].Cells[1].Value.ToString();
			TDCopy =  dsDauBep.Rows[i].Cells[2].Value.ToString();
			NHCopy = dsDauBep.Rows[i].Cells[3].Value.ToString();
			
			if (TDCopy == "G001") trinhDoTemp = "Xuất Sắc";
			else if (TDCopy == "G002") trinhDoTemp = "Giỏi";
			else if (TDCopy == "K001") trinhDoTemp = "Khá";
			else if (TDCopy == "K002") trinhDoTemp = "TB-Khá";
			else if (TDCopy == "TB001") trinhDoTemp = "Trung Bình";
			else if (TDCopy == "TB002") trinhDoTemp = "Học Viên";
			else trinhDoTemp = "Thử việc";

			if (NHCopy == "S00") noiHocTemp = "Trường S";
			else if (NHCopy == "A00") noiHocTemp = "Trường A";
			else if (NHCopy == "B00") noiHocTemp = "Trường B";
			else noiHocTemp = "Cao Đẳng C";
			
			DiaChiCopy = dsDauBep.Rows[i].Cells[4].Value.ToString();
			GenderCop = dsDauBep.Rows[i].Cells[5].Value.ToString();
			if (GenderCop == radioButton1.Text)
			{
				radioButton1.Checked = true;
			}
			else if (GenderCop == radioButton2.Text) { radioButton2.Checked = true; }
			PhoneCop = dsDauBep.Rows[i].Cells[6].Value.ToString();
			imgLocateCop = dsDauBep.Rows[i].Cells[9].Value.ToString();
			if (File.Exists(imgLocateCop))
			{
				pictureBox1.Image = Image.FromFile(imgLocateCop);

			}
			else
			{
				MessageBox.Show("Không tìm thấy ảnh");
			}
			//Kiểm tra điều kiện
			if(tenCopy == txtTen.Text && trinhDoTemp == txtTrinhDo.Text && noiHocTemp == txtStudy.Text && DiaChiCopy == txtAddress.Text && GenderCop == gender && PhoneCop == txtPhone.Text && imgLocateCop == imgLocation)
			{
				txtTen.Text = tenCopy;
				txtTrinhDo.Text = trinhDoTemp;
				txtStudy.Text = noiHocTemp;
				txtAddress.Text = DiaChiCopy;
				txtPhone.Text = PhoneCop;
				if (GenderCop == radioButton1.Text)
				{
					radioButton1.Checked = true;
				}
				else if (GenderCop == radioButton2.Text) { radioButton2.Checked = true; }
				imgLocation = imgLocateCop;
				if (File.Exists(imgLocation))
				{
					pictureBox1.Image = Image.FromFile(imgLocation);

				}
			}
			else
			{
				using (SqlCommand command = new SqlCommand("UPDATE DauBep SET TenDauBep = @Ten, MaTrinhDo = @TrinhDo, MaNoiHoc = @Study, DiaChia = @DiaChi, GioiTinh =@Gender ,DienThoai = @Phone, imageFile = @img WHERE MaDauBep = @MaNV", connection))
				{
					command.Parameters.AddWithValue("@Ten", txtTen.Text);
					
					if (txtTrinhDo.Text == "Xuất Sắc") command.Parameters.AddWithValue("@TrinhDo", "G001");
					else if(txtTrinhDo.Text == "Giỏi") command.Parameters.AddWithValue("@TrinhDo", "G002");
					else if(txtTrinhDo.Text == "Khá") command.Parameters.AddWithValue("@TrinhDo", "K001");
					else if(txtTrinhDo.Text == "TB-Khá") command.Parameters.AddWithValue("@TrinhDo", "K002");
					else if(txtTrinhDo.Text == "Trung Bình") command.Parameters.AddWithValue("@TrinhDo", "TB001");
					else if(txtTrinhDo.Text == "Học viên") command.Parameters.AddWithValue("@TrinhDo", "TB002");
					else command.Parameters.AddWithValue("@TrinhDo", "Y001");

					if (txtStudy.Text == "Trường S") command.Parameters.AddWithValue("@Study", "S00");
					else if (txtStudy.Text == "Trường A") command.Parameters.AddWithValue("@Study", "A00");
					else if (txtStudy.Text == "Trường B") command.Parameters.AddWithValue("@Study", "B00");
					else command.Parameters.AddWithValue("@Study", "C00");

					command.Parameters.AddWithValue("@DiaChi",txtAddress.Text);
					command.Parameters.AddWithValue("@Gender",	gender);
					command.Parameters.AddWithValue("@Phone", txtPhone.Text);
					command.Parameters.AddWithValue("@img", imgLocation);

					command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

					command.ExecuteNonQuery();
					LoadData();
				}
			}
			
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
			loadDataDefault();
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
			exSheet.Range["D6"].Value = "Tên trình độ";
			exSheet.Range["E6"].Value = "Tên nơi học";
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
				
				string maTrinhDo = dsDauBep.Rows[i].Cells[2].Value.ToString();
				string maNoiHoc = dsDauBep.Rows[i].Cells[3].Value.ToString();
				
				if (maTrinhDo == "G001") exSheet.Range["D" + (dong + i).ToString()].Value = "Xuất Sắc";
				else if (maTrinhDo == "G002") exSheet.Range["D" + (dong + i).ToString()].Value = "Giỏi";
				else if (maTrinhDo == "K001") exSheet.Range["D" + (dong + i).ToString()].Value = "Khá";
				else if (maTrinhDo == "K002") exSheet.Range["D" + (dong + i).ToString()].Value = "TB-Khá";
				else if (maTrinhDo == "TB001") exSheet.Range["D" + (dong + i).ToString()].Value = "Trung Bình";
				else if (maTrinhDo == "TB002") exSheet.Range["D" + (dong + i).ToString()].Value = "Học Viên";
				else exSheet.Range["D" + (dong + i).ToString()].Value = "Thử việc";

				if (maNoiHoc == "S00") exSheet.Range["E" + (dong + i).ToString()].Value = "Trường S";
				else if (maNoiHoc == "A00") exSheet.Range["E" + (dong + i).ToString()].Value = "Trường A";
				else if (maNoiHoc == "B00") exSheet.Range["E" + (dong + i).ToString()].Value = "Trường B";
				else exSheet.Range["E" + (dong + i).ToString()].Value = "Cao Đẳng C";

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

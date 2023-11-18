using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestBaiTapLonWinform2
{
    public partial class QuangNam : Form
    {
		SqlConnection connection;
		SqlCommand command = new SqlCommand();
		string sql = "Data Source=LAPTOP-7CFRQVA5\\SQLEXPRESS;Initial Catalog=CSDL;Integrated Security=True";
		System.Data.DataTable dataTable1 = new System.Data.DataTable();
		System.Data.DataTable dataTable2 = new System.Data.DataTable();
		SqlDataAdapter adapter = new SqlDataAdapter();

		void loadData1()
		{
			command = connection.CreateCommand();
			command.CommandText = "Select ChiTietThucDon.MaMonAn, TenMonAn, SUM(SoLuong) as TongSoluong from ChiTietThucDon inner join MonAn on MonAn.MaMonAn=ChiTietThucDon.MaMonAn Group by ChiTietThucDon.MaMonAn, TenMonAn Order by TongSoluong desc";
			adapter.SelectCommand = command;
			dataTable1.Clear();
			adapter.Fill(dataTable1);
			dataTien.DataSource = dataTable1;
		}
		void loadData2()
		{
			command = connection.CreateCommand();
			command.CommandText = "select DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai, sum(ThanhTien) as TongTien from DauBep\r\njoin TrinhDo on TrinhDo.MaTrinhDo = DauBep.MaTrinhDo" +
				"\r\njoin ChiTietThucDon on ChiTietThucDon.MaDauBep = DauBep.MaDauBep" +
				"\r\njoin ThucDon on ThucDon.SoThucDon = ChiTietThucDon.SoThucDon" +
				"\r\ngroup by DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai";
			adapter.SelectCommand = command;
			dataTable2.Clear();
			adapter.Fill(dataTable2);
			dataMonAn.DataSource = dataTable2;
		}
		void loadData3(int n)
		{
			command = connection.CreateCommand();
			command.CommandText = "select DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai, sum(ThanhTien) as TongTien from DauBep" +
				"\r\njoin TrinhDo on TrinhDo.MaTrinhDo = DauBep.MaTrinhDo" +
				"\r\njoin ChiTietThucDon on ChiTietThucDon.MaDauBep = DauBep.MaDauBep" +
				"\r\njoin ThucDon on ThucDon.SoThucDon = ChiTietThucDon.SoThucDon" +
				"\r\nwhere MONTH(NgayDung) = '" + n + "'" +
				"\r\ngroup by DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai" +
				"\r\nOrder By DauBep.MaDauBep";
			adapter.SelectCommand = command;
			dataTable2.Clear();
			adapter.Fill(dataTable2);
			dataMonAn.DataSource = dataTable2;
		}
		void loadData4(int n)
		{
			int n1 = 0, n2 = 0, n3 = 0;
			switch (n)
			{
				case 1:
					n1 = 1;
					n2 = 2;
					n3 = 3;
					break;
				case 2:
					n1 = 4;
					n2 = 5;
					n3 = 6;
					break;
				case 3:
					n1 = 7;
					n2 = 8;
					n3 = 9;
					break;
				case 4:
					n1 = 10;
					n2 = 11;
					n3 = 12;
					break;
			}
			command = connection.CreateCommand();
			command.CommandText = "select DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai, sum(ThanhTien) as TongTien from DauBep\r\njoin TrinhDo on TrinhDo.MaTrinhDo = DauBep.MaTrinhDo" +
				"\r\njoin ChiTietThucDon on ChiTietThucDon.MaDauBep = DauBep.MaDauBep" +
				"\r\njoin ThucDon on ThucDon.SoThucDon = ChiTietThucDon.SoThucDon" +
				"\r\nwhere MONTH(NgayDung) = '" + n1 + "' or MONTH(NgayDung) = '" + n2 + "' or MONTH(NgayDung) = '" + n3 + "'" +
				"\r\ngroup by DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai" +
				"\r\nOrder By DauBep.MaDauBep";
			adapter.SelectCommand = command;
			dataTable2.Clear();
			adapter.Fill(dataTable2);
			dataMonAn.DataSource = dataTable2;
		}
		void loadData5(int n)
		{
			command = connection.CreateCommand();
			command.CommandText = "select DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai, sum(ThanhTien) as TongTien from DauBep\r\njoin TrinhDo on TrinhDo.MaTrinhDo = DauBep.MaTrinhDo" +
				"\r\njoin ChiTietThucDon on ChiTietThucDon.MaDauBep = DauBep.MaDauBep" +
				"\r\njoin ThucDon on ThucDon.SoThucDon = ChiTietThucDon.SoThucDon" +
				"\r\nwhere YEAR(NgayDung) = '" + n + "'" +
				"\r\ngroup by DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai" +
				"\r\nOrder By DauBep.MaDauBep";
			adapter.SelectCommand = command;
			dataTable2.Clear();
			adapter.Fill(dataTable2);
			dataMonAn.DataSource = dataTable2;
		}
		public QuangNam()
        {
            InitializeComponent();
			GetDataAndUpdateTopMonAn();
			GetDataAndUpdateTopDauBep();
		}

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("helllo");
        }

		private void QuangNam_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(sql);
			connection.Open();
			loadData1();
			loadData2();
		}
		
		private void GetDataAndUpdateTopMonAn()
		{
			string connectionString = "Data Source=LAPTOP-7CFRQVA5\\SQLEXPRESS;Initial Catalog=CSDL;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand("Select TenMonAn, SUM(SoLuong) as TongSoluong, GetDate() as NgayThang from ChiTietThucDon inner join MonAn on MonAn.MaMonAn=ChiTietThucDon.MaMonAn Group by ChiTietThucDon.MaMonAn, TenMonAn Order by TongSoluong desc", connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							string datastring = reader["TenMonAn"].ToString();
							string datanum = reader["TongSoluong"].ToString();
							string datatg = reader["NgayThang"].ToString();
							lbltenmonan.Text = datastring;
							lblnummonan.Text = datanum;
							lbltg1.Text = datatg;
						}
					}
				}
			}
		}
		private void GetDataAndUpdateTopDauBep()
		{
			string connectionString = "Data Source=LAPTOP-7CFRQVA5\\SQLEXPRESS;Initial Catalog=CSDL;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand("select DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai, sum(ThanhTien) as TongTien, GetDate() as NgayThang from DauBep\r\njoin TrinhDo on TrinhDo.MaTrinhDo = DauBep.MaTrinhDo" +
				"\r\njoin ChiTietThucDon on ChiTietThucDon.MaDauBep = DauBep.MaDauBep" +
				"\r\njoin ThucDon on ThucDon.SoThucDon = ChiTietThucDon.SoThucDon" +
				"\r\ngroup by DauBep.MaDauBep, TenDauBep, TenTrinhDo, DiaChi, GioiTinh, DienThoai", connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							string datastring = reader["TenDauBep"].ToString();
							string datanum = reader["TongTien"].ToString();
							string datatg = reader["NgayThang"].ToString();
							lbltendaubep.Text = datastring;
							lblnumdoanhthu.Text = datanum;
							lbltg2.Text = datatg;
						}
					}
				}
			}
		}
		private void cmbchontg_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbchontg.Location = new System.Drawing.Point(15, 12);
			if (cmbchontg.SelectedItem.ToString() == "Thang")
			{
				cmbthang.Visible = true;
				cmbquy.Visible = false;
				txtnam.Visible = false;
			}
			else if (cmbchontg.SelectedItem.ToString() == "Quy")
			{
				cmbthang.Visible = false;
				cmbquy.Visible = true;
				txtnam.Visible = false;
			}
			else if (cmbchontg.SelectedItem.ToString() == "Nam")
			{
				cmbthang.Visible = false;
				cmbquy.Visible = false;
				txtnam.Visible = true;
			}
			else
			{
				MessageBox.Show("Bi loi");
			}
		}

		private void cmbthang_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			switch (cmbthang.SelectedItem.ToString())
			{
				case "1":
					loadData3(1);
					break;
				case "2":
					loadData3(2);
					break;
				case "3":
					loadData3(3);
					break;
				case "4":
					loadData3(4);
					break;
				case "5":
					loadData3(5);
					break;
				case "6":
					loadData3(6);
					break;
				case "7":
					loadData3(7);
					break;
				case "8":
					loadData3(8);
					break;
				case "9":
					loadData3(9);
					break;
				case "10":
					loadData3(10);
					break;
				case "11":
					loadData3(11);
					break;
				case "12":
					loadData3(12);
					break;
			}
		}

		private void cmbquy_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			switch (cmbquy.SelectedItem.ToString())
			{
				case "1":
					loadData4(1);
					break;
				case "2":
					loadData4(2);
					break;
				case "3":
					loadData4(3);
					break;
				case "4":
					loadData4(4);
					break;
			}
		}

		private void txtnam_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// Lấy dữ liệu từ TextBox
				string enteredText = txtnam.Text;
				// Thực hiện các thao tác với dữ liệu (ví dụ: hiển thị trong Label)
				int n = int.Parse(enteredText);
				loadData5(n);
				// Ngăn chặn sự kiện "KeyPress" tiếp theo được gửi đến TextBox
				e.Handled = true;
			}
		}

		private void btnexcel1_Click_1(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

			// Tiêu đề
			Excel.Range tieude = (Excel.Range)exSheet.Cells[1, 1];
			tieude.Font.Bold = true;
			tieude.Font.Size = 12;
			tieude.Font.Color = Color.Black;
			tieude.Value = "Tổng tiền thu được của đầu bếp";

			exSheet.get_Range("A3:H3").Font.Bold = true;
			exSheet.get_Range("A3:H3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
			exSheet.get_Range("A3").Value = "STT";
			exSheet.get_Range("B3").Value = "Mã đầu bếp";
			exSheet.get_Range("C3").Value = "Tên đầu bếp";
			exSheet.get_Range("C3").ColumnWidth = 20;
			exSheet.get_Range("D3").Value = "Tên trình độ";
			exSheet.get_Range("D3").ColumnWidth = 10;
			exSheet.get_Range("E3").Value = "Địa chỉ";
			exSheet.get_Range("E3").ColumnWidth = 30;
			exSheet.get_Range("F3").Value = "Giới tính";
			exSheet.get_Range("G3").Value = "Điện thoại";
			exSheet.get_Range("H3").Value = "Tổng tiền";

			for (int i = 0; i < dataTable2.Rows.Count; i++)
			{
				exSheet.get_Range("A" + (i + 4).ToString() + ":H" + (i + 4).ToString()).Font.Bold = false;
				exSheet.get_Range("A" + (i + 4).ToString()).Value = (i + 1).ToString();
				exSheet.get_Range("B" + (i + 4).ToString()).Value = dataTable2.Rows[i]["MaDauBep"].ToString();
				exSheet.get_Range("C" + (i + 4).ToString()).Value = dataTable2.Rows[i]["TenDauBep"].ToString();
				exSheet.get_Range("D" + (i + 4).ToString()).Value = dataTable2.Rows[i]["TenTrinhDo"].ToString();
				exSheet.get_Range("E" + (i + 4).ToString()).Value = dataTable2.Rows[i]["DiaChi"].ToString();
				exSheet.get_Range("F" + (i + 4).ToString()).Value = dataTable2.Rows[i]["GioiTinh"].ToString();
				exSheet.get_Range("G" + (i + 4).ToString()).Value = dataTable2.Rows[i]["DienThoai"].ToString();
				exSheet.get_Range("H" + (i + 4).ToString()).Value = dataTable2.Rows[i]["TongTien"].ToString();
			}

			exSheet.Name = "Doanh thu đầu bếp";

			SaveFileDialog dlgSave = new SaveFileDialog();

			exBook.Activate();
			dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
			dlgSave.FileName = "NewDocument.xls";
			dlgSave.FilterIndex = 1;
			dlgSave.AddExtension = true;
			dlgSave.DefaultExt = ".xls";
			//exBook.SaveAs("D:\\VS2022");

			if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				exBook.SaveAs(dlgSave.FileName.ToString());
			}
		}

		private void btnexcel2_Click_1(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

			// Tiêu đề
			Excel.Range tieude = (Excel.Range)exSheet.Cells[1, 1];
			tieude.Font.Bold = true;
			tieude.Font.Size = 12;
			tieude.Font.Color = Color.Black;
			tieude.Value = "Bảng xếp hạng món ăn";

			exSheet.get_Range("A3:D3").Font.Bold = true;
			exSheet.get_Range("A3:D3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
			exSheet.get_Range("A3").Value = "STT";
			exSheet.get_Range("B3").Value = "Mã món ăn";
			exSheet.get_Range("C3").Value = "Tên món ăn";
			exSheet.get_Range("C3").ColumnWidth = 20;
			exSheet.get_Range("D3").Value = "Tổng số lượng";

			for (int i = 0; i < dataTable1.Rows.Count; i++)
			{
				exSheet.get_Range("A" + (i + 4).ToString() + ":D" + (i + 4).ToString()).Font.Bold = false;
				exSheet.get_Range("A" + (i + 4).ToString()).Value = (i + 1).ToString();
				exSheet.get_Range("B" + (i + 4).ToString()).Value = dataTable1.Rows[i]["MaMonAn"].ToString();
				exSheet.get_Range("C" + (i + 4).ToString()).Value = dataTable1.Rows[i]["TenMonAn"].ToString();
				exSheet.get_Range("D" + (i + 4).ToString()).Value = dataTable1.Rows[i]["TongSoLuong"].ToString();
			}

			exSheet.Name = "Xếp hạng món ăn";

			SaveFileDialog dlgSave = new SaveFileDialog();

			exBook.Activate();
			dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
			dlgSave.FileName = "NewDocument1.xls";
			dlgSave.FilterIndex = 1;
			dlgSave.AddExtension = true;
			dlgSave.DefaultExt = ".xls";
			//exBook.SaveAs("D:\\VS2022");

			if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				exBook.SaveAs(dlgSave.FileName.ToString());
			}
		}
	}
}

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


namespace VehicleService
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-970GESGP\\MSSQLSERVER01;Initial Catalog=VehicleService;Integrated Security=True");
        public int BookingID;

        public Form1()
        {
            InitializeComponent();
 }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getBookings();
        }

        private void getBookings()
        {
           
            SqlCommand cmd = new SqlCommand("SELECT  * FROM Bookings", con);
            DataTable table = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            con.Close();
            bookingsTable.DataSource = table;
        }

        private void resetForm() {
            custNametxt.Clear();
            custNumtxt.Clear();
            datetxt.Value = DateTime.Now;
            notestxt.Clear();
            VehicleModeltxt.Clear();
            VehicleMaketxt.Clear();
            VehicleRegtxt.Clear();
            BookingID = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void insert_Btn_Click(object sender, EventArgs e)
        {

            //check that all fields are filled
            if (custNametxt.Text == string.Empty || custNumtxt.Text == string.Empty || VehicleMaketxt.Text == string.Empty || VehicleModeltxt.Text == string.Empty || VehicleRegtxt.Text == string.Empty)
            {
                MessageBox.Show("Please fill all empty fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                SqlCommand cmd = new SqlCommand("INSERT INTO Bookings VALUES (@CustomerName,@CustomerNumber,@VehicleMake,@VehicleModel,@VehicleRegistration,@BookingDate,@BookingNotes)", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@CustomerName",custNametxt.Text);
                cmd.Parameters.AddWithValue("@CustomerNumber",custNumtxt.Text);
                cmd.Parameters.AddWithValue("@VehicleMake",VehicleMaketxt.Text);
                cmd.Parameters.AddWithValue("@VehicleModel",VehicleModeltxt.Text);
                cmd.Parameters.AddWithValue("@VehicleRegistration",VehicleRegtxt.Text);
                cmd.Parameters.AddWithValue("@BookingDate",datetxt.Value);
                cmd.Parameters.AddWithValue("@BookingNotes",notestxt.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booking successfully made!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getBookings();
                resetForm();
            }
        }

        private void bookingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookingID = Convert.ToInt32(bookingsTable.Rows[0].Cells[0].Value);
            custNametxt.Text = bookingsTable.SelectedRows[0].Cells[1].Value.ToString();
            custNumtxt.Text = bookingsTable.SelectedRows[0].Cells[2].Value.ToString();
            VehicleMaketxt.Text = bookingsTable.SelectedRows[0].Cells[3].Value.ToString();
            VehicleModeltxt.Text = bookingsTable.SelectedRows[0].Cells[4].Value.ToString();
            VehicleRegtxt.Text = bookingsTable.SelectedRows[0].Cells[5].Value.ToString();
            datetxt.Value = (DateTime)bookingsTable.SelectedRows[0].Cells[6].Value;
            notestxt.Text = bookingsTable.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (BookingID > 0) {
                SqlCommand cmd = new SqlCommand("UPDATE Bookings SET CustomerName=@CustomerName,CustomerNumber=@CustomerNumber,VehicleMake=@VehicleMake,VehicleModel=@VehicleModel,VehicleRegistration=@VehicleRegistration,BookingDate=@BookingDate,BookingNotes=@BookingNotes WHERE ID=@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@CustomerName", custNametxt.Text);
                cmd.Parameters.AddWithValue("@CustomerNumber", custNumtxt.Text);
                cmd.Parameters.AddWithValue("@VehicleMake", VehicleMaketxt.Text);
                cmd.Parameters.AddWithValue("@VehicleModel", VehicleModeltxt.Text);
                cmd.Parameters.AddWithValue("@VehicleRegistration", VehicleRegtxt.Text);
                cmd.Parameters.AddWithValue("@BookingDate", datetxt.Value);
                cmd.Parameters.AddWithValue("@BookingNotes", notestxt.Text);
                cmd.Parameters.AddWithValue("@ID", this.BookingID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booking successfully updated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getBookings();
                resetForm();


            }
            else
            {
                MessageBox.Show("Please select a booking", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (BookingID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Bookings WHERE ID=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.BookingID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booking deleted", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getBookings();
                resetForm();

            }
            else {
                MessageBox.Show("Please select a booking", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bookings WHERE CAST(BookingDate AS DATE)=CAST(@BookingDate AS DATE)", con);
            cmd.Parameters.AddWithValue("@BookingDate", filterDate.Value);
            DataTable table = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            con.Close();
            bookingsTable.DataSource = table;
            resetForm();
        }

        private void displayall_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bookings", con);
            DataTable table = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            con.Close();
            bookingsTable.DataSource = table;
            resetForm();
        }
    }
}

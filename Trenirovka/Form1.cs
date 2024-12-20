using MySqlConnector;

namespace Trenirovka
{
    public partial class Form1 : Form
    {
            
        public Form1()
        {
            InitializeComponent();
        }
        List<Smesharik> smeshariks = new List<Smesharik>();
        MySqlCommand cmd;
        int selectedID = -1;

        private void Form1_Load(object sender, EventArgs e)
        {

            Db db = new Db();
            db.openConnection();
            cmd = new MySqlCommand("SELECT id, Name, characteristic FROM namesmeshariki", db.getConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 
                smeshariks.Add(new Smesharik(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                listBox1.Items.Add($"{reader.GetString(1)} {reader.GetString(2)}");
            }
           db.closeConnection();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            db.openConnection();
           
            cmd = new MySqlCommand("UPDATE namesmeshariki SET Name=@newName, characteristic=@newcharacteristic WHERE id = @id", db.getConnection());
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("newName", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("newcharacteristic", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("id", selectedID);
            cmd.ExecuteNonQuery();
            db.closeConnection();



        }
    }
}

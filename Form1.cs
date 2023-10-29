using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace cs2servergui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.cs2_map_file = null;
            Global.cs2_path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\game\\bin\\win64\\cs2.exe";
            label2.Text = Global.cs2_path;
        }
        public static class Global
        {
            public static int game_mode;
            public static int game_type;
            public static string cs2_path;
            public static string cs2_map_file;
            public static string cs2_srv_args;
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.cs2_path == "")
                {
                    MessageBox.Show("Sorry mate it seems like u havent selected a path i cant find ur cs2.exe", "Error cannot find cs2.exe",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                }
                else
                {
                    Global.cs2_srv_args = " -dedicated -insecure " + "+game_mode " + Global.game_mode + " +game_type " + Global.game_type + " +map " + Global.cs2_map_file;
                    Process p = new Process();
                    p.StartInfo.FileName = Global.cs2_path;
                    p.StartInfo.Arguments = Global.cs2_srv_args;
                    p.Start();
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void game_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.game_mode = Convert.ToInt32(game_mode_sel.SelectedIndex.ToString());
        }

        private void game_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.game_type = Convert.ToInt32(game_type_sel.SelectedIndex.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive/Game_Modes",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive";
            openFileDialog1.Filter = "cs2.exe |cs2.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of cs2.exe
                Global.cs2_path = openFileDialog1.FileName;
                label2.Text = Global.cs2_path;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\game\\csgo\\maps";
            openFileDialog2.Filter = "*.vpk |*.vpk|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //Get the path of cs2.exe
                Global.cs2_map_file = '"' + openFileDialog2.FileName + '"'; 
                label3.Text = Global.cs2_map_file;
            }
        }
    }
}
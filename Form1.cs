using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
//using MySql.Data.MySqlClient;

namespace CS_Cafe_Management_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtChickenbu.Text = "0";
            ChickenMeal.Text = "0";
            ChessBurger.Text = "0";
            txtStaber.Text = "0";
            txtMango.Text = "0";
            txtOrange.Text = "0";
            lbldrink.Text = "0";
            lblCost.Text = "0";
            label13.Text = "0";
            label12.Text = "0";
            label14.Text = "0";

            txtChickenbu.Enabled = false;
            ChickenMeal.Enabled = false;
            ChessBurger.Enabled = false;
            txtStaber.Enabled = false;
            txtMango.Enabled = false;
            txtOrange.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //for label
        }


        private void button2_Click(object sender, EventArgs e)
        {
            recieptPlace.Clear();

            recieptPlace.AppendText(Environment.NewLine);

            recieptPlace.AppendText("\t" + "UMT Cafeteria Management System" + Environment.NewLine);
            recieptPlace.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            recieptPlace.AppendText("Chiken Burger \t\t\t" + txtChickenbu.Text + Environment.NewLine);
            recieptPlace.AppendText("Chiken Burger Meal \t\t" + ChickenMeal.Text + Environment.NewLine);
            recieptPlace.AppendText("Chees Burger \t\t\t" + ChessBurger.Text + Environment.NewLine);
            recieptPlace.AppendText("Strawberry Shake \t\t\t" + txtStaber.Text + Environment.NewLine);
            recieptPlace.AppendText("Mango Shake \t\t\t" + txtMango.Text + Environment.NewLine);
            recieptPlace.AppendText("Orange Juice \t\t\t" + txtOrange.Text + Environment.NewLine);

            recieptPlace.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            recieptPlace.AppendText("Sub Total \t\t" + label13.Text + Environment.NewLine);
            recieptPlace.AppendText("Tax \t\t\t" + label12.Text + Environment.NewLine);
            recieptPlace.AppendText("Total \t\t\t" + label14.Text + Environment.NewLine);
            recieptPlace.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            recieptPlace.AppendText(lbltime.Text + "\t\t" + lblDate.Text);
            recieptPlace.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            recieptPlace.AppendText("\t\tTHANK YOU ");
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //for checkBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double chickenBurger, chikenMeal, CheesBurg, strawshake, mangoShake, orangeJuice;

            chickenBurger = 400; chikenMeal = 700; CheesBurg = 600; //prices of Burgers
            strawshake = 150; mangoShake = 150; orangeJuice = 100;

            double ChicBur = Convert.ToDouble(txtChickenbu.Text);
            double ChicMeal = Convert.ToDouble(ChickenMeal.Text);
            double CheeseBur = Convert.ToDouble(ChessBurger.Text);
            double straSha = Convert.ToDouble(txtStaber.Text);
            double manShak = Convert.ToDouble(txtMango.Text);
            double oraShake = Convert.ToDouble(txtOrange.Text);

            Cafe eat_in_Cafe = new Cafe(ChicBur, ChicMeal, CheeseBur, straSha, manShak, oraShake);

            double cost_of_drinks = (straSha * strawshake) + (manShak * mangoShake) + (oraShake * orangeJuice);
            lbldrink.Text = Convert.ToString(cost_of_drinks);

            double cost_of_meal = (ChicBur * chickenBurger) + (ChicMeal * chikenMeal) + (CheeseBur * CheesBurg);
            lblCost.Text = Convert.ToString(cost_of_meal);

            

            label13.Text = Convert.ToString(cost_of_drinks + cost_of_meal);
            label12.Text = Convert.ToString(((cost_of_drinks + cost_of_meal ) *0.16));
            double itax = Convert.ToDouble(label12.Text);
            label14.Text = Convert.ToString(cost_of_drinks + cost_of_meal + itax );


        }



        private void ChickenMeal_TextChanged(object sender, EventArgs e)
        {
            //for text box
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //for panel
        }

        private void ChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenBurger.Checked == true)
            {
                txtChickenbu.Enabled = true;
            }
            if (ChickenBurger.Checked == false)
            {
                txtChickenbu.Enabled = false;
                txtChickenbu.Text = "0";
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //for panel
        }

        private void OrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeJuice.Checked == true)
            {
                txtOrange.Enabled = true;
            }
            if (OrangeJuice.Checked == false)
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void txtChickenbur(object sender, EventArgs e)
        {
            //for text box
        }

        private void ChickenBurgerMeal_CheckedChanged(object sender, EventArgs e)
        {

            if (ChickenBurgerMeal.Checked == true)
            {
                ChickenMeal.Enabled = true;
            }
            if (ChickenBurgerMeal.Checked == false)
            {
                ChickenMeal.Enabled = false;
                ChickenMeal.Text = "0";
            }

        }

        private void CheesBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (CheesBurger.Checked == true)
            {
                ChessBurger.Enabled = true;
            }
            if (CheesBurger.Checked == false)
            {
                ChickenMeal.Enabled = false;
                ChessBurger.Text = "0";
            }
        }
        private void ChessBurger_TextChanged(object sender, EventArgs e)
        {
            //for text box
        }
        private void txtStraBer(object sender, EventArgs e)
        {
            //for text box
        }

        private void txtStrbShake(object sender, EventArgs e)
        {
            txtStaber.Text = "";
            txtStaber.Focus();
        }

        private void txtMangoShak(object sender, EventArgs e)
        {
            txtMango.Text = "";
            txtMango.Focus();
        }

        private void txtOrangeShake(object sender, EventArgs e)
        {
            txtOrange.Text = "";
            txtOrange.Focus();

        }

        private void lblDrinkSold(object sender, EventArgs e)
        {
            //for label
        }

        private void lblCostMeal(object sender, EventArgs e)
        {
            //for label
        }

        private void txtChickenBurger(object sender, EventArgs e)
        {
            txtChickenbu.Text = "";
            txtChickenbu.Focus();
        }

        private void btnReset(object sender, EventArgs e)
        {
            txtChickenbu.Text = "0";
            ChickenMeal.Text = "0";
            ChessBurger.Text = "0";
            txtStaber.Text = "0";
            txtMango.Text = "0";
            txtOrange.Text = "0";
            lbldrink.Text = "0";
            lblCost.Text = "0";


            ChickenBurger.Checked = false;
            ChickenBurgerMeal.Checked = false;
            CheesBurger.Checked = false;
            StrawberryShake.Checked = false;
            MangoShake.Checked = false;
            OrangeJuice.Checked = false;
        }

        private void txtCheesBurger(object sender, EventArgs e)
        {
            ChessBurger.Text = "";
            ChessBurger.Focus();
        }
        private void lblDrink(object sender, EventArgs e)
        {
            //for label
        }
        private void StrawberryShake_CheckedChanged(object sender, EventArgs e)
        {
            if (StrawberryShake.Checked == true)
            {
                txtStaber.Enabled = true;
            }
            if (StrawberryShake.Checked == false)
            {
                txtStaber.Enabled = false;
                txtStaber.Text = "0";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //for panel
        }

        private void lblCost_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void lblService_Click(object sender, EventArgs e)
        {
            //for label
        }

        private void txtChickenMeal(object sender, EventArgs e)
        {
            ChickenMeal.Text = "";
            ChickenMeal.Focus();
        }

        private void MangoShake_CheckedChanged(object sender, EventArgs e)
        {
            if (MangoShake.Checked == true)
            {
                txtMango.Enabled = true;
            }
            if (MangoShake.Checked == false)
            {
                txtMango.Enabled = false;
                txtMango.Text = "0";
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            //for tool
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                //for panel
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e) //using file handeling 
        {
            //SaveFileDialog savefile = new SaveFileDialog();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(saveToolStripButton.Text);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(recieptPlace.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //for print
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            recieptPlace.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            recieptPlace.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            recieptPlace.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            recieptPlace.Paste();
        }
        //public void LoadFile(string path);
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open the text file
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    recieptPlace.Text = filetext;
                    MessageBox.Show(strfilename);
                }
            }


        }

        private void recieptPlace_TextChanged(object sender, EventArgs e)
        {
            //for text
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //for click
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

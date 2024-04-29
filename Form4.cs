using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Boulevard__VB__Auto_Centre
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] package = { "Standard", "Deluxe", "Executive", "Luxury" };
        string[] choice = { "Exterior", "Interior" };
        string[] fragranceList = {"Hawaiian Mist","Baby Powder","Pine","Country Floral", "Pina Colada", "Vanilla" };
        string[] exteriorList = {"Hand Wash", "Hand Wax","Check Engine Fluids","Detail Engine Compartment","Detail Underearriage"};
        string[] interiorList = {"Fragrance","Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat (dashboard and console)",
                                 "Scotehgard"};
        
        //insert values in the comboboxs
        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < package.Length; i++)
            { comboBoxPackage.Items.Add(package[i]); }

            for (int i = 0;i < choice.Length; i++) 
            { comboBoxAppearance.Items.Add(choice[i]); }

            for (int i = 0; i<fragranceList.Length; i++)
            { comboBoxFragrance.Items.Add(fragranceList[i]); }
        }
      
        //populate the listBox
        private void comboBoxFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAppearance.SelectedItem.ToString() == "Exterior")
            {
                listBoxDescription.Items.Clear();
                listBoxDescription.Items.AddRange(exteriorList);

            }
            else if (comboBoxAppearance.SelectedItem.ToString() == "Interior")
            {
                listBoxDescription.Items.Clear();
                listBoxDescription.Items.AddRange(interiorList);

            }
        }

        private void comboBoxPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDescription.Items.Clear();
        }

        //prompt user to select the type of fragrance from combobox if they have selected fragrance from the listBox
        private void listBoxDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDescription.SelectedItem.ToString() == "Fragrance" & comboBoxFragrance.SelectedIndex==-1)
            { MessageBox.Show("Please select your preferred Fragrance", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

       

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document= printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            Font BodyFont = new Font("Arial", 12);
            Font HeadingFont = new Font("Arial", 14, FontStyle.Bold);
            float HeadingLineSpacing = HeadingFont.GetHeight() + 2;
            float BodyLineSpacing = BodyFont.GetHeight() + 2;
           
            //Print out the selected items on the listbox
            if (comboBoxAppearance.SelectedIndex == 0 )
            {
                string result = " ";
                foreach (string itemDescription in listBoxDescription.SelectedItems)
                { result += itemDescription + "\n"; }
                
                string text = "The order is for an " + comboBoxAppearance.SelectedText.ToString().ToUpper() + " wash " +
                    " for the " + comboBoxPackage.SelectedItem.ToString().ToUpper() + " package"
                              + " with the following detailing : " + "\n" + result;
                Font printFont = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Regular);
               

                // Draw the string .
                e.Graphics.DrawString(text, printFont,Brushes.Black, 100, 100);
                

            }
            else if (comboBoxAppearance.SelectedIndex==1 )
            {
                string result = " ";
                foreach (string itemDescription in listBoxDescription.SelectedItems)
                { result += itemDescription + "\n"; }
                string text = "The order is for an " + comboBoxAppearance.SelectedText.ToString().ToUpper() + " wash" +
                   " for the " + comboBoxPackage.SelectedItem.ToString().ToUpper() + " package"
                             + "with the following detailing: " + "\n" + result;
                Font printFont = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Regular);
               

                // Draw the string .
                e.Graphics.DrawString(text, printFont, Brushes.Black, 100, 100);
            }


        }
        private void clearItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxDescription.Items.Clear();
            comboBoxFragrance.SelectedIndex = -1;
            comboBoxPackage.SelectedIndex = -1;
        }
    }
}

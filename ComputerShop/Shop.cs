using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Shop : Form
    {
        int index; //index for the listbox of selected add-ons for item-removal
        public Shop()
        {
            InitializeComponent();
            availableAddons.Items.Add("ExternalHD");
            availableAddons.Items.Add("Keyboard");
            availableAddons.Items.Add("Mouse");
            availableAddons.Items.Add("Screen");
            index = -1;
        }

        /// <summary>
        /// initialize a new computer depending on the selection of the radiobuttons, then loop through the items
        /// in the selected add-ons listbox, and on each iteration wrap the previous object to a new object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            IComputer computer;

            if (laptopButton.Checked)
            {
                computer = new Laptop();
            }
            else if (TablePCButton.Checked)
            {
                computer = new TablePC();
            }
            else
            {
                MessageBox.Show("Choose a computer type!");
                return;
            }

            foreach (string item in selectedAddons.Items)
            {
                switch (item.ToString())
                {
                    case "ExternalHD":
                        computer = new ExternalHD(computer);
                        break;
                    case "Keyboard":
                        computer = new Keyboard(computer);
                        break;
                    case "Mouse":
                        computer = new Mouse(computer);
                        break;
                    case "Screen":
                        computer = new Screen(computer);
                        break;
                }
            }
            MessageBox.Show("Item bought!\nTotal price: " + computer.getPrice() + "\nDescription: " + computer.getDescription());
        }

        /// <summary>
        /// add item to the selected add-ons listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (availableAddons.SelectedItem != null)
            {
                selectedAddons.Items.Add(availableAddons.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// remove an item from the selected add-ons listbox, make index -1 afterwards for safety reasons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                selectedAddons.Items.RemoveAt(selectedAddons.SelectedIndex);
            }
            index = -1;
        }

        private void selectedAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = selectedAddons.SelectedIndex;
        }

        /// <summary>
        /// display the feature of the selected add-on item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void availableAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (availableAddons.SelectedItem.ToString())
            {
                case "ExternalHD":
                    MessageBox.Show("Hard drive size: " + new ExternalHD(null).getHDSize() + " GB");
                    break;
                case "Keyboard":
                    MessageBox.Show("Keyboard type: " + new Keyboard(null).getKbType());
                    break;
                case "Mouse":
                    MessageBox.Show("Mouse type: " + new Mouse(null).getMouseType());
                    break;
                case "Screen":
                    MessageBox.Show("Screen size: " + new ExternalHD(null).getHDSize() + " inches");
                    break;
            }
        }
    }
}

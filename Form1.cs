using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Yad2_Cars
{
    public partial class Form1 : Form
    {
        List<ElectricCar> listElectric = new List<ElectricCar>();
        List<PetrolCar> listPetrol = new List<PetrolCar>();
        List<MotorCycle> listMotorcycle = new List<MotorCycle>();
        List<Vehicle> ShoppingList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            ElectricCar temp1 = new ElectricCar(1000, 2, true, 4, 15400, 2019, "Tesla", 65000, 2);
            ElectricCar temp2 = new ElectricCar(670, 1, false, 4, 40000, 2022, "Hyundai ioniq", 37600, 3);
            listElectric.Add(temp1);
            listElectric.Add(temp2);
            cmbbox_admin_ElCar.Items.Add(temp1._model);
            cmbbox_admin_ElCar.Items.Add(temp2._model);

            PetrolCar temp3 = new PetrolCar(true, false, 4, 70000, 2018, "Volkswagen Polo", 65000, 0);
            PetrolCar temp4 = new PetrolCar(false, true, 4, 256000, 2012, "Toyota camry", 23400, 10);
            listPetrol.Add(temp3);
            listPetrol.Add(temp4);
            cmbx_admin_select_PetCar.Items.Add(temp3._model);
            cmbx_admin_select_PetCar.Items.Add(temp4._model);

            MotorCycle temp5 = new MotorCycle(300, 5000, 2020, "Kawasaki H2R", 120500, 2);
            MotorCycle temp6 = new MotorCycle(250, 7100, 2018, "Yamaha R1M", 87900, 1);
            listMotorcycle.Add(temp5);
            listMotorcycle.Add(temp6);
            cbx_select_motor.Items.Add(temp5._model);
            cbx_select_motor.Items.Add(temp6._model);
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_motorcycle_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            welcome_form.Visible = false;
            pnl_buy_ElCar.Visible = false;
            pnl_buy_PetCar.Visible = false;
            pnl_admin.Visible = false;
            pnl_buy_moto.Visible = true;
            if (listMotorcycle.Count == 0)
            {
                rich_bx_buy_moto_info.Visible = false;
                btn_buy_PetCar_addToShopList.Visible = false;
                MessageBox.Show("Motorcycle inventory is currently empty!");
            }
            else
            {
                foreach (MotorCycle element in listMotorcycle)
                {
                    string str = element._model;
                    lstbx_buy_moto_list.Items.Add(str);
                }
            }
        }

        private void btn_exit1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            welcome_form.Visible = false;
            pnl_buy_ElCar.Visible = false;
            pnl_buy_moto.Visible = false;
            pnl_buy_PetCar.Visible = false;
            pnl_admin.Visible = true;
            pnl_password.Visible = true;
            txt_password.Clear();
        }

        private void btn_exit_buy_moto_Click(object sender, EventArgs e)
        {
            lstbx_buy_moto_list.Items.Clear();
            pnl_buy_moto.Visible = false;
            welcome_form.Visible = true;
        }

        private void btn_shopping_list_Click(object sender, EventArgs e)
        {
            lstbx_shopping_list.Items.Clear();
            pnl_shoppng_list.Visible = true;
            double totalPrice = 0;
            foreach (Vehicle element in ShoppingList)
            {
                if (element != null)
                {
                    string str = element._model;
                    lstbx_shopping_list.Items.Add(str);
                    totalPrice += element._price;
                }
            }
            txtbx_shop_total_price.Text = totalPrice.ToString();
        }

        private void btn_petrolCar_Click(object sender, EventArgs e)
        {
            pnl_buy_moto.Visible = false;
            pnl_buy_ElCar.Visible = false;
            pnl_admin.Visible = false;
            welcome_form.Visible = false;
            pnl_buy_PetCar.Visible = true;

            if (listPetrol.Count == 0)
            {
                rich_bx_buy_PetCar_info.Visible = false;
                btn_buy_PetCar_info.Visible = false;
                MessageBox.Show("Petrol Car inventory is currently empty!");
            }
            else
            {
                foreach (PetrolCar element in listPetrol)
                {
                    string str = element._model;
                    lstbx_buy_PetCar_list.Items.Add(str);
                }
            }
        }

        private void btn_ElectricCar_Click(object sender, EventArgs e)
        {
            pnl_buy_moto.Visible = false;
            pnl_buy_PetCar.Visible = false;
            welcome_form.Visible = false;
            pnl_admin.Visible = false;
            pnl_buy_ElCar.Visible = true;

            if (listElectric.Count == 0)
            {
                rich_bx_buy_ElCar_info.Visible = false;
                btn_buy_ElCar_addToShopList.Visible = false;
                MessageBox.Show("Electric Car inventory is currently empty!");
            }
            else
            {
                foreach (ElectricCar element in listElectric)
                {
                    string str = element._model;
                    lstbx_buy_ElCar_list.Items.Add(str);
                }
            }
        }

        private void btn_exit_buy_PetCar_Click_1(object sender, EventArgs e)
        {
            lstbx_buy_PetCar_list.Items.Clear();
            pnl_buy_PetCar.Visible = false;
            welcome_form.Visible = true;
        }

        private void btn_exit_buy_ElCar_Click_1(object sender, EventArgs e)
        {
            lstbx_buy_ElCar_list.Items.Clear();
            pnl_buy_ElCar.Visible = false;
            welcome_form.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_shop_total_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_shoppng_list.Visible = false;
        }

        private void lstbx_buy_moto_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_buy_moto_list.SelectedItem != null)
            {
                rich_bx_buy_moto_info.Visible = true;

                MotorCycle element;
                element = listMotorcycle.Find(x => x._model.Contains(lstbx_buy_moto_list.SelectedItem.ToString()));
                if (element != null)
                {
                    rich_bx_buy_moto_info.Text = element.GiveInfo();

                    btn_buy_PetCar_addToShopList.Visible = true;
                }
            }
        }

        private void btn_edit_motorcycle_Click(object sender, EventArgs e)
        {
            pnl_admin_motorcycle.Visible = true;
            btn_exit_from_admin_panel.Visible = false;
            pnl_inventory.Hide();
            pnl_password.Hide();
        }

        private void btn_edit_electric_Click(object sender, EventArgs e)
        {
            pnl_admin_ElCar.Visible = true;
            btn_exit_from_admin_panel.Visible = false;
            pnl_admin_motorcycle.Visible = false;
            pnl_inventory.Hide();
            pnl_password.Hide();
        }

        private void btn_edit_petrol_Click(object sender, EventArgs e)
        {
            pnl_admin_PetrolCars.Visible = true;
            btn_exit_from_admin_panel.Visible = false;
            pnl_admin_motorcycle.Visible = false;
            pnl_admin_ElCar.Visible = false;
            pnl_inventory.Hide();
            pnl_password.Hide();
        }

        private void btn_add_motor_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbx_motor_new_hand.Text) || String.IsNullOrEmpty(txtbx_motor_new_mileage.Text) ||
                String.IsNullOrEmpty(txtbx_motor_new_model.Text) || String.IsNullOrEmpty(txtbx_motor_new_price.Text) ||
                String.IsNullOrEmpty(txtbx_motor_new_topspeed.Text) || String.IsNullOrEmpty(txtbx_motor_new_year.Text))

                MessageBox.Show("Fill all fields.");
            else
            {
                bool bo_topspeed = int.TryParse(txtbx_motor_new_topspeed.Text, out int topspeed);
                bool bo_mileage = int.TryParse(txtbx_motor_new_mileage.Text, out int mileage);
                bool bo_year = int.TryParse(txtbx_motor_new_year.Text, out int year);
                bool bo_price = int.TryParse(txtbx_motor_new_price.Text, out int price);
                bool bo_hand = int.TryParse(txtbx_motor_new_hand.Text, out int hand);

                if (bo_topspeed && bo_mileage && bo_year && bo_price && bo_hand)
                {
                    MotorCycle temp = new MotorCycle(topspeed, mileage, year, txtbx_motor_new_model.Text, price, hand);

                    listMotorcycle.Add(temp);
                    cbx_select_motor.Items.Add(temp._model);
                }
                else
                    MessageBox.Show("Error! One of the field was invalid!");
            }
        }

        private void cbx_select_motor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_select_motor.SelectedItem != null)
            {
                MotorCycle element;
                pnl_info_motor.Visible = true;
                element = listMotorcycle.Find(x => x._model.Contains(cbx_select_motor.SelectedItem.ToString()));

                if (element != null)
                {
                    textBox8.Text = element._model;
                    textBox7.Text = element._year.ToString();
                    textBox3.Text = element._mileage.ToString();
                    textBox4.Text = element._hand.ToString();
                    textBox5.Text = element._topSpeed.ToString();
                    textBox6.Text = element._price.ToString();
                }
            }
        }

        private void btn_edit_delete_Click(object sender, EventArgs e)
        {
            MotorCycle element;
            element = listMotorcycle.Find(x => x._model.Contains(cbx_select_motor.SelectedItem.ToString()));
            if (element == null)
                MessageBox.Show("No such motorcycle exists or it might have been deleted.");
            else
            {
                listMotorcycle.Remove(element);
                cbx_select_motor.Items.Remove(element._model);
                MessageBox.Show("Successfully deleted.");
            }
        }

        private void btn_edit_edit_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox6.ReadOnly = false;
            btn_edit_save.Visible = true;
        }

        private void btn_edit_save_Click(object sender, EventArgs e)
        {
            MotorCycle element;
            element = listMotorcycle.Find(x => x._model.Contains(cbx_select_motor.SelectedItem.ToString()));

            bool bo_mileage = int.TryParse(textBox3.Text, out int my_mileage);
            bool bo_hand = int.TryParse(textBox4.Text, out int my_hand);
            bool bo_price = int.TryParse(textBox6.Text, out int my_price);

            if (bo_mileage && bo_hand && bo_price)
            {
                element._mileage = my_mileage;
                element._hand = my_hand;
                element._price = my_price;

                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox6.ReadOnly = true;
                btn_edit_save.Visible = false;
            }
            else
            {
                MessageBox.Show("Error! One of the fields is invalid!");
            }
        }

        private void btn_exit_edit_PetCar_Click(object sender, EventArgs e)
        {
            pnl_admin_motorcycle.Visible = false;
            pnl_inventory.Visible = true;
            btn_exit_from_admin_panel.Visible = true;
        }

        private void btn_admin_PetCar_add_Click(object sender, EventArgs e)
        {
            if (txt_admin_add_PetCar_model.Text.Length == 0 || String.IsNullOrEmpty(txt_admin_add_PetCar_year.Text) ||
                String.IsNullOrEmpty(txt_admin_add_PetCar_mile.Text) || String.IsNullOrEmpty(txt_admin_add_PetCar_hand.Text) ||
                String.IsNullOrEmpty(txt_admin_add_PetCar_sedan.Text) || String.IsNullOrEmpty(txt_admin_add_PetCar_seats.Text) ||
                String.IsNullOrEmpty(txt_admin_add_PetCar_turbo.Text) || String.IsNullOrEmpty(txt_admin_add_PetCar_price.Text))

                MessageBox.Show("Fill all fields.");
            else
            {
                bool bo_mileage = int.TryParse(txt_admin_add_PetCar_mile.Text, out int mileage);
                bool bo_year = int.TryParse(txt_admin_add_PetCar_year.Text, out int year);
                bool bo_price = int.TryParse(txt_admin_add_PetCar_price.Text, out int price);
                bool bo_hand = int.TryParse(txt_admin_add_PetCar_hand.Text, out int hand);
                bool bo_seats = int.TryParse(txt_admin_add_PetCar_seats.Text, out int seats);
                bool bo_sedan = bool.TryParse(txt_admin_add_PetCar_sedan.Text, out bool sedan);
                bool bo_turbo = bool.TryParse(txt_admin_add_PetCar_turbo.Text, out bool turbo);


                if (bo_mileage && bo_year && bo_price && bo_hand && bo_seats && bo_sedan && bo_turbo)
                {
                    PetrolCar temp = new PetrolCar(turbo, sedan, seats, mileage, year, txt_admin_add_PetCar_model.Text, price, hand);
                    listPetrol.Add(temp);
                    cmbx_admin_select_PetCar.Items.Add(temp._model);
                }
                else
                {
                    MessageBox.Show("Error! One of the field was invalid!");
                }
            }
        }

        private void cmbx_admin_select_PetCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (cmbbox_admin_ElCar != null)
            {
                PetrolCar element;
                pnl_admin_PetrolCars.Visible = true;
                element = listPetrol.Find(x => x._model.Contains(cmbx_admin_select_PetCar.SelectedItem.ToString()));

                if (element != null)
                {
                    txt_admin_edit_PetCar_model.Text = element._model;
                    txt_admin_edit_PetCar_year.Text = element._year.ToString();
                    txt_admin_edit_PetCar_mile.Text = element._mileage.ToString();
                    txt_admin_edit_PetCar_hand.Text = element._hand.ToString();
                    txt_admin_edit_PetCar_price.Text = element._price.ToString();
                    txt_admin_edit_PetCar_sedan.Text = element._isSedan.ToString();
                    txt_admin_edit_PetCar_seats.Text = element._numSeats.ToString();
                    txt_admin_edit_PetCar_turbo.Text = element._isTurbo.ToString();
                }
            }
        }

        private void btn_admin_PetCar_delete_Click(object sender, EventArgs e)
        {
            PetrolCar element;
            element = listPetrol.Find(x => x._model.Contains(cmbx_admin_select_PetCar.SelectedItem.ToString()));
            if (element == null)
                MessageBox.Show("No such petrol car exists or it might have been deleted.");
            else
            {
                listPetrol.Remove(element);
                cmbx_admin_select_PetCar.Items.Remove(element._model);
                MessageBox.Show("successfully deleted.");
            }
        }

        private void btn_admin_PetCar_edit_Click(object sender, EventArgs e)
        {
            txt_admin_edit_PetCar_mile.ReadOnly = false;
            txt_admin_edit_PetCar_hand.ReadOnly = false;
            txt_admin_edit_PetCar_price.ReadOnly = false;
            btn_admin_PetCar_save.Visible = true;
        }

        private void btn_admin_PetCar_save_Click(object sender, EventArgs e)
        {
            PetrolCar element;
            element = listPetrol.Find(x => x._model.Contains(cmbx_admin_select_PetCar.SelectedItem.ToString()));

            bool bo_mileage = int.TryParse(txt_admin_edit_PetCar_mile.Text, out int mileage);
            bool bo_hand = int.TryParse(txt_admin_edit_PetCar_hand.Text, out int hand);
            bool bo_price = int.TryParse(txt_admin_edit_PetCar_price.Text, out int price);

            if (bo_mileage && bo_hand && bo_price)
            {
                element._mileage = mileage;
                element._hand = hand;
                element._price = price;
                txt_admin_edit_PetCar_mile.ReadOnly = true;
                txt_admin_edit_PetCar_hand.ReadOnly = true;
                txt_admin_edit_PetCar_price.ReadOnly = true;
                btn_admin_PetCar_save.Visible = false;
            }
            else
                MessageBox.Show("Error! One of the field was invalid!");

        }

        private void btn_exit_admin_PetCar_Click(object sender, EventArgs e)
        {
            pnl_admin_PetrolCars.Visible = false;
            pnl_inventory.Show();
            btn_exit_from_admin_panel.Visible = true;
        }

        private void btn_admin_ElCar_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_admin_add_ElCar_model.Text) || String.IsNullOrEmpty(txt_admin_add_ElCar_year.Text) ||
               String.IsNullOrEmpty(txt_admin_add_ElCar_mile.Text) || String.IsNullOrEmpty(txt_admin_add_ElCar_hand.Text) ||
               String.IsNullOrEmpty(txt_admin_add_ElCar_sedan.Text) || String.IsNullOrEmpty(txt_admin_add_ElCar_seats.Text) ||
               String.IsNullOrEmpty(txt_admin_add_ElCar_range.Text) || String.IsNullOrEmpty(txt_admin_add_ElCar_charge.Text) ||
               String.IsNullOrEmpty(txt_admin_add_ElCar_price.Text))

                MessageBox.Show("Fill all fields.");
            else
            {
                bool bo_Mileage = int.TryParse(txt_admin_add_ElCar_mile.Text, out int mileage);
                bool bo_Year = int.TryParse(txt_admin_add_ElCar_year.Text, out int year);
                bool bo_Price = int.TryParse(txt_admin_add_ElCar_price.Text, out int price);
                bool bo_Hand = int.TryParse(txt_admin_add_ElCar_hand.Text, out int hand);
                bool bo_Seats = int.TryParse(txt_admin_add_ElCar_seats.Text, out int seats);
                bool bo_Range = int.TryParse(txt_admin_add_ElCar_range.Text, out int range);
                bool bo_Charge = double.TryParse(txt_admin_add_ElCar_charge.Text, out double charge);
                bool bo_Sedan = bool.TryParse(txt_admin_add_ElCar_sedan.Text, out bool sedan);

                if (bo_Mileage && bo_Year && bo_Price && bo_Hand && bo_Seats && bo_Range && bo_Charge && bo_Sedan)
                {
                    ElectricCar temp = new ElectricCar(range, charge, sedan, seats, mileage, year, txt_admin_add_ElCar_model.Text, price, hand);

                    listElectric.Add(temp);
                    cmbbox_admin_ElCar.Items.Add(temp._model);
                }
                else
                {
                    MessageBox.Show("Error! One of the field was invalid!");
                }
            }
        }

        private void cmbbox_admin_ElCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_admin_ElCar != null)
            {
                ElectricCar element;
                pnl_admin_ElCar_edit.Visible = true;
                element = listElectric.Find(x => x._model.Contains(cmbbox_admin_ElCar.SelectedItem.ToString()));

                if (element != null)
                {
                    txt_admin_edit_ElCar_model.Text = element._model;
                    txt_admin_edit_ElCar_year.Text = element._year.ToString();
                    txt_admin_edit_ElCar_mile.Text = element._mileage.ToString();
                    txt_admin_edit_ElCar_hand.Text = element._hand.ToString();
                    txt_admin_edit_ElCar_price.Text = element._price.ToString();
                    txt_admin_edit_ElCar_sedan.Text = element._isSedan.ToString();
                    txt_admin_edit_ElCar_seats.Text = element._numSeats.ToString();
                    txt_admin_edit_ElCar_range.Text = element._range.ToString();
                    txt_admin_edit_ElCar_charge.Text = element._chargeTime.ToString();
                }
            }
        }

        private void btn_admin_ElCar_delete_Click(object sender, EventArgs e)
        {
            ElectricCar element;
            element = listElectric.Find(x => x._model.Contains(cmbbox_admin_ElCar.SelectedItem.ToString()));
            if (element == null)
                MessageBox.Show("No such electric car exists or it might have been deleted.");
            else
            {
                listElectric.Remove(element);
                cmbbox_admin_ElCar.Items.Remove(element._model);
                MessageBox.Show("successfully deleted.");
            }
        }

        private void btn_admin_ElCar_edit_Click(object sender, EventArgs e)
        {
            txt_admin_edit_ElCar_mile.ReadOnly = false;
            txt_admin_edit_ElCar_hand.ReadOnly = false;
            txt_admin_edit_ElCar_price.ReadOnly = false;
            btn_admin_ElCar_save.Visible = true;
        }

        private void btn_admin_ElCar_save_Click(object sender, EventArgs e)
        {
            ElectricCar element;
            element = listElectric.Find(x => x._model.Contains(cmbbox_admin_ElCar.SelectedItem.ToString()));

            bool new_bo_mileage = int.TryParse(txt_admin_edit_ElCar_mile.Text, out int mile);
            bool new_bo_hand = int.TryParse(txt_admin_edit_ElCar_hand.Text, out int hand);
            bool new_bo_price = int.TryParse(txt_admin_edit_ElCar_price.Text, out int price);

            if (new_bo_mileage && new_bo_hand && new_bo_price)
            {
                element._mileage = mile;
                element._hand = hand;
                element._price = price;

                txt_admin_edit_ElCar_mile.ReadOnly = true;
                txt_admin_edit_ElCar_hand.ReadOnly = true;
                txt_admin_edit_ElCar_price.ReadOnly = true;
                btn_admin_ElCar_save.Visible = false;
            }
            else
            {
                MessageBox.Show("Error! One of the fields is invalid!");
            }

        }

        private void btn_exit_admin_ElCar_Click(object sender, EventArgs e)
        {
            pnl_admin_motorcycle.Visible = false;
            pnl_admin_ElCar.Visible = false;
            pnl_inventory.Visible = true;
            btn_exit_from_admin_panel.Visible = true;
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string password = "0000";
            if (txt_password.Text == password)
            {
                pnl_inventory.Show();
                pnl_password.Visible = false;
                pnl_admin_motorcycle.Visible = false;
                pnl_admin_ElCar.Visible = false;
            }
            else
                MessageBox.Show("Wrong password, try again.");

        }

        private void btn_exit_from_admin_panel_Click(object sender, EventArgs e)
        {
            pnl_admin.Visible = false;
            welcome_form.Visible = true;
            pnl_password.Visible = false;
            pnl_admin_motorcycle.Visible = false;
            pnl_admin_ElCar.Visible = false;
            pnl_admin_PetrolCars.Visible = false;
            pnl_buy_PetCar.Visible = false;
            pnl_buy_ElCar.Visible = false;
            pnl_buy_moto.Visible = false;
            pnl_inventory.Visible = false;
        }

        private void lstbx_buy_PetCar_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_buy_PetCar_list.SelectedItem != null)
            {
                rich_bx_buy_PetCar_info.Visible = true;
                PetrolCar element;
                element = listPetrol.Find(x => x._model.Contains(lstbx_buy_PetCar_list.SelectedItem.ToString()));

                if (element != null)
                {
                    rich_bx_buy_PetCar_info.Text = element.GiveInfo();
                    btn_buy_PetCar_info.Visible = true;
                }
            }
        }

        private void lstbx_buy_ElCar_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_buy_ElCar_list.SelectedItem != null)
            {
                rich_bx_buy_ElCar_info.Visible = true;
                ElectricCar element;
                element = listElectric.Find(x => x._model.Contains(lstbx_buy_ElCar_list.SelectedItem.ToString()));
                if (element != null)
                {
                    rich_bx_buy_ElCar_info.Text = element.GiveInfo();

                    btn_buy_ElCar_addToShopList.Visible = true;
                }
            }
        }

        private void btn_buy_PetCar_info_Click(object sender, EventArgs e)
        {
            PetrolCar element;
            element = listPetrol.Find(x => x._model.Contains(lstbx_buy_PetCar_list.SelectedItem.ToString()));
            ShoppingList.Add(element);
            listPetrol.Remove(element);
            lstbx_buy_PetCar_list.Refresh();
        }

        private void btn_buy_moto_addToShopList_Click(object sender, EventArgs e)
        {
            MotorCycle element;
            element = listMotorcycle.Find(x => x._model.Contains(lstbx_buy_moto_list.SelectedItem.ToString()));
            ShoppingList.Add(element);
            listMotorcycle.Remove(element);
            lstbx_buy_moto_list.Refresh();
        }

        private void btn_buy_ElCar_addToShopList_Click(object sender, EventArgs e)
        {
            ElectricCar element;
            element = listElectric.Find(x => x._model.Contains(lstbx_buy_ElCar_list.SelectedItem.ToString()));
            ShoppingList.Add(element);
            listElectric.Remove(element);
            lstbx_buy_ElCar_list.Refresh();
        }

        private void rich_bx_buy_ElCar_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void rich_bx_buy_moto_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_shop_list_buy_Click(object sender, EventArgs e)
        {
            ShoppingList.Clear();
            MessageBox.Show("Thank you for the purchase!");
            lstbx_shopping_list.Items.Clear();
            txtbx_shop_total_price.Clear();

            foreach (Vehicle element in ShoppingList)
            {
                if (element.Equals(typeof(MotorCycle)))
                    listMotorcycle.Remove((MotorCycle)element);

                else if (element.Equals(typeof(ElectricCar)))
                    listElectric.Remove((ElectricCar)element);

                else
                    listPetrol.Remove((PetrolCar)element);
            }
        }

        private void btn_welcome_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "cars files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, listElectric);
                    formatter.Serialize(stream, listPetrol);
                    formatter.Serialize(stream, listMotorcycle);
                    formatter.Serialize(stream, ShoppingList);
                }
            }
        }

        private void btn_welcome_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "cars files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                listElectric = (List<ElectricCar>)binaryFormatter.Deserialize(stream);
                listPetrol = (List<PetrolCar>)binaryFormatter.Deserialize(stream);
                listMotorcycle = (List<MotorCycle>)binaryFormatter.Deserialize(stream);
                ShoppingList = (List<Vehicle>)binaryFormatter.Deserialize(stream);
            }
        }

        private void txt_motor_panel_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_admin_motorcycle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
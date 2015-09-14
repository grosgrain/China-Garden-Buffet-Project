using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace ChinaGardenLunch
{
    public partial class Form1 : Form
    {
        public static string letter;
        public static double numbert = 0;
        public static int numberc = 0;
        public static int numberd = 0;
        public static int yar2 = 0;
        public static int yar3 = 0;
        public static int yar4 = 0;
        public static int yar5 = 0;
        public static int yar6 = 0;
        public static int yar7 = 0;
        public static int yar8 = 0;
        public static int yar9 = 0;
        public static int yar10 = 0;
        public static int yartemp = 0;
        public static double tota = 0;
        public static double goltotal = 0;
        public static double chkNumber = 0;
        public static string table;
        public static string customers;
        public static string drinks;
        int i = 0;
        public static int beer1 = 0;
        public static int beer2 = 0;
        public static int beer3 = 0;
        public static int beer4 = 0;
        public static int beer5 = 0;
        public static int beer6 = 0;
        public static int beer7 = 0;
        public static int beer8 = 0;
        public static int beer9 = 0;
        public static int beer10 = 0;
        public static int beer11 = 0;
        public static int beer12 = 0;
        public static int beer13 = 0;
        public static int beer14 = 0;
        public static int beer15 = 0;
        public static int beer16 = 0;
        public static int beer17 = 0;
        public static int beer18 = 0;
        public static int beer19 = 0;
        public static int beertemp = 0;
        public static string check;
        public static bool submitClick = false;
        public static double lunchprice;
        public static double lunchdrinkprice;
        public static double chilprice2;
        public static double chilprice3;
        public static double chilprice4;
        public static double chilprice5;
        public static double chilprice6;
        public static double chilprice7;
        public static double chilprice8;
        public static double chilprice9;
        public static double chilprice10;
        public static double beerprice1;
        public static double beerprice2;
        public static double beerprice3;
        public static double beerprice4;
        public static double beerprice5;
        public static double beerprice6;
        public static double beerprice7;
        public static double beerprice8;
        public static double beerprice9;
        public static double beerprice10;
        public static double beerprice11;
        public static double beerprice12;
        public static double beerprice13;
        public static double beerprice14;
        public static double beerprice15;
        public static double beerprice16;
        public static double beerprice17;
        public static double beerprice18;
        public static double beerprice19;


        public Form1()
        {
            InitializeComponent();

            FileStream f = new FileStream("C:/text/lunchprice.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(f);

            lunchprice = Convert.ToDouble(reader.ReadLine());

            reader.Close();
            f.Close();

            FileStream f1 = new FileStream("C:/text/lunchdrinkprice.txt", FileMode.OpenOrCreate);
            StreamReader reader1 = new StreamReader(f1);

            lunchdrinkprice = Convert.ToDouble(reader1.ReadLine());

            reader1.Close();
            f1.Close();

            FileStream f2 = new FileStream("C:/text/chil2price.txt", FileMode.OpenOrCreate);
            StreamReader reader2 = new StreamReader(f2);

            chilprice2 = Convert.ToDouble(reader2.ReadLine());

            reader2.Close();
            f2.Close();



            FileStream f3 = new FileStream("C:/text/chil3price.txt", FileMode.OpenOrCreate);
            StreamReader reader3 = new StreamReader(f3);

            chilprice3 = Convert.ToDouble(reader3.ReadLine());

            reader3.Close();
            f3.Close();




            FileStream f4 = new FileStream("C:/text/chil4price.txt", FileMode.OpenOrCreate);
            StreamReader reader4 = new StreamReader(f4);

            chilprice4 = Convert.ToDouble(reader4.ReadLine());

            reader4.Close();
            f4.Close();





            FileStream f5 = new FileStream("C:/text/chil5price.txt", FileMode.OpenOrCreate);
            StreamReader reader5 = new StreamReader(f5);

            chilprice5 = Convert.ToDouble(reader5.ReadLine());

            reader5.Close();
            f5.Close();





            FileStream f6 = new FileStream("C:/text/chil6price.txt", FileMode.OpenOrCreate);
            StreamReader reader6 = new StreamReader(f6);

            chilprice6 = Convert.ToDouble(reader6.ReadLine());

            reader6.Close();
            f6.Close();





            FileStream f7 = new FileStream("C:/text/chil7price.txt", FileMode.OpenOrCreate);
            StreamReader reader7 = new StreamReader(f7);

            chilprice7 = Convert.ToDouble(reader7.ReadLine());

            reader7.Close();
            f7.Close();




            FileStream f8 = new FileStream("C:/text/chil8price.txt", FileMode.OpenOrCreate);
            StreamReader reader8 = new StreamReader(f8);

            chilprice8 = Convert.ToDouble(reader8.ReadLine());

            reader8.Close();
            f8.Close();





            FileStream f9 = new FileStream("C:/text/chil9price.txt", FileMode.OpenOrCreate);
            StreamReader reader9 = new StreamReader(f9);

            chilprice9 = Convert.ToDouble(reader9.ReadLine());

            reader9.Close();
            f9.Close();




            FileStream f10 = new FileStream("C:/text/chil10price.txt", FileMode.OpenOrCreate);
            StreamReader reader10 = new StreamReader(f10);

            chilprice10 = Convert.ToDouble(reader10.ReadLine());

            reader10.Close();
            f10.Close();

            FileStream f11 = new FileStream("C:/text/beer1price.txt", FileMode.OpenOrCreate);
            StreamReader reader11 = new StreamReader(f11);

            beerprice1 = Convert.ToDouble(reader11.ReadLine());

            reader11.Close();
            f11.Close();

            FileStream f12 = new FileStream("C:/text/beer2price.txt", FileMode.OpenOrCreate);
            StreamReader reader12 = new StreamReader(f12);

            beerprice2 = Convert.ToDouble(reader12.ReadLine());

            reader12.Close();
            f12.Close();

            FileStream f13 = new FileStream("C:/text/beer3price.txt", FileMode.OpenOrCreate);
            StreamReader reader13 = new StreamReader(f13);

            beerprice3 = Convert.ToDouble(reader13.ReadLine());

            reader13.Close();
            f13.Close();

            FileStream f14 = new FileStream("C:/text/beer4price.txt", FileMode.OpenOrCreate);
            StreamReader reader14 = new StreamReader(f14);

            beerprice4 = Convert.ToDouble(reader14.ReadLine());

            reader14.Close();
            f14.Close();

            FileStream f15 = new FileStream("C:/text/beer5price.txt", FileMode.OpenOrCreate);
            StreamReader reader15 = new StreamReader(f15);

            beerprice5 = Convert.ToDouble(reader15.ReadLine());

            reader15.Close();
            f15.Close();

            FileStream f16 = new FileStream("C:/text/beer6price.txt", FileMode.OpenOrCreate);
            StreamReader reader16 = new StreamReader(f16);

            beerprice6 = Convert.ToDouble(reader16.ReadLine());

            reader16.Close();
            f16.Close();

            FileStream f17 = new FileStream("C:/text/beer7price.txt", FileMode.OpenOrCreate);
            StreamReader reader17 = new StreamReader(f17);

            beerprice7 = Convert.ToDouble(reader17.ReadLine());

            reader17.Close();
            f17.Close();


            FileStream f18 = new FileStream("C:/text/beer8price.txt", FileMode.OpenOrCreate);
            StreamReader reader18 = new StreamReader(f18);

            beerprice8 = Convert.ToDouble(reader18.ReadLine());

            reader18.Close();
            f18.Close();

            FileStream f19 = new FileStream("C:/text/beer9price.txt", FileMode.OpenOrCreate);
            StreamReader reader19 = new StreamReader(f19);

            beerprice9 = Convert.ToDouble(reader19.ReadLine());

            reader19.Close();
            f19.Close();

            FileStream f20 = new FileStream("C:/text/beer10price.txt", FileMode.OpenOrCreate);
            StreamReader reader20 = new StreamReader(f20);

            beerprice10 = Convert.ToDouble(reader20.ReadLine());

            reader20.Close();
            f20.Close();

            FileStream f21 = new FileStream("C:/text/beer11price.txt", FileMode.OpenOrCreate);
            StreamReader reader21 = new StreamReader(f21);

            beerprice11 = Convert.ToDouble(reader21.ReadLine());

            reader21.Close();
            f21.Close();


            FileStream f22 = new FileStream("C:/text/beer12price.txt", FileMode.OpenOrCreate);
            StreamReader reader22 = new StreamReader(f22);

            beerprice12 = Convert.ToDouble(reader22.ReadLine());

            reader22.Close();
            f22.Close();

            FileStream f23 = new FileStream("C:/text/beer13price.txt", FileMode.OpenOrCreate);
            StreamReader reader23 = new StreamReader(f23);

            beerprice13 = Convert.ToDouble(reader23.ReadLine());

            reader23.Close();
            f23.Close();

            FileStream f24 = new FileStream("C:/text/beer14price.txt", FileMode.OpenOrCreate);
            StreamReader reader24 = new StreamReader(f24);

            beerprice14 = Convert.ToDouble(reader24.ReadLine());

            reader24.Close();
            f24.Close();

            FileStream f25 = new FileStream("C:/text/beer15price.txt", FileMode.OpenOrCreate);
            StreamReader reader25 = new StreamReader(f25);

            beerprice15 = Convert.ToDouble(reader25.ReadLine());

            reader25.Close();
            f25.Close();

            FileStream f26 = new FileStream("C:/text/beer16price.txt", FileMode.OpenOrCreate);
            StreamReader reader26 = new StreamReader(f26);

            beerprice16 = Convert.ToDouble(reader26.ReadLine());

            reader26.Close();
            f26.Close();


            FileStream f27 = new FileStream("C:/text/beer17price.txt", FileMode.OpenOrCreate);
            StreamReader reader27 = new StreamReader(f27);

            beerprice17 = Convert.ToDouble(reader27.ReadLine());

            reader27.Close();
            f27.Close();


            FileStream f28 = new FileStream("C:/text/beer18price.txt", FileMode.OpenOrCreate);
            StreamReader reader28 = new StreamReader(f28);

            beerprice18 = Convert.ToDouble(reader28.ReadLine());

            reader28.Close();
            f28.Close();


            FileStream f29 = new FileStream("C:/text/beer19price.txt", FileMode.OpenOrCreate);
            StreamReader reader29 = new StreamReader(f29);

            beerprice19 = Convert.ToDouble(reader29.ReadLine());

            reader29.Close();
            f29.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTable.Focus();
            txtTable.Text = "0";
            txtCustomers.Text = "0";
            txtDrinks.Text = "0";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitClick = true;
            double customerPrice, drinkPrice, childrenPrice, beerPrice, price, tax, total;
            table = txtTable.Text;
            customers = txtCustomers.Text;
            drinks = txtDrinks.Text;
            numberc = Int16.Parse(customers);
            numberd = Int16.Parse(drinks);
            customerPrice = lunchprice * numberc;
            drinkPrice = lunchdrinkprice * numberd;
            childrenPrice = chilprice2 * yar2 + chilprice3 * yar3 + chilprice4 * yar4 + chilprice5 * yar5 + chilprice6 * yar6 + chilprice7 * yar7 + chilprice8 * yar8 + chilprice9 * yar9 + chilprice10 * yar10;
            beerPrice = beerprice1 * beer1 + beerprice2 * beer2 + beerprice3 * beer3 + beerprice4 * beer4 + beerprice5 * beer5 + beerprice6 * beer6 + beerprice7 * beer7 + beerprice8 * beer8 + beerprice9 * beer9 + beerprice10 * beer10 + beerprice11 * beer11 + beerprice12 * beer12 + beerprice13 * beer13 + beerprice14 * beer14 + beerprice15 * beer15 + beerprice16 * beer16 + beerprice17 * beer17 + beerprice18 * beer18 + beerprice19 * beer19;
            price = customerPrice + drinkPrice + childrenPrice + beerPrice;
            tax = price * 0.0725;
            total = price + tax;
            price = Math.Round(price, 2);
            tax = Math.Round(tax, 2);
            total = Math.Round(total, 2);
            customerPrice = Math.Round(customerPrice, 2);
            drinkPrice = Math.Round(drinkPrice, 2);
            childrenPrice = Math.Round(childrenPrice, 2);
            beerPrice = Math.Round(beerPrice, 2);
            goltotal = total;
            table = Convert.ToString(txtTable.Text);
            customers = Convert.ToString(txtCustomers.Text);
            drinks = Convert.ToString(txtDrinks.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add(lblTable.Text.PadRight(40) + txtTable.Text);
            listBox1.Items.Add(lblAdults.Text.PadRight(42) + txtCustomers.Text.PadRight(13) + customerPrice.ToString("C2"));
            listBox1.Items.Add(lblDrinks.Text.PadRight(42) + txtDrinks.Text.PadRight(13) + drinkPrice.ToString("C2"));
            if (yar2 != 0)
            { listBox1.Items.Add("2 Years Old Child".PadRight(25) + "".PadRight(9) + (yar2) + "".PadRight(13) + (chilprice2 * yar2).ToString("C2")); }
            if (yar3 != 0)
            { listBox1.Items.Add("3 Years Old Child".PadRight(25) + "".PadRight(9) + (yar3) + "".PadRight(13) + (chilprice3 * yar3).ToString("C2")); }
            if (yar4 != 0)
            { listBox1.Items.Add("4 Years Old Child".PadRight(25) + "".PadRight(9) + (yar4) + "".PadRight(13) + (chilprice4 * yar4).ToString("C2")); }
            if (yar5 != 0)
            { listBox1.Items.Add("5 Years Old Child".PadRight(25) + "".PadRight(9) + (yar5) + "".PadRight(13) + (chilprice5 * yar5).ToString("C2")); }
            if (yar6 != 0)
            { listBox1.Items.Add("6 Years Old Child".PadRight(25) + "".PadRight(9) + (yar6) + "".PadRight(13) + (chilprice6 * yar6).ToString("C2")); }
            if (yar7 != 0)
            { listBox1.Items.Add("7 Years Old Child".PadRight(25) + "".PadRight(9) + (yar7) + "".PadRight(13) + (chilprice7 * yar7).ToString("C2")); }
            if (yar8 != 0)
            { listBox1.Items.Add("8 Years Old Child".PadRight(25) + "".PadRight(9) + (yar8) + "".PadRight(13) + (chilprice8 * yar8).ToString("C2")); }
            if (yar9 != 0)
            { listBox1.Items.Add("9 Years Old Child".PadRight(25) + "".PadRight(9) + (yar9) + "".PadRight(13) + (chilprice9 * yar9).ToString("C2")); }
            if (yar10 != 0)
            { listBox1.Items.Add("10 Years Old Child".PadRight(24) + "".PadRight(9) + (yar10) + "".PadRight(13) + (chilprice10 * yar10).ToString("C2")); }

            if (beer1 != 0)
            { listBox1.Items.Add("Budweiser".PadRight(29) + "".PadRight(9) + (beer1) + "".PadRight(13) + (beerprice1 * beer1).ToString("C2")); }
            if (beer2 != 0)
            { listBox1.Items.Add("Bud Light".PadRight(31) + "".PadRight(9) + (beer2) + "".PadRight(13) + (beerprice2 * beer2).ToString("C2")); }
            if (beer3 != 0)
            { listBox1.Items.Add("Miller Lite".PadRight(32) + "".PadRight(9) + (beer3) + "".PadRight(13) + (beerprice3 * beer3).ToString("C2")); }
            if (beer4 != 0)
            { listBox1.Items.Add("Coors Light".PadRight(29) + "".PadRight(9) + (beer4) + "".PadRight(13) + (beerprice4 * beer4).ToString("C2")); }
            if (beer5 != 0)
            { listBox1.Items.Add("Michelob".PadRight(30) + "".PadRight(9) + (beer5) + "".PadRight(13) + (beerprice5 * beer5).ToString("C2")); }
            if (beer6 != 0)
            { listBox1.Items.Add("Tsingtao, China".PadRight(26) + "".PadRight(9) + (beer6) + "".PadRight(13) + (beerprice6 * beer6).ToString("C2")); }
            if (beer7 != 0)
            { listBox1.Items.Add("Heineken, Holland".PadRight(23) + "".PadRight(9) + (beer7) + "".PadRight(13) + (beerprice7 * beer7).ToString("C2")); }
            if (beer8 != 0)
            { listBox1.Items.Add("Sapporo, Japan".PadRight(24) + "".PadRight(9) + (beer8) + "".PadRight(13) + (beerprice8 * beer8).ToString("C2")); }
            if (beer9 != 0)
            { listBox1.Items.Add("Corona, Mexico".PadRight(25) + "".PadRight(9) + (beer9) + "".PadRight(13) + (beerprice9 * beer9).ToString("C2")); }
            if (beer10 != 0)
            { listBox1.Items.Add("Ten High".PadRight(30) + "".PadRight(9) + (beer10) + "".PadRight(13) + (beerprice10 * beer10).ToString("C2")); }
            if (beer11 != 0)
            { listBox1.Items.Add("Oolong Tea (per cup)".PadRight(21) + "".PadRight(9) + (beer11) + "".PadRight(13) + (beerprice11 * beer11).ToString("C2")); }
            if (beer12 != 0)
            { listBox1.Items.Add("Orange Jucie (glass)".PadRight(22) + "".PadRight(9) + (beer12) + "".PadRight(13) + (beerprice12 * beer12).ToString("C2")); }
            if (beer13 != 0)
            { listBox1.Items.Add("Apple Jucie (glass)".PadRight(24) + "".PadRight(9) + (beer13) + "".PadRight(13) + (beerprice13 * beer13).ToString("C2")); }
            if (beer14 != 0)
            { listBox1.Items.Add("Milk (glass)".PadRight(30) + "".PadRight(9) + (beer14) + "".PadRight(13) + (beerprice14 * beer14).ToString("C2")); }
            if (beer15 != 0)
            { listBox1.Items.Add("Chardonnay".PadRight(33) + "".PadRight(4) + (beer15) + "".PadRight(13) + (beerprice15 * beer15).ToString("C2")); }
            if (beer16 != 0)
            { listBox1.Items.Add("Zinfandel".PadRight(32) + "".PadRight(9) + (beer16) + "".PadRight(13) + (beerprice16 * beer16).ToString("C2")); }
            if (beer17 != 0)
            { listBox1.Items.Add("Merlot".PadRight(34) + "".PadRight(9) + (beer17) + "".PadRight(13) + (beerprice17 * beer17).ToString("C2")); }
            if (beer18 != 0)
            { listBox1.Items.Add("Plum Wine".PadRight(30) + "".PadRight(9) + (beer18) + "".PadRight(13) + (beerprice18 * beer18).ToString("C2")); }
            if (beer19 != 0)
            { listBox1.Items.Add("Sake".PadRight(34) + "".PadRight(9) + (beer19) + "".PadRight(13) + (beerprice19 * beer19).ToString("C2")); }

            listBox1.Items.Add(lblPrice.Text.PadRight(52) + price.ToString("C2"));
            listBox1.Items.Add(lblTaxes.Text.PadRight(53) + tax.ToString("C2"));
            listBox1.Items.Add(lblTotal.Text.PadRight(55) + total.ToString("C2"));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (numbert > 1)
            {
                numbert -= 1;

                if (txtTable.Text != null)
                { txtTable.Text = Convert.ToString(letter + numbert); }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numbert += 1;

            if (txtTable.Text != null)
            {
                txtTable.Text = Convert.ToString(letter + numbert);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            letter = btnA.Text;
            txtTable.Text = btnA.Text;
            txtTable.Focus();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            letter = btnB.Text;
            txtTable.Text = btnB.Text;
            txtTable.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            letter = btnC.Text;
            txtTable.Text = btnC.Text;
            txtTable.Focus();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            letter = btnD.Text;
            txtTable.Text = btnD.Text;
            txtTable.Focus();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            letter = btnE.Text;
            txtTable.Text = btnE.Text;
            txtTable.Focus();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            letter = btnF.Text;
            txtTable.Text = btnF.Text;
            txtTable.Focus();

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            letter = btnG.Text;
            txtTable.Text = btnG.Text;
            txtTable.Focus();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            letter = btnH.Text;
            txtTable.Text = btnH.Text;
            txtTable.Focus();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            letter = btnS.Text;
            txtTable.Text = btnS.Text;
            txtTable.Focus();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            letter = btnP.Text;
            txtTable.Text = btnP.Text;
            txtTable.Focus();
        }

        private void btnMinus0_Click(object sender, EventArgs e)
        {
            if (txtCustomers.Text != "0")
            {
                if (txtCustomers.Text != null)
                {
                    customers = txtCustomers.Text;
                    txtCustomers.Text = Convert.ToString(Int16.Parse(customers) - 1);
                }
            }
        }

        private void btnPlus0_Click(object sender, EventArgs e)
        {

            customers = txtCustomers.Text;
            txtCustomers.Text = Convert.ToString(Int32.Parse(customers) + 1);

        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if (txtDrinks.Text != "0")
            {
                if (txtDrinks.Text != null)
                {
                    drinks = txtDrinks.Text;
                    txtDrinks.Text = Convert.ToString(Int16.Parse(drinks) - 1);
                }
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {

            drinks = txtDrinks.Text;
            txtDrinks.Text = Convert.ToString(int.Parse(drinks) + 1);

        }

        private void btn2yar_Click(object sender, EventArgs e)
        {
            yartemp = yar2;
            {
                if (this.listChil.Items.Contains("2 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("2 years old    x" + (yartemp));
                    yar2 += 1;
                    listChil.Items.Add("2 years old    x" + yar2);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar2 += 1;
                    listChil.Items.Add("2 years old    x" + yar2);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn3yar_Click(object sender, EventArgs e)
        {
            yartemp = yar3;
            {
                if (this.listChil.Items.Contains("3 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("3 years old    x" + (yartemp));
                    yar3 += 1;
                    listChil.Items.Add("3 years old    x" + yar3);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar3 += 1;
                    listChil.Items.Add("3 years old    x" + yar3);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn4yar_Click(object sender, EventArgs e)
        {
            yartemp = yar4;
            {
                if (this.listChil.Items.Contains("4 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("4 years old    x" + (yartemp));
                    yar4 += 1;
                    listChil.Items.Add("4 years old    x" + yar4);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar4 += 1;
                    listChil.Items.Add("4 years old    x" + yar4);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn5yar_Click(object sender, EventArgs e)
        {
            yartemp = yar5;
            {
                if (this.listChil.Items.Contains("5 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("5 years old    x" + (yartemp));
                    yar5 += 1;
                    listChil.Items.Add("5 years old    x" + yar5);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar5 += 1;
                    listChil.Items.Add("5 years old    x" + yar5);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn6ar_Click(object sender, EventArgs e)
        {
            yartemp = yar6;
            {
                if (this.listChil.Items.Contains("6 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("6 years old    x" + (yartemp));
                    yar6 += 1;
                    listChil.Items.Add("6 years old    x" + yar6);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar6 += 1;
                    listChil.Items.Add("6 years old    x" + yar6);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn7yar_Click(object sender, EventArgs e)
        {
            yartemp = yar7;
            {
                if (this.listChil.Items.Contains("7 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("7 years old    x" + (yartemp));
                    yar7 += 1;
                    listChil.Items.Add("7 years old    x" + yar7);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar7 += 1;
                    listChil.Items.Add("7 years old    x" + yar7);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn8yar_Click(object sender, EventArgs e)
        {
            yartemp = yar8;
            {
                if (this.listChil.Items.Contains("8 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("8 years old    x" + (yartemp));
                    yar8 += 1;
                    listChil.Items.Add("8 years old    x" + yar8);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar8 += 1;
                    listChil.Items.Add("8 years old    x" + yar8);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn9yar_Click(object sender, EventArgs e)
        {
            yartemp = yar9;
            {
                if (this.listChil.Items.Contains("9 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("9 years old    x" + (yartemp));
                    yar9 += 1;
                    listChil.Items.Add("9 years old    x" + yar9);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar9 += 1;
                    listChil.Items.Add("9 years old    x" + yar9);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }

        private void btn10yar_Click(object sender, EventArgs e)
        {
            yartemp = yar10;
            {
                if (this.listChil.Items.Contains("10 years old    x" + (yartemp)))
                {
                    listChil.Items.Remove("10 years old    x" + (yartemp));
                    yar10 += 1;
                    listChil.Items.Add("10 years old    x" + yar10);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
                else
                {
                    yar10 += 1;
                    listChil.Items.Add("10 years old    x" + yar10);
                    listChil.SelectedIndex = listChil.Items.Count - 1;
                    listChil.Focus();
                    this.i = 4;
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTable.Text = "0";
            txtCustomers.Text = "0";
            txtDrinks.Text = "0";
            listChil.Items.Clear();
            numbert = 0;
            numberc = 0;
            numberd = 0;
            yar2 = 0;
            yar3 = 0;
            yar4 = 0;
            yar5 = 0;
            yar6 = 0;
            yar7 = 0;
            yar8 = 0;
            yar9 = 0;
            yar10 = 0;
            goltotal = 0;

            beer1 = 0;
            beer2 = 0;
            beer3 = 0;
            beer4 = 0;
            beer5 = 0;
            beer6 = 0;
            beer7 = 0;
            beer8 = 0;
            beer9 = 0;
            beer10 = 0;
            beer11 = 0;
            beer12 = 0;
            beer13 = 0;
            beer14 = 0;
            beer15 = 0;
            beer16 = 0;
            beer17 = 0;
            beer18 = 0;
            beer19 = 0;
            beertemp = 0;

            listBox1.Items.Clear();
            listBeer.Items.Clear();

        }

        private void txtTable_Enter(object sender, EventArgs e)
        {
            txtTable.Focus();
            this.i = 1;
        }

        private void txtCustomers_Enter(object sender, EventArgs e)
        {
            txtCustomers.Focus();
            this.i = 2;
        }
        private void txtDrinks_Enter(object sender, EventArgs e)
        {
            txtDrinks.Focus();
            this.i = 3;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button1.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button1.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button1.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button1.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button1.Text;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button2.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button2.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button2.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button2.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button2.Text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button3.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button3.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button3.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button3.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button3.Text;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button4.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button4.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button4.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button4.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button4.Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button5.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button5.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button5.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button5.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button5.Text;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button6.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button6.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button6.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button6.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button6.Text;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button7.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button7.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button7.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button7.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button7.Text;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button8.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button8.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button8.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button8.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button8.Text;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button9.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button9.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button9.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button9.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button9.Text;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            { txtTable.Text += button10.Text; }
            else if (this.i == 2)
            {
                if (txtCustomers.Text != "0")
                { txtCustomers.Text += button10.Text; }
                else
                {
                    txtCustomers.Text = "";
                    txtCustomers.Text += button10.Text;
                }
            }

            else if (this.i == 3)
            {
                if (txtDrinks.Text != "0")
                { txtDrinks.Text += button10.Text; }
                else
                {
                    txtDrinks.Text = "";
                    txtDrinks.Text += button10.Text;
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
            {
                txtCustomers.Focus();
            }
            else if (this.i == 2)
            {
                txtDrinks.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {  
            if (submitClick == true)
            { 
            chkNumber += 1;
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument; //add the document to the dialog box...        
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
            printDocument.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            printDocument.Print();
            listChk.Items.Add(chkNumber + "".PadRight(4) + table + "".PadRight(4) + goltotal + "".PadRight(4) + DateTime.Now.ToString("HH:mm:ss"));
            listChk.SelectedIndex = listChk.Items.Count - 1;
            tota += goltotal;
            submitClick = false;
            }
        }
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphic = e.Graphics;

            Font font = new Font("Monaco", 6); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 0;
            int startY = 3;
            int offset = 20;


            graphic.DrawString("Lunch Check:   AB  " +  String.Format("{0:0000}", chkNumber), new Font("Monaco", 16), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            string top = "Type".PadRight(27) + "Number".PadRight(10) + "Price";
            offset = offset + (int)fontHeight;
            graphic.DrawString(top, new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------------------", new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 8; //make the spacing consistent

            graphic.DrawString("Table".PadRight(26) + String.Format("{0:c}", txtTable.Text), new Font("Monaco", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 15;

            for (int i = 1; i < listBox1.Items.Count - 3; i++)
            {
                string result;
                result = Convert.ToString(listBox1.Items[i]);
                graphic.DrawString(result, new Font("Monaco", 10), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 10;
            }

            double price, ChilPrice, customerPrice, drinkPrice, beerPrice,subtotal,taxes;
            ChilPrice = Convert.ToDouble(chilprice2 * yar2 + chilprice3 * yar3 + chilprice4 * yar4 + chilprice5 * yar5 + chilprice6 * yar6 + chilprice7 * yar7 + chilprice8 * yar8 + chilprice9 * yar9 + chilprice10 * yar10);
            beerPrice = beerprice1 * beer1 + beerprice2 * beer2 + beerprice3 * beer3 + beerprice4 * beer4 + beerprice5 * beer5 + beerprice6 * beer6 + beerprice7 * beer7 + beerprice8 * beer8 + beerprice9 * beer9 + beerprice10 * beer10 + beerprice11 * beer11 + beerprice12 * beer12 + beerprice13 * beer13 + beerprice14 * beer14 + beerprice15 * beer15 + beerprice16 * beer16 + beerprice17 * beer17 + beerprice18 * beer18 + beerprice19 * beer19;
            customers = txtCustomers.Text;
            drinks = txtDrinks.Text;
            numberc = Int16.Parse(customers);
            numberd = Int16.Parse(drinks);
            customerPrice = lunchprice * numberc;
            drinkPrice = lunchdrinkprice * numberd;
            subtotal = customerPrice + ChilPrice + drinkPrice + beerPrice;
            taxes = subtotal * 0.0725;
            price = subtotal + taxes;
            subtotal = Math.Round(subtotal, 2);
            taxes = Math.Round(taxes, 2);
            price = Math.Round(price, 2);
            graphic.DrawString("----------------------------------------------------", new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Subtotal".PadRight(55) + String.Format("{0:c}", subtotal), new Font("Monaco", 10), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Taxes".PadRight(55) + String.Format("{0:c}", taxes), new Font("Monaco", 10), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 8;
            graphic.DrawString("----------------------------------------------------", new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 27;

            graphic.DrawString("Total".PadRight(15) + String.Format("{0:c}", price), new Font("Monaco", 20, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 48; //make some room so that the total stands out.
            graphic.DrawString("Time of order:  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("Monaco", 10), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 27;
        }

        private void btnlistChilClear_Click(object sender, EventArgs e)
        {
            if (this.i == 1)
                txtTable.Text = "";
            else if (this.i == 2)
                txtCustomers.Text = "";
            else if (this.i == 3)
                txtDrinks.Text = "";
        }

        private void btnChilClear_Click(object sender, EventArgs e)
        {
            
            if (this.i == 4)
            {
                if (listChil.SelectedItems.Count > 0)
                { 
                if (listChil.SelectedItem.ToString().Contains("2 years old    x" + yar2))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar2 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("3 years old    x" + yar3))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar3 = 0;
                }
     
                else if (listChil.SelectedItem.ToString().Contains("4 years old    x" + yar4))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar4 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("5 years old    x" + yar5))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar5 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("6 years old    x" + yar6))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar6 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("7 years old    x" + yar7))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar7 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("8 years old    x"+ yar8))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar8 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("9 years old    x"+ yar9))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar9 = 0;
                }

                else if (listChil.SelectedItem.ToString().Contains("10 years old    x" + yar10))
                {
                    listChil.Items.Remove(listChil.SelectedItem);
                    yar10 = 0;
                }
                }
                else 
                {
                    MessageBox.Show("??????????");
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456")
            {
                txtZE.Text = "$" + tota;
                lblZE.Visible = true;
                txtZE.Visible = true;
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            beertemp = beer1;
            {
                if (this.listBeer.Items.Contains("Budweizer    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Budweizer    x" + (beertemp));
                    beer1 += 1;
                    listBeer.Items.Add("Budweizer    x" + beer1);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer1 += 1;
                    listBeer.Items.Add("Budweizer    x" + beer1);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            beertemp = beer2;
            {
                if (this.listBeer.Items.Contains("Bud Light    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Bud Light    x" + (beertemp));
                    beer2 += 1;
                    listBeer.Items.Add("Bud Light    x" + beer2);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer2 += 1;
                    listBeer.Items.Add("Bud Light    x" + beer2);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            beertemp = beer3;
            {
                if (this.listBeer.Items.Contains("Miller Lite    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Miller Lite    x" + (beertemp));
                    beer3 += 1;
                    listBeer.Items.Add("Miller Lite    x" + beer3);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer3 += 1;
                    listBeer.Items.Add("Miller Lite    x" + beer3);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            beertemp = beer4;
            {
                if (this.listBeer.Items.Contains("Coors Light    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Coors Light    x" + (beertemp));
                    beer4 += 1;
                    listBeer.Items.Add("Coors Light    x" + beer4);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer4 += 1;
                    listBeer.Items.Add("Coors Light    x" + beer4);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            beertemp = beer5;
            {
                if (this.listBeer.Items.Contains("Michelob    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Michelob    x" + (beertemp));
                    beer5 += 1;
                    listBeer.Items.Add("Michelob    x" + beer5);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer5 += 1;
                    listBeer.Items.Add("Michelob    x" + beer5);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            beertemp = beer6;
            {
                if (this.listBeer.Items.Contains("Tsingtao,China    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Tsingtao,China    x" + (beertemp));
                    beer6 += 1;
                    listBeer.Items.Add("Tsingtao,China    x" + beer6);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer6 += 1;
                    listBeer.Items.Add("Tsingtao,China    x" + beer6);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            beertemp = beer7;
            {
                if (this.listBeer.Items.Contains("Heineken,Holland    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Heineken,Holland    x" + (beertemp));
                    beer7 += 1;
                    listBeer.Items.Add("Heineken,Holland    x" + beer7);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer7 += 1;
                    listBeer.Items.Add("Heineken,Holland    x" + beer7);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            beertemp = beer8;
            {
                if (this.listBeer.Items.Contains("Sapporo,Japan    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Sapporo,Japan    x" + (beertemp));
                    beer8 += 1;
                    listBeer.Items.Add("Sapporo,Japan    x" + beer8);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer8 += 1;
                    listBeer.Items.Add("Sapporo,Japan    x" + beer8);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            beertemp = beer9;
            {
                if (this.listBeer.Items.Contains("Corona,Mexico    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Corona,Mexico    x" + (beertemp));
                    beer9 += 1;
                    listBeer.Items.Add("Corona,Mexico    x" + beer9);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer9 += 1;
                    listBeer.Items.Add("Corona,Mexico    x" + beer9);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            beertemp = beer10;
            {
                if (this.listBeer.Items.Contains("Ten High    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Ten High    x" + (beertemp));
                    beer10 += 1;
                    listBeer.Items.Add("Ten High    x" + beer10);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer10 += 1;
                    listBeer.Items.Add("Ten High    x" + beer10);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            beertemp = beer11;
            {
                if (this.listBeer.Items.Contains("Oolong Tea (per cup)    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Oolong Tea (per cup)    x" + (beertemp));
                    beer11 += 1;
                    listBeer.Items.Add("Oolong Tea (per cup)    x" + beer11);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer11 += 1;
                    listBeer.Items.Add("Oolong Tea (per cup)    x" + beer11);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            beertemp = beer12;
            {
                if (this.listBeer.Items.Contains("Orange Juice (glass)    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Orange Juice (glass)    x" + (beertemp));
                    beer12 += 1;
                    listBeer.Items.Add("Orange Juice (glass)    x" + beer12);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer12 += 1;
                    listBeer.Items.Add("Orange Juice (glass)    x" + beer12);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB13_Click(object sender, EventArgs e)
        {
            beertemp = beer13;
            {
                if (this.listBeer.Items.Contains("Apple Juice (glass)    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Apple Juice (glass)    x" + (beertemp));
                    beer13 += 1;
                    listBeer.Items.Add("Apple Juice (glass)    x" + beer13);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer13 += 1;
                    listBeer.Items.Add("Apple Juice (glass)    x" + beer13);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB14_Click(object sender, EventArgs e)
        {
            beertemp = beer14;
            {
                if (this.listBeer.Items.Contains("Milk (glass)    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Milk (glass)    x" + (beertemp));
                    beer14 += 1;
                    listBeer.Items.Add("Milk (glass)    x" + beer14);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer14 += 1;
                    listBeer.Items.Add("Milk (glass)    x" + beer14);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB15_Click(object sender, EventArgs e)
        {
            beertemp = beer15;
            {
                if (this.listBeer.Items.Contains("Chardonnay    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Chardonnay    x" + (beertemp));
                    beer15 += 1;
                    listBeer.Items.Add("Chardonnay    x" + beer15);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer15 += 1;
                    listBeer.Items.Add("Chardonnay    x" + beer15);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB16_Click(object sender, EventArgs e)
        {
            beertemp = beer16;
            {
                if (this.listBeer.Items.Contains("Zinfandel    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Zinfandel    x" + (beertemp));
                    beer16 += 1;
                    listBeer.Items.Add("Zinfandel    x" + beer16);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer16 += 1;
                    listBeer.Items.Add("Zinfandel    x" + beer16);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB17_Click(object sender, EventArgs e)
        {
            beertemp = beer17;
            {
                if (this.listBeer.Items.Contains("Merlot    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Merlot    x" + (beertemp));
                    beer17 += 1;
                    listBeer.Items.Add("Merlot    x" + beer17);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer17 += 1;
                    listBeer.Items.Add("Merlot    x" + beer17);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB18_Click(object sender, EventArgs e)
        {
            beertemp = beer18;
            {
                if (this.listBeer.Items.Contains("Plum Wine    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Plum Wine    x" + (beertemp));
                    beer18 += 1;
                    listBeer.Items.Add("Plum Wine    x" + beer18);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer18 += 1;
                    listBeer.Items.Add("Plum Wine    x" + beer18);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnB19_Click(object sender, EventArgs e)
        {
            beertemp = beer19;
            {
                if (this.listBeer.Items.Contains("Sake    x" + (beertemp)))
                {
                    listBeer.Items.Remove("Sake    x" + (beertemp));
                    beer19 += 1;
                    listBeer.Items.Add("Sake    x" + beer19);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
                else
                {
                    beer19 += 1;
                    listBeer.Items.Add("Sake    x" + beer19);
                    listBeer.SelectedIndex = listBeer.Items.Count - 1;
                    listBeer.Focus();
                    this.i = 5;
                }
            }
        }

        private void btnBeerClear_Click(object sender, EventArgs e)
        {
            if (this.i == 5)
            {
                if (listBeer.SelectedItems.Count > 0)
                {
                    if (listBeer.SelectedItem.ToString().Contains("Budweizer    x" + beer1))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer1 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Bud Light    x" + beer2))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer2 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Miller Lite    x" + beer3))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer3 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Coors Light    x" + beer4))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer4 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Michelob    x" + beer5))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer5 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Tsingtao,China    x" + beer6))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer6 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Heineken,Holland    x" + beer7))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer7 = 0;
                    }
                    else if (listBeer.SelectedItem.ToString().Contains("Sapporo,Japan    x" + beer8))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer8 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Corona,Mexico    x" + beer9))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer9 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Ten High    x" + beer10))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer10 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Oolong Tea (per cup)    x" + beer11))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer11 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Orange Juice (glass)    x" + beer12))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer12 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Apple Juice (glass)    x" + beer13))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer13 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Milk (glass)    x" + beer14))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer14 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Chardonnay    x" + beer15))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer15 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Zinfandel    x" + beer16))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer16 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Merlot    x" + beer17))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer17 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Plum Wine    x" + beer18))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer18 = 0;
                    }

                    else if (listBeer.SelectedItem.ToString().Contains("Sake    x" + beer19))
                    {
                        listBeer.Items.Remove(listBeer.SelectedItem);
                        beer19 = 0;
                    }
                }

                else
                {
                    MessageBox.Show("??????????");
                }
            }




        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456")
            {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument; //add the document to the dialog box...  
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
            printDocument.PrinterSettings.PrinterName = "EPSON TM-T20II Receipt";
            printDocument.Print();
            }
        }

        private void btnPasswordClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnZEPrint_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456")
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument; //add the document to the dialog box...        
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateZE); //add an event handler that will do the printing
                printDocument.PrinterSettings.PrinterName = "EPSON TM-T20II Receipt";
                printDocument.Print();

            }
        }
        public void CreateZE(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphic = e.Graphics;

            Font font = new Font("Monaco", 6); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 0;
            int startY = 3;
            int offset = 20;

            graphic.DrawString("??AB", new Font("Monaco", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            string top = "??".PadRight(5) + "??".PadRight(5) + "??".PadRight(5) +"??".PadRight(5);
            offset = offset + (int)fontHeight;
            graphic.DrawString(top, new Font("??", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString("??:  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("Monaco", 9), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------", new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 8; //make the spacing consistent
  
            for (int i = 0; i < listChk.Items.Count; i++)
            {
                string result;
                result = Convert.ToString(listChk.Items[i]);
                graphic.DrawString(result, new Font("Monaco", 12), new SolidBrush(Color.Black), startX+10, startY + offset);
                offset = offset + (int)fontHeight + 10;
            }
            graphic.DrawString("--------------------------------------------", new Font("Monaco", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("??".PadRight(15) + String.Format("{0:c}", tota), new Font("Monaco", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;

            {
             if (txtPassword.Text == "123456")
            {
                e.Cancel = false;
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("?????");

            }

            else
            {
                MessageBox.Show("????");
            }
     
             }
        }
    }
}

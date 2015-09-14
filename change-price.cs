using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChangePrice
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tableLayoutPanel7.Visible = false;

            groupBox6.Visible = true;

            FileStream f = new FileStream("C:/text/lunchprice.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(f);

            txtPrice.Text = reader.ReadLine();

            reader.Close();
            f.Close();


            FileStream f1 = new FileStream("C:/text/lunchdrinkprice.txt", FileMode.OpenOrCreate);
            StreamReader reader1 = new StreamReader(f1);

            txtDrinkPrice.Text = reader1.ReadLine();

            reader1.Close();
            f1.Close();




            FileStream f2 = new FileStream("C:/text/chil2price.txt", FileMode.OpenOrCreate);
            StreamReader reader2 = new StreamReader(f2);

            txt2.Text = reader2.ReadLine();

            reader2.Close();
            f2.Close();


            FileStream f3 = new FileStream("C:/text/chil3price.txt", FileMode.OpenOrCreate);
            StreamReader reader3 = new StreamReader(f3);

            txt3.Text = reader3.ReadLine();

            reader3.Close();
            f3.Close();


            FileStream f4 = new FileStream("C:/text/chil4price.txt", FileMode.OpenOrCreate);
            StreamReader reader4 = new StreamReader(f4);

            txt4.Text = reader4.ReadLine();

            reader4.Close();
            f4.Close();



            FileStream f5 = new FileStream("C:/text/chil5price.txt", FileMode.OpenOrCreate);
            StreamReader reader5 = new StreamReader(f5);

            txt5.Text = reader5.ReadLine();

            reader5.Close();
            f5.Close();



            FileStream f6 = new FileStream("C:/text/chil6price.txt", FileMode.OpenOrCreate);
            StreamReader reader6 = new StreamReader(f6);

            txt6.Text = reader6.ReadLine();

            reader6.Close();
            f6.Close();




            FileStream f7 = new FileStream("C:/text/chil7price.txt", FileMode.OpenOrCreate);
            StreamReader reader7 = new StreamReader(f7);

            txt7.Text = reader7.ReadLine();

            reader7.Close();
            f7.Close();


            FileStream f8 = new FileStream("C:/text/chil8price.txt", FileMode.OpenOrCreate);
            StreamReader reader8 = new StreamReader(f8);

            txt8.Text = reader8.ReadLine();

            reader8.Close();
            f8.Close();



            FileStream f9 = new FileStream("C:/text/chil9price.txt", FileMode.OpenOrCreate);
            StreamReader reader9 = new StreamReader(f9);

            txt9.Text = reader9.ReadLine();

            reader9.Close();
            f9.Close();


            FileStream f10 = new FileStream("C:/text/chil10price.txt", FileMode.OpenOrCreate);
            StreamReader reader10 = new StreamReader(f10);

            txt10.Text = reader10.ReadLine();

            reader10.Close();
            f10.Close();


            FileStream f11 = new FileStream("C:/text/beer1price.txt", FileMode.OpenOrCreate);
            StreamReader reader11 = new StreamReader(f11);

            txtBeer1.Text = reader11.ReadLine();

            reader11.Close();
            f11.Close();


            FileStream f12 = new FileStream("C:/text/beer2price.txt", FileMode.OpenOrCreate);
            StreamReader reader12 = new StreamReader(f12);

            txtBeer2.Text = reader12.ReadLine();

            reader12.Close();
            f12.Close();


            FileStream f13 = new FileStream("C:/text/beer3price.txt", FileMode.OpenOrCreate);
            StreamReader reader13 = new StreamReader(f13);

            txtBeer3.Text = reader13.ReadLine();

            reader13.Close();
            f13.Close();

            FileStream f14 = new FileStream("C:/text/beer4price.txt", FileMode.OpenOrCreate);
            StreamReader reader14 = new StreamReader(f14);

            txtBeer4.Text = reader14.ReadLine();

            reader14.Close();
            f14.Close();



            FileStream f15 = new FileStream("C:/text/beer5price.txt", FileMode.OpenOrCreate);
            StreamReader reader15 = new StreamReader(f15);

            txtBeer5.Text = reader15.ReadLine();

            reader15.Close();
            f15.Close();



            FileStream f16 = new FileStream("C:/text/beer6price.txt", FileMode.OpenOrCreate);
            StreamReader reader16 = new StreamReader(f16);

            txtBeer6.Text = reader16.ReadLine();

            reader16.Close();
            f16.Close();

            FileStream f17 = new FileStream("C:/text/beer7price.txt", FileMode.OpenOrCreate);
            StreamReader reader17 = new StreamReader(f17);

            txtBeer7.Text = reader17.ReadLine();

            reader17.Close();
            f17.Close();


            FileStream f18 = new FileStream("C:/text/beer8price.txt", FileMode.OpenOrCreate);
            StreamReader reader18 = new StreamReader(f18);

            txtBeer8.Text = reader18.ReadLine();

            reader18.Close();
            f18.Close();



            FileStream f19 = new FileStream("C:/text/beer9price.txt", FileMode.OpenOrCreate);
            StreamReader reader19 = new StreamReader(f19);

            txtBeer9.Text = reader19.ReadLine();

            reader19.Close();
            f19.Close();

            FileStream f20 = new FileStream("C:/text/beer10price.txt", FileMode.OpenOrCreate);
            StreamReader reader20 = new StreamReader(f20);

            txtBeer10.Text = reader20.ReadLine();

            reader20.Close();
            f20.Close();

            FileStream f21 = new FileStream("C:/text/beer11price.txt", FileMode.OpenOrCreate);
            StreamReader reader21 = new StreamReader(f21);

            txtBeer11.Text = reader21.ReadLine();

            reader21.Close();
            f21.Close();

            FileStream f22 = new FileStream("C:/text/beer12price.txt", FileMode.OpenOrCreate);
            StreamReader reader22 = new StreamReader(f22);

            txtBeer12.Text = reader22.ReadLine();

            reader22.Close();
            f22.Close();

            FileStream f23 = new FileStream("C:/text/beer13price.txt", FileMode.OpenOrCreate);
            StreamReader reader23 = new StreamReader(f23);

            txtBeer13.Text = reader23.ReadLine();

            reader23.Close();
            f23.Close();

            FileStream f24 = new FileStream("C:/text/beer14price.txt", FileMode.OpenOrCreate);
            StreamReader reader24 = new StreamReader(f24);

            txtBeer14.Text = reader24.ReadLine();

            reader24.Close();
            f24.Close();

            FileStream f25 = new FileStream("C:/text/beer15price.txt", FileMode.OpenOrCreate);
            StreamReader reader25 = new StreamReader(f25);

            txtBeer15.Text = reader25.ReadLine();

            reader25.Close();
            f25.Close();

            FileStream f26 = new FileStream("C:/text/beer16price.txt", FileMode.OpenOrCreate);
            StreamReader reader26 = new StreamReader(f26);

            txtBeer16.Text = reader26.ReadLine();

            reader26.Close();
            f26.Close();

            FileStream f27 = new FileStream("C:/text/beer17price.txt", FileMode.OpenOrCreate);
            StreamReader reader27 = new StreamReader(f27);

            txtBeer17.Text = reader27.ReadLine();

            reader27.Close();
            f27.Close();

            FileStream f28 = new FileStream("C:/text/beer18price.txt", FileMode.OpenOrCreate);
            StreamReader reader28 = new StreamReader(f28);

            txtBeer18.Text = reader28.ReadLine();

            reader28.Close();
            f28.Close();


            FileStream f29 = new FileStream("C:/text/beer19price.txt", FileMode.OpenOrCreate);
            StreamReader reader29 = new StreamReader(f29);

            txtBeer19.Text = reader29.ReadLine();

            reader29.Close();
            f29.Close();

            FileStream fD = new FileStream("C:/text/dinnerprice.txt", FileMode.OpenOrCreate);
            StreamReader readerD = new StreamReader(fD);

            txtPriceD.Text = readerD.ReadLine();

            readerD.Close();
            fD.Close();


            FileStream f1D = new FileStream("C:/text/dinnerdrinkprice.txt", FileMode.OpenOrCreate);
            StreamReader reader1D = new StreamReader(f1D);

            txtDrinkPriceD.Text = reader1D.ReadLine();

            reader1D.Close();
            f1D.Close();




            FileStream f2D = new FileStream("C:/text/chil2priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader2D = new StreamReader(f2D);

            txt2D.Text = reader2D.ReadLine();

            reader2D.Close();
            f2D.Close();


            FileStream f3D = new FileStream("C:/text/chil3priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader3D = new StreamReader(f3D);

            txt3D.Text = reader3D.ReadLine();

            reader3D.Close();
            f3D.Close();


            FileStream f4D = new FileStream("C:/text/chil4priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader4D = new StreamReader(f4D);

            txt4D.Text = reader4D.ReadLine();

            reader4D.Close();
            f4D.Close();



            FileStream f5D = new FileStream("C:/text/chil5priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader5D = new StreamReader(f5D);

            txt5D.Text = reader5D.ReadLine();

            reader5D.Close();
            f5D.Close();



            FileStream f6D = new FileStream("C:/text/chil6priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader6D = new StreamReader(f6D);

            txt6D.Text = reader6D.ReadLine();

            reader6D.Close();
            f6D.Close();




            FileStream f7D = new FileStream("C:/text/chil7priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader7D = new StreamReader(f7D);

            txt7D.Text = reader7D.ReadLine();

            reader7D.Close();
            f7D.Close();


            FileStream f8D = new FileStream("C:/text/chil8priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader8D = new StreamReader(f8D);

            txt8D.Text = reader8D.ReadLine();

            reader8D.Close();
            f8D.Close();



            FileStream f9D = new FileStream("C:/text/chil9priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader9D = new StreamReader(f9D);

            txt9D.Text = reader9D.ReadLine();

            reader9D.Close();
            f9D.Close();


            FileStream f10D = new FileStream("C:/text/chil10priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader10D = new StreamReader(f10D);

            txt10D.Text = reader10D.ReadLine();

            reader10D.Close();
            f10D.Close();

            FileStream ftax= new FileStream("C:/text/taxrate.txt", FileMode.OpenOrCreate);
            StreamReader readertax = new StreamReader(ftax);

            txtTax.Text = readertax.ReadLine();

            readertax.Close();
            ftax.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("C:/text/lunchprice.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer = new StreamWriter(file); //设置文件时可以写的
            writer.WriteLine(txtPrice.Text);

            writer.Close();
            file.Close();

            FileStream file1 = new FileStream("C:/text/lunchdrinkprice.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer1 = new StreamWriter(file1); //设置文件时可以写的
            writer1.WriteLine(txtDrinkPrice.Text);

            writer1.Close();
            file1.Close();

            FileStream file2 = new FileStream("C:/text/chil2price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer2 = new StreamWriter(file2); //设置文件时可以写的
            writer2.WriteLine(txt2.Text);

            writer2.Close();
            file2.Close();



            FileStream file3 = new FileStream("C:/text/chil3price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer3 = new StreamWriter(file3); //设置文件时可以写的
            writer3.WriteLine(txt3.Text);

            writer3.Close();
            file3.Close();



            FileStream file4 = new FileStream("C:/text/chil4price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer4 = new StreamWriter(file4); //设置文件时可以写的
            writer4.WriteLine(txt4.Text);

            writer4.Close();
            file4.Close();




            FileStream file5 = new FileStream("C:/text/chil5price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer5 = new StreamWriter(file5); //设置文件时可以写的
            writer5.WriteLine(txt5.Text);

            writer5.Close();
            file5.Close();


            FileStream file6 = new FileStream("C:/text/chil6price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer6 = new StreamWriter(file6); //设置文件时可以写的
            writer6.WriteLine(txt6.Text);

            writer6.Close();
            file6.Close();



            FileStream file7 = new FileStream("C:/text/chil7price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer7 = new StreamWriter(file7); //设置文件时可以写的
            writer7.WriteLine(txt7.Text);

            writer7.Close();
            file7.Close();


            FileStream file8 = new FileStream("C:/text/chil8price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer8 = new StreamWriter(file8); //设置文件时可以写的
            writer8.WriteLine(txt8.Text);

            writer8.Close();
            file8.Close();


            FileStream file9 = new FileStream("C:/text/chil9price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer9 = new StreamWriter(file9); //设置文件时可以写的
            writer9.WriteLine(txt9.Text);

            writer9.Close();
            file9.Close();


            FileStream file10 = new FileStream("C:/text/chil10price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer10 = new StreamWriter(file10); //设置文件时可以写的
            writer10.WriteLine(txt10.Text);

            writer10.Close();
            file10.Close();


            FileStream file11 = new FileStream("C:/text/beer1price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer11 = new StreamWriter(file11); //设置文件时可以写的
            writer11.WriteLine(txtBeer1.Text);

            writer11.Close();
            file11.Close();

            FileStream file12 = new FileStream("C:/text/beer2price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer12 = new StreamWriter(file12); //设置文件时可以写的
            writer12.WriteLine(txtBeer2.Text);

            writer12.Close();
            file12.Close();


            FileStream file13 = new FileStream("C:/text/beer3price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer13 = new StreamWriter(file13); //设置文件时可以写的
            writer13.WriteLine(txtBeer3.Text);

            writer13.Close();
            file13.Close();


            FileStream file14 = new FileStream("C:/text/beer4price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer14 = new StreamWriter(file14); //设置文件时可以写的
            writer14.WriteLine(txtBeer4.Text);

            writer14.Close();
            file14.Close();


            FileStream file15 = new FileStream("C:/text/beer5price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer15 = new StreamWriter(file15); //设置文件时可以写的
            writer15.WriteLine(txtBeer5.Text);

            writer15.Close();
            file15.Close();

            FileStream file16 = new FileStream("C:/text/beer6price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer16 = new StreamWriter(file16); //设置文件时可以写的
            writer16.WriteLine(txtBeer6.Text);

            writer16.Close();
            file16.Close();


            FileStream file17 = new FileStream("C:/text/beer7price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer17 = new StreamWriter(file17); //设置文件时可以写的
            writer17.WriteLine(txtBeer7.Text);

            writer17.Close();
            file17.Close();


            FileStream file18 = new FileStream("C:/text/beer8price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer18 = new StreamWriter(file18); //设置文件时可以写的
            writer18.WriteLine(txtBeer8.Text);

            writer18.Close();
            file18.Close();


            FileStream file19 = new FileStream("C:/text/beer9price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer19 = new StreamWriter(file19); //设置文件时可以写的
            writer19.WriteLine(txtBeer9.Text);

            writer19.Close();
            file19.Close();

            FileStream file20 = new FileStream("C:/text/beer10price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer20 = new StreamWriter(file20); //设置文件时可以写的
            writer20.WriteLine(txtBeer10.Text);

            writer20.Close();
            file20.Close();

            FileStream file21 = new FileStream("C:/text/beer11price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer21 = new StreamWriter(file21); //设置文件时可以写的
            writer21.WriteLine(txtBeer11.Text);

            writer21.Close();
            file21.Close();

            FileStream file22 = new FileStream("C:/text/beer12price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer22 = new StreamWriter(file22); //设置文件时可以写的
            writer22.WriteLine(txtBeer12.Text);

            writer22.Close();
            file22.Close();

            FileStream file23 = new FileStream("C:/text/beer13price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer23 = new StreamWriter(file23); //设置文件时可以写的
            writer23.WriteLine(txtBeer13.Text);

            writer23.Close();
            file23.Close();

            FileStream file24 = new FileStream("C:/text/beer14price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer24 = new StreamWriter(file24); //设置文件时可以写的
            writer24.WriteLine(txtBeer14.Text);

            writer24.Close();
            file24.Close();

            FileStream file25 = new FileStream("C:/text/beer15price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer25 = new StreamWriter(file25); //设置文件时可以写的
            writer25.WriteLine(txtBeer15.Text);

            writer25.Close();
            file25.Close();

            FileStream file26 = new FileStream("C:/text/beer16price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer26 = new StreamWriter(file26); //设置文件时可以写的
            writer26.WriteLine(txtBeer16.Text);

            writer26.Close();
            file26.Close();

            FileStream file27 = new FileStream("C:/text/beer17price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer27 = new StreamWriter(file27); //设置文件时可以写的
            writer27.WriteLine(txtBeer17.Text);

            writer27.Close();
            file27.Close();

            FileStream file28 = new FileStream("C:/text/beer18price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer28 = new StreamWriter(file28); //设置文件时可以写的
            writer28.WriteLine(txtBeer18.Text);

            writer28.Close();
            file28.Close();

            FileStream file29 = new FileStream("C:/text/beer19price.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer29 = new StreamWriter(file29); //设置文件时可以写的
            writer29.WriteLine(txtBeer19.Text);

            writer29.Close();
            file29.Close();

            FileStream fileD = new FileStream("C:/text/dinnerprice.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writerD = new StreamWriter(fileD); //设置文件时可以写的
            writerD.WriteLine(txtPriceD.Text);

            writerD.Close();
            fileD.Close();

            FileStream file1D = new FileStream("C:/text/dinnerdrinkprice.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer1D = new StreamWriter(file1D); //设置文件时可以写的
            writer1D.WriteLine(txtDrinkPriceD.Text);

            writer1D.Close();
            file1D.Close();

            FileStream file2D = new FileStream("C:/text/chil2priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer2D = new StreamWriter(file2D); //设置文件时可以写的
            writer2D.WriteLine(txt2D.Text);

            writer2D.Close();
            file2D.Close();



            FileStream file3D = new FileStream("C:/text/chil3priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer3D = new StreamWriter(file3D); //设置文件时可以写的
            writer3D.WriteLine(txt3D.Text);

            writer3D.Close();
            file3D.Close();



            FileStream file4D = new FileStream("C:/text/chil4priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer4D = new StreamWriter(file4D); //设置文件时可以写的
            writer4D.WriteLine(txt4D.Text);

            writer4D.Close();
            file4D.Close();




            FileStream file5D = new FileStream("C:/text/chil5priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer5D = new StreamWriter(file5D); //设置文件时可以写的
            writer5D.WriteLine(txt5D.Text);

            writer5D.Close();
            file5D.Close();


            FileStream file6D = new FileStream("C:/text/chil6priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer6D = new StreamWriter(file6D); //设置文件时可以写的
            writer6D.WriteLine(txt6D.Text);

            writer6D.Close();
            file6D.Close();



            FileStream file7D = new FileStream("C:/text/chil7priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer7D = new StreamWriter(file7D); //设置文件时可以写的
            writer7D.WriteLine(txt7D.Text);

            writer7D.Close();
            file7D.Close();


            FileStream file8D = new FileStream("C:/text/chil8priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer8D = new StreamWriter(file8D); //设置文件时可以写的
            writer8D.WriteLine(txt8D.Text);

            writer8D.Close();
            file8D.Close();


            FileStream file9D = new FileStream("C:/text/chil9priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer9D = new StreamWriter(file9D); //设置文件时可以写的
            writer9D.WriteLine(txt9D.Text);

            writer9D.Close();
            file9D.Close();


            FileStream file10D = new FileStream("C:/text/chil10priceD.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writer10D = new StreamWriter(file10D); //设置文件时可以写的
            writer10D.WriteLine(txt10D.Text);

            writer10D.Close();
            file10D.Close();

            FileStream filetax = new FileStream("C:/text/taxrate.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);//建立一个文件
            StreamWriter writertax = new StreamWriter(filetax); //设置文件时可以写的
            writertax.WriteLine(txtTax.Text);

            writertax.Close();
            filetax.Close();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="123456")
            {
                tableLayoutPanel7.Visible = true;

                groupBox6.Visible = false;
            }

            else
            {
                MessageBox.Show("密码错误！请重新输入");
            }
        }

        private void btnPasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("C:/text/lunchprice.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(f);

            txtPrice.Text = reader.ReadLine();

            reader.Close();
            f.Close();


            FileStream f1 = new FileStream("C:/text/lunchdrinkprice.txt", FileMode.OpenOrCreate);
            StreamReader reader1 = new StreamReader(f1);

            txtDrinkPrice.Text = reader1.ReadLine();

            reader1.Close();
            f1.Close();




            FileStream f2 = new FileStream("C:/text/chil2price.txt", FileMode.OpenOrCreate);
            StreamReader reader2 = new StreamReader(f2);

            txt2.Text = reader2.ReadLine();

            reader2.Close();
            f2.Close();


            FileStream f3 = new FileStream("C:/text/chil3price.txt", FileMode.OpenOrCreate);
            StreamReader reader3 = new StreamReader(f3);

            txt3.Text = reader3.ReadLine();

            reader3.Close();
            f3.Close();


            FileStream f4 = new FileStream("C:/text/chil4price.txt", FileMode.OpenOrCreate);
            StreamReader reader4 = new StreamReader(f4);

            txt4.Text = reader4.ReadLine();

            reader4.Close();
            f4.Close();



            FileStream f5 = new FileStream("C:/text/chil5price.txt", FileMode.OpenOrCreate);
            StreamReader reader5 = new StreamReader(f5);

            txt5.Text = reader5.ReadLine();

            reader5.Close();
            f5.Close();



            FileStream f6 = new FileStream("C:/text/chil6price.txt", FileMode.OpenOrCreate);
            StreamReader reader6 = new StreamReader(f6);

            txt6.Text = reader6.ReadLine();

            reader6.Close();
            f6.Close();




            FileStream f7 = new FileStream("C:/text/chil7price.txt", FileMode.OpenOrCreate);
            StreamReader reader7 = new StreamReader(f7);

            txt7.Text = reader7.ReadLine();

            reader7.Close();
            f7.Close();


            FileStream f8 = new FileStream("C:/text/chil8price.txt", FileMode.OpenOrCreate);
            StreamReader reader8 = new StreamReader(f8);

            txt8.Text = reader8.ReadLine();

            reader8.Close();
            f8.Close();



            FileStream f9 = new FileStream("C:/text/chil9price.txt", FileMode.OpenOrCreate);
            StreamReader reader9 = new StreamReader(f9);

            txt9.Text = reader9.ReadLine();

            reader9.Close();
            f9.Close();


            FileStream f10 = new FileStream("C:/text/chil10price.txt", FileMode.OpenOrCreate);
            StreamReader reader10 = new StreamReader(f10);

            txt10.Text = reader10.ReadLine();

            reader10.Close();
            f10.Close();


            FileStream f11 = new FileStream("C:/text/beer1price.txt", FileMode.OpenOrCreate);
            StreamReader reader11 = new StreamReader(f11);

            txtBeer1.Text = reader11.ReadLine();

            reader11.Close();
            f11.Close();


            FileStream f12 = new FileStream("C:/text/beer2price.txt", FileMode.OpenOrCreate);
            StreamReader reader12 = new StreamReader(f12);

            txtBeer2.Text = reader12.ReadLine();

            reader12.Close();
            f12.Close();


            FileStream f13 = new FileStream("C:/text/beer3price.txt", FileMode.OpenOrCreate);
            StreamReader reader13 = new StreamReader(f13);

            txtBeer3.Text = reader13.ReadLine();

            reader13.Close();
            f13.Close();

            FileStream f14 = new FileStream("C:/text/beer4price.txt", FileMode.OpenOrCreate);
            StreamReader reader14 = new StreamReader(f14);

            txtBeer4.Text = reader14.ReadLine();

            reader14.Close();
            f14.Close();



            FileStream f15 = new FileStream("C:/text/beer5price.txt", FileMode.OpenOrCreate);
            StreamReader reader15 = new StreamReader(f15);

            txtBeer5.Text = reader15.ReadLine();

            reader15.Close();
            f15.Close();



            FileStream f16 = new FileStream("C:/text/beer6price.txt", FileMode.OpenOrCreate);
            StreamReader reader16 = new StreamReader(f16);

            txtBeer6.Text = reader16.ReadLine();

            reader16.Close();
            f16.Close();

            FileStream f17 = new FileStream("C:/text/beer7price.txt", FileMode.OpenOrCreate);
            StreamReader reader17 = new StreamReader(f17);

            txtBeer7.Text = reader17.ReadLine();

            reader17.Close();
            f17.Close();


            FileStream f18 = new FileStream("C:/text/beer8price.txt", FileMode.OpenOrCreate);
            StreamReader reader18 = new StreamReader(f18);

            txtBeer8.Text = reader18.ReadLine();

            reader18.Close();
            f18.Close();



            FileStream f19 = new FileStream("C:/text/beer9price.txt", FileMode.OpenOrCreate);
            StreamReader reader19 = new StreamReader(f19);

            txtBeer9.Text = reader19.ReadLine();

            reader19.Close();
            f19.Close();

            FileStream f20 = new FileStream("C:/text/beer10price.txt", FileMode.OpenOrCreate);
            StreamReader reader20 = new StreamReader(f20);

            txtBeer10.Text = reader20.ReadLine();

            reader20.Close();
            f20.Close();

            FileStream f21 = new FileStream("C:/text/beer11price.txt", FileMode.OpenOrCreate);
            StreamReader reader21 = new StreamReader(f21);

            txtBeer11.Text = reader21.ReadLine();

            reader21.Close();
            f21.Close();

            FileStream f22 = new FileStream("C:/text/beer12price.txt", FileMode.OpenOrCreate);
            StreamReader reader22 = new StreamReader(f22);

            txtBeer12.Text = reader22.ReadLine();

            reader22.Close();
            f22.Close();

            FileStream f23 = new FileStream("C:/text/beer13price.txt", FileMode.OpenOrCreate);
            StreamReader reader23 = new StreamReader(f23);

            txtBeer13.Text = reader23.ReadLine();

            reader23.Close();
            f23.Close();

            FileStream f24 = new FileStream("C:/text/beer14price.txt", FileMode.OpenOrCreate);
            StreamReader reader24 = new StreamReader(f24);

            txtBeer14.Text = reader24.ReadLine();

            reader24.Close();
            f24.Close();

            FileStream f25 = new FileStream("C:/text/beer15price.txt", FileMode.OpenOrCreate);
            StreamReader reader25 = new StreamReader(f25);

            txtBeer15.Text = reader25.ReadLine();

            reader25.Close();
            f25.Close();

            FileStream f26 = new FileStream("C:/text/beer16price.txt", FileMode.OpenOrCreate);
            StreamReader reader26 = new StreamReader(f26);

            txtBeer16.Text = reader26.ReadLine();

            reader26.Close();
            f26.Close();

            FileStream f27 = new FileStream("C:/text/beer17price.txt", FileMode.OpenOrCreate);
            StreamReader reader27 = new StreamReader(f27);

            txtBeer17.Text = reader27.ReadLine();

            reader27.Close();
            f27.Close();

            FileStream f28 = new FileStream("C:/text/beer18price.txt", FileMode.OpenOrCreate);
            StreamReader reader28 = new StreamReader(f28);

            txtBeer18.Text = reader28.ReadLine();

            reader28.Close();
            f28.Close();


            FileStream f29 = new FileStream("C:/text/beer19price.txt", FileMode.OpenOrCreate);
            StreamReader reader29 = new StreamReader(f29);

            txtBeer19.Text = reader29.ReadLine();

            reader29.Close();
            f29.Close();

            FileStream fD = new FileStream("C:/text/dinnerprice.txt", FileMode.OpenOrCreate);
            StreamReader readerD = new StreamReader(fD);

            txtPriceD.Text = readerD.ReadLine();

            readerD.Close();
            fD.Close();


            FileStream f1D = new FileStream("C:/text/dinnerdrinkprice.txt", FileMode.OpenOrCreate);
            StreamReader reader1D = new StreamReader(f1D);

            txtDrinkPriceD.Text = reader1D.ReadLine();

            reader1D.Close();
            f1D.Close();




            FileStream f2D = new FileStream("C:/text/chil2priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader2D = new StreamReader(f2D);

            txt2D.Text = reader2D.ReadLine();

            reader2D.Close();
            f2D.Close();


            FileStream f3D = new FileStream("C:/text/chil3priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader3D = new StreamReader(f3D);

            txt3D.Text = reader3D.ReadLine();

            reader3D.Close();
            f3D.Close();


            FileStream f4D = new FileStream("C:/text/chil4priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader4D = new StreamReader(f4D);

            txt4D.Text = reader4D.ReadLine();

            reader4D.Close();
            f4D.Close();



            FileStream f5D = new FileStream("C:/text/chil5priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader5D = new StreamReader(f5D);

            txt5D.Text = reader5D.ReadLine();

            reader5D.Close();
            f5D.Close();



            FileStream f6D = new FileStream("C:/text/chil6priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader6D = new StreamReader(f6D);

            txt6D.Text = reader6D.ReadLine();

            reader6D.Close();
            f6D.Close();




            FileStream f7D = new FileStream("C:/text/chil7priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader7D = new StreamReader(f7D);

            txt7D.Text = reader7D.ReadLine();

            reader7D.Close();
            f7D.Close();


            FileStream f8D = new FileStream("C:/text/chil8priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader8D = new StreamReader(f8D);

            txt8D.Text = reader8D.ReadLine();

            reader8D.Close();
            f8D.Close();



            FileStream f9D = new FileStream("C:/text/chil9priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader9D = new StreamReader(f9D);

            txt9D.Text = reader9D.ReadLine();

            reader9D.Close();
            f9D.Close();


            FileStream f10D = new FileStream("C:/text/chil10priceD.txt", FileMode.OpenOrCreate);
            StreamReader reader10D = new StreamReader(f10D);

            txt10D.Text = reader10D.ReadLine();

            reader10D.Close();
            f10D.Close();

            FileStream ftax = new FileStream("C:/text/taxrate.txt", FileMode.OpenOrCreate);
            StreamReader readertax = new StreamReader(ftax);

            txtTax.Text = readertax.ReadLine();

            readertax.Close();
            ftax.Close();
        }

    }
}

namespace convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Functie pentru a verifica daca utilizatorul introduce doar valori numerice
        private void textBox1_keypress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch == 46 && textBox1.Text.IndexOf(".") != -1) || (ch == 45 && textBox1.Text.IndexOf("-") != -1) ||
                (ch == 45 && textBox1.Text.IndexOf(".") != -1) || !Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
                return;
            }
            else
                MessageBox.Show("Introduceti doar valori numerice!");
        }

        // Adaugarea elementelor in combobox in functie de optiunea meniu selectata
        private void lungimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUnit1.Text = "Unitatea 1";
            Combo1.Text = string.Empty;
            Combo1.Items.Clear();
            Combo1.Items.Add("Kilometru");
            Combo1.Items.Add("Hectometru");
            Combo1.Items.Add("Decametru");
            Combo1.Items.Add("Metru");
            Combo1.Items.Add("Decimetru");
            Combo1.Items.Add("Centimetru");
            Combo1.Items.Add("Milimetru");

            lblUnit2.Text = "Unitatea 2";
            Combo2.Text = string.Empty;
            Combo2.Items.Clear();
            Combo2.Items.Add("Kilometru");
            Combo2.Items.Add("Hectometru");
            Combo2.Items.Add("Decametru");
            Combo2.Items.Add("Metru");
            Combo2.Items.Add("Decimetru");
            Combo2.Items.Add("Centimetru");
            Combo2.Items.Add("Milimetru");

        }

        private void greutateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUnit1.Text = "Unitatea 1";
            Combo1.Text = string.Empty;
            Combo1.Items.Clear();
            Combo1.Items.Add("Tona");
            Combo1.Items.Add("Quintal");
            Combo1.Items.Add("Kilogram");
            Combo1.Items.Add("Hectogram");
            Combo1.Items.Add("Decagram");
            Combo1.Items.Add("Gram");
            Combo1.Items.Add("Decigram");
            Combo1.Items.Add("Centigram");
            Combo1.Items.Add("Miligram");

            lblUnit2.Text = "Unitatea 2";
            Combo2.Text = string.Empty;
            Combo2.Items.Clear();
            Combo2.Items.Add("Tona");
            Combo2.Items.Add("Quintal");
            Combo2.Items.Add("Kilogram");
            Combo2.Items.Add("Hectogram");
            Combo2.Items.Add("Decagram");
            Combo2.Items.Add("Gram");
            Combo2.Items.Add("Decigram");
            Combo2.Items.Add("Centigram");
            Combo2.Items.Add("Miligram");
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUnit1.Text = "Unitatea 1";
            Combo1.Text = string.Empty;
            Combo1.Items.Clear();
            Combo1.Items.Add("\u00b0C");
            Combo1.Items.Add("\u00b0K");
            Combo1.Items.Add("\u00b0F");

            lblUnit2.Text = "Unitatea 2";
            Combo2.Text = string.Empty;
            Combo2.Items.Clear();
            Combo2.Items.Add("\u00b0C");
            Combo2.Items.Add("\u00b0K");
            Combo2.Items.Add("\u00b0F");


        }

        // Functie de resetare
        private void resetbtn_Click(object sender, EventArgs e)
        {
            Combo1.Items.Clear();
            Combo2.Items.Clear();
            Combo1.Text = string.Empty;
            Combo2.Text = string.Empty;
            textBox1.Text = " ";
            lblrez.Text = " ";
        }

        // Functie pentru iesirea din aplicatie
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Convertirea si afisarea valorilor 
        private void calcbtn_Click(object sender, EventArgs e)
        {
            double valoareconv = 0;
            double rezconv = 0;
            switch (Combo1.Text)
            {
                // Lungime
                case "Kilometru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                MessageBox.Show("Ati selectat aceeasi unitate de masura!");
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Hectometru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Decametru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Metru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Decimetru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Centimetru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.00001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Milimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Milimetru":
                    {
                        switch (Combo2.Text)
                        {
                            case "Kilometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectometru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.00001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decametru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Metru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centimetru":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Milimetru":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                        }
                    }
                    break;


                // Greutate 

                case "Tona":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                MessageBox.Show("Ati selectat aceeasi unitate de masura!");
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Kilogram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Hectogram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Decagram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Gram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;

                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 1000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100000;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Decigram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 10;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Centigram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.00000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.00001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                MessageBox.Show("Ati introdus aceasi unitate de masura!");
                                break;
                            case "Miligram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 100;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "Miligram":
                    {
                        switch (Combo2.Text)
                        {
                            case "Tona":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.000000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Kilogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.000001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Hectogram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.00001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decagram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.0001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Gram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.001;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Decigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.01;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Centigram":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv * 0.1;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "Miligram":
                                MessageBox.Show("Ati introdus aceeasi unitate de masura! ");
                                break;
                        }
                    }
                    break;


                // Grade

                case "\u00b0C":
                    {
                        switch (Combo2.Text)
                        {
                            case "\u00b0C":
                                MessageBox.Show("Ati introdus aceeasi unitate de masura!");
                                break;

                            case "\u00b0F":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = (valoareconv * 9 / 5) + 32;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;

                            case "\u00b0K":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv + 273.15;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                    }
                    break;
                case "\u00b0K":
                    {
                        switch (Combo2.Text)
                        {
                            case "\u00b0C":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = valoareconv - 273.15;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                            case "\u00b0K":
                                MessageBox.Show("Ati introdus aceeasi unitate de masura");
                                break;
                            case "\u00b0F":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = 1.8 * (valoareconv - 273) + 32;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;
                        }
                        break;
                    }
                case "\u00b0F":
                    {
                        switch (Combo2.Text)
                        {
                            case "\u00b0C":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = (valoareconv - 32) * 5 / 9;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;

                            case "\u00b0K":
                                {
                                    valoareconv = Convert.ToDouble(textBox1.Text);
                                    rezconv = (valoareconv - 32) / 1.8 + 273;
                                    lblrez.Text = rezconv.ToString();
                                }
                                break;

                            case "\u00b0F":
                                MessageBox.Show("Ati introdus aceeasi unitate de masura");
                                break;
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Nu s-au introdus valori. Va rugam sa incercati din nou.");
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


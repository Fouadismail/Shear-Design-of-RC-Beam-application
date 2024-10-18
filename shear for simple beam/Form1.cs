using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shear_for_simple_beam
{
    public partial class welcom_form : Form
    {

        public welcom_form()
        {
            InitializeComponent();
            con_load.Enabled = false;
            loction_con_load.Enabled = false;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            result.Text = "";
            spacing.Text = "";
            No_stirrups_input.Text = "";
            spacing_stat.Text = "" ;
            var L = double.Parse(Length.Text);
            var d = double.Parse(depth.Text);
            var C = double.Parse(col_width.Text);
            var W = double.Parse(dis_load.Text);
            var b = double.Parse(min_width.Text);
            var fcu = double.Parse(Fcu_input.Text);
            var fy = double.Parse(fy_input.Text);


            if (d <= 0 || b <= 0)
            {
                MessageBox.Show("d or b less than or equal zero and this leads to a problem in the future, enter right value", "Error");
                d = double.Parse(depth.Text);
                b = double.Parse(min_width.Text);

            }
            else
            {
            if (avilable_conload.Checked)
            {
                var p = double.Parse(con_load.Text);
                var a = double.Parse(loction_con_load.Text);
                var L2 = L - ((C / 2) + a);
                switch (a)
                {
                    case var _ when a < d / 2 :
                        double Qcr1 = ((W * L) / 2) - ((W * C) / 2) + (((p * L2) / L) * (a / (2 * d)));
                        Qcracked.Text = Qcr1.ToString();
                        break;

                    case var _ when a >=d/2 && a <= 2*d:
                        double Qcr2 = ((W * L) / 2) - (W * ((C/2)+(d/2))) + (((p * L2) / L) * (a / (2 * d)));
                        Qcracked.Text = Qcr2.ToString();
                        break;

                    case var _ when  a > 2*d && a <= L :
                        double Qcr3 = ((W * L) / 2) - (W * ((C / 2) + (d / 2)));
                        Qcracked.Text = Qcr3.ToString();
                        break;

                    case var _ when a > L:
                        MessageBox.Show("Error, location of concentrated load out of beam");
                        break;
                }

            }
            else
            {
                double Qcr = (W * L) / 2 - W * ((C / 2) + (d / 2));
                Qcracked.Text = Qcr.ToString();
            }

            double qu = double.Parse(Qcracked.Text) / ((b * d) * Math.Pow(10, 3));
            qu_input.Text = qu.ToString();

            double quncr = .16* Math.Sqrt(fcu/1.5);
            quncr_input.Text = quncr.ToString();

            double qcr = .12 * Math.Sqrt(fcu / 1.5);
            qcr_input.Text = qcr.ToString();

            double qumax = .7 * Math.Sqrt(fcu / 1.5);
            qumax_input.Text = qumax.ToString();

            switch (qu)
            {
                case var _ when qu <= quncr:
                   result.Text = "use min shear Rft (5⌀8/m')";
                   spacing.Text = "200";
                        break;

                case var _ when qu > quncr && qu <= qumax:
                    result.Text = "we have to design for shear Rft";
                    var phi = double.Parse(phi_input.Text);
                    var n = double.Parse(n_input.Text);


                    if (b>=.4 || b>(d+.5)) // n =4 branch
                    {
                        if (n == 4)
                        {
                                var As = (Math.PI * Math.Pow(phi, 2)) / 4;
                                var s = (n * As * (fy / 1.15)) / ((b * Math.Pow(10, 3)) * (qu - qcr));
                                spacing.Text = s.ToString();

                                switch (s)
                                {
                                    case var _ when s >= 200: // more than 200mm -->use min stirrups
                                        spacing_stat.Text = "use min stirrups (5⌀" + phi + "/m')";
                                        No_stirrups_input.Text = 5 + "⌀" + phi + "/m'";
                                        break;

                                    case var _ when s >= 100 && s <= 200: // range from 100 to 200mm
                                        spacing_stat.Text = "ok, S in range from 100 to 200 mm";
                                        var num_stieups = Math.Ceiling(1000 / s); // no. stirrups per meter
                                        No_stirrups_input.Text = num_stieups.ToString() + "⌀" + phi + "/m'";
                                        break;

                                    case var _ when s < 100: // less than 100mm----> another assumption
                                        spacing_stat.Text = "try again, Increase As or n";
                                        break;

                                    default:
                                        break;
                                }
                            }
                        else
                        {
                            MessageBox.Show("must use n 4 because b≥400 mm or b>(d+.5) ");
                        }
                       
                    }
                    else 
                    {
                        var As = (Math.PI*Math.Pow(phi, 2))/4 ;              
                        var s =(n*As*(fy/1.15))/((b*Math.Pow(10,3))*(qu-qcr));
                        spacing.Text = s.ToString();

                        switch (s)
                        {
                            case var _ when s >= 200: // more than 200mm -->use min stirrups
                                spacing_stat.Text = "use min stirrups (5⌀"+phi+"/m')";
                                No_stirrups_input.Text = 5+ "⌀" + phi + "/m'";
                                break;

                            case var _ when s >= 100 && s <= 200: // range from 100 to 200mm
                                spacing_stat.Text = "ok, S in range from 100 to 200 mm";
                                var num_stieups = Math.Ceiling(1000/s); // no. stirrups per meter
                                No_stirrups_input.Text = num_stieups.ToString()+"⌀"+phi+"/m'";
                                break;

                            case var _ when s < 100: // less than 100mm----> another assumption
                                spacing_stat.Text = "try again, Increase As or n";
                                No_stirrups_input.Text = "";
                                    break;

                        }
                    }

                    break;

                case var _ when qu > qumax:
                    result.Text = "unsafe and increase dimensions";
                        spacing_stat.Text = "";
                        No_stirrups_input.Text = "";
                        break;
            }
        }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (avilable_conload.Checked)
            {
                con_load.Enabled = true;
                loction_con_load.Enabled = true;
            }
            else
            {
                con_load.Enabled = false;
                loction_con_load.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void L_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void qu_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void qcr_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

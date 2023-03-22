using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace LinkedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lstbox_ref1.Items.Add("Natheen S");
            lstbox_ref1.Items.Add("Kumar P"); 
            lstbox_ref1.Items.Add("Naveen N");
            lstbox_ref2.Items.Add("Natheen S");
            lstbox_ref2.Items.Add("Kumar P");
            lstbox_ref2.Items.Add("Naveen N");
            //lstbox_ref.Items.Add("Manoj M");
        }
        string val1="";
        string val2 = "";
        string val3 = "";
        LinkedList<string> natheen = new LinkedList<string>();
        LinkedList<string> kumar = new LinkedList<string>();
        LinkedList<string> naveen = new LinkedList<string>();
        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            if (lstbox_ref1.SelectedItem == "Natheen S")
            {
               
                natheen.AddLast(txtbox_name.Text);
            }
            if (lstbox_ref1.SelectedItem == "Kumar P")
            {
                
                kumar.AddLast(txtbox_name.Text);
            }
            if (lstbox_ref1.SelectedItem == "Naveen N")
            {
                
                naveen.AddLast(txtbox_name.Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lstbox_ref2.SelectedItem == "Natheen S")
            {
                foreach(var item in natheen)
                {
                    val1 += item+"\n";
                }
                MessageBox.Show(val1, "Natheen's Referral");
                val1 = string.Empty;
            }
            
            if (lstbox_ref2.SelectedItem == "Kumar P")
            {
                foreach (var item in kumar)
                {
                    val2 += item + "\n";
                }
                MessageBox.Show(val2, "Kumar's Referral");
                val2 = string.Empty;
            }
            if (lstbox_ref2.SelectedItem == "Naveen N")
            {
                foreach (var item in naveen)
                {
                    val3 += item+"\n";
                }
                MessageBox.Show(val3, "Naveen's Referral");
                val3 = string.Empty;
            }
        }
    }
}

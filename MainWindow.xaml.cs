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

namespace Simiancage_CSGO_BuyScript_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CSGO Buyscript Maker For simiancage.org. For Code Please Msg PLEB");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work In Progress.");
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            string key = comboBox.Text;
            string p_gun = "";
            string pistol = "";
            int armour = 0;
            bool defuse = false;
            string nade = "";
            string defuse_kit = "";
            string cb_pistol = comboBox2.Text;
            string cb_primary = comboBox1.Text;
            string armourtype = "";
            string flash1 = "";
            string flash2 = "";
            string flame = "";
            string zeus = "";
            string decoy = "";
            string smoke = "";

            if(key == "")
            {
                MessageBox.Show("No key is selected.");
                return;
            }

            //Defuse Start
            if (checkBox2.IsChecked == true){
                defuse = true;  
            }

            if (defuse == true){
                defuse_kit = "buy defuser; ";
            }
            //Defuse End
            //Zeus start
            if(checkBox9.IsChecked == true)
            {
                zeus = "buy Taser; ";
            }
            //zeus end

            //Pistol Start
            if(cb_pistol == "USP-S/P2000/Glock-18")
            {
                pistol = "buy glock; buy hkp2000; ";
            }

            if(cb_pistol == "P250")
            {
                pistol = "buy p250; " ;
            }

            if (cb_pistol == "Dual Berettas")
            {
                pistol = "buy elite; ";
            }

            if (cb_pistol == "FiveSeven/Tec-9/CZ75-auto")
            {
                pistol = "buy tec9; buy fiveseven; ";
            }

            if (cb_pistol == "R8-Revolver/Degale")
            {
                pistol = "buy deagle; ";
            }
            // Pistol End
    
    //Start Of Primary Guns
            // Heavy Start
             if (cb_primary == "Nova")
            {
                p_gun = "buy nova; ";
            }
            
            if (cb_primary == "XM-1014")
            {
                p_gun = "buy xm1014; ";
            }
                 
            if(cb_primary == "Mag-7/Sawed-Off") 
            {
                p_gun = "buy sawedoff; buy mag7; ";
            }
            
            if(cb_primary == "M249")
            {
                p_gun = "buy m249; ";
            }
            
            if(cb_primary == "Negev")
            {
                p_gun = "buy negev; ";
            }
            //End Of Heavy

            //SMCHEESE Start
            if (cb_primary == "Mac-10/MP-9")
            {
                p_gun = "buy mac10; buy mp9;";
            }

            if (cb_primary == "MP-7")
            {
                p_gun = "buy mp7; ";
            }

            if (cb_primary == "P90")
            {
                p_gun = "buy p90; ";
            }

            if (cb_primary == "PP-Bizion")
            {
                p_gun = "buy bizon; ";
            }

            if (cb_primary == "UMP-45")
            {
                p_gun = "buy ump45; ";
            }
            //SMGs End

            //Rifles Start
            if (cb_primary == "AK-47/M4A1-S")
            {
                p_gun = "buy ak47; buy m4a1;";
            }

            if (cb_primary == "AWP")
            {
                p_gun = "buy awp; ";
            }

            if (cb_primary == "Famas/Galil-AR")
            {
                p_gun = "buy galilar; buy famas; ";
            }

            if (cb_primary == "SSG 08")
            {
                p_gun = "buy ssg08; ";
            }

            if (cb_primary == "SG 553/AUG")
            {
                p_gun = "buy sg556; buy aug; ";
            }

            if (cb_primary == "G3SG1/Scar-20")
            {
                p_gun = "buy g3sg1; buy scar20; ";
            }

            //Rifles End
    //start Armour
            if(checkBox.IsChecked == true)
            {
                armour = 1;
            }

            if(checkBox1.IsChecked == true)
            {
                armour = 2;
            }

            if(armour == 1)
            {
                armourtype = "buy vest; ";
            }

            if (armour == 2)
            {
                armourtype = "buy vesthelm; ";
            }
            //armour end
            //start Grenades

            if (checkBox3.IsChecked == true)
            {
                nade = "buy hegrenade; ";
            }

            if(checkBox5.IsChecked == true)
            {
                flame = "buy molotov; buy incgrenade; ";
            }

            if(checkBox8.IsChecked == true)
            {
                decoy = "buy decoy; ";
            }

            if(checkBox7.IsChecked == true)
            {
                smoke = "buy smokegrenade; ";
            }



            textBox.Text = "bind " + '"' + key + '"' + " " + '"' + p_gun + pistol + armourtype + defuse_kit + zeus + flash1 + flash2 + nade + flame + decoy + smoke + '"';
            

        }


    }
}

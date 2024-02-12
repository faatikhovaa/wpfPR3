using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для rogue.xaml
    /// </summary>
    public partial class rogue : Page
    {
        List<string> UnitsList = new List<string>();

        Warrior warrior = new Warrior(30, 15, 10, 25);
        Rogue raogue = new Rogue(30, 15, 20, 20);
        Wizard wizard = new Wizard(20, 35, 15, 15);
        public rogue()
        {
            UnitsList.Add(warrior.Tip);
            UnitsList.Add(raogue.Tip);
            UnitsList.Add(wizard.Tip);
            InitializeComponent();
           
            Refresh();
        }
        private void Refresh()
        {
            warrior.Uppdate();
            HealthTbl.Text = warrior.Health.ToString();
            ManaTbl.Text = warrior.Mana.ToString();
            StrengthTbx.Text = warrior.Strength.ToString();
            DexterityTbx.Text = warrior.Dexterity.ToString();
            InteligencTbx.Text = warrior.Inteligence.ToString();
            VitalityTbx.Text = warrior.Vitality.ToString();
            PickDamageTbl.Text = warrior.PickDamage.ToString();
            ArmorTbl.Text = warrior.Armor.ToString();
            MagicDamageTbl.Text = warrior.MagicDamage.ToString();
            MagicArmorBtl.Text = warrior.MagigArmor.ToString();
            CrtChanseTbl.Text = warrior.CtrChanse.ToString();
            CrtDamageTbl.Text = warrior.CtrDamage.ToString();

        } 
    }
}

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
            UnitTbl.Text = warrior.Tip;
            Refresh();
        }
        private void Refresh()
        {

            if (UnitTbl.Text == "Warrior")
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
            else if (UnitTbl.Text == "Rogue")
            {
                raogue.Uppdate();
                HealthTbl.Text = raogue.Health.ToString();
                ManaTbl.Text = raogue.Mana.ToString();
                StrengthTbx.Text = raogue.Strength.ToString();
                DexterityTbx.Text = raogue.Dexterity.ToString();
                InteligencTbx.Text = raogue.Inteligence.ToString();
                VitalityTbx.Text = raogue.Vitality.ToString();
                PickDamageTbl.Text = raogue.PickDamage.ToString();
                ArmorTbl.Text = raogue.Armor.ToString();
                MagicDamageTbl.Text = raogue.MagicDamage.ToString();
                MagicArmorBtl.Text = raogue.MagigArmor.ToString();
                CrtChanseTbl.Text = raogue.CtrChanse.ToString();
                CrtDamageTbl.Text = raogue.CtrDamage.ToString();

            }
            else if (UnitTbl.Text == "Wizard")
            {
                wizard.Uppdate();
                HealthTbl.Text = wizard.Health.ToString();
                ManaTbl.Text = wizard.Mana.ToString();
                StrengthTbx.Text = wizard.Strength.ToString();
                DexterityTbx.Text = wizard.Dexterity.ToString();
                InteligencTbx.Text = wizard.Inteligence.ToString();
                VitalityTbx.Text = wizard.Vitality.ToString();
                PickDamageTbl.Text = wizard.PickDamage.ToString();
                ArmorTbl.Text = wizard.Armor.ToString();
                MagicDamageTbl.Text = wizard.MagicDamage.ToString();
                MagicArmorBtl.Text = wizard.MagigArmor.ToString();
                CrtChanseTbl.Text = wizard.CtrChanse.ToString();
                CrtDamageTbl.Text = wizard.CtrDamage.ToString();

            }
        }
    }
}

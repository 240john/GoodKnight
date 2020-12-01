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
using static System.Convert;

namespace GoodKnight
{
    public partial class GoodKnight : Form
    {
        int iterations = 0;
        int storynum = 0;
        int luck = 0;
        string[] story = {"","","",""};
        LightKnight light = new LightKnight();
        HeavyKnight heavy = new HeavyKnight();
        MagicKnight magic = new MagicKnight();
        Dragon dragon = new Dragon();
        Bear bear = new Bear();
        Spider spider = new Spider();
        Bees bees = new Bees();
        GiantToad giant_toad = new GiantToad();
        Knight knight = new Knight();
        AdamantArmor adamant_armor = new AdamantArmor();
        SteelArmor steel_armor = new SteelArmor();
        IronArmor iron_armor = new IronArmor();
        LeatherArmor leather_armor = new LeatherArmor();
        WoodenSword wooden_sword = new WoodenSword();
        IronSword iron_sword = new IronSword();
        GoldenSword golden_sword = new GoldenSword();
        DiamondSword diamond_sword = new DiamondSword();
        ShinySword shiny_sword = new ShinySword();
        KingsSword kings_sword = new KingsSword();
        Story gameStory = new Story();
        StreamWriter sw = File.CreateText(@"C:\Users\DSU Student\Documents\GoodKnight\GoodKnight.txt");
        public GoodKnight()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDifficulty_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            nudDifficulty.Enabled = false;
            comboBox3.Enabled = false;
            gameStory = new Story(ToInt32(nudDifficulty.Text));
            luck = ToInt32(nudDifficulty.Text);
            if (luck == 1)
            { 
                luck = 3;
                knight.Health = 30;
            }
            else if (luck == 3)
                luck = 1;
            else
                knight.Health = 60;

            if (comboBox3.Text == "Light Knight")
            {
                var light = new LightKnight(ToInt32(nudDifficulty.Text));
                txtHealth.Text = light.Health.ToString();
                leather_armor.calculateDeflection(luck, false);
                iron_armor.calculateDeflection(luck, false);
                steel_armor.calculateDeflection(luck, false);
                adamant_armor.calculateDeflection(luck, false);
            }
            else if (comboBox3.Text == "Heavy Knight")
            {
                var heavy = new HeavyKnight(ToInt32(nudDifficulty.Text));
                txtHealth.Text = heavy.Health.ToString();
                leather_armor.calculateDeflection(luck, true);
                iron_armor.calculateDeflection(luck, true);
                steel_armor.calculateDeflection(luck, true);
                adamant_armor.calculateDeflection(luck, true);
            }
            else if (comboBox3.Text == "Magic Knight")
            {
                var magic = new MagicKnight(ToInt32(nudDifficulty.Text));
                txtHealth.Text = magic.Health.ToString();
                leather_armor.calculateDeflection(luck, false);
                iron_armor.calculateDeflection(luck, false);
                steel_armor.calculateDeflection(luck, false);
                adamant_armor.calculateDeflection(luck, false);
            }
            sw.Write("You stumble upon a cave. As a knight, you must do what knights do, and meander into " +
                "the cave to ensure the safety of the people! You find three paths: one well-lit path, " +
                " one with a dark path ahead of you, and " +
                "another path that leads deeper into the ground." + Environment.NewLine + "Which will you take?");
            txtStory.Text = "You stumble upon a cave. As a knight, you must do what knights do, and meander into " +
                "the cave to ensure the safety of the people! You find three paths: one well-lit path, " +
                " one with a dark path ahead of you, and " +
                "another path that leads deeper into the ground." + Environment.NewLine + "Which will you take?";
            txtChoice.Text = "1) The well-lit path." + Environment.NewLine + "2) The path with a single torch." +
                Environment.NewLine + "3) The path that leads deeper into the earth.";
        }

        private void txtStory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //button 1
            story_decider(1, iterator(), storynum);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            //button 2
            story_decider(2, iterator(), storynum);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            //button 3
            story_decider(3, iterator(), storynum);
        }

        private void story_decider(int chc, int iter, int stor)
        {
            // start by saying outcome of last choice, done using switch case
            // present next story and choices using story class
            // iterator is used to determine end of game (9th turn send the dragon)
            int health = ToInt32(txtHealth.Text);
            //calculate light, heavy, and magic damage and all enemies damage depending on armor/weapon equipped
            switch(cmbWeapon.SelectedItem)
            {
                case "Wooden Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + wooden_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + wooden_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + wooden_sword.DamageBoost;
                    break;
                case "Iron Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + iron_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + iron_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + iron_sword.DamageBoost;
                    break;
                case "Golden Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + golden_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + golden_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + golden_sword.DamageBoost;
                    break;
                case "Diamond Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + diamond_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + diamond_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + diamond_sword.DamageBoost;
                    break;
                case "Shiny Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + shiny_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + shiny_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + shiny_sword.DamageBoost;
                    break;
                case "King's Sword":
                    if (comboBox3.Text == "Light Knight")
                        light.Damage = light.Damage + kings_sword.DamageBoost;
                    else if (comboBox3.Text == "Heavy Knight")
                        heavy.Damage = heavy.Damage + kings_sword.DamageBoost;
                    else if (comboBox3.Text == "Magic Knight")
                        magic.Damage = magic.Damage + kings_sword.DamageBoost;
                    break;
            }

            switch (cmbArmor.SelectedItem)
            {
                case "Leather Armor":
                    dragon.Damage = dragon.Damage - leather_armor.DamageDeflected;
                    bear.Damage = bear.Damage - leather_armor.DamageDeflected;
                    giant_toad.Damage = giant_toad.Damage - leather_armor.DamageDeflected;
                    spider.Damage = spider.Damage - leather_armor.DamageDeflected;
                    break;
                case "Iron Armor":
                    dragon.Damage = dragon.Damage / iron_armor.DamageDeflected;
                    bear.Damage = bear.Damage / iron_armor.DamageDeflected;
                    giant_toad.Damage = giant_toad.Damage / iron_armor.DamageDeflected;
                    spider.Damage = spider.Damage / iron_armor.DamageDeflected;
                    bees.Damage = bees.Damage / iron_armor.DamageDeflected;
                    break;
                case "Steel Armor":
                    dragon.Damage = dragon.Damage / steel_armor.DamageDeflected;
                    bear.Damage = bear.Damage / steel_armor.DamageDeflected;
                    giant_toad.Damage = giant_toad.Damage / steel_armor.DamageDeflected;
                    spider.Damage = spider.Damage / steel_armor.DamageDeflected;
                    bees.Damage = bees.Damage / steel_armor.DamageDeflected;
                    break;
                case "Adamant Armor":
                    dragon.Damage = dragon.Damage / adamant_armor.DamageDeflected;
                    bear.Damage = bear.Damage / adamant_armor.DamageDeflected;
                    giant_toad.Damage = giant_toad.Damage / adamant_armor.DamageDeflected;
                    spider.Damage = spider.Damage / adamant_armor.DamageDeflected;
                    bees.Damage = bees.Damage / adamant_armor.DamageDeflected;
                    break;
            }

            switch (stor)
            {
                case 0:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You walk down the well-lit path. ");
                            txtStory.Text = "You walk down the well-lit path. ";
                            break;
                        case 2:
                            sw.WriteLine("You grab the torch off the ground then continue down the dark path. ");
                            txtStory.Text = "You grab the torch off the ground then continue down the dark path. ";
                            break;
                        case 3:
                            sw.WriteLine("You start down the dark path that slopes down and immediately slip on " +
                                "the wet floor you could not see. ");
                            txtStory.Text = "You start down the dark path that slopes down and immediately slip on " + 
                                "the wet floor you could not see. ";
                            health -= 1;
                            break;
                    }
                    break;
                case 1:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You grab the pickaxe and break through the opening, but exhaust yourself in the" +
                                " process. When you bust through a Wolf pounces on you and kills you. ");
                            txtStory.Text = "You grab the pickaxe and break through the opening, but exhaust yourself in the" +
                                " process. When you bust through a Wolf pounces on you and kills you. ";
                            health = health - 50;
                            break;
                        case 2:
                            sw.WriteLine("You peak through the opening and notice a wolf on the otherside, " +
                                "and decide not to break through and continue on. ");
                            txtStory.Text = "You peak through the opening and notice a wolf on the otherside, " +
                                "and decide not to break through and continue on. ";
                            break;
                        case 3:
                            sw.WriteLine("You continue on and act as if you never saw the opening. ");
                            txtStory.Text = "You continue on and act as if you never saw the opening. ";
                            break;
                    }
                    break;
                case 21:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You turn and run as fast as you can from the dragon. You slip and get " +
                                "clawed by the dragon, but narrowly escape. ");
                            txtStory.Text = "You turn and run as fast as you can from the dragon. You slip and get " +
                                "clawed by the dragon, but narrowly escape. ";
                            health = health - 3;
                            break;
                        case 2:
                            while(health > 0 && dragon.Health > 0)
                            {
                                health = health - dragon.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    dragon.Health = dragon.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    dragon.Health = dragon.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    dragon.Health = dragon.Health - magic.Damage;
                            }
                            cmbWeapon.Items.Add(dragon.Drop);
                            sw.WriteLine("You have defeated the dragon! He dropped the King's Sword! You can equip it. ");
                            txtStory.Text = "You have defeated the dragon! He dropped the King's Sword! You can equip it. ";
                            break;
                        case 3:
                            sw.WriteLine("You shoot an arrow into the wing of the dragon which stuns and cripples it enough for you" +
                                " to narrowly escape being clawed! ");
                            txtStory.Text = "You shoot an arrow into the wing of the dragon which stuns and cripples it enough for you" +
                                " to narrowly escape being clawed! ";
                            break;
                    }
                    break;
                case 22:
                    switch (chc)
                    {
                        case 1:
                            while (health > 0 && bear.Health > 0)
                            {
                                health = health - bear.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    bear.Health = bear.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    bear.Health = bear.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    bear.Health = bear.Health - magic.Damage;
                            }
                            cmbWeapon.Items.Add(bear.Drop);
                            sw.WriteLine("You have defeated the Bear! He dropped the Golden Sword! You can equip it. ");
                            txtStory.Text = "You have defeated the Bear! He dropped the Golden Sword! You can equip it. ";
                            break;
                        case 2:
                            sw.WriteLine("You take some honey out of your satchel, because of course you have honey with you." +
                                "You distract the bear enough to slip by. ");
                            txtStory.Text = "You take some honey out of your satchel, because of course you have honey with you." +
                                "You distract the bear enough to slip by. ";
                            break;
                        case 3:
                            sw.WriteLine("You throw a rock at the Bear's head which diorients so you can slip by, but as you just " +
                                "make it past it swipes you with its bear claw. ");
                            txtStory.Text = "You throw a rock at the Bear's head which diorients so you can slip by, but as you just " +
                                "make it past it swipes you with its bear claw. ";
                            health -= 3;
                            break;
                    }
                    break;
                case 23:
                    switch (chc)
                    {
                        case 1:
                            while (health > 0 && giant_toad.Health > 0)
                            {
                                health = health - giant_toad.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    giant_toad.Health = giant_toad.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    giant_toad.Health = giant_toad.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    giant_toad.Health = giant_toad.Health - magic.Damage;
                            }
                            cmbWeapon.Items.Add(giant_toad.Drop);
                            sw.WriteLine("You have defeated the Giant Toad! He dropped an Iron Sword! You can equip it. ");
                            txtStory.Text = "You have defeated the Giant Toad! He dropped an Iron Sword! You can equip it. ";
                            break;
                        case 2:
                            sw.WriteLine("You attempt to run past the Giant Toad, and, surprisingly, it is unharmful. ");
                            txtStory.Text = "You attempt to run past the Giant Toad, and, surprisingly, it is unharmful. ";
                            break;
                        case 3:
                            sw.WriteLine("You try to reason with the Giant Toad, but it grows irritated by your voice and attacks you. ");
                            txtStory.Text = "You try to reason with the Giant Toad, but it grows irritated by your voice and attacks you. ";
                            while (health > 0 && giant_toad.Health > 0)
                            {
                                health = health - giant_toad.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    giant_toad.Health = giant_toad.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    giant_toad.Health = giant_toad.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    giant_toad.Health = giant_toad.Health - magic.Damage;
                            }
                            cmbWeapon.Items.Add(giant_toad.Drop);
                            health -= 3;
                            if (health > 0)
                            {
                                sw.WriteLine("You have defeated the Irritated Giant Toad! He dropped an Iron Sword! You can equip it. ");
                                txtStory.Text += "You have defeated the Irritated Giant Toad! He dropped an Iron Sword! You can equip it. ";
                            }
                            break;
                    }
                    break;
                case 24:
                    switch (chc)
                    {
                        case 1:
                            while (health > 0 && spider.Health > 0)
                            {
                                health = health - spider.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    spider.Health = spider.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    spider.Health = spider.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    spider.Health = spider.Health - magic.Damage;
                            }
                            sw.WriteLine("You have defeated the Spider! ");
                            txtStory.Text = "You have defeated the Spider! ";
                            break;
                        case 2:
                            sw.WriteLine("You simply squash the spider with your foot, how cruel. ");
                            txtStory.Text = "You simply squash the spider with your foot, how cruel. ";
                            break;
                        case 3:
                            sw.WriteLine("You walk past the spider very carefully. ");
                            txtStory.Text = "You walk past the spider very carefully. ";
                            break;
                    }
                    break;
                case 25:
                    switch (chc)
                    {
                        case 1:
                            while (health > 0 && bees.Health > 0)
                            {
                                health = health - bees.Damage;
                                if (comboBox3.Text == "Light Knight")
                                    bees.Health = bees.Health - light.Damage;
                                else if (comboBox3.Text == "Heavy Knight")
                                    bees.Health = bees.Health - heavy.Damage;
                                else if (comboBox3.Text == "Magic Knight")
                                    bees.Health = bees.Health - magic.Damage;
                            }
                            sw.WriteLine("You have defeated the Bees! ");
                            txtStory.Text = "You have defeated the Bees! ";
                            break;
                        case 2:
                            if (comboBox3.Text == "Light Knight" || comboBox3.Text == "Heavy Knight")
                            {
                                sw.WriteLine("Somehow you forgot you do not have an ounce of magic in your soul. The bees swarm you. ");
                                txtStory.Text = "Somehow you forgot you do not have an ounce of magic in your soul. The bees swarm you. ";
                                health = health - 2;
                            }
                            else if (comboBox3.Text == "Magic Knight")
                                txtStory.Text = "You have defeated the Bees with fire magic! ";
                            break;
                        case 3:
                            sw.WriteLine("You attempt to run through the bees as quickly as you possibly can. You only get stun" +
                                " a few times. ");
                            txtStory.Text = "You attempt to run through the bees as quickly as you possibly can. You only get stun" +
                                " a few times. ";
                            health -= 1;
                            break;
                    }
                    break;
                case 4:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You jump across the gap and slip on the otherside, because of course you did. ");
                            txtStory.Text = "You jump across the gap and slip on the otherside, because of course you did. ";
                            health--;
                            break;
                        case 2:
                            sw.WriteLine("You knock down the support beam to attempt to use it to cross the gap, but neglect to " +
                                "realize that was the only thing holding up the cave. ");
                            txtStory.Text = "You knock down the support beam to attempt to use it to cross the gap, but neglect to " +
                                "realize that was the only thing holding up the cave. ";
                            health = health - 50;
                            break;
                        case 3:
                            sw.WriteLine("You lasso a rope up to the support beam above you and swing across rather gracefully. ");
                            txtStory.Text = "You lasso a rope up to the support beam above you and swing across rather gracefully. ";
                            break;
                    }
                    break;
                case 5:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You attempt to pry the sword from the skeleton's hand; it swipes back with the sword, " +
                                "how greedy of you. ");
                            txtStory.Text = "You attempt to pry the sword from the skeleton's hand; it swipes back with the sword, " +
                                "how greedy of you. ";
                            health = health - 5;
                            break;
                        case 2:
                            sw.WriteLine("You continue on past the skeleton and act as if you never saw it. ");
                            txtStory.Text = "You continue on past the skeleton and act as if you never saw it. ";
                            break;
                        case 3:
                            cmbWeapon.Items.Add("Shiny Sword");
                            cmbWeapon.Items.Remove(cmbWeapon.SelectedItem);
                            cmbWeapon.SelectedItem = "Shiny Sword";
                            sw.WriteLine("You lay your current weapon in the skeleton's hand and grab the one in his. ");
                            txtStory.Text = "You lay your current weapon in the skeleton's hand and grab the one in his. ";
                            break;
                    }
                    break;
                case 6:
                    switch (chc)
                    {
                        case 1:
                            cmbArmor.Items.Add("Steel Armor");
                            sw.WriteLine("You grab the key and open the chest. You find some Steel Armor! ");
                            txtStory.Text = "You grab the key and open the chest. You find some Steel Armor! ";
                            break;
                        case 2:
                            sw.WriteLine("You continue on past chest and act as if you never saw it. ");
                            txtStory.Text = "You continue on past chest and act as if you never saw it. ";
                            break;
                        case 3:
                            sw.WriteLine("You destroy the key but hurt your hand in the process and rightly feel a bit idiotic. ");
                            txtStory.Text = "You destroy the key but hurt your hand in the process and rightly feel a bit idiotic. ";
                            health--;
                            break;
                    }
                    break;
                case 7:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You push the boulder down the hill and hear a large crash near the bottom. You crawl " +
                                "down the slope to see what happened. You crushed a horse, how evil. ");
                            txtStory.Text = "You push the boulder down the hill and hear a large crash near the bottom. You crawl " +
                                "down the slope to see what happened. You crushed a horse, how evil. ";
                            break;
                        case 2:
                            sw.WriteLine("You notice a chained horse at the bottom. You slide down to the bottom and free the horse, " +
                                "hurting yourself in the process. " +
                                "You find a health potion sitting on a crate. You drink it. ");
                            txtStory.Text = "You notice a chained horse at the bottom. You slide down to the bottom and free the horse, " +
                                "hurting yourself in the process. " +
                                "You find a health potion sitting on a crate. You drink it. ";
                            health = health - 2;
                            health = health + 3;
                            break;
                        case 3:
                            sw.WriteLine("You grappel down the slope using the boulder. You free the horse at the bottom and find" +
                                " a health potion sitting on a crate. You drink it. ");
                            txtStory.Text = "You grappel down the slope using the boulder. You free the horse at the bottom and find" +
                                " a health potion sitting on a crate. You drink it. ";
                            health = health + 3;
                            break;
                    }
                    break;
                case 8:
                    switch (chc)
                    {
                        case 1:
                            cmbArmor.Items.Add("Iron Armor");
                            sw.WriteLine("You smith some Iron Armor. You can equip it. ");
                            txtStory.Text = "You smith some Iron Armor. You can equip it. ";
                            break;
                        case 2:
                            cmbArmor.Items.Add("Adamant Armor");
                            sw.WriteLine("You mine ore from the vein and create Adamant Armor, although you smash your finger " +
                                "with a hammer in the process. ");
                            txtStory.Text = "You mine ore from the vein and create Adamant Armor, although you smash your finger " +
                                "with a hammer in the process. ";
                            health = health - 2;
                            break;
                        case 3:
                            sw.WriteLine("You ignore the anvil and continue on. ");
                            txtStory.Text = "You ignore the anvil and continue on. ";
                            break;
                    }
                    break;
                case 9:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You walk across the rocks. You left your armor on, and burned your skin against " +
                                "the hot metal. ");
                            txtStory.Text = "You walk across the rocks. You left your armor on, and burned your skin against " +
                                "the hot metal. ";
                            health = health - 4;
                            break;
                        case 2:
                            cmbArmor.Items.Remove(cmbArmor.SelectedItem);
                            cmbArmor.Items.Add("");
                            cmbArmor.SelectedItem = "";
                            cmbArmor.Items.Remove("");
                            sw.WriteLine("You remove your armor and walk across the rocks, managing to not slip in. ");
                            txtStory.Text = "You remove your armor and walk across the rocks, managing to not slip in. ";
                            break;
                        case 3:
                            sw.WriteLine("You attempt to run across the rocks and slip into the lava. ");
                            txtStory.Text = "You attempt to run across the rocks and slip into the lava. ";
                            health = health - 50;
                            break;
                    }
                    break;
                case 10:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You take the ring to give the princess, perhaps she'll like this one unlike the last." +
                                " You hurt your own feelings. ");
                            txtStory.Text = "You take the ring to give the princess, perhaps she'll like this one unlike the last." +
                                " You hurt your own feelings. ";
                            health--;
                            break;
                        case 2:
                            sw.WriteLine("You decide against taking the ring, perhaps it still belongs to somebody. ");
                            txtStory.Text = "You decide against taking the ring, perhaps it still belongs to somebody. ";
                            break;
                        case 3:
                            sw.WriteLine("You reminisce about the time the princess rejected your engagement ring. That hurt." +
                                " In your distraction, a mosquito bites you in the neck. ");
                            txtStory.Text = "You reminisce about the time the princess rejected your engagement ring. That hurt." +
                                " In your distraction, a mosquito bites you in the neck. ";
                            health = health - 3;
                            break;
                    }
                    break;
                case 11:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You get closer to inspect the banana peel, of course looking for treasure. Unfortunately," +
                                " it is just a banana peel, so you throw it back onto the ground, and slip on it as you walk " +
                                "past. Impressive. ");
                            txtStory.Text = "You get closer to inspect the banana peel, of course looking for treasure. Unfortunately," +
                                " it is just a banana peel, so you throw it back onto the ground, and slip on it as you walk " +
                                "past. Impressive. ";
                            health = health - 2;
                            break;
                        case 2:
                            sw.WriteLine("You carefully walk around the banana peel and continue on. ");
                            txtStory.Text = "You carefully walk around the banana peel and continue on. ";
                            break;
                        case 3:
                            sw.WriteLine("You pick up the banana peel off of the ground and feel good about what you did. ");
                            txtStory.Text = "You pick up the banana peel off of the ground and feel good about what you did. ";
                            health = health + 3;
                            break;
                    }
                    break;
                case 12:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You attempt to swim across the lake to the other side and panic as you start sinking." +
                                " You drown. ");
                            txtStory.Text = "You attempt to swim across the lake to the other side and panic as you start sinking." +
                                " You drown. ";
                            health = health - 50;
                            break;
                        case 2:
                            cmbWeapon.Items.Add("Diamond Sword");
                            cmbArmor.Items.Remove(cmbArmor.SelectedItem);
                            cmbArmor.Items.Add("");
                            cmbArmor.SelectedItem = "";
                            cmbArmor.Items.Remove("");
                            sw.WriteLine("You purposefully walk to the bottom of the water using your armor and grab " +
                                "a Diamond Sword off the ground! You can equip it. You then take off your armor and cross " +
                                "to the other side. ");
                            txtStory.Text = "You purposefully walk to the bottom of the water using your armor and grab " +
                                "a Diamond Sword off the ground! You can equip it. You then take off your armor and cross " +
                                "to the other side. ";
                            break;
                        case 3:
                            cmbArmor.Items.Remove(cmbArmor.SelectedItem);
                            cmbArmor.Items.Add("");
                            cmbArmor.SelectedItem = "";
                            cmbArmor.Items.Remove("");
                            sw.WriteLine("You take off your armor and swim to the other side of the water. Smart decision. ");
                            txtStory.Text = "You take off your armor and swim to the other side of the water. Smart decision. ";
                            break;
                    }
                    break;
                case 13:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You turn around and go another way. ");
                            txtStory.Text = "You turn around and go another way. ";
                            break;
                        case 2:
                            sw.WriteLine("You feel your hand across the back wall as if you were looking for a hidden switch." +
                                " A snake bites your ankle as you waste your time. ");
                            txtStory.Text = "You feel your hand across the back wall as if you were looking for a hidden switch." +
                                " A snake bites your ankle as you waste your time. ";
                            health--;
                            break;
                        case 3:
                            sw.WriteLine("As you turn a snake is waiting for you. You kill it swiftly. ");
                            txtStory.Text = "As you turn a snake is waiting for you. You kill it swiftly. ";
                            break;
                    }
                    break;
                case 14:
                    switch (chc)
                    {
                        case 1:
                            sw.WriteLine("You set the cobwebs on fire with your torch and end up burning your arm. ");
                            txtStory.Text = "You set the cobwebs on fire with your torch and end up burning your arm. ";
                            health = health - 4;
                            break;
                        case 2:
                            sw.WriteLine("You slash through the cobwebs, although you severely underestimated how long " +
                                "you'd be swinging and become exhausted. ");
                            txtStory.Text = "You slash through the cobwebs, although you severely underestimated how long " +
                                "you'd be swinging and become exhausted. ";
                            health = health - 2;
                            break;
                        case 3:
                            if (comboBox3.Text == "Light Knight" || comboBox3.Text == "Heavy Knight")
                            {
                                sw.WriteLine("It seems you have forgotten you do not have an ounce of magic in your soul. " +
                                    "You decide to just run through the cobwebs, get stuck, and watch as a giant tarantula begins " +
                                    "spinning you into a web. ");
                                txtStory.Text = "It seems you have forgotten you do not have an ounce of magic in your soul. " +
                                    "You decide to just run through the cobwebs, get stuck, and watch as a giant tarantula begins " +
                                    "spinning you into a web. ";
                                health = health - 50;
                            }
                            else if (comboBox3.Text == "Magic Knight")
                            {
                                sw.WriteLine("You burn the cobwebs with your fire magic and continue on. ");
                                txtStory.Text = "You burn the cobwebs with your fire magic and continue on. ";
                            }
                            break;
                    }
                    break;
            }
            if (health < 1)
            {
                btnStart.Visible = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btnClose.Visible = true;
                sw.WriteLine("You have perished. Game Over.");
                txtChoice.Text = "You have perished. Game Over.";
                txtHealth.Text = "0";
            }
            else if(iter == 9)
            {
                sw.WriteLine("You finally made it out of the otherside of the cave only to meet a fellow knight who beat you to" +
                    " the punch. You choose to fight him.");
                txtStory.Text += "You finally made it out of the otherside of the cave only to meet a fellow knight who beat you to" +
                    " the punch. You choose to fight him.";
                while (health > 0 && knight.Health > 0)
                {
                    health = health - knight.Damage;
                    if (comboBox3.Text == "Light Knight")
                        knight.Health = knight.Health - light.Damage;
                    else if (comboBox3.Text == "Heavy Knight")
                        knight.Health = knight.Health - heavy.Damage;
                    else if (comboBox3.Text == "Magic Knight")
                        knight.Health = knight.Health - magic.Damage;
                }
                if (health < 1)
                {
                    btnStart.Visible = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btnClose.Visible = true;
                    sw.WriteLine("You have perished. Game Over.");
                    txtChoice.Text = "You have perished. Game Over.";
                    txtHealth.Text = "0";
                }
                else
                {
                    btnStart.Visible = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btnClose.Visible = true;
                    txtHealth.Text = health.ToString();
                    sw.WriteLine("Congratulations you have won!");
                    txtChoice.Text = "Congratulations you have won!";
                }
            }
            else
            {
                txtHealth.Text = health.ToString();

                story[0] = gameStory.story;
                story[1] = gameStory.choice1;
                story[2] = gameStory.choice2;
                story[3] = gameStory.choice3;
                storynum = gameStory.storynum;

                sw.WriteLine(story[0]);
                sw.Flush();
                txtStory.Text += story[0];
                txtChoice.Text = story[1] + Environment.NewLine + story[2] + Environment.NewLine + story[3];
                gameStory.StoryRandomization(luck);
            }
        }

        private int iterator()
        {
            iterations++;
            return iterations;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the program
            sw.Close();
            this.Close();
        }
    }
}
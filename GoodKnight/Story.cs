using System;
using System.Collections.Generic;
using System.Text;
using static System.Random;

namespace GoodKnight
{
	public class Story
	{
		public string story;
		public string choice1;
		public string choice2;
		public string choice3;
		string drop;
		public int storynum;
		int luck;
		bool isDrop;

		public Story(int luck)
        {
			StoryRandomization(luck);
        }
		public Story()
		{
		}

		//change this so that the constructor runs this method then sets story, choice1, choice2, choice3, and storynum
		public void StoryRandomization(int luck)
		{
			string choice2enemy = Enemy.RandomizeEnemy(luck);
			string choice3enemy = Enemy.RandomizeEnemy(luck);
			string choice4enemy = Enemy.RandomizeEnemy(luck);
			string[] choices2 = { "", "", "" };
			string[] choices3 = { "", "", "" };
			string[] choices4 = { "", "", "" };
			string story2 = "You encounter " + choice2enemy + "! What will you do?";
			string story3 = "You encounter " + choice3enemy + "! What will you do?";
			string story4 = "You encounter " + choice4enemy + "! What will you do?";

			string[] stories = {"You are very clumsy and walk into a cave wall. The wall crumbles enough to show an " +
					"opening of light. What will you do?", story2, story3, story4 ,"As you continue on, you notice a decently" + 
					" large gap. What will you do?","You come across a skeleton with a nice sword stuck in the bones " + 
					"of his hands. What will you do?","You find a key on the ground and down the ways, see a" + 
					" chest. What will you do?","You come across a giant boulder sitting atop a steep decline." +
					" What will you do?","You find a blacksmith's anvil complete with the tools necessary" +
					" to create something. What will you do?","You find a pool of lava with a small path of jaggedy" +
					" rocks that run across it, what will you do?","You find a beautiful ring being displayed upon a" +
					" pedestal. What will you do?","You find what looks to be a banana peel sitting on the ground." +
					" What will you do?","You come across a pool of water with what looks to be a ledge on the other" +
					" side. What will you do?","You come across a dead end, but you feel something eerie." +
					" What will you do?","As you walk along the path it suddenly becomes more and more cobwebby, eventually" +
					" blocking the way entirely. What do you do?",choice2enemy,choice3enemy,choice4enemy};

			string[] choices1 = { "Grab the pickaxe sitting behind you and mine through the rubble.", "Peak through " +
					"the opening then decide what to do.", "Continue on and act as if you never saw it." };

			if (choice2enemy == "a Dragon")
			{
				choices2[0] = "Run for your life!";
				choices2[1] = "Fight the dragon like a real knight would!";
				choices2[2] = "Shoot an arrow into the wing of the dragon and run!";
			}
			else if (choice2enemy == "a Bear")
			{
				choices2[0] = "Fight the Bear.";
				choices2[1] = "Distract the Bear with some honey.";
				choices2[2] = "Throw a rock at the Bear's head and run past.";
			}
			else if (choice2enemy == "a Giant Toad")
			{
				choices2[0] = "Slay the Giant Toad.";
				choices2[1] = "Run past the Toad.";
				choices2[2] = "Reason with the Toad.";
			}
			else if (choice2enemy == "a Spider")
			{
				choices2[0] = "Slay the Spider.";
				choices2[1] = "It is quite small, squah it with your foot.";
				choices2[2] = "Walk past, it has to be harmless, right?";
			}
			else if (choice2enemy == "some Bees")
			{
				choices2[0] = "Swing your sword at the Bees.";
				choices2[1] = "Use fire magic against the Bees.";
				choices2[2] = "Run through the Bees as fast as you can.";
			}
			if (choice3enemy == "a Dragon")
			{
				choices3[0] = "Run for your life!";
				choices3[1] = "Fight the dragon like a real knight would!";
				choices3[2] = "Shoot an arrow into the wing of the dragon and run!";
			}
			else if (choice3enemy == "a Bear")
			{
				choices3[0] = "Fight the Bear.";
				choices3[1] = "Distract the Bear with some honey.";
				choices3[2] = "Throw a rock at the Bear's head and run past.";
			}
			else if (choice3enemy == "a Giant Toad")
			{
				choices3[0] = "Slay the Giant Toad.";
				choices3[1] = "Run past the Toad.";
				choices3[2] = "Reason with the Toad.";
			}
			else if (choice3enemy == "a Spider")
			{
				choices3[0] = "Slay the Spider.";
				choices3[1] = "It is quite small, squah it with your foot.";
				choices3[2] = "Walk past, it has to be harmless, right?";
			}
			else if (choice3enemy == "some Bees")
			{
				choices3[0] = "Swing your sword at the Bees.";
				choices3[1] = "Use fire magic against the Bees.";
				choices3[2] = "Run through the Bees as fast as you can.";
			}
			if (choice4enemy == "a Dragon")
			{
				choices4[0] = "Run for your life!";
				choices4[1] = "Fight the dragon like a real knight would!";
				choices4[2] = "Shoot an arrow into the wing of the dragon and run!";
			}
			else if (choice4enemy == "a Bear")
			{
				choices4[0] = "Fight the Bear.";
				choices4[1] = "Distract the Bear with some honey.";
				choices4[2] = "Throw a rock at the Bear's head and run past.";
			}
			else if (choice4enemy == "a Giant Toad")
			{
				choices4[0] = "Slay the Giant Toad.";
				choices4[1] = "Run past the Toad.";
				choices4[2] = "Reason with the Toad.";
			}
			else if (choice4enemy == "a Spider")
			{
				choices4[0] = "Slay the Spider.";
				choices4[1] = "It is quite small, squah it with your foot.";
				choices4[2] = "Walk past, it has to be harmless, right?";
			}
			else if (choice4enemy == "some Bees")
			{
				choices4[0] = "Swing your sword at the Bees.";
				choices4[1] = "Use fire magic against the Bees.";
				choices4[2] = "Run through the Bees as fast as you can.";
			}

			string[] choices5 = { "Jump across the gap!", "Knock down a rickety wooden support post and use it" + 
					" to get across.", "Lasso a rope on the beam above you and swing across." };
			string[] choices6 = { "Pry the sword from the skeleton's hand.", "Continue on past the skeleton.", "Place " + 
					"the sword you are holding in the skeleton's hand before grabbing his." };
			string[] choices7 = { "Grab the key and open the chest.", "Continue on and act as if you never saw the" +
					" chest.", "Destroy the key." };
			string[] choices8 = { "Push the boulder down the hill.", "Check to see what is down the hill.", 
					"Tie a rope around the boulder and grappel down the hill." };
			string[] choices9 = { "Create some Iron Armor.", "Mine some ore from the nearby vein and " +
					"create armor with that.", "Ignore it, and continue on." };
			string[] choices10 = { "Walk across the rocks.", "Take off your armor and attempt to walk across" +
					" the rocks.", "Run across the rocks." };
			string[] choices11 = { "Take the ring, of course!", "Leave the ring right where it is.", "Reminisce about" +
					" the time you bought the princess an engagement ring." };
			string[] choices12 = { "Inspect the banana peel.", "Walk around the banana peel and continue on.", 
					"Pick it up, who would dare to litter so far into this cave?" };
			string[] choices13 = { "Swim across the water to the other side.", "Use your armor as a weight" +
					" to walk to the bottom of the pool of water.", "Take your armor off and swim to the other side."};
			string[] choices14 = { "Turn around and go another way.", "Feel you hand across the dead end wall.", 
					"Draw your sword and turn around very slowly." };
			string[] choices15 = { "Burn the cobwebs with your torch.", "Slash through the cobwebs to continue.", 
					"Use fire magic to burn the cobwebs." };

			int num = new Random().Next(1, 15);
			story = stories[num];

			switch(num)
            {
				case 0:
					choice1 = choices1[0];
					choice2 = choices1[1];
					choice3 = choices1[2];
					storynum = num;
					break;
				case 1:
					choice1 = choices2[0];
					choice2 = choices2[1];
					choice3 = choices2[2];
					switch (choice2enemy)
                    {
						case "a Dragon":
							storynum = 21;
							break;
						case "a Bear":
							storynum = 22;
							break;
						case "a Giant Toad":
							storynum = 23;
							break;
						case "a Spider":
							storynum = 24;
							break;
						case "some Bees":
							storynum = 25;
							break;
					}
					break;
				case 2:
					choice1 = choices3[0];
					choice2 = choices3[1];
					choice3 = choices3[2];
					switch (choice3enemy)
					{
						case "a Dragon":
							storynum = 21;
							break;
						case "a Bear":
							storynum = 22;
							break;
						case "a Giant Toad":
							storynum = 23;
							break;
						case "a Spider":
							storynum = 24;
							break;
						case "some Bees":
							storynum = 25;
							break;
					}
					break;
				case 3:
					choice1 = choices4[0];
					choice2 = choices4[1];
					choice3 = choices4[2];
					switch (choice4enemy)
					{
						case "a Dragon":
							storynum = 21;
							break;
						case "a Bear":
							storynum = 22;
							break;
						case "a Giant Toad":
							storynum = 23;
							break;
						case "a Spider":
							storynum = 24;
							break;
						case "some Bees":
							storynum = 25;
							break;
					}
					break;
				case 4:
					choice1 = choices5[0];
					choice2 = choices5[1];
					choice3 = choices5[2];
					storynum = num;
					break;
				case 5:
					choice1 = choices6[0];
					choice2 = choices6[1];
					choice3 = choices6[2];
					storynum = num;
					break;
				case 6:
					choice1 = choices7[0];
					choice2 = choices7[1];
					choice3 = choices7[2];
					storynum = num;
					break;
				case 7:
					choice1 = choices8[0];
					choice2 = choices8[1];
					choice3 = choices8[2];
					storynum = num;
					break;
				case 8:
					choice1 = choices9[0];
					choice2 = choices9[1];
					choice3 = choices9[2];
					storynum = num;
					break;
				case 9:
					choice1 = choices10[0];
					choice2 = choices10[1];
					choice3 = choices10[2];
					storynum = num;
					break;
				case 10:
					choice1 = choices11[0];
					choice2 = choices11[1];
					choice3 = choices11[2];
					storynum = num;
					break;
				case 11:
					choice1 = choices12[0];
					choice2 = choices12[1];
					choice3 = choices12[2];
					storynum = num;
					break;
				case 12:
					choice1 = choices13[0];
					choice2 = choices13[1];
					choice3 = choices13[2];
					storynum = num;
					break;
				case 13:
					choice1 = choices14[0];
					choice2 = choices14[1];
					choice3 = choices14[2];
					storynum = num;
					break;
				case 14:
					choice1 = choices15[0];
					choice2 = choices15[1];
					choice3 = choices15[2];
					storynum = num;
					break;
			}
		}
	}
}
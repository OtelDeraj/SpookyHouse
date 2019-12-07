using System;

namespace cs_zayzkitch {
    class Game {
        void executeStep(string prompt, string branchOne, string branchTwo, Action functionOne, Action functionTwo){
            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            if (choice.ToLower().Equals(branchOne)){
                functionOne();
            }
            else if(choice.ToLower().Equals(branchTwo)){
                functionTwo();
            }
            else {
                Console.WriteLine("INVALID CHOICE, TRY AGAIN!");
                executeStep(prompt, branchOne, branchTwo, functionOne, functionTwo);
            }
        }
        void executeStep(string prompt, string branchOne, string branchTwo, string branchTrois, Action functionOne, Action functionTwo, Action functionTrois){
            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            if (choice.ToLower().Equals(branchOne)){
                functionOne();
            }
            else if(choice.ToLower().Equals(branchTwo)){
                functionTwo();
            }
            else if(choice.ToLower().Equals(branchTrois)){
                functionTrois();
            }
            else {
                Console.WriteLine("INVALID CHOICE, TRY AGAIN!");
                executeStep(prompt, branchOne, branchTwo, branchTrois, functionOne, functionTwo, functionTrois);
            }
        }
        public void gameStart(){
            string prompt="You come the the precipice of destiny, along a cement paved path of doubt and terror. Everyone in town knows the story of this old, rundown hovel. The masterson house has no shortage of demons from its tenure at the dead end of Willowbrook Drive. It's been 8 years since Gilroy Mathis disappeared. Everyone says he was probably abducted, or maybe he skipped town, but you know the truth. Gil was taken not by some drifter or pack of nomads, but by the very evil that lives in this house. As your gaze rises along the hewn cement, overgrown with weeds, you lock eyes with the door's knocker. A face, appearing sad, with deep, empty sockets where eyes should be. The sight of it sends a chill down your spine, and as you hold your hand out, suspended in front fo you, you know this is the point of no return. Do you KNOCK or TURN AWAY? This penultimate choice, is yours.";
            string branchOne="knock";
            string branchTwo="turn away";
            executeStep(prompt, branchOne, branchTwo, knock, turnaway);
        }
        void gameEnd(){
            Console.WriteLine("GAME OVER");
            Environment.Exit(0);
        }
        void knock(){
            string prompt="As your hand rests upon the copper doorknock, you feel an energy that makes your hairs stand on end. You feel the desperate tug of fear on your shoulder, pulling you away from what will most certainly be your end. Nevertheless, with determined mind and a sure heart, the your hand grips tighter as you lift the knob and bring is crashing back into the door. KNOCK... KNOCK... KNOCK. You can hear the result of your effort echoing through the ramshackle walls, creating a small rumble of creaking wood and jittering window panes. \n After a moment the whole world falls silent, without the whistle of wind or the sound of birds. The emptiness of it all weighs on your shoulders as if gravity itself were trying to stop you from continuing your trial. All of a sudden the emptiness is lifted by the chilling sound of the door, slowly swinging open to reveal an abyss of darkness before you. And though your Feet say to run you take your first steps into this dank and cursed place. As your eyes adjust the the darkness around you, a room is revealed. Paintings of cold faced men in military dress hand throughout the hallway, all off level and worn by time. In front of you is a grand STAIRWAY. There are also two doorways to the LEFT or RIGHT of you.";
            string branchOne="staircase";
            string branchTwo="left door";
            string branchTrois="right door";
            executeStep(prompt, branchOne, branchTwo, branchTrois, staircase, leftDoor, rightDoor);
        }
        void turnaway(){
            string prompt="Quaking with anxiety and full of cowardice, you decide to abandon your friend Gil to whatever fate has befallen him. No sense in sticking out your neck for some dead kid, right? As you turn to walk away, you trip on a protruding section of cement, and, with a swift ninety degree plummet you meet your untimely end in most embarassing fashion. Thus ends your all to brief and miserable journey. Would you like to take another crack at it, sport?";
            string branchOne= "yes";
            string branchTwo= "no";
            executeStep(prompt, branchOne, branchTwo, gameStart, gameEnd);
        }
        void staircase(){
            Console.WriteLine("staircase.");
        }
        void leftDoor(){
            Console.WriteLine("left door");
        }
        void rightDoor(){
            Console.WriteLine("right door");
        }
    }
}
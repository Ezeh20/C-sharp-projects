﻿using System.Collections.Generic;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "?";
            animalPhysicalDescription =
                "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription =
                "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
    readResult = Console.ReadLine();
    Console.WriteLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }
    switch (menuSelection)
    {
        case "1":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            /**
          - to add a new animal friend to the array, we need to know how many we have now because there is a limit
            to what we can hold
          - we need a parent while loop keeps asking the user if the want to add another animal as long as we have not hit the max count and the user picks y
          - we nned a loop that ask for values to fill in the 6 attribute an animal firend should have
          - increase the total number
          */
            int petCount = 0;
            string addPet = "y";
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }
            if (maxPets > petCount)
            {
                Console.WriteLine(
                    $"\nWe have {petCount} ready to be your friend and we have room for {maxPets - petCount}\n"
                );
            }

            //parent loop that resides over the user's loop entery
            while (addPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                //first loop to take pet animalSpecies
                do
                {
                    Console.WriteLine("\nEnter pet category to continue 'dog' or 'cat' ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if ((animalSpecies != "dog") && (animalSpecies != "cat"))
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                //dynamically set the petID by using the first letter of the pet + the (petCount + 1)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1);
                do
                {
                    int petAge;
                    Console.WriteLine("\nEnter pet age use '?' if unknown");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                do
                {
                    Console.WriteLine("\ngive a physical description of the animal (optional)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                do
                {
                    Console.WriteLine(
                        "\nsay something about the personality of the animal (optional)"
                    );
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                do
                {
                    Console.WriteLine("\ngive the pet a nickname (optional)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount += 1;

                if (petCount < maxPets)
                {
                    do
                    {
                        Console.WriteLine("\ndo you want to add another pet (y/n)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            addPet = readResult.ToLower();
                        }
                    } while (addPet != "y" && addPet != "n");
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine("We have hit our maximum pet collection limit");
                    Console.WriteLine("press enter to continue");
                    readResult = Console.ReadLine();
                }
            }
            break;
        case "3":
            for (int i = 0; i < maxPets; i++)
            {
                int validAge;
                bool validEntry;
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    validEntry = int.TryParse(ourAnimals[i, 2][5].ToString(), out validAge);

                    if (!validEntry)
                    {
                        do
                        {
                            Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalAge = readResult;
                                validEntry = int.TryParse(animalAge, out validAge);
                                if (validEntry)
                                {
                                    ourAnimals[i, 2] = "Age: " + validAge;
                                }
                            }
                        } while (validEntry == false);
                    }

                    if (ourAnimals[i, 4].Length < 23)
                    {
                        bool validDes = false;
                        do
                        {
                            Console.WriteLine(
                                $"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken"
                            );
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult.ToLower();
                                if (animalPhysicalDescription.Trim().Length >= 1)
                                {
                                    validDes = true;
                                    ourAnimals[i, 4] =
                                        "Physical description: " + animalPhysicalDescription.Trim();
                                }
                            }
                        } while (validDes == false);
                    }
                }
            }
            //confrim
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine($"{ourAnimals[i, j]}");
                    }
                Console.WriteLine();
            }

            Console.WriteLine(
                "Age and physical description fields are complete for all of our friends.\nPress the Enter key to continue"
            );
            readResult = Console.ReadLine();
            break;
        case "4":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3].Length == 10)
                    {
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine($"\nEnter a nickname for {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalNickname = readResult.Trim().ToLower();
                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                                validEntry = true;
                            }
                            else
                            {
                                validEntry = false;
                            }
                        } while (validEntry == false);
                    }

                    if (ourAnimals[i, 5].Length == 13)
                    {
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine(
                                $"\nEnter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)"
                            );
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.Trim().ToLower();
                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                                validEntry = true;
                            }
                            else
                            {
                                validEntry = false;
                            }
                        } while (validEntry == false);
                    }
                }
            }
            Console.WriteLine(
                "Nickname and personality description fields are complete for all of our friends.\nPress the Enter key to continue"
            );
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }
} while (menuSelection != "exit");

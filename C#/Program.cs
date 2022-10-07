// Definerer diverse variabler som skal brukes senere i koden.
bool running = true;
string user_input1 = "";
string user_input2 = "";
string user_input3 = "";
int user_hp = 3;
int bot_input = 0;
int bot_hp = 3;
Random rnd = new Random();
int goat_loc = rnd.Next(0, 4);
int price_location = rnd.Next(0, 4);

// Programmet gjentar seg så lenge man ikke gir kommandoen 'exit'.
while (running == true) {
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Hello and welcome to this program.");
    Console.WriteLine("To use this program, please issue valid commands to the program.");
    Console.WriteLine("To see valid commands, issue the command 'help'.");

    // Leser input til brukeren og finner det man leter etter.
    user_input1 = Console.ReadLine();
    if (user_input1.ToLower() == "help") {  // Hjelp kommandoen viser fram alle gyldige kommandoer.
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Command issued : help");
        Console.WriteLine("help ------- see valid commands.");
        Console.WriteLine("calculator - opens the calculator.");
        Console.WriteLine("games ------ shows available games.");
        Console.WriteLine("random ----- shows random trivia.");
        Console.WriteLine("exit ------- closes the current program");

    } else if (user_input1.ToLower() == "calculator") { // Kalkulator kommandoen opner et nytt program med evnen til å regne ut med to verdier.
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Command issued : calculator");
        Console.WriteLine("Welcome to the calculator");
        Console.WriteLine("To use the calculator, choose an operator :"); 
        Console.WriteLine("Add, Sub, Mul, Div, Pow, Sqr");
        user_input1 = Console.ReadLine();

        if (user_input1.ToLower() == "add") {   // Legger til de to tallene som er gitt.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : add");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "0";
            }
            Console.WriteLine("Input number 2 :");
            user_input3 = Console.ReadLine();
            if (user_input3 is string) {
                user_input3 = "0";
            }

            int number1 = Int32.Parse(user_input2);
            int number2 = Int32.Parse(user_input3);
            int user_output = number1 + number2;
            Console.WriteLine("Output : " + user_output);

        } else if (user_input1.ToLower() == "sub") {    // Trekker fra det første talled med det andre.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : sub");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "1";
            }
            Console.WriteLine("Input number 2 :");
            user_input3 = Console.ReadLine();
            if (user_input3 is string) {
                user_input3 = "1";
            }

            int number1 = Int32.Parse(user_input2);
            int number2 = Int32.Parse(user_input3);
            int user_output = number1 - number2;
            Console.WriteLine("Output : " + user_output);   

        } else if (user_input1.ToLower() == "mul") {    // Ganger det første tallet med det andre.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : mul");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "1";
            }
            Console.WriteLine("Input number 2 :");
            user_input3 = Console.ReadLine();
            if (user_input3 is string) {
                user_input3 = "0";
            }

            int number1 = Int32.Parse(user_input2);
            int number2 = Int32.Parse(user_input3);
            int user_output = number1 * number2;
            Console.WriteLine("Output : " + user_output);

        } else if (user_input1.ToLower() == "div") {    // Deler det første tallet på det andre.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : div");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "1";
            }
            Console.WriteLine("Input number 2 :");
            user_input3 = Console.ReadLine();
            if (user_input3 is string) {
                user_input3 = "1";
            }

            int number1 = Int32.Parse(user_input2);
            int number2 = Int32.Parse(user_input3);
            int user_output = number1 / number2;
            Console.WriteLine("Output : " + user_output);

        } else if (user_input1.ToLower() == "pow") {    // Regner ut det første tallet opphøyd i det andre tallet.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : pow");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "1";
            }
            Console.WriteLine("Input number 2 :");
            user_input3 = Console.ReadLine();
            if (user_input3 is string) {
                user_input3 = "1";
            }

            int number1 = Int32.Parse(user_input2);
            int number2 = Int32.Parse(user_input3);
            double user_output = Math.Pow(number1, number2);
            Console.WriteLine("Output : " + user_output);

        } else if (user_input1.ToLower() == "sqr") {    // Regner ut kvadratroten til det første tallet.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : sqr");
            Console.WriteLine("Input number 1 :");
            user_input2 = Console.ReadLine();
            if (user_input2 is string) {
                user_input2 = "1";
            }

            int number1 = Int32.Parse(user_input2);
            Console.WriteLine("Output : " + Math.Sqrt(number1));
        }
    } else if (user_input1.ToLower() == "games") {  // Åpner et nytt vindu med spill.
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Command Issued : games");
        Console.WriteLine("Welcome to the games section, here you can choose some games from the list below.");
        Console.WriteLine("Rock, paper, scissors (rps)");
        Console.WriteLine("Guess the door (gtd)");
        user_input1 = Console.ReadLine();

        if (user_input1.ToLower() == "rps") {   // Åpner stein, saks, papir.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : rps");
            Console.WriteLine("A game of rock, paper, scissors has started!");

            while (user_hp > 0 || bot_hp > 0) { // Holder spillet gående helt til enten spilleren eller boten taper.
                Console.WriteLine("Choose rock, paper, or scissors");
                Random rnd_choice = new Random();
                bot_input = rnd_choice.Next(0, 4);
                user_input1 = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("You chose " + user_input1);

                // Finner ut hvem som vinner, boten velger stein, saks, eller papir helt tilfeldig.
                if (user_input1.ToLower() == "rock") {
                    if (bot_input == 1) {
                        Console.WriteLine("The outcome resulted in a tie!");
                    } else if (bot_input == 2) {
                        Console.WriteLine("The outcome resulted in a loss!");
                        user_hp--;
                    } else if (bot_input == 3) {
                        Console.WriteLine("The outcome resulted in a win!");
                        bot_hp--;
                    }
                } else if (user_input1.ToLower() == "paper") {
                    if (bot_input == 1) {
                        Console.WriteLine("The outcome resulted in a tie!");
                    } else if (bot_input == 2) {
                        Console.WriteLine("The outcome resulted in a loss!");
                        user_hp--;
                    } else if (bot_input == 3) {
                        Console.WriteLine("The outcome resulted in a win!");
                        bot_hp--;
                    }
                } else if (user_input1.ToLower() == "scissors") {
                    if (bot_input == 1) {
                        Console.WriteLine("The outcome resulted in a tie!");
                    } else if (bot_input == 2) {
                        Console.WriteLine("The outcome resulted in a loss!");
                        user_hp--;
                    } else if (bot_input == 3) {
                        Console.WriteLine("The outcome resulted in a win!");
                        bot_hp--;
                    }
                } else {
                    Console.WriteLine("You had a stroke while playing...");
                    break;
                }
                // Viser frem hvor mange liv du og boten har.
                Console.WriteLine("------------------------------");
                Console.WriteLine("Your HP : " + user_hp + " | Bot HP : " + bot_hp);
                Console.WriteLine("------------------------------");

                if (user_hp < 1) {  // Boten vinner hvis du går tom for liv.
                    Console.WriteLine("You lost this game of rock, paper, scissors...");
                    break;
                } else if (bot_hp < 1) {    // Du vinner hvis boten år tom for liv.
                    Console.WriteLine("You won this game of rock, paper, scissors!");
                    break;
                }
            }
        } else if (user_input1.ToLower() == "gtd") {    // Starter er spill hvor man skal gjette hvilken dør har en belønning bak.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Command issued : gtd");
            Console.WriteLine("A game of guess the door has started!");
            Console.WriteLine("Guess a door between 1 and 3");
            Random rnd_location = new Random();
            price_location = rnd_location.Next(1, 3);   // Definerer hvor belønningen ligger.
            user_input1 = Console.ReadLine();
            Console.WriteLine("You chose door number " + user_input1);
            int user_input = Int32.Parse(user_input1);  // Konverterer string til en integer.
            while (goat_loc == price_location || goat_loc == user_input) {  // Finner ut hvilken av dørene igjen ikke har en belønning bak seg.
                Random rnd_loc = new Random();
                goat_loc = rnd_loc.Next(0, 4);
            }
            Console.WriteLine("The price is not behind door number " + goat_loc);   // Gir et hint om hvor prisen kan være og om du bør skifte dør.
            Console.WriteLine("Choose a new door, or choose the same door.");
            user_input1 = Console.ReadLine();
            user_input = Int32.Parse(user_input1);  // Konverterer string til en integer.
            if (user_input == price_location) {
                Console.WriteLine("You won, the price was behind door number " + price_location);
            } else {
                Console.WriteLine("You lost, the price was behind door number " + price_location);
                Console.WriteLine("But you chose door number " + user_input1);
            }
        }

    } else if (user_input1.ToLower() == "random") { // Gir deg en tilfeldig fakta.
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Command issued : random");
        Random rnd_fact = new Random();
        int random_fact = rnd_fact.Next(0, 30);
        if (random_fact == 1) {
            Console.WriteLine("A group of pugs is called a grumble.");
        } else if (random_fact == 2) {
            Console.WriteLine("Bacon was used to make explosives during World War II.");
        } else if (random_fact == 3) {
            Console.WriteLine("According to a 2015 study, sarcasm can promote creative thinking.");
        } else if (random_fact == 4) {
            Console.WriteLine("Hippopotomonstrosesquippedaliophobia is the fear of long words.");
        } else if (random_fact == 5) {
            Console.WriteLine("The ampersand symbol is formed from the letters in et—the Latin word for 'and'.");
        } else if (random_fact == 6) {
            Console.WriteLine("The dot over your lowercase 'i' is called a tittle.");
        } else if (random_fact == 7) {
            Console.WriteLine("The original version of Monopoly was a cautionary tale against the perils of capitalism.");
        } else if (random_fact == 8) {
            Console.WriteLine("Trained pigeons can differentiate between the paintings of Pablo Picasso and Claude Monet.");
        } else if (random_fact == 9) {
            Console.WriteLine("Earmuffs were invented by a 15-year-old.");
        } else if (random_fact == 10) {
            Console.WriteLine("Danny DeVito is an experienced hairdresser.");
        } else if (random_fact == 11) {
            Console.WriteLine("Queen Elizabeth II technically owns all the dolphins in UK waters.");
        } else if (random_fact == 12) {
            Console.WriteLine("In 19th-century Ireland, jack-o'-lanterns were carved out of turnips instead of pumpkins.");
        } else if (random_fact == 13) {
            Console.WriteLine("Forrest Mars, the creator of Peanut M&M's, was allergic to peanuts.");
        } else if (random_fact == 14) {
            Console.WriteLine("There's a basketball court above the Supreme Court. It's known as the Highest Court in the Land.");
        } else if (random_fact == 15) {
            Console.WriteLine("The 1967 Outer Space Treaty forbids any nation from trying to own the Moon.");
        } else if (random_fact == 16) {
            Console.WriteLine("Before earning a living as a writer, Octavia E. Butler once worked as a potato chip inspector.");
        } else if (random_fact == 17) {
            Console.WriteLine("A group of ferrets is called a business.");
        } else if (random_fact == 18) {
            Console.WriteLine("Sea cucumbers eat with their feet.");
        } else if (random_fact == 19) {
            Console.WriteLine("George Washington was among America's largest whiskey producers.");
        } else if (random_fact == 20) {
            Console.WriteLine("Pentheraphobia is the intense and disproportionate fear of your mother-in-law.");
        } else if (random_fact == 21) {
            Console.WriteLine("The Scots have a word for that panicky hesitation you get when you can't remember someone's name: tartle.");
        } else if (random_fact == 22) {
            Console.WriteLine("By total area, Canada is the world's second largest country. Only Russia is larger.");
        } else if (random_fact == 23) {
            Console.WriteLine("Eighteen percent of Americans claim to have seen or felt the presence of a ghost.");
        } else if (random_fact == 24) {
            Console.WriteLine("According to one study, most dogs reach peak cuteness between six and eight weeks old.");
        } else if (random_fact == 25) {
            Console.WriteLine("Viking burials included board games.");
        } else if (random_fact == 26) {
            Console.WriteLine("On April 18, 1930—Good Friday—the BBC reported, 'There is no news.' Instead, they played piano music.");
        } else if (random_fact == 27) {
            Console.WriteLine("Geckos can turn the stickiness of their feet on and off at will.");
        } else if (random_fact == 28) {
            Console.WriteLine("A black cat crossing your path (from right to left) is considered good luck in Germany.");
        } else if (random_fact == 29) {
            Console.WriteLine("Chinese checkers was invented in Germany.");
        } else {
            Console.WriteLine("Ravens in captivity can learn to talk better than parrots.");
        }
    } else if (user_input1.ToLower() == "exit") {   // Avslutter programmet
        System.Environment.Exit(0);
    }
}
namespace AskQuestion {
    using System;
    using System.Collections.Generic;
    class question {
        public static int[] Next() {
            //initalising variables
            int min_number = 0;
            int max_number = 10;
            int number_of_operations = 3;
            int[] to_return = new int[3];
            Random random = new Random();

            //actual code
            to_return[0] = random.Next(min_number, max_number); // add number 1
            to_return[1] = random.Next(min_number, max_number); // add number 2
            to_return[2] = random.Next(0, number_of_operations); // add the operation
            return to_return;
        }
        public static int GetAnswer(int[] question) {
            Dictionary<int, string> operations = new Dictionary<int, string>() // dictionary of command and help for the help file
            { // {command_name_in_lowercase, command_help_to_be_output}
                {0, "+"},
                {1, "-"},
                {2, "*"}
            };
            string answer = ""; // set the value to be a string to fail the loop
            int converted_answer;
            while (!int.TryParse(answer, out converted_answer)) { //while answer is not a number, ask the question again, try convert answer(string) to converted_answer(int)
                Console.WriteLine($"What is {question[0]} {operations[question[2]]} {question[1]}?");
                answer = Console.ReadLine();
            }
            return converted_answer;// Convert.ToInt32(answer); // return the answer in int form
        }
        public static bool CorrectAnswer(int[] question, int entered_answer) {
            int answer;
            switch (question[2]){ //operation
                case 0: //add
                    answer = question[0] + question[1];
                    break;
                case 1: // subtract
                    answer = question[0] - question[1];
                    break;
                case 2: //multiply
                    answer = question[0] * question[1];
                    break;
                default:
                    answer = -1; // incase something went wrong this should never be
                    break;
            }
            if (answer == -1) {
                Console.WriteLine($"Something went wrong: 0 = '{question[0]}' 1 = '{question[1]}' 2 = '{question[2]}'");
                return false;
            }
            if (answer == entered_answer) {
                return true;
            }
            return false;
        }
    }
}
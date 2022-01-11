using System;
using File_Change;
using questions = AskQuestion.question;

class Program {
    public static void print_int_arr(int[] arr) {
        foreach (int i in arr) {
            Console.Write($" {i} ");
        }
        Console.WriteLine("");
    }

    public static void Main (string[] args) {
        const string question_path = "questions.txt";
        File_Change.FileWriter questions_file = new File_Change.FileWriter(question_path);
        // AskQuestion.question questions = new AskQuestion.question();
        int questions_to_answer = 10;
        int questions_correct = 0;

        for (int questions_answered = 0; questions_answered < questions_to_answer; questions_answered++) {
            int[] returned = questions.Next();
            int answer = questions.GetAnswer(returned);
            bool answerCorrect = questions.CorrectAnswer(returned, answer);
            Console.WriteLine(answerCorrect);
            if (answerCorrect) {questions_correct++;}
        }
        Console.WriteLine($"You got {questions_correct} out of {questions_to_answer}");

    }
}
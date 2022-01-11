using System;
using File_Change;

class Program {
  public static void Main (string[] args) {
    const string question_path = "questions.txt";
    File_Change.FileWriter questions_file = new File_Change.FileWriter(question_path);
  }
}
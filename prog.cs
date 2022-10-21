using System;
using static System.Console;

Clear();


string[] array = Array();
string[] result = FindThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] Array() {
    Write("Введите данные через пробел: ");
    return ReadLine().Split(" ");
}// метод в который поступают даные 


string[] FindThan(string[] input, int n) {
    string[] output = new string[LessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}//

int LessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}



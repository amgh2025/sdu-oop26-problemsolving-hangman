string secret="hydrochlorid";

//Console.WriteLine(secret);


bool[] guesses = new bool['z'-'a']; // false -> has not been guessed

// helpers

int char2int (char c) {
  return c-'a';
}

char int2char (int i) {
  return (char)(((int)'a')+i);
}

void print_status () {
  // guesses
  Console.Write("Guesses: ");
  for (int i=0 ; i<guesses.Length ; i++) {
    if (guesses[i]) {
      Console.Write(int2char(i));
    }
  }
    Console.WriteLine("");

    // secret
    Console.Write("Word: ");
    for (int i=0 ; i<secret.Length ; i++) {
      char c = secret[i];
      Console.Write(( guesses[char2int(c)] ? c : '*'));
    }
    Console.WriteLine("");
}



while (true)
{
    print_status();

    Console.WriteLine("Give us a guess: ");
    string? input = Console.ReadLine();
    if (input == null || input.Length != 1)
    {
        Console.WriteLine("Error: Input should be 1 long");
        continue;
    }
    //char c = input[0];
    char c = Char.ToLower(input[0]);

    if (c<'a' || c>'z') {
        Console.WriteLine("Only letters acceptable");
        continue;
      }

    Console.WriteLine(c);

    guesses[char2int(c)]=true;
}

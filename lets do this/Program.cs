while(true){
    Console.Write("Enter a string(one,two,three):");
    string input = Console.ReadLine();
    if(input == "exit")
    {
        break;
    }
    int output = 0;
    switch (input)
    {
        case "one":
            output = 1;
            break;
        case "two":
            output = 2;
            break;
        case "three":
            output = 3;
            break;
        default:
            output = 0;
            break;
    }
    Console.WriteLine(output);
}
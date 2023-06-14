Console.Write("Please, enter your programming language: ");
string progLang = Console.ReadLine().ToLower();

if (progLang == "assembly")
{
    Console.WriteLine("Wow! You program in a low-level language.");
}
else if (progLang == "c" || progLang == "c++" || progLang == "c#" || progLang == "go")
{
    Console.WriteLine("Great! You program in a C-like language.");
}
else if (progLang == "python" || progLang == "julia" || progLang == "r") 
{
    Console.WriteLine("Certainly you're a data scientist.");
}
else if (progLang == "typescript")
{
    Console.WriteLine("You're a front-end \"programmer\", nice!");
}
else if (progLang == "javascript") 
{
    Console.WriteLine("Is it really worth it?");
}
else if (progLang == "haskell" || progLang == "f#" || progLang == "ocaml") 
{
    Console.WriteLine("You program in such a exotic language.");
}
else
{
    Console.WriteLine("Bruh, just type one of the programming languages that already exist in the code.");
}
string username = "Vaeep";
string lowerUsername = username.ToLower();
string upperUsername = username.ToUpper();
string atUsername = username.Insert(0, "@");
int lenUsername = username.Length;
string subUsername = username.Substring(0, 2); // left inclusive, right not inclusive

string number = "151 125 654-23";
string replacedNumber = number.Replace(" ", ".");

Console.WriteLine("Username: " + username + Environment.NewLine +
                  "Lower Username: " + lowerUsername + Environment.NewLine +
                  "Upper Username: " + upperUsername + Environment.NewLine +
                  "At Username: " + atUsername + Environment.NewLine +
                  "Username Length: " + lenUsername + Environment.NewLine +
                  "Username Substring: " + subUsername + Environment.NewLine +
                  "Number: " + number + Environment.NewLine +
                  "Replaced Number: " + replacedNumber + Environment.NewLine);
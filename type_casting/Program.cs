double a = 3.14159;

int b = Convert.ToInt32(a);
double c = Convert.ToDouble(b);
string d = Convert.ToString(c);
char e = Convert.ToChar(d);
bool f = Convert.ToBoolean(c); // basically, if string != 0 -> f == true

Console.WriteLine("Value: " + a  + "  Type: " + a.GetType() + Environment.NewLine +
                  "Value: " + b  + "\tType: " + b.GetType() + Environment.NewLine +
                  "Value: " + c  + "\tType: " + c.GetType() + Environment.NewLine +
                  "Value: " + d  + "\tType: " + d.GetType() + Environment.NewLine +
                  "Value: " + e  + "\tType: " + e.GetType() + Environment.NewLine +
                  "Value: " + f  + "\tType: " + f.GetType() + Environment.NewLine);

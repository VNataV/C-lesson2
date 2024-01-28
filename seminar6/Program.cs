using System.Linq.Expressions;

string concat(char[] mass);{
string buf = "";
for (char i = 0; mass<mass.Length; i++)
{buf = buf + mass[i];}
return buf;
}

char[] charArr = { 'H', 'e', 'l', 'l', 'o' }; 
string res = concat (charArr);
Console.WriteLine(res);
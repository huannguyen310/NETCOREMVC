Console.WriteLine("Hello, World!");
//Khai bao bien
int a;
long b;
float c;
double d;
decimal e;
bool f;
char g;
string h;
//Gan gia tri cho bien
a = 10;
b = 100000;
c = 3.14f;
d = 3.14;
e = 10000000;
f = true;
g = 'H';
h = "Hello World";
//In ra man hinh
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
//TH chuyen doi kieu du lieu + cac phep tinh toan"
int a1, a2;
System.Console.Write(" a1 = ");
a1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" a2 = ");
a2 = Convert.ToInt32(Console.ReadLine());
int x = a1%a2;
int y = a1/a2;
System.Console.WriteLine("Hieu cua hai so: {0} - {1} = {2}", a1, a2 , a1 - a2);
System.Console.WriteLine("Tich cua hai so: {0} * {1} = {2}", a1, a2 , a1 * a2);
System.Console.WriteLine("Ket qua cua phep chia lay phan du: {0} % {1} = {2}",a1, a2, x);
System.Console.WriteLine("Ket qua cua phep chia lay phan nguyên: {0} / {1} = {2}",a1, a2, y);
//TH Cac toan tu trong C#
int b1, b2;
System.Console.Write(" b1 = ");
b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" b2 = ");
b2 = Convert.ToInt32(Console.ReadLine());
if( b1 < b2)
{
   System.Console.WriteLine("{0} nho hon {1}", b1, b2);
}else if(b1 > b2){
    System.Console.WriteLine("{0} lon hon {1}", b1, b2);
}else{
    System.Console.WriteLine("Hai so nhap vao bang nhau!");
}
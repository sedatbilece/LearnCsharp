

//implicit
int sayi = 100;

long sayi2 = sayi;


//explicit
long sayi3 = 500;
int sayi4 = (int) sayi3;


// value type => byte , int , long , decimal
// reference type =>  class , interface , delegate


int deger = 100;

object deger2 = deger;//boxing 



object deger3 = 100;

int deger4 =(int) deger3; // unboxing 



Object[] dizi = { "fatih", 5, 3.14, false, "sedat", true, 50 };

foreach(var i in dizi)
{
    if( i is string) // typeof(i) == string ?? true : false
    {
        Console.WriteLine(i);

    }
}
Console.WriteLine("********\n");

foreach (var i in dizi)
{
    var data = i as string; // typeof(i)==string ?? i : null
        Console.WriteLine(data);
}
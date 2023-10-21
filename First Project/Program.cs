//See https://aka.ms/new-console-template for more information
{
       // int j = 0;
       //for (int numbers= 0; numbers<= 100; numbers ++) {
       //     Console.WriteLine(j+=numbers);
       // }



    //int j = 0;
    //int i = 0;
    //while (i <= 100) {
    //    i++;
    //    Console.WriteLine(j+=i);
    //}

    CalculateSum();
  
Console.ReadLine();
}
   static void CalculateSum() {


    int j = 0;
    int i = 0;
    do
    {
       Console.WriteLine(j += i);
       i++;
   }
    while (i <= 100);

}

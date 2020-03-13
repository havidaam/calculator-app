using System;



class MainClass {
  public static void Main (string[] args) {
			kembali:
			Console.Clear();
            int pilihan=0;
            int a=0,b=0;
            Console.WriteLine("Aplikasi Calculator");
            Console.WriteLine( );
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine( );
            Console.WriteLine("Masukan Pilihan : ");
            pilihan= int.Parse(Console.ReadLine());

            if (pilihan==1)
            {
                Console.WriteLine("Masukan Nilai A : ");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai B : ");
                b=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pertambahan: {0}+{1}={2}", a, b, pertambahan(a,b));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==2)
            {
                Console.WriteLine("Masukan Nilai A : ");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai B : ");
                b=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pengurangan: {0}-{1}={2}", a, b, pengurangan(a,b));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==3)
            {
                Console.WriteLine("Masukan Nilai A : ");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai B : ");
                b=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil perkalian: {0}*{1}={2}", a, b, perkalian(a,b));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==4)
            {
                Console.WriteLine("Masukan Nilai A : ");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Nilai B : ");
                b=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pembagian: {0}/{1}={2}", a, b, pembagian(a,b)); 
             	Console.ReadKey(true);
				goto kembali;
            }
			else
			{
				Console.WriteLine("Maaf Pilihan anda tidak ada");
				Console.ReadKey(true);
				goto kembali;
			}
  }
  
  static int pertambahan(int a,int b)
  {
      return a+b;
      
  }
  
  static int pengurangan(int a,int b)
  {
      return a-b;
      
  }
  static int perkalian(int a,int b)
  {
      return a*b;
     
  }
  static int pembagian(int a,int b)
  {
      return a/b;
      
  }



  
}
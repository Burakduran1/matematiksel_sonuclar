// See https://aka.ms/new-console-template for more information
Console.WriteLine(48 / 6 / 4); // hepsi bölme operatörü oldugu icin soldan baslayarak sırayla islem yapılır
Console.WriteLine(24 / 3 * 2); // çarpma ve bölme operatörü bir birine denk önceliktedir , bu yuzden yine soıldan sırayla islem yapilir
Console.WriteLine(2 * 2 + 5 - 1 + 4); // öncelik çarpma işlemidir daha sonra soldan sırayla işlem yapılır
Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2); // öncelik parantez içi işlemdir daha sonra çarpma ya da bölme işlemi yapılır,ardından toplama çıkarma işlemi yapılır
float islem = (5 - 1) * 2 - 1 + 7 * 7 / 2f; // öncelik parantez içi işlemdir daha sonra çarpma ya da bölme işlemi yapılır,ardından toplama çıkarma işlemi yapılır
Console.WriteLine((islem));

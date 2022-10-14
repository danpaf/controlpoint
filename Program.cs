  using ControlPoint;

  class Tovar
    {
        public string name;
        public int cena;
        public Tovar(Tovar T1)
        {
            this.name = T1.name;
            this.cena = T1.cena;
        }
        public Tovar(string NameTov, int CenaTov)
        {
            name = NameTov;
            cena = CenaTov;
        }
    }
    class Magazin<T> where T : Tovar
    {
        public T Tovar;
        public int kol;
        public Magazin(Tovar T2, int KolTov)
        {
            Tovar T1 = new Tovar(T2);
            kol = KolTov;
        }
    }




  class Program
  {
      static void Main(string[] args)
      {
          //void P<T,T1>(T a, T1 b)
          //{
          //    Console.WriteLine($"{a} и {b}");
          //}
          //P(2, 3);
          //P(2.4, 3.3);
          //P(123, "dfg");
          Tovar[] MassTov = new Tovar[2];
          for (int i = 0; i < 2; i++)
          {
              Console.WriteLine("введите имя товара");
              string NameTov = Console.ReadLine();
              Console.WriteLine("введите цену товара");
              int CenaTov = Convert.ToInt32(Console.ReadLine());
              MassTov[i] = new Tovar(NameTov, CenaTov);
          }

          Console.WriteLine("список товаров");
          Console.WriteLine($" {MassTov[0].name}  {MassTov[0].cena}   ");
          Console.WriteLine($" {MassTov[1].name}  {MassTov[1].cena}   ");
          Magazin<Tovar>[] Mass = new Magazin<Tovar>[2];



          for (int i = 0; i < 2; i++)
          {
              Console.WriteLine($"введите номер товара 1 - {MassTov[0].name} 2 - {MassTov[1].name}");
              int NomTov = Convert.ToInt32(Console.ReadLine());
              if (NomTov == 1)
              {
                  Console.WriteLine("введите кол-во товаров");
                  int KolTov = Convert.ToInt32(Console.ReadLine());
                  Mass[i] = new Magazin<Tovar>(MassTov[0], KolTov);
                  Mass[i].Tovar = new Tovar(MassTov[0]);
              }
              else
              {
                  Console.WriteLine("введите кол-во товаров");
                  int KolTov = Convert.ToInt32(Console.ReadLine());
                  Mass[i] = new Magazin<Tovar>(MassTov[1], KolTov);
                  Mass[i].Tovar = new Tovar(MassTov[1]);
              }




          }

          Console.WriteLine("список товаров в магазине");
          Console.WriteLine($" {Mass[0].Tovar.name}  {Mass[0].Tovar.cena}   {Mass[0].kol}");
          Console.WriteLine($" {Mass[1].Tovar.name}   {Mass[1].Tovar.cena}   {Mass[1].kol}");

          string FIO;
          int Age;
          Console.WriteLine("Фио покупателя");
          FIO = Console.ReadLine();
          Console.WriteLine("Возраст покупателя");
          Age = Convert.ToInt32(Console.ReadLine());
          Person A = new Person(FIO, Age,0);
          

          Console.WriteLine("список товаров в магазине");
          Console.WriteLine($" {Mass[0].Tovar.name}  {Mass[0].Tovar.cena}   {Mass[0].kol}");
          Console.WriteLine($" {Mass[1].Tovar.name}   {Mass[1].Tovar.cena}   {Mass[1].kol}");
          for (int i = 0; i < 2; i++)
          {
              Console.WriteLine($"введите номер товара 1 - {MassTov[0].name} 2 - {MassTov[1].name}");
              int NomTov1 = Convert.ToInt32(Console.ReadLine());
              if (NomTov1 == 1)
              {
                  if (A.Age>= 13 && Age <= 18)
                  {
                      // скидка
                      double cena;
                      cena = Mass[0].Tovar.cena - (Mass[0].Tovar.cena * 0.2);
                      Console.WriteLine($"{MassTov[0].name} куплен за {cena} " +
                                        $"\nТовар купил: {FIO}" +
                                        $"\nВозраст покупателя:{Age}" +
                                        $"\nID: {A.ID}");
                     
                  }
                  
              }
              else
              {
                  double cena2;
                  cena2 = Mass[1].Tovar.cena - (Mass[1].Tovar.cena * 0.2);
                  Console.WriteLine($"{MassTov[1].name} куплен за {cena2} " +
                                    $"\nТовар купил: {FIO}" +
                                    $"\nВозраст покупателя:{Age}");
                  
                  
                  
              }
//Создание персонажей
              Console.WriteLine("Добавим ли покупателей?");
              string o = Console.ReadLine();
              if(o=="yes")
              {
                  List<Person> NewBies = new List<Person>(16);
                  Console.WriteLine("Сколько новых покупателей?");
                  int kolvo = Convert.ToInt32(Console.ReadLine());
                  for (int j=0; j<kolvo; j++)
                  {
                      
                      
                      string FIOadd;
                      int Ageadd;
                      Console.WriteLine("Фио покупателя");
                      FIOadd = Console.ReadLine();
                      Console.WriteLine("Возраст покупателя");
                      Ageadd = Convert.ToInt32(Console.ReadLine());
                      Person B = new Person(FIOadd, Ageadd,1);
                      
                      NewBies.Add(B);

                  }
                  
                  foreach (Person item in NewBies)
                  {
                      Console.WriteLine(item);
                  }
                  
                  Console.WriteLine("хочет ли?");
                  o = Console.ReadLine();
              }
              else
              {
                  
                  break;
                  
              }
              
              
              




          }
      }
  }

        
       // 1) Aynı cümleyi 10 kere yazdırır

        int i = 0;
        while (i < 10)
        {
            // karışmaması için her cümlenin başına kaçıncı olduğunu yazdırır
            Console.WriteLine($"{i + 1}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
            i++;
        }
        Console.WriteLine("\n"); // satır boşluğu bırakır


        // 2) 1 ile 20 arasındaki sayıları yazdırır

        i = 1;
        while (i <= 20)
        {
            Console.WriteLine($"i değeri: {i}");
            i++;
        }
        Console.WriteLine("\n");


        // 3) 1 ile 20 arasındaki çift sayıları yazdırır

        i = 2;
        while (i < 20)
        {
            Console.WriteLine($"i değeri: {i}");
            i += 2; // çift sayılar için her adımda 2 artırılır
        }
        Console.WriteLine("\n");

        // 4) 50 ile 150 arasındaki sayıların toplamını yazdırır

        int total = 0; // toplamı tutacak olan değişken
         i = 50;
        while (i <= 150)
        {
            total += i; // her sayı total değişkenine eklenir
          i++;
        }
        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {total}");
        Console.WriteLine("\n");


        // 5) 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı yazdırır

        int evenTotal = 0; // çift sayıların toplamı
        int oddTotal = 0; // tek sayıların toplamı
         i = 1;
        while (i <= 120)
        {
            if (i % 2 == 0)
            {
                evenTotal += i; // çift sayıları toplar
            }
            else
            {
                oddTotal += i; // tek sayıları toplar
            }
            i++;
        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenTotal}");
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddTotal}");
